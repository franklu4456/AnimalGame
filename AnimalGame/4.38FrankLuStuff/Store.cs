using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGame
{
    class Store
    {
        public void SetUpShop()
        {
            List<Item> availableItems = new List<Item>();

            Item atkBuff = new Item("Attack Buff", 5, 1, 10);
            availableItems.Add(atkBuff);

            Item defBuff = new Item("Defense Buff", 5, 1, 10);
            availableItems.Add(atkBuff);

            Item speedBuff = new Item("Speed Buff", 5, 1, 10);
            availableItems.Add(speedBuff);

            Item specAtkBuff = new Item("Special Attack Buff", 5, 1, 10);
            availableItems.Add(specAtkBuff);

            Item net = new Item("Net", 0, 1, 30);
            availableItems.Add(net);
        }

        public void PurchaseItem(List<Item> playerList, Item shopItem, Player player1)
        {
            if (player1.Money >= shopItem.Price)
            {
                player1.Money = player1.Money - shopItem.Price;

                playerList.Add(shopItem);
            }
            else
            {
                // Display some message?
            }
        }
    }
}
