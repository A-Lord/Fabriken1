using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabriken1
{
    public class Products
    {
        public string Name { get; set; }
        private int _plasticCost = 0;
        private int _metalCost = 0;
        private int _stoneCost = 0;
        private int _treeCost = 0;
        public Products()
        {

        }
        public Products(string stringValue, int plasticCoast,int metalCost, int stoneCost,int treeCost)
        {
            _plasticCost = plasticCoast;
            _metalCost = metalCost;
            _stoneCost = stoneCost;
            _treeCost = treeCost;
            Name = stringValue;

        }
        public (int leftOverMats,bool canCraft) ProductCost(int p,int m, int s, int t)
        {
            var leftOverMats = 0;
            bool canCraft = false;
            if (_plasticCost <= p && _metalCost <= m && _stoneCost <= s && _treeCost <= t)
            {
                leftOverMats = (p - _plasticCost) + (m - _metalCost) + (s - _stoneCost) + (t - _treeCost);
                canCraft = true;
            }

            return (leftOverMats,canCraft);
        }
        public int[] ReturnCost()
        {
            int[] returnAllCosts = new int[4];
            returnAllCosts[0] = _metalCost;
            returnAllCosts[1] = _plasticCost;
            returnAllCosts[2] = _treeCost;
            returnAllCosts[3] = _stoneCost;
            return returnAllCosts;
        } //sendBackMetalPlasticTreeStone
    }
}
