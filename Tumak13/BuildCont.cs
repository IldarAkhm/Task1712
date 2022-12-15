using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumak13
{
    internal class BuildCont
    {
        Buiding[] buidings = new Buiding[10];
        public Buiding this[int index]
        {
            get => buidings[index];
            set => buidings[index] = value;
        }
        public BuildCont(Buiding[] buidings)
        {
            this.buidings = buidings;
        }
    }
}
