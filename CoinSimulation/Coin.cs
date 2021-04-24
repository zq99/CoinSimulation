using System;
using System.Collections.Generic;

namespace CoinSimulation
{
    public class Coin
    {
        public enum FACE
        {
            HEADS,
            TAILS,
            UNKNOWN
        }

        private Random randomGenerator = new Random();

        private readonly double weight;
        private readonly FACE weightedSide;
        private readonly List<FACE> faces = new List<FACE>();

        public static readonly string HEAD_LABEL = "H";
        public static readonly string TAIL_LABEL = "T";

        public static readonly double DEFAULT_PROBABILITY = 0.5;
        public static readonly double MIN_PROBABILITY = 0;
        public static readonly double MAX_PROBABILITY = 1.0;
        private static readonly FACE DEFAULT_SIDE = FACE.HEADS;

        public Coin()
        {
            this.weight = DEFAULT_PROBABILITY;
            this.weightedSide = DEFAULT_SIDE;
            Init();
        }

        public Coin(double weight)
        {
            this.weight = IsValidWeight(weight) ? weight : DEFAULT_PROBABILITY;
            this.weightedSide = DEFAULT_SIDE;
            Init();
        }

        public Coin(double weight, FACE face)
        {
            this.weight = IsValidWeight(weight) ? weight : DEFAULT_PROBABILITY;
            this.weightedSide = face;
            Init();
        }

        private bool IsValidWeight(double weight)
        {
            return weight > 0 && weight <= 1;
        }

        private void Init()
        {
            double limit = Math.Round(this.weight * 100);
            FACE unbiased = this.weightedSide == FACE.HEADS ? FACE.TAILS : FACE.HEADS;
            for (int i = 1; i <= 100; i++)
            {
                faces.Add(i <= limit ? this.weightedSide : unbiased);
            }
        }

        public FACE Flip()
        {
            if (this.faces.Count == 0)
            {
                return FACE.UNKNOWN;
            }
            int index = randomGenerator.Next(0, this.faces.Count - 1);
            return this.faces[index];
        }

        public double getExpectedProbability(FACE face, int consecutiveCount)
        {
            double probability = face == this.weightedSide ? this.weight : 1 - this.weight;
            return Math.Pow(probability, consecutiveCount);
        }

        public static bool IsValidFaceName(string face)
        {
            return face.Equals(FACE.HEADS.ToString()) || face.Equals(FACE.TAILS.ToString());
        }
    }
}
