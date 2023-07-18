using System;

namespace lab4ex1
{
    class Program
    {
        static void Main(string[] args)

        {
           

            /*
             Un dulap are trei caracteristici : lungime, latime, inaltime. Dulapul va avea o
metoda care va calcula volumul acestuia.
Folositi o clasa care va modela un dulap.
 Clasa va avea trei campuri private intregi: lungime, latime, inaltime.
 Cele trei campuri vor fi initializate cu ajutorul constructorului
 Scrieti o metoda care va calcula volumul dulapului pe baza celor trei campuri.
Instantiati un dulap in functia Main, apelati metoda de calcul a volumului si afisati rezultatul.
             */
            Console.WriteLine("Introduceti lungimea dulapului");
            int lungime = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti latimea dulapului");
            int latime = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti inaltimea dulapului");
            int inaltime = int.Parse(Console.ReadLine());

            Dulap dulap = new Dulap(lungime, latime, inaltime);

            //Console.WriteLine($ "volumul dulapului cu lungimea " { dulap.GetLungime() " , latimea " { dulap.GetLatime()} ", inaltimea "{ dulap.GetInaltime()} " este " { dulap.GetVolume(lungime, latime, inaltime)} ) ;

            Console.Write("volumul dulapului este: ");
            Console.Write( dulap.GetVolume(lungime, latime, inaltime));
            

        }


        
    }
}
