using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    // Dylan Bausch
    internal class Supply : InvItem
    {
        public string Manufacturer { get; set; }

        public Supply() : base() { }

        public Supply(int itemNo, string description, decimal price, string manufacturer) : base(itemNo, description, price)
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
            Manufacturer = manufacturer;
        }

        public override string GetDisplayText() => $"{ItemNo}    {Manufacturer} {Description} ({Price:c})";
    }
}
