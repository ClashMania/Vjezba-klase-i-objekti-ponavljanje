using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vježba_klase_i_objekti___ponavljanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stablo stablo = new Stablo();
            

          
        }

       
    }
    class Stablo
    {
        bool otpadajuListovi;
        string vrstaStabla;

        public override string ToString()
        {
            return "Stablo je " + this.vrstaStabla;
        }
        public Stablo(bool otpadajuListovi0)
        {
               this.otpadajuListovi = otpadajuListovi;
               if(otpadajuListovi)
                {
                this.vrstaStabla = "Bijelogorično";
                }
                else
                {
                this.vrstaStabla = "Crnogorično";
            
                }
        }
        
        public bool OtpadajuListovi { get => otpadajuListovi; set => otpadajuListovi=value;}
        public string vrstaStabla { get => vrstaStabla; set => vrstaStabla = value; }



    }
}
