﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LeagueLib
{
    public class Items
    {
        public static enum Tier
        {
            Basic,
            Advanced,
            Legendary,
            Mythical,
            Enchantment,
            Consumable,
            RengarsTrinket,
            None
        }

        // 78 items
        internal readonly static Item[] pre_items = new Item[]
        {
            new Item(3001, "Abyssal Scepter", Tier.Advanced, 980, 1708, 0f, new List<int> {1033,1033,1026}),
            new Item(3105, "Aegis of the Legion", Tier.Advanced, 820, 1330, 1100f, new List<int> {1033,1028,1006}),
            new Item(3113, "Aether Wisp", Tier.Advanced, 515, 665, 0f, new List<int> {1052}),
            new Item(1052, "Amplifying Tome", Tier.Basic, 435, 305, 0f, new List<int> {}),
            new Item(3301, "Ancient Coin", Tier.Basic, 365, 146, 0f, new List<int> {}),
            new Item(3007, "Archangel's Staff (Crystal Scar)", Tier.Legendary, 1120, 1890, 0f, new List<int> {3070, 1026}),
            new Item(3003, "Archangel's Staff", Tier.Legendary, 1120, 1890, 0f, new List<int> {3070, 1026}),
            new Item(3504, "Ardent Censer", Tier.Legendary, 550, 1540, 0f, new List<int> {3114, 3113}),
            new Item(3174, "Athene's Unholy Grail", Tier.Legendary, 880, 1820, 0f, new List<int>{3108, 3028}),
            new Item(3005, "Atma's Impaler", Tier.Legendary, 780, 1610, 0f, new List<int> {1031, 3093}),
            new Item(3093, "Avarice Blade", Tier.Advanced, 400, 320, 0f, new List<int> {1051}),
            new Item(1038, "B. F. Sword", Tier.Basic, 1550, 1085, 0f, new List<int> {}),
            new Item(3060, "Banner of Command", Tier.Legendary, 280, 2100, 0f, new List<int> {3105, 3108}),
            new Item(3102, "Banshee's Veil", Tier.Legendary, 1150, 1925, 0f, new List<int> {3211, 1028}),
            new Item(3254, "Berserker's Greaves - Enchantment: Alacrity", Tier.Enchantment, 475, 0, 0f, new List<int> {3006}),
            new Item(3251, "Berserker's Greaves - Enchantment: Captain", Tier.Enchantment, 600, 0, 0f, new List<int> {3006}),
            new Item(3253, "Berserker's Greaves - Enchantment: Distortion", Tier.Enchantment, 475, 0, 0f, new List<int> {3006}),
            new Item(3252, "Berserker's Greaves - Enchantment: Furor", Tier.Enchantment, 475, 0, 0f, new List<int> {3006}),
            new Item(3250, "Berserker's Greaves - Enchantment: Homeguard", Tier.Enchantment, 475, 0, 0f, new List<int> {3006}),
            new Item(3006, "Berserker's Greaves", Tier.Advanced, 225, 700, 0f, new List<int> {1042, 1001}),
            new Item(3144, "Bilgewater Cutlass", Tier.Legendary, 240, 980, 450f, new List<int> {1036, 1053}),
            new Item(3188, "Blackfire Torch", Tier.Legendary, 970, 1855, 0f, new List<int> {1026, 3108}),
            new Item(3153, "Blade of the Ruined King", Tier.Mythical, 900, 2240, 450f, new List<int> {3144, 1042, 1042}),
            new Item(1026, "Blasting Wand", Tier.Basic, 860, 602, 0f, new List<int> {}),
            new Item(3166, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3167, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3168, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3169, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3171, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3405, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3406, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3407, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3408, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3409, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3411, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3412, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3413, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3414, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3415, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3417, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3418, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3419, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3420, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3421, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3450, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3451, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3452, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3453, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3454, "Bonetooth Necklace", Tier.RengarsTrinket, 0, 0, 0f, new List<int> {}),
            new Item(3274, "Boots of Mobility - Enchantment: Alacrity", Tier.Enchantment, 475, 0, 0f, new List<int> {3117}),
            new Item(3271, "Boots of Mobility - Enchantment: Captain", Tier.Enchantment, 600, 0, 0f, new List<int> {3117}),
            new Item(3273, "Boots of Mobility - Enchantment: Distortion", Tier.Enchantment, 475, 0, 0f, new List<int> {3117}),
            new Item(3272, "Boots of Mobility - Enchantment: Furor", Tier.Enchantment, 475, 0, 0f, new List<int> {3117}),
            new Item(3270, "Boots of Mobility - Enchantment: Homeguard", Tier.Enchantment, 475, 0, 0f, new List<int> {3117}),
            new Item(3117, "Boots of Mobility", Tier.Enchantment, 475, 560, 0f, new List<int> {1001}),
            new Item(1001, "Boots of Speed", Tier.Basic, 325, 227, 0f, new List<int> {}),
            new Item(3284, "Boots of Swiftness - Enchantment: Alacrity", Tier.Enchantment, 475, 0, 0f, new List<int> {3009}),
            new Item(3281, "Boots of Swiftness - Enchantment: Captain", Tier.Enchantment, 600, 0, 0f, new List<int> {3009}),
            new Item(3283, "Boots of Swiftness - Enchantment: Distortion", Tier.Enchantment, 475, 0, 0f, new List<int> {3009}),
            new Item(3282, "Boots of Swiftness - Enchantment: Furor", Tier.Enchantment, 475, 0, 0f, new List<int> {3009}),
            new Item(3280, "Boots of Swiftness - Enchantment: Homeguard", Tier.Enchantment, 475, 0, 0f, new List<int> {3009}),
            new Item(3009, "Boots of Swiftness", Tier.Advanced, 675, 700, 0f, new List<int> {1001}),
            new Item(1051, "Brawler's Gloves", Tier.Basic, 400, 280, 0f, new List<int> {}),
            new Item(3010, "Catalyst the Protector", Tier.Advanced, 400, 840, 0f, new List<int> {1028, 1027}),
            new Item(1031, "Chain Vest", Tier.Basic, 750, 504, 0f, new List<int> {1029}),
            new Item(3028, "Chalice of Harmony", Tier.Advanced, 140, 700, 0f, new List<int> {1004, 1004, 1033}),
            new Item(1018, "Cloak of Agility", Tier.Basic, 730, 511, 0f, new List<int> {}),
            new Item(1029, "Cloth Armor", Tier.Basic, 300, 210, 0f, new List<int> {}),
            new Item(3801, "Crystalline Bracer", Tier.Advanced, 600, -1, 0f, new List<int> {1028, 1006}),
            new Item(2041, "Crystalline Flask", Tier.Consumable, 345, 138, 0f, new List<int> {}),
            new Item(1042, "Dagger", Tier.Basic, 450, 315, 0f, new List<int> {}),
            new Item(3128, "Deathfire Grasp", Tier.Legendary, 680, 2170, 750f, new List<int>{1058, 3108}),
            new Item(3137, "Dervish Blade", Tier.Legendary, 200, 2100, 0f, new List<int> {3140, 3101}),
            new Item(1075, "Doran's Blade (Showdown)", Tier.Basic, 440, 176, 0f, new List<int> {}),
            new Item(1055, "Doran's Blade", Tier.Basic, 440, 176, 0f, new List<int> {}),
            new Item(1076, "Doran's Ring (Snowdown)", Tier.Basic, 400, 160, 0f, new List<int> {}),
            new Item(1056, "Doran's Ring", Tier.Basic, 400, 160, 0f, new List<int> {}),
            new Item(1074, "Doran's Shield (Snowdown)", Tier.Basic, 440, 176, 0f, new List<int> {}),
            new Item(1054, "Doran's Shield", Tier.Basic, 440, 176, 0f, new List<int> {})
        };
        internal readonly static IEnumerable<Item> IEpre_items = pre_items;
        private static List<Item> items = new List<Item>(IEpre_items);

        public static Item GetItemByName(string name)
        {
            foreach (var item in items.Where(i => i.GetName().Equals(name)))
                return item;
            return null;
        }

        public static Item GetItem(int itemID)
        {
            foreach (var item in items.Where(i => i.GetID() == itemID))
                return item;
            return null;
        }

        private class Item
        {
            private readonly int itemID;
            private readonly string itemName;
            private readonly Tier itemTier;
            private readonly int priceValue;
            private readonly int sellValue;
            private readonly float itemRange;
            private readonly List<int> builtFrom;

            public Item(int itemID, string itemName, Tier itemTier, int priceValue, int sellValue, float itemRange, List<int> builtFrom)
            {
                this.itemID = itemID;
                this.itemName = itemName;
                this.itemTier = itemTier;
                this.priceValue = priceValue;
                this.sellValue = sellValue;
                this.itemRange = itemRange;
                this.builtFrom = builtFrom;
            }

            public int GetID()
            {
                return this.itemID;
            }

            public string GetName()
            {
                return this.itemName;
            }

            public Tier GetTier()
            {
                return this.itemTier;
            }

            public int GetPriceValue()
            {
                int price = this.priceValue;

                foreach(var i in builtFrom)
                    foreach(var i2 in items.Where(c => c.GetID() == i))
                        price += i2.GetPriceValue();

                return price;
            }

            public int GetSellValue()
            {
                return this.sellValue;
            }

            public float GetRange()
            {
                return this.itemRange;
            }
        }
    }
}
