using System.Globalization;

namespace Course{
    class Program {

        //static double Pi = 3.14;
        static void Main(string[] args){

            System.Console.Write("Valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);


            System.Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        /*
        static double Circunferencia(double r){
            return 2.0 * Pi * r;
        }

        static double Volume(double r){
            return 4.0 / 3.0 * Pi * r * r * r;
        }
        */
    }
}