using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseIObjekti3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stablo stablo1 = new Stablo(true);
            Stablo stablo2 = new Stablo(false);

            Console.WriteLine("Stablo 1: " + stablo1.ToString());
            Console.WriteLine("Stablo 2: " + stablo2.ToString());

            Console.ReadKey();
        }
        
    }
    class Stablo
    {
        bool odpadajuListovi;
        string vrstaStabla;

        public bool OdpadajuListovi { get => odpadajuListovi; set => odpadajuListovi = value; }

        public override string ToString()
        {
            return vrstaStabla;
        }

        public Stablo()
        {

        }
        public Stablo(bool odpadajuListovi)
        {
            this.odpadajuListovi = odpadajuListovi;

            if (odpadajuListovi)
            {
                this.vrstaStabla = "Vrsta stabla je bijelogorično";
            }
            else
            {
                this.vrstaStabla = "Vrsta stabla je crnogorično";
            }
        }

    }
}
