﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tehtava6elain
{
    class Kissa : Elain
    {
        private static int instanssit = 0;
        public Kissa()
        {
            instanssit++;
        }

        public static new void KuinkaMonta()
        {
            Console.WriteLine("Kissoja luotu " + instanssit);
        }

        public override void Ääntele()
        {
            Console.WriteLine("Meow");
        }
    }
}
