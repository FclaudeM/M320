using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasserfass
{
    internal class Wasserfass
    {
        private readonly int minimalPegel;
        private readonly int maximalPegel;
        public int füllstand;
        private readonly int kapazität;

        public Wasserfass(int minimalPegel, int maximalPegel, int kapazität, int füllstand)
        {
            this.minimalPegel = minimalPegel;
            this.maximalPegel = maximalPegel;
            this.kapazität = kapazität;
            this.füllstand = füllstand;
        }

        public void befüllen(int menge)
        {
            if (füllstand + menge > maximalPegel)
            {
                
            }
            else
            {
                füllstand += menge;
            }
        }

        public void entnehmen(int menge)
        {
            if (füllstand - menge < minimalPegel)
            {
                füllstand = minimalPegel;
            }
            else
            {
                füllstand -= menge;
            }
        }

        public void entleeren()
        {
            füllstand = minimalPegel;
        }
    }
}
