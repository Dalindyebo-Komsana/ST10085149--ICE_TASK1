using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10085149_ICE_TASK1
{
    class Item
    {
        public string ItemName_A { get; }
        public string ItemName_B { get; }
        public string ItemName_C { get; }
        public string ItemName_D { get; }
        public string ItemName_E { get; }


        public Item(string itemName_A, string itemName_B, string itemName_C, string itemName_D, string itemName_E)
        {

            this.ItemName_A = itemName_A;

            this.ItemName_B = itemName_B;

            this.ItemName_C = itemName_C;

            this.ItemName_D = itemName_D;

            this.ItemName_E = itemName_E;

        }
    }
}
