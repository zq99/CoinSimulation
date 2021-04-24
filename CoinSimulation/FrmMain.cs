using System;
using System.Threading;
using System.Windows.Forms;

namespace CoinSimulation
{
    public partial class FormMain : Form
    {
       
        public FormMain()
        {
            InitializeComponent();
        }


        private Coin.FACE GetFaceValueFromFormControl(ComboBox comboBox)
        {
            if (IsValidCoinFace(comboBox))
            {
                return comboBox.SelectedItem.ToString().Equals(Coin.FACE.HEADS.ToString()) ? Coin.FACE.HEADS : Coin.FACE.TAILS;
            }
            return Coin.FACE.UNKNOWN;
        }


        private void InitFormData()
        {
            cboCoinFace.Items.Clear();
            cboSimulationFace.Items.Clear();
            cboCoinFace.Items.Add(Coin.FACE.HEADS);
            cboCoinFace.Items.Add(Coin.FACE.TAILS);
            cboSimulationFace.Items.Add(Coin.FACE.HEADS);
            cboSimulationFace.Items.Add(Coin.FACE.TAILS);
            cboCoinFace.SelectedItem = Coin.FACE.HEADS;
            cboSimulationFace.SelectedItem = Coin.FACE.HEADS;
            txtProbability.Text = Coin.DEFAULT_PROBABILITY.ToString();
            txtSimulationRuns.Text = Simulation.SUGGESTED_SAMPLE_RUNS.ToString();
        }

        private void InitDataGrid()
        {

            string[] fields= new string[]
            {
                    "Consecutive Count",
                    "Pattern",
                    "Frequency",
                    "Expected %",
                    "Actual %",
                    "Diff %",
                };

            InitDataGridView(fields,dataGridView);

            string[] fieldsHistory = new string[]
            {
                "Order",
                "Count",
                "Face",
                "Heads Cumulative",
                "Tails Cumulative",
                "Running total",
            };

            InitDataGridView(fieldsHistory, dataGridViewHistory);

        }

        private void InitDataGridView(string[] headers, DataGridView dataGridView)
        {
            foreach (string headerText in headers)
            {
                string name = StringHelper.CleanName(headerText);
                dataGridView.Columns.Add(name, headerText);
                dataGridView.Columns[name].ReadOnly = true;
            }
        }


        private void RunSimulation()
        {
            int coinFlipsCount = Convert.ToInt32(txtSimulationRuns.Text);
            double probability = Convert.ToDouble(txtProbability.Text);

            Coin.FACE simulationface = GetFaceValueFromFormControl(cboSimulationFace);
            Coin.FACE weightedface = GetFaceValueFromFormControl(cboCoinFace);

            Coin coin = new Coin(probability, weightedface);
            Simulation simulation = new Simulation(coin, coinFlipsCount, simulationface);
            Result result = simulation.Run();
            OutputResults(result);
        }

        private void OutputResults(Result result)
        {
            Thread t1 = new Thread(() => PopulateFlipHistory(result));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();

            Thread t2 = new Thread(() => PopulateResultsGridView(result));
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();

            Thread t3 = new Thread(() => PopulateResultSummary(result));
            t3.SetApartmentState(ApartmentState.STA);
            t3.Start();

            while (t1.IsAlive || t2.IsAlive || t3.IsAlive)
            {
                Application.DoEvents();
            }
            return;
        }

        private void PopulateResultSummary(Result result)
        {
            lblHeadsTotal.Invoke((Action)delegate
            {
                lblHeadsTotal.Text = result.GetHeadsTotal().ToString();
            });
            lblTailsTotal.Invoke((Action)delegate
            {
                lblTailsTotal.Text = result.GetTailsTotal().ToString();
            });
            lblHeadsTotalPercent.Invoke((Action)delegate
            {
                lblHeadsTotalPercent.Text = result.GetHeadsPercent().ToString();
            });
            lblTailsTotalPercent.Invoke((Action)delegate
            {
                lblTailsTotalPercent.Text = result.GetTailsPercent().ToString();
            });
        }


