namespace CoinSimulation
{
    public class Simulation
    {
        private readonly Coin coin;
        private readonly int sample;
        private readonly Coin.FACE face;
        public static readonly int SUGGESTED_SAMPLE_RUNS = 1000;
        public static readonly int MIN_FLIPS = 1;
        public static readonly int MAX_FLIPS = 100000;

        public Simulation(Coin coin, int sample, Coin.FACE face)
        {
            this.coin = coin;
            this.sample = sample;
            this.face = face;
        }


  
        public Result Run()
        {

            Result result = new Result(coin, sample, face);
            FlipHistory flipHistory = new FlipHistory();

            int consecutiveCount = 0;

            for (int i = 0; i < sample; i++)
            {
                Coin.FACE face = coin.Flip();
                flipHistory.Log(face);
                consecutiveCount = (face == this.face) ? consecutiveCount + 1 : 0;
                result.IncrementCountsUpToValue(consecutiveCount);
               
                Result.ResultType type = (face == Coin.FACE.HEADS ? Result.ResultType.HEADS : Result.ResultType.TAILS);
                result.AddCount(type);

            }
            result.AddHistory(flipHistory);
            return result;
        }

    }
}
