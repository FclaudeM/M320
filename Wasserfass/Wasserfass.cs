using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasserfass
{
    internal class Wasserfass
    {
        {
        private readonly int minimalPegel;
        private readonly int maximalPegel;
        private int füllstand;
        private readonly int kapazität;

        public Wasserfass(int minimalPegel, int maximalPegel, int kapazität)
        {
            this.minimalPegel = minimalPegel;
            this.maximalPegel = maximalPegel;
            this.kapazität = kapazität;
            this.füllstand = minimalPegel;
        }

        public int Füllstand
        {
            füllstand = füllstand + Befüllen;
            füllstand = füllstand - Entnehmen;
            return füllstand;
        }

        public int Kapazität
        {
            get { return kapazität; }
        }

        public int Befüllen(int menge)
        {
            füllstand++;
            return füllstand;
        }

        public int Entnehmen(int menge)
            {
                füllstand--;
                return füllstand;
            }

        public int Entleeren()
        {
            füllstand = minimalPegel;
                return füllstand;
        }
    }
}
}