        private void PopulateFlipHistory(Result result)
        {
            dataGridViewHistory.Invoke((Action)delegate
            {
                if (dataGridViewHistory.RowCount > 0)
                {
                    dataGridViewHistory.Rows.Clear();
                    dataGridViewHistory.Refresh();
                }
            }
            );

            if (result.GetFlipHistory().IsFilled())
            {
                FlipHistory flipHistory = result.GetFlipHistory();
                int index = 1;
                int headsCount = 0;
                int tailsCount = 0;
                int total = 0;
                foreach (FlipHistory.FaceCount faceCount in flipHistory)
                {
                    headsCount = faceCount.IsHeads() ? headsCount + faceCount.GetCount() : headsCount;
                    tailsCount = !faceCount.IsHeads() ? tailsCount + faceCount.GetCount() : tailsCount;
                    total = headsCount + tailsCount;

                    dataGridViewHistory.Invoke((Action)delegate
                    {
                        dataGridViewHistory.Rows.Add(index, faceCount.GetCount(), faceCount.GetFace(), headsCount, tailsCount, total);
                    }
                    );
                    index++;
                }
            
            }
        }

        private void PopulateResultsGridView(Result result)
        {
            dataGridView.Invoke((Action)delegate
            {
                if (dataGridView.RowCount > 0)
                {
                    dataGridView.Rows.Clear();
                    dataGridView.Refresh();
                }
            });

            for (int i = 1; i <= result.GetSize(); i++)
            {
                int count = result.GetTotalForCount(i);
                double expected = result.GetExpectedProbability(i);
                double actual = result.GetActualProbability(i);
                double diff = result.GetDiffProbability(i);
                string pattern = result.GetFlipPattern(i);
                dataGridView.Invoke((Action)delegate
                {
                    dataGridView.Rows.Add(i, pattern, count,expected,actual,diff);
                });
            }
        }


        private bool IsUserInputValid()
        {
            if (!IsCoinFlipCount(txtSimulationRuns))
            {
                string msg = $"Enter a number between {Simulation.MIN_FLIPS} and {Simulation.MAX_FLIPS}";
                MessageBox.Show(msg, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!IsValidProbability(txtProbability))
            {
                string msg = $"Enter a number between {Coin.MIN_PROBABILITY} and {Coin.MAX_PROBABILITY}";
                MessageBox.Show(msg,"Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!IsValidCoinFace(cboSimulationFace) || !IsValidCoinFace(cboCoinFace))
            {
                MessageBox.Show("Invalid face for coin specified", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private bool IsCoinFlipCount(TextBox textBox)
        {
            if (FormHelper.CheckValidNumberInput(textBox))
            {
                double value = Convert.ToDouble(textBox.Text);
                return value >= Simulation.MIN_FLIPS && value <= Simulation.MAX_FLIPS;
            }
            return false;
        }


        private bool IsValidProbability(TextBox textBox)
        {
            if (FormHelper.CheckValidNumberInput(textBox)){
                double value = Convert.ToDouble(textBox.Text);
                return value > Coin.MIN_PROBABILITY && value <= Coin.MAX_PROBABILITY;
            }
            return false;
        }

        private bool IsValidCoinFace(ComboBox comboBox)
        {
            return Coin.IsValidFaceName(comboBox.Text.ToString());
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            InitFormData();
            InitDataGrid();
        }

        private void BtnRun_Click(object sender, EventArgs e)
        {
            if (IsUserInputValid())
            {
                using (new CursorWait())
                {
                    SetButtonsEnabled(false);
                    RunSimulation();
                    SetButtonsEnabled(true);
                }
            }
        }


        private void SetButtonsEnabled(Boolean enabled)
        {
            btnRun.Enabled = enabled;
            BtnReset.Enabled = enabled;
        }


        private void BtnReset_Click(object sender, EventArgs e)
        {
            using (new CursorWait())
            {
                SetButtonsEnabled(false);
                InitFormData();
                dataGridView.Rows.Clear();
                dataGridView.Refresh();
                dataGridViewHistory.Rows.Clear();
                dataGridViewHistory.Refresh();
                SetButtonsEnabled(true);
            }
        }
    }
}
