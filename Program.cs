using System;

namespace Fabriken1
{
    partial class Program
    {
        static void Main(string[] args)
        {
            MysteryCrafting newGame = new MysteryCrafting(20);           //Storage newStorage = new Storage(6);
            newGame.UserInterface();
            //newStorage.ShowStorage();
            //Fabrik newFabrik = new Fabrik();
            //newFabrik.CreatProduct();
            
        }
    }
    enum Matrial { Tree,Plastic,Metal,Stone }
}
