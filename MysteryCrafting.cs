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
        public MysteryCrafting(int storageSize)
        {
            mysteryStorage = new Storage(storageSize);
            Fabrik mysteryFabrik = new Fabrik();
        }
        public void UserInterface()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Your storage Contains:");
                mysteryStorage.ShowStorage();
                PrintSendingList();
                System.Console.WriteLine("Pick the materials that you want to send to the Mystery Factory:(pick the number:");
                int userChoiceInput = Int32.Parse(Console.ReadLine()) -1;
                sendToFabrik.Add(mysteryStorage.SendedMaterial(userChoiceInput));
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
