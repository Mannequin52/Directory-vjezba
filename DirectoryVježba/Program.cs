using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DirectoryVježba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi putanju direktorija: ");
            string put = Console.ReadLine();

            //postoji li direktorij
            if (Directory.Exists(put))
            {
                //da- ispisujemo sve datoteke u njemu
                Console.WriteLine("Datoteke: ");
                foreach(string datoteka in Directory.GetFiles(put))
                {
                    Console.WriteLine(datoteka);
                }
            }

            //postoji li poddirektorij TEST
            string test = put + "\\TEST";

            if (!Directory.Exists(test))
            {
                Directory.CreateDirectory(test);
            }

            //ispis svih poddirektorija
            Console.WriteLine("Poddirektoriji: ");
            foreach(string podd in Directory.GetDirectories(test))
            {
                Console.WriteLine(podd);
            }

            //brisanje poddirektorija
            Directory.Delete(test);

            //ponovno ispisivanje poddirektorija
            foreach(string podd in Directory.GetDirectories(put))
            {
                Console.WriteLine(podd);
            }
            Console.ReadKey();
        }
    }
}
