using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    // Dylan Bausch
    //
    // This class signifies inheritance by using InvItem as the base class, while adding a new Size property and overriding the
    // GetDisplayText method to include the Size property before the description.
    internal class Plant : InvItem
    {
        public string Size { get; set; }

        public Plant() : base() { }

        public Plant(int itemNo, string description, decimal price, string size) : base(itemNo, description, price)
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
            Size = size;
        }

        public override string GetDisplayText() => $"{ItemNo}    {Size} {Description} ({Price:c})";
    }
}
