using System;

namespace ConsoleApp2
{
    class Program
    {
        private static void Main(string[] args)
        {
            Radio kiuas1 = new Radio();

            // kiuas1.TulostaData();
            kiuas1.onOFF();

            
            kiuas1.TulostaData();


            Radio kosteus1 = new Radio();

            //kosteus1.TulostaData();

            
            kosteus1.TulostaData();
            kiuas1.onOFF();
           

        }
    }

}
