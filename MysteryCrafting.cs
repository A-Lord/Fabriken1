using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabriken1
{
    public class MysteryCrafting
    {
        public List<string> sendToFabrik = new List<string>();
        public Storage mysteryStorage;
        public Fabrik mysteryFabrik;
        public MysteryCrafting(int storageSize)
        {
            mysteryStorage = new Storage(storageSize);
            mysteryFabrik = new Fabrik();
        }
        public void UserInterface()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Your storage Contains:");
                mysteryStorage.ShowStorage();
                PrintSendingList();
                Console.WriteLine("Pick the materials that you want to send to the Mystery Factory:\n(pick the number)");
                Console.WriteLine("");

                int userChoiceInput = Int32.Parse(Console.ReadLine());
                if (userChoiceInput == 0)
                {
                    mysteryStorage.AddProduct(mysteryFabrik.CreatProduct(sendToFabrik));
                }
                else
                {
                    sendToFabrik.Add(mysteryStorage.SendedMaterial(userChoiceInput-1));
                }

                
            }
        }
        public void PrintSendingList()
        {
            if (sendToFabrik.Count > 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Material that you are sending to the Factory:");
                foreach (var item in sendToFabrik)
                {
                    Console.WriteLine($"-{item}");
                }
                Console.WriteLine("\n");
            }
        }

    }
}
