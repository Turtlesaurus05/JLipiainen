using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava10elaimetja
{
    internal interface icanfly
    {
        public int WingSize { get; set; }

        public void Fly();
    }
}
