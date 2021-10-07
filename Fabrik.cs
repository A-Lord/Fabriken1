using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabriken1
{
    public class Fabrik
    {

        private List<Products> _productsList = new List<Products>();
        public Fabrik()
        {
            var swimingpool = new Products("Swimingpool",2,1,1,0);
            var StoneTable = new Products("StoneTable", 0, 0, 2, 1);
            var car = new Products("car", 2, 2, 0, 0);
            var Computer = new Products("Computer", 3, 3, 0, 0);
            _productsList.Add(car);
            _productsList.Add(swimingpool);
            _productsList.Add(StoneTable);
            _productsList.Add(Computer);
        }
        public (string, List<string>) CreatProduct(List<string> userMaterials)
        {
            List<string> returnedMaterials = new List<string>();
            Console.WriteLine();
            var theNewProduct = "";
            var metalCount = 0;
            var plasticCount = 0;
            var treeCount = 0;
            var stoneCount = 0;
            var leftOver = 0;
            int[] sendBackMetalPlasticTreeStone = new int[4];
            int[] tempSendBackMetalPlasticTreeStone = new int[4];
            foreach (var item in userMaterials)
            {
                switch (item)
                {
                    case "Metal":
                        metalCount++;
                        break;
                    case "Plastic":
                        plasticCount++;
                        break;
                    case "Tree":
                        treeCount++;
                        break;
                    case "Stone":
                        stoneCount++;
                        break;
                    default:
                        break;
                }
            }

            sendBackMetalPlasticTreeStone[0] = metalCount;
            sendBackMetalPlasticTreeStone[1] = plasticCount;
            sendBackMetalPlasticTreeStone[2] = treeCount;
            sendBackMetalPlasticTreeStone[3] = stoneCount;

            foreach (var item in _productsList)
            {
                var testet = item.ProductCost(plasticCount, metalCount, stoneCount, treeCount);
                if (testet.Item2)
                {
                    if (leftOver < testet.Item1)
                    {
                        leftOver = testet.Item1;
                        theNewProduct = item.Name;
                        tempSendBackMetalPlasticTreeStone = item.ReturnCost();
                    }
                }
            }
            for (int i = 0; i < sendBackMetalPlasticTreeStone.Length; i++)
            {
                sendBackMetalPlasticTreeStone[i] -= tempSendBackMetalPlasticTreeStone[i];
            }
            for (int i = 0; i < sendBackMetalPlasticTreeStone[0]; i++)
            {
                returnedMaterials.Add("Metal");
            }
            for (int i = 0; i < sendBackMetalPlasticTreeStone[1]; i++)
            {
                returnedMaterials.Add("Plastic");
            }
            for (int i = 0; i < sendBackMetalPlasticTreeStone[2]; i++)
            {
                returnedMaterials.Add("Tree");
            }
            for (int i = 0; i < sendBackMetalPlasticTreeStone[3]; i++)
            {
                returnedMaterials.Add("Stone");
            }
            return (theNewProduct, returnedMaterials);

        }
        private string ProductMatch(string Matrial)
        {
            return Matrial;
        }
    }
}
