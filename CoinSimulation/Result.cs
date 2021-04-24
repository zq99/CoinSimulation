using System;
using System.Collections.Generic;

namespace CoinSimulation
{
    public class Result
    {
        private IDictionary<int, int> consecutiveMap = new Dictionary<int, int>();
        private int headCount = 0;
        private int tailCount = 0;
        private readonly Coin coin;
        private readonly int sampleSize;
        private readonly Coin.FACE face;
        private FlipHistory flipHistory;
        private readonly int decimalsCount = 3;

        public enum ResultType
        {
            HEADS,
            TAILS
        }

        public int GetTailsTotal()
        {
            return this.tailCount;
        }

        public int GetHeadsTotal()
        {
            return this.headCount;
        }

        public double GetTailsPercent()
        {
            return Math.Round((double)tailCount / (double) (this.headCount + this.tailCount),decimalsCount);
        }

        public double GetHeadsPercent()
        {
            return Math.Round((double) headCount / (double)(this.headCount + this.tailCount),decimalsCount);
        }


        public FlipHistory GetFlipHistory()
        {
            return this.flipHistory;
        }


        public void AddHistory(FlipHistory flipHistory)
        {
            this.flipHistory = flipHistory;
        }

        public Result(Coin coin, int sample, Coin.FACE face) {
            this.coin = coin;
            this.sampleSize = sample;
            this.face = face;
        }

        public Coin GetCoin()
        {
            return this.coin;
        }

        public Coin.FACE getCoinFace()
        {
            return this.face;
        }


        public int GetSize()
        {
            return consecutiveMap.Count;
        }

        public int GetTotalFlips()
        {
            return this.headCount + this.tailCount;
        }

        public void AddCount(ResultType type)
        {
            this.headCount += type == ResultType.HEADS ? 1 : 0;
            this.tailCount += type == ResultType.TAILS ? 1 : 0;
        }

        public void IncrementCountsUpToValue(int consecutiveCount)
        {

            if (consecutiveCount > 0)
            {
                for (int j = 1; j <= consecutiveCount; j++)
                {
                    int total = this.consecutiveMap.ContainsKey(j) ? this.consecutiveMap[j] + 1 : 1;
                    this.consecutiveMap[j] = total;
                }
            }

        }

        public int GetTotalForCount(int index)
        {
            if (this.consecutiveMap.ContainsKey(index))
            {
                return this.consecutiveMap[index];
            }
            return 0;
        }

        public double GetExpectedProbability(int consecutiveCount)
        {
            return Math.Round(this.GetCoin().getExpectedProbability(this.getCoinFace(), consecutiveCount), decimalsCount);
        }

        public double GetActualProbability(int consecutiveCount)
        {
            int count = this.GetTotalForCount(consecutiveCount);
            return Math.Round((double)count / this.GetTotalFlips(), decimalsCount);
        }

        public double GetDiffProbability(int consecutiveCount)
        {
            return Math.Round(this.GetExpectedProbability(consecutiveCount) - this.GetActualProbability(consecutiveCount), decimalsCount);
        }

        public string GetFlipPattern(int consecutiveCount)
        {
            string f = this.getCoinFace() == Coin.FACE.HEADS ? Coin.HEAD_LABEL : Coin.TAIL_LABEL;
            return StringHelper.RepeatString(f, consecutiveCount);
        }
    }
}
