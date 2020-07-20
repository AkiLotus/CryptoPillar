using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoPillar
{
    public class NumberDroplet
    {
        private int pillarId;
        private int value;

        public int PillarId { get => pillarId; set => pillarId = value; }
        public int Value { get => value; set => this.value = value; }

        public NumberDroplet(int pillarId, int value)
        {
            this.pillarId = pillarId;
            this.value = value;
        }
    }
}
