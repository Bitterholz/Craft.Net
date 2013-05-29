using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Craft.Net.Anvil;

namespace Craft.Net.Logic.Items
{
    [Item(EnchantedBookItem.ItemId, EnchantedBookItem.DisplayName)]
    public static class EnchantedBookItem
    {
        public const short ItemId = 403;
        public const string DisplayName = "Enchanted Book";
    }
}
