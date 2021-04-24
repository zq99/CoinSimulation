using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CoinSimulation
{
    /* 
     This class is used to store the history of coin flips in a simulation.
     If this is the sequence of historical flips: 
     
        HHTTTTHHTH.
     
     Then the sequence is stored as follows:
     
        2H 4T 2H 1T 1H
      
     The class FaceCount stores each value:

        FaceCount(2,"H") , FaceCount(4,"T") etc...
    */


    public class FlipHistory : IEnumerable<FlipHistory.FaceCount>
    {

        private List<FaceCount> history = new List<FaceCount>();


        public bool IsFilled()
        {
            return history.Count > 0;
        }

        public void Log(Coin.FACE face)
        {
            if (history.Count == 0)
            {
                history.Add(new FaceCount(1, face));
            }
            else
            {
                int index = history.Count - 1;
                FaceCount last = history[index];
                if (last.GetFace().Equals(face))
                {
                    last.IncrementCount();
                    history[index] = last;
                }
                else
                {
                    history.Add(new FaceCount(1, face));
                }
            }
        }

        public void Clear()
        {
            history.Clear();
        }

        public string GetFullString()
        {
            StringBuilder full = new StringBuilder();
            foreach (FaceCount faceCount in this.history)
            {
                full.Append(faceCount.GetFullString());
            }
            return full.ToString();
        }

        public string Get(int index)
        {
            if (history.Count > 0)
            {
                return history[index].ToString();
            }
            return "";
        }

        public int GetSize()
        {
            return this.history.Count;
        }

        public class FaceCount
        {
            private int count;
            private readonly Coin.FACE face;

            public FaceCount(int count, Coin.FACE face)
            {
                this.count = count;
                this.face = face;
            }

            public bool IsHeads()
            {
                return this.face == Coin.FACE.HEADS;
            }

            public void IncrementCount()
            {
                this.count++;
            }

            public int GetCount()
            {
                return this.count;
            }

            public Coin.FACE GetFace()
            {
                return this.face;
            }

            public string GetLabel()
            {
                string value = GetFace().ToString();
                return this.count + value;
            }

            public string GetFullString()
            {
                string value = GetFace().ToString();
                return value.Repeat(this.count);
            }

        }

        public void Print()
        {
            foreach (FaceCount faceCount in history)
            {
                Console.WriteLine(faceCount.GetLabel());
     
            }
        }

        public IEnumerator<FaceCount> GetEnumerator()
        {
            return history.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return history.GetEnumerator();
        }
    }
}
