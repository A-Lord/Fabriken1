using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabriken1
{
    public class Storage
    {
        
        private List<string> _IsInStorage = new List<string>();
        private List<string> _IsInStorageProducts = new List<string>();

        public void ShowStorage()
        {
            for (int i = 0; i < _IsInStorage.Count; i++)
            {
                var rightCounter = i + 1;
                Console.WriteLine($"{rightCounter}, {_IsInStorage[i]}");
            }
            Console.WriteLine("\n");
            foreach (var item in _IsInStorageProducts)
            {
                Console.WriteLine($"{item}");
            }
        }
        public Storage(int numberOfMaterials)
        {
            Random random = new Random();
            Matrial slumpen = new Matrial();
            for (int i = 0; i < numberOfMaterials; ++i)
            {
                int index = random.Next(Enum.GetNames(typeof(Matrial)).Length);
                _IsInStorage.Add(Enum.GetValues(slumpen.GetType()).GetValue(index).ToString());
            }
            _IsInStorage.Sort();
        }
        public string SendedMaterial(int userInput)
        {
            string returnMaterial = _IsInStorage[userInput];
            _IsInStorage.RemoveAt(userInput);
            return returnMaterial;


        }
        public void AddMaterials(List<string> leftOver)
        {
            _IsInStorage.AddRange(leftOver);
        }
        public void AddProduct(string produkt)
        {
            _IsInStorageProducts.Add(produkt);
        }

    }
}
