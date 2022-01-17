namespace ConsoleApp1
{
    class Program
    {
        private static void Main(string[] args)
        {
            Kiuas kiuas1 = new Kiuas("Harvia",  0);

            // kiuas1.TulostaData();
            kiuas1.onOFF();

            kiuas1.MuokkaaLämpötilaa(80);
            kiuas1.TulostaData();

            
                Kiuas kosteus1 = new Kiuas("Harvia", 0);

                //kosteus1.TulostaData();

                kosteus1.MuokkaaLämpötilaa(5);
            kosteus1.TulostaData();
            kiuas1.onOFF();
          
        }
      }
    }

