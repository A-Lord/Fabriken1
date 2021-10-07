using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabriken1
{
    public class Fabrik
    {

        private List<List<string>> _bluePrints = new List<List<string>>();
        public Fabrik()
        {
            List<string> IronShit = new List<string>();
            IronShit.Add("IronShit");
            IronShit.Add(Matrial.Metal.ToString());
            IronShit.Add(Matrial.Metal.ToString());
            IronShit.Add(Matrial.Metal.ToString());
            IronShit.Add(Matrial.Metal.ToString());
            IronShit.Add(Matrial.Metal.ToString());
            IronShit.Add(Matrial.Stone.ToString());
            _bluePrints.Add(IronShit);
        }
        public void CreatProduct()
        {
            foreach (var list1 in _bluePrints)
            {
               
                foreach (var element in list1)
                {
                    
                    Console.WriteLine(element);
                }

            }
        }
        private string ProductMatch(string Matrial)
        {
            return Matrial;
        }
    }
}
