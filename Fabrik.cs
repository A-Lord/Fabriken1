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
            List<string> Car = new List<string>();
            Car.Add("Car");
            Car.Add(Matrial.Plastic.ToString());
            
            _bluePrints.Add(Car);
        }
        public string CreatProduct(List<string> userMaterials)
        {
            var produkt = "";
            var produktComplexity = 0;
                foreach (var list1 in _bluePrints)
                {
                    if (list1.Except(userMaterials).Any() == false)
                    {
                        if(list1.Count > produktComplexity)
                        {
                            produkt = list1[0];
                            produktComplexity = list1.Count;
                        }
                    }
                }
            return produkt;
        }
        private string ProductMatch(string Matrial)
        {
            return Matrial;
        }
    }
}
