using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10085149_ICE_TASK1
{
    class Cart
    {
        public double ItemPrice_A { get; set; }
        public double ItemPrice_B { get; set; }
        public double ItemPrice_C { get; set; }
        public double ItemPrice_D { get; set; }
        public double ItemPrice_E { get; set; }

        public double Total
        {
            get
            {
                return (this.ItemPrice_A + this.ItemPrice_B + this.ItemPrice_C + this.ItemPrice_D + this.ItemPrice_E);
            }
        }
        public double VAT
        {
            get
            {
                return (this.ItemPrice_A * 0.14 + this.ItemPrice_B * 0.14 + this.ItemPrice_C * 0.14 + this.ItemPrice_D * 0.14 + this.ItemPrice_E * 0.14);
            }
        }
        public double GrandTotal
        {
            get
            {
                return Total + VAT;
            }
        }
        public Cart(double itemPrice_A, double itemPrice_B, double itemPrice_C, double itemPrice_D, double itemPrice_E)
        {

            this.ItemPrice_A = itemPrice_A;

            this.ItemPrice_B = itemPrice_B;

            this.ItemPrice_C = itemPrice_C;

            this.ItemPrice_D = itemPrice_D;

            this.ItemPrice_E = itemPrice_E;
        }
    }
}
