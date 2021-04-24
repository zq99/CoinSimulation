namespace CoinSimulation
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProbability = new System.Windows.Forms.TextBox();
            this.txtSimulationRuns = new System.Windows.Forms.TextBox();
            this.cboSimulationFace = new System.Windows.Forms.ComboBox();
            this.cboCoinFace = new System.Windows.Forms.ComboBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHeadsTotal = new System.Windows.Forms.Label();
            this.lblTailsTotal = new System.Windows.Forms.Label();
            this.lblHeadsTotalPercent = new System.Windows.Forms.Label();
            this.lblTailsTotalPercent = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.BtnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(50, 38);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 40;
            this.dataGridView.Size = new System.Drawing.Size(1591, 400);
            this.dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Probability";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(704, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weighted Side";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Coin Face";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(700, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Coin Flips Count";
            // 
            // txtProbability
            // 
            this.txtProbability.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtProbability.Location = new System.Drawing.Point(336, 51);
            this.txtProbability.Name = "txtProbability";
            this.txtProbability.Size = new System.Drawing.Size(271, 38);
            this.txtProbability.TabIndex = 5;
            // 
            // txtSimulationRuns
            // 
            this.txtSimulationRuns.Location = new System.Drawing.Point(956, 57);
            this.txtSimulationRuns.Name = "txtSimulationRuns";
            this.txtSimulationRuns.Size = new System.Drawing.Size(271, 38);
            this.txtSimulationRuns.TabIndex = 6;
            // 
            // cboSimulationFace
            // 
            this.cboSimulationFace.FormattingEnabled = true;
            this.cboSimulationFace.Location = new System.Drawing.Point(332, 56);
            this.cboSimulationFace.Name = "cboSimulationFace";
            this.cboSimulationFace.Size = new System.Drawing.Size(271, 39);
            this.cboSimulationFace.TabIndex = 7;
            // 
            // cboCoinFace
            // 
            this.cboCoinFace.FormattingEnabled = true;
            this.cboCoinFace.Location = new System.Drawing.Point(960, 50);
            this.cboCoinFace.Name = "cboCoinFace";
            this.cboCoinFace.Size = new System.Drawing.Size(271, 39);
            this.cboCoinFace.TabIndex = 8;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(1420, 97);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(285, 133);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHistory.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Location = new System.Drawing.Point(32, 80);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.RowTemplate.Height = 40;
            this.dataGridViewHistory.Size = new System.Drawing.Size(849, 1011);
            this.dataGridViewHistory.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(827, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tails Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Heads Total";
            // 
            // lblHeadsTotal
            // 
            this.lblHeadsTotal.AutoSize = true;
            this.lblHeadsTotal.BackColor = System.Drawing.SystemColors.Info;
            this.lblHeadsTotal.Location = new System.Drawing.Point(375, 54);
            this.lblHeadsTotal.Name = "lblHeadsTotal";
            this.lblHeadsTotal.Size = new System.Drawing.Size(31, 32);
            this.lblHeadsTotal.TabIndex = 13;
            this.lblHeadsTotal.Text = "0";
            // 
            // lblTailsTotal
            // 
            this.lblTailsTotal.AutoSize = true;
            this.lblTailsTotal.BackColor = System.Drawing.SystemColors.Info;
            this.lblTailsTotal.Location = new System.Drawing.Point(1067, 54);
            this.lblTailsTotal.Name = "lblTailsTotal";
            this.lblTailsTotal.Size = new System.Drawing.Size(31, 32);
            this.lblTailsTotal.TabIndex = 14;
            this.lblTailsTotal.Text = "0";
            // 
            // lblHeadsTotalPercent
            // 
            this.lblHeadsTotalPercent.AutoSize = true;
            this.lblHeadsTotalPercent.BackColor = System.Drawing.SystemColors.Info;
            this.lblHeadsTotalPercent.Location = new System.Drawing.Point(537, 54);
            this.lblHeadsTotalPercent.Name = "lblHeadsTotalPercent";
            this.lblHeadsTotalPercent.Size = new System.Drawing.Size(31, 32);
            this.lblHeadsTotalPercent.TabIndex = 15;
            this.lblHeadsTotalPercent.Text = "0";
            // 
            // lblTailsTotalPercent
            // 
            this.lblTailsTotalPercent.AutoSize = true;
            this.lblTailsTotalPercent.BackColor = System.Drawing.SystemColors.Info;
            this.lblTailsTotalPercent.Location = new System.Drawing.Point(1229, 54);
            this.lblTailsTotalPercent.Name = "lblTailsTotalPercent";
            this.lblTailsTotalPercent.Size = new System.Drawing.Size(31, 32);
            this.lblTailsTotalPercent.TabIndex = 16;
            this.lblTailsTotalPercent.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtProbability);
            this.panel1.Controls.Add(this.cboCoinFace);
            this.panel1.Location = new System.Drawing.Point(37, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1310, 132);
            this.panel1.TabIndex = 17;
            this.panel1.Tag = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblTailsTotalPercent);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblHeadsTotalPercent);
            this.panel2.Controls.Add(this.lblHeadsTotal);
            this.panel2.Controls.Add(this.lblTailsTotal);
            this.panel2.Location = new System.Drawing.Point(37, 525);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1696, 133);
            this.panel2.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label12.Location = new System.Drawing.Point(1317, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 32);
            this.label12.TabIndex = 18;
            this.label12.Text = "%";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label11.Location = new System.Drawing.Point(635, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 32);
            this.label11.TabIndex = 17;
            this.label11.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(37, 467);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 32);
            this.label8.TabIndex = 21;
            this.label8.Text = "Results Summary";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.dataGridView);
            this.panel3.Location = new System.Drawing.Point(37, 751);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1696, 475);
            this.panel3.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(37, 689);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(416, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Consecutive Probability Results";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.dataGridViewHistory);
            this.panel4.Location = new System.Drawing.Point(1775, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(907, 1128);
            this.panel4.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(1769, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 32);
            this.label9.TabIndex = 22;
            this.label9.Text = "Coin Flip History";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(37, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 32);
            this.label10.TabIndex = 22;
            this.label10.Text = "Configure Coin";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.txtSimulationRuns);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.cboSimulationFace);
            this.panel5.Location = new System.Drawing.Point(37, 303);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1306, 140);
            this.panel5.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(37, 250);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(303, 32);
            this.label13.TabIndex = 24;
            this.label13.Text = "Simulation Parameters";
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(1420, 315);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(285, 133);
            this.BtnReset.TabIndex = 25;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(2759, 1275);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coin Simulation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProbability;
        private System.Windows.Forms.TextBox txtSimulationRuns;
        private System.Windows.Forms.ComboBox cboSimulationFace;
        private System.Windows.Forms.ComboBox cboCoinFace;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHeadsTotal;
        private System.Windows.Forms.Label lblTailsTotal;
        private System.Windows.Forms.Label lblHeadsTotalPercent;
        private System.Windows.Forms.Label lblTailsTotalPercent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnReset;
    }
}

