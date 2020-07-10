using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Item
    {
        public String Name { get; set; }
        public String ItemId { get; set; }
        public String Description { get; set; }
        public String EquipmentRarity { get; set; }
        public String CountId { get; set; }
        public String IsPotUnit { get; set; }
        public String KeyName { get; set; }
        public String ItemStack { get; set; }
        public String ItemBuyPrice { get; set; }
        public String ItemSellPrice { get; set; }
        public String ItemIdClone { get; set; }
        public String BitNumber { get; set; }

        public static readonly Item Potion = new Item { Name = "Potion", ItemId = "101000100", Description = "ポーション", EquipmentRarity = "1", CountId = "1", IsPotUnit = "1", KeyName = "6", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "101000100", BitNumber = "1"};
        public static readonly Item HiPotion = new Item { Name = "Hi-Potion", ItemId = "101000200", Description = "ハイポーション", EquipmentRarity = "3", CountId = "2", IsPotUnit = "1", KeyName = "6", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "101000200", BitNumber = "2"};
        public static readonly Item XPotion = new Item { Name = "X-Potion", ItemId = "101000300", Description = "エクスポーション", EquipmentRarity = "5", CountId = "3", IsPotUnit = "1", KeyName = "6", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "101000300", BitNumber = "3"};
        public static readonly Item Ether = new Item { Name = "Ether", ItemId = "101001100", Description = "エーテル", EquipmentRarity = "3", CountId = "4", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "101001100", BitNumber = "4"};
        public static readonly Item TurboEther = new Item { Name = "Turbo Ether", ItemId = "101001200", Description = "エーテルターボ", EquipmentRarity = "5", CountId = "5", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "101001200", BitNumber = "5"};
        public static readonly Item Elixir = new Item { Name = "Elixir", ItemId = "101002100", Description = "エリクサー", EquipmentRarity = "8", CountId = "6", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "101002100", BitNumber = "6"};
        public static readonly Item PhoenixDown = new Item { Name = "Phoenix Down", ItemId = "101003100", Description = "フェニックスの尾", EquipmentRarity = "4", CountId = "7", IsPotUnit = "1", KeyName = "6", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "101003100", BitNumber = "7"};
        public static readonly Item Antidote = new Item { Name = "Antidote", ItemId = "102000100", Description = "毒消し", EquipmentRarity = "1", CountId = "8", IsPotUnit = "2", KeyName = "2", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "102000100", BitNumber = "8"};
        public static readonly Item EyeDrops = new Item { Name = "Eye Drops", ItemId = "102001100", Description = "目薬", EquipmentRarity = "1", CountId = "9", IsPotUnit = "2", KeyName = "2", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "102001100", BitNumber = "9"};
        public static readonly Item SmellingSalts = new Item { Name = "Smelling Salts", ItemId = "102002100", Description = "気付け薬", EquipmentRarity = "2", CountId = "10", IsPotUnit = "2", KeyName = "2", ItemStack = "99", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "102002100", BitNumber = "10"};
        public static readonly Item EchoHerbs = new Item { Name = "Echo Herbs", ItemId = "102003100", Description = "やまびこ草", EquipmentRarity = "2", CountId = "11", IsPotUnit = "2", KeyName = "2", ItemStack = "99", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "102003100", BitNumber = "11"};
        public static readonly Item UnicornHorn = new Item { Name = "Unicorn Horn", ItemId = "102004100", Description = "ユニコーンの角", EquipmentRarity = "3", CountId = "12", IsPotUnit = "2", KeyName = "2", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "102004100", BitNumber = "12"};
        public static readonly Item Vaccine = new Item { Name = "Vaccine", ItemId = "102005100", Description = "ワクチン", EquipmentRarity = "5", CountId = "13", IsPotUnit = "2", KeyName = "2", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "102005100", BitNumber = "13"};
        public static readonly Item GoldNeedle = new Item { Name = "Gold Needle", ItemId = "102006100", Description = "金の針", EquipmentRarity = "3", CountId = "14", IsPotUnit = "2", KeyName = "2", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "102006100", BitNumber = "14"};
        public static readonly Item Remedy = new Item { Name = "Remedy", ItemId = "102007100", Description = "万能薬", EquipmentRarity = "4", CountId = "15", IsPotUnit = "2", KeyName = "2", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "102007100", BitNumber = "15"};
        public static readonly Item Hyper = new Item { Name = "Hyper", ItemId = "102008100", Description = "興奮剤", EquipmentRarity = "4", CountId = "16", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "102008100", BitNumber = "16"};
        public static readonly Item LightCurtain = new Item { Name = "Light Curtain", ItemId = "103000100", Description = "光のカーテン", EquipmentRarity = "6", CountId = "17", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "103000100", BitNumber = "17"};
        public static readonly Item LunarCurtain = new Item { Name = "Lunar Curtain", ItemId = "103001100", Description = "月のカーテン", EquipmentRarity = "6", CountId = "18", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "103001100", BitNumber = "18"};
        public static readonly Item HealingSpring = new Item { Name = "Healing Spring", ItemId = "103002100", Description = "回復の泉", EquipmentRarity = "4", CountId = "19", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "103002100", BitNumber = "19"};
        public static readonly Item SmokeScreen = new Item { Name = "Smoke Screen", ItemId = "103003100", Description = "煙玉", EquipmentRarity = "1", CountId = "20", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "103003100", BitNumber = "20"};
        public static readonly Item BodyBoost = new Item { Name = "Body Boost", ItemId = "103006100", Description = "力の薬", EquipmentRarity = "3", CountId = "21", IsPotUnit = "3", KeyName = "3", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "103006100", BitNumber = "23"};
        public static readonly Item ManaTablet = new Item { Name = "Mana Tablet", ItemId = "103007100", Description = "魔力の薬", EquipmentRarity = "3", CountId = "22", IsPotUnit = "3", KeyName = "3", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "103007100", BitNumber = "24"};
        public static readonly Item ProtectDrink = new Item { Name = "Protect Drink", ItemId = "103008100", Description = "プロテスドリンク", EquipmentRarity = "4", CountId = "23", IsPotUnit = "3", KeyName = "3", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "103008100", BitNumber = "25"};
        public static readonly Item ShellDrink = new Item { Name = "Shell Drink", ItemId = "103009100", Description = "シェルドリンク", EquipmentRarity = "4", CountId = "24", IsPotUnit = "3", KeyName = "3", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "103009100", BitNumber = "26"};
        public static readonly Item BacchussWine = new Item { Name = "Bacchus's Wine", ItemId = "103010100", Description = "バッカスの酒", EquipmentRarity = "3", CountId = "25", IsPotUnit = "3", KeyName = "3", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "103010100", BitNumber = "27"};
        public static readonly Item HeroDrink = new Item { Name = "Hero Drink", ItemId = "103100100", Description = "英雄の薬", EquipmentRarity = "7", CountId = "26", IsPotUnit = "3", KeyName = "3", ItemStack = "99", ItemBuyPrice = "7000", ItemSellPrice = "700", ItemIdClone = "103100100", BitNumber = "21"};
        public static readonly Item GiantsDrink = new Item { Name = "Giant's Drink", ItemId = "103101100", Description = "巨人の薬", EquipmentRarity = "7", CountId = "27", IsPotUnit = "3", KeyName = "3", ItemStack = "99", ItemBuyPrice = "7000", ItemSellPrice = "700", ItemIdClone = "103101100", BitNumber = "22"};
        public static readonly Item BombFragment = new Item { Name = "Bomb Fragment", ItemId = "104000100", Description = "ボムのかけら", EquipmentRarity = "1", CountId = "28", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "104000100", BitNumber = "28"};
        public static readonly Item BombArm = new Item { Name = "Bomb Arm", ItemId = "104000200", Description = "ボムの右腕", EquipmentRarity = "3", CountId = "29", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "104000200", BitNumber = "29"};
        public static readonly Item AntarcticWind = new Item { Name = "Antarctic Wind", ItemId = "104001100", Description = "南極の風", EquipmentRarity = "1", CountId = "30", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "104001100", BitNumber = "30"};
        public static readonly Item ArcticWind = new Item { Name = "Arctic Wind", ItemId = "104001200", Description = "北極の風", EquipmentRarity = "3", CountId = "31", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "104001200", BitNumber = "31"};
        public static readonly Item ZeussWrath = new Item { Name = "Zeus's Wrath", ItemId = "104002100", Description = "ゼウスの怒り", EquipmentRarity = "1", CountId = "32", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "104002100", BitNumber = "32"};
        public static readonly Item HeavenlyWrath = new Item { Name = "Heavenly Wrath", ItemId = "104002200", Description = "神々の怒り", EquipmentRarity = "3", CountId = "33", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "104002200", BitNumber = "33"};
        public static readonly Item FishScale = new Item { Name = "Fish Scale", ItemId = "104003100", Description = "魚のウロコ", EquipmentRarity = "1", CountId = "34", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "104003100", BitNumber = "34"};
        public static readonly Item DragonScale_104003200 = new Item { Name = "Dragon Scale", ItemId = "104003200", Description = "龍のウロコ", EquipmentRarity = "3", CountId = "35", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "104003200", BitNumber = "35"};
        public static readonly Item GiantFeather = new Item { Name = "Giant Feather", ItemId = "104004100", Description = "巨鳥の羽", EquipmentRarity = "1", CountId = "36", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "104004100", BitNumber = "36"};
        public static readonly Item WyvernFeather = new Item { Name = "Wyvern Feather", ItemId = "104004200", Description = "ワイバーンの羽", EquipmentRarity = "3", CountId = "37", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "104004200", BitNumber = "37"};
        public static readonly Item EarthDrum = new Item { Name = "Earth Drum", ItemId = "104005100", Description = "大地のドラム", EquipmentRarity = "1", CountId = "38", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "104005100", BitNumber = "38"};
        public static readonly Item GaiasCry = new Item { Name = "Gaia's Cry", ItemId = "104005200", Description = "大地のうなり", EquipmentRarity = "3", CountId = "39", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "104005200", BitNumber = "39"};
        public static readonly Item RedFang = new Item { Name = "Red Fang", ItemId = "104006100", Description = "赤い牙", EquipmentRarity = "5", CountId = "40", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "104006100", BitNumber = "40"};
        public static readonly Item WhiteFang = new Item { Name = "White Fang", ItemId = "104007100", Description = "白い牙", EquipmentRarity = "5", CountId = "41", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "104007100", BitNumber = "41"};
        public static readonly Item BlueFang = new Item { Name = "Blue Fang", ItemId = "104008100", Description = "青い牙", EquipmentRarity = "5", CountId = "42", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "104008100", BitNumber = "42"};
        public static readonly Item HolyTorch = new Item { Name = "Holy Torch", ItemId = "104009100", Description = "聖なるトーチ", EquipmentRarity = "5", CountId = "43", IsPotUnit = "3", KeyName = "1", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "104009100", BitNumber = "43"};
        public static readonly Item Grenade = new Item { Name = "Grenade", ItemId = "105000100", Description = "手榴弾", EquipmentRarity = "2", CountId = "44", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "105000100", BitNumber = "44"};
        public static readonly Item FragGrenade = new Item { Name = "Frag Grenade", ItemId = "105001100", Description = "徹甲手榴弾", EquipmentRarity = "4", CountId = "45", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "105001100", BitNumber = "45"};
        public static readonly Item Shuriken = new Item { Name = "Shuriken", ItemId = "105002100", Description = "手裏剣", EquipmentRarity = "3", CountId = "46", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "105002100", BitNumber = "46"};
        public static readonly Item FumaShuriken = new Item { Name = "Fuma Shuriken", ItemId = "105003100", Description = "風魔手裏剣", EquipmentRarity = "4", CountId = "47", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "105003100", BitNumber = "47"};
        public static readonly Item Pinwheel = new Item { Name = "Pinwheel", ItemId = "105004100", Description = "風車", EquipmentRarity = "5", CountId = "48", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "105004100", BitNumber = "48"};
        public static readonly Item Tent = new Item { Name = "Tent", ItemId = "106000100", Description = "テント", EquipmentRarity = "3", CountId = "49", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106000100", BitNumber = "49"};
        public static readonly Item MagicKey = new Item { Name = "Magic Key", ItemId = "106100100", Description = "魔法の鍵", EquipmentRarity = "8", CountId = "50", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "106100100", BitNumber = "50"};
        public static readonly Item StarQuartz = new Item { Name = "Star Quartz", ItemId = "106200100", Description = "スタークォーツ", EquipmentRarity = "8", CountId = "51", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000010", BitNumber = "165"};
        public static readonly Item MagiciteShard = new Item { Name = "Magicite Shard", ItemId = "107000100", Description = "魔石のカケラ", EquipmentRarity = "1", CountId = "52", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "107000100", BitNumber = "51"};
        public static readonly Item Magicite = new Item { Name = "Magicite", ItemId = "107000200", Description = "魔石", EquipmentRarity = "2", CountId = "53", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "107000200", BitNumber = "52"};
        public static readonly Item RedMagicite = new Item { Name = "Red Magicite", ItemId = "107001100", Description = "赤の魔石", EquipmentRarity = "3", CountId = "54", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "107001100", BitNumber = "53"};
        public static readonly Item BlueMagicite = new Item { Name = "Blue Magicite", ItemId = "107001200", Description = "青の魔石", EquipmentRarity = "3", CountId = "55", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "107001200", BitNumber = "54"};
        public static readonly Item GreenMagicite = new Item { Name = "Green Magicite", ItemId = "107001300", Description = "緑の魔石", EquipmentRarity = "3", CountId = "56", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "107001300", BitNumber = "55"};
        public static readonly Item WhiteMagicite = new Item { Name = "White Magicite", ItemId = "107001400", Description = "白の魔石", EquipmentRarity = "4", CountId = "57", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "107001400", BitNumber = "56"};
        public static readonly Item BlackMagicite = new Item { Name = "Black Magicite", ItemId = "107001500", Description = "黒の魔石", EquipmentRarity = "4", CountId = "58", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "107001500", BitNumber = "57"};
        public static readonly Item RedMegacite = new Item { Name = "Red Megacite", ItemId = "107001600", Description = "赤の大魔石", EquipmentRarity = "5", CountId = "59", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "107001600", BitNumber = "58"};
        public static readonly Item BlueMegacite = new Item { Name = "Blue Megacite", ItemId = "107001700", Description = "青の大魔石", EquipmentRarity = "5", CountId = "60", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "107001700", BitNumber = "59"};
        public static readonly Item GreenMegacite = new Item { Name = "Green Megacite", ItemId = "107001800", Description = "緑の大魔石", EquipmentRarity = "5", CountId = "61", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "107001800", BitNumber = "60"};
        public static readonly Item WhiteMegacite = new Item { Name = "White Megacite", ItemId = "107001900", Description = "白の大魔石", EquipmentRarity = "6", CountId = "62", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "107001900", BitNumber = "61"};
        public static readonly Item BlackMegacite = new Item { Name = "Black Megacite", ItemId = "107002000", Description = "黒の大魔石", EquipmentRarity = "6", CountId = "63", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "107002000", BitNumber = "62"};
        public static readonly Item EarthKey_109201000 = new Item { Name = "Earth Key #1", ItemId = "109201000", Description = "大地の鍵1", EquipmentRarity = "7", CountId = "64", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201000", BitNumber = "63"};
        public static readonly Item EarthKey_109201010 = new Item { Name = "Earth Key #2", ItemId = "109201010", Description = "大地の鍵2", EquipmentRarity = "7", CountId = "65", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201010", BitNumber = "64"};
        public static readonly Item EarthKey_109201020 = new Item { Name = "Earth Key #3", ItemId = "109201020", Description = "大地の鍵3", EquipmentRarity = "7", CountId = "66", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201020", BitNumber = "65"};
        public static readonly Item EarthKey_109201030 = new Item { Name = "Earth Key #4", ItemId = "109201030", Description = "大地の鍵4", EquipmentRarity = "7", CountId = "67", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201030", BitNumber = "66"};
        public static readonly Item EarthKey_109201040 = new Item { Name = "Earth Key #5", ItemId = "109201040", Description = "大地の鍵5", EquipmentRarity = "7", CountId = "68", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201040", BitNumber = "67"};
        public static readonly Item EarthKey_109201050 = new Item { Name = "Earth Key #6", ItemId = "109201050", Description = "大地の鍵6", EquipmentRarity = "7", CountId = "69", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201050", BitNumber = "68"};
        public static readonly Item EarthKey_109201060 = new Item { Name = "Earth Key #7", ItemId = "109201060", Description = "大地の鍵7", EquipmentRarity = "7", CountId = "70", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201060", BitNumber = "69"};
        public static readonly Item EarthKey_109201070 = new Item { Name = "Earth Key #8", ItemId = "109201070", Description = "大地の鍵8", EquipmentRarity = "7", CountId = "71", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201070", BitNumber = "70"};
        public static readonly Item EarthKey_109201080 = new Item { Name = "Earth Key #9", ItemId = "109201080", Description = "大地の鍵9", EquipmentRarity = "7", CountId = "72", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201080", BitNumber = "71"};
        public static readonly Item EarthKey_109201090 = new Item { Name = "Earth Key #10", ItemId = "109201090", Description = "大地の鍵10", EquipmentRarity = "7", CountId = "73", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201090", BitNumber = "72"};
        public static readonly Item EarthKey_109201100 = new Item { Name = "Earth Key #11", ItemId = "109201100", Description = "大地の鍵11", EquipmentRarity = "7", CountId = "74", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201100", BitNumber = "73"};
        public static readonly Item EarthKey_109201110 = new Item { Name = "Earth Key #12", ItemId = "109201110", Description = "大地の鍵12", EquipmentRarity = "7", CountId = "75", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201110", BitNumber = "74"};
        public static readonly Item EarthKey_109201120 = new Item { Name = "Earth Key #13", ItemId = "109201120", Description = "大地の鍵13", EquipmentRarity = "7", CountId = "76", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201120", BitNumber = "75"};
        public static readonly Item EarthKey_109201130 = new Item { Name = "Earth Key #14", ItemId = "109201130", Description = "大地の鍵14", EquipmentRarity = "7", CountId = "77", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201130", BitNumber = "76"};
        public static readonly Item EarthKey_109201140 = new Item { Name = "Earth Key #15", ItemId = "109201140", Description = "大地の鍵15", EquipmentRarity = "7", CountId = "78", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201140", BitNumber = "77"};
        public static readonly Item EarthKey_109201150 = new Item { Name = "Earth Key #16", ItemId = "109201150", Description = "大地の鍵16", EquipmentRarity = "7", CountId = "79", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201150", BitNumber = "78"};
        public static readonly Item EarthKey_109201160 = new Item { Name = "Earth Key #17", ItemId = "109201160", Description = "大地の鍵17", EquipmentRarity = "7", CountId = "80", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201160", BitNumber = "79"};
        public static readonly Item EarthKey_109201170 = new Item { Name = "Earth Key #18", ItemId = "109201170", Description = "大地の鍵18", EquipmentRarity = "7", CountId = "81", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201170", BitNumber = "80"};
        public static readonly Item EarthKey_109201180 = new Item { Name = "Earth Key #19", ItemId = "109201180", Description = "大地の鍵19", EquipmentRarity = "7", CountId = "82", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201180", BitNumber = "81"};
        public static readonly Item EarthKey_109201190 = new Item { Name = "Earth Key #20", ItemId = "109201190", Description = "大地の鍵20", EquipmentRarity = "7", CountId = "83", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201190", BitNumber = "82"};
        public static readonly Item EarthKey_109201200 = new Item { Name = "Earth Key #21", ItemId = "109201200", Description = "大地の鍵21", EquipmentRarity = "7", CountId = "84", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201200", BitNumber = "83"};
        public static readonly Item EarthKey_109201210 = new Item { Name = "Earth Key #22", ItemId = "109201210", Description = "大地の鍵22", EquipmentRarity = "7", CountId = "85", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201210", BitNumber = "84"};
        public static readonly Item EarthKey_109201220 = new Item { Name = "Earth Key #23", ItemId = "109201220", Description = "大地の鍵23", EquipmentRarity = "7", CountId = "86", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201220", BitNumber = "85"};
        public static readonly Item EarthKey_109201230 = new Item { Name = "Earth Key #24", ItemId = "109201230", Description = "大地の鍵24", EquipmentRarity = "7", CountId = "87", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201230", BitNumber = "86"};
        public static readonly Item EarthKey_109201240 = new Item { Name = "Earth Key #25", ItemId = "109201240", Description = "大地の鍵25", EquipmentRarity = "7", CountId = "88", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109201240", BitNumber = "87"};
        public static readonly Item FireCryst = new Item { Name = "Fire Cryst", ItemId = "201000100", Description = "火の結晶", EquipmentRarity = "1", CountId = "89", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "201000100", BitNumber = "88"};
        public static readonly Item IceCryst = new Item { Name = "Ice Cryst", ItemId = "201000200", Description = "氷の結晶", EquipmentRarity = "1", CountId = "90", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "201000200", BitNumber = "89"};
        public static readonly Item LightningCryst = new Item { Name = "Lightning Cryst", ItemId = "201000300", Description = "雷の結晶", EquipmentRarity = "1", CountId = "91", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "201000300", BitNumber = "90"};
        public static readonly Item WaterCryst = new Item { Name = "Water Cryst", ItemId = "201000400", Description = "水の結晶", EquipmentRarity = "1", CountId = "92", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "201000400", BitNumber = "91"};
        public static readonly Item EarthCryst = new Item { Name = "Earth Cryst", ItemId = "201000500", Description = "土の結晶", EquipmentRarity = "1", CountId = "93", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "201000500", BitNumber = "92"};
        public static readonly Item WindCryst = new Item { Name = "Wind Cryst", ItemId = "201000600", Description = "風の結晶", EquipmentRarity = "1", CountId = "94", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "201000600", BitNumber = "93"};
        public static readonly Item LightCryst = new Item { Name = "Light Cryst", ItemId = "201000700", Description = "光の結晶", EquipmentRarity = "2", CountId = "95", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "201000700", BitNumber = "94"};
        public static readonly Item DarkCryst = new Item { Name = "Dark Cryst", ItemId = "201000800", Description = "闇の結晶", EquipmentRarity = "2", CountId = "96", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "201000800", BitNumber = "95"};
        public static readonly Item FireMegacryst = new Item { Name = "Fire Megacryst", ItemId = "201000900", Description = "火の大結晶", EquipmentRarity = "3", CountId = "97", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "201000900", BitNumber = "96"};
        public static readonly Item IceMegacryst = new Item { Name = "Ice Megacryst", ItemId = "201001000", Description = "氷の大結晶", EquipmentRarity = "3", CountId = "98", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "201001000", BitNumber = "97"};
        public static readonly Item LightningMegacryst = new Item { Name = "Lightning Megacryst", ItemId = "201001100", Description = "雷の大結晶", EquipmentRarity = "3", CountId = "99", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "201001100", BitNumber = "98"};
        public static readonly Item WaterMegacryst = new Item { Name = "Water Megacryst", ItemId = "201001200", Description = "水の大結晶", EquipmentRarity = "3", CountId = "100", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "201001200", BitNumber = "99"};
        public static readonly Item EarthMegacryst = new Item { Name = "Earth Megacryst", ItemId = "201001300", Description = "土の大結晶", EquipmentRarity = "3", CountId = "101", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "201001300", BitNumber = "100"};
        public static readonly Item WindMegacryst = new Item { Name = "Wind Megacryst", ItemId = "201001400", Description = "風の大結晶", EquipmentRarity = "3", CountId = "102", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "201001400", BitNumber = "101"};
        public static readonly Item LightMegacryst = new Item { Name = "Light Megacryst", ItemId = "201001500", Description = "光の大結晶", EquipmentRarity = "4", CountId = "103", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "201001500", BitNumber = "102"};
        public static readonly Item DarkMegacryst = new Item { Name = "Dark Megacryst", ItemId = "201001600", Description = "闇の大結晶", EquipmentRarity = "4", CountId = "104", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "201001600", BitNumber = "103"};
        public static readonly Item LifeOrb = new Item { Name = "Life Orb", ItemId = "202000100", Description = "生命の珠", EquipmentRarity = "1", CountId = "105", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202000100", BitNumber = "104"};
        public static readonly Item FarplaneSoul = new Item { Name = "Farplane Soul", ItemId = "202000200", Description = "異界の魂", EquipmentRarity = "1", CountId = "106", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202000200", BitNumber = "105"};
        public static readonly Item GaiasTear = new Item { Name = "Gaia's Tear", ItemId = "202000300", Description = "大地の涙", EquipmentRarity = "1", CountId = "107", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202000300", BitNumber = "106"};
        public static readonly Item ThickenedHide = new Item { Name = "Thickened Hide", ItemId = "202000400", Description = "丈夫な皮", EquipmentRarity = "1", CountId = "108", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202000400", BitNumber = "107"};
        public static readonly Item RaptorFeather = new Item { Name = "Raptor Feather", ItemId = "202000500", Description = "凶鳥の羽", EquipmentRarity = "1", CountId = "109", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202000500", BitNumber = "108"};
        public static readonly Item ChromaticOoze = new Item { Name = "Chromatic Ooze", ItemId = "202000600", Description = "彩りゼリー", EquipmentRarity = "1", CountId = "110", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202000600", BitNumber = "109"};
        public static readonly Item DemonTail = new Item { Name = "Demon Tail", ItemId = "202000700", Description = "悪魔のしっぽ", EquipmentRarity = "1", CountId = "111", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202000700", BitNumber = "110"};
        public static readonly Item BrokenBlade_202000800 = new Item { Name = "Broken Blade", ItemId = "202000800", Description = "折れた刃", EquipmentRarity = "1", CountId = "112", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202000800", BitNumber = "111"};
        public static readonly Item DigitalCircuit = new Item { Name = "Digital Circuit", ItemId = "202000900", Description = "デジタル回路", EquipmentRarity = "1", CountId = "113", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202000900", BitNumber = "112"};
        public static readonly Item DragonFang = new Item { Name = "Dragon Fang", ItemId = "202001000", Description = "竜の牙", EquipmentRarity = "1", CountId = "114", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202001000", BitNumber = "113"};
        public static readonly Item Glowseeds = new Item { Name = "Glowseeds", ItemId = "202001100", Description = "光る種", EquipmentRarity = "1", CountId = "115", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202001100", BitNumber = "114"};
        public static readonly Item Spellsilk = new Item { Name = "Spellsilk", ItemId = "202001200", Description = "魔虫の糸", EquipmentRarity = "1", CountId = "116", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202001200", BitNumber = "115"};
        public static readonly Item QualityStone = new Item { Name = "Quality Stone", ItemId = "202001300", Description = "良質の石材", EquipmentRarity = "1", CountId = "117", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202001300", BitNumber = "116"};
        public static readonly Item GummyOil = new Item { Name = "Gummy Oil", ItemId = "202001400", Description = "べとつく油", EquipmentRarity = "1", CountId = "118", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202001400", BitNumber = "117"};
        public static readonly Item GreenFluid = new Item { Name = "Green Fluid", ItemId = "202001500", Description = "緑色の液体", EquipmentRarity = "1", CountId = "119", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "202001500", BitNumber = "118"};
        public static readonly Item OtherworldlyBone = new Item { Name = "Otherworldly Bone", ItemId = "202001600", Description = "魔獣の骨", EquipmentRarity = "2", CountId = "120", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202001600", BitNumber = "119"};
        public static readonly Item AbominableWing = new Item { Name = "Abominable Wing", ItemId = "202001700", Description = "怪魔の翼", EquipmentRarity = "2", CountId = "121", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202001700", BitNumber = "120"};
        public static readonly Item ToughScale = new Item { Name = "Tough Scale", ItemId = "202001800", Description = "硬い鱗", EquipmentRarity = "2", CountId = "122", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202001800", BitNumber = "121"};
        public static readonly Item CursedTusk = new Item { Name = "Cursed Tusk", ItemId = "202001900", Description = "忌まわしき牙", EquipmentRarity = "2", CountId = "123", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202001900", BitNumber = "122"};
        public static readonly Item WizardStone = new Item { Name = "Wizard Stone", ItemId = "202002000", Description = "魔導石", EquipmentRarity = "2", CountId = "124", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202002000", BitNumber = "123"};
        public static readonly Item PolymerEmulsion = new Item { Name = "Polymer Emulsion", ItemId = "202002100", Description = "高分子体", EquipmentRarity = "2", CountId = "125", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202002100", BitNumber = "124"};
        public static readonly Item DragonScale_202002200 = new Item { Name = "Dragon Scale", ItemId = "202002200", Description = "竜の鱗", EquipmentRarity = "2", CountId = "126", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202002200", BitNumber = "125"};
        public static readonly Item ElementalTear = new Item { Name = "Elemental Tear", ItemId = "202002300", Description = "精霊の涙", EquipmentRarity = "2", CountId = "127", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202002300", BitNumber = "126"};
        public static readonly Item RockbeetleHusk = new Item { Name = "Rockbeetle Husk", ItemId = "202002400", Description = "硬虫の甲殻", EquipmentRarity = "2", CountId = "128", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202002400", BitNumber = "127"};
        public static readonly Item SparklingStone = new Item { Name = "Sparkling Stone", ItemId = "202002500", Description = "輝石", EquipmentRarity = "2", CountId = "129", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202002500", BitNumber = "128"};
        public static readonly Item Screamroot = new Item { Name = "Screamroot", ItemId = "202002600", Description = "さけびの根", EquipmentRarity = "2", CountId = "130", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202002600", BitNumber = "129"};
        public static readonly Item CorpseFly = new Item { Name = "Corpse Fly", ItemId = "202002700", Description = "死虫", EquipmentRarity = "2", CountId = "131", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "202002700", BitNumber = "130"};
        public static readonly Item CopperOre = new Item { Name = "Copper Ore", ItemId = "203000100", Description = "銅鉱", EquipmentRarity = "1", CountId = "132", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "203000100", BitNumber = "131"};
        public static readonly Item IronOre = new Item { Name = "Iron Ore", ItemId = "203000200", Description = "鉄鉱", EquipmentRarity = "2", CountId = "133", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "203000200", BitNumber = "132"};
        public static readonly Item SilverOre = new Item { Name = "Silver Ore", ItemId = "203000300", Description = "銀鉱", EquipmentRarity = "3", CountId = "134", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "203000300", BitNumber = "133"};
        public static readonly Item MythrilOre = new Item { Name = "Mythril Ore", ItemId = "203000400", Description = "ミスリル鉱", EquipmentRarity = "4", CountId = "135", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "203000400", BitNumber = "134"};
        public static readonly Item Lumber = new Item { Name = "Lumber", ItemId = "204000100", Description = "木材", EquipmentRarity = "1", CountId = "136", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "204000100", BitNumber = "135"};
        public static readonly Item Alcryst = new Item { Name = "Alcryst", ItemId = "280000100", Description = "錬晶石", EquipmentRarity = "2", CountId = "137", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "280000100", BitNumber = "136"};
        public static readonly Item FineAlcryst = new Item { Name = "Fine Alcryst", ItemId = "280000200", Description = "錬晶輝石", EquipmentRarity = "5", CountId = "138", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "280000200", BitNumber = "137"};
        public static readonly Item BeastMeat = new Item { Name = "Beast Meat", ItemId = "290010000", Description = "戦獣の肉", EquipmentRarity = "2", CountId = "139", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "290010000", BitNumber = "138"};
        public static readonly Item PearlofWisdom = new Item { Name = "Pearl of Wisdom", ItemId = "290010100", Description = "知識の珠", EquipmentRarity = "2", CountId = "140", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "290010100", BitNumber = "139"};
        public static readonly Item AllurePowder = new Item { Name = "Allure Powder", ItemId = "290010200", Description = "魅惑の砂", EquipmentRarity = "2", CountId = "141", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "290010200", BitNumber = "140"};
        public static readonly Item Litrock = new Item { Name = "Litrock", ItemId = "290020000", Description = "光の石塊", EquipmentRarity = "3", CountId = "142", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "290020000", BitNumber = "141"};
        public static readonly Item SeedofLife = new Item { Name = "Seed of Life", ItemId = "290020100", Description = "生命の種", EquipmentRarity = "3", CountId = "143", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "290020100", BitNumber = "142"};
        public static readonly Item CrimsonTear = new Item { Name = "Crimson Tear", ItemId = "290020200", Description = "真紅の涙", EquipmentRarity = "3", CountId = "144", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "290020200", BitNumber = "143"};
        public static readonly Item MysticOre = new Item { Name = "Mystic Ore", ItemId = "290020300", Description = "魔原石", EquipmentRarity = "3", CountId = "145", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "290020300", BitNumber = "144"};
        public static readonly Item AquaPearl = new Item { Name = "Aqua Pearl", ItemId = "290020400", Description = "蒼い宝珠", EquipmentRarity = "3", CountId = "146", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "290020400", BitNumber = "145"};
        public static readonly Item LuminousHorn = new Item { Name = "Luminous Horn", ItemId = "290020500", Description = "燐光の角", EquipmentRarity = "3", CountId = "147", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "290020500", BitNumber = "146"};
        public static readonly Item QualityParts = new Item { Name = "Quality Parts", ItemId = "290020600", Description = "高質機素", EquipmentRarity = "3", CountId = "148", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "290020600", BitNumber = "147"};
        public static readonly Item RainbowNeedle = new Item { Name = "Rainbow Needle", ItemId = "290020700", Description = "虹色の針", EquipmentRarity = "3", CountId = "149", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "290020700", BitNumber = "148"};
        public static readonly Item GoldenEgg = new Item { Name = "Golden Egg", ItemId = "290020800", Description = "金の卵", EquipmentRarity = "3", CountId = "150", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "290020800", BitNumber = "149"};
        public static readonly Item BookofRuin = new Item { Name = "Book of Ruin", ItemId = "290020900", Description = "破滅の書", EquipmentRarity = "3", CountId = "151", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "290020900", BitNumber = "150"};
        public static readonly Item EarthsCore = new Item { Name = "Earth's Core", ItemId = "290030000", Description = "大地の凝晶", EquipmentRarity = "4", CountId = "152", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290030000", BitNumber = "151"};
        public static readonly Item HeavensAsh = new Item { Name = "Heaven's Ash", ItemId = "290030100", Description = "天空の灰", EquipmentRarity = "4", CountId = "153", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290030100", BitNumber = "152"};
        public static readonly Item DeepseaBloom = new Item { Name = "Deepsea Bloom", ItemId = "290030200", Description = "深海の魔花", EquipmentRarity = "4", CountId = "154", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290030200", BitNumber = "153"};
        public static readonly Item ScriptureofTime = new Item { Name = "Scripture of Time", ItemId = "290030300", Description = "時空の教典", EquipmentRarity = "4", CountId = "155", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290030300", BitNumber = "154"};
        public static readonly Item FarplaneDew = new Item { Name = "Farplane Dew", ItemId = "290030400", Description = "異界の雫", EquipmentRarity = "4", CountId = "156", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290030400", BitNumber = "155"};
        public static readonly Item Spiritsand = new Item { Name = "Spiritsand", ItemId = "290040000", Description = "精霊の光粉", EquipmentRarity = "5", CountId = "157", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "290040000", BitNumber = "156"};
        public static readonly Item GodsReliquary = new Item { Name = "God's Reliquary", ItemId = "290040100", Description = "神々の遺物", EquipmentRarity = "5", CountId = "158", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "290040100", BitNumber = "157"};
        public static readonly Item DragonHeart = new Item { Name = "Dragon Heart", ItemId = "290040200", Description = "大竜の心臓", EquipmentRarity = "5", CountId = "159", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "290040200", BitNumber = "158"};
        public static readonly Item EspersTear = new Item { Name = "Esper's Tear", ItemId = "290040300", Description = "幻獣の涙", EquipmentRarity = "5", CountId = "160", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "290040300", BitNumber = "159"};
        public static readonly Item TalmoniteofLife = new Item { Name = "Talmonite of Life", ItemId = "290040400", Description = "生命の魔素", EquipmentRarity = "5", CountId = "161", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "290040400", BitNumber = "160"};
        public static readonly Item EsperShard = new Item { Name = "Esper Shard", ItemId = "290050100", Description = "幻結晶の欠片", EquipmentRarity = "1", CountId = "162", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "290050100", BitNumber = "161"};
        public static readonly Item EsperCryst = new Item { Name = "Esper Cryst", ItemId = "290050200", Description = "幻結晶", EquipmentRarity = "3", CountId = "163", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "290050200", BitNumber = "162"};
        public static readonly Item SacredCrystal = new Item { Name = "Sacred Crystal", ItemId = "290050300", Description = "神結晶", EquipmentRarity = "4", CountId = "164", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290050300", BitNumber = "163"};
        public static readonly Item HolyCrystal = new Item { Name = "Holy Crystal", ItemId = "290050400", Description = "神魔結晶", EquipmentRarity = "6", CountId = "165", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "290050400", BitNumber = "164"};
        public static readonly Item YellowMagicite = new Item { Name = "Yellow Magicite", ItemId = "107002100", Description = "黄の魔石", EquipmentRarity = "3", CountId = "166", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "107002100", BitNumber = "166"};
        public static readonly Item OrangeMagicite = new Item { Name = "Orange Magicite", ItemId = "107002200", Description = "橙の魔石", EquipmentRarity = "3", CountId = "167", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "107002200", BitNumber = "167"};
        public static readonly Item VioletMagicite = new Item { Name = "Violet Magicite", ItemId = "107002300", Description = "紫の魔石", EquipmentRarity = "3", CountId = "168", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "107002300", BitNumber = "168"};
        public static readonly Item YellowMegacite = new Item { Name = "Yellow Megacite", ItemId = "107002400", Description = "黄の大魔石", EquipmentRarity = "5", CountId = "169", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "107002400", BitNumber = "169"};
        public static readonly Item OrangeMegacite = new Item { Name = "Orange Megacite", ItemId = "107002500", Description = "橙の大魔石", EquipmentRarity = "5", CountId = "170", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "107002500", BitNumber = "170"};
        public static readonly Item VioletMegacite = new Item { Name = "Violet Megacite", ItemId = "107002600", Description = "紫の大魔石", EquipmentRarity = "5", CountId = "171", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "107002600", BitNumber = "171"};
        public static readonly Item GalleanTins = new Item { Name = "Gallean Tins", ItemId = "108000100", Description = "ガレア錫貨", EquipmentRarity = "5", CountId = "172", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "3000", ItemIdClone = "108000100", BitNumber = "172"};
        public static readonly Item PlayMoney = new Item { Name = "Play Money", ItemId = "108000401", Description = "おもちゃの金貨", EquipmentRarity = "5", CountId = "173", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "500", ItemIdClone = "108000401", BitNumber = "173"};
        public static readonly Item GaleKey_109202000 = new Item { Name = "Gale Key 1", ItemId = "109202000", Description = "疾風の鍵1", EquipmentRarity = "7", CountId = "176", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109202000", BitNumber = "176"};
        public static readonly Item GaleKey_109202010 = new Item { Name = "Gale Key 2", ItemId = "109202010", Description = "疾風の鍵2", EquipmentRarity = "7", CountId = "177", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109202010", BitNumber = "177"};
        public static readonly Item GaleKey_109202020 = new Item { Name = "Gale Key 3", ItemId = "109202020", Description = "疾風の鍵3", EquipmentRarity = "7", CountId = "178", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109202020", BitNumber = "178"};
        public static readonly Item GaleKey_109202030 = new Item { Name = "Gale Key 4", ItemId = "109202030", Description = "疾風の鍵4", EquipmentRarity = "7", CountId = "179", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109202030", BitNumber = "179"};
        public static readonly Item GaleKey_109202040 = new Item { Name = "Gale Key 5", ItemId = "109202040", Description = "疾風の鍵5", EquipmentRarity = "7", CountId = "180", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109202040", BitNumber = "180"};
        public static readonly Item GaleKey_109202050 = new Item { Name = "Gale Key 6", ItemId = "109202050", Description = "疾風の鍵6", EquipmentRarity = "7", CountId = "181", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109202050", BitNumber = "181"};
        public static readonly Item GaleKey_109202060 = new Item { Name = "Gale Key 7", ItemId = "109202060", Description = "疾風の鍵7", EquipmentRarity = "7", CountId = "182", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109202060", BitNumber = "182"};
        public static readonly Item GaleKey_109202070 = new Item { Name = "Gale Key 8", ItemId = "109202070", Description = "疾風の鍵8", EquipmentRarity = "7", CountId = "183", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109202070", BitNumber = "183"};
        public static readonly Item GaleKey_109202080 = new Item { Name = "Gale Key 9", ItemId = "109202080", Description = "疾風の鍵9", EquipmentRarity = "7", CountId = "184", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109202080", BitNumber = "184"};
        public static readonly Item GaleKey_109202090 = new Item { Name = "Gale Key 10", ItemId = "109202090", Description = "疾風の鍵10", EquipmentRarity = "7", CountId = "185", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109202090", BitNumber = "185"};
        public static readonly Item HardPebble = new Item { Name = "Hard Pebble", ItemId = "205000100", Description = "不砕の細石", EquipmentRarity = "3", CountId = "174", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "205000100", BitNumber = "174"};
        public static readonly Item PureStone = new Item { Name = "Pure Stone", ItemId = "205000200", Description = "至純の石", EquipmentRarity = "4", CountId = "175", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "205000200", BitNumber = "175"};
        public static readonly Item LazarethsNote = new Item { Name = "Lazareth's Note", ItemId = "291000100", Description = "ラザレスの書", EquipmentRarity = "4", CountId = "186", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "291000100", BitNumber = "186"};
        public static readonly Item IrissNote = new Item { Name = "Iris's Note", ItemId = "291000200", Description = "イリスの書", EquipmentRarity = "4", CountId = "187", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "291000200", BitNumber = "187"};
        public static readonly Item IvansNote = new Item { Name = "Ivan's Note", ItemId = "291000300", Description = "イヴァンの書", EquipmentRarity = "4", CountId = "188", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "291000300", BitNumber = "188"};
        public static readonly Item OlgasNote = new Item { Name = "Olga's Note", ItemId = "291000400", Description = "オルガの書", EquipmentRarity = "4", CountId = "189", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "291000400", BitNumber = "189"};
        public static readonly Item FinnithsNote = new Item { Name = "Finnith's Note", ItemId = "291000500", Description = "フィニスの書", EquipmentRarity = "4", CountId = "190", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "291000500", BitNumber = "190"};
        public static readonly Item DrakeHeart = new Item { Name = "Drake Heart", ItemId = "206000100", Description = "魔竜の心臓", EquipmentRarity = "4", CountId = "191", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "206000100", BitNumber = "191"};
        public static readonly Item DrakeOre = new Item { Name = "Drake Ore", ItemId = "206000200", Description = "竜輝鉱", EquipmentRarity = "4", CountId = "192", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "206000200", BitNumber = "192"};
        public static readonly Item DrakeSphere = new Item { Name = "Drake Sphere", ItemId = "206000300", Description = "竜玉", EquipmentRarity = "5", CountId = "193", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "206000300", BitNumber = "193"};
        public static readonly Item DrakeFang = new Item { Name = "Drake Fang", ItemId = "206000400", Description = "魔竜の牙", EquipmentRarity = "4", CountId = "194", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "206000400", BitNumber = "194"};
        public static readonly Item FarplaneMineral = new Item { Name = "Farplane Mineral", ItemId = "206000500", Description = "異界の鉱物", EquipmentRarity = "2", CountId = "195", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "206000500", BitNumber = "195"};
        public static readonly Item DeathStone = new Item { Name = "Death Stone", ItemId = "206000600", Description = "デスストーン", EquipmentRarity = "3", CountId = "196", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "206000600", BitNumber = "196"};
        public static readonly Item DemonHorn = new Item { Name = "Demon Horn", ItemId = "206000700", Description = "悪魔の角", EquipmentRarity = "2", CountId = "197", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "206000700", BitNumber = "197"};
        public static readonly Item DivineCrystal = new Item { Name = "Divine Crystal", ItemId = "290050500", Description = "神魔王結晶", EquipmentRarity = "7", CountId = "199", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "7000", ItemSellPrice = "700", ItemIdClone = "290050500", BitNumber = "199"};
        public static readonly Item FairiesWrit = new Item { Name = "Fairies' Writ", ItemId = "290060000", Description = "妖精王の密書", EquipmentRarity = "6", CountId = "200", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "290060000", BitNumber = "200"};
        public static readonly Item RainbowBloom = new Item { Name = "Rainbow Bloom", ItemId = "290060100", Description = "楽園の幻虹花", EquipmentRarity = "6", CountId = "201", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "290060100", BitNumber = "201"};
        public static readonly Item CalamityGem = new Item { Name = "Calamity Gem", ItemId = "290060200", Description = "災禍の封神珠", EquipmentRarity = "6", CountId = "202", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "290060200", BitNumber = "202"};
        public static readonly Item PrismaticHorn = new Item { Name = "Prismatic Horn", ItemId = "290060300", Description = "神獣の極彩角", EquipmentRarity = "6", CountId = "203", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "290060300", BitNumber = "203"};
        public static readonly Item CalamityWrit = new Item { Name = "Calamity Writ", ItemId = "290060400", Description = "終焉の予言書", EquipmentRarity = "6", CountId = "204", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "290060400", BitNumber = "204"};
        public static readonly Item AuraciteShard = new Item { Name = "Auracite Shard ", ItemId = "106300100", Description = "聖石の欠片", EquipmentRarity = "3", CountId = "205", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106300100", BitNumber = "205"};
        public static readonly Item BugrossOre = new Item { Name = "Bugross Ore", ItemId = "207000100", Description = "バグロス鉱", EquipmentRarity = "5", CountId = "206", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "207000100", BitNumber = "206"};
        public static readonly Item UlricIron = new Item { Name = "Ulric Iron", ItemId = "207000200", Description = "デルタ鉄", EquipmentRarity = "4", CountId = "207", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "207000200", BitNumber = "207"};
        public static readonly Item CoreDust = new Item { Name = "Core Dust", ItemId = "207000300", Description = "地底の砂塵", EquipmentRarity = "4", CountId = "208", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "207000300", BitNumber = "208"};
        public static readonly Item AbyssPearl = new Item { Name = "Abyss Pearl", ItemId = "207000400", Description = "深淵の宝珠", EquipmentRarity = "4", CountId = "209", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "207000400", BitNumber = "209"};
        public static readonly Item PantherFang = new Item { Name = "Panther Fang", ItemId = "207000500", Description = "パンサーの牙", EquipmentRarity = "2", CountId = "210", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "207000500", BitNumber = "210"};
        public static readonly Item DemonWing = new Item { Name = "Demon Wing", ItemId = "207000600", Description = "悪魔の翼", EquipmentRarity = "2", CountId = "211", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "207000600", BitNumber = "211"};
        public static readonly Item AncientStone = new Item { Name = "Ancient Stone", ItemId = "207000700", Description = "古代神殿の石", EquipmentRarity = "3", CountId = "212", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "207000700", BitNumber = "212"};
        public static readonly Item TrochoidGear = new Item { Name = "Trochoid Gear", ItemId = "106300200", Description = "トロコイド歯車", EquipmentRarity = "3", CountId = "213", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106300200", BitNumber = "213"};
        public static readonly Item Uraninite = new Item { Name = "Uraninite", ItemId = "208000100", Description = "閃ウラン鉱", EquipmentRarity = "5", CountId = "214", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "208000100", BitNumber = "214"};
        public static readonly Item IridiumPlug = new Item { Name = "Iridium Plug", ItemId = "208000200", Description = "イリジウムプラグ", EquipmentRarity = "3", CountId = "215", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "208000200", BitNumber = "215"};
        public static readonly Item ParaffinOil = new Item { Name = "Paraffin Oil", ItemId = "208000300", Description = "パラフィンオイル", EquipmentRarity = "3", CountId = "216", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "208000300", BitNumber = "216"};
        public static readonly Item CrystalOscillator = new Item { Name = "Crystal Oscillator", ItemId = "208000400", Description = "水晶発振子", EquipmentRarity = "3", CountId = "217", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "208000400", BitNumber = "217"};
        public static readonly Item Perovskite = new Item { Name = "Perovskite", ItemId = "208000500", Description = "灰チタン石", EquipmentRarity = "4", CountId = "218", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "208000500", BitNumber = "218"};
        public static readonly Item EntrancingTail = new Item { Name = "Entrancing Tail", ItemId = "208000600", Description = "霊獣の鳳尾", EquipmentRarity = "2", CountId = "219", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "208000600", BitNumber = "219"};
        public static readonly Item MenacingWings = new Item { Name = "Menacing Wings", ItemId = "208000700", Description = "飛天の双翼", EquipmentRarity = "2", CountId = "220", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "208000700", BitNumber = "220"};
        public static readonly Item HardRock = new Item { Name = "Hard Rock", ItemId = "290030500", Description = "堅強な岩石", EquipmentRarity = "4", CountId = "221", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290030500", BitNumber = "221"};
        public static readonly Item FurySeed = new Item { Name = "Fury Seed", ItemId = "290030600", Description = "闘気の種", EquipmentRarity = "4", CountId = "222", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290030600", BitNumber = "222"};
        public static readonly Item WickedDrop = new Item { Name = "Wicked Drop", ItemId = "290030700", Description = "魔性の滴り", EquipmentRarity = "4", CountId = "223", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290030700", BitNumber = "223"};
        public static readonly Item BrilliantRay = new Item { Name = "Brilliant Ray", ItemId = "290030800", Description = "知性の光片", EquipmentRarity = "4", CountId = "224", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290030800", BitNumber = "224"};
        public static readonly Item LuckySeedling = new Item { Name = "Lucky Seedling", ItemId = "290030900", Description = "幸運の種子", EquipmentRarity = "4", CountId = "225", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290030900", BitNumber = "225"};
        public static readonly Item BizarreBox = new Item { Name = "Bizarre Box", ItemId = "290031000", Description = "奇想天外の箱", EquipmentRarity = "4", CountId = "226", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "290031000", BitNumber = "226"};
        public static readonly Item MassiveStone = new Item { Name = "Massive Stone", ItemId = "1000000000", Description = "大きな石", EquipmentRarity = "4", CountId = "9000", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "1000000000", BitNumber = "9000"};
        public static readonly Item DemonHeart_1000000001 = new Item { Name = "Demon Heart", ItemId = "1000000001", Description = "悪魔の心臓", EquipmentRarity = "5", CountId = "9001", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "1000000001", BitNumber = "9001"};
        public static readonly Item VoidVessel = new Item { Name = "Void Vessel", ItemId = "1000000002", Description = "虚無の器", EquipmentRarity = "5", CountId = "9002", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "1000000002", BitNumber = "9002"};
        public static readonly Item FineFlour = new Item { Name = "Fine Flour", ItemId = "1209000100", Description = "小麦粉", EquipmentRarity = "1", CountId = "9003", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "1209000100", BitNumber = "9003"};
        public static readonly Item LotusSeedPaste = new Item { Name = "Lotus Seed Paste", ItemId = "1209000200", Description = "蓮容餡", EquipmentRarity = "1", CountId = "9004", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "100", ItemSellPrice = "20", ItemIdClone = "1209000200", BitNumber = "9004"};
        public static readonly Item BrownEgg = new Item { Name = "Brown Egg", ItemId = "1209000300", Description = "卵", EquipmentRarity = "1", CountId = "9005", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "100", ItemSellPrice = "20", ItemIdClone = "1209000300", BitNumber = "9005"};
        public static readonly Item CoarseRockSugar = new Item { Name = "Coarse Rock Sugar", ItemId = "1209000400", Description = "氷砂糖", EquipmentRarity = "1", CountId = "9006", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "100", ItemSellPrice = "20", ItemIdClone = "1209000400", BitNumber = "9006"};
        public static readonly Item Mogcake = new Item { Name = "Mogcake", ItemId = "1106300100", Description = "モグケーキ", EquipmentRarity = "2", CountId = "9010", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "100", ItemSellPrice = "50", ItemIdClone = "1106300100", BitNumber = "9010"};
        public static readonly Item StandardMogcakeBox = new Item { Name = "Standard Mogcake Box", ItemId = "1209000600", Description = "モグケーキ通常ボックス", EquipmentRarity = "1", CountId = "9007", IsPotUnit = "5", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "100", ItemSellPrice = "100", ItemIdClone = "1209000600", BitNumber = "9007"};
        public static readonly Item RareMogcakeBox = new Item { Name = "Rare Mogcake Box", ItemId = "1209000700", Description = "モグケーキスペシャルボックス", EquipmentRarity = "1", CountId = "9008", IsPotUnit = "5", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "100", ItemSellPrice = "100", ItemIdClone = "1209000700", BitNumber = "9008"};
        public static readonly Item PremiumMogcakeBox = new Item { Name = "Premium Mogcake Box", ItemId = "1209000800", Description = "モグケーキプレミアムボックス", EquipmentRarity = "1", CountId = "9009", IsPotUnit = "5", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "100", ItemSellPrice = "100", ItemIdClone = "1209000800", BitNumber = "9009"};
        public static readonly Item Phantoma = new Item { Name = "Phantoma", ItemId = "106300300", Description = "ファントマ", EquipmentRarity = "3", CountId = "227", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106300300", BitNumber = "227"};
        public static readonly Item Candy = new Item { Name = "Candy", ItemId = "106300400", Description = "まんまるドロップ", EquipmentRarity = "3", CountId = "228", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106300400", BitNumber = "228"};
        public static readonly Item WhitePhantoma = new Item { Name = "White Phantoma", ItemId = "106300500", Description = "ホワイトファントマ", EquipmentRarity = "3", CountId = "229", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106300500", BitNumber = "229"};
        public static readonly Item ScrollofAcumen = new Item { Name = "Scroll of Acumen", ItemId = "1209000804", Description = "知力の巻物", EquipmentRarity = "3", CountId = "9015", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "100", ItemIdClone = "1209000804", BitNumber = "9015"};
        public static readonly Item ScrollofVigor = new Item { Name = "Scroll of Vigor", ItemId = "1209000805", Description = "筋力の巻物", EquipmentRarity = "3", CountId = "9016", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "100", ItemIdClone = "1209000805", BitNumber = "9016"};
        public static readonly Item CavernOre = new Item { Name = "Cavern Ore", ItemId = "1209000806", Description = "洞窟鉱石", EquipmentRarity = "3", CountId = "9011", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "1209000806", BitNumber = "9011"};
        public static readonly Item YPotion = new Item { Name = "Y-Potion", ItemId = "1000000003", Description = "ワイポーション", EquipmentRarity = "6", CountId = "9017", IsPotUnit = "1", KeyName = "6", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "300", ItemIdClone = "1000000003", BitNumber = "9017"};
        public static readonly Item MegaEther = new Item { Name = "Mega Ether", ItemId = "1000000004", Description = "メガエーテル", EquipmentRarity = "6", CountId = "9018", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "300", ItemIdClone = "1000000004", BitNumber = "9018"};
        public static readonly Item StainlessSteel = new Item { Name = "Stainless Steel", ItemId = "1209000801", Description = "ステンレス鋼", EquipmentRarity = "3", CountId = "9012", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "888", ItemSellPrice = "88", ItemIdClone = "1209000801", BitNumber = "9012"};
        public static readonly Item BloodAlcryst = new Item { Name = "Blood Alcryst", ItemId = "1209000802", Description = "血錬晶石", EquipmentRarity = "3", CountId = "9013", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "1209000802", BitNumber = "9013"};
        public static readonly Item BloodStone = new Item { Name = "Blood Stone", ItemId = "1209000803", Description = "ブラッドストーン", EquipmentRarity = "3", CountId = "9014", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "1209000803", BitNumber = "9014"};
        public static readonly Item SurvivorsFlask = new Item { Name = "Survivor's Flask", ItemId = "1209000807", Description = "神聖な水", EquipmentRarity = "2", CountId = "9019", IsPotUnit = "2", KeyName = "2", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "101000100", BitNumber = "9019"};
        public static readonly Item CandyCorn = new Item { Name = "Candy Corn", ItemId = "1106300101", Description = "キャンディコーン", EquipmentRarity = "2", CountId = "9020", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "100", ItemSellPrice = "50", ItemIdClone = "1106300101", BitNumber = "9020"};
        public static readonly Item Karma = new Item { Name = "Karma", ItemId = "106300900", Description = "カルマ", EquipmentRarity = "3", CountId = "265", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106300900", BitNumber = "265"};
        public static readonly Item MeteorFragment = new Item { Name = "Meteor Fragment", ItemId = "1100000027", Description = "流星の小片", EquipmentRarity = "1", CountId = "9021", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "1", ItemIdClone = "1100000027", BitNumber = "9021"};
        public static readonly Item MeteorShards = new Item { Name = "Meteor Shards", ItemId = "1100000028", Description = "流星の欠片", EquipmentRarity = "2", CountId = "9022", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "5000", ItemSellPrice = "1", ItemIdClone = "1100000028", BitNumber = "9022"};
        public static readonly Item MeteorStones = new Item { Name = "Meteor Stones", ItemId = "1100000029", Description = "流星の石", EquipmentRarity = "3", CountId = "9023", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1", ItemIdClone = "1100000029", BitNumber = "9023"};
        public static readonly Item MeteorRock = new Item { Name = "Meteor Rock", ItemId = "1100000030", Description = "流星の岩", EquipmentRarity = "4", CountId = "9024", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "20000", ItemSellPrice = "1", ItemIdClone = "1100000030", BitNumber = "9024"};
        public static readonly Item MeteorOre = new Item { Name = "Meteor Ore", ItemId = "1100000031", Description = "流星の鉱石", EquipmentRarity = "5", CountId = "9025", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "30000", ItemSellPrice = "10", ItemIdClone = "1100000031", BitNumber = "9025"};
        public static readonly Item MedicinalHerb = new Item { Name = "Medicinal Herb", ItemId = "101000400", Description = "やくそう", EquipmentRarity = "1", CountId = "243", IsPotUnit = "1", KeyName = "6", ItemStack = "99", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "101000400", BitNumber = "243"};
        public static readonly Item SuperiorMedicine = new Item { Name = "Superior Medicine", ItemId = "101000500", Description = "いやしそう", EquipmentRarity = "5", CountId = "244", IsPotUnit = "1", KeyName = "6", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "101000500", BitNumber = "244"};
        public static readonly Item YggdrasilDew = new Item { Name = "Yggdrasil Dew", ItemId = "101000600", Description = "せかいじゅのしずく", EquipmentRarity = "6", CountId = "247", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "101000600", BitNumber = "247"};
        public static readonly Item MagicWater = new Item { Name = "Magic Water", ItemId = "101001300", Description = "まほうのせいすい", EquipmentRarity = "3", CountId = "245", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "101001300", BitNumber = "245"};
        public static readonly Item SagesElixir = new Item { Name = "Sage's Elixir", ItemId = "101001400", Description = "けんじゃのせいすい", EquipmentRarity = "5", CountId = "246", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "101001400", BitNumber = "246"};
        public static readonly Item YggdrasilLeaf = new Item { Name = "Yggdrasil Leaf", ItemId = "101003200", Description = "せかいじゅのは", EquipmentRarity = "4", CountId = "248", IsPotUnit = "1", KeyName = "6", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "101003200", BitNumber = "248"};
        public static readonly Item FlameringKey_109203000 = new Item { Name = "Flamering Key 1", ItemId = "109203000", Description = "火輪の鍵1", EquipmentRarity = "7", CountId = "231", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109203000", BitNumber = "231"};
        public static readonly Item FlameringKey_109203010 = new Item { Name = "Flamering Key 2", ItemId = "109203010", Description = "火輪の鍵2", EquipmentRarity = "7", CountId = "232", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109203010", BitNumber = "232"};
        public static readonly Item FlameringKey_109203020 = new Item { Name = "Flamering Key 3", ItemId = "109203020", Description = "火輪の鍵3", EquipmentRarity = "7", CountId = "233", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109203020", BitNumber = "233"};
        public static readonly Item FlameringKey_109203030 = new Item { Name = "Flamering Key 4", ItemId = "109203030", Description = "火輪の鍵4", EquipmentRarity = "7", CountId = "234", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109203030", BitNumber = "234"};
        public static readonly Item FlameringKey_109203040 = new Item { Name = "Flamering Key 5", ItemId = "109203040", Description = "火輪の鍵5", EquipmentRarity = "7", CountId = "235", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109203040", BitNumber = "235"};
        public static readonly Item FlameringKey_109203050 = new Item { Name = "Flamering Key 6", ItemId = "109203050", Description = "火輪の鍵6", EquipmentRarity = "7", CountId = "236", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109203050", BitNumber = "236"};
        public static readonly Item FlameringKey_109203060 = new Item { Name = "Flamering Key 7", ItemId = "109203060", Description = "火輪の鍵7", EquipmentRarity = "7", CountId = "237", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109203060", BitNumber = "237"};
        public static readonly Item FlameringKey_109203070 = new Item { Name = "Flamering Key 8", ItemId = "109203070", Description = "火輪の鍵8", EquipmentRarity = "7", CountId = "238", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109203070", BitNumber = "238"};
        public static readonly Item FlameringKey_109203080 = new Item { Name = "Flamering Key 9", ItemId = "109203080", Description = "火輪の鍵9", EquipmentRarity = "7", CountId = "239", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109203080", BitNumber = "239"};
        public static readonly Item FlameringKey_109203090 = new Item { Name = "Flamering Key 10", ItemId = "109203090", Description = "火輪の鍵10", EquipmentRarity = "7", CountId = "240", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109203090", BitNumber = "240"};
        public static readonly Item AuroraKey_109204000 = new Item { Name = "Aurora Key 1", ItemId = "109204000", Description = "極光の鍵1", EquipmentRarity = "7", CountId = "254", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109204000", BitNumber = "254"};
        public static readonly Item AuroraKey_109204010 = new Item { Name = "Aurora Key 2", ItemId = "109204010", Description = "極光の鍵2", EquipmentRarity = "7", CountId = "255", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109204010", BitNumber = "255"};
        public static readonly Item AuroraKey_109204020 = new Item { Name = "Aurora Key 3", ItemId = "109204020", Description = "極光の鍵3", EquipmentRarity = "7", CountId = "256", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109204020", BitNumber = "256"};
        public static readonly Item AuroraKey_109204030 = new Item { Name = "Aurora Key 4", ItemId = "109204030", Description = "極光の鍵4", EquipmentRarity = "7", CountId = "257", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109204030", BitNumber = "257"};
        public static readonly Item AuroraKey_109204040 = new Item { Name = "Aurora Key 5", ItemId = "109204040", Description = "極光の鍵5", EquipmentRarity = "7", CountId = "258", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109204040", BitNumber = "258"};
        public static readonly Item AuroraKey_109204050 = new Item { Name = "Aurora Key 6", ItemId = "109204050", Description = "極光の鍵6", EquipmentRarity = "7", CountId = "259", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109204050", BitNumber = "259"};
        public static readonly Item AuroraKey_109204060 = new Item { Name = "Aurora Key 7", ItemId = "109204060", Description = "極光の鍵7", EquipmentRarity = "7", CountId = "260", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109204060", BitNumber = "260"};
        public static readonly Item AuroraKey_109204070 = new Item { Name = "Aurora Key 8", ItemId = "109204070", Description = "極光の鍵8", EquipmentRarity = "7", CountId = "261", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109204070", BitNumber = "261"};
        public static readonly Item AuroraKey_109204080 = new Item { Name = "Aurora Key 9", ItemId = "109204080", Description = "極光の鍵9", EquipmentRarity = "7", CountId = "262", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109204080", BitNumber = "262"};
        public static readonly Item AuroraKey_109204090 = new Item { Name = "Aurora Key 10", ItemId = "109204090", Description = "極光の鍵10", EquipmentRarity = "7", CountId = "263", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109204090", BitNumber = "263"};
        public static readonly Item BlackKey_109205000 = new Item { Name = "Black Key 1", ItemId = "109205000", Description = "漆黒の鍵1", EquipmentRarity = "7", CountId = "338", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109205000", BitNumber = "338"};
        public static readonly Item BlackKey_109205010 = new Item { Name = "Black Key 2", ItemId = "109205010", Description = "漆黒の鍵2", EquipmentRarity = "7", CountId = "339", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109205010", BitNumber = "339"};
        public static readonly Item BlackKey_109205020 = new Item { Name = "Black Key 3", ItemId = "109205020", Description = "漆黒の鍵3", EquipmentRarity = "7", CountId = "340", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109205020", BitNumber = "340"};
        public static readonly Item BlackKey_109205030 = new Item { Name = "Black Key 4", ItemId = "109205030", Description = "漆黒の鍵4", EquipmentRarity = "7", CountId = "341", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109205030", BitNumber = "341"};
        public static readonly Item BlackKey_109205040 = new Item { Name = "Black Key 5", ItemId = "109205040", Description = "漆黒の鍵5", EquipmentRarity = "7", CountId = "342", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109205040", BitNumber = "342"};
        public static readonly Item BlackKey_109205050 = new Item { Name = "Black Key 6", ItemId = "109205050", Description = "漆黒の鍵6", EquipmentRarity = "7", CountId = "343", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109205050", BitNumber = "343"};
        public static readonly Item BlackKey_109205060 = new Item { Name = "Black Key 7", ItemId = "109205060", Description = "漆黒の鍵7", EquipmentRarity = "7", CountId = "344", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109205060", BitNumber = "344"};
        public static readonly Item BlackKey_109205070 = new Item { Name = "Black Key 8", ItemId = "109205070", Description = "漆黒の鍵8", EquipmentRarity = "7", CountId = "345", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109205070", BitNumber = "345"};
        public static readonly Item BlackKey_109205080 = new Item { Name = "Black Key 9", ItemId = "109205080", Description = "漆黒の鍵9", EquipmentRarity = "7", CountId = "346", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109205080", BitNumber = "346"};
        public static readonly Item BlackKey_109205090 = new Item { Name = "Black Key 10", ItemId = "109205090", Description = "漆黒の鍵10", EquipmentRarity = "7", CountId = "347", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109205090", BitNumber = "347"};
        public static readonly Item RedOrb = new Item { Name = "Red Orb", ItemId = "106300600", Description = "赤の宝玉", EquipmentRarity = "3", CountId = "230", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106300600", BitNumber = "230"};
        public static readonly Item RatTail = new Item { Name = "Rat Tail", ItemId = "106210100", Description = "ねずみのしっぽ", EquipmentRarity = "3", CountId = "241", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "106210100", BitNumber = "241"};
        public static readonly Item GoldCoin = new Item { Name = "Gold Coin", ItemId = "106300700", Description = "ゴールド", EquipmentRarity = "3", CountId = "242", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106300700", BitNumber = "242"};
        public static readonly Item GoldOre = new Item { Name = "Gold Ore", ItemId = "203000500", Description = "金鉱", EquipmentRarity = "5", CountId = "249", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "203000500", BitNumber = "249"};
        public static readonly Item BluePhantoma = new Item { Name = "Blue Phantoma", ItemId = "106300800", Description = "ブルーファントマ", EquipmentRarity = "3", CountId = "250", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106300800", BitNumber = "250"};
        public static readonly Item KoltzStar = new Item { Name = "Koltz Star", ItemId = "202002800", Description = "コルツの星", EquipmentRarity = "8", CountId = "251", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "202002800", BitNumber = "251"};
        public static readonly Item HopeDiamond = new Item { Name = "Hope Diamond", ItemId = "202002900", Description = "ホープダイヤ", EquipmentRarity = "8", CountId = "252", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "202002900", BitNumber = "252"};
        public static readonly Item FlamingBlood = new Item { Name = "Flaming Blood", ItemId = "202003000", Description = "フレイムブラッド", EquipmentRarity = "8", CountId = "253", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "202003000", BitNumber = "253"};
        public static readonly Item ImperialGrenade = new Item { Name = "Imperial Grenade", ItemId = "105005100", Description = "帝国式手榴弾", EquipmentRarity = "4", CountId = "264", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "105005100", BitNumber = "264"};
        public static readonly Item IfritRaidCoin = new Item { Name = "Ifrit Raid Coin", ItemId = "106301000", Description = "焔神イフリートレイドコイン", EquipmentRarity = "3", CountId = "266", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106301000", BitNumber = "266"};
        public static readonly Item HermitsTeachings = new Item { Name = "Hermit's Teachings", ItemId = "291100100", Description = "隠者の教え", EquipmentRarity = "5", CountId = "267", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "291100100", BitNumber = "267"};
        public static readonly Item StarMote = new Item { Name = "Star Mote", ItemId = "291100200", Description = "星の魔片", EquipmentRarity = "5", CountId = "268", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "291100200", BitNumber = "268"};
        public static readonly Item SwordsmanshipNotes = new Item { Name = "Swordsmanship Notes", ItemId = "291100300", Description = "剣士の戦術書", EquipmentRarity = "5", CountId = "269", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "291100300", BitNumber = "269"};
        public static readonly Item DesertMineral = new Item { Name = "Desert Mineral", ItemId = "209000100", Description = "砂漠の鉱石", EquipmentRarity = "1", CountId = "270", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "209000100", BitNumber = "270"};
        public static readonly Item OldJungleTree = new Item { Name = "Old Jungle Tree", ItemId = "209000200", Description = "密林の古木", EquipmentRarity = "2", CountId = "271", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "209000200", BitNumber = "271"};
        public static readonly Item MiraculousThread = new Item { Name = "Miraculous Thread", ItemId = "209000300", Description = "不思議な糸", EquipmentRarity = "3", CountId = "272", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "209000300", BitNumber = "272"};
        public static readonly Item HideoftheGuardian = new Item { Name = "Hide of the Guardian", ItemId = "209000400", Description = "守護獣の皮", EquipmentRarity = "4", CountId = "273", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "209000400", BitNumber = "273"};
        public static readonly Item SeedofIllusions = new Item { Name = "Seed of Illusions", ItemId = "209000500", Description = "幻想の種", EquipmentRarity = "5", CountId = "274", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "209000500", BitNumber = "274"};
        public static readonly Item AncientWritings = new Item { Name = "Ancient Writings", ItemId = "209000600", Description = "古代の書物", EquipmentRarity = "3", CountId = "275", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "209000600", BitNumber = "275"};
        public static readonly Item HighgradeArmorOil = new Item { Name = "High-grade Armor Oil", ItemId = "209000700", Description = "武具用高級油", EquipmentRarity = "4", CountId = "276", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "209000700", BitNumber = "276"};
        public static readonly Item MysteriousDrop = new Item { Name = "Mysterious Drop", ItemId = "209000800", Description = "神秘の雨滴", EquipmentRarity = "5", CountId = "277", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "209000800", BitNumber = "277"};
        public static readonly Item AlterBlade = new Item { Name = "Alter Blade", ItemId = "209000900", Description = "栄枯の刃", EquipmentRarity = "3", CountId = "278", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "209000900", BitNumber = "278"};
        public static readonly Item DreamBlossom = new Item { Name = "Dream Blossom", ItemId = "209001000", Description = "夢の花", EquipmentRarity = "4", CountId = "279", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "209001000", BitNumber = "279"};
        public static readonly Item QualityGoldDust = new Item { Name = "Quality Gold Dust", ItemId = "209001100", Description = "上質な砂金", EquipmentRarity = "5", CountId = "280", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "209001100", BitNumber = "280"};
        public static readonly Item Fish = new Item { Name = "Fish", ItemId = "106301100", Description = "魚", EquipmentRarity = "3", CountId = "281", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106301100", BitNumber = "281"};
        public static readonly Item WhiteAlcryst = new Item { Name = "White Alcryst", ItemId = "270000100", Description = "白の晶石", EquipmentRarity = "2", CountId = "282", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "270000100", BitNumber = "282"};
        public static readonly Item WhiteMilcryst = new Item { Name = "White Milcryst", ItemId = "270000200", Description = "白の中晶石", EquipmentRarity = "3", CountId = "283", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "270000200", BitNumber = "283"};
        public static readonly Item WhiteHeavicryst = new Item { Name = "White Heavicryst", ItemId = "270000300", Description = "白の大晶石", EquipmentRarity = "4", CountId = "284", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "270000300", BitNumber = "284"};
        public static readonly Item WhiteGiancryst = new Item { Name = "White Giancryst", ItemId = "270000400", Description = "白の超晶石", EquipmentRarity = "5", CountId = "285", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "270000400", BitNumber = "285"};
        public static readonly Item WhitePurecryst = new Item { Name = "White Purecryst", ItemId = "270000500", Description = "白の神晶石", EquipmentRarity = "6", CountId = "286", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "270000500", BitNumber = "286"};
        public static readonly Item BlackAlcryst = new Item { Name = "Black Alcryst", ItemId = "270000600", Description = "黒の晶石", EquipmentRarity = "2", CountId = "287", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "270000600", BitNumber = "287"};
        public static readonly Item BlackMilcryst = new Item { Name = "Black Milcryst", ItemId = "270000700", Description = "黒の中晶石", EquipmentRarity = "3", CountId = "288", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "270000700", BitNumber = "288"};
        public static readonly Item BlackHeavicryst = new Item { Name = "Black Heavicryst", ItemId = "270000800", Description = "黒の大晶石", EquipmentRarity = "4", CountId = "289", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "270000800", BitNumber = "289"};
        public static readonly Item BlackGiancryst = new Item { Name = "Black Giancryst", ItemId = "270000900", Description = "黒の超晶石", EquipmentRarity = "5", CountId = "290", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "270000900", BitNumber = "290"};
        public static readonly Item BlackPurecryst = new Item { Name = "Black Purecryst", ItemId = "270001000", Description = "黒の神晶石", EquipmentRarity = "6", CountId = "291", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "270001000", BitNumber = "291"};
        public static readonly Item GreenAlcryst = new Item { Name = "Green Alcryst", ItemId = "270001100", Description = "緑の晶石", EquipmentRarity = "2", CountId = "292", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "270001100", BitNumber = "292"};
        public static readonly Item GreenMilcryst = new Item { Name = "Green Milcryst", ItemId = "270001200", Description = "緑の中晶石", EquipmentRarity = "3", CountId = "293", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "270001200", BitNumber = "293"};
        public static readonly Item GreenHeavicryst = new Item { Name = "Green Heavicryst", ItemId = "270001300", Description = "緑の大晶石", EquipmentRarity = "4", CountId = "294", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "270001300", BitNumber = "294"};
        public static readonly Item GreenGiancryst = new Item { Name = "Green Giancryst", ItemId = "270001400", Description = "緑の超晶石", EquipmentRarity = "5", CountId = "295", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "270001400", BitNumber = "295"};
        public static readonly Item GreenPurecryst = new Item { Name = "Green Purecryst", ItemId = "270001500", Description = "緑の神晶石", EquipmentRarity = "6", CountId = "296", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "270001500", BitNumber = "296"};
        public static readonly Item PowerAlcryst = new Item { Name = "Power Alcryst", ItemId = "270002600", Description = "攻めの晶石", EquipmentRarity = "2", CountId = "307", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "270002600", BitNumber = "307"};
        public static readonly Item PowerMilcryst = new Item { Name = "Power Milcryst", ItemId = "270002700", Description = "攻めの中晶石", EquipmentRarity = "3", CountId = "308", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "270002700", BitNumber = "308"};
        public static readonly Item PowerHeavicryst = new Item { Name = "Power Heavicryst", ItemId = "270002800", Description = "攻めの大晶石", EquipmentRarity = "4", CountId = "309", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "270002800", BitNumber = "309"};
        public static readonly Item PowerGiancryst = new Item { Name = "Power Giancryst", ItemId = "270002900", Description = "攻めの超晶石", EquipmentRarity = "5", CountId = "310", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "270002900", BitNumber = "310"};
        public static readonly Item PowerPurecryst = new Item { Name = "Power Purecryst", ItemId = "270003000", Description = "攻めの神晶石", EquipmentRarity = "6", CountId = "311", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "270003000", BitNumber = "311"};
        public static readonly Item GuardAlcryst = new Item { Name = "Guard Alcryst", ItemId = "270003100", Description = "守りの晶石", EquipmentRarity = "2", CountId = "312", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "270003100", BitNumber = "312"};
        public static readonly Item GuardMilcryst = new Item { Name = "Guard Milcryst", ItemId = "270003200", Description = "守りの中晶石", EquipmentRarity = "3", CountId = "313", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "270003200", BitNumber = "313"};
        public static readonly Item GuardHeavicryst = new Item { Name = "Guard Heavicryst", ItemId = "270003300", Description = "守りの大晶石", EquipmentRarity = "4", CountId = "314", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "270003300", BitNumber = "314"};
        public static readonly Item GuardGiancryst = new Item { Name = "Guard Giancryst", ItemId = "270003400", Description = "守りの超晶石", EquipmentRarity = "5", CountId = "315", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "270003400", BitNumber = "315"};
        public static readonly Item GuardPurecryst = new Item { Name = "Guard Purecryst", ItemId = "270003500", Description = "守りの神晶石", EquipmentRarity = "6", CountId = "316", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "270003500", BitNumber = "316"};
        public static readonly Item HealingAlcryst = new Item { Name = "Healing Alcryst", ItemId = "270003600", Description = "癒しの晶石", EquipmentRarity = "2", CountId = "317", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "270003600", BitNumber = "317"};
        public static readonly Item HealingMilcryst = new Item { Name = "Healing Milcryst", ItemId = "270003700", Description = "癒しの中晶石", EquipmentRarity = "3", CountId = "318", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "270003700", BitNumber = "318"};
        public static readonly Item HealingHeavicryst = new Item { Name = "Healing Heavicryst", ItemId = "270003800", Description = "癒しの大晶石", EquipmentRarity = "4", CountId = "319", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "270003800", BitNumber = "319"};
        public static readonly Item HealingGiancryst = new Item { Name = "Healing Giancryst", ItemId = "270003900", Description = "癒しの超晶石", EquipmentRarity = "5", CountId = "320", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "270003900", BitNumber = "320"};
        public static readonly Item HealingPurecryst = new Item { Name = "Healing Purecryst", ItemId = "270004000", Description = "癒しの神晶石", EquipmentRarity = "6", CountId = "321", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "270004000", BitNumber = "321"};
        public static readonly Item SupportAlcryst = new Item { Name = "Support Alcryst", ItemId = "270004100", Description = "支援の晶石", EquipmentRarity = "2", CountId = "322", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "270004100", BitNumber = "322"};
        public static readonly Item SupportMilcryst = new Item { Name = "Support Milcryst", ItemId = "270004200", Description = "支援の中晶石", EquipmentRarity = "3", CountId = "323", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "270004200", BitNumber = "323"};
        public static readonly Item SupportHeavicryst = new Item { Name = "Support Heavicryst", ItemId = "270004300", Description = "支援の大晶石", EquipmentRarity = "4", CountId = "324", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "270004300", BitNumber = "324"};
        public static readonly Item SupportGiancryst = new Item { Name = "Support Giancryst", ItemId = "270004400", Description = "支援の超晶石", EquipmentRarity = "5", CountId = "325", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "270004400", BitNumber = "325"};
        public static readonly Item SupportPurecryst = new Item { Name = "Support Purecryst", ItemId = "270004500", Description = "支援の神晶石", EquipmentRarity = "6", CountId = "326", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "270004500", BitNumber = "326"};
        public static readonly Item TechAlcryst = new Item { Name = "Tech Alcryst", ItemId = "270004600", Description = "技巧の晶石", EquipmentRarity = "2", CountId = "327", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "270004600", BitNumber = "327"};
        public static readonly Item TechMilcryst = new Item { Name = "Tech Milcryst", ItemId = "270004700", Description = "技巧の中晶石", EquipmentRarity = "3", CountId = "328", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "270004700", BitNumber = "328"};
        public static readonly Item TechHeavicryst = new Item { Name = "Tech Heavicryst", ItemId = "270004800", Description = "技巧の大晶石", EquipmentRarity = "4", CountId = "329", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "270004800", BitNumber = "329"};
        public static readonly Item TechGiancryst = new Item { Name = "Tech Giancryst", ItemId = "270004900", Description = "技巧の超晶石", EquipmentRarity = "5", CountId = "330", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "270004900", BitNumber = "330"};
        public static readonly Item TechPurecryst = new Item { Name = "Tech Purecryst", ItemId = "270005000", Description = "技巧の神晶石", EquipmentRarity = "6", CountId = "331", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "270005000", BitNumber = "331"};
        public static readonly Item StrengthOrb = new Item { Name = "Strength Orb", ItemId = "210000100", Description = "力の珠", EquipmentRarity = "3", CountId = "332", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "210000100", BitNumber = "332"};
        public static readonly Item PetrifyGrenade = new Item { Name = "Petrify Grenade", ItemId = "210000200", Description = "石化手榴弾", EquipmentRarity = "3", CountId = "333", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "210000200", BitNumber = "333"};
        public static readonly Item SleepingPowder = new Item { Name = "Sleeping Powder", ItemId = "210000300", Description = "スリープパウダー", EquipmentRarity = "3", CountId = "334", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "210000300", BitNumber = "334"};
        public static readonly Item UnderdogsSecret = new Item { Name = "Underdog's Secret", ItemId = "210000400", Description = "逆転のカギ", EquipmentRarity = "4", CountId = "335", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "210000400", BitNumber = "335"};
        public static readonly Item BlueButterflyPowder = new Item { Name = "Blue Butterfly Powder", ItemId = "210000500", Description = "青い蝶の鱗粉", EquipmentRarity = "6", CountId = "336", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "210000500", BitNumber = "336"};
        public static readonly Item RedButterflyPowder = new Item { Name = "Red Butterfly Powder", ItemId = "210000600", Description = "赤い蝶の鱗粉", EquipmentRarity = "5", CountId = "337", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "210000600", BitNumber = "337"};
        public static readonly Item Mote = new Item { Name = "Mote", ItemId = "106301200", Description = "魔片", EquipmentRarity = "3", CountId = "348", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106301200", BitNumber = "348"};
        public static readonly Item MusicalNote = new Item { Name = "Musical Note", ItemId = "106301800", Description = "髪飾り", EquipmentRarity = "3", CountId = "395", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106301800", BitNumber = "395"};
        public static readonly Item Perfume = new Item { Name = "Perfume", ItemId = "106301900", Description = "音符", EquipmentRarity = "2", CountId = "406", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "106301900", BitNumber = "406"};
        public static readonly Item Lipstick = new Item { Name = "Lipstick", ItemId = "106302000", Description = "香水", EquipmentRarity = "3", CountId = "407", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106302000", BitNumber = "407"};
        public static readonly Item NailPolish = new Item { Name = "Nail Polish", ItemId = "106302100", Description = "口紅", EquipmentRarity = "3", CountId = "408", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106302100", BitNumber = "408"};
        public static readonly Item FacePowder = new Item { Name = "Face Powder", ItemId = "106302200", Description = "マニキュア", EquipmentRarity = "3", CountId = "409", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106302200", BitNumber = "409"};
        public static readonly Item HairSpray_106302300 = new Item { Name = "Hair Spray", ItemId = "106302300", Description = "フェイスパウダー", EquipmentRarity = "3", CountId = "410", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106302300", BitNumber = "410"};
        public static readonly Item Chocolate = new Item { Name = "Chocolate", ItemId = "101001900", Description = "チョコ", EquipmentRarity = "3", CountId = "198", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "101001900", BitNumber = "198"};
        public static readonly Item FinasChocolate = new Item { Name = "Fina's Chocolate", ItemId = "101003300", Description = "フィーナのチョコレート", EquipmentRarity = "8", CountId = "413", IsPotUnit = "1", KeyName = "6", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "101003300", BitNumber = "413"};
        public static readonly Item ShadowLordCoin = new Item { Name = "Shadow Lord Coin", ItemId = "106301300", Description = "闇の王レイドコイン", EquipmentRarity = "3", CountId = "363", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106301300", BitNumber = "363"};
        public static readonly Item WhiteOrb = new Item { Name = "White Orb", ItemId = "106301400", Description = "白の宝玉", EquipmentRarity = "3", CountId = "364", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106301400", BitNumber = "364"};
        public static readonly Item KingMogCoin = new Item { Name = "King Mog Coin", ItemId = "106301500", Description = "モーグリ王レイドコイン", EquipmentRarity = "3", CountId = "365", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106301500", BitNumber = "365"};
        public static readonly Item FangofWind = new Item { Name = "Fang of Wind", ItemId = "106301600", Description = "風の牙", EquipmentRarity = "3", CountId = "372", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106301600", BitNumber = "372"};
        public static readonly Item collab_106301700 = new Item { Name = "collab", ItemId = "106301700", Description = "ネフ・ガルムドレイドコイン", EquipmentRarity = "3", CountId = "373", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106301700", BitNumber = "373"};
        public static readonly Item collab_106301710 = new Item { Name = "collab", ItemId = "106301710", Description = "ネフ・ガルムドの感応結晶", EquipmentRarity = "3", CountId = "374", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106301710", BitNumber = "374"};
        public static readonly Item MemoryCandy = new Item { Name = "Memory Candy", ItemId = "106302400", Description = "思い出の飴玉", EquipmentRarity = "3", CountId = "396", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106302400", BitNumber = "396"};
        public static readonly Item collab_106302500 = new Item { Name = "collab", ItemId = "106302500", Description = "四魔貴族レイドコイン", EquipmentRarity = "3", CountId = "405", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106302500", BitNumber = "405"};
        public static readonly Item thScaleSoldier = new Item { Name = "1/35th Scale Soldier", ItemId = "106302700", Description = "1/35神羅兵", EquipmentRarity = "3", CountId = "412", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106302700", BitNumber = "412"};
        public static readonly Item BreathofLife = new Item { Name = "Breath of Life", ItemId = "211000100", Description = "生命の息吹", EquipmentRarity = "1", CountId = "349", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "100", ItemSellPrice = "10", ItemIdClone = "211000100", BitNumber = "349"};
        public static readonly Item TwilightStone = new Item { Name = "Twilight Stone", ItemId = "211000200", Description = "黄昏の石", EquipmentRarity = "2", CountId = "350", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "211000200", BitNumber = "350"};
        public static readonly Item DuskJewel = new Item { Name = "Dusk Jewel", ItemId = "211000300", Description = "宵闇の宝珠", EquipmentRarity = "5", CountId = "351", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "211000300", BitNumber = "351"};
        public static readonly Item DarkOre = new Item { Name = "Dark Ore", ItemId = "211000400", Description = "黒闇鉱", EquipmentRarity = "5", CountId = "352", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "211000400", BitNumber = "352"};
        public static readonly Item TranquilStone = new Item { Name = "Tranquil Stone", ItemId = "211000500", Description = "安らぎの貴石", EquipmentRarity = "4", CountId = "353", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "211000500", BitNumber = "353"};
        public static readonly Item SilverChunk = new Item { Name = "Silver Chunk", ItemId = "211000600", Description = "銀の細片", EquipmentRarity = "4", CountId = "354", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "211000600", BitNumber = "354"};
        public static readonly Item BlessingNeedle = new Item { Name = "Blessing Needle", ItemId = "211000700", Description = "祝福の針", EquipmentRarity = "4", CountId = "355", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "211000700", BitNumber = "355"};
        public static readonly Item CursedSphere = new Item { Name = "Cursed Sphere", ItemId = "211000800", Description = "呪縛の玉", EquipmentRarity = "3", CountId = "356", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "211000800", BitNumber = "356"};
        public static readonly Item SacredBranch = new Item { Name = "Sacred Branch", ItemId = "211000900", Description = "神木の枝", EquipmentRarity = "3", CountId = "357", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "211000900", BitNumber = "357"};
        public static readonly Item GloryBug = new Item { Name = "Glory Bug", ItemId = "211001000", Description = "栄光の虫", EquipmentRarity = "3", CountId = "358", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "211001000", BitNumber = "358"};
        public static readonly Item AntiqueBone = new Item { Name = "Antique Bone", ItemId = "211001100", Description = "いにしえの骨", EquipmentRarity = "3", CountId = "359", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "211001100", BitNumber = "359"};
        public static readonly Item PinkScale = new Item { Name = "Pink Scale", ItemId = "211001200", Description = "桃色の鱗", EquipmentRarity = "4", CountId = "360", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "211001200", BitNumber = "360"};
        public static readonly Item DawnShell = new Item { Name = "Dawn Shell", ItemId = "211001300", Description = "暁虫の甲殻", EquipmentRarity = "3", CountId = "361", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "211001300", BitNumber = "361"};
        public static readonly Item AchromaticBlossom = new Item { Name = "Achromatic Blossom", ItemId = "211001400", Description = "無色の花", EquipmentRarity = "4", CountId = "362", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "211001400", BitNumber = "362"};
        public static readonly Item WhiteTail = new Item { Name = "White Tail", ItemId = "212000100", Description = "白尾", EquipmentRarity = "3", CountId = "366", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "212000100", BitNumber = "366"};
        public static readonly Item DewBlossom = new Item { Name = "Dew Blossom", ItemId = "212000200", Description = "白露の花", EquipmentRarity = "3", CountId = "367", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "212000200", BitNumber = "367"};
        public static readonly Item WhiteMetal = new Item { Name = "White Metal", ItemId = "212000300", Description = "ホワイトメタル", EquipmentRarity = "4", CountId = "368", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "212000300", BitNumber = "368"};
        public static readonly Item WhiteDrakesFeather = new Item { Name = "White Drake's Feather", ItemId = "212000400", Description = "白翼竜の羽根", EquipmentRarity = "4", CountId = "369", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "212000400", BitNumber = "369"};
        public static readonly Item WhiteTome = new Item { Name = "White Tome", ItemId = "212000500", Description = "白の魔道書", EquipmentRarity = "4", CountId = "370", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "212000500", BitNumber = "370"};
        public static readonly Item WhiteSlate = new Item { Name = "White Slate", ItemId = "212000600", Description = "白の石版", EquipmentRarity = "5", CountId = "371", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "212000600", BitNumber = "371"};
        public static readonly Item BlueBeastsShell = new Item { Name = "Blue Beast's Shell", ItemId = "213000100", Description = "青熊獣の甲殻", EquipmentRarity = "3", CountId = "375", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "213000100", BitNumber = "375"};
        public static readonly Item BlueBeastsBone = new Item { Name = "Blue Beast's Bone", ItemId = "213000200", Description = "青熊獣の骨", EquipmentRarity = "3", CountId = "376", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "213000200", BitNumber = "376"};
        public static readonly Item BlueBeastsClaw = new Item { Name = "Blue Beast's Claw", ItemId = "213000300", Description = "青熊獣の爪", EquipmentRarity = "3", CountId = "377", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "213000300", BitNumber = "377"};
        public static readonly Item BlueBeastPieceI = new Item { Name = "Blue Beast Piece I", ItemId = "213000400", Description = "青熊獣の部位証Ⅰ", EquipmentRarity = "3", CountId = "378", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "213000400", BitNumber = "378"};
        public static readonly Item SeaDrakesScale = new Item { Name = "Sea Drake's Scale", ItemId = "213000500", Description = "海竜の鱗", EquipmentRarity = "4", CountId = "379", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "213000500", BitNumber = "379"};
        public static readonly Item SeaDrakesBone = new Item { Name = "Sea Drake's Bone", ItemId = "213000600", Description = "海竜の骨", EquipmentRarity = "4", CountId = "380", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "213000600", BitNumber = "380"};
        public static readonly Item SeaDrakesClaw = new Item { Name = "Sea Drake's Claw", ItemId = "213000700", Description = "海竜の爪", EquipmentRarity = "4", CountId = "381", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "213000700", BitNumber = "381"};
        public static readonly Item SeaDrakePieceI = new Item { Name = "Sea Drake Piece I", ItemId = "213000800", Description = "海竜の部位証Ⅰ", EquipmentRarity = "4", CountId = "382", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "213000800", BitNumber = "382"};
        public static readonly Item RageDrakesSkin = new Item { Name = "Rage Drake's Skin", ItemId = "213000900", Description = "恐暴竜の皮", EquipmentRarity = "5", CountId = "383", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "213000900", BitNumber = "383"};
        public static readonly Item RageDrakesBone = new Item { Name = "Rage Drake's Bone", ItemId = "213001000", Description = "恐暴竜の骨", EquipmentRarity = "5", CountId = "384", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "213001000", BitNumber = "384"};
        public static readonly Item RageDrakesFang = new Item { Name = "Rage Drake's Fang", ItemId = "213001100", Description = "恐暴竜の牙", EquipmentRarity = "5", CountId = "385", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "213001100", BitNumber = "385"};
        public static readonly Item RageDrakePieceI = new Item { Name = "Rage Drake Piece I", ItemId = "213001200", Description = "恐暴竜の部位証Ⅰ", EquipmentRarity = "5", CountId = "386", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "213001200", BitNumber = "386"};
        public static readonly Item RedBeastsShell = new Item { Name = "Red Beast's Shell", ItemId = "213001300", Description = "赤甲獣の甲殻", EquipmentRarity = "3", CountId = "387", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "213001300", BitNumber = "387"};
        public static readonly Item RedBeastsBone = new Item { Name = "Red Beast's Bone", ItemId = "213001400", Description = "赤甲獣の骨", EquipmentRarity = "3", CountId = "388", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "213001400", BitNumber = "388"};
        public static readonly Item RedBeastsClaw = new Item { Name = "Red Beast's Claw", ItemId = "213001500", Description = "赤甲獣の爪", EquipmentRarity = "3", CountId = "389", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "213001500", BitNumber = "389"};
        public static readonly Item WolfDrakesBone = new Item { Name = "Wolf Drake's Bone", ItemId = "213001600", Description = "命狼竜の骨", EquipmentRarity = "5", CountId = "390", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "213001600", BitNumber = "390"};
        public static readonly Item WolfDrakesClaw = new Item { Name = "Wolf Drake's Claw", ItemId = "213001700", Description = "命狼竜の爪", EquipmentRarity = "5", CountId = "391", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "213001700", BitNumber = "391"};
        public static readonly Item WolfDrakesShell = new Item { Name = "Wolf Drake's Shell", ItemId = "213001800", Description = "命狼竜の甲殻", EquipmentRarity = "5", CountId = "392", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "213001800", BitNumber = "392"};
        public static readonly Item WhiteFeather = new Item { Name = "White Feather", ItemId = "213001900", Description = "白い羽根", EquipmentRarity = "2", CountId = "393", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "213001900", BitNumber = "393"};
        public static readonly Item RedFeather = new Item { Name = "Red Feather", ItemId = "213002000", Description = "赤い羽根", EquipmentRarity = "2", CountId = "394", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "213002000", BitNumber = "394"};
        public static readonly Item QualitySugar = new Item { Name = "Quality Sugar", ItemId = "214000100", Description = "上質な砂糖", EquipmentRarity = "3", CountId = "397", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "214000100", BitNumber = "397"};
        public static readonly Item DeliciousWater = new Item { Name = "Delicious Water", ItemId = "214000200", Description = "おいしい水", EquipmentRarity = "3", CountId = "398", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "214000200", BitNumber = "398"};
        public static readonly Item CrimsonWing_215000100 = new Item { Name = "Crimson Wing", ItemId = "215000100", Description = "紅魔の翼", EquipmentRarity = "3", CountId = "399", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "215000100", BitNumber = "399"};
        public static readonly Item AshScale = new Item { Name = "Ash Scale", ItemId = "215000200", Description = "薄灰の鱗", EquipmentRarity = "3", CountId = "400", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "215000200", BitNumber = "400"};
        public static readonly Item MysteriousMineral = new Item { Name = "Mysterious Mineral", ItemId = "215000300", Description = "神秘の鉱石", EquipmentRarity = "4", CountId = "401", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "215000300", BitNumber = "401"};
        public static readonly Item AncientMedicine = new Item { Name = "Ancient Medicine", ItemId = "215000400", Description = "太古の秘薬", EquipmentRarity = "4", CountId = "402", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "215000400", BitNumber = "402"};
        public static readonly Item BlessedStone = new Item { Name = "Blessed Stone", ItemId = "215000500", Description = "恵みの石", EquipmentRarity = "4", CountId = "403", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "215000500", BitNumber = "403"};
        public static readonly Item RuinGem = new Item { Name = "Ruin Gem", ItemId = "215000600", Description = "亡国の宝石", EquipmentRarity = "5", CountId = "404", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "215000600", BitNumber = "404"};
        public static readonly Item HairSpray_106302600 = new Item { Name = "Hair Spray", ItemId = "106302600", Description = "ヘアスプレー", EquipmentRarity = "3", CountId = "411", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "106302600", BitNumber = "411"};
        public static readonly Item RedEgg = new Item { Name = "Red Egg", ItemId = "1209000812", Description = "レッドエッグ", EquipmentRarity = "1", CountId = "9036", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000812", BitNumber = "9036"};
        public static readonly Item BlueEgg = new Item { Name = "Blue Egg", ItemId = "1209000813", Description = "ブルーエッグ", EquipmentRarity = "1", CountId = "9037", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000813", BitNumber = "9037"};
        public static readonly Item RainbowEgg = new Item { Name = "Rainbow Egg", ItemId = "1209000814", Description = "レインボーエッグ", EquipmentRarity = "3", CountId = "9038", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000814", BitNumber = "9038"};
        public static readonly Item MetalEgg = new Item { Name = "Metal Egg", ItemId = "1209000815", Description = "メタルエッグ", EquipmentRarity = "3", CountId = "9039", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000815", BitNumber = "9039"};
        public static readonly Item CrystalEggofPower = new Item { Name = "Crystal Egg of Power", ItemId = "1209000816", Description = "力のクリスタルエッグ", EquipmentRarity = "3", CountId = "9040", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000816", BitNumber = "9040"};
        public static readonly Item CrystalEggofMind = new Item { Name = "Crystal Egg of Mind", ItemId = "1209000817", Description = "知のクリスタルエッグ", EquipmentRarity = "3", CountId = "9041", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000817", BitNumber = "9041"};
        public static readonly Item ShadowBahamutGem = new Item { Name = "Shadow Bahamut Gem", ItemId = "1209000818", Description = "幻影竜の宝石", EquipmentRarity = "3", CountId = "9042", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000818", BitNumber = "9042"};
        public static readonly Item ShadowBahamutScale = new Item { Name = "Shadow Bahamut Scale", ItemId = "1209000819", Description = "幻影竜の鱗", EquipmentRarity = "3", CountId = "9043", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000819", BitNumber = "9043"};
        public static readonly Item ShadowBahamutJade = new Item { Name = "Shadow Bahamut Jade", ItemId = "1209000820", Description = "幻影竜の翡翠", EquipmentRarity = "3", CountId = "9044", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000820", BitNumber = "9044"};
        public static readonly Item ShadowBahamutWing = new Item { Name = "Shadow Bahamut Wing", ItemId = "1209000821", Description = "幻影竜の翼", EquipmentRarity = "3", CountId = "9045", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000821", BitNumber = "9045"};
        public static readonly Item ShadowBahamutHeart = new Item { Name = "Shadow Bahamut Heart", ItemId = "1209000822", Description = "幻影竜の心臓", EquipmentRarity = "3", CountId = "9046", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000822", BitNumber = "9046"};
        public static readonly Item ShadowBahamutsOre = new Item { Name = "Shadow Bahamuts Ore", ItemId = "1209000823", Description = "幻影竜の輝石", EquipmentRarity = "3", CountId = "9047", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000823", BitNumber = "9047"};
        public static readonly Item ShadowBahamutFang = new Item { Name = "Shadow Bahamut Fang", ItemId = "1209000824", Description = "幻影竜の牙", EquipmentRarity = "3", CountId = "9048", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000824", BitNumber = "9048"};
        public static readonly Item BahamutRaidCoin = new Item { Name = "Bahamut Raid Coin", ItemId = "1209000825", Description = "バハムートレイドコイン", EquipmentRarity = "3", CountId = "9049", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000825", BitNumber = "9049"};
        public static readonly Item ShardofKelsus = new Item { Name = "Shard of Kelsus", ItemId = "1209000826", Description = "ケルススの欠片", EquipmentRarity = "6", CountId = "9050", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1", ItemIdClone = "1209000826", BitNumber = "9050"};
        public static readonly Item SealedBox = new Item { Name = "Sealed Box", ItemId = "216000700", Description = "封魔の匣", EquipmentRarity = "3", CountId = "423", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "216000700", BitNumber = "423"};
        public static readonly Item CrimsonWing_216000800 = new Item { Name = "Crimson Wing", ItemId = "216000800", Description = "紅玉虫の翅", EquipmentRarity = "4", CountId = "424", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "216000800", BitNumber = "424"};
        public static readonly Item AzureCorundum = new Item { Name = "Azure Corundum", ItemId = "216000900", Description = "碧空の鋼玉", EquipmentRarity = "5", CountId = "425", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "216000900", BitNumber = "425"};
        public static readonly Item MiasmaChunk = new Item { Name = "Miasma Chunk", ItemId = "216001000", Description = "瘴気の塊体", EquipmentRarity = "3", CountId = "426", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "216001000", BitNumber = "426"};
        public static readonly Item AetherochemicalFiber = new Item { Name = "Aetherochemical Fiber", ItemId = "216001100", Description = "魔科学繊維", EquipmentRarity = "4", CountId = "427", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "216001100", BitNumber = "427"};
        public static readonly Item CorruptWeed = new Item { Name = "Corrupt Weed", ItemId = "216001200", Description = "退廃の夜草", EquipmentRarity = "5", CountId = "428", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "216001200", BitNumber = "428"};
        public static readonly Item TitanCoin = new Item { Name = "Titan Coin", ItemId = "106303000", Description = "岩神タイタンレイドコイン", EquipmentRarity = "3", CountId = "422", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106303000", BitNumber = "422"};
        public static readonly Item Relic = new Item { Name = "Relic", ItemId = "1209000808", Description = "レリック", EquipmentRarity = "1", CountId = "9032", IsPotUnit = "5", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "0", ItemIdClone = "1209000808", BitNumber = "9032"};
        public static readonly Item RandomMagicite = new Item { Name = "Random Magicite", ItemId = "1209000809", Description = "何かの魔石", EquipmentRarity = "1", CountId = "9033", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000809", BitNumber = "9033"};
        public static readonly Item RandomMegacryst = new Item { Name = "Random Megacryst", ItemId = "1209000810", Description = "何かの大結晶", EquipmentRarity = "1", CountId = "9034", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000810", BitNumber = "9034"};
        public static readonly Item RandomAwakeningMaterial = new Item { Name = "Random Awakening Material", ItemId = "1209000811", Description = "何かの覚醒素材", EquipmentRarity = "1", CountId = "9035", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000811", BitNumber = "9035"};
        public static readonly Item MinorScrollofHealing = new Item { Name = "Minor Scroll of Healing", ItemId = "1000000005", Description = "ヒーリングスクロール・小", EquipmentRarity = "4", CountId = "9052", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "6000", ItemSellPrice = "450", ItemIdClone = "1000000005", BitNumber = "9052"};
        public static readonly Item GreaterScrollofHealing = new Item { Name = "Greater Scroll of Healing", ItemId = "1000000006", Description = "ヒーリングスクロール・大", EquipmentRarity = "5", CountId = "9053", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "600", ItemIdClone = "1000000006", BitNumber = "9053"};
        public static readonly Item MinorScrollofRecovery = new Item { Name = "Minor Scroll of Recovery", ItemId = "1000000007", Description = "リカバリースクロール・小", EquipmentRarity = "4", CountId = "9054", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "6000", ItemSellPrice = "450", ItemIdClone = "1000000007", BitNumber = "9054"};
        public static readonly Item GreaterScrollofRecovery = new Item { Name = "Greater Scroll of Recovery", ItemId = "1000000008", Description = "リカバリースクロール・大", EquipmentRarity = "5", CountId = "9055", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "600", ItemIdClone = "1000000008", BitNumber = "9055"};
        public static readonly Item ProtagonistHalo = new Item { Name = "Protagonist Halo", ItemId = "1000000009", Description = "主役の光", EquipmentRarity = "4", CountId = "9056", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "6000", ItemSellPrice = "450", ItemIdClone = "1000000009", BitNumber = "9056"};
        public static readonly Item PotionofDeception = new Item { Name = "Potion of Deception", ItemId = "1000000010", Description = "惑わしのポーション", EquipmentRarity = "3", CountId = "9057", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "300", ItemIdClone = "1000000010", BitNumber = "9057"};
        public static readonly Item PotionofCleansing = new Item { Name = "Potion of Cleansing", ItemId = "1000000011", Description = "浄化のポーション", EquipmentRarity = "5", CountId = "9058", IsPotUnit = "2", KeyName = "2", ItemStack = "99", ItemBuyPrice = "8000", ItemSellPrice = "600", ItemIdClone = "1000000011", BitNumber = "9058"};
        public static readonly Item PotionofElementalResistance = new Item { Name = "Potion of Elemental Resistance", ItemId = "1000000012", Description = "属性耐性のポーション", EquipmentRarity = "3", CountId = "9059", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "300", ItemIdClone = "1000000012", BitNumber = "9059"};
        public static readonly Item MinorPotionofRejuvenation = new Item { Name = "Minor Potion of Rejuvenation", ItemId = "1000000013", Description = "回復のポーション・小", EquipmentRarity = "2", CountId = "9060", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "2000", ItemSellPrice = "150", ItemIdClone = "1000000013", BitNumber = "9060"};
        public static readonly Item PotionofRejuvenation = new Item { Name = "Potion of Rejuvenation", ItemId = "1000000014", Description = "回復のポーション・中", EquipmentRarity = "3", CountId = "9061", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "300", ItemIdClone = "1000000014", BitNumber = "9061"};
        public static readonly Item GreaterPotionofRejuvenation = new Item { Name = "Greater Potion of Rejuvenation", ItemId = "1000000015", Description = "回復のポーション・大", EquipmentRarity = "4", CountId = "9062", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "6000", ItemSellPrice = "450", ItemIdClone = "1000000015", BitNumber = "9062"};
        public static readonly Item RandomConsumable = new Item { Name = "Random Consumable", ItemId = "1209000827", Description = "何かの消費アイテム", EquipmentRarity = "1", CountId = "9063", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000827", BitNumber = "9063"};
        public static readonly Item RandomMegacite = new Item { Name = "Random Megacite", ItemId = "1209000828", Description = "何かの大魔石", EquipmentRarity = "1", CountId = "9064", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000828", BitNumber = "9064"};
        public static readonly Item RandomMilcryst = new Item { Name = "Random Milcryst", ItemId = "1209000829", Description = "何かの中晶石", EquipmentRarity = "1", CountId = "9065", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000829", BitNumber = "9065"};
        public static readonly Item RandomHeavicryst = new Item { Name = "Random Heavicryst", ItemId = "1209000830", Description = "何かの大晶石", EquipmentRarity = "1", CountId = "9066", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000830", BitNumber = "9066"};
        public static readonly Item RandomGiancryst = new Item { Name = "Random Giancryst", ItemId = "1209000831", Description = "何かの超晶石", EquipmentRarity = "1", CountId = "9067", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000831", BitNumber = "9067"};
        public static readonly Item CrimsonOre = new Item { Name = "Crimson Ore", ItemId = "1106300102", Description = "紅い鉱石", EquipmentRarity = "3", CountId = "9051", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "1106300102", BitNumber = "9051"};
        public static readonly Item MetalGigantuarCoin_1209000832 = new Item { Name = "Metal Gigantuar Coin", ItemId = "1209000832", Description = "Metal Gigantuar Coin", EquipmentRarity = "8", CountId = "9068", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10000", ItemSellPrice = "100", ItemIdClone = "1209000832", BitNumber = "9068"};
        public static readonly Item SummonTicket = new Item { Name = "10+1 Summon Ticket", ItemId = "1300000005", Description = "10+1 召喚チケット", EquipmentRarity = "8", CountId = "9069", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "0", ItemIdClone = "1300000005", BitNumber = "9069"};
        public static readonly Item ThankYouCandy = new Item { Name = "Thank You Candy", ItemId = "101003400", Description = "お返しのキャンディ", EquipmentRarity = "8", CountId = "429", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "101003400", BitNumber = "429"};
        public static readonly Item ContestRaidCoin = new Item { Name = "Contest Raid Coin", ItemId = "106302800", Description = "コンテストレイドコイン", EquipmentRarity = "3", CountId = "414", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106302800", BitNumber = "414"};
        public static readonly Item DebasedCoin = new Item { Name = "Debased Coin", ItemId = "106302900", Description = "ふるい小銭", EquipmentRarity = "3", CountId = "421", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106302900", BitNumber = "421"};
        public static readonly Item Ticket = new Item { Name = "Ticket", ItemId = "106303100", Description = "おしばいのチケット", EquipmentRarity = "3", CountId = "430", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106303100", BitNumber = "430"};
        public static readonly Item EngelsRaidCoin = new Item { Name = "Engels Raid Coin", ItemId = "106303200", Description = "エンゲルスレイドコイン", EquipmentRarity = "3", CountId = "437", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106303200", BitNumber = "437"};
        public static readonly Item AlBhedPrimer = new Item { Name = "Al Bhed Primer", ItemId = "106303300", Description = "アルベド語辞書", EquipmentRarity = "3", CountId = "438", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106303300", BitNumber = "438"};
        public static readonly Item TwilightFeather = new Item { Name = "Twilight Feather", ItemId = "216000100", Description = "黄昏色の羽根", EquipmentRarity = "3", CountId = "415", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "216000100", BitNumber = "415"};
        public static readonly Item PureThread = new Item { Name = "Pure Thread", ItemId = "216000200", Description = "純白の柔糸", EquipmentRarity = "3", CountId = "416", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "216000200", BitNumber = "416"};
        public static readonly Item WornBlueprint = new Item { Name = "Worn Blueprint", ItemId = "216000300", Description = "破れた設計図", EquipmentRarity = "4", CountId = "417", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "216000300", BitNumber = "417"};
        public static readonly Item SteelBone = new Item { Name = "Steel Bone", ItemId = "216000400", Description = "鋼鉄の骨", EquipmentRarity = "4", CountId = "418", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "216000400", BitNumber = "418"};
        public static readonly Item BlackOil = new Item { Name = "Black Oil", ItemId = "216000500", Description = "黒燃液", EquipmentRarity = "4", CountId = "419", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "216000500", BitNumber = "419"};
        public static readonly Item MagicParts = new Item { Name = "Magic Parts", ItemId = "216000600", Description = "魔導パーツ", EquipmentRarity = "5", CountId = "420", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "216000600", BitNumber = "420"};
        public static readonly Item BrokenCircuit = new Item { Name = "Broken Circuit", ItemId = "217000100", Description = "壊れた回路", EquipmentRarity = "3", CountId = "431", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "217000100", BitNumber = "431"};
        public static readonly Item RustedLump = new Item { Name = "Rusted Lump", ItemId = "217000200", Description = "錆びた塊", EquipmentRarity = "3", CountId = "432", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "217000200", BitNumber = "432"};
        public static readonly Item TitaniumAlloy = new Item { Name = "Titanium Alloy", ItemId = "217000300", Description = "チタン合金", EquipmentRarity = "4", CountId = "433", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "217000300", BitNumber = "433"};
        public static readonly Item BlackPearl = new Item { Name = "Black Pearl", ItemId = "217000400", Description = "黒真珠", EquipmentRarity = "4", CountId = "434", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "217000400", BitNumber = "434"};
        public static readonly Item MeteorLight = new Item { Name = "Meteor Light", ItemId = "217000500", Description = "メテオライト", EquipmentRarity = "4", CountId = "435", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "217000500", BitNumber = "435"};
        public static readonly Item BlackBox = new Item { Name = "Black Box", ItemId = "217000600", Description = "ブラックボックス", EquipmentRarity = "5", CountId = "436", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "217000600", BitNumber = "436"};
        public static readonly Item Hairpin = new Item { Name = "Hairpin", ItemId = "1209000833", Description = "髪飾り", EquipmentRarity = "3", CountId = "9070", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "1209000833", BitNumber = "395"};
        public static readonly Item MagmaRockFragments = new Item { Name = "Magma Rock Fragments", ItemId = "1209000834", Description = "Magma Rock Fragments", EquipmentRarity = "3", CountId = "9073", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "1209000834", BitNumber = "9073"};
        public static readonly Item MusicalGem = new Item { Name = "Musical Gem", ItemId = "1209000835", Description = "Musical Gem", EquipmentRarity = "3", CountId = "9071", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "1209000835", BitNumber = "9070"};
        public static readonly Item MetalGigantuarCoin_1209000837 = new Item { Name = "Metal Gigantuar Coin", ItemId = "1209000837", Description = "メタルジャボテンコイン", EquipmentRarity = "8", CountId = "9073", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10000", ItemSellPrice = "100", ItemIdClone = "1209000832", BitNumber = "9072"};
        public static readonly Item Lantern = new Item { Name = "Lantern", ItemId = "1209000836", Description = "ランタン", EquipmentRarity = "3", CountId = "9072", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "1100000095", BitNumber = "9071"};
        public static readonly Item MetalGigantuarCoin_1209000839 = new Item { Name = "Metal Gigantuar Coin", ItemId = "1209000839", Description = "メタルジャボテンコイン", EquipmentRarity = "8", CountId = "9074", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10000", ItemSellPrice = "100", ItemIdClone = "1209000832", BitNumber = "9074"};
        public static readonly Item MetalGigantuarCoin_1209000847 = new Item { Name = "Metal Gigantuar Coin", ItemId = "1209000847", Description = "Metal Gigantuar Coin(Korea)", EquipmentRarity = "8", CountId = "9083", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10000", ItemSellPrice = "100", ItemIdClone = "1209000832", BitNumber = "9083"};
        public static readonly Item MetalGigantuarCoin_1209000848 = new Item { Name = "Metal Gigantuar Coin", ItemId = "1209000848", Description = "Metal Gigantuar Coin(LA)", EquipmentRarity = "8", CountId = "9084", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10000", ItemSellPrice = "0", ItemIdClone = "1209000832", BitNumber = "9084"};
        public static readonly Item SkeletonKey = new Item { Name = "Skeleton Key", ItemId = "1209000838", Description = "スケルトンキー", EquipmentRarity = "8", CountId = "9075", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10000", ItemSellPrice = "100", ItemIdClone = "1209000838", BitNumber = "9075"};
        public static readonly Item RamseysPillow = new Item { Name = "Ramsey's Pillow", ItemId = "105006100", Description = "ラムジィのまくら", EquipmentRarity = "2", CountId = "440", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "105006100", BitNumber = "440"};
        public static readonly Item MonkeyBaby = new Item { Name = "Monkey Baby", ItemId = "105006200", Description = "モンキーベイビー", EquipmentRarity = "2", CountId = "441", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "200", ItemSellPrice = "20", ItemIdClone = "105006200", BitNumber = "441"};
        public static readonly Item EsperOre = new Item { Name = "Esper Ore", ItemId = "106210200", Description = "幻鉱", EquipmentRarity = "8", CountId = "459", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "106210200", BitNumber = "459"};
        public static readonly Item RedEsperOre = new Item { Name = "Red Esper Ore", ItemId = "106210300", Description = "赤幻鉱", EquipmentRarity = "8", CountId = "460", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "106210300", BitNumber = "460"};
        public static readonly Item BlueEsperOre = new Item { Name = "Blue Esper Ore", ItemId = "106210400", Description = "青幻鉱", EquipmentRarity = "8", CountId = "461", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "106210400", BitNumber = "461"};
        public static readonly Item GreenEsperOre = new Item { Name = "Green Esper Ore", ItemId = "106210500", Description = "緑幻鉱", EquipmentRarity = "8", CountId = "462", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "106210500", BitNumber = "462"};
        public static readonly Item WhiteEsperOre = new Item { Name = "White Esper Ore", ItemId = "106210600", Description = "白幻鉱", EquipmentRarity = "8", CountId = "463", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "106210600", BitNumber = "463"};
        public static readonly Item BlackEsperOre = new Item { Name = "Black Esper Ore", ItemId = "106210700", Description = "黒幻鉱", EquipmentRarity = "8", CountId = "464", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "106210700", BitNumber = "464"};
        public static readonly Item YellowEsperOre = new Item { Name = "Yellow Esper Ore", ItemId = "106210800", Description = "黄幻鉱", EquipmentRarity = "8", CountId = "465", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "106210800", BitNumber = "465"};
        public static readonly Item OrangeEsperOre = new Item { Name = "Orange Esper Ore", ItemId = "106210900", Description = "橙幻鉱", EquipmentRarity = "8", CountId = "466", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "106210900", BitNumber = "466"};
        public static readonly Item VioletEsperOre = new Item { Name = "Violet Esper Ore", ItemId = "106211000", Description = "紫幻鉱", EquipmentRarity = "8", CountId = "467", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "106211000", BitNumber = "467"};
        public static readonly Item CrimsonGem = new Item { Name = "Crimson Gem", ItemId = "106211100", Description = "紅宝玉", EquipmentRarity = "8", CountId = "509", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "106211100", BitNumber = "509"};
        public static readonly Item GarudaRaidCoin = new Item { Name = "Garuda Raid Coin", ItemId = "106303400", Description = "嵐神ガルーダレイドコイン", EquipmentRarity = "3", CountId = "439", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106303400", BitNumber = "439"};
        public static readonly Item MAXManipleRaidCoin = new Item { Name = "MA-X Maniple Raid Coin", ItemId = "106303500", Description = "マニプルスレイドコイン", EquipmentRarity = "3", CountId = "442", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106303500", BitNumber = "442"};
        public static readonly Item UrutanFlower = new Item { Name = "Urutan Flower", ItemId = "106303600", Description = "ウルタンの花", EquipmentRarity = "3", CountId = "457", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106303600", BitNumber = "457"};
        public static readonly Item CharybdisRaidCoin = new Item { Name = "Charybdis Raid Coin", ItemId = "106303700", Description = "カリュブディスレイドコイン", EquipmentRarity = "3", CountId = "474", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106303700", BitNumber = "474"};
        public static readonly Item PinkTail = new Item { Name = "Pink Tail", ItemId = "106303800", Description = "ピンクのしっぽ", EquipmentRarity = "3", CountId = "475", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106303800", BitNumber = "475"};
        public static readonly Item NianBeastRaidCoin = new Item { Name = "Nian Beast Raid Coin", ItemId = "106303900", Description = "年獣レイドコイン", EquipmentRarity = "3", CountId = "476", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106303900", BitNumber = "476"};
        public static readonly Item EtchedCoin = new Item { Name = "Etched Coin", ItemId = "106304000", Description = "賢女のメダル", EquipmentRarity = "3", CountId = "483", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106304000", BitNumber = "483"};
        public static readonly Item JieRevorseRaidCoin = new Item { Name = "Jie Revorse Raid Coin", ItemId = "106304100", Description = "ジエ・リヴォースレイドコイン", EquipmentRarity = "3", CountId = "514", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106304100", BitNumber = "514"};
        public static readonly Item TrainingBokken = new Item { Name = "Training Bokken", ItemId = "106304200", Description = "訓練用の木剣", EquipmentRarity = "3", CountId = "521", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106304200", BitNumber = "521"};
        public static readonly Item RedSupercite = new Item { Name = "Red Supercite", ItemId = "107002700", Description = "赤の超魔石", EquipmentRarity = "6", CountId = "443", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "107002700", BitNumber = "443"};
        public static readonly Item BlueSupercite = new Item { Name = "Blue Supercite", ItemId = "107002800", Description = "青の超魔石", EquipmentRarity = "6", CountId = "444", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "107002800", BitNumber = "444"};
        public static readonly Item GreenSupercite = new Item { Name = "Green Supercite", ItemId = "107002900", Description = "緑の超魔石", EquipmentRarity = "6", CountId = "445", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "107002900", BitNumber = "445"};
        public static readonly Item WhiteSupercite = new Item { Name = "White Supercite", ItemId = "107003000", Description = "白の超魔石", EquipmentRarity = "7", CountId = "446", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "7000", ItemSellPrice = "700", ItemIdClone = "107003000", BitNumber = "446"};
        public static readonly Item BlackSupercite = new Item { Name = "Black Supercite", ItemId = "107003100", Description = "黒の超魔石", EquipmentRarity = "7", CountId = "447", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "7000", ItemSellPrice = "700", ItemIdClone = "107003100", BitNumber = "447"};
        public static readonly Item YellowSupercite = new Item { Name = "Yellow Supercite", ItemId = "107003200", Description = "黄の超魔石", EquipmentRarity = "6", CountId = "448", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "107003200", BitNumber = "448"};
        public static readonly Item OrangeSupercite = new Item { Name = "Orange Supercite", ItemId = "107003300", Description = "橙の超魔石", EquipmentRarity = "6", CountId = "449", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "107003300", BitNumber = "449"};
        public static readonly Item VioletSupercite = new Item { Name = "Violet Supercite", ItemId = "107003400", Description = "紫の超魔石", EquipmentRarity = "6", CountId = "450", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "107003400", BitNumber = "450"};
        public static readonly Item SectoredCircleBlue_109301000 = new Item { Name = "Sectored Circle - Blue 1", ItemId = "109301000", Description = "石板の欠片・青1", EquipmentRarity = "7", CountId = "484", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109301000", BitNumber = "484"};
        public static readonly Item SectoredCircleBlue_109301010 = new Item { Name = "Sectored Circle - Blue 2", ItemId = "109301010", Description = "石板の欠片・青2", EquipmentRarity = "7", CountId = "485", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109301010", BitNumber = "485"};
        public static readonly Item SectoredCircleBlue_109301020 = new Item { Name = "Sectored Circle - Blue 3", ItemId = "109301020", Description = "石板の欠片・青3", EquipmentRarity = "7", CountId = "486", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109301020", BitNumber = "486"};
        public static readonly Item SectoredCircleBlue_109301030 = new Item { Name = "Sectored Circle - Blue 4", ItemId = "109301030", Description = "石板の欠片・青4", EquipmentRarity = "7", CountId = "487", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109301030", BitNumber = "487"};
        public static readonly Item SectoredCircleBlue_109301040 = new Item { Name = "Sectored Circle - Blue 5", ItemId = "109301040", Description = "石板の欠片・青5", EquipmentRarity = "7", CountId = "488", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109301040", BitNumber = "488"};
        public static readonly Item SectoredCircleBlue_109301050 = new Item { Name = "Sectored Circle - Blue 6", ItemId = "109301050", Description = "石板の欠片・青6", EquipmentRarity = "7", CountId = "489", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109301050", BitNumber = "489"};
        public static readonly Item CorrosivePowder = new Item { Name = "Corrosive Powder", ItemId = "205000300", Description = "侵食の粉", EquipmentRarity = "5", CountId = "508", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "205000300", BitNumber = "508"};
        public static readonly Item EarthGemstone = new Item { Name = "Earth Gemstone", ItemId = "218000100", Description = "地の宝玉", EquipmentRarity = "5", CountId = "451", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "218000100", BitNumber = "451"};
        public static readonly Item LaserSensor = new Item { Name = "Laser Sensor", ItemId = "218000200", Description = "レーザーセンサー", EquipmentRarity = "4", CountId = "452", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "218000200", BitNumber = "452"};
        public static readonly Item MythrilShaft = new Item { Name = "Mythril Shaft", ItemId = "218000300", Description = "ミスリルジョイント", EquipmentRarity = "4", CountId = "453", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "218000300", BitNumber = "453"};
        public static readonly Item ElectrolyticCondenser = new Item { Name = "Electrolytic Condenser", ItemId = "218000400", Description = "電解コンデンサ", EquipmentRarity = "3", CountId = "454", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "218000400", BitNumber = "454"};
        public static readonly Item IronShavings = new Item { Name = "Iron Shavings", ItemId = "218000500", Description = "くず鉄の塊", EquipmentRarity = "3", CountId = "455", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "218000500", BitNumber = "455"};
        public static readonly Item MetalScrap = new Item { Name = "Metal Scrap", ItemId = "218000600", Description = "金属のかけら", EquipmentRarity = "3", CountId = "456", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "218000600", BitNumber = "456"};
        public static readonly Item DarkMatterFragment = new Item { Name = "Dark Matter Fragment", ItemId = "218000700", Description = "ダークマターの欠片", EquipmentRarity = "5", CountId = "468", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "218000700", BitNumber = "468"};
        public static readonly Item SnowCrystal = new Item { Name = "Snow Crystal", ItemId = "218000800", Description = "六花晶", EquipmentRarity = "4", CountId = "469", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "218000800", BitNumber = "469"};
        public static readonly Item FairyWing = new Item { Name = "Fairy Wing", ItemId = "218000900", Description = "妖精の羽根", EquipmentRarity = "4", CountId = "470", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "218000900", BitNumber = "470"};
        public static readonly Item BugFeeler = new Item { Name = "Bug Feeler", ItemId = "218001000", Description = "虫の触角", EquipmentRarity = "3", CountId = "471", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "218001000", BitNumber = "471"};
        public static readonly Item GhoulBone = new Item { Name = "Ghoul Bone", ItemId = "218001100", Description = "死霊の骨", EquipmentRarity = "3", CountId = "472", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "218001100", BitNumber = "472"};
        public static readonly Item MonsterFiber = new Item { Name = "Monster Fiber", ItemId = "218001200", Description = "魔物の繊維", EquipmentRarity = "3", CountId = "473", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "218001200", BitNumber = "473"};
        public static readonly Item MagicEgg = new Item { Name = "Magic Egg", ItemId = "219000100", Description = "魔力の卵", EquipmentRarity = "5", CountId = "477", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "219000100", BitNumber = "477"};
        public static readonly Item DemonHeart_219000200 = new Item { Name = "Demon Heart", ItemId = "219000200", Description = "悪魔の心臓", EquipmentRarity = "4", CountId = "478", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "219000200", BitNumber = "478"};
        public static readonly Item LotusFang = new Item { Name = "Lotus Fang", ItemId = "219000300", Description = "紅蓮の牙", EquipmentRarity = "4", CountId = "479", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "219000300", BitNumber = "479"};
        public static readonly Item BloodiedBone = new Item { Name = "Bloodied Bone", ItemId = "219000400", Description = "血染めの骨", EquipmentRarity = "4", CountId = "480", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "219000400", BitNumber = "480"};
        public static readonly Item GreyPelt = new Item { Name = "Grey Pelt", ItemId = "219000500", Description = "鈍色の皮", EquipmentRarity = "3", CountId = "481", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "219000500", BitNumber = "481"};
        public static readonly Item RottenMeat = new Item { Name = "Rotten Meat", ItemId = "219000600", Description = "腐った肉", EquipmentRarity = "3", CountId = "482", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "219000600", BitNumber = "482"};
        public static readonly Item PhilosophersStone = new Item { Name = "Philosopher's Stone", ItemId = "220000100", Description = "賢者の石", EquipmentRarity = "5", CountId = "515", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "220000100", BitNumber = "515"};
        public static readonly Item Moonstone = new Item { Name = "Moonstone", ItemId = "220000200", Description = "ムーナイト", EquipmentRarity = "4", CountId = "516", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "220000200", BitNumber = "516"};
        public static readonly Item SmithyHammer = new Item { Name = "Smithy Hammer", ItemId = "220000300", Description = "スミッティーハンマー", EquipmentRarity = "4", CountId = "517", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "220000300", BitNumber = "517"};
        public static readonly Item VelvetRibbon = new Item { Name = "Velvet Ribbon", ItemId = "220000400", Description = "ベルベットリボン", EquipmentRarity = "4", CountId = "518", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "220000400", BitNumber = "518"};
        public static readonly Item CarbonFiber = new Item { Name = "Carbon Fiber", ItemId = "220000500", Description = "カーボンファイバー", EquipmentRarity = "3", CountId = "519", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "220000500", BitNumber = "519"};
        public static readonly Item Iron = new Item { Name = "Iron", ItemId = "220000600", Description = "アイアン", EquipmentRarity = "3", CountId = "520", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "220000600", BitNumber = "520"};
        public static readonly Item MusicalCoin = new Item { Name = "Musical Coin", ItemId = "1209000840", Description = "ミュージックコイン", EquipmentRarity = "8", CountId = "9076", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000840", BitNumber = "9076"};
        public static readonly Item PurpleNailPolish = new Item { Name = "Purple Nail Polish", ItemId = "1209000841", Description = "パープルマニキュア", EquipmentRarity = "3", CountId = "9077", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000841", BitNumber = "9077"};
        public static readonly Item PurpleLipstick = new Item { Name = "Purple Lipstick", ItemId = "1209000842", Description = "パープルリップスティック", EquipmentRarity = "4", CountId = "9078", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000842", BitNumber = "9078"};
        public static readonly Item PurpleHairSpray = new Item { Name = "Purple Hair Spray", ItemId = "1209000843", Description = "パープルヘアスプレー", EquipmentRarity = "4", CountId = "9079", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000843", BitNumber = "9079"};
        public static readonly Item PurplePerfume = new Item { Name = "Purple Perfume", ItemId = "1209000844", Description = "パープルパフューム", EquipmentRarity = "5", CountId = "9080", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000844", BitNumber = "9080"};
        public static readonly Item CDAlbum = new Item { Name = "CD Album", ItemId = "1209000845", Description = "CDアルバム", EquipmentRarity = "5", CountId = "9081", IsPotUnit = "0", KeyName = "0", ItemStack = "999", ItemBuyPrice = "1000", ItemSellPrice = "500", ItemIdClone = "1209000845", BitNumber = "9081"};
        public static readonly Item GlitteringShard = new Item { Name = "Glittering Shard", ItemId = "1209000846", Description = "キラキラの欠片", EquipmentRarity = "8", CountId = "9082", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000000", ItemSellPrice = "100000", ItemIdClone = "1209000846", BitNumber = "9082"};
        public static readonly Item CandyCane = new Item { Name = "Candy Cane", ItemId = "1209000849", Description = "Candy Cane", EquipmentRarity = "3", CountId = "9084", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000849", BitNumber = "9084"};
        public static readonly Item GlowingStar = new Item { Name = "Glowing Star", ItemId = "1209000850", Description = "Glowing Star", EquipmentRarity = "5", CountId = "9085", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "5000", ItemSellPrice = "50", ItemIdClone = "1209000850", BitNumber = "9085"};
        public static readonly Item KhalamMedal = new Item { Name = "Khalam Medal", ItemId = "1209000851", Description = "カーラムメダル", EquipmentRarity = "3", CountId = "9086", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "10000", ItemSellPrice = "10", ItemIdClone = "1209000851", BitNumber = "9086"};
        public static readonly Item RoyalFireOrb = new Item { Name = "Royal Fire Orb", ItemId = "1209000852", Description = "火のキングオーブ", EquipmentRarity = "4", CountId = "9087", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000852", BitNumber = "9087"};
        public static readonly Item RoyalEarthOrb = new Item { Name = "Royal Earth Orb", ItemId = "1209000853", Description = "土のキングオーブ", EquipmentRarity = "4", CountId = "9088", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000853", BitNumber = "9088"};
        public static readonly Item RoyalWindOrb = new Item { Name = "Royal Wind Orb", ItemId = "1209000854", Description = "風のキングオーブ", EquipmentRarity = "4", CountId = "9089", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000854", BitNumber = "9089"};
        public static readonly Item RoyalWaterOrb = new Item { Name = "Royal Water Orb", ItemId = "1209000855", Description = "水のキングオーブ", EquipmentRarity = "4", CountId = "9090", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000855", BitNumber = "9090"};
        public static readonly Item RoyalDarkOrb = new Item { Name = "Royal Dark Orb", ItemId = "1209000856", Description = "闇のキングオーブ", EquipmentRarity = "4", CountId = "9091", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000856", BitNumber = "9091"};
        public static readonly Item RoyalLightOrb = new Item { Name = "Royal Light Orb", ItemId = "1209000857", Description = "光のキングオーブ", EquipmentRarity = "4", CountId = "9092", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000857", BitNumber = "9092"};
        public static readonly Item Regalite = new Item { Name = "Regalite", ItemId = "1209000858", Description = "キングストーン", EquipmentRarity = "5", CountId = "9093", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000858", BitNumber = "9093"};
        public static readonly Item TungOil = new Item { Name = "Tung Oil", ItemId = "1209000859", Description = "桐油", EquipmentRarity = "5", CountId = "9094", IsPotUnit = "0", KeyName = "0", ItemStack = "999", ItemBuyPrice = "10000", ItemSellPrice = "100", ItemIdClone = "1209000859", BitNumber = "9094"};
        public static readonly Item MoonJade = new Item { Name = "Moon Jade", ItemId = "1209000860", Description = "月の翡翠", EquipmentRarity = "6", CountId = "9095", IsPotUnit = "0", KeyName = "0", ItemStack = "999", ItemBuyPrice = "20000", ItemSellPrice = "200", ItemIdClone = "1209000860", BitNumber = "9095"};
        public static readonly Item SunJade = new Item { Name = "Sun Jade ", ItemId = "1209000861", Description = "太陽の翡翠", EquipmentRarity = "6", CountId = "9096", IsPotUnit = "0", KeyName = "0", ItemStack = "999", ItemBuyPrice = "20000", ItemSellPrice = "200", ItemIdClone = "1209000861", BitNumber = "9096"};
        public static readonly Item FireOpal = new Item { Name = "Fire Opal", ItemId = "1209000862", Description = "ファイアーオパール", EquipmentRarity = "7", CountId = "9097", IsPotUnit = "0", KeyName = "0", ItemStack = "999", ItemBuyPrice = "50000", ItemSellPrice = "500", ItemIdClone = "1209000862", BitNumber = "9097"};
        public static readonly Item RedFlax = new Item { Name = "Red Flax", ItemId = "1209000863", Description = "赤色の亜麻", EquipmentRarity = "3", CountId = "9098", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "5", ItemIdClone = "1209000863", BitNumber = "9098"};
        public static readonly Item GoldFlax = new Item { Name = "Gold Flax", ItemId = "1209000864", Description = "金色の亜麻", EquipmentRarity = "4", CountId = "9099", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000864", BitNumber = "9099"};
        public static readonly Item YellowDisk = new Item { Name = "Yellow Disk", ItemId = "1209000865", Description = "Yellow Disk (Raid Coin)", EquipmentRarity = "4", CountId = "9100", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000865", BitNumber = "9100"};
        public static readonly Item GunmetalAlloy_1209000866 = new Item { Name = "Gunmetal Alloy", ItemId = "1209000866", Description = "Gunmetal Alloy", EquipmentRarity = "4", CountId = "9101", IsPotUnit = "0", KeyName = "0", ItemStack = "999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000866", BitNumber = "9101"};
        public static readonly Item SealedTreasure = new Item { Name = "Sealed Treasure", ItemId = "1209000867", Description = "Sealed Treasure", EquipmentRarity = "4", CountId = "9102", IsPotUnit = "0", KeyName = "0", ItemStack = "999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000867", BitNumber = "9102"};
        public static readonly Item GlitzGem_1209000868 = new Item { Name = "Glitz Gem", ItemId = "1209000868", Description = "Glitz Gem", EquipmentRarity = "4", CountId = "9103", IsPotUnit = "0", KeyName = "0", ItemStack = "999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000868", BitNumber = "9103"};
        public static readonly Item DenseOre_1209000869 = new Item { Name = "Dense Ore", ItemId = "1209000869", Description = "Dense Ore", EquipmentRarity = "4", CountId = "9104", IsPotUnit = "0", KeyName = "0", ItemStack = "999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000869", BitNumber = "9104"};
        public static readonly Item Gunpowder_1209000870 = new Item { Name = "Gunpowder", ItemId = "1209000870", Description = "Gun powder", EquipmentRarity = "5", CountId = "9105", IsPotUnit = "0", KeyName = "0", ItemStack = "999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000870", BitNumber = "9105"};
        public static readonly Item MillionDownloadsTicket_1209000871 = new Item { Name = "30 Million Downloads Ticket", ItemId = "1209000871", Description = "30 million downloads celebratory ticket", EquipmentRarity = "8", CountId = "9106", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "0", ItemIdClone = "1209000871", BitNumber = "9106"};
        public static readonly Item PetalToken = new Item { Name = "Petal Token", ItemId = "1209000881", Description = "花びらトークン", EquipmentRarity = "3", CountId = "9116", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "1209000872", BitNumber = "9116"};
        public static readonly Item BlueandRedSupercites = new Item { Name = "Blue and Red Supercites", ItemId = "1209000872", Description = "Blue and Red Supercites", EquipmentRarity = "6", CountId = "9107", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000873", BitNumber = "9107"};
        public static readonly Item VioletandYellowSupercites = new Item { Name = "Violet and Yellow Supercites", ItemId = "1209000873", Description = "Violet and Yellow Supercites", EquipmentRarity = "6", CountId = "9108", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000874", BitNumber = "9108"};
        public static readonly Item OrangeandWhiteSupercites = new Item { Name = "Orange and White Supercites", ItemId = "1209000874", Description = "Orange and White Supercites", EquipmentRarity = "6", CountId = "9109", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000875", BitNumber = "9109"};
        public static readonly Item GreenandBlackSupercites = new Item { Name = "Green and Black Supercites", ItemId = "1209000875", Description = "Green and Black Supercites", EquipmentRarity = "6", CountId = "9110", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000876", BitNumber = "9110"};
        public static readonly Item FinasChocolateII = new Item { Name = "Fina's Chocolate II", ItemId = "101003500", Description = "フィーナのチョコレート・II", EquipmentRarity = "8", CountId = "726", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "101003500", BitNumber = "635"};
        public static readonly Item SakurasChocolate = new Item { Name = "Sakura's Chocolate", ItemId = "101003600", Description = "サクラのチョコレート", EquipmentRarity = "8", CountId = "727", IsPotUnit = "1", KeyName = "6", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "101003600", BitNumber = "636"};
        public static readonly Item LidsChocolate = new Item { Name = "Lid's Chocolate", ItemId = "101003700", Description = "リドのチョコレート", EquipmentRarity = "8", CountId = "728", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "101003700", BitNumber = "637"};
        public static readonly Item RicosChocolate = new Item { Name = "Rico's Chocolate", ItemId = "101003800", Description = "リコのチョコレート", EquipmentRarity = "8", CountId = "729", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "101003800", BitNumber = "638"};
        public static readonly Item ElegantCandy = new Item { Name = "Elegant Candy", ItemId = "101003900", Description = "エレガントキャンディ", EquipmentRarity = "8", CountId = "730", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "101003900", BitNumber = "661"};
        public static readonly Item MegaPhoenix = new Item { Name = "Mega Phoenix", ItemId = "105006300", Description = "メガフェニックス", EquipmentRarity = "8", CountId = "570", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "105006300", BitNumber = "573"};
        public static readonly Item ChilledFoodTin = new Item { Name = "Chilled Food Tin", ItemId = "105006400", Description = "冷えた缶詰", EquipmentRarity = "4", CountId = "602", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "105006400", BitNumber = "601"};
        public static readonly Item StarCurtain = new Item { Name = "Star Curtain", ItemId = "105006500", Description = "星のカーテン", EquipmentRarity = "6", CountId = "722", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "105006500", BitNumber = "631"};
        public static readonly Item BlessedFlag = new Item { Name = "Blessed Flag", ItemId = "105006600", Description = "ブレス・フラッグ", EquipmentRarity = "6", CountId = "723", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "105006600", BitNumber = "632"};
        public static readonly Item ConquerorsGavelAttack = new Item { Name = "Conqueror's Gavel - Attack", ItemId = "105006700", Description = "征服者のガベル・攻", EquipmentRarity = "6", CountId = "724", IsPotUnit = "3", KeyName = "1", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "105006700", BitNumber = "633"};
        public static readonly Item ConquerorsGavelDefense = new Item { Name = "Conqueror's Gavel - Defense", ItemId = "105006800", Description = "征服者のガベル・防", EquipmentRarity = "6", CountId = "743", IsPotUnit = "3", KeyName = "1", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "105006800", BitNumber = "662"};
        public static readonly Item InvigoratingPotionI = new Item { Name = "Invigorating Potion I", ItemId = "105006900", Description = "闘神薬I", EquipmentRarity = "6", CountId = "744", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "105006900", BitNumber = "663"};
        public static readonly Item AzureGem = new Item { Name = "Azure Gem", ItemId = "106211110", Description = "蒼宝玉", EquipmentRarity = "8", CountId = "510", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "106211110", BitNumber = "510"};
        public static readonly Item UnitExchangeTicketBonus = new Item { Name = "Unit Exchange Ticket Bonus", ItemId = "106211150", Description = "特典ユニット交換チケット", EquipmentRarity = "8", CountId = "581", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "106211150", BitNumber = "581"};
        public static readonly Item ndAnniversaryRaidCoin = new Item { Name = "2nd Anniversary Raid Coin", ItemId = "106304300", Description = "2周年記念レイドコイン", EquipmentRarity = "3", CountId = "522", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106304300", BitNumber = "522"};
        public static readonly Item TripleTriadCard = new Item { Name = "Triple Triad Card", ItemId = "106304400", Description = "トリプルトライアドのカード", EquipmentRarity = "3", CountId = "545", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106304400", BitNumber = "545"};
        public static readonly Item EstarkRaidCoin = new Item { Name = "Estark Raid Coin", ItemId = "106304500", Description = "エスタークレイドコイン", EquipmentRarity = "3", CountId = "546", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106304500", BitNumber = "546"};
        public static readonly Item FadedCrystal = new Item { Name = "Faded Crystal", ItemId = "106304600", Description = "変色クリスタル", EquipmentRarity = "3", CountId = "569", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106304600", BitNumber = "572"};
        public static readonly Item GraverobberRaidCoin = new Item { Name = "Graverobber Raid Coin", ItemId = "106304700", Description = "グラープロイバーレイドコイン", EquipmentRarity = "3", CountId = "582", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106304700", BitNumber = "582"};
        public static readonly Item EmptyMagicFlask = new Item { Name = "Empty Magic Flask", ItemId = "106304800", Description = "空のマジックボトル", EquipmentRarity = "3", CountId = "700", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106304800", BitNumber = "585"};
        public static readonly Item BarbarossaRaidCoin = new Item { Name = "Barbarossa Raid Coin", ItemId = "106304900", Description = "バルバロッサレイドコイン", EquipmentRarity = "3", CountId = "583", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106304900", BitNumber = "603"};
        public static readonly Item EverfrostShard = new Item { Name = "Everfrost Shard", ItemId = "106305000", Description = "永久氷柱", EquipmentRarity = "3", CountId = "704", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106305000", BitNumber = "614"};
        public static readonly Item ManaBeastRaidCoin = new Item { Name = "Mana Beast Raid Coin", ItemId = "106305100", Description = "祀られし神獣レイドコイン", EquipmentRarity = "3", CountId = "736", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106305100", BitNumber = "649"};
        public static readonly Item KnowingTag = new Item { Name = "Knowing Tag", ItemId = "106305200", Description = "ノーウィングタグ", EquipmentRarity = "3", CountId = "737", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106305200", BitNumber = "650"};
        public static readonly Item SilversmithRaidCoin = new Item { Name = "Silversmith Raid Coin", ItemId = "106305300", Description = "銀細工師の遺跡レイドコイン", EquipmentRarity = "3", CountId = "740", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106305300", BitNumber = "653"};
        public static readonly Item FangofEarth = new Item { Name = "Fang of Earth", ItemId = "106305400", Description = "土の牙", EquipmentRarity = "3", CountId = "745", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106305400", BitNumber = "670"};
        public static readonly Item SectoredCircleYellow_109302000 = new Item { Name = "Sectored Circle - Yellow 1", ItemId = "109302000", Description = "石板の欠片・黄1", EquipmentRarity = "7", CountId = "490", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109302000", BitNumber = "490"};
        public static readonly Item SectoredCircleYellow_109302010 = new Item { Name = "Sectored Circle - Yellow 2", ItemId = "109302010", Description = "石板の欠片・黄2", EquipmentRarity = "7", CountId = "491", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109302010", BitNumber = "491"};
        public static readonly Item SectoredCircleYellow_109302020 = new Item { Name = "Sectored Circle - Yellow 3", ItemId = "109302020", Description = "石板の欠片・黄3", EquipmentRarity = "7", CountId = "492", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109302020", BitNumber = "492"};
        public static readonly Item SectoredCircleYellow_109302030 = new Item { Name = "Sectored Circle - Yellow 4", ItemId = "109302030", Description = "石板の欠片・黄4", EquipmentRarity = "7", CountId = "493", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109302030", BitNumber = "493"};
        public static readonly Item SectoredCircleYellow_109302040 = new Item { Name = "Sectored Circle - Yellow 5", ItemId = "109302040", Description = "石板の欠片・黄5", EquipmentRarity = "7", CountId = "494", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109302040", BitNumber = "494"};
        public static readonly Item SectoredCircleYellow_109302050 = new Item { Name = "Sectored Circle - Yellow 6", ItemId = "109302050", Description = "石板の欠片・黄6", EquipmentRarity = "7", CountId = "495", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109302050", BitNumber = "495"};
        public static readonly Item TrustMooglesMap = new Item { Name = "Trust Moogles Map", ItemId = "110000100", Description = "トラモグの地図", EquipmentRarity = "7", CountId = "748", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "7000", ItemSellPrice = "700", ItemIdClone = "110000100", BitNumber = "665"};
        public static readonly Item MegacrystsMap = new Item { Name = "Megacrysts Map", ItemId = "110000200", Description = "大結晶の地図", EquipmentRarity = "5", CountId = "749", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "110000200", BitNumber = "666"};
        public static readonly Item RankEXPMap = new Item { Name = "Rank EXP Map", ItemId = "110000300", Description = "ランク経験値の地図", EquipmentRarity = "4", CountId = "750", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "110000300", BitNumber = "667"};
        public static readonly Item MaterialsMap = new Item { Name = "Materials Map", ItemId = "110000400", Description = "覚醒素材の地図", EquipmentRarity = "3", CountId = "751", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "110000400", BitNumber = "668"};
        public static readonly Item StarQuartzMap = new Item { Name = "Star Quartz Map", ItemId = "110000500", Description = "スタークォーツの地図", EquipmentRarity = "3", CountId = "752", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "110000500", BitNumber = "669"};
        public static readonly Item AdamantiteLump = new Item { Name = "Adamantite Lump", ItemId = "203000600", Description = "金剛石塊", EquipmentRarity = "6", CountId = "721", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "203000600", BitNumber = "630"};
        public static readonly Item IllusionStone = new Item { Name = "Illusion Stone", ItemId = "221000100", Description = "幻想石", EquipmentRarity = "5", CountId = "547", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "221000100", BitNumber = "547"};
        public static readonly Item RainbowFeather = new Item { Name = "Rainbow Feather", ItemId = "221000200", Description = "虹色の羽根", EquipmentRarity = "4", CountId = "548", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "221000200", BitNumber = "548"};
        public static readonly Item OrangeGem = new Item { Name = "Orange Gem", ItemId = "221000300", Description = "橙の宝珠", EquipmentRarity = "4", CountId = "549", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "221000300", BitNumber = "549"};
        public static readonly Item StrangePurpleLiquid = new Item { Name = "Strange Purple Liquid", ItemId = "221000400", Description = "謎の紫色の液体", EquipmentRarity = "3", CountId = "550", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "221000400", BitNumber = "550"};
        public static readonly Item MonsterClaw = new Item { Name = "Monster Claw", ItemId = "221000500", Description = "妖魔の爪", EquipmentRarity = "3", CountId = "551", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "221000500", BitNumber = "551"};
        public static readonly Item MedicinalBark = new Item { Name = "Medicinal Bark", ItemId = "221000600", Description = "乾いた薬木", EquipmentRarity = "3", CountId = "552", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "221000600", BitNumber = "552"};
        public static readonly Item IceAlcryst = new Item { Name = "Ice Alcryst", ItemId = "221000700", Description = "氷晶石", EquipmentRarity = "5", CountId = "573", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "221000700", BitNumber = "576"};
        public static readonly Item SnowTree = new Item { Name = "Snow Tree", ItemId = "221000800", Description = "天華の白木", EquipmentRarity = "4", CountId = "574", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "221000800", BitNumber = "577"};
        public static readonly Item WhiteGemcryst = new Item { Name = "White Gemcryst", ItemId = "221000900", Description = "白宝晶", EquipmentRarity = "4", CountId = "575", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "221000900", BitNumber = "578"};
        public static readonly Item CrimsonSilk = new Item { Name = "Crimson Silk", ItemId = "221001000", Description = "真紅の絹糸", EquipmentRarity = "3", CountId = "576", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "221001000", BitNumber = "579"};
        public static readonly Item CrimsonHide = new Item { Name = "Crimson Hide", ItemId = "221001100", Description = "薄紅の皮", EquipmentRarity = "3", CountId = "577", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "221001100", BitNumber = "580"};
        public static readonly Item LapisLazuli = new Item { Name = "Lapis Lazuli", ItemId = "222000100", Description = "ラピス晶石", EquipmentRarity = "5", CountId = "607", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "222000100", BitNumber = "604"};
        public static readonly Item NecklessDoll = new Item { Name = "Neckless Doll", ItemId = "222000200", Description = "首の無い人形", EquipmentRarity = "4", CountId = "608", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "222000200", BitNumber = "605"};
        public static readonly Item BurgundyFlask = new Item { Name = "Burgundy Flask", ItemId = "222000300", Description = "ポルト酒", EquipmentRarity = "4", CountId = "609", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "222000300", BitNumber = "606"};
        public static readonly Item Nightshade = new Item { Name = "Nightshade", ItemId = "222000400", Description = "ベラドンナ", EquipmentRarity = "3", CountId = "610", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "222000400", BitNumber = "607"};
        public static readonly Item BaseMetal = new Item { Name = "Base Metal", ItemId = "222000500", Description = "卑金属", EquipmentRarity = "3", CountId = "611", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "222000500", BitNumber = "608"};
        public static readonly Item MinimumHammer = new Item { Name = "Minimum Hammer", ItemId = "223000100", Description = "ミニマムハンマー", EquipmentRarity = "5", CountId = "612", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "223000100", BitNumber = "644"};
        public static readonly Item BrilliantJam = new Item { Name = "Brilliant Jam", ItemId = "223000200", Description = "ブリリアントゼリー", EquipmentRarity = "4", CountId = "613", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "223000200", BitNumber = "645"};
        public static readonly Item FaerieNut = new Item { Name = "Faerie Nut", ItemId = "223000300", Description = "魔法のきのみ", EquipmentRarity = "4", CountId = "614", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "223000300", BitNumber = "646"};
        public static readonly Item MedicalRoot = new Item { Name = "Medical Root", ItemId = "223000400", Description = "ポイポイ草", EquipmentRarity = "3", CountId = "615", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "223000400", BitNumber = "647"};
        public static readonly Item WeatheredWood = new Item { Name = "Weathered Wood", ItemId = "223000500", Description = "潮風の木材", EquipmentRarity = "3", CountId = "616", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "223000500", BitNumber = "648"};
        public static readonly Item GlitzGem_224000100 = new Item { Name = "Glitz Gem", ItemId = "224000100", Description = "グリッツジェム", EquipmentRarity = "5", CountId = "617", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "224000100", BitNumber = "654"};
        public static readonly Item GunmetalAlloy_224000200 = new Item { Name = "Gunmetal Alloy", ItemId = "224000200", Description = "ガンメタルアロイ", EquipmentRarity = "4", CountId = "618", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "224000200", BitNumber = "655"};
        public static readonly Item SealedTreasureChest = new Item { Name = "Sealed Treasure Chest", ItemId = "224000300", Description = "封じられた宝", EquipmentRarity = "4", CountId = "619", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "224000300", BitNumber = "656"};
        public static readonly Item DenseOre_224000400 = new Item { Name = "Dense Ore", ItemId = "224000400", Description = "デンスオア", EquipmentRarity = "3", CountId = "620", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "224000400", BitNumber = "657"};
        public static readonly Item Gunpowder_224000500 = new Item { Name = "Gunpowder", ItemId = "224000500", Description = "ガンパウダー", EquipmentRarity = "3", CountId = "621", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "224000500", BitNumber = "658"};
        public static readonly Item LightningsPrism = new Item { Name = "Lightning's Prism", ItemId = "300000010", Description = "ライトニングの輝源", EquipmentRarity = "8", CountId = "523", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "523"};
        public static readonly Item RamzasPrism = new Item { Name = "Ramza's Prism", ItemId = "300000020", Description = "ラムザの輝源", EquipmentRarity = "8", CountId = "524", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "524"};
        public static readonly Item DelitasPrism = new Item { Name = "Delita's Prism", ItemId = "300000030", Description = "ディリータの輝源", EquipmentRarity = "8", CountId = "525", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "525"};
        public static readonly Item DarkKnightCecilsPrism = new Item { Name = "Dark Knight Cecil's Prism", ItemId = "300000040", Description = "暗黒騎士セシルの輝源", EquipmentRarity = "8", CountId = "526", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "526"};
        public static readonly Item AcesPrism = new Item { Name = "Ace's Prism", ItemId = "300000050", Description = "エースの輝源", EquipmentRarity = "8", CountId = "527", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "527"};
        public static readonly Item LunethsPrism = new Item { Name = "Luneth's Prism", ItemId = "300000060", Description = "ルーネスの輝源", EquipmentRarity = "8", CountId = "528", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "528"};
        public static readonly Item QueensPrism = new Item { Name = "Queen's Prism", ItemId = "300000070", Description = "クイーンの輝源", EquipmentRarity = "8", CountId = "529", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "529"};
        public static readonly Item DarkFinasPrism = new Item { Name = "Dark Fina's Prism", ItemId = "300000080", Description = "魔人フィーナの輝源", EquipmentRarity = "8", CountId = "530", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "530"};
        public static readonly Item OrlandeausPrism = new Item { Name = "Orlandeau's Prism", ItemId = "300000090", Description = "オルランドゥの輝源", EquipmentRarity = "8", CountId = "531", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "531"};
        public static readonly Item MariesPrism = new Item { Name = "Marie's Prism", ItemId = "300000100", Description = "マリーの輝源", EquipmentRarity = "8", CountId = "532", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "532"};
        public static readonly Item EmperorsPrism = new Item { Name = "Emperor's Prism", ItemId = "300000110", Description = "皇帝の輝源", EquipmentRarity = "8", CountId = "533", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "533"};
        public static readonly Item AileensPrism = new Item { Name = "Aileen's Prism", ItemId = "300000120", Description = "アイリーンの輝源", EquipmentRarity = "8", CountId = "534", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "534"};
        public static readonly Item RemsPrism = new Item { Name = "Rem's Prism", ItemId = "300000130", Description = "レムの輝源", EquipmentRarity = "8", CountId = "535", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "535"};
        public static readonly Item TidussPrism = new Item { Name = "Tidus's Prism", ItemId = "300000140", Description = "ティーダの輝源", EquipmentRarity = "8", CountId = "536", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "536"};
        public static readonly Item WilhelmsPrism = new Item { Name = "Wilhelm's Prism", ItemId = "300000150", Description = "ヴィルヘルムの輝源", EquipmentRarity = "8", CountId = "537", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "537"};
        public static readonly Item SeabreezeDarkFinasPrism = new Item { Name = "Seabreeze Dark Fina's Prism", ItemId = "300000160", Description = "爽涼の魔人フィーナの輝源", EquipmentRarity = "8", CountId = "538", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "538"};
        public static readonly Item TranceTerrasPrism = new Item { Name = "Trance Terra's Prism", ItemId = "300000170", Description = "トランスティナの輝源", EquipmentRarity = "8", CountId = "539", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "539"};
        public static readonly Item FohlensPrism = new Item { Name = "Fohlen's Prism", ItemId = "300000180", Description = "フォーレンの輝源", EquipmentRarity = "8", CountId = "540", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "540"};
        public static readonly Item VeritasoftheDarksPrism = new Item { Name = "Veritas of the Dark's Prism", ItemId = "300000190", Description = "常闇のヴェリアスの輝源", EquipmentRarity = "8", CountId = "541", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "541"};
        public static readonly Item SquallsPrism = new Item { Name = "Squall's Prism", ItemId = "300000200", Description = "スコールの輝源", EquipmentRarity = "8", CountId = "543", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "542"};
        public static readonly Item RinoasPrism = new Item { Name = "Rinoa's Prism", ItemId = "300000210", Description = "リノアの輝源", EquipmentRarity = "8", CountId = "544", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "543"};
        public static readonly Item OnionKnightsPrism = new Item { Name = "Onion Knight's Prism", ItemId = "300000220", Description = "たまねぎ剣士の輝源", EquipmentRarity = "8", CountId = "542", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "544"};
        public static readonly Item NalusPrism = new Item { Name = "Nalu's Prism", ItemId = "300000230", Description = "ナルの輝源", EquipmentRarity = "8", CountId = "584", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "555"};
        public static readonly Item EstarksPrism = new Item { Name = "Estark's Prism", ItemId = "300000240", Description = "エスタークの輝源", EquipmentRarity = "8", CountId = "553", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "556"};
        public static readonly Item MarquisdeLonsPrism = new Item { Name = "Marquis de Léon's Prism", ItemId = "300000250", Description = "キングレオの輝源", EquipmentRarity = "8", CountId = "554", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "557"};
        public static readonly Item DragonlordsPrism = new Item { Name = "Dragonlord's Prism", ItemId = "300000260", Description = "りゅうおうの輝源", EquipmentRarity = "8", CountId = "555", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "558"};
        public static readonly Item LividShantottosPrism = new Item { Name = "Livid Shantotto's Prism", ItemId = "300000270", Description = "ブチ切れシャントットの輝源", EquipmentRarity = "8", CountId = "556", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "559"};
        public static readonly Item ShadowLordsPrism = new Item { Name = "Shadow Lord's Prism", ItemId = "300000280", Description = "闇の王の輝源", EquipmentRarity = "8", CountId = "557", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "560"};
        public static readonly Item LunerasPrism = new Item { Name = "Lunera's Prism", ItemId = "300000290", Description = "ルネラの輝源", EquipmentRarity = "8", CountId = "558", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "561"};
        public static readonly Item PrishesPrism = new Item { Name = "Prishe's Prism", ItemId = "300000300", Description = "プリッシュの輝源", EquipmentRarity = "8", CountId = "559", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "562"};
        public static readonly Item MercenaryRamzasPrism = new Item { Name = "Mercenary Ramza's Prism", ItemId = "300000310", Description = "傭兵ラムザの輝源", EquipmentRarity = "8", CountId = "560", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "563"};
        public static readonly Item KnightDelitasPrism = new Item { Name = "Knight Delita's Prism", ItemId = "300000320", Description = "騎士ディリータの輝源", EquipmentRarity = "8", CountId = "561", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "564"};
        public static readonly Item CloudsPrism = new Item { Name = "Cloud's Prism", ItemId = "300000330", Description = "クラウドの輝源", EquipmentRarity = "8", CountId = "562", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "565"};
        public static readonly Item VeritasoftheFlamesPrism = new Item { Name = "Veritas of the Flame's Prism", ItemId = "300000340", Description = "劫火のヴェリアスの輝源", EquipmentRarity = "8", CountId = "563", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "566"};
        public static readonly Item LorensPrism = new Item { Name = "Loren's Prism", ItemId = "300000350", Description = "ロレーヌの輝源", EquipmentRarity = "8", CountId = "564", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "567"};
        public static readonly Item VeritasoftheLightsPrism = new Item { Name = "Veritas of the Light's Prism", ItemId = "300000360", Description = "光輝のヴェリアスの輝源", EquipmentRarity = "8", CountId = "565", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "568"};
        public static readonly Item NoctissPrism = new Item { Name = "Noctis's Prism", ItemId = "300000370", Description = "ノクティスの輝源", EquipmentRarity = "8", CountId = "566", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "569"};
        public static readonly Item BeatrixsPrism = new Item { Name = "Beatrix's Prism", ItemId = "300000380", Description = "ベアトリクスの輝源", EquipmentRarity = "8", CountId = "567", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "570"};
        public static readonly Item EikosPrism = new Item { Name = "Eiko's Prism", ItemId = "300000390", Description = "エーコの輝源", EquipmentRarity = "8", CountId = "568", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "571"};
        public static readonly Item HyohsPrism = new Item { Name = "Hyoh's Prism", ItemId = "300000400", Description = "ヒョウの輝源", EquipmentRarity = "8", CountId = "571", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "574"};
        public static readonly Item SantaRoseliasPrism = new Item { Name = "Santa Roselia's Prism", ItemId = "300000410", Description = "サンタローゼリアの輝源", EquipmentRarity = "8", CountId = "572", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "575"};
        public static readonly Item IgnissPrism = new Item { Name = "Ignis's Prism", ItemId = "300000420", Description = "イグニスの輝源", EquipmentRarity = "8", CountId = "585", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "583"};
        public static readonly Item RayJacksPrism = new Item { Name = "Ray Jack's Prism", ItemId = "300000430", Description = "レイジャックの輝源", EquipmentRarity = "8", CountId = "601", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "584"};
        public static readonly Item BalthiersPrism = new Item { Name = "Balthier's Prism", ItemId = "300000440", Description = "バルフレアの輝源", EquipmentRarity = "8", CountId = "586", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "586"};
        public static readonly Item GilgameshsPrism = new Item { Name = "Gilgamesh's Prism", ItemId = "300000450", Description = "ギルガメッシュ(FFV)の輝源", EquipmentRarity = "8", CountId = "587", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "587"};
        public static readonly Item AyakasPrism = new Item { Name = "Ayaka's Prism", ItemId = "300000460", Description = "アヤカの輝源", EquipmentRarity = "8", CountId = "588", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "588"};
        public static readonly Item ElfreedasPrism = new Item { Name = "Elfreeda's Prism", ItemId = "300000470", Description = "エルフリーデの輝源", EquipmentRarity = "8", CountId = "589", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "589"};
        public static readonly Item RoysPrism = new Item { Name = "Roy's Prism", ItemId = "300000480", Description = "ロイの輝源", EquipmentRarity = "8", CountId = "590", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "590"};
        public static readonly Item GladiolussPrism = new Item { Name = "Gladiolus's Prism", ItemId = "300000490", Description = "グラディオラスの輝源", EquipmentRarity = "8", CountId = "591", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "591"};
        public static readonly Item DukesPrism = new Item { Name = "Duke's Prism", ItemId = "300000500", Description = "デュークの輝源", EquipmentRarity = "8", CountId = "592", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "592"};
        public static readonly Item PyroGlacialLasswellsPrism = new Item { Name = "Pyro Glacial Lasswell's Prism", ItemId = "300000510", Description = "氷炎の騎士ラスウェルの輝源", EquipmentRarity = "8", CountId = "593", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "593"};
        public static readonly Item YunasPrism = new Item { Name = "Yuna's Prism", ItemId = "300000520", Description = "ユウナの輝源", EquipmentRarity = "8", CountId = "594", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "594"};
        public static readonly Item LulusPrism = new Item { Name = "Lulu's Prism", ItemId = "300000530", Description = "ルールーの輝源", EquipmentRarity = "8", CountId = "595", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "595"};
        public static readonly Item BlossomSageSakurasPrism = new Item { Name = "Blossom Sage Sakura's Prism", ItemId = "300000540", Description = "桜雲の賢者サクラの輝源", EquipmentRarity = "8", CountId = "596", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "596"};
        public static readonly Item LotusMageFinasPrism = new Item { Name = "Lotus Mage Fina's Prism", ItemId = "300000550", Description = "白蓮の魔道士フィーナの輝源", EquipmentRarity = "8", CountId = "597", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "597"};
        public static readonly Item AraneasPrism = new Item { Name = "Aranea's Prism", ItemId = "300000560", Description = "アラネアの輝源", EquipmentRarity = "8", CountId = "598", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "598"};
        public static readonly Item PromptosPrism = new Item { Name = "Prompto's Prism", ItemId = "300000570", Description = "プロンプトの輝源", EquipmentRarity = "8", CountId = "599", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "599"};
        public static readonly Item KunshirasPrism = new Item { Name = "Kunshira's Prism", ItemId = "300000580", Description = "クンシラの輝源", EquipmentRarity = "8", CountId = "600", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "600"};
        public static readonly Item CitrasPrism = new Item { Name = "Citra's Prism", ItemId = "300000590", Description = "シトラの輝源", EquipmentRarity = "8", CountId = "603", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "602"};
        public static readonly Item LennethsPrism = new Item { Name = "Lenneth's Prism", ItemId = "300000600", Description = "レナスの輝源", EquipmentRarity = "8", CountId = "604", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "609"};
        public static readonly Item FreyasVPPrism = new Item { Name = "Freya's (VP) Prism", ItemId = "300000610", Description = "フレイの輝源", EquipmentRarity = "8", CountId = "605", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "610"};
        public static readonly Item ArngrimsPrism = new Item { Name = "Arngrim's Prism", ItemId = "300000620", Description = "アリューゼの輝源", EquipmentRarity = "8", CountId = "606", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "611"};
        public static readonly Item TifasPrism = new Item { Name = "Tifa's Prism", ItemId = "300000630", Description = "ティファの輝源", EquipmentRarity = "8", CountId = "702", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "612"};
        public static readonly Item VincentsPrism = new Item { Name = "Vincent's Prism", ItemId = "300000640", Description = "ヴィンセントの輝源", EquipmentRarity = "8", CountId = "703", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "613"};
        public static readonly Item NyxsPrism = new Item { Name = "Nyx's Prism", ItemId = "300000650", Description = "ニックスの輝源", EquipmentRarity = "8", CountId = "706", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "615"};
        public static readonly Item JiraiyasPrism = new Item { Name = "Jiraiya's Prism", ItemId = "300000660", Description = "ジライヤの輝源", EquipmentRarity = "8", CountId = "707", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "616"};
        public static readonly Item GabranthsPrism = new Item { Name = "Gabranth's Prism", ItemId = "300000670", Description = "ガブラスの輝源", EquipmentRarity = "8", CountId = "708", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "617"};
        public static readonly Item BaschsPrism = new Item { Name = "Basch's Prism", ItemId = "300000680", Description = "バッシュの輝源", EquipmentRarity = "8", CountId = "709", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "618"};
        public static readonly Item NamelessGunnerJakesPrism = new Item { Name = "Nameless Gunner Jake's Prism", ItemId = "300000690", Description = "無銘の銃士ジェイクの輝源", EquipmentRarity = "8", CountId = "710", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "619"};
        public static readonly Item EmperorSherasPrism = new Item { Name = "Emperor Shera's Prism", ItemId = "300000700", Description = "シエラ皇帝の輝源", EquipmentRarity = "8", CountId = "711", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "620"};
        public static readonly Item PureSummonerRydiasPrism = new Item { Name = "Pure Summoner Rydia's Prism", ItemId = "300000710", Description = "無垢なる召喚士リディアの輝源", EquipmentRarity = "8", CountId = "712", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "621"};
        public static readonly Item AtoningDragoonKainsPrism = new Item { Name = "Atoning Dragoon Kain's Prism", ItemId = "300000720", Description = "究道の竜騎士カインの輝源", EquipmentRarity = "8", CountId = "713", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "622"};
        public static readonly Item HeavenlyTechnicianLidsPrism = new Item { Name = "Heavenly Technician Lid's Prism", ItemId = "300000730", Description = "星虹の技師リドの輝源", EquipmentRarity = "8", CountId = "714", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "623"};
        public static readonly Item MedienasPrism = new Item { Name = "Mediena's Prism", ItemId = "300000740", Description = "メディエナの輝源", EquipmentRarity = "8", CountId = "715", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "624"};
        public static readonly Item SephirothsPrism = new Item { Name = "Sephiroth's Prism", ItemId = "300000750", Description = "セフィロスの輝源", EquipmentRarity = "8", CountId = "716", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "625"};
        public static readonly Item LilasPrism = new Item { Name = "Lila's Prism", ItemId = "300000760", Description = "リーラの輝源", EquipmentRarity = "8", CountId = "717", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "626"};
        public static readonly Item MaritimeStrategistNicholsPrism = new Item { Name = "Maritime Strategist Nichol's Prism", ItemId = "300000770", Description = "洸洋の軍師ニコルの輝源", EquipmentRarity = "8", CountId = "718", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "627"};
        public static readonly Item RaegansPrism = new Item { Name = "Raegan's Prism", ItemId = "300000780", Description = "レーゲンの輝源", EquipmentRarity = "8", CountId = "719", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "628"};
        public static readonly Item AwakenedRainsPrism = new Item { Name = "Awakened Rain's Prism", ItemId = "300000790", Description = "レイン(覚醒せし力)の輝源", EquipmentRarity = "8", CountId = "720", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "629"};
        public static readonly Item ElephimsPrism = new Item { Name = "Elephim's Prism", ItemId = "300000800", Description = "エレフィムの輝源", EquipmentRarity = "8", CountId = "725", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "634"};
        public static readonly Item FlammiesPrism = new Item { Name = "Flammie's Prism", ItemId = "300000810", Description = "フラミーの輝源", EquipmentRarity = "8", CountId = "731", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "639"};
        public static readonly Item RandisPrism = new Item { Name = "Randi's Prism", ItemId = "300000820", Description = "ランディの輝源", EquipmentRarity = "8", CountId = "732", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "640"};
        public static readonly Item KevinsPrism = new Item { Name = "Kevin's Prism", ItemId = "300000830", Description = "ケヴィンの輝源", EquipmentRarity = "8", CountId = "733", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "641"};
        public static readonly Item LisesPrism = new Item { Name = "Lise's Prism", ItemId = "300000840", Description = "リースの輝源", EquipmentRarity = "8", CountId = "734", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "642"};
        public static readonly Item HawkeyesPrism = new Item { Name = "Hawkeye's Prism", ItemId = "300000850", Description = "ホークアイの輝源", EquipmentRarity = "8", CountId = "735", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "643"};
        public static readonly Item MachinasPrism = new Item { Name = "Machina's Prism", ItemId = "300000860", Description = "マキナの輝源", EquipmentRarity = "8", CountId = "738", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "651"};
        public static readonly Item KurasamesPrism = new Item { Name = "Kurasame's Prism", ItemId = "300000870", Description = "クラサメの輝源", EquipmentRarity = "8", CountId = "739", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "652"};
        public static readonly Item SieghardsPrism = new Item { Name = "Sieghard's Prism", ItemId = "300000880", Description = "ジークハルトの輝源", EquipmentRarity = "8", CountId = "741", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "659"};
        public static readonly Item YuraishasPrism = new Item { Name = "Yuraisha's Prism", ItemId = "300000890", Description = "ユライシャの輝源", EquipmentRarity = "8", CountId = "742", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "660"};
        public static readonly Item OnionKnightRefiasPrism = new Item { Name = "Onion Knight Refia's Prism", ItemId = "300000900", Description = "たまねぎ剣士レフィアの輝源", EquipmentRarity = "8", CountId = "746", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "671"};
        public static readonly Item DarkKnightLunethsPrism = new Item { Name = "Dark Knight Luneth's Prism", ItemId = "300000910", Description = "魔剣士ルーネスの輝源", EquipmentRarity = "8", CountId = "747", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "672"};
        public static readonly Item OlivesPrism = new Item { Name = "Olive's Prism", ItemId = "310000010", Description = "オリーブの輝源", EquipmentRarity = "8", CountId = "9132", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9132"};
        public static readonly Item RebertasPrism = new Item { Name = "Reberta's Prism", ItemId = "310000060", Description = "レベルタの輝源", EquipmentRarity = "8", CountId = "9145", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9145"};
        public static readonly Item BarbaricciasPrism = new Item { Name = "Barbariccia's Prism", ItemId = "310000090", Description = "バルバリシアの輝源", EquipmentRarity = "8", CountId = "9160", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9160"};
        public static readonly Item ZargabaathsPrism = new Item { Name = "Zargabaath's Prism", ItemId = "310000100", Description = "ザルガバースの輝源", EquipmentRarity = "8", CountId = "9161", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9161"};
        public static readonly Item ElvenCrystal = new Item { Name = "Elven Crystal", ItemId = "1209000882", Description = "Elven Crystal", EquipmentRarity = "5", CountId = "9117", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "1209000882", BitNumber = "9117"};
        public static readonly Item ManufacturedWood = new Item { Name = "Manufactured Wood", ItemId = "1209000883", Description = "Manufactured Wood", EquipmentRarity = "4", CountId = "9118", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "1209000883", BitNumber = "9118"};
        public static readonly Item ScarletOrb = new Item { Name = "Scarlet Orb", ItemId = "1209000884", Description = "Scarlet Orb", EquipmentRarity = "4", CountId = "9119", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "1209000884", BitNumber = "9119"};
        public static readonly Item BlackThread = new Item { Name = "Black Thread", ItemId = "1209000885", Description = "Black Thread", EquipmentRarity = "3", CountId = "9120", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "1209000885", BitNumber = "9120"};
        public static readonly Item ScarletHide = new Item { Name = "Scarlet Hide", ItemId = "1209000886", Description = "Scarlet Hide", EquipmentRarity = "3", CountId = "9121", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "1209000886", BitNumber = "9121"};
        public static readonly Item GreyFeathers = new Item { Name = "Grey Feathers", ItemId = "1209000887", Description = "Grey Feathers", EquipmentRarity = "3", CountId = "9122", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "1209000887", BitNumber = "9122"};
        public static readonly Item ScarletEgg = new Item { Name = "Scarlet Egg", ItemId = "1209000888", Description = "Scarlet Egg", EquipmentRarity = "3", CountId = "9123", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "1209000888", BitNumber = "9123"};
        public static readonly Item BavariumDust = new Item { Name = "Bavarium Dust", ItemId = "1209000876", Description = "Bavarium Dust", EquipmentRarity = "4", CountId = "9111", IsPotUnit = "0", KeyName = "0", ItemStack = "999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000881", BitNumber = "9111"};
        public static readonly Item BavariumOre = new Item { Name = "Bavarium Ore", ItemId = "1209000877", Description = "Bavarium Ore", EquipmentRarity = "4", CountId = "9112", IsPotUnit = "0", KeyName = "0", ItemStack = "999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000877", BitNumber = "9112"};
        public static readonly Item BavariumShard = new Item { Name = "Bavarium Shard", ItemId = "1209000878", Description = "Bavarium Shard", EquipmentRarity = "4", CountId = "9113", IsPotUnit = "0", KeyName = "0", ItemStack = "999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000878", BitNumber = "9113"};
        public static readonly Item RefinedBavarium = new Item { Name = "Refined Bavarium", ItemId = "1209000879", Description = "Refined Bavarium", EquipmentRarity = "5", CountId = "9114", IsPotUnit = "0", KeyName = "0", ItemStack = "999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000879", BitNumber = "9114"};
        public static readonly Item BavariumCoin = new Item { Name = "Bavarium Coin", ItemId = "1209000880", Description = "Bavarium Coin", EquipmentRarity = "4", CountId = "9115", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000880", BitNumber = "9115"};
        public static readonly Item ndAnniversaryMedal = new Item { Name = "2nd Anniversary Medal", ItemId = "1209000889", Description = "2周年メダル", EquipmentRarity = "8", CountId = "9124", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "1209000889", BitNumber = "9124"};
        public static readonly Item ndAnniversaryTicket = new Item { Name = "2nd Anniversary Ticket", ItemId = "1209000890", Description = "2nd Anniversary Ticket", EquipmentRarity = "8", CountId = "9125", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000890", BitNumber = "9125"};
        public static readonly Item PlayersVoiceTicketPart_1209000891 = new Item { Name = "Player's Voice Ticket (Part 1)", ItemId = "1209000891", Description = "Player's Voice Ticket (Part 1)", EquipmentRarity = "8", CountId = "9126", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000891", BitNumber = "9126"};
        public static readonly Item PlayersVoiceTicketPart_1209000892 = new Item { Name = "Player's Voice Ticket (Part 2)", ItemId = "1209000892", Description = "Player's Voice Ticket (Part 2)", EquipmentRarity = "8", CountId = "9127", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000892", BitNumber = "9127"};
        public static readonly Item FFBEHeroesCoin = new Item { Name = "FFBE Heroes Coin", ItemId = "1209000896", Description = "FFBE Heroes Coin", EquipmentRarity = "8", CountId = "9131", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10000", ItemIdClone = "1209000896", BitNumber = "9131"};
        public static readonly Item NanoSeeds = new Item { Name = "Nano Seeds", ItemId = "1209000897", Description = "Nano Seeds", EquipmentRarity = "4", CountId = "9133", IsPotUnit = "0", KeyName = "0", ItemStack = "999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000897", BitNumber = "9133"};
        public static readonly Item NanoShard = new Item { Name = "Nano Shard", ItemId = "1209000898", Description = "Nano Shard", EquipmentRarity = "4", CountId = "9134", IsPotUnit = "0", KeyName = "0", ItemStack = "999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000898", BitNumber = "9134"};
        public static readonly Item NanoCrystal = new Item { Name = "Nano Crystal", ItemId = "1209000899", Description = "Nano Crystal", EquipmentRarity = "4", CountId = "9135", IsPotUnit = "0", KeyName = "0", ItemStack = "999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000899", BitNumber = "9135"};
        public static readonly Item NanoCore = new Item { Name = "Nano Core", ItemId = "1209000900", Description = "Nano Core", EquipmentRarity = "5", CountId = "9136", IsPotUnit = "0", KeyName = "0", ItemStack = "999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000900", BitNumber = "9136"};
        public static readonly Item Hypostim = new Item { Name = "Hypostim", ItemId = "1209000901", Description = "Hypostim", EquipmentRarity = "3", CountId = "9137", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000901", BitNumber = "9137"};
        public static readonly Item AdamJensensPrism = new Item { Name = "Adam Jensen's Prism", ItemId = "310000020", Description = "Adam Jensen Prism", EquipmentRarity = "8", CountId = "9138", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9138"};
        public static readonly Item ViktorMarchenkosPrism = new Item { Name = "Viktor Marchenko's Prism", ItemId = "310000030", Description = "Viktor Marchenko's Prism", EquipmentRarity = "8", CountId = "9140", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9140"};
        public static readonly Item Conch = new Item { Name = "Conch", ItemId = "1209000893", Description = "Conch", EquipmentRarity = "4", CountId = "9128", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000893", BitNumber = "9128"};
        public static readonly Item TurretShell = new Item { Name = "Turret Shell", ItemId = "1209000894", Description = "Turret Shell", EquipmentRarity = "3", CountId = "9129", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000894", BitNumber = "9129"};
        public static readonly Item CowryShell = new Item { Name = "Cowry Shell", ItemId = "1209000895", Description = "Cowry Shell", EquipmentRarity = "3", CountId = "9130", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000895", BitNumber = "9130"};
        public static readonly Item RainbowShell = new Item { Name = "Rainbow Shell", ItemId = "1209000902", Description = "Rainbow Shell", EquipmentRarity = "5", CountId = "9139", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000902", BitNumber = "9139"};
        public static readonly Item SummerSummonTicket = new Item { Name = "Summer 2018 Summon Ticket", ItemId = "1209000903", Description = "Summer 2018 Summon Ticket", EquipmentRarity = "8", CountId = "9141", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000903", BitNumber = "9141"};
        public static readonly Item SummerStone = new Item { Name = "Summer Stone", ItemId = "1209000904", Description = "Summer Stone", EquipmentRarity = "8", CountId = "9142", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000904", BitNumber = "9142"};
        public static readonly Item SeasideNicholsPrism = new Item { Name = "Seaside Nichol's Prism", ItemId = "310000040", Description = "Seaside Nichol Prism", EquipmentRarity = "8", CountId = "9143", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9143"};
        public static readonly Item AlohaLasswellsPrism = new Item { Name = "Aloha Lasswell's Prism", ItemId = "310000050", Description = "Aloha Lasswell Prism", EquipmentRarity = "8", CountId = "9144", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9144"};
        public static readonly Item MalphasiesPrism = new Item { Name = "Malphasie's Prism", ItemId = "310000070", Description = "Malphasie Prism", EquipmentRarity = "8", CountId = "9146", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9146"};
        public static readonly Item CircesPrism = new Item { Name = "Circe's Prism", ItemId = "310000080", Description = "Circe Prism", EquipmentRarity = "8", CountId = "9147", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9147"};
        public static readonly Item HatredRaidCoin = new Item { Name = "Hatred Raid Coin", ItemId = "1209000905", Description = "Hatred Raid Coin", EquipmentRarity = "4", CountId = "9148", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000905", BitNumber = "9148"};
        public static readonly Item DecayedSeeds = new Item { Name = "Decayed Seeds", ItemId = "1209000906", Description = "Decayed Seeds", EquipmentRarity = "3", CountId = "9149", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000906", BitNumber = "9149"};
        public static readonly Item BurntShard = new Item { Name = "Burnt Shard", ItemId = "1209000907", Description = "Burnt Shard", EquipmentRarity = "3", CountId = "9150", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000907", BitNumber = "9150"};
        public static readonly Item DullCrystal = new Item { Name = "Dull Crystal", ItemId = "1209000908", Description = "Dull Crystal", EquipmentRarity = "3", CountId = "9151", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000908", BitNumber = "9151"};
        public static readonly Item DarkCore = new Item { Name = "Dark Core", ItemId = "1209000909", Description = "Dark Core", EquipmentRarity = "3", CountId = "9152", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000909", BitNumber = "9152"};
        public static readonly Item CorruptedStone = new Item { Name = "Corrupted Stone", ItemId = "1209000910", Description = "Corrupted Stone", EquipmentRarity = "3", CountId = "9153", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000910", BitNumber = "9153"};
        public static readonly Item WickedRoots = new Item { Name = "Wicked Roots", ItemId = "1209000911", Description = "Wicked Roots", EquipmentRarity = "3", CountId = "9154", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000911", BitNumber = "9154"};
        public static readonly Item LockofBlackHair = new Item { Name = "Lock of Black Hair", ItemId = "1209000912", Description = "Lock of Black Hair", EquipmentRarity = "5", CountId = "9155", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000912", BitNumber = "9155"};
        public static readonly Item PumpkinCandy = new Item { Name = "Pumpkin Candy", ItemId = "1209000915", Description = "Pumpkin Candy", EquipmentRarity = "8", CountId = "9158", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "1209000915", BitNumber = "9158"};
        public static readonly Item SpecialFFXVTicket = new Item { Name = "Special FFXV Ticket", ItemId = "1209000916", Description = "SP Exchange Ticket", EquipmentRarity = "8", CountId = "9159", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000916", BitNumber = "9159"};
        public static readonly Item DemonRainsPrism = new Item { Name = "Demon Rain's Prism", ItemId = "310000110", Description = "悪魔のレインの輝源", EquipmentRarity = "8", CountId = "9163", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9163"};
        public static readonly Item DracuLasswellsPrism = new Item { Name = "Dracu Lasswell's Prism", ItemId = "310000120", Description = "吸血鬼のラスウェルの輝源", EquipmentRarity = "8", CountId = "9164", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9164"};
        public static readonly Item GrimLordSakurasPrism = new Item { Name = "Grim Lord Sakura's Prism", ItemId = "310000130", Description = "ザルガバースの輝源", EquipmentRarity = "8", CountId = "9165", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9165"};
        public static readonly Item RedVial = new Item { Name = "Red Vial", ItemId = "1209000917", Description = "Red Vial", EquipmentRarity = "4", CountId = "9162", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000917", BitNumber = "9162"};
        public static readonly Item HalloweenSummonTicket = new Item { Name = "Halloween 2018 Summon Ticket", ItemId = "1209000913", Description = "Halloween 2018 Summon Ticket", EquipmentRarity = "8", CountId = "9156", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000913", BitNumber = "9156"};
        public static readonly Item LilithsPrism = new Item { Name = "Lilith's Prism", ItemId = "310000140", Description = "Lilith Prism", EquipmentRarity = "8", CountId = "9166", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9166"};
        public static readonly Item LuciusPrism = new Item { Name = "Lucius' Prism", ItemId = "310000150", Description = "Lucius's Prism", EquipmentRarity = "8", CountId = "9167", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9167"};
        public static readonly Item ConquerorsGavelMagic = new Item { Name = "Conqueror's Gavel - Magic", ItemId = "105007000", Description = "征服者のガベル・魔", EquipmentRarity = "6", CountId = "769", IsPotUnit = "3", KeyName = "1", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "105007000", BitNumber = "664"};
        public static readonly Item XenogearsLimitedExchangeTicketFEB = new Item { Name = "Xenogears Limited Exchange Ticket [F/E/B]", ItemId = "106211160", Description = "ゼノギアス限定交換券[F.E.B]", EquipmentRarity = "8", CountId = "763", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106211160", BitNumber = "682"};
        public static readonly Item GuaranteedSpecialSummonTicket_106211170 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "106211170", Description = "[期間限定]★5確定SP召喚チケット", EquipmentRarity = "8", CountId = "768", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106211170", BitNumber = "688"};
        public static readonly Item XenogearsLimitedExchangeTicketFEBCM = new Item { Name = "Xenogears Limited Exchange Ticket [F/E/B/C/M]", ItemId = "106211180", Description = "ゼノギアス限定交換券[F.E.B.S.M]", EquipmentRarity = "8", CountId = "779", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106211160", BitNumber = "698"};
        public static readonly Item GElementsRaidCoin = new Item { Name = "G Elements Raid Coin", ItemId = "106305500", Description = "Gエレメンツレイドコイン", EquipmentRarity = "3", CountId = "753", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106305500", BitNumber = "673"};
        public static readonly Item BlankSphere = new Item { Name = "Blank Sphere", ItemId = "106305600", Description = "からっぽのスフィア", EquipmentRarity = "3", CountId = "764", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106305600", BitNumber = "685"};
        public static readonly Item DeusRaidCoin = new Item { Name = "Deus Raid Coin", ItemId = "106305700", Description = "デウスレイドコイン", EquipmentRarity = "3", CountId = "773", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106305700", BitNumber = "692"};
        public static readonly Item GilMap = new Item { Name = "Gil Map", ItemId = "110000600", Description = "ギルの地図", EquipmentRarity = "4", CountId = "765", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "110000500", BitNumber = "684"};
        public static readonly Item GoldBullion = new Item { Name = "Gold Bullion", ItemId = "225000100", Description = "大金塊", EquipmentRarity = "5", CountId = "754", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "225000100", BitNumber = "674"};
        public static readonly Item VioletLumber = new Item { Name = "Violet Lumber", ItemId = "225000200", Description = "桔梗色の木材", EquipmentRarity = "4", CountId = "755", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "225000200", BitNumber = "675"};
        public static readonly Item CrimsonCloth = new Item { Name = "Crimson Cloth", ItemId = "225000300", Description = "紅色の生地", EquipmentRarity = "4", CountId = "756", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "225000300", BitNumber = "676"};
        public static readonly Item EarthenScale = new Item { Name = "Earthen Scale", ItemId = "225000400", Description = "大地の鱗", EquipmentRarity = "3", CountId = "757", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "225000400", BitNumber = "677"};
        public static readonly Item EbonyFang = new Item { Name = "Ebony Fang", ItemId = "225000500", Description = "漆黒の牙", EquipmentRarity = "3", CountId = "758", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "225000500", BitNumber = "678"};
        public static readonly Item MidorisRing = new Item { Name = "Midori's Ring", ItemId = "226000100", Description = "ミドリの指輪", EquipmentRarity = "5", CountId = "774", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "226000100", BitNumber = "693"};
        public static readonly Item SteelLump = new Item { Name = "Steel Lump", ItemId = "226000200", Description = "玉鋼の塊", EquipmentRarity = "4", CountId = "775", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "226000200", BitNumber = "694"};
        public static readonly Item BlackLeather = new Item { Name = "Black Leather", ItemId = "226000300", Description = "黒の革布", EquipmentRarity = "4", CountId = "776", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "226000300", BitNumber = "695"};
        public static readonly Item SmokyGemstone = new Item { Name = "Smoky Gemstone", ItemId = "226000400", Description = "黒光りした宝珠", EquipmentRarity = "3", CountId = "777", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "226000400", BitNumber = "696"};
        public static readonly Item AzureFragment = new Item { Name = "Azure Fragment", ItemId = "226000500", Description = "蒼の欠片", EquipmentRarity = "3", CountId = "778", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "226000500", BitNumber = "697"};
        public static readonly Item FolkasPrism = new Item { Name = "Folka's Prism", ItemId = "300000920", Description = "フォルカの輝源", EquipmentRarity = "8", CountId = "759", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "679"};
        public static readonly Item FeisPrism = new Item { Name = "Fei's Prism", ItemId = "300000930", Description = "フェイの輝源", EquipmentRarity = "8", CountId = "760", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "680"};
        public static readonly Item EllysPrism = new Item { Name = "Elly's Prism", ItemId = "300000940", Description = "エリィの輝源", EquipmentRarity = "8", CountId = "761", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "681"};
        public static readonly Item BartsPrism = new Item { Name = "Bart's Prism", ItemId = "300000950", Description = "バルトの輝源", EquipmentRarity = "8", CountId = "762", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "683"};
        public static readonly Item JechtsPrism = new Item { Name = "Jecht's Prism", ItemId = "300000960", Description = "ジェクトの輝源", EquipmentRarity = "8", CountId = "766", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "686"};
        public static readonly Item AuronsPrism = new Item { Name = "Auron's Prism", ItemId = "300000970", Description = "アーロンの輝源", EquipmentRarity = "8", CountId = "767", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "687"};
        public static readonly Item IgnaciosPrism = new Item { Name = "Ignacio's Prism", ItemId = "300000980", Description = "イグニシオの輝源", EquipmentRarity = "8", CountId = "770", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "689"};
        public static readonly Item CitansPrism = new Item { Name = "Citan's Prism", ItemId = "300000990", Description = "シタンの輝源", EquipmentRarity = "8", CountId = "771", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "690"};
        public static readonly Item MariasPrism = new Item { Name = "Maria's Prism", ItemId = "300001000", Description = "マリアの輝源", EquipmentRarity = "8", CountId = "772", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "691"};
        public static readonly Item MillionDownloadsTicket_1209000923 = new Item { Name = "35 Million Downloads Ticket", ItemId = "1209000923", Description = "35 Million Downloads Ticket", EquipmentRarity = "8", CountId = "9173", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000923", BitNumber = "9159"};
        public static readonly Item RedCloth = new Item { Name = "Red Cloth", ItemId = "1209000918", Description = "Red Cloth Piece", EquipmentRarity = "5", CountId = "9168", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000918", BitNumber = "9168"};
        public static readonly Item CursedNeedle = new Item { Name = "Cursed Needle", ItemId = "1209000919", Description = "Cursed Needles", EquipmentRarity = "4", CountId = "9169", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000919", BitNumber = "9169"};
        public static readonly Item BlackAsh = new Item { Name = "Black Ash", ItemId = "1209000920", Description = "Black Ash", EquipmentRarity = "3", CountId = "9170", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000920", BitNumber = "9170"};
        public static readonly Item PureBlood = new Item { Name = "Pure Blood", ItemId = "1209000921", Description = "Pure Blood", EquipmentRarity = "3", CountId = "9171", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000921", BitNumber = "9171"};
        public static readonly Item BlackGrimoire = new Item { Name = "Black Grimoire", ItemId = "1209000922", Description = "Black Grimoire", EquipmentRarity = "3", CountId = "9172", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000922", BitNumber = "9172"};
        public static readonly Item FryeviasPrism = new Item { Name = "Fryevia's Prism", ItemId = "310000180", Description = "Fryevia's Prism", EquipmentRarity = "8", CountId = "9176", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9176"};
        public static readonly Item BsPrism = new Item { Name = "2B's Prism", ItemId = "300001200", Description = "2Bの輝源", EquipmentRarity = "8", CountId = "848", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "768"};
        public static readonly Item A2sPrism = new Item { Name = "A2's Prism", ItemId = "300001210", Description = "A2の輝源", EquipmentRarity = "8", CountId = "849", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "769"};
        public static readonly Item BerylsPrism = new Item { Name = "Beryl's Prism", ItemId = "310000160", Description = "Beryl's Prism", EquipmentRarity = "8", CountId = "9174", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9174"};
        public static readonly Item EllesperissPrism = new Item { Name = "Ellesperis's Prism", ItemId = "310000170", Description = "Ellesperis Prism", EquipmentRarity = "8", CountId = "9175", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9175"};
        public static readonly Item AuroraFryeviasPrism = new Item { Name = "Aurora Fryevia's Prism", ItemId = "310000190", Description = "Aurora Fryevia's Prism", EquipmentRarity = "8", CountId = "9179", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9179"};
        public static readonly Item FanFestaSummonTicket = new Item { Name = "Fan Festa 2018 Summon Ticket", ItemId = "1209000924", Description = "Fan Festa 2018 Summon Ticket", EquipmentRarity = "8", CountId = "9177", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000924", BitNumber = "9177"};
        public static readonly Item CrimsonDragonScale = new Item { Name = "Crimson Dragon Scale", ItemId = "1209000927", Description = "Crimson Dragon Scale", EquipmentRarity = "4", CountId = "9181", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000927", BitNumber = "9181"};
        public static readonly Item PopstarKatysPrism = new Item { Name = "Popstar Katy's Prism", ItemId = "310000200", Description = "Popstar Katy Prism", EquipmentRarity = "8", CountId = "9182", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9182"};
        public static readonly Item FanFestaSelectTicket = new Item { Name = "Fan Festa 2018 Select Ticket", ItemId = "1209000925", Description = "Fan Festa 2018 Select Ticket", EquipmentRarity = "8", CountId = "9178", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000925", BitNumber = "9178"};
        public static readonly Item FelixsPrism = new Item { Name = "Felix's Prism", ItemId = "310000220", Description = "Felix's Prism", EquipmentRarity = "8", CountId = "9185", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9185"};
        public static readonly Item TianasPrism = new Item { Name = "Tiana's Prism", ItemId = "310000210", Description = "Tiana's Prism", EquipmentRarity = "8", CountId = "9184", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9184"};
        public static readonly Item WinterSummonTicket = new Item { Name = "Winter 2018 5★ Summon Ticket", ItemId = "1209000929", Description = "2018 Winter 5★ Summon Ticket", EquipmentRarity = "8", CountId = "9189", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000929", BitNumber = "9189"};
        public static readonly Item GiftBow = new Item { Name = "Gift Bow", ItemId = "1209000928", Description = "Gift Bow", EquipmentRarity = "3", CountId = "9183", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "1209000928", BitNumber = "9183"};
        public static readonly Item WhiteKnightNoelsPrism = new Item { Name = "White Knight Noel's Prism", ItemId = "310000230", Description = "白騎士ノエルの輝源", EquipmentRarity = "8", CountId = "9186", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9186"};
        public static readonly Item ChristinesPrism = new Item { Name = "Christine's Prism", ItemId = "310000240", Description = "Christine's Prism", EquipmentRarity = "8", CountId = "9187", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9187"};
        public static readonly Item KrylasPrism = new Item { Name = "Kryla's Prism", ItemId = "310000250", Description = "Kryla's Prism", EquipmentRarity = "8", CountId = "9188", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9188"};
        public static readonly Item ConquerorsGavelSpirit = new Item { Name = "Conqueror's Gavel - Spirit", ItemId = "105007100", Description = "征服者のガベル・精", EquipmentRarity = "6", CountId = "784", IsPotUnit = "3", KeyName = "1", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "105007100", BitNumber = "703"};
        public static readonly Item ConquerorsGavelAttackandMagic = new Item { Name = "Conqueror's Gavel - Attack and Magic", ItemId = "105007200", Description = "征服者のガベル・攻魔", EquipmentRarity = "6", CountId = "805", IsPotUnit = "3", KeyName = "1", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "105007200", BitNumber = "725"};
        public static readonly Item GuardArmorRaidCoin = new Item { Name = "Guard Armor Raid Coin", ItemId = "106307100", Description = "ガードアーマーレイドコイン", EquipmentRarity = "3", CountId = "924", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106307100", BitNumber = "842"};
        public static readonly Item DarkMatter_235004100 = new Item { Name = "Dark Matter", ItemId = "235004100", Description = "ダークマター", EquipmentRarity = "5", CountId = "925", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235004100", BitNumber = "843"};
        public static readonly Item SerenityPower = new Item { Name = "Serenity Power", ItemId = "235004200", Description = "満たされるチカラ", EquipmentRarity = "4", CountId = "926", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235004200", BitNumber = "844"};
        public static readonly Item FuryStone = new Item { Name = "Fury Stone", ItemId = "235004300", Description = "闘気のしずく", EquipmentRarity = "4", CountId = "927", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235004300", BitNumber = "845"};
        public static readonly Item PowerStone = new Item { Name = "Power Stone", ItemId = "235004400", Description = "力のしずく", EquipmentRarity = "3", CountId = "928", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235004400", BitNumber = "846"};
        public static readonly Item MythrilStone = new Item { Name = "Mythril Stone", ItemId = "235004500", Description = "ミスリルのしずく", EquipmentRarity = "3", CountId = "929", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235004500", BitNumber = "847"};
        public static readonly Item CloudKHsPrism = new Item { Name = "Cloud (KH)'s Prism", ItemId = "300001430", Description = "クラウド(キングダム ハーツ)の輝源", EquipmentRarity = "8", CountId = "931", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "849"};
        public static readonly Item SorasPrism = new Item { Name = "Sora's Prism", ItemId = "300001420", Description = "ソラの輝源", EquipmentRarity = "8", CountId = "930", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "848"};
        public static readonly Item SophiasPrism = new Item { Name = "Sophia's Prism", ItemId = "310000260", Description = "Sophia's Prism", EquipmentRarity = "8", CountId = "9191", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9191"};
        public static readonly Item FaytsPrism = new Item { Name = "Fayt's Prism", ItemId = "310000270", Description = "Fayt's Prism", EquipmentRarity = "8", CountId = "9192", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9192"};
        public static readonly Item RenasPrism = new Item { Name = "Rena's Prism", ItemId = "310000280", Description = "Rena's Prism", EquipmentRarity = "8", CountId = "9193", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9193"};
        public static readonly Item ExploringtheMoogleCave = new Item { Name = "Exploring the Moogle Cave", ItemId = "1209000926", Description = "Exploring the Moogle Cave", EquipmentRarity = "8", CountId = "9180", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "1209000926", BitNumber = "9180"};
        public static readonly Item STAROCEANANAMNESISTicket = new Item { Name = "STAR OCEAN: ANAMNESIS Ticket", ItemId = "1209000930", Description = "Star Ocean: Anamnesis Ticket", EquipmentRarity = "8", CountId = "9190", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000930", BitNumber = "9190"};
        public static readonly Item CopperCoin = new Item { Name = "Copper Coin", ItemId = "1209000931", Description = "Copper Coin", EquipmentRarity = "3", CountId = "9194", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000931", BitNumber = "9194"};
        public static readonly Item BronzeIngot = new Item { Name = "Bronze Ingot", ItemId = "1209000932", Description = "Bronze Ingot", EquipmentRarity = "3", CountId = "9195", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000932", BitNumber = "9195"};
        public static readonly Item SilverIngot = new Item { Name = "Silver Ingot", ItemId = "1209000933", Description = "Silver Ingot", EquipmentRarity = "4", CountId = "9196", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000933", BitNumber = "9196"};
        public static readonly Item GoldenIngot = new Item { Name = "Golden Ingot", ItemId = "1209000934", Description = "Golden Ingot", EquipmentRarity = "5", CountId = "9197", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000934", BitNumber = "9197"};
        public static readonly Item GlassIngot = new Item { Name = "Glass Ingot", ItemId = "1209000935", Description = "Crystal Ingot", EquipmentRarity = "6", CountId = "9198", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000935", BitNumber = "9198"};
        public static readonly Item YunsPrism = new Item { Name = "Yun's Prism", ItemId = "310000310", Description = "ユンの輝源", EquipmentRarity = "8", CountId = "9201", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9201"};
        public static readonly Item ChowsPrism = new Item { Name = "Chow's Prism", ItemId = "310000320", Description = "チョウの輝源", EquipmentRarity = "8", CountId = "9202", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9202"};
        public static readonly Item AngsPrism = new Item { Name = "Ang's Prism", ItemId = "310000330", Description = "アンの輝源", EquipmentRarity = "8", CountId = "9203", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9203"};
        public static readonly Item QinsPrism = new Item { Name = "Qin's Prism", ItemId = "310000300", Description = "Qin's Prism", EquipmentRarity = "8", CountId = "9200", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9200"};
        public static readonly Item BaiHuZhuQuesPrism = new Item { Name = "Bai Hu & Zhu Que's Prism", ItemId = "310000290", Description = "Baihu & Zhuque's Prism", EquipmentRarity = "8", CountId = "9199", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9199"};
        public static readonly Item MyrasPrism = new Item { Name = "Myra's Prism", ItemId = "310000340", Description = "Myra's Prism", EquipmentRarity = "8", CountId = "9205", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9205"};
        public static readonly Item RuinationRaidCoin = new Item { Name = "Ruination Raid Coin", ItemId = "1209000939", Description = "Ruination Raid Coin", EquipmentRarity = "4", CountId = "9208", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000939", BitNumber = "9208"};
        public static readonly Item RancidSeeds = new Item { Name = "Rancid Seeds", ItemId = "1209000940", Description = "Rotten Seeds", EquipmentRarity = "3", CountId = "9209", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000940", BitNumber = "9209"};
        public static readonly Item FragileShard = new Item { Name = "Fragile Shard", ItemId = "1209000941", Description = "Fragmented Shard", EquipmentRarity = "3", CountId = "9210", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000941", BitNumber = "9210"};
        public static readonly Item FallenGem = new Item { Name = "Fallen Gem", ItemId = "1209000942", Description = "Fallen Crystal", EquipmentRarity = "3", CountId = "9211", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000942", BitNumber = "9211"};
        public static readonly Item DamagedCore = new Item { Name = "Damaged Core", ItemId = "1209000943", Description = "Damaged Core", EquipmentRarity = "3", CountId = "9212", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000943", BitNumber = "9212"};
        public static readonly Item JinxedStone = new Item { Name = "Jinxed Stone", ItemId = "1209000944", Description = "Ruined Stone", EquipmentRarity = "3", CountId = "9213", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000944", BitNumber = "9213"};
        public static readonly Item EntangledRoots = new Item { Name = "Entangled Roots", ItemId = "1209000945", Description = "Entangled Roots", EquipmentRarity = "3", CountId = "9214", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000945", BitNumber = "9214"};
        public static readonly Item BundleofPurpleThread = new Item { Name = "Bundle of Purple Thread", ItemId = "1209000946", Description = "Lock of Purple Thread", EquipmentRarity = "5", CountId = "9215", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000946", BitNumber = "9215"};
        public static readonly Item FanFestaToken = new Item { Name = "Fan Festa Token", ItemId = "1209000936", Description = "Fan Festa Token", EquipmentRarity = "8", CountId = "9204", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000936", BitNumber = "9204"};
        public static readonly Item SpecialBatchTicket = new Item { Name = "Special 5★ Batch Ticket", ItemId = "1209000937", Description = "Special 5★ Batch Ticket", EquipmentRarity = "8", CountId = "9206", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000937", BitNumber = "9206"};
        public static readonly Item FanFestaPremiumSummonTicket = new Item { Name = "Fan Festa Premium 10+1 Summon Ticket", ItemId = "1209000938", Description = "Fan Festa Premium 10+1 Summon Ticket", EquipmentRarity = "8", CountId = "9207", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000938", BitNumber = "9207"};
        public static readonly Item OrientationControlUnit = new Item { Name = "Orientation Control Unit", ItemId = "227000100", Description = "姿勢制御装置", EquipmentRarity = "5", CountId = "787", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "227000100", BitNumber = "708"};
        public static readonly Item LevistoneFragment = new Item { Name = "Levistone Fragment", ItemId = "227000500", Description = "浮遊石の欠片", EquipmentRarity = "4", CountId = "791", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "227000500", BitNumber = "712"};
        public static readonly Item ThickSailcloth = new Item { Name = "Thick Sailcloth", ItemId = "227000300", Description = "厚手の帆布", EquipmentRarity = "4", CountId = "789", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "227000300", BitNumber = "710"};
        public static readonly Item Galesilk = new Item { Name = "Galesilk", ItemId = "227000200", Description = "風虫の糸", EquipmentRarity = "4", CountId = "788", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "227000200", BitNumber = "709"};
        public static readonly Item MidnightWings = new Item { Name = "Midnight Wings", ItemId = "227000400", Description = "闇夜の翼", EquipmentRarity = "4", CountId = "790", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "227000400", BitNumber = "711"};
        public static readonly Item GlobalExchangeTicket = new Item { Name = "Global Exchange Ticket", ItemId = "1209000948", Description = "Global Exchange Ticket", EquipmentRarity = "8", CountId = "9217", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "600000", ItemSellPrice = "300000", ItemIdClone = "1209000948", BitNumber = "9217"};
        public static readonly Item CidsPrism = new Item { Name = "Cid's Prism", ItemId = "300001030", Description = "シドの輝源", EquipmentRarity = "8", CountId = "785", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "704"};
        public static readonly Item GuaranteedFeaturedTicket = new Item { Name = "5★ Guaranteed (30% Featured) Ticket", ItemId = "1209000949", Description = "5★ Guaranteed (30% Featured) Ticket", EquipmentRarity = "8", CountId = "9218", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000949", BitNumber = "9218"};
        public static readonly Item SpecialBatchTicketSG = new Item { Name = "Special 5★ Batch Ticket (S. G. 2019)", ItemId = "1209000955", Description = "Special 5★ Batch Ticket (S. G. 2019)", EquipmentRarity = "8", CountId = "9224", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000937", BitNumber = "9224"};
        public static readonly Item GuaranteedSpecialSummonTicket_1209000947 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "1209000947", Description = "[期間限定]★5確定SP召喚チケット", EquipmentRarity = "8", CountId = "9216", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106211170", BitNumber = "9216"};
        public static readonly Item KarlettesPrism = new Item { Name = "Karlette's Prism", ItemId = "300001040", Description = "カルエラートの輝源", EquipmentRarity = "8", CountId = "786", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "705"};
        public static readonly Item Sunstone = new Item { Name = "Sunstone", ItemId = "1209000950", Description = "Sunstone", EquipmentRarity = "3", CountId = "9219", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000950", BitNumber = "9219"};
        public static readonly Item EggCoin = new Item { Name = "Egg Coin", ItemId = "1209000951", Description = "Egg Coin", EquipmentRarity = "4", CountId = "9220", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000951", BitNumber = "9220"};
        public static readonly Item EsthersPrism = new Item { Name = "Esther's Prism", ItemId = "310000350", Description = "Esther's Prism", EquipmentRarity = "8", CountId = "9226", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9226"};
        public static readonly Item SylviesPrism = new Item { Name = "Sylvie's Prism", ItemId = "310000360", Description = "Sylvie's Prism", EquipmentRarity = "8", CountId = "9227", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9227"};
        public static readonly Item GuaranteedFeaturedTicketFFT = new Item { Name = "5★ Guaranteed (30% Featured) Ticket [FFT]", ItemId = "1209000958", Description = "5★ Guaranteed (30% Featured) Ticket [FFT]", EquipmentRarity = "8", CountId = "9230", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000958", BitNumber = "9230"};
        public static readonly Item GuaranteedSpecialSummonTicket_1209000957 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "1209000957", Description = "[期間限定]★5確定SP召喚チケット", EquipmentRarity = "8", CountId = "9228", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106211170", BitNumber = "9228"};
        public static readonly Item BlueOrb = new Item { Name = "Blue Orb", ItemId = "106305800", Description = "青の宝玉", EquipmentRarity = "3", CountId = "780", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106305800", BitNumber = "699"};
        public static readonly Item HighSeraphUltimasPrism = new Item { Name = "High Seraph Ultima's Prism", ItemId = "300001010", Description = "聖天使アルテマの輝源", EquipmentRarity = "8", CountId = "781", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "700"};
        public static readonly Item BeowulfsPrism = new Item { Name = "Beowulf's Prism", ItemId = "300001020", Description = "ベイオウーフの輝源", EquipmentRarity = "8", CountId = "782", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "701"};
        public static readonly Item SpecialBatchTicketBL = new Item { Name = "Special 5★ Batch Ticket (B. L. 2019)", ItemId = "1209000960", Description = "Special 5★ Batch Ticket (B. L. 2019)", EquipmentRarity = "8", CountId = "9232", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000937", BitNumber = "9232"};
        public static readonly Item YoungLadysDiary = new Item { Name = "Young Lady's Diary", ItemId = "231000100", Description = "少女の日記帳", EquipmentRarity = "5", CountId = "829", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "231000100", BitNumber = "749"};
        public static readonly Item TwilightDesertHerb = new Item { Name = "Twilight Desert Herb", ItemId = "231000200", Description = "砂漠の夕日草", EquipmentRarity = "4", CountId = "830", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "231000200", BitNumber = "750"};
        public static readonly Item CloudyWhiteCloth = new Item { Name = "Cloudy White Cloth", ItemId = "231000300", Description = "白雲の薄布", EquipmentRarity = "4", CountId = "831", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "231000300", BitNumber = "751"};
        public static readonly Item FleetFootedBirdsTailFeather = new Item { Name = "Fleet-Footed Bird's Tail Feather", ItemId = "231000400", Description = "走り鳥の尾羽", EquipmentRarity = "4", CountId = "832", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "231000400", BitNumber = "752"};
        public static readonly Item ScorpionStone = new Item { Name = "Scorpion Stone", ItemId = "231000500", Description = "砂サソリの毒石", EquipmentRarity = "4", CountId = "833", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "231000500", BitNumber = "753"};
        public static readonly Item CrimsonsPrism = new Item { Name = "Crimson's Prism", ItemId = "300001150", Description = "クリムゾンの輝源", EquipmentRarity = "8", CountId = "828", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "748"};
        public static readonly Item WaterBookofMagic = new Item { Name = "Water Book of Magic", ItemId = "105007300", Description = "水彩の魔法書", EquipmentRarity = "6", CountId = "863", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "105007300", BitNumber = "783"};
        public static readonly Item SpringSummonTicket = new Item { Name = "Spring 2019 Summon Ticket", ItemId = "1209000959", Description = "Spring 2019 Summon Ticket", EquipmentRarity = "8", CountId = "9231", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000959", BitNumber = "9231"};
        public static readonly Item GuaranteedFeaturedTicketSpring = new Item { Name = "5★ Guaranteed (30% Featured) Ticket [Spring 2019]", ItemId = "1209000961", Description = "5★ Guaranteed (30% Featured) Ticket [Spring 2019]", EquipmentRarity = "8", CountId = "9233", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000958", BitNumber = "9233"};
        public static readonly Item GuaranteedSummonTicketERTMR = new Item { Name = "5★ Guaranteed 10+1 Summon Ticket (ER TMR)", ItemId = "1209000962", Description = "5★ Guaranteed 10+1 Summon Ticket (ER TMR)", EquipmentRarity = "8", CountId = "9235", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000962", BitNumber = "9235"};
        public static readonly Item GuaranteedSummonTicketAUTMR = new Item { Name = "5★ Guaranteed 10+1 Summon Ticket (AU TMR)", ItemId = "1209000963", Description = "5★ Guaranteed 10+1 Summon Ticket (AU TMR)", EquipmentRarity = "8", CountId = "9236", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000963", BitNumber = "9236"};
        public static readonly Item ZenooftheBetaStarsPrism = new Item { Name = "Zeno of the Beta Star's Prism", ItemId = "310000380", Description = "Zeno of the Beta Star's Prism", EquipmentRarity = "8", CountId = "9234", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9234"};
        public static readonly Item GuaranteedSpecialSummonTicket_1209000964 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "1209000964", Description = "[期間限定]★5確定SP召喚チケット", EquipmentRarity = "8", CountId = "9237", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106211170", BitNumber = "9237"};
        public static readonly Item BlackMageGolbezsPrism = new Item { Name = "Black Mage Golbez's Prism", ItemId = "300001070", Description = "漆黒の魔道士ゴルベーザの輝源", EquipmentRarity = "8", CountId = "801", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "722"};
        public static readonly Item GuaranteedBlackMageGolbezTicket_1209000967 = new Item { Name = "5★ Guaranteed (Black Mage Golbez) Ticket", ItemId = "1209000967", Description = "5★ Guaranteed (Black Mage Golbez) Ticket", EquipmentRarity = "8", CountId = "9240", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000967", BitNumber = "9240"};
        public static readonly Item GuaranteedBlackMageGolbezTicket_1209000968 = new Item { Name = "5★ Guaranteed (50% Black Mage Golbez) Ticket", ItemId = "1209000968", Description = "5★ Guaranteed (50% Black Mage Golbez) Ticket", EquipmentRarity = "8", CountId = "9241", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000967", BitNumber = "9241"};
        public static readonly Item GuaranteedBlackMageGolbezTicket_1209000969 = new Item { Name = "5★ Guaranteed (20% Black Mage Golbez) Ticket", ItemId = "1209000969", Description = "5★ Guaranteed (20% Black Mage Golbez) Ticket", EquipmentRarity = "8", CountId = "9242", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000967", BitNumber = "9242"};
        public static readonly Item GuaranteedNagiTicket_1209000970 = new Item { Name = "5★ Guaranteed (Nagi) Ticket", ItemId = "1209000970", Description = "5★ Guaranteed (Nagi) Ticket", EquipmentRarity = "8", CountId = "9243", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000968", BitNumber = "9243"};
        public static readonly Item GuaranteedNagiTicket_1209000971 = new Item { Name = "5★ Guaranteed (20% Nagi) Ticket", ItemId = "1209000971", Description = "5★ Guaranteed (20% Nagi) Ticket", EquipmentRarity = "8", CountId = "9244", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000968", BitNumber = "9244"};
        public static readonly Item GuaranteedYegoTicket_1209000972 = new Item { Name = "5★ Guaranteed (Yego) Ticket", ItemId = "1209000972", Description = "5★ Guaranteed (Yego) Ticket", EquipmentRarity = "8", CountId = "9245", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000969", BitNumber = "9245"};
        public static readonly Item GuaranteedYegoTicket_1209000973 = new Item { Name = "5★ Guaranteed (20% Yego) Ticket", ItemId = "1209000973", Description = "5★ Guaranteed (20% Yego) Ticket", EquipmentRarity = "8", CountId = "9246", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000969", BitNumber = "9246"};
        public static readonly Item BlackFabric = new Item { Name = "Black Fabric", ItemId = "229000100", Description = "墨染織", EquipmentRarity = "5", CountId = "807", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "229000100", BitNumber = "727"};
        public static readonly Item WhiteGem = new Item { Name = "White Gem", ItemId = "229000200", Description = "白宝珠", EquipmentRarity = "4", CountId = "808", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "229000200", BitNumber = "728"};
        public static readonly Item ShisoPowder = new Item { Name = "Shiso Powder", ItemId = "229000300", Description = "紫蘇の粉末", EquipmentRarity = "4", CountId = "809", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "229000300", BitNumber = "729"};
        public static readonly Item GrassbeastFang = new Item { Name = "Grassbeast Fang", ItemId = "229000400", Description = "草獣の牙", EquipmentRarity = "4", CountId = "810", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "229000400", BitNumber = "730"};
        public static readonly Item OldTreeSeedShell = new Item { Name = "Old Tree Seed Shell", ItemId = "229000500", Description = "古木の種皮", EquipmentRarity = "4", CountId = "811", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "229000500", BitNumber = "731"};
        public static readonly Item AkstarsPrism = new Item { Name = "Akstar's Prism", ItemId = "300001090", Description = "アクスターの輝源", EquipmentRarity = "8", CountId = "812", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "732"};
        public static readonly Item GuaranteedFeaturedTicketAZ = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [A/Z]", ItemId = "1209000966", Description = "5★ Guaranteed (20% Featured) Ticket [A/Z]", EquipmentRarity = "8", CountId = "9239", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000958", BitNumber = "9239"};
        public static readonly Item DefenseSystemRaidCoin = new Item { Name = "Defense System Raid Coin", ItemId = "106305900", Description = "防衛システムレイドコイン", EquipmentRarity = "3", CountId = "794", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106305900", BitNumber = "713"};
        public static readonly Item GoldCircuit = new Item { Name = "Gold Circuit", ItemId = "228000100", Description = "黄金回路", EquipmentRarity = "5", CountId = "795", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "228000100", BitNumber = "714"};
        public static readonly Item HandlessClockFace = new Item { Name = "Handless Clock Face", ItemId = "228000200", Description = "針のない時計盤", EquipmentRarity = "4", CountId = "796", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "228000200", BitNumber = "715"};
        public static readonly Item ChargedFilament = new Item { Name = "Charged Filament", ItemId = "228000300", Description = "帯電したフィラメント", EquipmentRarity = "4", CountId = "797", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "228000300", BitNumber = "716"};
        public static readonly Item CopperBolt = new Item { Name = "Copper Bolt", ItemId = "228000400", Description = "赤銅のボルト", EquipmentRarity = "3", CountId = "798", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "228000400", BitNumber = "717"};
        public static readonly Item BrokenGear = new Item { Name = "Broken Gear", ItemId = "228000500", Description = "歯抜けの歯車", EquipmentRarity = "3", CountId = "799", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "228000500", BitNumber = "718"};
        public static readonly Item NagisPrism = new Item { Name = "Nagi's Prism", ItemId = "300001050", Description = "ナギの輝源", EquipmentRarity = "8", CountId = "792", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "719"};
        public static readonly Item YegosPrism = new Item { Name = "Yego's Prism", ItemId = "300001060", Description = "イーゴの輝源", EquipmentRarity = "8", CountId = "800", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "721"};
        public static readonly Item GuaranteedSpecialSummonTicket_106211230 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "106211230", Description = "[期間限定]★5確定SP召喚チケット", EquipmentRarity = "8", CountId = "846", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106211170", BitNumber = "766"};
        public static readonly Item GuaranteedSpecialSummonTicket_106211220 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "106211220", Description = "[期間限定]★5確定SP召喚チケット", EquipmentRarity = "8", CountId = "826", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106211170", BitNumber = "746"};
        public static readonly Item KingEdgarofFigarosPrism = new Item { Name = "King Edgar of Figaro's Prism", ItemId = "300001180", Description = "フィガロの王エドガーの輝源", EquipmentRarity = "8", CountId = "843", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "763"};
        public static readonly Item MonkSabinofKoltssPrism = new Item { Name = "Monk Sabin of Kolts's Prism", ItemId = "300001190", Description = "コルツの格闘家マッシュの輝源", EquipmentRarity = "8", CountId = "844", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "764"};
        public static readonly Item Walnut = new Item { Name = "Walnut", ItemId = "106306400", Description = "くるみ", EquipmentRarity = "3", CountId = "845", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106306400", BitNumber = "765"};
        public static readonly Item SummonCoinFFVIMay = new Item { Name = "Summon Coin (FFVI May 2019)", ItemId = "1209000978", Description = "Summon Coin (FFVI 5/19)", EquipmentRarity = "8", CountId = "9251", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000978", BitNumber = "9251"};
        public static readonly Item SummonCoinFFBEMay = new Item { Name = "Summon Coin (FFBE May 2019)", ItemId = "1209000979", Description = "Summon Coin (FFBE 5/19)", EquipmentRarity = "8", CountId = "9252", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000979", BitNumber = "9252"};
        public static readonly Item GuaranteedFeaturedTicketFFVI = new Item { Name = "5★ Guaranteed (30% Featured) Ticket [FFVI]", ItemId = "1209000982", Description = "5★ Guaranteed (30% Featured) Ticket [FFVI]", EquipmentRarity = "8", CountId = "9255", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000958", BitNumber = "9255"};
        public static readonly Item AmberGem = new Item { Name = "Amber Gem", ItemId = "106211120", Description = "黄宝玉", EquipmentRarity = "8", CountId = "578", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "106211120", BitNumber = "511"};
        public static readonly Item IceBookofMagic = new Item { Name = "Ice Book of Magic", ItemId = "105007500", Description = "氷陣の魔法書", EquipmentRarity = "6", CountId = "892", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "105007500", BitNumber = "811"};
        public static readonly Item SectoredCircleGreen_109303000 = new Item { Name = "Sectored Circle - Green 1", ItemId = "109303000", Description = "石板の欠片・緑1", EquipmentRarity = "7", CountId = "496", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109303000", BitNumber = "496"};
        public static readonly Item SectoredCircleGreen_109303010 = new Item { Name = "Sectored Circle - Green 2", ItemId = "109303010", Description = "石板の欠片・緑2", EquipmentRarity = "7", CountId = "497", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109303010", BitNumber = "497"};
        public static readonly Item SectoredCircleGreen_109303020 = new Item { Name = "Sectored Circle - Green 3", ItemId = "109303020", Description = "石板の欠片・緑3", EquipmentRarity = "7", CountId = "498", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109303020", BitNumber = "498"};
        public static readonly Item SectoredCircleGreen_109303030 = new Item { Name = "Sectored Circle - Green 4", ItemId = "109303030", Description = "石板の欠片・緑4", EquipmentRarity = "7", CountId = "499", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109303030", BitNumber = "499"};
        public static readonly Item SectoredCircleGreen_109303040 = new Item { Name = "Sectored Circle - Green 5", ItemId = "109303040", Description = "石板の欠片・緑5", EquipmentRarity = "7", CountId = "500", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109303040", BitNumber = "500"};
        public static readonly Item SectoredCircleGreen_109303050 = new Item { Name = "Sectored Circle - Green 6", ItemId = "109303050", Description = "石板の欠片・緑6", EquipmentRarity = "7", CountId = "501", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109303050", BitNumber = "501"};
        public static readonly Item GuaranteedSummonTicketUSTMR = new Item { Name = "5★ Guaranteed 10+1 Summon Ticket (US TMR)", ItemId = "1209000988", Description = "5★ Guaranteed 10+1 Summon Ticket (US TMR)", EquipmentRarity = "8", CountId = "9256", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000988", BitNumber = "9256"};
        public static readonly Item GuaranteedFeaturedTicketSummer = new Item { Name = "5★ Guaranteed (30% Featured) Ticket [Summer 2019]", ItemId = "1209000974", Description = "5★ Guaranteed (30% Featured) Ticket [Summer 2019]", EquipmentRarity = "8", CountId = "9247", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000958", BitNumber = "9247"};
        public static readonly Item ExchangeCoinLoginSummer = new Item { Name = "Exchange Coin (Login Summer 2019)", ItemId = "1209000980", Description = "Exchange Coin (Login Summer 2019)", EquipmentRarity = "8", CountId = "9253", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000980", BitNumber = "9253"};
        public static readonly Item SummonCoinSummerMay = new Item { Name = "Summon Coin (Summer May 2019)", ItemId = "1209000981", Description = "Summon Coin (Summer May 19)", EquipmentRarity = "8", CountId = "9254", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000981", BitNumber = "9254"};
        public static readonly Item SummerFinaLidPrism = new Item { Name = "Summer Fina & Lid Prism", ItemId = "300001140", Description = "フィーナ&リド2018夏の輝源", EquipmentRarity = "8", CountId = "827", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "747"};
        public static readonly Item SummerFolkaCitraPrism = new Item { Name = "Summer Folka & Citra Prism", ItemId = "300001220", Description = "フォルカ&シトラ2018夏の輝源", EquipmentRarity = "8", CountId = "859", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "779"};
        public static readonly Item SecretToolbox = new Item { Name = "Secret Toolbox", ItemId = "233000100", Description = "秘密の工具箱", EquipmentRarity = "5", CountId = "853", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "233000100", BitNumber = "773"};
        public static readonly Item RustyMetalParts = new Item { Name = "Rusty Metal Parts", ItemId = "233000200", Description = "錆びた金属パーツ", EquipmentRarity = "4", CountId = "854", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "233000200", BitNumber = "774"};
        public static readonly Item ResearchersNotes = new Item { Name = "Researcher's Notes", ItemId = "233000300", Description = "研究者の覚書", EquipmentRarity = "4", CountId = "855", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "233000300", BitNumber = "775"};
        public static readonly Item HomemadeLubricant = new Item { Name = "Homemade Lubricant", ItemId = "233000400", Description = "自家製潤滑油", EquipmentRarity = "4", CountId = "856", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "233000400", BitNumber = "776"};
        public static readonly Item MagneticNeedle = new Item { Name = "Magnetic Needle", ItemId = "233000500", Description = "磁鉄針", EquipmentRarity = "4", CountId = "857", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "233000500", BitNumber = "777"};
        public static readonly Item ReginasPrism = new Item { Name = "Regina's Prism", ItemId = "300001230", Description = "レジーナの輝源", EquipmentRarity = "8", CountId = "860", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "780"};
        public static readonly Item GuaranteedReginaTicket = new Item { Name = "5★ Guaranteed (20% Regina) Ticket", ItemId = "1209000983", Description = "5★ Guaranteed (20% Regina) Ticket", EquipmentRarity = "8", CountId = "9256", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000983", BitNumber = "9256"};
        public static readonly Item AerithsPrism = new Item { Name = "Aerith's Prism", ItemId = "300001120", Description = "エアリスの輝源", EquipmentRarity = "8", CountId = "822", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "742"};
        public static readonly Item RedXIIIsPrism = new Item { Name = "Red XIII's Prism", ItemId = "300001130", Description = "レッドXIIIの輝源", EquipmentRarity = "8", CountId = "823", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "743"};
        public static readonly Item BECoupon = new Item { Name = "BE Coupon", ItemId = "106306200", Description = "BEクーポン", EquipmentRarity = "3", CountId = "824", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106306200", BitNumber = "744"};
        public static readonly Item ImmortalFlameKatysPrism = new Item { Name = "Immortal Flame Katy's Prism", ItemId = "310000370", Description = "Immortal Flame Katy's Prism", EquipmentRarity = "8", CountId = "9229", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9227"};
        public static readonly Item FrostFragment = new Item { Name = "Frost Fragment", ItemId = "1209000977", Description = "Frost Fragment", EquipmentRarity = "4", CountId = "9250", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000977", BitNumber = "9250"};
        public static readonly Item GuaranteedFeaturedTicketFFVII = new Item { Name = "5★ Guaranteed (30% Featured) Ticket [FFVII]", ItemId = "1209000984", Description = "5★ Guaranteed (30% Featured) Ticket [FFVII]", EquipmentRarity = "8", CountId = "9257", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000984", BitNumber = "9257"};
        public static readonly Item PremiumSummonTicketFFVII = new Item { Name = "Premium 10+1 Summon Ticket [FFVII]", ItemId = "1209000985", Description = "Premium 10+1 Summon Ticket [FFVII]", EquipmentRarity = "8", CountId = "9258", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "908", BitNumber = "9258"};
        public static readonly Item PremiumSummonTicketrdAnniv = new Item { Name = "Premium 10+1 Summon Ticket [3rd Anniv.]", ItemId = "1209000986", Description = "Premium 10+1 Summon Ticket [3rd Anniv.]", EquipmentRarity = "8", CountId = "9259", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "908", BitNumber = "9259"};
        public static readonly Item rdAnniversaryMedal = new Item { Name = "3rd Anniversary Medal", ItemId = "1209000987", Description = "3rd Anniversary Medal", EquipmentRarity = "8", CountId = "9260", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000987", BitNumber = "9254"};
        public static readonly Item SummonCoinrdAnnivCountdown = new Item { Name = "Summon Coin (3rd Anniv. Countdown)", ItemId = "1209000993", Description = "Summon Coin (3rd Anniv. Countdown)", EquipmentRarity = "8", CountId = "9266", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000993", BitNumber = "9266"};
        public static readonly Item CollectionofManaLimitedTimeExchangeTicketFR = new Item { Name = "Collection of Mana Limited Time Exchange Ticket [F/R]", ItemId = "1209000991", Description = "Collection of Mana Limited Time Exchange Ticket [F/R]", EquipmentRarity = "8", CountId = "9264", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000991", BitNumber = "9264"};
        public static readonly Item GuaranteedSummonTicketFlyingBlades = new Item { Name = "5★ Guaranteed 10+1 Summon Ticket (Flying Blades)", ItemId = "1209000994", Description = "5★ Guaranteed 10+1 Ticket (Flying Blades)", EquipmentRarity = "8", CountId = "9267", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000988", BitNumber = "9267"};
        public static readonly Item KimonoAyakasPrism = new Item { Name = "Kimono Ayaka's Prism", ItemId = "300001250", Description = "晴れ着アヤカの輝源", EquipmentRarity = "8", CountId = "873", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "792"};
        public static readonly Item DressyAileensPrism = new Item { Name = "Dressy Aileen's Prism", ItemId = "300001260", Description = "ドレスアップアイリーンの輝源", EquipmentRarity = "8", CountId = "874", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "793"};
        public static readonly Item PlayersVoiceTicketPart_1209000989 = new Item { Name = "Player's Voice Ticket 2019 (Part 1)", ItemId = "1209000989", Description = "Player's Voice Ticket 2019 (Part 1)", EquipmentRarity = "8", CountId = "9262", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000989", BitNumber = "9262"};
        public static readonly Item PlayersVoiceTicketPart_1209000990 = new Item { Name = "Player's Voice Ticket 2019 (Part 2)", ItemId = "1209000990", Description = "Player's Voice Ticket 2019 (Part 2)", EquipmentRarity = "8", CountId = "9263", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000990", BitNumber = "9263"};
        public static readonly Item rdAnniversaryTicket = new Item { Name = "3rd Anniversary Ticket", ItemId = "1209000992", Description = "3rd Anniversary Ticket", EquipmentRarity = "8", CountId = "9265", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000992", BitNumber = "9265"};
        public static readonly Item GuaranteedFeaturedTicketKADA = new Item { Name = "5★ Guaranteed (30% Featured) Ticket [KA/DA]", ItemId = "1209000995", Description = "5★ Guaranteed (30% Featured) Ticket [KA/DA]", EquipmentRarity = "8", CountId = "9268", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000995", BitNumber = "9268"};
        public static readonly Item SummonCoinKAyakaDAileen = new Item { Name = "Summon Coin (K.Ayaka/D.Aileen)", ItemId = "1209000999", Description = "Summon Coin (K.Ayaka/D.Aileen)", EquipmentRarity = "8", CountId = "9272", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000999", BitNumber = "9272"};
        public static readonly Item SummonCoinrdAnnivSummon = new Item { Name = "Summon Coin (3rd Anniv. Summon)", ItemId = "1209001005", Description = "Summon Coin (3rd Anniv. Summon)", EquipmentRarity = "8", CountId = "9278", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001005", BitNumber = "9278"};
        public static readonly Item ExchangeCoinComebackQuests = new Item { Name = "Exchange Coin (Comeback Quests)", ItemId = "1209001006", Description = "Exchange Coin (Comeback Quests)", EquipmentRarity = "8", CountId = "9279", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001006", BitNumber = "9279"};
        public static readonly Item ComebackSummonTicket_1209001009 = new Item { Name = "Comeback 10+1 Summon Ticket", ItemId = "1209001009", Description = "Comeback 10+1 Summon Ticket", EquipmentRarity = "8", CountId = "9282", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001009", BitNumber = "9282"};
        public static readonly Item EarthBookofMagic = new Item { Name = "Earth Book of Magic", ItemId = "105007600", Description = "土陣の魔法書", EquipmentRarity = "6", CountId = "915", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "105007600", BitNumber = "833"};
        public static readonly Item FireBookofMagic = new Item { Name = "Fire Book of Magic", ItemId = "105007700", Description = "火陣の魔法書", EquipmentRarity = "6", CountId = "941", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "105007700", BitNumber = "859"};
        public static readonly Item LightningBookofMagic = new Item { Name = "Lightning Book of Magic", ItemId = "105007800", Description = "雷陣の魔法書", EquipmentRarity = "6", CountId = "956", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "105007800", BitNumber = "873"};
        public static readonly Item FightingPitsCoin = new Item { Name = "Fighting Pits Coin", ItemId = "1209000998", Description = "Gigantuar Penny (Fighting Pits Coin)", EquipmentRarity = "8", CountId = "9271", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000998", BitNumber = "9271"};
        public static readonly Item GuaranteedSpecialSummonTicket_106211280 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "106211280", Description = "[期間限定]★5確定SP召喚チケット", EquipmentRarity = "8", CountId = "861", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106211170", BitNumber = "781"};
        public static readonly Item GysahlSeeds = new Item { Name = "Gysahl Seeds", ItemId = "106306500", Description = "ギサールの種", EquipmentRarity = "3", CountId = "862", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106306500", BitNumber = "782"};
        public static readonly Item EpicGuaranteedSummonTicketHeroes = new Item { Name = "Epic 5★ Guaranteed 10+1 Summon Ticket (Heroes)", ItemId = "1209001007", Description = "5★ Guaranteed 10+1 Ticket (Heroes)", EquipmentRarity = "8", CountId = "9280", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001007", BitNumber = "9280"};
        public static readonly Item EpicGuaranteedSummonTicketSwornSix = new Item { Name = "Epic 5★ Guaranteed 10+1 Summon Ticket (Sworn Six)", ItemId = "1209001008", Description = "5★ Guaranteed 10+1 Ticket (Sworn Six)", EquipmentRarity = "8", CountId = "9281", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001008", BitNumber = "9281"};
        public static readonly Item SuperTrustMoogleExchangeTicket = new Item { Name = "Super Trust Moogle Exchange Ticket", ItemId = "106211340", Description = "スーパートラストモーグリ交換チケット", EquipmentRarity = "8", CountId = "917", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "106211340", BitNumber = "835"};
        public static readonly Item MagicSilverIngot = new Item { Name = "Magic Silver Ingot", ItemId = "234000100", Description = "魔法銀のインゴット", EquipmentRarity = "5", CountId = "865", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "234000100", BitNumber = "785"};
        public static readonly Item SilverHilt = new Item { Name = "Silver Hilt", ItemId = "234000200", Description = "銀色の柄", EquipmentRarity = "4", CountId = "866", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "234000200", BitNumber = "786"};
        public static readonly Item SeawolfFang = new Item { Name = "Seawolf Fang", ItemId = "234000300", Description = "海狼の牙", EquipmentRarity = "4", CountId = "867", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "234000300", BitNumber = "787"};
        public static readonly Item SilverGrayLog = new Item { Name = "Silver-Gray Log", ItemId = "234000400", Description = "銀灰色の丸材", EquipmentRarity = "4", CountId = "868", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "234000400", BitNumber = "788"};
        public static readonly Item SilverOrb = new Item { Name = "Silver Orb", ItemId = "234000500", Description = "銀の宝玉", EquipmentRarity = "4", CountId = "869", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "234000500", BitNumber = "789"};
        public static readonly Item SacredShieldCharlottesPrism = new Item { Name = "Sacred Shield Charlotte's Prism", ItemId = "300001240", Description = "聖盾の騎士シャルロットの輝源", EquipmentRarity = "8", CountId = "864", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "784"};
        public static readonly Item GuaranteedSummonTicketFanFesta = new Item { Name = "5★ Guaranteed 10+1 Summon Ticket (Fan Festa)", ItemId = "1209001010", Description = "Special 5★ Guaranteed 10+1 Summon Ticket (Fan Fiesta)", EquipmentRarity = "8", CountId = "9284", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001010", BitNumber = "9284"};
        public static readonly Item DachaoRaidCoin = new Item { Name = "Da-chao Raid Coin", ItemId = "106306300", Description = "ダチャオ像レイドコイン", EquipmentRarity = "3", CountId = "836", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106306300", BitNumber = "756"};
        public static readonly Item LiquidMako = new Item { Name = "Liquid Mako", ItemId = "232000100", Description = "魔晄液", EquipmentRarity = "5", CountId = "837", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "232000100", BitNumber = "757"};
        public static readonly Item Flywheel = new Item { Name = "Flywheel", ItemId = "232000200", Description = "フライホイール", EquipmentRarity = "4", CountId = "838", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "232000200", BitNumber = "758"};
        public static readonly Item NamelessFlower = new Item { Name = "Nameless Flower", ItemId = "232000300", Description = "名もなき花", EquipmentRarity = "4", CountId = "839", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "232000300", BitNumber = "759"};
        public static readonly Item SteelJoint = new Item { Name = "Steel Joint", ItemId = "232000400", Description = "スチールジョイント", EquipmentRarity = "3", CountId = "840", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "232000400", BitNumber = "760"};
        public static readonly Item Digestive = new Item { Name = "Digestive", ItemId = "232000500", Description = "消化薬", EquipmentRarity = "3", CountId = "841", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "232000500", BitNumber = "761"};
        public static readonly Item ZacksPrism = new Item { Name = "Zack's Prism", ItemId = "300001160", Description = "ザックスの輝源", EquipmentRarity = "8", CountId = "834", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "754"};
        public static readonly Item YuffiesPrism = new Item { Name = "Yuffie's Prism", ItemId = "300001170", Description = "ユフィの輝源", EquipmentRarity = "8", CountId = "835", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "755"};
        public static readonly Item GuaranteedFeaturedTicketYZ = new Item { Name = "5★ Guaranteed (30% Featured) Ticket [Y/Z]", ItemId = "1209001012", Description = "5★ Guaranteed (30% Featured) Ticket [Y/Z]", EquipmentRarity = "8", CountId = "9287", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001012", BitNumber = "9287"};
        public static readonly Item SummonCoinrdAnnivSummonII = new Item { Name = "Summon Coin (3rd Anniv. Summon II)", ItemId = "1209001013", Description = "Summon Coin (3rd Anniv. Summon II)", EquipmentRarity = "8", CountId = "9288", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001013", BitNumber = "9288"};
        public static readonly Item GuaranteedSummonTicketFFVII = new Item { Name = "5★ Guaranteed 10+1 Summon Ticket (FFVII)", ItemId = "1209001011", Description = "Special 5★ Guaranteed 10+1 Summon Ticket (FF VII)", EquipmentRarity = "8", CountId = "9285", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001011", BitNumber = "9285"};
        public static readonly Item SummonCoinElenaMorgana = new Item { Name = "Summon Coin (Elena/Morgana)", ItemId = "1209001014", Description = "Summon Coin (Elena/Morgana)", EquipmentRarity = "8", CountId = "9289", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001014", BitNumber = "9289"};
        public static readonly Item ElenasPrism = new Item { Name = "Elena's Prism", ItemId = "310000400", Description = "Elena's Prism", EquipmentRarity = "8", CountId = "9286", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9286"};
        public static readonly Item GuaranteedFeaturedTicketEM = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [E/M]", ItemId = "1209001015", Description = "5★ Guaranteed (20% Featured) Ticket [E/M]", EquipmentRarity = "8", CountId = "9290", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001015", BitNumber = "9290"};
        public static readonly Item MorganasPrism = new Item { Name = "Morgana's Prism", ItemId = "310000410", Description = "Morgana's Prism", EquipmentRarity = "8", CountId = "9291", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9291"};
        public static readonly Item RedStarQuartz = new Item { Name = "Red Star Quartz", ItemId = "106211240", Description = "レッドスタークォーツ", EquipmentRarity = "8", CountId = "847", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "106211240", BitNumber = "767"};
        public static readonly Item AmethystShards = new Item { Name = "Amethyst Shards", ItemId = "1209000975", Description = "Amethyst Shards", EquipmentRarity = "3", CountId = "9248", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000975", BitNumber = "9248"};
        public static readonly Item AmethystCoin = new Item { Name = "Amethyst Coin", ItemId = "1209000976", Description = "Amethyst Coin", EquipmentRarity = "4", CountId = "9249", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209000976", BitNumber = "9249"};
        public static readonly Item EnlightenmentPoints = new Item { Name = "Enlightenment Point(s)", ItemId = "1209001000", Description = "AP Orb", EquipmentRarity = "4", CountId = "9273", IsPotUnit = "0", KeyName = "0", ItemStack = "50000", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "1209001000", BitNumber = "9273"};
        public static readonly Item DiamondEnlightenmentKey = new Item { Name = "Diamond Enlightenment Key", ItemId = "1209001001", Description = "Diamond AP Key", EquipmentRarity = "7", CountId = "9274", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "1209001001", BitNumber = "9274"};
        public static readonly Item GoldEnlightenmentKey = new Item { Name = "Gold Enlightenment Key", ItemId = "1209001002", Description = "Gold AP Key", EquipmentRarity = "6", CountId = "9275", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "1209001002", BitNumber = "9275"};
        public static readonly Item SilverEnlightenmentKey = new Item { Name = "Silver Enlightenment Key", ItemId = "1209001003", Description = "Silver AP Key", EquipmentRarity = "5", CountId = "9276", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "1209001003", BitNumber = "9276"};
        public static readonly Item BronzeEnlightenmentKey = new Item { Name = "Bronze Enlightenment Key", ItemId = "1209001004", Description = "Bronze AP Key", EquipmentRarity = "4", CountId = "9277", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "1209001004", BitNumber = "9277"};
        public static readonly Item RiverasPrism = new Item { Name = "Rivera's Prism", ItemId = "310000390", Description = "Rivera's Prism", EquipmentRarity = "8", CountId = "9283", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9283"};
        public static readonly Item KingGoldenBombRaidCoin = new Item { Name = "King Golden Bomb Raid Coin", ItemId = "106306700", Description = "キングゴールデンボムレイドコイン", EquipmentRarity = "3", CountId = "879", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106306700", BitNumber = "802"};
        public static readonly Item SnowWhiteFlower = new Item { Name = "Snow White Flower", ItemId = "235000100", Description = "雪白の花", EquipmentRarity = "5", CountId = "880", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235000100", BitNumber = "803"};
        public static readonly Item FestivePetals = new Item { Name = "Festive Petals", ItemId = "235000200", Description = "祝祭の花びら", EquipmentRarity = "4", CountId = "881", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235000200", BitNumber = "804"};
        public static readonly Item BeautifulPurpleCloth = new Item { Name = "Beautiful Purple Cloth", ItemId = "235000300", Description = "麗紫の布", EquipmentRarity = "4", CountId = "882", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235000300", BitNumber = "805"};
        public static readonly Item InvitingPerfume = new Item { Name = "Inviting Perfume", ItemId = "235000400", Description = "誘香水", EquipmentRarity = "3", CountId = "883", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235000400", BitNumber = "806"};
        public static readonly Item VioletSilkThread = new Item { Name = "Violet Silk Thread", ItemId = "235000500", Description = "紫の絹糸", EquipmentRarity = "3", CountId = "884", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235000500", BitNumber = "807"};
        public static readonly Item SummonCoinRLightningNHope = new Item { Name = "Summon Coin (R.Lightning/N.Hope)", ItemId = "1209001016", Description = "Summon Coin (R.Lightning/N.Hope)", EquipmentRarity = "8", CountId = "9292", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001016", BitNumber = "9292"};
        public static readonly Item GuaranteedFeaturedTicketRLightningNHope = new Item { Name = "5★ Guaranteed (30% Featured) Ticket [R.Lightning/N.Hope]", ItemId = "1209001017", Description = "5★ Guaranteed (30% Featured) Ticket [R.Lightning/N.Hope]", EquipmentRarity = "8", CountId = "9293", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001017", BitNumber = "9293"};
        public static readonly Item AnniversaryFollowUpTicket = new Item { Name = "Anniversary Follow-Up Ticket", ItemId = "1209001026", Description = "Anniversary Follow-Up Ticket", EquipmentRarity = "8", CountId = "9302", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001026", BitNumber = "9302"};
        public static readonly Item AnniversaryFollowUpCoin = new Item { Name = "Anniversary Follow-Up Coin", ItemId = "1209001027", Description = "Anniversary Follow-Up Coin", EquipmentRarity = "8", CountId = "9303", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001027", BitNumber = "9303"};
        public static readonly Item RadiantLightningsPrism = new Item { Name = "Radiant Lightning's Prism", ItemId = "300001300", Description = "髢・・縺ｮ繝ｩ繧､繝医ル繝ｳ繧ｰ縺ｮ霈晄ｺ・", EquipmentRarity = "8", CountId = "887", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "797"};
        public static readonly Item NeverendingHopesPrism = new Item { Name = "Neverending Hope's Prism", ItemId = "300001310", Description = "譛ｪ譚･縺ｸ縺ｮ繝帙・繝励・霈晄ｺ・", EquipmentRarity = "8", CountId = "888", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "798"};
        public static readonly Item GuaranteedSpecialSummonTicket_106211310 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "106211310", Description = "[期間限定]★5確定SP召喚チケット", EquipmentRarity = "8", CountId = "886", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106211170", BitNumber = "809"};
        public static readonly Item CreditChip = new Item { Name = "Credit Chip", ItemId = "106306800", Description = "クレジットチップ", EquipmentRarity = "3", CountId = "885", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106306800", BitNumber = "808"};
        public static readonly Item SummonCoinAnnivFollowUp = new Item { Name = "Summon Coin (Anniv. Follow-Up)", ItemId = "1209001028", Description = "Summon Coin (Anniv. Follow-Up)", EquipmentRarity = "8", CountId = "9304", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001028", BitNumber = "9304"};
        public static readonly Item BlazingStone = new Item { Name = "Blazing Stone", ItemId = "1209000996", Description = "Blazing Stone", EquipmentRarity = "3", CountId = "9269", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000996", BitNumber = "9269"};
        public static readonly Item BlazingCoin = new Item { Name = "Blazing Coin", ItemId = "1209000997", Description = "Blazing Coin", EquipmentRarity = "4", CountId = "9270", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209000997", BitNumber = "9270"};
        public static readonly Item TsukikosPrism = new Item { Name = "Tsukiko's Prism", ItemId = "310000412", Description = "Tsukiko's Prism", EquipmentRarity = "8", CountId = "9309", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9309"};
        public static readonly Item KaitosPrism = new Item { Name = "Kaito's Prism", ItemId = "310000411", Description = "Kaito's Prism", EquipmentRarity = "8", CountId = "9308", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9308"};
        public static readonly Item GuaranteedFeaturedTicketKT = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [K/T]", ItemId = "1209001030", Description = "5★ Guaranteed (20% Featured) Ticket [K/T]", EquipmentRarity = "8", CountId = "9306", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001030", BitNumber = "9306"};
        public static readonly Item SummonCoinKaitoTsukiko = new Item { Name = "Summon Coin (Kaito/Tsukiko)", ItemId = "1209001031", Description = "Summon Coin (Kaito/Tsukiko)", EquipmentRarity = "8", CountId = "9307", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001031", BitNumber = "9307"};
        public static readonly Item GuaranteedFeaturedTicketEndofSummer = new Item { Name = "5★ Guaranteed (30% Featured) Ticket [End of Summer 2019]", ItemId = "1209001032", Description = "5★ Guaranteed (30% Featured) Ticket [End of Summer 2019]", EquipmentRarity = "8", CountId = "9310", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001032", BitNumber = "9310"};
        public static readonly Item SummonCoinEndofSummer = new Item { Name = "Summon Coin (End of Summer 2019)", ItemId = "1209001033", Description = "Summon Coin (End of Summer 2019)", EquipmentRarity = "8", CountId = "9311", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001033", BitNumber = "9311"};
        public static readonly Item KimonoFinasPrism = new Item { Name = "Kimono Fina's Prism", ItemId = "300001450", Description = "晴れ着フィーナの輝源", EquipmentRarity = "8", CountId = "936", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "854"};
        public static readonly Item GastonsRaidCoin = new Item { Name = "Gaston's Raid Coin", ItemId = "106306100", Description = "ガストンレイドコイン", EquipmentRarity = "3", CountId = "815", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106306100", BitNumber = "735"};
        public static readonly Item SunlandsSilk = new Item { Name = "Sunlands Silk", ItemId = "230000100", Description = "サンランドのシルク", EquipmentRarity = "5", CountId = "816", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "230000100", BitNumber = "736"};
        public static readonly Item SteelIngot = new Item { Name = "Steel Ingot", ItemId = "230000200", Description = "鋼片", EquipmentRarity = "4", CountId = "817", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "230000200", BitNumber = "737"};
        public static readonly Item DesertBranch = new Item { Name = "Desert Branch", ItemId = "230000300", Description = "砂漠の木片", EquipmentRarity = "4", CountId = "818", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "230000300", BitNumber = "738"};
        public static readonly Item RedMineral = new Item { Name = "Red Mineral", ItemId = "230000400", Description = "赤の結晶", EquipmentRarity = "3", CountId = "819", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "230000400", BitNumber = "739"};
        public static readonly Item BlueMineral = new Item { Name = "Blue Mineral", ItemId = "230000500", Description = "青の結晶", EquipmentRarity = "3", CountId = "820", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "230000500", BitNumber = "740"};
        public static readonly Item PrimrosesPrism = new Item { Name = "Primrose's Prism", ItemId = "300001100", Description = "繝励Μ繝繝ｭ繧ｼ縺ｮ霈晄ｺ・", EquipmentRarity = "8", CountId = "813", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "733"};
        public static readonly Item OlbericsPrism = new Item { Name = "Olberic's Prism", ItemId = "300001110", Description = "オルベリクの輝源", EquipmentRarity = "8", CountId = "814", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "734"};
        public static readonly Item OCTOPATHTRAVELERLimitedTimeExchangeTicketPO = new Item { Name = "OCTOPATH TRAVELER Limited Time Exchange Ticket [P/O]", ItemId = "1209001036", Description = "Octopath Traveler Limited Exchange Ticket [P/O]", EquipmentRarity = "8", CountId = "9314", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001036", BitNumber = "9314"};
        public static readonly Item ExchangeCoinEnhancedUnits = new Item { Name = "Exchange Coin (Enhanced Units)", ItemId = "1209001037", Description = "Exchange Coin (Units Revamp)", EquipmentRarity = "8", CountId = "9315", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001037", BitNumber = "9315"};
        public static readonly Item ExchangeCoinEUTrustMoogle = new Item { Name = "Exchange Coin (EU Trust Moogle)", ItemId = "1209001038", Description = "Exchange Coin (Units TMR)", EquipmentRarity = "8", CountId = "9316", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001038", BitNumber = "9316"};
        public static readonly Item WarriorofLightBartzsPrism = new Item { Name = "Warrior of Light Bartz's Prism", ItemId = "300001380", Description = "光の戦士バッツの輝源", EquipmentRarity = "8", CountId = "912", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "830"};
        public static readonly Item WarriorofLightLennasPrism = new Item { Name = "Warrior of Light Lenna's Prism", ItemId = "300001390", Description = "光の戦士レナの輝源", EquipmentRarity = "8", CountId = "913", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "831"};
        public static readonly Item DragonGrass = new Item { Name = "Dragon Grass", ItemId = "106307000", Description = "飛竜草", EquipmentRarity = "3", CountId = "910", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106307000", BitNumber = "828"};
        public static readonly Item GuaranteedSpecialSummonTicket_106211320 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "106211320", Description = "[期間限定]★5確定SP召喚チケット", EquipmentRarity = "8", CountId = "911", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106211170", BitNumber = "829"};
        public static readonly Item LargeBodyRaidCoin = new Item { Name = "Large Body Raid Coin", ItemId = "106308800", Description = "ラージボディレイドコイン", EquipmentRarity = "3", CountId = "1165", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106308800", BitNumber = "1082"};
        public static readonly Item OrichalcumKH = new Item { Name = "Orichalcum (KH)", ItemId = "235017300", Description = "オリハルコン(キングダム ハーツ)", EquipmentRarity = "5", CountId = "1166", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235017300", BitNumber = "1083"};
        public static readonly Item BreathofWind = new Item { Name = "Breath of Wind", ItemId = "235017400", Description = "風の息吹", EquipmentRarity = "5", CountId = "1167", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235017400", BitNumber = "1084"};
        public static readonly Item DazzlingStone = new Item { Name = "Dazzling Stone", ItemId = "235017500", Description = "きらめくしずく", EquipmentRarity = "4", CountId = "1168", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235017500", BitNumber = "1085"};
        public static readonly Item ThunderGem = new Item { Name = "Thunder Gem", ItemId = "235017600", Description = "とどろく魔石", EquipmentRarity = "3", CountId = "1169", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235017600", BitNumber = "1086"};
        public static readonly Item FrostShard = new Item { Name = "Frost Shard", ItemId = "235017700", Description = "凍てつくかけら", EquipmentRarity = "3", CountId = "1170", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235017700", BitNumber = "1087"};
        public static readonly Item GuaranteedFeaturedTicketWOLBartzWOLLenna = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [WOL.Bartz/WOL.Lenna]", ItemId = "1209001039", Description = "5★ Guaranteed (20% Featured) Ticket [WOL.Bartz/WOL.Lenna]", EquipmentRarity = "8", CountId = "9317", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001039", BitNumber = "9317"};
        public static readonly Item SummonCoinWOLBartzWOLLenna = new Item { Name = "Summon Coin (WOL.Bartz/WOL.Lenna)", ItemId = "1209001040", Description = "Summon Coin (WOL.Bartz/WOL.Lenna)", EquipmentRarity = "8", CountId = "9318", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001040", BitNumber = "9318"};
        public static readonly Item MDLStepUpSummonTicket = new Item { Name = "40M DL Step-Up Summon Ticket", ItemId = "1209001041", Description = "40M DL Step-Up Summon Ticket", EquipmentRarity = "8", CountId = "9319", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001041", BitNumber = "9319"};
        public static readonly Item MDLGuaranteedStepUpSummonTicket = new Item { Name = "40M DL 5★ Guaranteed Step-Up Summon Ticket", ItemId = "1209001042", Description = "40M DL 5★ Guaranteed Step-Up Summon Ticket", EquipmentRarity = "8", CountId = "9320", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001042", BitNumber = "9320"};
        public static readonly Item RikusPrism = new Item { Name = "Riku's Prism", ItemId = "300002030", Description = "リクの輝源", EquipmentRarity = "8", CountId = "1162", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1079"};
        public static readonly Item SephirothKHsPrism = new Item { Name = "Sephiroth (KH)'s Prism", ItemId = "300002040", Description = "セフィロス(キングダム ハーツ)の輝源", EquipmentRarity = "8", CountId = "1163", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1080"};
        public static readonly Item SolsPrism = new Item { Name = "Sol's Prism", ItemId = "300001340", Description = "ソルの輝源", EquipmentRarity = "8", CountId = "893", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "812"};
        public static readonly Item LifestoneOre = new Item { Name = "Lifestone Ore", ItemId = "235001100", Description = "生命岩の原石", EquipmentRarity = "5", CountId = "894", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235001100", BitNumber = "813"};
        public static readonly Item GoldenDevilTail = new Item { Name = "Golden Devil Tail", ItemId = "235001200", Description = "黄金魔の尾", EquipmentRarity = "4", CountId = "895", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235001200", BitNumber = "814"};
        public static readonly Item LightEatingBlackCrystal = new Item { Name = "Light-Eating Black Crystal", ItemId = "235001300", Description = "光飲黒晶", EquipmentRarity = "4", CountId = "896", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235001300", BitNumber = "815"};
        public static readonly Item MeteoriteFragment = new Item { Name = "Meteorite Fragment", ItemId = "235001400", Description = "隕石の欠片", EquipmentRarity = "4", CountId = "897", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235001400", BitNumber = "816"};
        public static readonly Item CosmoPowder = new Item { Name = "Cosmo Powder", ItemId = "235001500", Description = "コスモパウダー", EquipmentRarity = "4", CountId = "898", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235001500", BitNumber = "817"};
        public static readonly Item GuaranteedSpecialSummonTicket_106211390 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "106211390", Description = "[期間限定]★5確定SP召喚チケット", EquipmentRarity = "8", CountId = "951", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106211170", BitNumber = "868"};
        public static readonly Item LovelyKatysPrism = new Item { Name = "Lovely Katy's Prism", ItemId = "310000420", Description = "Lovely Katy's Prism", EquipmentRarity = "8", CountId = "9323", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9323"};
        public static readonly Item AIKatysPrism = new Item { Name = "A.I. Katy's Prism", ItemId = "310000430", Description = "AI Katy's Prism", EquipmentRarity = "8", CountId = "9324", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9324"};
        public static readonly Item MDLRaffleTicket = new Item { Name = "40M DL Raffle Ticket", ItemId = "1209001043", Description = "40M DL Raffle Ticket", EquipmentRarity = "8", CountId = "9321", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001043", BitNumber = "9321"};
        public static readonly Item MDLFestiveRaffleTicket = new Item { Name = "40M DL Festive Raffle Ticket", ItemId = "1209001044", Description = "40M DL Festive Raffle Ticket", EquipmentRarity = "8", CountId = "9322", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001044", BitNumber = "9322"};
        public static readonly Item SummonCoinSoraCloudKH = new Item { Name = "Summon Coin (Sora/Cloud (KH))", ItemId = "1209001045", Description = "Summon Coin  (Sora/Cloud (KH))", EquipmentRarity = "8", CountId = "9325", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001045", BitNumber = "9325"};
        public static readonly Item SummonCoinRikuSephirothKH = new Item { Name = "Summon Coin (Riku/Sephiroth (KH))", ItemId = "1209001046", Description = "Summon Coin  (Riku/Sephiroth (KH))", EquipmentRarity = "8", CountId = "9326", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001046", BitNumber = "9326"};
        public static readonly Item GuaranteedFeaturedTicketSoraCloudKH = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [Sora/Cloud (KH)]", ItemId = "1209001047", Description = "5★ Guaranteed (20% Featured) Ticket [Sora/Cloud (KH)]", EquipmentRarity = "8", CountId = "9327", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001047", BitNumber = "9327"};
        public static readonly Item GuaranteedFeaturedTicketRikuSephirothKH = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [Riku/Sephiroth(KH)]", ItemId = "1209001048", Description = "5★ Guaranteed (20% Featured) Ticket [Riku/Sephiroth (KH)]", EquipmentRarity = "8", CountId = "9328", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001048", BitNumber = "9328"};
        public static readonly Item MordegonsPrism = new Item { Name = "Mordegon's Prism", ItemId = "300002050", Description = "魔道士ウルノーガの輝源", EquipmentRarity = "8", CountId = "1173", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1088"};
        public static readonly Item ElevensPrism = new Item { Name = "Eleven's Prism", ItemId = "300002070", Description = "勇者イレブンの輝源", EquipmentRarity = "8", CountId = "1175", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1090"};
        public static readonly Item VeronicasPrism = new Item { Name = "Veronica's Prism", ItemId = "300002080", Description = "ベロニカの輝源", EquipmentRarity = "8", CountId = "1176", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1091"};
        public static readonly Item SerenasPrism = new Item { Name = "Serena's Prism", ItemId = "300002090", Description = "セーニャの輝源", EquipmentRarity = "8", CountId = "1177", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1092"};
        public static readonly Item DrasilanGuinea = new Item { Name = "Drasilan Guinea", ItemId = "106308900", Description = "ユグノア銀貨", EquipmentRarity = "3", CountId = "1177", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106308900", BitNumber = "1094"};
        public static readonly Item GuaranteedSpecialSummonTicket_106211910 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "106211910", Description = "[期間限定]★5確定SP召喚チケット2019/9", EquipmentRarity = "8", CountId = "1186", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106211170", BitNumber = "1104"};
        public static readonly Item DQXISSpecialUnitSummoningKeySilver_106211880 = new Item { Name = "DQXI S Special Unit Summoning Key [Silver]", ItemId = "106211880", Description = "DQ XI S Special Unit Summoning Key [Silver]", EquipmentRarity = "8", CountId = "9331", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "106211880", BitNumber = "9331"};
        public static readonly Item DQXISSpecialUnitSummoningKeyGold_106211890 = new Item { Name = "DQXI S Special Unit Summoning Key [Gold]", ItemId = "106211890", Description = "DQ XI S Special Unit Summoning Key [Gold]", EquipmentRarity = "8", CountId = "9329", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "106211890", BitNumber = "9329"};
        public static readonly Item SummonCoinEVS = new Item { Name = "Summon Coin (E/V/S)", ItemId = "1209001050", Description = "Summon Coin (E/V/S)", EquipmentRarity = "8", CountId = "9330", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001050", BitNumber = "9330"};
        public static readonly Item WildRoseFirionsPrism = new Item { Name = "Wild Rose Firion's Prism", ItemId = "300001500", Description = "のばらの義士フリオニールの輝源", EquipmentRarity = "8", CountId = "953", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "870"};
        public static readonly Item DarkKnightLeonsPrism = new Item { Name = "Dark Knight Leon's Prism", ItemId = "300001510", Description = "闇騎士レオンハルトの輝源", EquipmentRarity = "8", CountId = "954", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "871"};
        public static readonly Item WildRose = new Item { Name = "Wild Rose", ItemId = "106307400", Description = "のばら", EquipmentRarity = "3", CountId = "952", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106307400", BitNumber = "869"};
        public static readonly Item SummonCoinWRFirionDKLeon = new Item { Name = "Summon Coin (WR.Firion/DK.Leon)", ItemId = "1209001051", Description = "Summon Coin (WR.Firion/DK.Leon)", EquipmentRarity = "8", CountId = "9333", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001051", BitNumber = "9333"};
        public static readonly Item GuaranteedFeaturedTicketFFII = new Item { Name = "5★ Guaranteed (30% Featured) Ticket [FFII]", ItemId = "1209001049", Description = "5★ Guaranteed (30% Featured) Ticket [FFII]", EquipmentRarity = "8", CountId = "9332", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001049", BitNumber = "9332"};
        public static readonly Item SummonCoinMDLCelebration = new Item { Name = "Summon Coin  (40M DL Celebration)", ItemId = "1209001052", Description = "Summon Coin (40M DL Celebration)", EquipmentRarity = "8", CountId = "9334", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001052", BitNumber = "9334"};
        public static readonly Item WarriorofLightKrilesPrism = new Item { Name = "Warrior of Light Krile's Prism", ItemId = "300001350", Description = "光の戦士クルルの輝源", EquipmentRarity = "8", CountId = "899", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "818"};
        public static readonly Item DarkMageExdeathsPrism = new Item { Name = "Dark Mage Exdeath's Prism", ItemId = "300001360", Description = "暗黒魔道士エクスデスの輝源", EquipmentRarity = "8", CountId = "900", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "819"};
        public static readonly Item WarriorofDawnGalufsPrism = new Item { Name = "Warrior of Dawn Galuf's Prism", ItemId = "300001370", Description = "暁の四戦士ガラフの輝源", EquipmentRarity = "8", CountId = "901", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "820"};
        public static readonly Item AtomosRaidCoin = new Item { Name = "Atomos Raid Coin", ItemId = "106306900", Description = "アトモスレイドコイン", EquipmentRarity = "3", CountId = "902", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106306900", BitNumber = "821"};
        public static readonly Item PoisonousFang = new Item { Name = "Poisonous Fang", ItemId = "235002100", Description = "毒々しい牙", EquipmentRarity = "5", CountId = "903", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235002100", BitNumber = "822"};
        public static readonly Item BlackYarn = new Item { Name = "Black Yarn", ItemId = "235002200", Description = "黒の糸", EquipmentRarity = "4", CountId = "904", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235002200", BitNumber = "823"};
        public static readonly Item BlackLumber = new Item { Name = "Black Lumber", ItemId = "235002300", Description = "黒の木材", EquipmentRarity = "4", CountId = "905", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235002300", BitNumber = "824"};
        public static readonly Item FusedStone = new Item { Name = "Fused Stone", ItemId = "235002400", Description = "融合石", EquipmentRarity = "3", CountId = "906", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235002400", BitNumber = "825"};
        public static readonly Item MetalRing = new Item { Name = "Metal Ring", ItemId = "235002500", Description = "金属の輪", EquipmentRarity = "3", CountId = "907", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235002500", BitNumber = "826"};
        public static readonly Item ChocoboFinasPrism = new Item { Name = "Chocobo Fina's Prism", ItemId = "300001400", Description = "フィーナ&チョコボの輝源", EquipmentRarity = "8", CountId = "914", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "832"};
        public static readonly Item SummonCoinSelectExchangeSummon = new Item { Name = "Summon Coin (Select Exchange Summon)", ItemId = "1209001064", Description = "Summon Coin (Select Exchange Summon)", EquipmentRarity = "8", CountId = "9349", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001064", BitNumber = "9349"};
        public static readonly Item EnergizingShot = new Item { Name = "Energizing Shot", ItemId = "1209001054", Description = "Energizing Shot", EquipmentRarity = "3", CountId = "9337", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "1209001055", BitNumber = "9337"};
        public static readonly Item RestorativeShot = new Item { Name = "Restorative Shot", ItemId = "1209001055", Description = "Restorative Shot", EquipmentRarity = "5", CountId = "9338", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "1209001054", BitNumber = "9338"};
        public static readonly Item CPRKit = new Item { Name = "CPR Kit", ItemId = "1209001056", Description = "CPR Kit", EquipmentRarity = "6", CountId = "9336", IsPotUnit = "1", KeyName = "2", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "1209001056", BitNumber = "9336"};
        public static readonly Item BlightStone = new Item { Name = "Blight Stone", ItemId = "1209001057", Description = "Blight Stone", EquipmentRarity = "7", CountId = "9339", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209001057", BitNumber = "9339"};
        public static readonly Item UnderworldFare = new Item { Name = "Underworld Fare", ItemId = "1209001058", Description = "Underworld Fare", EquipmentRarity = "7", CountId = "9340", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209001058", BitNumber = "9340"};
        public static readonly Item GuaranteedFeaturedTicketKG = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [K/G]", ItemId = "1209001053", Description = "5★ Guaranteed (20% Featured) Ticket [K/G]", EquipmentRarity = "8", CountId = "9335", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001053", BitNumber = "9335"};
        public static readonly Item SummonCoinKartenGodrea = new Item { Name = "Summon Coin (Karten/Godrea)", ItemId = "1209001059", Description = "Summon Coin (Karten/Godrea)", EquipmentRarity = "8", CountId = "9343", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001059", BitNumber = "9343"};
        public static readonly Item SummonCoinSpooktacular = new Item { Name = "Summon Coin (Spooktacular)", ItemId = "1209001060", Description = "Summon Coin (Spooktacular)", EquipmentRarity = "8", CountId = "9344", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001060", BitNumber = "9344"};
        public static readonly Item SpooktacularSlotsToken = new Item { Name = "Spooktacular Slots Token", ItemId = "1209001061", Description = "Spooktacular Slots Medal", EquipmentRarity = "8", CountId = "9345", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001061", BitNumber = "9345"};
        public static readonly Item KartensPrism = new Item { Name = "Karten's Prism", ItemId = "310000440", Description = "Karten's Prism", EquipmentRarity = "8", CountId = "9341", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9341"};
        public static readonly Item GodreasPrism = new Item { Name = "Godrea's Prism", ItemId = "310000450", Description = "Godrea's Prism", EquipmentRarity = "8", CountId = "9342", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9342"};
        public static readonly Item SummonCoinAKefkaAShadow = new Item { Name = "Summon Coin (A.Kefka/A.Shadow)", ItemId = "1209001062", Description = "Summon Coin (A.Kefka/A.Shadow)", EquipmentRarity = "8", CountId = "9347", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001062", BitNumber = "9347"};
        public static readonly Item GuaranteedFeaturedTicketAKefkaAShadow = new Item { Name = "5★ Guaranteed (30% Featured) Ticket [A.Kefka/A.Shadow]", ItemId = "1209001063", Description = "5★ Guaranteed (30% Featured) Ticket [A.Kefka/A.Shadow]", EquipmentRarity = "8", CountId = "9348", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001063", BitNumber = "9348"};
        public static readonly Item NamelessKatanasHilt = new Item { Name = "Nameless Katana's Hilt", ItemId = "235005100", Description = "名もなき刀の柄", EquipmentRarity = "5", CountId = "945", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235005100", BitNumber = "863"};
        public static readonly Item JesterWoodblockPrint = new Item { Name = "Jester Woodblock Print", ItemId = "235005200", Description = "道化師の木版", EquipmentRarity = "4", CountId = "946", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235005200", BitNumber = "864"};
        public static readonly Item CityCamouflage = new Item { Name = "City Camouflage", ItemId = "235005300", Description = "都市迷彩布", EquipmentRarity = "4", CountId = "947", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235005300", BitNumber = "865"};
        public static readonly Item LumpofDarksteel = new Item { Name = "Lump of Darksteel", ItemId = "235005400", Description = "黒鋼塊", EquipmentRarity = "3", CountId = "948", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235005400", BitNumber = "866"};
        public static readonly Item TwinCrystals = new Item { Name = "Twin Crystals", ItemId = "235005500", Description = "黄魔双晶", EquipmentRarity = "3", CountId = "949", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235005500", BitNumber = "867"};
        public static readonly Item AssassinShadowsPrism = new Item { Name = "Assassin Shadow's Prism", ItemId = "300001480", Description = "アサシン シャドウの輝源", EquipmentRarity = "8", CountId = "942", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "860"};
        public static readonly Item ArchmageKefkasPrism = new Item { Name = "Archmage Kefka's Prism", ItemId = "300001490", Description = "大魔導士ケフカの輝源", EquipmentRarity = "8", CountId = "943", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "861"};
        public static readonly Item AirForceRaidCoin = new Item { Name = "Air Force Raid Coin", ItemId = "106307300", Description = "エアフォースレイドコイン", EquipmentRarity = "3", CountId = "944", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106307300", BitNumber = "862"};
        public static readonly Item GiveawayParticipationTicket = new Item { Name = "Giveaway Participation Ticket", ItemId = "1209001070", Description = "Normal Lottery Ticket", EquipmentRarity = "8", CountId = "9355", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001070", BitNumber = "9355"};
        public static readonly Item GiveawayBonusTicket = new Item { Name = "Giveaway Bonus Ticket", ItemId = "1209001071", Description = "Special (+20%) Lottery Ticket", EquipmentRarity = "8", CountId = "9356", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001071", BitNumber = "9356"};
        public static readonly Item CrimsonHandWovenCloth = new Item { Name = "Crimson Hand-Woven Cloth", ItemId = "235007000", Description = "深紅の手織布", EquipmentRarity = "5", CountId = "978", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235007000", BitNumber = "895"};
        public static readonly Item ShiningMagicalThread = new Item { Name = "Shining Magical Thread", ItemId = "235007100", Description = "輝く魔糸", EquipmentRarity = "4", CountId = "979", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235007100", BitNumber = "896"};
        public static readonly Item BrilliantScarletFeather = new Item { Name = "Brilliant Scarlet Feather", ItemId = "235007200", Description = "緋色の羽根", EquipmentRarity = "4", CountId = "980", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235007200", BitNumber = "897"};
        public static readonly Item CrackedJewel = new Item { Name = "Cracked Jewel", ItemId = "235007300", Description = "割れた宝珠", EquipmentRarity = "4", CountId = "981", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235007300", BitNumber = "898"};
        public static readonly Item SkyBlueStone = new Item { Name = "Sky Blue Stone", ItemId = "235007400", Description = "蒼空の石", EquipmentRarity = "4", CountId = "982", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235007400", BitNumber = "899"};
        public static readonly Item AldoreKingRainsPrism = new Item { Name = "Aldore King Rain's Prism", ItemId = "300001580", Description = "アルドール王レインの輝源", EquipmentRarity = "8", CountId = "977", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "894"};
        public static readonly Item GuaranteedCompensationTicket = new Item { Name = "5★ Guaranteed Compensation Ticket", ItemId = "1209001077", Description = "5★ Guaranteed Compensation Ticket", EquipmentRarity = "8", CountId = "9365", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001077", BitNumber = "9365"};
        public static readonly Item MagitekWarriorTerrasPrism = new Item { Name = "Magitek Warrior Terra's Prism", ItemId = "300001460", Description = "魔導戦士ティナの輝源", EquipmentRarity = "8", CountId = "937", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "855"};
        public static readonly Item AdventurerLockesPrism = new Item { Name = "Adventurer Locke's Prism", ItemId = "300001470", Description = "冒険者ロックの輝源", EquipmentRarity = "8", CountId = "938", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "856"};
        public static readonly Item NarsheCoal = new Item { Name = "Narshe Coal", ItemId = "106307200", Description = "ナルシェ石炭", EquipmentRarity = "3", CountId = "935", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106307200", BitNumber = "853"};
        public static readonly Item SummonCoinMWTerraALocke = new Item { Name = "Summon Coin (M.W. Terra/A. Locke)", ItemId = "1209001065", Description = "Summon Coin (M.W. Terra/A. Locke)", EquipmentRarity = "8", CountId = "9350", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001065", BitNumber = "9350"};
        public static readonly Item GuaranteedFeaturedTicketMWTerraALocke = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [M.W.Terra/A.Locke]", ItemId = "1209001067", Description = "5★ Guaranteed (20% Featured) Ticket [M.W.Terra/A.Locke]", EquipmentRarity = "8", CountId = "9352", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001067", BitNumber = "9352"};
        public static readonly Item CrimsonSaberKey = new Item { Name = "Crimson Saber Key", ItemId = "1209001072", Description = "Fujimoto boss Raid Coin A", EquipmentRarity = "8", CountId = "9357", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001072", BitNumber = "9357"};
        public static readonly Item PurpleLightningKey = new Item { Name = "Purple Lightning Key", ItemId = "1209001073", Description = "Fujimoto boss Raid Coin B", EquipmentRarity = "8", CountId = "9358", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001073", BitNumber = "9358"};
        public static readonly Item ReincarnationKey = new Item { Name = "Reincarnation Key", ItemId = "1209001074", Description = "Fujimoto boss Raid Coin C", EquipmentRarity = "8", CountId = "9359", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001074", BitNumber = "9359"};
        public static readonly Item ComebackSummonTicket_1209001075 = new Item { Name = "Comeback 10+1 Summon Ticket", ItemId = "1209001075", Description = "Comeback 10+1 Summon Ticket", EquipmentRarity = "8", CountId = "9363", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001009", BitNumber = "9363"};
        public static readonly Item GuaranteedSpecialSummonTicket_106211360 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "106211360", Description = "[期間限定]★5確定SP召喚チケット", EquipmentRarity = "8", CountId = "934", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106211170", BitNumber = "852"};
        public static readonly Item DrasilianSovereign = new Item { Name = "Drasilian Sovereign", ItemId = "106309500", Description = "ユグノア金貨", EquipmentRarity = "3", CountId = "1251", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106309500", BitNumber = "1170"};
        public static readonly Item BlueEye = new Item { Name = "Blue Eye", ItemId = "235019300", Description = "ブルーアイ", EquipmentRarity = "6", CountId = "1252", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "235019300", BitNumber = "1171"};
        public static readonly Item PlatinumOre = new Item { Name = "Platinum Ore", ItemId = "235019400", Description = "プラチナこうせき", EquipmentRarity = "5", CountId = "1253", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235019400", BitNumber = "1172"};
        public static readonly Item Fatalistick = new Item { Name = "Fatalistick", ItemId = "235019500", Description = "あんこくの樹木", EquipmentRarity = "5", CountId = "1254", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235019500", BitNumber = "1173"};
        public static readonly Item Mirrorstone = new Item { Name = "Mirrorstone", ItemId = "235019600", Description = "かがみ石", EquipmentRarity = "4", CountId = "1255", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235019600", BitNumber = "1174"};
        public static readonly Item GlassFrit = new Item { Name = "Glass Frit", ItemId = "235019700", Description = "みがきずな", EquipmentRarity = "3", CountId = "1256", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235019700", BitNumber = "1175"};
        public static readonly Item SylvandosPrism = new Item { Name = "Sylvando's Prism", ItemId = "300002290", Description = "シルビアの輝源", EquipmentRarity = "8", CountId = "1260", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1179"};
        public static readonly Item RabsPrism = new Item { Name = "Rab's Prism", ItemId = "300002300", Description = "ロウの輝源", EquipmentRarity = "8", CountId = "1261", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1180"};
        public static readonly Item JasperUnboundsPrism = new Item { Name = "Jasper Unbound's Prism", ItemId = "300002060", Description = "魔軍司令ホメロスの輝源", EquipmentRarity = "8", CountId = "1174", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1089"};
        public static readonly Item EriksPrism = new Item { Name = "Erik's Prism", ItemId = "300002100", Description = "カミュの輝源", EquipmentRarity = "8", CountId = "1178", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1093"};
        public static readonly Item TheLordofShadowsPrism = new Item { Name = "The Lord of Shadows' Prism", ItemId = "300002270", Description = "魔王ウルノーガの輝源", EquipmentRarity = "8", CountId = "1258", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1177"};
        public static readonly Item JadesPrism = new Item { Name = "Jade's Prism", ItemId = "300002280", Description = "マルティナの輝源", EquipmentRarity = "8", CountId = "1259", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1178"};
        public static readonly Item DQXISSpecialUnitSummoningKeyGold_1209001068 = new Item { Name = "DQXI S Special Unit Summoning Key #2 (Gold)", ItemId = "1209001068", Description = "DQ XI S Special Unit Summoning Key #2 (Gold)", EquipmentRarity = "8", CountId = "9353", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001068", BitNumber = "9353"};
        public static readonly Item DQXISSpecialUnitSummoningKeySilver_1209001069 = new Item { Name = "DQXI S Special Unit Summoning Key #2 (Silver)", ItemId = "1209001069", Description = "DQ XI S Special Unit Summoning Key #2 (Silver)", EquipmentRarity = "8", CountId = "9354", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001069", BitNumber = "9354"};
        public static readonly Item TreasureCoin = new Item { Name = "Treasure Coin", ItemId = "1209001066", Description = "Treasure coin", EquipmentRarity = "3", CountId = "9351", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001066", BitNumber = "9351"};
        public static readonly Item AgentOlivesPrism = new Item { Name = "Agent Olive's Prism", ItemId = "310000460", Description = "Agent Olive's Prism", EquipmentRarity = "8", CountId = "9346", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9346"};
        public static readonly Item MastermindXonsPrism = new Item { Name = "Mastermind Xon's Prism", ItemId = "310000470", Description = "Mastermind Xon's Prism", EquipmentRarity = "8", CountId = "9360", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9360"};
        public static readonly Item DoctorAidensPrism = new Item { Name = "Doctor Aiden's Prism", ItemId = "310000480", Description = "Doctor Aiden Prism", EquipmentRarity = "8", CountId = "9361", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9361"};
        public static readonly Item OperativeZyrussPrism = new Item { Name = "Operative Zyrus's Prism", ItemId = "310000490", Description = "Operative Zyrus Prism", EquipmentRarity = "8", CountId = "9362", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9362"};
        public static readonly Item GuaranteedFlexibleTicketAOliveMXon = new Item { Name = "5★ Guaranteed Flexible Ticket [A.Olive/M.Xon]", ItemId = "1209001076", Description = "5★ Guaranteed Flexible Ticket [A.Olive/M.Xon]", EquipmentRarity = "8", CountId = "9364", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001076", BitNumber = "9364"};
        public static readonly Item GuaranteedFlexibleTicketOZyrusDAiden = new Item { Name = "5★ Guaranteed Flexible Ticket [O.Zyrus/D.Aiden]", ItemId = "1209001078", Description = "5★ Guaranteed Flexible Ticket [O.Zyrus/D.Aiden]", EquipmentRarity = "8", CountId = "9366", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001078", BitNumber = "9366"};
        public static readonly Item AldoreWootzOre = new Item { Name = "Aldore Wootz Ore", ItemId = "235003010", Description = "アルドールウーツ鉱", EquipmentRarity = "5", CountId = "918", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235003010", BitNumber = "836"};
        public static readonly Item GunganLacquerTree = new Item { Name = "Gungan Lacquer Tree", ItemId = "235003020", Description = "グンガン漆", EquipmentRarity = "4", CountId = "919", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235003020", BitNumber = "837"};
        public static readonly Item DeluxeGunpowder = new Item { Name = "Deluxe Gunpowder", ItemId = "235003030", Description = "特製ガンパウダー", EquipmentRarity = "4", CountId = "920", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235003030", BitNumber = "838"};
        public static readonly Item FluorineRubber = new Item { Name = "Fluorine Rubber", ItemId = "235003040", Description = "フッ素ゴム", EquipmentRarity = "4", CountId = "921", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235003040", BitNumber = "839"};
        public static readonly Item TeakLog = new Item { Name = "Teak Log", ItemId = "235003050", Description = "チーク原木", EquipmentRarity = "4", CountId = "922", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235003050", BitNumber = "840"};
        public static readonly Item PhysalissPrism = new Item { Name = "Physalis's Prism", ItemId = "300001410", Description = "ファイサリスの輝源", EquipmentRarity = "8", CountId = "923", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "841"};
        public static readonly Item FestiveSlotsToken = new Item { Name = "Festive Slots Token", ItemId = "1209001079", Description = "Joyous Slots Token", EquipmentRarity = "8", CountId = "9367", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001079", BitNumber = "9367"};
        public static readonly Item HollyJollyTicket = new Item { Name = "Holly Jolly Ticket", ItemId = "1209001082", Description = "Joyous Summon Ticket", EquipmentRarity = "8", CountId = "9370", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001082", BitNumber = "9370"};
        public static readonly Item GuaranteedFlexibleTicketCPNoctisLunafreya = new Item { Name = "5★ Guaranteed Flexible Ticket [C.P.Noctis/Lunafreya]", ItemId = "1209001083", Description = "5★ Guaranteed Flexible Ticket [C.P.Noctis/Lunafreya]", EquipmentRarity = "8", CountId = "9371", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001083", BitNumber = "9371"};
        public static readonly Item PremiumSummonTicketHollyJolly = new Item { Name = "Premium 10+1 Summon Ticket [Holly Jolly]", ItemId = "1209001084", Description = "Premium 10+1 Summon Ticket [Holly Jolly]", EquipmentRarity = "8", CountId = "9372", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "908", BitNumber = "9372"};
        public static readonly Item UnitCoinAiden = new Item { Name = "Unit Coin (Aiden)", ItemId = "1209001085", Description = "Unit Coin (Aiden)", EquipmentRarity = "8", CountId = "9373", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001085", BitNumber = "9373"};
        public static readonly Item UnitCoinAng = new Item { Name = "Unit Coin (Ang)", ItemId = "1209001086", Description = "Unit Coin (Ang)", EquipmentRarity = "8", CountId = "9374", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001086", BitNumber = "9374"};
        public static readonly Item UnitCoinBaiHuZhuQue = new Item { Name = "Unit Coin (Bai Hu & Zhu Que)", ItemId = "1209001087", Description = "Unit Coin (Bai Hu & Zhu Que)", EquipmentRarity = "8", CountId = "9375", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001087", BitNumber = "9375"};
        public static readonly Item UnitCoinChow = new Item { Name = "Unit Coin (Chow)", ItemId = "1209001088", Description = "Unit Coin (Chow)", EquipmentRarity = "8", CountId = "9376", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001088", BitNumber = "9376"};
        public static readonly Item UnitCoinChristine = new Item { Name = "Unit Coin (Christine)", ItemId = "1209001089", Description = "Unit Coin (Christine)", EquipmentRarity = "8", CountId = "9377", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001089", BitNumber = "9377"};
        public static readonly Item UnitCoinElena = new Item { Name = "Unit Coin (Elena)", ItemId = "1209001090", Description = "Unit Coin (Elena)", EquipmentRarity = "8", CountId = "9378", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001090", BitNumber = "9378"};
        public static readonly Item UnitCoinEsther = new Item { Name = "Unit Coin (Esther)", ItemId = "1209001091", Description = "Unit Coin (Esther)", EquipmentRarity = "8", CountId = "9379", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001091", BitNumber = "9379"};
        public static readonly Item UnitCoinFelix = new Item { Name = "Unit Coin (Felix)", ItemId = "1209001092", Description = "Unit Coin (Felix)", EquipmentRarity = "8", CountId = "9380", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001092", BitNumber = "9380"};
        public static readonly Item UnitCoinFryevia = new Item { Name = "Unit Coin (Fryevia)", ItemId = "1209001093", Description = "Unit Coin (Fryevia)", EquipmentRarity = "8", CountId = "9381", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001093", BitNumber = "9381"};
        public static readonly Item UnitCoinGodrea = new Item { Name = "Unit Coin (Godrea)", ItemId = "1209001094", Description = "Unit Coin (Godrea)", EquipmentRarity = "8", CountId = "9382", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001094", BitNumber = "9382"};
        public static readonly Item UnitCoinKaito = new Item { Name = "Unit Coin (Kaito)", ItemId = "1209001095", Description = "Unit Coin (Kaito)", EquipmentRarity = "8", CountId = "9383", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001095", BitNumber = "9383"};
        public static readonly Item UnitCoinKarten = new Item { Name = "Unit Coin (Karten)", ItemId = "1209001096", Description = "Unit Coin (Karten)", EquipmentRarity = "8", CountId = "9384", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001096", BitNumber = "9384"};
        public static readonly Item UnitCoinKryla = new Item { Name = "Unit Coin (Kryla)", ItemId = "1209001097", Description = "Unit Coin (Kryla)", EquipmentRarity = "8", CountId = "9385", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001097", BitNumber = "9385"};
        public static readonly Item UnitCoinLilith = new Item { Name = "Unit Coin (Lilith)", ItemId = "1209001098", Description = "Unit Coin (Lilith)", EquipmentRarity = "8", CountId = "9386", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001098", BitNumber = "9386"};
        public static readonly Item UnitCoinLing = new Item { Name = "Unit Coin (Ling)", ItemId = "1209001099", Description = "Unit Coin (Ling)", EquipmentRarity = "8", CountId = "9387", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001099", BitNumber = "9387"};
        public static readonly Item UnitCoinLucius = new Item { Name = "Unit Coin (Lucius)", ItemId = "1209001100", Description = "Unit Coin (Lucius)", EquipmentRarity = "8", CountId = "9388", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001100", BitNumber = "9388"};
        public static readonly Item UnitCoinMorgana = new Item { Name = "Unit Coin (Morgana)", ItemId = "1209001101", Description = "Unit Coin (Morgana)", EquipmentRarity = "8", CountId = "9389", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001101", BitNumber = "9389"};
        public static readonly Item UnitCoinOlive = new Item { Name = "Unit Coin (Olive)", ItemId = "1209001102", Description = "Unit Coin (Olive)", EquipmentRarity = "8", CountId = "9390", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001102", BitNumber = "9390"};
        public static readonly Item UnitCoinQin = new Item { Name = "Unit Coin (Qin)", ItemId = "1209001103", Description = "Unit Coin (Qin)", EquipmentRarity = "8", CountId = "9391", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001103", BitNumber = "9391"};
        public static readonly Item UnitCoinReberta = new Item { Name = "Unit Coin (Reberta)", ItemId = "1209001104", Description = "Unit Coin (Reberta)", EquipmentRarity = "8", CountId = "9392", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001104", BitNumber = "9392"};
        public static readonly Item UnitCoinRivera = new Item { Name = "Unit Coin (Rivera)", ItemId = "1209001105", Description = "Unit Coin (Rivera)", EquipmentRarity = "8", CountId = "9393", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001105", BitNumber = "9393"};
        public static readonly Item UnitCoinSylvie = new Item { Name = "Unit Coin (Sylvie)", ItemId = "1209001106", Description = "Unit Coin (Sylvie)", EquipmentRarity = "8", CountId = "9394", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001106", BitNumber = "9394"};
        public static readonly Item UnitCoinTiana = new Item { Name = "Unit Coin (Tiana)", ItemId = "1209001107", Description = "Unit Coin (Tiana)", EquipmentRarity = "8", CountId = "9395", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001107", BitNumber = "9395"};
        public static readonly Item UnitCoinTsukiko = new Item { Name = "Unit Coin (Tsukiko)", ItemId = "1209001108", Description = "Unit Coin (Tsukiko)", EquipmentRarity = "8", CountId = "9396", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001108", BitNumber = "9396"};
        public static readonly Item UnitCoinWhiteKnightNoel = new Item { Name = "Unit Coin (White Knight Noel)", ItemId = "1209001109", Description = "Unit Coin (White Knight Noel)", EquipmentRarity = "8", CountId = "9397", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001109", BitNumber = "9397"};
        public static readonly Item UnitCoinXon = new Item { Name = "Unit Coin (Xon)", ItemId = "1209001110", Description = "Unit Coin (Xon)", EquipmentRarity = "8", CountId = "9398", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001110", BitNumber = "9398"};
        public static readonly Item UnitCoinYan = new Item { Name = "Unit Coin (Yan)", ItemId = "1209001111", Description = "Unit Coin (Yan)", EquipmentRarity = "8", CountId = "9399", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001111", BitNumber = "9399"};
        public static readonly Item UnitCoinYun = new Item { Name = "Unit Coin (Yun)", ItemId = "1209001112", Description = "Unit Coin (Yun)", EquipmentRarity = "8", CountId = "9400", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001112", BitNumber = "9400"};
        public static readonly Item UnitCoinZyrus = new Item { Name = "Unit Coin (Zyrus)", ItemId = "1209001113", Description = "Unit Coin (Zyrus)", EquipmentRarity = "8", CountId = "9401", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001113", BitNumber = "9401"};
        public static readonly Item PopularityContestVotingTicket = new Item { Name = "Popularity Contest Voting Ticket", ItemId = "1209001114", Description = "Popularity Contest Voting Ticket", EquipmentRarity = "8", CountId = "9402", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001114", BitNumber = "9402"};
        public static readonly Item CrownPrinceNoctissPrism = new Item { Name = "Crown Prince Noctis's Prism", ItemId = "300001680", Description = "ノクティス王子の輝源", EquipmentRarity = "8", CountId = "1017", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "935"};
        public static readonly Item GentianasPrism = new Item { Name = "Gentiana's Prism", ItemId = "300001690", Description = "ゲンティアナの輝源", EquipmentRarity = "8", CountId = "1018", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "936"};
        public static readonly Item LunafreyasPrism = new Item { Name = "Lunafreya's Prism", ItemId = "300001700", Description = "ルナフレーナの輝源", EquipmentRarity = "8", CountId = "1019", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "937"};
        public static readonly Item ArapaimaRoe = new Item { Name = "Arapaima Roe", ItemId = "106307900", Description = "セルナキャビア", EquipmentRarity = "3", CountId = "1020", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106307900", BitNumber = "938"};
        public static readonly Item GuaranteedSpecialSummonTicket_106211520 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "106211520", Description = "[期間限定]★5確定SP召喚チケット", EquipmentRarity = "8", CountId = "1021", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106211170", BitNumber = "939"};
        public static readonly Item BoxofRegalement = new Item { Name = "Box of Regalement", ItemId = "1209001024", Description = "Box of Regalement", EquipmentRarity = "6", CountId = "9414", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "1209001024", BitNumber = "9300"};
        public static readonly Item Snowball = new Item { Name = "Snowball", ItemId = "1209001025", Description = "Snowball", EquipmentRarity = "3", CountId = "9415", IsPotUnit = "4", KeyName = "1", ItemStack = "99", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "1209001025", BitNumber = "9301"};
        public static readonly Item PlasticJewel = new Item { Name = "Plastic Jewel", ItemId = "1209001118", Description = "Plastic Jewel", EquipmentRarity = "7", CountId = "9406", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209001118", BitNumber = "9416"};
        public static readonly Item WoodenBlocks = new Item { Name = "Wooden Blocks", ItemId = "1209001119", Description = "Wooden Blocks", EquipmentRarity = "7", CountId = "9407", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209001119", BitNumber = "9416"};
        public static readonly Item LevinsonsPrism = new Item { Name = "Levinson's Prism", ItemId = "310000510", Description = "Levinson's Prism", EquipmentRarity = "8", CountId = "9413", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9413"};
        public static readonly Item LucassPrism = new Item { Name = "Lucas's Prism", ItemId = "310000500", Description = "Lucas Prism", EquipmentRarity = "8", CountId = "9412", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9412"};
        public static readonly Item GuaranteedFlexibleTicketLevinsonLucas = new Item { Name = "5★ Guaranteed Flexible Ticket [Levinson/Lucas]", ItemId = "1209001121", Description = "5★ Guaranteed Flexible Ticket [Levinson/Lucas]", EquipmentRarity = "8", CountId = "9409", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001121", BitNumber = "9409"};
        public static readonly Item HolyNightAmeliaEmiliasPrism = new Item { Name = "Holy Night Amelia & Emilia's Prism", ItemId = "300001440", Description = "聖夜のアメリア＆エミリアの輝源", EquipmentRarity = "8", CountId = "932", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "850"};
        public static readonly Item WhiteLilyDarkFinasPrism = new Item { Name = "White Lily Dark Fina's Prism", ItemId = "300001520", Description = "白百合の魔人フィーナの輝源", EquipmentRarity = "8", CountId = "958", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "875"};
        public static readonly Item CrimsonLotusTear = new Item { Name = "Crimson Lotus Tear", ItemId = "235006000", Description = "紅蓮の涙", EquipmentRarity = "5", CountId = "961", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235006000", BitNumber = "878"};
        public static readonly Item PricelessStone = new Item { Name = "Priceless Stone", ItemId = "235006100", Description = "千金石", EquipmentRarity = "4", CountId = "962", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235006100", BitNumber = "879"};
        public static readonly Item GoldPowder = new Item { Name = "Gold Powder", ItemId = "235006200", Description = "ゴールドパウダー", EquipmentRarity = "4", CountId = "963", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235006200", BitNumber = "880"};
        public static readonly Item PurpleEmulsion = new Item { Name = "Purple Emulsion", ItemId = "235006300", Description = "紫分子体", EquipmentRarity = "4", CountId = "964", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235006300", BitNumber = "881"};
        public static readonly Item TwistedBlackHorn = new Item { Name = "Twisted Black Horn", ItemId = "235006400", Description = "黒の螺旋角", EquipmentRarity = "4", CountId = "965", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235006400", BitNumber = "882"};
        public static readonly Item FreeDailySummonwithbonusTrustMoogleUnitspecificunlocked = new Item { Name = "Free Daily 4★+ Summon with bonus 3★ Trust Moogle (Unit-specific 5%) unlocked!", ItemId = "1209001130", Description = "Free Daily 4★+ Summon with bonus 3★ Trust Moogle (Unit-specific ", EquipmentRarity = "1", CountId = "9420", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209001132", BitNumber = "9416"};
        public static readonly Item SpecialVaultofHiddenTreasuresunlocked = new Item { Name = "Special 'Vault of Hidden Treasures' unlocked!", ItemId = "1209001131", Description = "Special 'Vault of Hidden Treasures' unlocked!", EquipmentRarity = "1", CountId = "9421", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209001133", BitNumber = "9416"};
        public static readonly Item FreeLapisSummonunlocked = new Item { Name = "Free Lapis Summon unlocked!", ItemId = "1209001132", Description = "Free Lapis Summon unlocked!", EquipmentRarity = "1", CountId = "9422", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209001134", BitNumber = "9416"};
        public static readonly Item FreeDailySummonunlocked = new Item { Name = "Free Daily 10 Summon unlocked!", ItemId = "1209001133", Description = "Free Daily 10 Summon unlocked!", EquipmentRarity = "1", CountId = "9423", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209001135", BitNumber = "9416"};
        public static readonly Item ImmortalKnightGarlandsPrism = new Item { Name = "Immortal Knight Garland's Prism", ItemId = "300001560", Description = "輪廻の騎士ガーランドの輝源", EquipmentRarity = "8", CountId = "974", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "891"};
        public static readonly Item AwakenedWarriorofLightsPrism = new Item { Name = "Awakened Warrior of Light's Prism", ItemId = "300001550", Description = "ウォーリア オブ ライトの輝源", EquipmentRarity = "8", CountId = "973", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "890"};
        public static readonly Item WarpCube = new Item { Name = "Warp Cube", ItemId = "106307500", Description = "ワープキューブ", EquipmentRarity = "3", CountId = "972", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106307500", BitNumber = "889"};
        public static readonly Item GuaranteedSpecialSummonTicket_106211450 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "106211450", Description = "[期間限定]★5確定SP召喚チケット", EquipmentRarity = "8", CountId = "971", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106211170", BitNumber = "888"};
        public static readonly Item GuaranteedFeaturedTicketArdynRegis = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [Ardyn/Regis]", ItemId = "1209001124", Description = "5★ Guaranteed (20% Featured) Ticket [Ardyn/Regis]", EquipmentRarity = "8", CountId = "9414", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001121", BitNumber = "9414"};
        public static readonly Item SummonCoinArdynRegis = new Item { Name = "Summon Coin (Ardyn/Regis)", ItemId = "1209001125", Description = "Summon Coin (Ardyn/Regis)", EquipmentRarity = "8", CountId = "9415", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001065", BitNumber = "9415"};
        public static readonly Item BehemothKingRaidCoin = new Item { Name = "Behemoth King Raid Coin", ItemId = "106308000", Description = "キングベヒーモスレイドコイン", EquipmentRarity = "3", CountId = "1044", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106308000", BitNumber = "962"};
        public static readonly Item TrueBeastFur = new Item { Name = "True Beast Fur", ItemId = "235012100", Description = "真・ビーストファー", EquipmentRarity = "6", CountId = "1038", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "235012100", BitNumber = "956"};
        public static readonly Item BeastFur = new Item { Name = "Beast Fur", ItemId = "235012200", Description = "ビーストファー", EquipmentRarity = "5", CountId = "1039", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235012200", BitNumber = "957"};
        public static readonly Item SyntheticFiberCloth = new Item { Name = "Synthetic Fiber Cloth", ItemId = "235012300", Description = "人造ファイバー布", EquipmentRarity = "4", CountId = "1040", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235012300", BitNumber = "958"};
        public static readonly Item DarkbladeHilt = new Item { Name = "Darkblade Hilt", ItemId = "235012400", Description = "黒剣の柄", EquipmentRarity = "4", CountId = "1041", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235012400", BitNumber = "959"};
        public static readonly Item ShadowTar = new Item { Name = "Shadow Tar", ItemId = "235012500", Description = "シャドウタール", EquipmentRarity = "3", CountId = "1042", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235012500", BitNumber = "960"};
        public static readonly Item RedBeryl = new Item { Name = "Red Beryl", ItemId = "235012600", Description = "レッドベリル", EquipmentRarity = "3", CountId = "1043", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235012600", BitNumber = "961"};
        public static readonly Item ArdynsPrism = new Item { Name = "Ardyn's Prism", ItemId = "300001750", Description = "アーデンの輝源", EquipmentRarity = "8", CountId = "1036", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "954"};
        public static readonly Item RegissPrism = new Item { Name = "Regis's Prism", ItemId = "300001760", Description = "レギスの輝源", EquipmentRarity = "8", CountId = "1037", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "955"};
        public static readonly Item HessKingLasswellsPrism = new Item { Name = "Hess King Lasswell's Prism", ItemId = "300001640", Description = "ヘス王ラスウェルの輝源", EquipmentRarity = "8", CountId = "1000", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "918"};
        public static readonly Item PurityFragment = new Item { Name = "Purity Fragment", ItemId = "1209001122", Description = "Purity Fragment", EquipmentRarity = "8", CountId = "9410", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209001122", BitNumber = "9410"};
        public static readonly Item DropofCourage = new Item { Name = "Drop of Courage", ItemId = "1209001123", Description = "Oathdrop", EquipmentRarity = "8", CountId = "9411", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209001123", BitNumber = "9411"};
        public static readonly Item EngravedBlade = new Item { Name = "Engraved Blade", ItemId = "235009000", Description = "銘入りの刀身", EquipmentRarity = "5", CountId = "1002", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235009000", BitNumber = "920"};
        public static readonly Item SmallMagicalOre = new Item { Name = "Small Magical Ore", ItemId = "235009100", Description = "小魔鉄鉱", EquipmentRarity = "4", CountId = "1003", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235009100", BitNumber = "921"};
        public static readonly Item HighGradePowder = new Item { Name = "High-Grade Powder", ItemId = "235009200", Description = "特製打ち粉", EquipmentRarity = "4", CountId = "1004", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235009200", BitNumber = "922"};
        public static readonly Item MetallicGel = new Item { Name = "Metallic Gel", ItemId = "235009300", Description = "ジェルメタル", EquipmentRarity = "4", CountId = "1005", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235009300", BitNumber = "923"};
        public static readonly Item SilkTwine = new Item { Name = "Silk Twine", ItemId = "235009400", Description = "妖絹の紐", EquipmentRarity = "4", CountId = "1006", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235009400", BitNumber = "924"};
        public static readonly Item FortuneCookie = new Item { Name = "Fortune Cookie", ItemId = "1209001116", Description = "Fortune Cookie", EquipmentRarity = "7", CountId = "9404", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209001116", BitNumber = "9404"};
        public static readonly Item GoldenCoin = new Item { Name = "Golden Coin", ItemId = "1209001117", Description = "Golden Coin", EquipmentRarity = "7", CountId = "9405", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209001117", BitNumber = "9405"};
        public static readonly Item XuanWuQingLongsPrism = new Item { Name = "Xuan Wu & Qing Long's Prism", ItemId = "310000530", Description = "Xuan Wu & Qing Long Prism", EquipmentRarity = "8", CountId = "9424", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9424"};
        public static readonly Item EmperorFoosPrism = new Item { Name = "Emperor Foo's Prism", ItemId = "310000520", Description = "Emperor Foo's Prism", EquipmentRarity = "8", CountId = "9418", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9418"};
        public static readonly Item LuckySlotsToken = new Item { Name = "Lucky Slots Token", ItemId = "1209001120", Description = "Auspicious Slots Token", EquipmentRarity = "8", CountId = "9408", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001120", BitNumber = "9408"};
        public static readonly Item GuaranteedFeaturedTicketXWQLEFoo = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [X.W&Q.L/E.Foo]", ItemId = "1209001135", Description = "5★ Guaranteed (20% Featured) Ticket [X.W&Q.L/E.Foo]", EquipmentRarity = "8", CountId = "9425", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001121", BitNumber = "9425"};
        public static readonly Item SummonCoinXWQLEFoo = new Item { Name = "Summon Coin  (X.W&Q.L/E.Foo)", ItemId = "1209001136", Description = "Summon Coin (X.W&Q.L/E.Foo)", EquipmentRarity = "8", CountId = "9426", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001065", BitNumber = "9426"};
        public static readonly Item LuckyYearoftheRatTicket = new Item { Name = "Lucky Year of the Rat Ticket", ItemId = "1209001147", Description = "Lucky Year of the Rat Ticket", EquipmentRarity = "8", CountId = "9439", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001147", BitNumber = "9439"};
        public static readonly Item PremiumSummonTicketLunarNewYear = new Item { Name = "Premium 10+1 Summon Ticket [Lunar New Year 2020]", ItemId = "1209001148", Description = "Premium 10+1 Summon Ticket", EquipmentRarity = "8", CountId = "9440", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "908", BitNumber = "9440"};
        public static readonly Item SuperTrustMoogleExchangeTicketx5Allplayers = new Item { Name = "Super Trust Moogle Exchange Ticket x5 (All players)", ItemId = "1209001150", Description = "STMR Exchange Ticket (All Players) x5", EquipmentRarity = "1", CountId = "9443", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "106211340", BitNumber = "9416"};
        public static readonly Item FreeDailySummonEXTENSIONweekunlocked = new Item { Name = "Free Daily 10 Summon EXTENSION (1 week) unlocked!", ItemId = "1209001151", Description = "Free Daily 10 Summon EXTENSION (1 week) unlocked!", EquipmentRarity = "1", CountId = "9444", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209001135", BitNumber = "9416"};
        public static readonly Item BlueTome = new Item { Name = "Blue Tome", ItemId = "292000100", Description = "青の魔道書", EquipmentRarity = "8", CountId = "1054", IsPotUnit = "5", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "292000100", BitNumber = "972"};
        public static readonly Item BlueHolyHorn = new Item { Name = "Blue Holy Horn", ItemId = "292000200", Description = "青の聖角", EquipmentRarity = "8", CountId = "1055", IsPotUnit = "5", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "292000200", BitNumber = "973"};
        public static readonly Item BluePictureScroll = new Item { Name = "Blue Picture Scroll", ItemId = "292000300", Description = "青の絵巻", EquipmentRarity = "8", CountId = "1056", IsPotUnit = "5", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "292000300", BitNumber = "974"};
        public static readonly Item BlueMoonlightFlower = new Item { Name = "Blue Moonlight Flower", ItemId = "292000400", Description = "青の月光花", EquipmentRarity = "8", CountId = "1057", IsPotUnit = "5", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "292000400", BitNumber = "975"};
        public static readonly Item BlueSpellstone = new Item { Name = "Blue Spellstone", ItemId = "292000500", Description = "青の魔法石", EquipmentRarity = "8", CountId = "1058", IsPotUnit = "5", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "292000500", BitNumber = "976"};
        public static readonly Item GuaranteedResummonCompensationTicketSupport = new Item { Name = "7★ Guaranteed (Re)summon [Compensation] Ticket - Support", ItemId = "1209001152", Description = "7★ Guaranteed (Re)summon [Compensation] Ticket - Support", EquipmentRarity = "8", CountId = "9445", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001152", BitNumber = "9445"};
        public static readonly Item GuaranteedResummonCompensationTicketAttacker = new Item { Name = "7★ Guaranteed (Re)summon [Compensation] Ticket - Attacker", ItemId = "1209001153", Description = "7★ Guaranteed (Re)summon [Compensation] Ticket - Attacker", EquipmentRarity = "8", CountId = "9446", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001153", BitNumber = "9446"};
        public static readonly Item GuaranteedResummonCompensationTicketMage = new Item { Name = "7★ Guaranteed (Re)summon [Compensation] Ticket - Mage", ItemId = "1209001154", Description = "7★ Guaranteed (Re)summon [Compensation] Ticket - Mage", EquipmentRarity = "8", CountId = "9447", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001154", BitNumber = "9447"};
        public static readonly Item ComebackSummonTicket_1209001134 = new Item { Name = "Comeback 10+1 Summon Ticket", ItemId = "1209001134", Description = "Comeback 10+1 Summon Ticket", EquipmentRarity = "8", CountId = "9363", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001009", BitNumber = "9363"};
        public static readonly Item GuaranteedSpecialSummonTicket_106211590 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "106211590", Description = "[期間限定]★5確定SP召喚チケット", EquipmentRarity = "8", CountId = "1051", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106211170", BitNumber = "969"};
        public static readonly Item SilverApple = new Item { Name = "Silver Apple", ItemId = "106308100", Description = "ぎんのリンゴ", EquipmentRarity = "3", CountId = "1053", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106308100", BitNumber = "971"};
        public static readonly Item RedCube = new Item { Name = "Red Cube", ItemId = "235013100", Description = "レッドキューブ", EquipmentRarity = "5", CountId = "1060", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235013100", BitNumber = "978"};
        public static readonly Item BlueCube = new Item { Name = "Blue Cube", ItemId = "235013200", Description = "ブルーキューブ", EquipmentRarity = "5", CountId = "1061", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235013200", BitNumber = "979"};
        public static readonly Item DarkObsidian = new Item { Name = "Dark Obsidian", ItemId = "235013300", Description = "魔黒曜石", EquipmentRarity = "4", CountId = "1062", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235013300", BitNumber = "980"};
        public static readonly Item WhiteMageRosasPrism = new Item { Name = "White Mage Rosa's Prism", ItemId = "300001790", Description = "白魔道士ローザの輝源", EquipmentRarity = "8", CountId = "1048", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "966"};
        public static readonly Item PalomPoromsPrism = new Item { Name = "Palom & Porom's Prism", ItemId = "300001780", Description = "パロム＆ポロムの輝源", EquipmentRarity = "8", CountId = "1047", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "965"};
        public static readonly Item PaladinCecilsPrism = new Item { Name = "Paladin Cecil's Prism", ItemId = "300001770", Description = "聖騎士セシルの輝源", EquipmentRarity = "8", CountId = "1046", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "964"};
        public static readonly Item GuaranteedFeaturedTicketPCecilPP = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [P.Cecil/P&P]", ItemId = "1209001138", Description = "5★ Guaranteed (20% Featured) Ticket [P.Cecil/P&P]", EquipmentRarity = "8", CountId = "9428", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001138", BitNumber = "9428"};
        public static readonly Item SummonCoinPCecilPP = new Item { Name = "Summon Coin (P.Cecil/P&P)", ItemId = "1209001139", Description = "Summon Coin (P.Cecil/P&P)", EquipmentRarity = "8", CountId = "9429", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001139", BitNumber = "9429"};
        public static readonly Item SakuraAyakasPrism = new Item { Name = "Sakura & Ayaka's Prism", ItemId = "310000540", Description = "Sakura & Ayaka Prism", EquipmentRarity = "8", CountId = "9430", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9430"};
        public static readonly Item SieghardIgnaciosPrism = new Item { Name = "Sieghard & Ignacio's Prism", ItemId = "310000550", Description = "Sieghard and Ignacio Prism", EquipmentRarity = "8", CountId = "9431", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9431"};
        public static readonly Item SweetLukasPrism = new Item { Name = "Sweet Luka's Prism", ItemId = "300001540", Description = "スウィートルルカの輝源", EquipmentRarity = "8", CountId = "960", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "877"};
        public static readonly Item SweetNicholsPrism = new Item { Name = "Sweet Nichol's Prism", ItemId = "300001530", Description = "スウィートニコルの輝源", EquipmentRarity = "8", CountId = "959", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "876"};
        public static readonly Item SweetSentimentsSummonTicket = new Item { Name = "Sweet Sentiments 5+1 Summon Ticket", ItemId = "1209001137", Description = "Sweet Sentiments 5+1 Summon Ticket", EquipmentRarity = "8", CountId = "9427", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001137", BitNumber = "9427"};
        public static readonly Item GuaranteedFeaturedTicketSISA = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [S&I/S&A]", ItemId = "1209001142", Description = "5★ Guaranteed (20% Featured) Ticket [S&I/S&A]", EquipmentRarity = "8", CountId = "9434", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001142", BitNumber = "9434"};
        public static readonly Item SummonCoinSISA = new Item { Name = "Summon Coin (S&I/S&A)", ItemId = "1209001143", Description = "Summon Coin (S&I/S&A)", EquipmentRarity = "8", CountId = "9435", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001143", BitNumber = "9435"};
        public static readonly Item GuaranteedFeaturedTicketSNicholSLuka = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [S.Nichol/S.Luka]", ItemId = "1209001144", Description = "5★ Guaranteed (20% Featured) Ticket [S.Nichol/S.Luka]", EquipmentRarity = "8", CountId = "9436", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001144", BitNumber = "9436"};
        public static readonly Item SummonCoinSNicholSLuka = new Item { Name = "Summon Coin (S.Nichol/S.Luka)", ItemId = "1209001145", Description = "Summon Coin (S.Nichol/S.Luka)", EquipmentRarity = "8", CountId = "9437", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001145", BitNumber = "9437"};
        public static readonly Item PermaPremiumSummonTicket = new Item { Name = "Perma-Premium 10+1 Summon Ticket", ItemId = "1209001160", Description = "Perma-Premium 10+1 Summon Ticket", EquipmentRarity = "8", CountId = "9453", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "908", BitNumber = "9453"};
        public static readonly Item BronzeHourglassFFIV = new Item { Name = "Bronze Hourglass (FFIV)", ItemId = "105008100", Description = "どうのすなどけい(FFIV)", EquipmentRarity = "6", CountId = "1059", IsPotUnit = "3", KeyName = "1", ItemStack = "99", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "105008100", BitNumber = "977"};
        public static readonly Item ChocolateRaidCoin = new Item { Name = "Chocolate Raid Coin", ItemId = "1209001140", Description = "Chocolate Raid Coin", EquipmentRarity = "6", CountId = "9432", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209001140", BitNumber = "9432"};
        public static readonly Item ChocoChunk = new Item { Name = "Choco Chunk", ItemId = "1209001141", Description = "Choco Chunk", EquipmentRarity = "6", CountId = "9433", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209001141", BitNumber = "9433"};
        public static readonly Item CacaoCore = new Item { Name = "Cacao Core", ItemId = "1209001149", Description = "Cacao Core", EquipmentRarity = "6", CountId = "9442", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "1000", ItemSellPrice = "10", ItemIdClone = "1209001149", BitNumber = "9442"};
        public static readonly Item ExchangeTicketAOKnightHein = new Item { Name = "5★ Exchange Ticket [A.O.Knight/Hein]", ItemId = "1209001155", Description = "5★ Exchange Ticket [A.O.Knight/Hein]", EquipmentRarity = "8", CountId = "9448", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001155", BitNumber = "9448"};
        public static readonly Item GuaranteedFeaturedTicketAOKnightHein = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [A.O.Knight/Hein]", ItemId = "1209001156", Description = "5★ Guaranteed (20% Featured) Ticket [A.O.Knight/Hein]", EquipmentRarity = "8", CountId = "9449", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001156", BitNumber = "9449"};
        public static readonly Item SummonCoinAOKnightHein = new Item { Name = "Summon Coin (A.O.Knight/Hein)", ItemId = "1209001157", Description = "Summon Coin (A.O.Knight/Hein)", EquipmentRarity = "8", CountId = "9450", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001157", BitNumber = "9450"};
        public static readonly Item Levigrass = new Item { Name = "Levigrass", ItemId = "106307700", Description = "ふゆうそう", EquipmentRarity = "3", CountId = "993", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106307700", BitNumber = "910"};
        public static readonly Item GuaranteedSpecialSummonTicket_106211490 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "106211490", Description = "[期間限定]★5確定SP召喚チケット", EquipmentRarity = "8", CountId = "998", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106211170", BitNumber = "916"};
        public static readonly Item XandesPrism = new Item { Name = "Xande's Prism", ItemId = "300001620", Description = "まおうザンデの輝源", EquipmentRarity = "8", CountId = "995", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "913"};
        public static readonly Item HeinsPrism = new Item { Name = "Hein's Prism", ItemId = "300001630", Description = "まどうしハインの輝源", EquipmentRarity = "8", CountId = "996", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "914"};
        public static readonly Item AwakenedOnionKnightsPrism = new Item { Name = "Awakened Onion Knight's Prism", ItemId = "300001610", Description = "オニオンナイトの輝源", EquipmentRarity = "8", CountId = "994", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "912"};
        public static readonly Item MadamEdelsPrism = new Item { Name = "Madam Edel's Prism", ItemId = "300001710", Description = "マダム・エーデルの輝源", EquipmentRarity = "8", CountId = "1025", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "943"};
        public static readonly Item DarkQuartz = new Item { Name = "Dark Quartz", ItemId = "235011100", Description = "闇水晶", EquipmentRarity = "5", CountId = "1026", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235011100", BitNumber = "944"};
        public static readonly Item GoldenDragonHorn = new Item { Name = "Golden Dragon Horn", ItemId = "235011200", Description = "金龍の角", EquipmentRarity = "4", CountId = "1027", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235011200", BitNumber = "945"};
        public static readonly Item GoldenBladeFragment = new Item { Name = "Golden Blade Fragment", ItemId = "235011300", Description = "黄金剣の欠片", EquipmentRarity = "4", CountId = "1028", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235011300", BitNumber = "946"};
        public static readonly Item AncientWine = new Item { Name = "Ancient Wine", ItemId = "235011400", Description = "古葡萄酒", EquipmentRarity = "4", CountId = "1029", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235011400", BitNumber = "947"};
        public static readonly Item SilverDragonFang = new Item { Name = "Silver Dragon Fang", ItemId = "235011500", Description = "銀龍の牙", EquipmentRarity = "4", CountId = "1030", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235011500", BitNumber = "948"};
        public static readonly Item GuaranteedFeaturedTicketMEdel = new Item { Name = "5★ Guaranteed (10% Featured) Ticket [M.Edel]", ItemId = "1209001158", Description = "5★ Guaranteed (10% Featured) Ticket [M.Edel]", EquipmentRarity = "8", CountId = "9451", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001158", BitNumber = "9451"};
        public static readonly Item SummonCoinMEdel = new Item { Name = "Summon Coin (M.Edel)", ItemId = "1209001159", Description = "Summon Coin (M.Edel)", EquipmentRarity = "8", CountId = "9452", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001159", BitNumber = "9452"};
        public static readonly Item SpringBlossomTicket = new Item { Name = "Spring Blossom Ticket", ItemId = "1209001161", Description = "Spring Blossom Ticket", EquipmentRarity = "8", CountId = "9454", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001161", BitNumber = "9454"};
        public static readonly Item InvigoratingPotionII = new Item { Name = "Invigorating Potion II", ItemId = "105007900", Description = "闘神薬Ⅱ", EquipmentRarity = "7", CountId = "1034", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "7000", ItemSellPrice = "700", ItemIdClone = "105007900", BitNumber = "952"};
        public static readonly Item InvigoratingPotionIII = new Item { Name = "Invigorating Potion III", ItemId = "105008000", Description = "闘神薬Ⅲ", EquipmentRarity = "8", CountId = "1035", IsPotUnit = "3", KeyName = "2", ItemStack = "99", ItemBuyPrice = "10000", ItemSellPrice = "1000", ItemIdClone = "105008000", BitNumber = "953"};
        public static readonly Item EmeraldGem = new Item { Name = "Emerald Gem", ItemId = "106211130", Description = "緑宝玉", EquipmentRarity = "8", CountId = "579", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "106211130", BitNumber = "512"};
        public static readonly Item VioletGem = new Item { Name = "Violet Gem", ItemId = "106211140", Description = "紫宝玉", EquipmentRarity = "8", CountId = "580", IsPotUnit = "5", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "106211140", BitNumber = "513"};
        public static readonly Item LadyLilithRaidCoin = new Item { Name = "Lady Lilith Raid Coin", ItemId = "106309000", Description = "レディ・リリスレイドコイン", EquipmentRarity = "3", CountId = "1194", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106309000", BitNumber = "1112"};
        public static readonly Item WizardessShantottosPrism = new Item { Name = "Wizardess Shantotto's Prism", ItemId = "300002140", Description = "連邦の黒い悪魔シャントットの輝源", EquipmentRarity = "8", CountId = "1200", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1118"};
        public static readonly Item LilisettesPrism = new Item { Name = "Lilisette's Prism", ItemId = "300002150", Description = "リリゼットの輝源", EquipmentRarity = "8", CountId = "1201", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1119"};
        public static readonly Item LiminalResidue = new Item { Name = "Liminal Residue", ItemId = "235018600", Description = "リミナルレジデ", EquipmentRarity = "4", CountId = "1197", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235018600", BitNumber = "1115"};
        public static readonly Item DeviousDie = new Item { Name = "Devious Die", ItemId = "235018700", Description = "トリックダイス", EquipmentRarity = "3", CountId = "1198", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235018700", BitNumber = "1116"};
        public static readonly Item GoldIngot = new Item { Name = "Gold Ingot", ItemId = "235018800", Description = "ゴールドインゴット", EquipmentRarity = "3", CountId = "1199", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235018800", BitNumber = "1117"};
        public static readonly Item CoinofRuin = new Item { Name = "Coin of Ruin", ItemId = "235018400", Description = "滅亡のコイン", EquipmentRarity = "5", CountId = "1195", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235018400", BitNumber = "1113"};
        public static readonly Item CoinofBirth = new Item { Name = "Coin of Birth", ItemId = "235018500", Description = "誕生のコイン", EquipmentRarity = "5", CountId = "1196", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235018500", BitNumber = "1114"};
        public static readonly Item MagicalMarchSummonTicket = new Item { Name = "Magical March Summon Ticket", ItemId = "1209001162", Description = "Magical March Ticket", EquipmentRarity = "8", CountId = "9455", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001162", BitNumber = "9455"};
        public static readonly Item ExchangeTicketWShantottoLilisette = new Item { Name = "5★ Exchange Ticket [W.Shantotto/Lilisette]", ItemId = "1209001164", Description = "5★ Exchange Ticket [W.Shantotto/Lilisette]", EquipmentRarity = "8", CountId = "9457", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001164", BitNumber = "9457"};
        public static readonly Item GuaranteedFeaturedTicketWShantottoLilisette = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [W.Shantotto/Lilisette]", ItemId = "1209001165", Description = "5★ Guaranteed (20% Featured) Ticket [W.Shantotto/Lilisette]", EquipmentRarity = "8", CountId = "9458", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001165", BitNumber = "9458"};
        public static readonly Item SummonCoinWShantottoLilisette = new Item { Name = "Summon Coin (W.Shantotto/Lilisette)", ItemId = "1209001166", Description = "Summon Coin (W.Shantotto/Lilisette)", EquipmentRarity = "8", CountId = "9459", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001166", BitNumber = "9459"};
        public static readonly Item SectoredCirclePurple_109304000 = new Item { Name = "Sectored Circle - Purple 1", ItemId = "109304000", Description = "石板の欠片・紫1", EquipmentRarity = "7", CountId = "502", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109304000", BitNumber = "502"};
        public static readonly Item SectoredCirclePurple_109304010 = new Item { Name = "Sectored Circle - Purple 2", ItemId = "109304010", Description = "石板の欠片・紫2", EquipmentRarity = "7", CountId = "503", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109304010", BitNumber = "503"};
        public static readonly Item SectoredCirclePurple_109304020 = new Item { Name = "Sectored Circle - Purple 3", ItemId = "109304020", Description = "石板の欠片・紫3", EquipmentRarity = "7", CountId = "504", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "109304020", BitNumber = "504"};
        public static readonly Item ExchangeTicketSPTidusYunalesca = new Item { Name = "5★ Exchange Ticket [S.P.Tidus/Yunalesca]", ItemId = "1209001167", Description = "5★ Exchange Ticket [Tidus.O.Z/Yunalesca]", EquipmentRarity = "8", CountId = "9460", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001167", BitNumber = "9460"};
        public static readonly Item GuaranteedFeaturedTicketSPTidusYunalesca = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [S.P.Tidus/Yunalesca]", ItemId = "1209001168", Description = "5★ Guaranteed (20% Featured) Ticket [Tidus.O.Z/Yunalesca]", EquipmentRarity = "8", CountId = "9461", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001168", BitNumber = "9461"};
        public static readonly Item SummonCoinSPTidusYunalesca = new Item { Name = "Summon Coin (S.P.Tidus/Yunalesca)", ItemId = "1209001169", Description = "Summon Coin (Tidus.O.Z/Yunalesca)", EquipmentRarity = "8", CountId = "9462", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001169", BitNumber = "9462"};
        public static readonly Item SpringBreakTicket = new Item { Name = "Spring Break Ticket", ItemId = "1209001184", Description = "Spring Break Ticket", EquipmentRarity = "8", CountId = "9473", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001184", BitNumber = "9473"};
        public static readonly Item KimahrisPrism = new Item { Name = "Kimahri's Prism", ItemId = "300001970", Description = "キマリの輝源", EquipmentRarity = "8", CountId = "1151", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1068"};
        public static readonly Item StarPlayerTidusPrism = new Item { Name = "Star Player Tidus' Prism", ItemId = "300001950", Description = "ザナルカンドのティーダの輝源", EquipmentRarity = "8", CountId = "1149", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1066"};
        public static readonly Item YunalescasPrism = new Item { Name = "Yunalesca's Prism", ItemId = "300001960", Description = "ユウナレスカの輝源", EquipmentRarity = "8", CountId = "1150", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1067"};
        public static readonly Item SpectralSphere = new Item { Name = "Spectral Sphere", ItemId = "106308700", Description = "魔天のスフィア", EquipmentRarity = "3", CountId = "1135", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106308700", BitNumber = "1052"};
        public static readonly Item BlackAuxiliaryQuestKey = new Item { Name = "Black Auxiliary Quest Key", ItemId = "1209001179", Description = "Black Auxiliary Quest Key", EquipmentRarity = "8", CountId = "9472", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "1209001179", BitNumber = "9472"};
        public static readonly Item WhiteAuxiliaryQuestKey = new Item { Name = "White Auxiliary Quest Key", ItemId = "1209001180", Description = "White Auxiliary Quest Key", EquipmentRarity = "8", CountId = "9473", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "1209001180", BitNumber = "9473"};
        public static readonly Item GreenAuxiliaryQuestKey = new Item { Name = "Green Auxiliary Quest Key", ItemId = "1209001181", Description = "Green Auxiliary Quest Key", EquipmentRarity = "8", CountId = "9474", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "1209001181", BitNumber = "9474"};
        public static readonly Item BlueAuxiliaryQuestKey = new Item { Name = "Blue Auxiliary Quest Key", ItemId = "1209001182", Description = "Blue Auxiliary Quest Key", EquipmentRarity = "8", CountId = "9475", IsPotUnit = "0", KeyName = "0", ItemStack = "99", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "1209001182", BitNumber = "9475"};
        public static readonly Item GuaranteedSpecialSummonTicket_106211750 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "106211750", Description = "[期間限定]★5確定SP召喚チケット2019/8", EquipmentRarity = "8", CountId = "1140", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106211170", BitNumber = "1057"};
        public static readonly Item SummonCoinTYLAJ = new Item { Name = "Summon Coin (T/Y/L/A/J)", ItemId = "1209001192", Description = "Summon Coin (T/Y/L/A/J)", EquipmentRarity = "8", CountId = "9481", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001192", BitNumber = "9481"};
        public static readonly Item ExchangeTicketFFXYRP = new Item { Name = "5★ Exchange Ticket [FFX-2: Y/R/P]", ItemId = "1209001170", Description = "5★ Exchange Ticket [Y/R/P]", EquipmentRarity = "8", CountId = "9463", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001170", BitNumber = "9463"};
        public static readonly Item GuaranteedFeaturedTicketFFXYRP = new Item { Name = "5★ Guaranteed (30% Featured) Ticket [FFX-2: Y/R/P]", ItemId = "1209001171", Description = "5★ Guaranteed (30% Featured) Ticket [Y/R/P]", EquipmentRarity = "8", CountId = "9464", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001171", BitNumber = "9464"};
        public static readonly Item SummonCoinFFXYRP = new Item { Name = "Summon Coin (FFX-2: Y/R/P)", ItemId = "1209001172", Description = "Summon Coin (Y/R/P)", EquipmentRarity = "8", CountId = "9465", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001172", BitNumber = "9465"};
        public static readonly Item DailyCoin = new Item { Name = "Daily Coin", ItemId = "1209001163", Description = "Daily Coin", EquipmentRarity = "8", CountId = "9456", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001163", BitNumber = "9456"};
        public static readonly Item Amber = new Item { Name = "Amber", ItemId = "235017200", Description = "琥珀", EquipmentRarity = "3", CountId = "1161", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235017200", BitNumber = "1078"};
        public static readonly Item RikkuFFXsPrism = new Item { Name = "Rikku (FFX-2)'s Prism", ItemId = "300002010", Description = "リュック(FFX-2)の輝源", EquipmentRarity = "8", CountId = "1158", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1075"};
        public static readonly Item YunaFFXsPrism = new Item { Name = "Yuna (FFX-2)'s Prism", ItemId = "300002000", Description = "ユウナ(FFX-2)の輝源", EquipmentRarity = "8", CountId = "1157", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1074"};
        public static readonly Item PainesPrism = new Item { Name = "Paine's Prism", ItemId = "300002020", Description = "パインの輝源", EquipmentRarity = "8", CountId = "1159", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1076"};
        public static readonly Item Lazulite = new Item { Name = "Lazulite", ItemId = "235017000", Description = "天藍石", EquipmentRarity = "4", CountId = "1138", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235017000", BitNumber = "1055"};
        public static readonly Item Calcite = new Item { Name = "Calcite", ItemId = "235017100", Description = "天輝石", EquipmentRarity = "5", CountId = "1152", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235017100", BitNumber = "1069"};
        public static readonly Item WhiteCube = new Item { Name = "White Cube", ItemId = "235016800", Description = "ホワイトキューブ", EquipmentRarity = "5", CountId = "1136", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235016800", BitNumber = "1053"};
        public static readonly Item BlackCube = new Item { Name = "Black Cube", ItemId = "235016900", Description = "ブラックキューブ", EquipmentRarity = "5", CountId = "1137", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235016900", BitNumber = "1054"};
        public static readonly Item Omniprism = new Item { Name = "Omniprism", ItemId = "900000001", Description = "ALL輝源", EquipmentRarity = "8", CountId = "1225", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "900000001", BitNumber = "1143"};
        public static readonly Item FMABROTHERHOODRaidCoin = new Item { Name = "FMA BROTHERHOOD Raid Coin", ItemId = "106309700", Description = "ハガレンFAレイドコイン", EquipmentRarity = "3", CountId = "1282", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106309700", BitNumber = "1201"};
        public static readonly Item SilverDial = new Item { Name = "Silver Dial", ItemId = "235020500", Description = "銀の文字盤", EquipmentRarity = "6", CountId = "1283", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "235020500", BitNumber = "1202"};
        public static readonly Item GlassFlask = new Item { Name = "Glass Flask", ItemId = "235020600", Description = "水晶のフラスコ", EquipmentRarity = "5", CountId = "1284", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235020600", BitNumber = "1203"};
        public static readonly Item AutomailScrew = new Item { Name = "Auto-mail Screw", ItemId = "235020700", Description = "オートメイルのネジ", EquipmentRarity = "4", CountId = "1285", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235020700", BitNumber = "1204"};
        public static readonly Item GreenCloth = new Item { Name = "Green Cloth", ItemId = "235020800", Description = "緑色の布", EquipmentRarity = "4", CountId = "1286", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235020800", BitNumber = "1205"};
        public static readonly Item MechanicalGear = new Item { Name = "Mechanical Gear", ItemId = "235020900", Description = "機械用歯車", EquipmentRarity = "3", CountId = "1287", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235020900", BitNumber = "1206"};
        public static readonly Item ExchangeTicketEdwardEAlphonseE = new Item { Name = "5★ Exchange Ticket [Edward.E/Alphonse.E]", ItemId = "1209001173", Description = "5★ Exchange Ticket [Edward.E/Alphonse.E]", EquipmentRarity = "8", CountId = "9466", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001173", BitNumber = "9466"};
        public static readonly Item GuaranteedFeaturedTicketEdwardEAlphonseE = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [Edward.E/Alphonse.E]", ItemId = "1209001174", Description = "5★ Guaranteed (20% Featured) Ticket [Edward.E/Alphonse.E]", EquipmentRarity = "8", CountId = "9467", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001174", BitNumber = "9467"};
        public static readonly Item SummonCoinEdwardEAlphonseE = new Item { Name = "Summon Coin (Edward.E/Alphonse.E)", ItemId = "1209001175", Description = "Summon Coin (Edward.E/Alphonse.E)", EquipmentRarity = "8", CountId = "9468", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001175", BitNumber = "9468"};
        public static readonly Item ExchangeTicketKBradleyRMustang = new Item { Name = "5★ Exchange Ticket [K.Bradley/R.Mustang]", ItemId = "1209001176", Description = "5★ Exchange Ticket [K.Bradley/Roy.M]", EquipmentRarity = "8", CountId = "9469", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001176", BitNumber = "9469"};
        public static readonly Item GuaranteedFeaturedTicketKBradleyRMustang = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [K.Bradley/R.Mustang]", ItemId = "1209001177", Description = "5★ Guaranteed (20% Featured) Ticket [K.Bradley/Roy.M]", EquipmentRarity = "8", CountId = "9470", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001177", BitNumber = "9470"};
        public static readonly Item SummonCoinKBradleyRMustang = new Item { Name = "Summon Coin (K.Bradley/R.Mustang)", ItemId = "1209001178", Description = "Summon Coin (K.Bradley/Roy.M)", EquipmentRarity = "8", CountId = "9471", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001178", BitNumber = "9471"};
        public static readonly Item RoyMustangsPrism = new Item { Name = "Roy Mustang's Prism", ItemId = "300002380", Description = "ロイ・マスタングの輝源", EquipmentRarity = "8", CountId = "1290", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1209"};
        public static readonly Item KingBradleysPrism = new Item { Name = "King Bradley's Prism", ItemId = "310000560", Description = "King Bradley Prism", EquipmentRarity = "8", CountId = "9441", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9441"};
        public static readonly Item EdwardElricsPrism = new Item { Name = "Edward Elric's Prism", ItemId = "300002360", Description = "エドワード・エルリックの輝源", EquipmentRarity = "8", CountId = "1288", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1207"};
        public static readonly Item AlphonseElricsPrism = new Item { Name = "Alphonse Elric's Prism", ItemId = "300002370", Description = "アルフォンス・エルリックの輝源", EquipmentRarity = "8", CountId = "1289", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1208"};
        public static readonly Item RakishThiefZidanesPrism = new Item { Name = "Rakish Thief Zidane's Prism", ItemId = "300001860", Description = "尻尾の少年ジタンの輝源", EquipmentRarity = "8", CountId = "1088", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1006"};
        public static readonly Item DragonKnightFreyasPrism = new Item { Name = "Dragon Knight Freya's Prism", ItemId = "300001870", Description = "ブルメシアの竜騎士フライヤの輝源", EquipmentRarity = "8", CountId = "1089", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1007"};
        public static readonly Item BlackMageVivisPrism = new Item { Name = "Black Mage Vivi's Prism", ItemId = "300001880", Description = "黒魔道士の少年ビビの輝源", EquipmentRarity = "8", CountId = "1090", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1008"};
        public static readonly Item StrangeGourmandQuinasPrism = new Item { Name = "Strange Gourmand Quina's Prism", ItemId = "300001890", Description = "クイナの輝源", EquipmentRarity = "8", CountId = "1091", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1009"};
        public static readonly Item DracozombiesTalon = new Item { Name = "Dracozombie's Talon", ItemId = "106308400", Description = "ドラゴンゾンビのツメ", EquipmentRarity = "3", CountId = "1095", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106308400", BitNumber = "1013"};
        public static readonly Item ExchangeTicketRTZDKFBMV = new Item { Name = "5★ Exchange Ticket [R.T.Z/D.K.F/B.M.V]", ItemId = "1209001186", Description = "5★ Exchange Ticket [R.T.Zidane/D.K.Freya/B.M.Vivi]", EquipmentRarity = "8", CountId = "9475", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001186", BitNumber = "9475"};
        public static readonly Item GuaranteedFeaturedTicketRTZDKFBMV = new Item { Name = "5★ Guaranteed (30% Featured) Ticket [R.T.Z/D.K.F/B.M.V]", ItemId = "1209001187", Description = "5★ Guaranteed (30% Featured) Ticket [R.T.Zidane/D.K.Freya/B.M.Vi", EquipmentRarity = "8", CountId = "9476", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001187", BitNumber = "9476"};
        public static readonly Item SummonCoinRTZDKFBMV = new Item { Name = "Summon Coin (R.T.Z/D.K.F/B.M.V)", ItemId = "1209001188", Description = "Summon Coin (R.T.Zidane/D.K.Freya/B.M.Vivi)", EquipmentRarity = "8", CountId = "9477", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001188", BitNumber = "9477"};
        public static readonly Item SummonCoinBeatrixEiko = new Item { Name = "Summon Coin (Beatrix/Eiko)", ItemId = "1209001205", Description = "Summon Coin (Beatrix/Eiko)", EquipmentRarity = "8", CountId = "9498", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001205", BitNumber = "9498"};
        public static readonly Item GuaranteedSpecialSummonTicket_106211680 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "106211680", Description = "[期間限定]★5確定SP召喚チケット", EquipmentRarity = "8", CountId = "1093", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106211170", BitNumber = "1011"};
        public static readonly Item SakuraoftheDeltaStarsPrism = new Item { Name = "Sakura of the Delta Star's Prism", ItemId = "300001900", Description = "四闘星のサクラの輝源", EquipmentRarity = "8", CountId = "1110", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1028"};
        public static readonly Item NicholoftheEpsilonStarsPrism = new Item { Name = "Nichol of the Epsilon Star's Prism", ItemId = "300001910", Description = "五闘星のニコルの輝源", EquipmentRarity = "8", CountId = "1111", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1029"};
        public static readonly Item ExchangeTicketSakuraDSNicholES = new Item { Name = "5★ Exchange Ticket [Sakura.D.S/Nichol.E.S]", ItemId = "1209001189", Description = "5★ Exchange Ticket [Sakura.D.S/Nichol.E.S]", EquipmentRarity = "8", CountId = "9478", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001189", BitNumber = "9478"};
        public static readonly Item GuaranteedFeaturedTicketSakuraDSNicholES = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [Sakura.D.S/Nichol.E.S]", ItemId = "1209001190", Description = "5★ Guaranteed (20% Featured) Ticket [Sakura.D.S/Nichol.E.S]", EquipmentRarity = "8", CountId = "9479", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001190", BitNumber = "9479"};
        public static readonly Item SummonCoinSakuraDSNicholES = new Item { Name = "Summon Coin (Sakura.D.S/Nichol.E.S)", ItemId = "1209001191", Description = "Summon Coin (Sakura.D.S/Nichol.E.S)", EquipmentRarity = "8", CountId = "9480", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001191", BitNumber = "9480"};
        public static readonly Item GuaranteedFeaturedTicketGilgameshWOTVFFBE = new Item { Name = "5★ Guaranteed (10% Featured) Ticket [Gilgamesh (WOTV FFBE)]", ItemId = "1209001199", Description = "5★ Guaranteed (10% Featured) Ticket [Gilgamesh (WOTV FFBE)]", EquipmentRarity = "8", CountId = "9492", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001199", BitNumber = "9492"};
        public static readonly Item SummonCoinGilgameshWOTVFFBE = new Item { Name = "Summon Coin (Gilgamesh (WOTV FFBE))", ItemId = "1209001200", Description = "Summon Coin (Gilgamesh (WOTV FFBE))", EquipmentRarity = "8", CountId = "9493", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001200", BitNumber = "9493"};
        public static readonly Item GilgameshWOTVFFBEsPrism = new Item { Name = "Gilgamesh (WOTV FFBE)'s Prism", ItemId = "300002450", Description = "ギルガメッシュの輝源", EquipmentRarity = "8", CountId = "1318", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1237"};
        public static readonly Item AntiParticleCore = new Item { Name = "Anti-Particle Core", ItemId = "235015700", Description = "対消滅コア", EquipmentRarity = "5", CountId = "1112", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235015700", BitNumber = "1030"};
        public static readonly Item MagicalSteelBolt = new Item { Name = "Magical Steel Bolt", ItemId = "235015800", Description = "魔鋼ボルト", EquipmentRarity = "4", CountId = "1113", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235015800", BitNumber = "1031"};
        public static readonly Item DoubleRubberRing = new Item { Name = "Double Rubber Ring", ItemId = "235015900", Description = "ダブルラバーリング", EquipmentRarity = "4", CountId = "1114", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235015900", BitNumber = "1032"};
        public static readonly Item StripeDyedCloth = new Item { Name = "Stripe-Dyed Cloth", ItemId = "235016000", Description = "ストライプ染布", EquipmentRarity = "4", CountId = "1115", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235016000", BitNumber = "1033"};
        public static readonly Item MagicalSteelGears = new Item { Name = "Magical Steel Gears", ItemId = "235016100", Description = "魔鋼の歯車", EquipmentRarity = "4", CountId = "1116", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235016100", BitNumber = "1034"};
        public static readonly Item EggceptionalTicket = new Item { Name = "Eggceptional Ticket", ItemId = "1209001207", Description = "Eggceptional Ticket", EquipmentRarity = "8", CountId = "9500", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001207", BitNumber = "9500"};
        public static readonly Item EsperMagicCryst = new Item { Name = "Esper Magic Cryst", ItemId = "106309100", Description = "幻魔結晶", EquipmentRarity = "3", CountId = "1205", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106309100", BitNumber = "1123"};
        public static readonly Item RedEsperLucidite = new Item { Name = "Red Esper Lucidite", ItemId = "235018900", Description = "赤幻瓏石", EquipmentRarity = "3", CountId = "1206", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235018900", BitNumber = "1124"};
        public static readonly Item NobleRedEsperLucidite = new Item { Name = "Noble Red Esper Lucidite", ItemId = "235019000", Description = "赤幻瓏貴石", EquipmentRarity = "3", CountId = "1207", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235019000", BitNumber = "1125"};
        public static readonly Item InfernalFireRainsPrism = new Item { Name = "Infernal Fire Rain's Prism", ItemId = "300002170", Description = "炎獄レインの輝源", EquipmentRarity = "8", CountId = "1208", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1126"};
        public static readonly Item DarkSpiritSolsPrism = new Item { Name = "Dark Spirit Sol's Prism", ItemId = "300002190", Description = "冥鬼ソルの輝源", EquipmentRarity = "8", CountId = "1210", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1128"};
        public static readonly Item ExchangeTicketIFRainDSSol = new Item { Name = "5★ Exchange Ticket [I.F.Rain/D.S.Sol]", ItemId = "1209001193", Description = "5★ Exchange Ticket [I.F.Rain/D.S.Sol]", EquipmentRarity = "8", CountId = "9486", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001193", BitNumber = "9486"};
        public static readonly Item GuaranteedFeaturedTicketIFRainDSSol = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [I.F.Rain/D.S.Sol]", ItemId = "1209001194", Description = "5★ Guaranteed (20% Featured) Ticket [I.F.Rain/D.S.Sol]", EquipmentRarity = "8", CountId = "9487", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001194", BitNumber = "9487"};
        public static readonly Item SummonCoinIFRainDSSol = new Item { Name = "Summon Coin (I.F.Rain/D.S.Sol)", ItemId = "1209001195", Description = "Summon Coin (I.F.Rain/D.S.Sol)", EquipmentRarity = "8", CountId = "9488", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001195", BitNumber = "9488"};
        public static readonly Item DarkVisionsArrivalTicket = new Item { Name = "Dark Visions' Arrival Ticket", ItemId = "1209001185", Description = "Dark Vision Ticket", EquipmentRarity = "8", CountId = "9474", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001185", BitNumber = "9474"};
        public static readonly Item DraconianPrincessFinasPrism = new Item { Name = "Draconian Princess Fina's Prism", ItemId = "300002180", Description = "竜姫フィーナの輝源", EquipmentRarity = "8", CountId = "1209", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1127"};
        public static readonly Item SupremeDevaAkstarsPrism = new Item { Name = "Supreme Deva Akstar's Prism", ItemId = "300002200", Description = "覇王アクスターの輝源", EquipmentRarity = "8", CountId = "1211", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1129"};
        public static readonly Item GuaranteedSpecialSummonTicket_106212020 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "106212020", Description = "[期間限定]★5確定SP召喚チケット2019/10", EquipmentRarity = "8", CountId = "1217", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106211170", BitNumber = "1135"};
        public static readonly Item YshtolatheSorceresssPrism = new Item { Name = "Y'shtola the Sorceress's Prism", ItemId = "300001940", Description = "魔女ヤ・シュトラの輝源", EquipmentRarity = "8", CountId = "1131", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1048"};
        public static readonly Item ExchangeTicketDPFinaSDAkstar = new Item { Name = "5★ Exchange Ticket [D.P.Fina/S.D.Akstar]", ItemId = "1209001196", Description = "5★ Exchange Ticket [D.P.Fina/S.D.Akstar]", EquipmentRarity = "8", CountId = "9489", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001196", BitNumber = "9489"};
        public static readonly Item GuaranteedFeaturedTicketDPFinaSDAkstar = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [D.P.Fina/S.D.Akstar]", ItemId = "1209001197", Description = "5★ Guaranteed (20% Featured) Ticket [D.P.Fina/S.D.Akstar]", EquipmentRarity = "8", CountId = "9490", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001197", BitNumber = "9490"};
        public static readonly Item SummonCoinDPFinaSDAkstar = new Item { Name = "Summon Coin (D.P.Fina/S.D.Akstar)", ItemId = "1209001198", Description = "Summon Coin (D.P.Fina/S.D.Akstar)", EquipmentRarity = "8", CountId = "9491", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001198", BitNumber = "9491"};
        public static readonly Item SummonCoinSpringAwakening = new Item { Name = "Summon Coin (Spring Awakening)", ItemId = "1209001206", Description = "Summon Coin (Spring Awakening)", EquipmentRarity = "8", CountId = "9499", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001206", BitNumber = "9499"};
        public static readonly Item DXSummonTicket = new Item { Name = "DX Summon Ticket", ItemId = "106211700", Description = "DX召喚チケット", EquipmentRarity = "8", CountId = "1117", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106211630", BitNumber = "1035"};
        public static readonly Item DarkMatter_235018200 = new Item { Name = "Dark Matter", ItemId = "235018200", Description = "ダークマター", EquipmentRarity = "3", CountId = "1171", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "235018200", BitNumber = "1099"};
        public static readonly Item LezardValethsPrism = new Item { Name = "Lezard Valeth's Prism", ItemId = "300001920", Description = "レザード・ヴァレスの輝源", EquipmentRarity = "8", CountId = "1129", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1046"};
        public static readonly Item MystinasPrism = new Item { Name = "Mystina's Prism", ItemId = "300001930", Description = "メルティーナの輝源", EquipmentRarity = "8", CountId = "1130", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1047"};
        public static readonly Item LokiRaidCoin = new Item { Name = "Loki Raid Coin", ItemId = "106308600", Description = "ロキレイドコイン", EquipmentRarity = "3", CountId = "1127", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106308600", BitNumber = "1045"};
        public static readonly Item OrichalcumVP_235016300 = new Item { Name = "Orichalcum (VP)", ItemId = "235016300", Description = "オリハルコン(ヴァルキリープロファイル)", EquipmentRarity = "5", CountId = "1118", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235016300", BitNumber = "1036"};
        public static readonly Item OrichalcumVP_235016200 = new Item { Name = "Orichalcum+ (VP)", ItemId = "235016200", Description = "真・オリハルコン", EquipmentRarity = "6", CountId = "1126", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "4000", ItemSellPrice = "400", ItemIdClone = "235016200", BitNumber = "1044"};
        public static readonly Item BookofEverlastingLife = new Item { Name = "Book of Everlasting Life", ItemId = "235016700", Description = "不老不死の書", EquipmentRarity = "3", CountId = "1122", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235016700", BitNumber = "1040"};
        public static readonly Item BrokenBlade_235016600 = new Item { Name = "Broken Blade", ItemId = "235016600", Description = "折れた剣", EquipmentRarity = "3", CountId = "1121", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235016600", BitNumber = "1039"};
        public static readonly Item EbonyPowder = new Item { Name = "Ebony Powder", ItemId = "235016500", Description = "黒真珠の粉", EquipmentRarity = "4", CountId = "1120", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235016500", BitNumber = "1038"};
        public static readonly Item FreshMeat = new Item { Name = "Fresh Meat", ItemId = "235016400", Description = "海鮮肉", EquipmentRarity = "4", CountId = "1119", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235016400", BitNumber = "1037"};
        public static readonly Item ExchangeTicketVALKYRIEPROFILELENNETH = new Item { Name = "5★ Exchange Ticket [VALKYRIE PROFILE -LENNETH-]", ItemId = "1209001201", Description = "5★ Exchange Ticket [VALKYRIE PROFILE -LENNETH-]", EquipmentRarity = "8", CountId = "9494", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001201", BitNumber = "9494"};
        public static readonly Item GuaranteedFeaturedTicketVALKYRIEPROFILELENNETH = new Item { Name = "5★ Guaranteed (30% Featured) Ticket [VALKYRIE PROFILE -LENNETH-]", ItemId = "1209001202", Description = "5★ Guaranteed (30% Featured) Ticket [VALKYRIE PROFILE -LENNETH-]", EquipmentRarity = "8", CountId = "9495", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001202", BitNumber = "9495"};
        public static readonly Item SummonCoinVALKYRIEPROFILELENNETH = new Item { Name = "Summon Coin (VALKYRIE PROFILE -LENNETH-)", ItemId = "1209001203", Description = "Summon Coin (VALKYRIE PROFILE -LENNETH-)", EquipmentRarity = "8", CountId = "9496", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001203", BitNumber = "9496"};
        public static readonly Item VALKYRIEPROFILELENNETHLimitedExchangeTicketLFA = new Item { Name = "VALKYRIE PROFILE -LENNETH- Limited Exchange Ticket [L/F/A]", ItemId = "1209001204", Description = "VALKYRIE PROFILE -LENNETH- Limited Exchange Ticket [L/F/A]", EquipmentRarity = "8", CountId = "9497", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001204", BitNumber = "9314"};
        public static readonly Item TifaFFVIIACsPrism = new Item { Name = "Tifa (FFVII AC)'s Prism", ItemId = "300002320", Description = "ティファ(FFVII AC)の輝源", EquipmentRarity = "8", CountId = "1268", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1187"};
        public static readonly Item CloudFFVIIACsPrism = new Item { Name = "Cloud (FFVII AC)'s Prism", ItemId = "300002310", Description = "クラウド(FFVII AC)の輝源", EquipmentRarity = "8", CountId = "1267", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1186"};
        public static readonly Item KadajsPrism = new Item { Name = "Kadaj's Prism", ItemId = "300002330", Description = "カダージュの輝源", EquipmentRarity = "8", CountId = "1269", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1188"};
        public static readonly Item ChurchFlower = new Item { Name = "Church Flower", ItemId = "106309600", Description = "教会に咲く花", EquipmentRarity = "3", CountId = "1262", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106309600", BitNumber = "1181"};
        public static readonly Item GuaranteedSpecialSummonTicket_106212200 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "106212200", Description = "[期間限定]★5確定SP召喚チケット2019/11", EquipmentRarity = "8", CountId = "1264", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106212200", BitNumber = "1183"};
        public static readonly Item ExchangeTicketFFVIIAC = new Item { Name = "5★ Exchange Ticket [FFVII: AC]", ItemId = "1209001208", Description = "5★ Exchange Ticket [FFVII: AC]", EquipmentRarity = "8", CountId = "9501", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001208", BitNumber = "9501"};
        public static readonly Item GuaranteedFeaturedTicketFFVIIAC = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [FFVII: AC]", ItemId = "1209001209", Description = "5★ Guaranteed (20% Featured) Ticket [FFVII: AC]", EquipmentRarity = "8", CountId = "9502", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001209", BitNumber = "9502"};
        public static readonly Item SummonCoinFFVIIAC = new Item { Name = "Summon Coin (FFVII: AC)", ItemId = "1209001210", Description = "Summon Coin (FFVII: AC)", EquipmentRarity = "8", CountId = "9503", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001210", BitNumber = "9503"};
        public static readonly Item ExchangeCoinFFVIIACU = new Item { Name = "Exchange Coin [FFVII: AC] (U)", ItemId = "1209001221", Description = "Exchange Coin [FFVII: AC] (U)", EquipmentRarity = "8", CountId = "9515", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001221", BitNumber = "9515"};
        public static readonly Item ExchangeCoinFFVIIACP = new Item { Name = "Exchange Coin [FFVII: AC] (P)", ItemId = "1209001222", Description = "Exchange Coin [FFVII: AC] (P)", EquipmentRarity = "8", CountId = "9516", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001222", BitNumber = "9516"};
        public static readonly Item BeginnersSelectTicket = new Item { Name = "5★ Beginner's Select Ticket", ItemId = "1209001224", Description = "5★ Beginner Selection Ticket", EquipmentRarity = "8", CountId = "9518", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001224", BitNumber = "9518"};
        public static readonly Item BlueEsperLucidite = new Item { Name = "Blue Esper Lucidite", ItemId = "235019100", Description = "青幻瓏石", EquipmentRarity = "3", CountId = "1240", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235019100", BitNumber = "1159"};
        public static readonly Item NobleBlueEsperLucidite = new Item { Name = "Noble Blue Esper Lucidite", ItemId = "235019200", Description = "青幻瓏貴石", EquipmentRarity = "3", CountId = "1241", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235019200", BitNumber = "1160"};
        public static readonly Item HallowedAegisCharlottesPrism = new Item { Name = "Hallowed Aegis Charlotte's Prism", ItemId = "300002250", Description = "聖砦シャルロットの輝源", EquipmentRarity = "8", CountId = "1230", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1149"};
        public static readonly Item MysticalIceLasswellsPrism = new Item { Name = "Mystical Ice Lasswell's Prism", ItemId = "300002220", Description = "氷魔ラスウェルの輝源", EquipmentRarity = "8", CountId = "1227", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1146"};
        public static readonly Item FourWindsPhysalissPrism = new Item { Name = "Four Winds Physalis's Prism", ItemId = "300002240", Description = "四天ファイサリスの輝源", EquipmentRarity = "8", CountId = "1229", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1148"};
        public static readonly Item WarHeroRaegensPrism = new Item { Name = "War Hero Raegen's Prism", ItemId = "300002230", Description = "戦騎レーゲンの輝源", EquipmentRarity = "8", CountId = "1228", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1147"};
        public static readonly Item ExchangeTicketMILasswellHACharlotte = new Item { Name = "5★ Exchange Ticket [M.I.Lasswell/H.A.Charlotte]", ItemId = "1209001211", Description = "5★ Exchange Ticket [M.I.Lasswell/H.A.Charlotte]", EquipmentRarity = "8", CountId = "9504", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001211", BitNumber = "9504"};
        public static readonly Item GuaranteedFeaturedTicketMILasswellHACharlotte = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [M.I.Lasswell/H.A.Charlotte]", ItemId = "1209001212", Description = "5★ Guaranteed (20% Featured) Ticket [M.I.Lasswell/H.A.Charlotte]", EquipmentRarity = "8", CountId = "9505", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001212", BitNumber = "9505"};
        public static readonly Item SummonCoinMILasswellHACharlotte = new Item { Name = "Summon Coin (M.I.Lasswell/H.A.Charlotte)", ItemId = "1209001213", Description = "Summon Coin (M.I.Lasswell/H.A.Charlotte)", EquipmentRarity = "8", CountId = "9506", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001213", BitNumber = "9506"};
        public static readonly Item MayBundleTicket = new Item { Name = "May Bundle Ticket", ItemId = "1209001217", Description = "May Bundle Ticket", EquipmentRarity = "8", CountId = "9511", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001217", BitNumber = "9511"};
        public static readonly Item DARKVISIONSSpecialQuestCoin = new Item { Name = "DARK VISIONS Special Quest Coin", ItemId = "1209001225", Description = "Dark Vision Coin", EquipmentRarity = "3", CountId = "9519", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001225", BitNumber = "9519"};
        public static readonly Item UntamedWolfEdelsPrism = new Item { Name = "Untamed Wolf Edel's Prism", ItemId = "300002210", Description = "魔狼マダム・エーデルの輝源", EquipmentRarity = "8", CountId = "1224", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1142"};
        public static readonly Item ExchangeTicketWHRaegenFWPhysalis = new Item { Name = "5★ Exchange Ticket [W.H.Raegen/F.W.Physalis]", ItemId = "1209001214", Description = "5★ Exchange Ticket [W.H.Raegen/F.W.Physalis]", EquipmentRarity = "8", CountId = "9507", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001214", BitNumber = "9507"};
        public static readonly Item GuaranteedFeaturedTicketWHRaegenFWPhysalis = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [W.H.Raegen/F.W.Physalis]", ItemId = "1209001215", Description = "5★ Guaranteed (20% Featured) Ticket [W.H.Raegen/F.W.Physalis]", EquipmentRarity = "8", CountId = "9508", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001215", BitNumber = "9508"};
        public static readonly Item SummonCoinWHRaegenFWPhysalis = new Item { Name = "Summon Coin (W.H.Raegen/F.W.Physalis)", ItemId = "1209001216", Description = "Summon Coin (W.H.Raegen/F.W.Physalis)", EquipmentRarity = "8", CountId = "9509", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001216", BitNumber = "9509"};
        public static readonly Item DaughterofDestinyVanillesPrism = new Item { Name = "Daughter of Destiny Vanille's Prism", ItemId = "300002460", Description = "宿命の少女ヴァニラの輝源", EquipmentRarity = "8", CountId = "1327", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1246"};
        public static readonly Item GracefulChampionFangsPrism = new Item { Name = "Graceful Champion Fang's Prism", ItemId = "300002470", Description = "麗しき勇士ファングの輝源", EquipmentRarity = "8", CountId = "1328", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1247"};
        public static readonly Item ExchangeTicketDODVanilleGCFang = new Item { Name = "5★ Exchange Ticket [D.O.D.Vanille/G.C.Fang]", ItemId = "1209001218", Description = "5★ Exchange Ticket [D.O.D.Vanille/G.C.Fang]", EquipmentRarity = "8", CountId = "9512", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001218", BitNumber = "9512"};
        public static readonly Item GuaranteedFeaturedTicketDODVanilleGCFang = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [D.O.D.Vanille/G.C.Fang]", ItemId = "1209001219", Description = "5★ Guaranteed (20% Featured) Ticket [D.O.D.Vanille/G.C.Fang]", EquipmentRarity = "8", CountId = "9513", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001219", BitNumber = "9513"};
        public static readonly Item SummonCoinDODVanilleGCFang = new Item { Name = "Summon Coin (D.O.D.Vanille/G.C.Fang)", ItemId = "1209001220", Description = "Summon Coin (D.O.D.Vanille/G.C.Fang)", EquipmentRarity = "8", CountId = "9514", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001220", BitNumber = "9514"};
        public static readonly Item DarkVisionsIITicket = new Item { Name = "Dark Visions II Ticket", ItemId = "1209001223", Description = "Dark Visions II Ticket", EquipmentRarity = "8", CountId = "9517", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001223", BitNumber = "9517"};
        public static readonly Item HecatoncheirRaidCoin = new Item { Name = "Hecatoncheir Raid Coin", ItemId = "106309900", Description = "ヘカトンケイルレイドコイン", EquipmentRarity = "3", CountId = "1321", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106309900", BitNumber = "1240"};
        public static readonly Item OrangeOerbaYarn = new Item { Name = "Orange Oerba Yarn", ItemId = "235021700", Description = "ヲルバの橙糸", EquipmentRarity = "5", CountId = "1322", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235021700", BitNumber = "1241"};
        public static readonly Item BlueOerbaYarn = new Item { Name = "Blue Oerba Yarn", ItemId = "235021800", Description = "ヲルバの青糸", EquipmentRarity = "5", CountId = "1323", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235021800", BitNumber = "1242"};
        public static readonly Item MetalParts = new Item { Name = "Metal Parts", ItemId = "235021900", Description = "メタルパーツ", EquipmentRarity = "4", CountId = "1324", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235021900", BitNumber = "1243"};
        public static readonly Item MedicinalOil = new Item { Name = "Medicinal Oil", ItemId = "235022000", Description = "薬効の油", EquipmentRarity = "3", CountId = "1325", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235022000", BitNumber = "1244"};
        public static readonly Item OtherworldlyLeather = new Item { Name = "Otherworldly Leather", ItemId = "235022100", Description = "魔獣の毛皮", EquipmentRarity = "3", CountId = "1326", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235022100", BitNumber = "1245"};
        public static readonly Item LightningFFXIIIsPrism = new Item { Name = "Lightning (FFXIII-2)'s Prism", ItemId = "300002410", Description = "ライトニング(FFXIII-2)の輝源", EquipmentRarity = "8", CountId = "1298", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1217"};
        public static readonly Item SerahsPrism = new Item { Name = "Serah's Prism", ItemId = "300002390", Description = "セラの輝源", EquipmentRarity = "8", CountId = "1296", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1215"};
        public static readonly Item NoelsPrism = new Item { Name = "Noel's Prism", ItemId = "300002400", Description = "ノエルの輝源", EquipmentRarity = "8", CountId = "1297", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1216"};
        public static readonly Item PotentDroplet = new Item { Name = "Potent Droplet", ItemId = "106309800", Description = "万能のしずく", EquipmentRarity = "3", CountId = "1293", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106309800", BitNumber = "1212"};
        public static readonly Item AbyssalScale = new Item { Name = "Abyssal Scale", ItemId = "235021000", Description = "深淵の鱗", EquipmentRarity = "3", CountId = "1294", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235021000", BitNumber = "1213"};
        public static readonly Item TearofWoe = new Item { Name = "Tear of Woe", ItemId = "235021100", Description = "悲嘆の紅涙", EquipmentRarity = "3", CountId = "1295", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235021100", BitNumber = "1214"};
        public static readonly Item ExchangeTicketSerahNoel = new Item { Name = "5★ Exchange Ticket [Serah/Noel]", ItemId = "1209001226", Description = "5★ Exchange Ticket [Serah/Noel]", EquipmentRarity = "8", CountId = "9520", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001226", BitNumber = "9520"};
        public static readonly Item GuaranteedFeaturedTicketSerahNoel = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [Serah/Noel]", ItemId = "1209001227", Description = "5★ Guaranteed (20% Featured) Ticket [Serah/Noel]", EquipmentRarity = "8", CountId = "9521", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001227", BitNumber = "9521"};
        public static readonly Item SummonCoinSerahNoel = new Item { Name = "Summon Coin (Serah/Noel)", ItemId = "1209001228", Description = "Summon Coin (Serah/Noel)", EquipmentRarity = "8", CountId = "9522", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001228", BitNumber = "9522"};
        public static readonly Item GuaranteedSpecialSummonTicket_106212310 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "106212310", Description = "[期間限定]★5確定SP召喚チケット2019/12", EquipmentRarity = "8", CountId = "1301", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106212200", BitNumber = "1220"};
        public static readonly Item CollaborationFestivalCoin = new Item { Name = "Collaboration Festival Coin", ItemId = "1209001238", Description = "Collaboration Festival Coin", EquipmentRarity = "3", CountId = "9532", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001238", BitNumber = "9532"};
        public static readonly Item CollaborationFestivalExchangeTicket = new Item { Name = "Collaboration Festival 5★ Exchange Ticket", ItemId = "1209001236", Description = "Collaboration Festival 5★ Exchange Ticket", EquipmentRarity = "8", CountId = "9530", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001236", BitNumber = "9530"};
        public static readonly Item RicoRodriguezsPrism = new Item { Name = "Rico Rodriguez's Prism", ItemId = "310000570", Description = "Rico Rodriguez Prism", EquipmentRarity = "8", CountId = "9510", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "9510"};
        public static readonly Item ExchangeTicketLLSquallSeifer = new Item { Name = "5★ Exchange Ticket [L.L.Squall/Seifer]", ItemId = "1209001229", Description = "5★ Exchange Ticket [L.L.Squall/Seifer]", EquipmentRarity = "8", CountId = "9523", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001229", BitNumber = "9523"};
        public static readonly Item GuaranteedFeaturedTicketLLSquallSeifer = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [L.L.Squall/Seifer]", ItemId = "1209001230", Description = "5★ Guaranteed (20% Featured) Ticket [L.L.Squall/Seifer]", EquipmentRarity = "8", CountId = "9524", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001230", BitNumber = "9524"};
        public static readonly Item SummonCoinLLSquallSeifer = new Item { Name = "Summon Coin (L.L.Squall/Seifer)", ItemId = "1209001231", Description = "Summon Coin (L.L.Squall/Seifer)", EquipmentRarity = "8", CountId = "9525", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001231", BitNumber = "9525"};
        public static readonly Item QuistissPrism = new Item { Name = "Quistis's Prism", ItemId = "300002500", Description = "キスティスの輝源", EquipmentRarity = "8", CountId = "1338", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1257"};
        public static readonly Item SeifersPrism = new Item { Name = "Seifer's Prism", ItemId = "300002490", Description = "サイファーの輝源", EquipmentRarity = "8", CountId = "1337", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1256"};
        public static readonly Item LoneLionSquallsPrism = new Item { Name = "Lone Lion Squall's Prism", ItemId = "300002480", Description = "孤高の獅子スコールの輝源", EquipmentRarity = "8", CountId = "1336", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1255"};
        public static readonly Item MoonStone = new Item { Name = "Moon Stone", ItemId = "106310000", Description = "月の石", EquipmentRarity = "3", CountId = "1333", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106310000", BitNumber = "1252"};
        public static readonly Item EnergyCrystal = new Item { Name = "Energy Crystal", ItemId = "235022200", Description = "エネルギー結晶体", EquipmentRarity = "3", CountId = "1334", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235022200", BitNumber = "1253"};
        public static readonly Item LuvLuvG = new Item { Name = "LuvLuv G", ItemId = "235022300", Description = "ラブラブG", EquipmentRarity = "3", CountId = "1335", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235022300", BitNumber = "1254"};
        public static readonly Item GuaranteedSpecialSummonTicket_106212460 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "106212460", Description = "★5確定SP召喚チケット2020/1", EquipmentRarity = "8", CountId = "1339", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106212200", BitNumber = "1258"};
        public static readonly Item SelphiesPrism = new Item { Name = "Selphie's Prism", ItemId = "300002540", Description = "セルフィの輝源", EquipmentRarity = "8", CountId = "1372", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1291"};
        public static readonly Item IrvinesPrism = new Item { Name = "Irvine's Prism", ItemId = "300002550", Description = "アーヴァインの輝源", EquipmentRarity = "8", CountId = "1373", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1292"};
        public static readonly Item BlueMageFinasPrism = new Item { Name = "Blue Mage Fina's Prism", ItemId = "300001800", Description = "青魔道士フィーナの輝源", EquipmentRarity = "8", CountId = "1063", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "981"};
        public static readonly Item SorceresssKnightRaidCoin = new Item { Name = "Sorceress's Knight Raid Coin", ItemId = "106310200", Description = "魔女の騎士レイドコイン", EquipmentRarity = "3", CountId = "1366", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106310200", BitNumber = "1285"};
        public static readonly Item RosettaStone = new Item { Name = "Rosetta Stone", ItemId = "235022900", Description = "ロゼッタ石", EquipmentRarity = "5", CountId = "1367", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235022900", BitNumber = "1286"};
        public static readonly Item DynamoStone = new Item { Name = "Dynamo Stone", ItemId = "235023000", Description = "ダイナモ石", EquipmentRarity = "5", CountId = "1368", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "2000", ItemSellPrice = "200", ItemIdClone = "235023000", BitNumber = "1287"};
        public static readonly Item StarFragment = new Item { Name = "Star Fragment", ItemId = "235023100", Description = "星々のかけら", EquipmentRarity = "4", CountId = "1369", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "1000", ItemSellPrice = "100", ItemIdClone = "235023100", BitNumber = "1288"};
        public static readonly Item SteelCurtain = new Item { Name = "Steel Curtain", ItemId = "235023200", Description = "鉄のカーテン", EquipmentRarity = "3", CountId = "1370", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235023200", BitNumber = "1289"};
        public static readonly Item CockatricePinion = new Item { Name = "Cockatrice Pinion", ItemId = "235023300", Description = "コカトリスの羽", EquipmentRarity = "3", CountId = "1371", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235023300", BitNumber = "1290"};
        public static readonly Item ComebackSummonTicket_1209001272 = new Item { Name = "Comeback 10+1 Summon Ticket", ItemId = "1209001272", Description = "Comeback 10+1 Summon Ticket", EquipmentRarity = "8", CountId = "9560", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001009", BitNumber = "9560"};
        public static readonly Item ExchangeTicketSelphieIrvine = new Item { Name = "5★ Exchange Ticket [Selphie/Irvine]", ItemId = "1209001232", Description = "5★ Exchange Ticket [Selphie/Irvine]", EquipmentRarity = "8", CountId = "9526", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001232", BitNumber = "9526"};
        public static readonly Item GuaranteedFeaturedTicketSelphieIrvine = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [Selphie/Irvine]", ItemId = "1209001233", Description = "5★ Guaranteed (20% Featured) Ticket [Selphie/Irvine]", EquipmentRarity = "8", CountId = "9527", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001233", BitNumber = "9527"};
        public static readonly Item SummonCoinSelphieIrvine = new Item { Name = "Summon Coin (Selphie/Irvine)", ItemId = "1209001234", Description = "Summon Coin (Selphie/Irvine)", EquipmentRarity = "8", CountId = "9528", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001234", BitNumber = "9528"};
        public static readonly Item DarkVisionsIIITicket = new Item { Name = "Dark Visions III Ticket", ItemId = "1209001235", Description = "Dark Visions III Ticket", EquipmentRarity = "8", CountId = "9529", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001235", BitNumber = "9529"};
        public static readonly Item FFBEthAnniversarySlotsToken = new Item { Name = "FFBE 4th Anniversary Slots Token", ItemId = "1209001239", Description = "FFBE 4th Anniversary Slots Token", EquipmentRarity = "8", CountId = "9533", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001239", BitNumber = "9533"};
        public static readonly Item NextEraExchangeTicket = new Item { Name = "Next Era 5★ Exchange Ticket", ItemId = "1209001259", Description = "Next Era 5★ Exchange Ticket", EquipmentRarity = "8", CountId = "9547", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001259", BitNumber = "9547"};
        public static readonly Item FFBEEquipmentExchangeTicket = new Item { Name = "FFBE Equipment Exchange Ticket", ItemId = "106212070", Description = "復刻FFBE装備交換チケット", EquipmentRarity = "8", CountId = "1222", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106212070", BitNumber = "1140"};
        public static readonly Item ExchangeTicketWOTVSLKG = new Item { Name = "5★ Exchange Ticket [WOTV: S.L/K/G]", ItemId = "1209001245", Description = "5★ Exchange Ticket [WOTV: S.L/K/G]", EquipmentRarity = "8", CountId = "9534", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001245", BitNumber = "9534"};
        public static readonly Item GuaranteedFeaturedTicketWOTVSLKG = new Item { Name = "5★ Guaranteed (30% Featured) Ticket [WOTV: S.L/K/G]", ItemId = "1209001246", Description = "5★ Guaranteed (30% Featured) Ticket [WOTV: S.L/K/G]", EquipmentRarity = "8", CountId = "9535", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001246", BitNumber = "9535"};
        public static readonly Item SummonCoinWOTVSLKG = new Item { Name = "Summon Coin (WOTV: S.L/K/G)", ItemId = "1209001247", Description = "Summon Coin (WOTV: S.L/K/G)", EquipmentRarity = "8", CountId = "9536", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001247", BitNumber = "9536"};
        public static readonly Item NextEraIIExchangeTicket = new Item { Name = "Next Era II 5★ Exchange Ticket", ItemId = "1209001260", Description = "Next Era II 5★ Exchange Ticket", EquipmentRarity = "8", CountId = "9548", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001260", BitNumber = "9548"};
        public static readonly Item DXSummonTicketJuly = new Item { Name = "DX Summon Ticket [July 2020]", ItemId = "106212880", Description = "DXボックス召喚チケット2020/3", EquipmentRarity = "8", CountId = "1449", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106212880", BitNumber = "1549"};
        public static readonly Item MontLeonissPrism = new Item { Name = "Mont Leonis's Prism", ItemId = "300002760", Description = "モントの輝源", EquipmentRarity = "8", CountId = "1452", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1552"};
        public static readonly Item KitonesPrism = new Item { Name = "Kitone's Prism", ItemId = "300002750", Description = "キトンの輝源", EquipmentRarity = "8", CountId = "1451", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1551"};
        public static readonly Item SterneLeonissPrism = new Item { Name = "Sterne Leonis's Prism", ItemId = "300002740", Description = "シュテルの輝源", EquipmentRarity = "8", CountId = "1450", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1550"};
        public static readonly Item WildCardAcesPrism = new Item { Name = "Wild Card Ace's Prism", ItemId = "300002560", Description = "0組の秀才エースの輝源", EquipmentRarity = "8", CountId = "1382", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1301"};
        public static readonly Item BenevolentBeautyRemsPrism = new Item { Name = "Benevolent Beauty Rem's Prism", ItemId = "300002570", Description = "慈愛の少女レムの輝源", EquipmentRarity = "8", CountId = "1383", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1302"};
        public static readonly Item SteadfastSoldierMachinasPrism = new Item { Name = "Steadfast Soldier Machina's Prism", ItemId = "300002580", Description = "不撓の戦士マキナの輝源", EquipmentRarity = "8", CountId = "1384", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "0", ItemSellPrice = "0", ItemIdClone = "600000090", BitNumber = "1303"};
        public static readonly Item RedPhantoma = new Item { Name = "Red Phantoma", ItemId = "106310300", Description = "レッドファントマ", EquipmentRarity = "3", CountId = "1379", IsPotUnit = "0", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "500", ItemSellPrice = "10", ItemIdClone = "106310300", BitNumber = "1298"};
        public static readonly Item BlankCard = new Item { Name = "Blank Card", ItemId = "235023400", Description = "ブランクカード", EquipmentRarity = "3", CountId = "1380", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235023400", BitNumber = "1299"};
        public static readonly Item GlaciesCodexFFTYPE = new Item { Name = "Glacies Codex (FF TYPE-0)", ItemId = "235023500", Description = "氷の書(FF零式)", EquipmentRarity = "3", CountId = "1381", IsPotUnit = "0", KeyName = "0", ItemStack = "199", ItemBuyPrice = "500", ItemSellPrice = "50", ItemIdClone = "235023500", BitNumber = "1300"};
        public static readonly Item GuaranteedSpecialSummonTicket_106212670 = new Item { Name = "Guaranteed 5★ Special Summon Ticket", ItemId = "106212670", Description = "★5確定SP召喚チケット2020/2", EquipmentRarity = "8", CountId = "1377", IsPotUnit = "5", KeyName = "0", ItemStack = "99999", ItemBuyPrice = "100000", ItemSellPrice = "10000", ItemIdClone = "106212200", BitNumber = "1296"};
        public static readonly Item ExchangeTicketWCABBR = new Item { Name = "5★ Exchange Ticket [W.C.A/B.B.R]", ItemId = "1209001248", Description = "5★ Exchange Ticket [W.C.A/B.B.R]", EquipmentRarity = "8", CountId = "9537", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001248", BitNumber = "9520"};
        public static readonly Item GuaranteedFeaturedTicketWCABBR = new Item { Name = "5★ Guaranteed (20% Featured) Ticket [W.C.A/B.B.R]", ItemId = "1209001249", Description = "5★ Guaranteed (20% Featured) Ticket [W.C.A/B.B.R]", EquipmentRarity = "8", CountId = "9538", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001249", BitNumber = "9521"};
        public static readonly Item SummonCoinWCABBR = new Item { Name = "Summon Coin (W.C.A/B.B.R)", ItemId = "1209001250", Description = "Summon Coin (W.C.A/B.B.R)", EquipmentRarity = "8", CountId = "9539", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "10", ItemIdClone = "1209001250", BitNumber = "9522"};
        public static readonly Item NextEraIIIExchangeTicket = new Item { Name = "Next Era III 5★ Exchange Ticket", ItemId = "1209001261", Description = "Next Era III 5★ Exchange Ticket", EquipmentRarity = "8", CountId = "9549", IsPotUnit = "0", KeyName = "0", ItemStack = "9999", ItemBuyPrice = "10", ItemSellPrice = "1000", ItemIdClone = "1209001261", BitNumber = "9549"};

		public static readonly List<Item> Items = new List<Item>
		{
           Potion,
           HiPotion,
           XPotion,
           Ether,
           TurboEther,
           Elixir,
           PhoenixDown,
           Antidote,
           EyeDrops,
           SmellingSalts,
           EchoHerbs,
           UnicornHorn,
           Vaccine,
           GoldNeedle,
           Remedy,
           Hyper,
           LightCurtain,
           LunarCurtain,
           HealingSpring,
           SmokeScreen,
           BodyBoost,
           ManaTablet,
           ProtectDrink,
           ShellDrink,
           BacchussWine,
           HeroDrink,
           GiantsDrink,
           BombFragment,
           BombArm,
           AntarcticWind,
           ArcticWind,
           ZeussWrath,
           HeavenlyWrath,
           FishScale,
           DragonScale_104003200,
           GiantFeather,
           WyvernFeather,
           EarthDrum,
           GaiasCry,
           RedFang,
           WhiteFang,
           BlueFang,
           HolyTorch,
           Grenade,
           FragGrenade,
           Shuriken,
           FumaShuriken,
           Pinwheel,
           Tent,
           MagicKey,
           StarQuartz,
           MagiciteShard,
           Magicite,
           RedMagicite,
           BlueMagicite,
           GreenMagicite,
           WhiteMagicite,
           BlackMagicite,
           RedMegacite,
           BlueMegacite,
           GreenMegacite,
           WhiteMegacite,
           BlackMegacite,
           EarthKey_109201000,
           EarthKey_109201010,
           EarthKey_109201020,
           EarthKey_109201030,
           EarthKey_109201040,
           EarthKey_109201050,
           EarthKey_109201060,
           EarthKey_109201070,
           EarthKey_109201080,
           EarthKey_109201090,
           EarthKey_109201100,
           EarthKey_109201110,
           EarthKey_109201120,
           EarthKey_109201130,
           EarthKey_109201140,
           EarthKey_109201150,
           EarthKey_109201160,
           EarthKey_109201170,
           EarthKey_109201180,
           EarthKey_109201190,
           EarthKey_109201200,
           EarthKey_109201210,
           EarthKey_109201220,
           EarthKey_109201230,
           EarthKey_109201240,
           FireCryst,
           IceCryst,
           LightningCryst,
           WaterCryst,
           EarthCryst,
           WindCryst,
           LightCryst,
           DarkCryst,
           FireMegacryst,
           IceMegacryst,
           LightningMegacryst,
           WaterMegacryst,
           EarthMegacryst,
           WindMegacryst,
           LightMegacryst,
           DarkMegacryst,
           LifeOrb,
           FarplaneSoul,
           GaiasTear,
           ThickenedHide,
           RaptorFeather,
           ChromaticOoze,
           DemonTail,
           BrokenBlade_202000800,
           DigitalCircuit,
           DragonFang,
           Glowseeds,
           Spellsilk,
           QualityStone,
           GummyOil,
           GreenFluid,
           OtherworldlyBone,
           AbominableWing,
           ToughScale,
           CursedTusk,
           WizardStone,
           PolymerEmulsion,
           DragonScale_202002200,
           ElementalTear,
           RockbeetleHusk,
           SparklingStone,
           Screamroot,
           CorpseFly,
           CopperOre,
           IronOre,
           SilverOre,
           MythrilOre,
           Lumber,
           Alcryst,
           FineAlcryst,
           BeastMeat,
           PearlofWisdom,
           AllurePowder,
           Litrock,
           SeedofLife,
           CrimsonTear,
           MysticOre,
           AquaPearl,
           LuminousHorn,
           QualityParts,
           RainbowNeedle,
           GoldenEgg,
           BookofRuin,
           EarthsCore,
           HeavensAsh,
           DeepseaBloom,
           ScriptureofTime,
           FarplaneDew,
           Spiritsand,
           GodsReliquary,
           DragonHeart,
           EspersTear,
           TalmoniteofLife,
           EsperShard,
           EsperCryst,
           SacredCrystal,
           HolyCrystal,
           YellowMagicite,
           OrangeMagicite,
           VioletMagicite,
           YellowMegacite,
           OrangeMegacite,
           VioletMegacite,
           GalleanTins,
           PlayMoney,
           GaleKey_109202000,
           GaleKey_109202010,
           GaleKey_109202020,
           GaleKey_109202030,
           GaleKey_109202040,
           GaleKey_109202050,
           GaleKey_109202060,
           GaleKey_109202070,
           GaleKey_109202080,
           GaleKey_109202090,
           HardPebble,
           PureStone,
           LazarethsNote,
           IrissNote,
           IvansNote,
           OlgasNote,
           FinnithsNote,
           DrakeHeart,
           DrakeOre,
           DrakeSphere,
           DrakeFang,
           FarplaneMineral,
           DeathStone,
           DemonHorn,
           DivineCrystal,
           FairiesWrit,
           RainbowBloom,
           CalamityGem,
           PrismaticHorn,
           CalamityWrit,
           AuraciteShard,
           BugrossOre,
           UlricIron,
           CoreDust,
           AbyssPearl,
           PantherFang,
           DemonWing,
           AncientStone,
           TrochoidGear,
           Uraninite,
           IridiumPlug,
           ParaffinOil,
           CrystalOscillator,
           Perovskite,
           EntrancingTail,
           MenacingWings,
           HardRock,
           FurySeed,
           WickedDrop,
           BrilliantRay,
           LuckySeedling,
           BizarreBox,
           MassiveStone,
           DemonHeart_1000000001,
           VoidVessel,
           FineFlour,
           LotusSeedPaste,
           BrownEgg,
           CoarseRockSugar,
           Mogcake,
           StandardMogcakeBox,
           RareMogcakeBox,
           PremiumMogcakeBox,
           Phantoma,
           Candy,
           WhitePhantoma,
           ScrollofAcumen,
           ScrollofVigor,
           CavernOre,
           YPotion,
           MegaEther,
           StainlessSteel,
           BloodAlcryst,
           BloodStone,
           SurvivorsFlask,
           CandyCorn,
           Karma,
           MeteorFragment,
           MeteorShards,
           MeteorStones,
           MeteorRock,
           MeteorOre,
           MedicinalHerb,
           SuperiorMedicine,
           YggdrasilDew,
           MagicWater,
           SagesElixir,
           YggdrasilLeaf,
           FlameringKey_109203000,
           FlameringKey_109203010,
           FlameringKey_109203020,
           FlameringKey_109203030,
           FlameringKey_109203040,
           FlameringKey_109203050,
           FlameringKey_109203060,
           FlameringKey_109203070,
           FlameringKey_109203080,
           FlameringKey_109203090,
           AuroraKey_109204000,
           AuroraKey_109204010,
           AuroraKey_109204020,
           AuroraKey_109204030,
           AuroraKey_109204040,
           AuroraKey_109204050,
           AuroraKey_109204060,
           AuroraKey_109204070,
           AuroraKey_109204080,
           AuroraKey_109204090,
           BlackKey_109205000,
           BlackKey_109205010,
           BlackKey_109205020,
           BlackKey_109205030,
           BlackKey_109205040,
           BlackKey_109205050,
           BlackKey_109205060,
           BlackKey_109205070,
           BlackKey_109205080,
           BlackKey_109205090,
           RedOrb,
           RatTail,
           GoldCoin,
           GoldOre,
           BluePhantoma,
           KoltzStar,
           HopeDiamond,
           FlamingBlood,
           ImperialGrenade,
           IfritRaidCoin,
           HermitsTeachings,
           StarMote,
           SwordsmanshipNotes,
           DesertMineral,
           OldJungleTree,
           MiraculousThread,
           HideoftheGuardian,
           SeedofIllusions,
           AncientWritings,
           HighgradeArmorOil,
           MysteriousDrop,
           AlterBlade,
           DreamBlossom,
           QualityGoldDust,
           Fish,
           WhiteAlcryst,
           WhiteMilcryst,
           WhiteHeavicryst,
           WhiteGiancryst,
           WhitePurecryst,
           BlackAlcryst,
           BlackMilcryst,
           BlackHeavicryst,
           BlackGiancryst,
           BlackPurecryst,
           GreenAlcryst,
           GreenMilcryst,
           GreenHeavicryst,
           GreenGiancryst,
           GreenPurecryst,
           PowerAlcryst,
           PowerMilcryst,
           PowerHeavicryst,
           PowerGiancryst,
           PowerPurecryst,
           GuardAlcryst,
           GuardMilcryst,
           GuardHeavicryst,
           GuardGiancryst,
           GuardPurecryst,
           HealingAlcryst,
           HealingMilcryst,
           HealingHeavicryst,
           HealingGiancryst,
           HealingPurecryst,
           SupportAlcryst,
           SupportMilcryst,
           SupportHeavicryst,
           SupportGiancryst,
           SupportPurecryst,
           TechAlcryst,
           TechMilcryst,
           TechHeavicryst,
           TechGiancryst,
           TechPurecryst,
           StrengthOrb,
           PetrifyGrenade,
           SleepingPowder,
           UnderdogsSecret,
           BlueButterflyPowder,
           RedButterflyPowder,
           Mote,
           MusicalNote,
           Perfume,
           Lipstick,
           NailPolish,
           FacePowder,
           HairSpray_106302300,
           Chocolate,
           FinasChocolate,
           ShadowLordCoin,
           WhiteOrb,
           KingMogCoin,
           FangofWind,
           collab_106301700,
           collab_106301710,
           MemoryCandy,
           collab_106302500,
           thScaleSoldier,
           BreathofLife,
           TwilightStone,
           DuskJewel,
           DarkOre,
           TranquilStone,
           SilverChunk,
           BlessingNeedle,
           CursedSphere,
           SacredBranch,
           GloryBug,
           AntiqueBone,
           PinkScale,
           DawnShell,
           AchromaticBlossom,
           WhiteTail,
           DewBlossom,
           WhiteMetal,
           WhiteDrakesFeather,
           WhiteTome,
           WhiteSlate,
           BlueBeastsShell,
           BlueBeastsBone,
           BlueBeastsClaw,
           BlueBeastPieceI,
           SeaDrakesScale,
           SeaDrakesBone,
           SeaDrakesClaw,
           SeaDrakePieceI,
           RageDrakesSkin,
           RageDrakesBone,
           RageDrakesFang,
           RageDrakePieceI,
           RedBeastsShell,
           RedBeastsBone,
           RedBeastsClaw,
           WolfDrakesBone,
           WolfDrakesClaw,
           WolfDrakesShell,
           WhiteFeather,
           RedFeather,
           QualitySugar,
           DeliciousWater,
           CrimsonWing_215000100,
           AshScale,
           MysteriousMineral,
           AncientMedicine,
           BlessedStone,
           RuinGem,
           HairSpray_106302600,
           RedEgg,
           BlueEgg,
           RainbowEgg,
           MetalEgg,
           CrystalEggofPower,
           CrystalEggofMind,
           ShadowBahamutGem,
           ShadowBahamutScale,
           ShadowBahamutJade,
           ShadowBahamutWing,
           ShadowBahamutHeart,
           ShadowBahamutsOre,
           ShadowBahamutFang,
           BahamutRaidCoin,
           ShardofKelsus,
           SealedBox,
           CrimsonWing_216000800,
           AzureCorundum,
           MiasmaChunk,
           AetherochemicalFiber,
           CorruptWeed,
           TitanCoin,
           Relic,
           RandomMagicite,
           RandomMegacryst,
           RandomAwakeningMaterial,
           MinorScrollofHealing,
           GreaterScrollofHealing,
           MinorScrollofRecovery,
           GreaterScrollofRecovery,
           ProtagonistHalo,
           PotionofDeception,
           PotionofCleansing,
           PotionofElementalResistance,
           MinorPotionofRejuvenation,
           PotionofRejuvenation,
           GreaterPotionofRejuvenation,
           RandomConsumable,
           RandomMegacite,
           RandomMilcryst,
           RandomHeavicryst,
           RandomGiancryst,
           CrimsonOre,
           MetalGigantuarCoin_1209000832,
           SummonTicket,
           ThankYouCandy,
           ContestRaidCoin,
           DebasedCoin,
           Ticket,
           EngelsRaidCoin,
           AlBhedPrimer,
           TwilightFeather,
           PureThread,
           WornBlueprint,
           SteelBone,
           BlackOil,
           MagicParts,
           BrokenCircuit,
           RustedLump,
           TitaniumAlloy,
           BlackPearl,
           MeteorLight,
           BlackBox,
           Hairpin,
           MagmaRockFragments,
           MusicalGem,
           MetalGigantuarCoin_1209000837,
           Lantern,
           MetalGigantuarCoin_1209000839,
           MetalGigantuarCoin_1209000847,
           MetalGigantuarCoin_1209000848,
           SkeletonKey,
           RamseysPillow,
           MonkeyBaby,
           EsperOre,
           RedEsperOre,
           BlueEsperOre,
           GreenEsperOre,
           WhiteEsperOre,
           BlackEsperOre,
           YellowEsperOre,
           OrangeEsperOre,
           VioletEsperOre,
           CrimsonGem,
           GarudaRaidCoin,
           MAXManipleRaidCoin,
           UrutanFlower,
           CharybdisRaidCoin,
           PinkTail,
           NianBeastRaidCoin,
           EtchedCoin,
           JieRevorseRaidCoin,
           TrainingBokken,
           RedSupercite,
           BlueSupercite,
           GreenSupercite,
           WhiteSupercite,
           BlackSupercite,
           YellowSupercite,
           OrangeSupercite,
           VioletSupercite,
           SectoredCircleBlue_109301000,
           SectoredCircleBlue_109301010,
           SectoredCircleBlue_109301020,
           SectoredCircleBlue_109301030,
           SectoredCircleBlue_109301040,
           SectoredCircleBlue_109301050,
           CorrosivePowder,
           EarthGemstone,
           LaserSensor,
           MythrilShaft,
           ElectrolyticCondenser,
           IronShavings,
           MetalScrap,
           DarkMatterFragment,
           SnowCrystal,
           FairyWing,
           BugFeeler,
           GhoulBone,
           MonsterFiber,
           MagicEgg,
           DemonHeart_219000200,
           LotusFang,
           BloodiedBone,
           GreyPelt,
           RottenMeat,
           PhilosophersStone,
           Moonstone,
           SmithyHammer,
           VelvetRibbon,
           CarbonFiber,
           Iron,
           MusicalCoin,
           PurpleNailPolish,
           PurpleLipstick,
           PurpleHairSpray,
           PurplePerfume,
           CDAlbum,
           GlitteringShard,
           CandyCane,
           GlowingStar,
           KhalamMedal,
           RoyalFireOrb,
           RoyalEarthOrb,
           RoyalWindOrb,
           RoyalWaterOrb,
           RoyalDarkOrb,
           RoyalLightOrb,
           Regalite,
           TungOil,
           MoonJade,
           SunJade,
           FireOpal,
           RedFlax,
           GoldFlax,
           YellowDisk,
           GunmetalAlloy_1209000866,
           SealedTreasure,
           GlitzGem_1209000868,
           DenseOre_1209000869,
           Gunpowder_1209000870,
           MillionDownloadsTicket_1209000871,
           PetalToken,
           BlueandRedSupercites,
           VioletandYellowSupercites,
           OrangeandWhiteSupercites,
           GreenandBlackSupercites,
           FinasChocolateII,
           SakurasChocolate,
           LidsChocolate,
           RicosChocolate,
           ElegantCandy,
           MegaPhoenix,
           ChilledFoodTin,
           StarCurtain,
           BlessedFlag,
           ConquerorsGavelAttack,
           ConquerorsGavelDefense,
           InvigoratingPotionI,
           AzureGem,
           UnitExchangeTicketBonus,
           ndAnniversaryRaidCoin,
           TripleTriadCard,
           EstarkRaidCoin,
           FadedCrystal,
           GraverobberRaidCoin,
           EmptyMagicFlask,
           BarbarossaRaidCoin,
           EverfrostShard,
           ManaBeastRaidCoin,
           KnowingTag,
           SilversmithRaidCoin,
           FangofEarth,
           SectoredCircleYellow_109302000,
           SectoredCircleYellow_109302010,
           SectoredCircleYellow_109302020,
           SectoredCircleYellow_109302030,
           SectoredCircleYellow_109302040,
           SectoredCircleYellow_109302050,
           TrustMooglesMap,
           MegacrystsMap,
           RankEXPMap,
           MaterialsMap,
           StarQuartzMap,
           AdamantiteLump,
           IllusionStone,
           RainbowFeather,
           OrangeGem,
           StrangePurpleLiquid,
           MonsterClaw,
           MedicinalBark,
           IceAlcryst,
           SnowTree,
           WhiteGemcryst,
           CrimsonSilk,
           CrimsonHide,
           LapisLazuli,
           NecklessDoll,
           BurgundyFlask,
           Nightshade,
           BaseMetal,
           MinimumHammer,
           BrilliantJam,
           FaerieNut,
           MedicalRoot,
           WeatheredWood,
           GlitzGem_224000100,
           GunmetalAlloy_224000200,
           SealedTreasureChest,
           DenseOre_224000400,
           Gunpowder_224000500,
           LightningsPrism,
           RamzasPrism,
           DelitasPrism,
           DarkKnightCecilsPrism,
           AcesPrism,
           LunethsPrism,
           QueensPrism,
           DarkFinasPrism,
           OrlandeausPrism,
           MariesPrism,
           EmperorsPrism,
           AileensPrism,
           RemsPrism,
           TidussPrism,
           WilhelmsPrism,
           SeabreezeDarkFinasPrism,
           TranceTerrasPrism,
           FohlensPrism,
           VeritasoftheDarksPrism,
           SquallsPrism,
           RinoasPrism,
           OnionKnightsPrism,
           NalusPrism,
           EstarksPrism,
           MarquisdeLonsPrism,
           DragonlordsPrism,
           LividShantottosPrism,
           ShadowLordsPrism,
           LunerasPrism,
           PrishesPrism,
           MercenaryRamzasPrism,
           KnightDelitasPrism,
           CloudsPrism,
           VeritasoftheFlamesPrism,
           LorensPrism,
           VeritasoftheLightsPrism,
           NoctissPrism,
           BeatrixsPrism,
           EikosPrism,
           HyohsPrism,
           SantaRoseliasPrism,
           IgnissPrism,
           RayJacksPrism,
           BalthiersPrism,
           GilgameshsPrism,
           AyakasPrism,
           ElfreedasPrism,
           RoysPrism,
           GladiolussPrism,
           DukesPrism,
           PyroGlacialLasswellsPrism,
           YunasPrism,
           LulusPrism,
           BlossomSageSakurasPrism,
           LotusMageFinasPrism,
           AraneasPrism,
           PromptosPrism,
           KunshirasPrism,
           CitrasPrism,
           LennethsPrism,
           FreyasVPPrism,
           ArngrimsPrism,
           TifasPrism,
           VincentsPrism,
           NyxsPrism,
           JiraiyasPrism,
           GabranthsPrism,
           BaschsPrism,
           NamelessGunnerJakesPrism,
           EmperorSherasPrism,
           PureSummonerRydiasPrism,
           AtoningDragoonKainsPrism,
           HeavenlyTechnicianLidsPrism,
           MedienasPrism,
           SephirothsPrism,
           LilasPrism,
           MaritimeStrategistNicholsPrism,
           RaegansPrism,
           AwakenedRainsPrism,
           ElephimsPrism,
           FlammiesPrism,
           RandisPrism,
           KevinsPrism,
           LisesPrism,
           HawkeyesPrism,
           MachinasPrism,
           KurasamesPrism,
           SieghardsPrism,
           YuraishasPrism,
           OnionKnightRefiasPrism,
           DarkKnightLunethsPrism,
           OlivesPrism,
           RebertasPrism,
           BarbaricciasPrism,
           ZargabaathsPrism,
           ElvenCrystal,
           ManufacturedWood,
           ScarletOrb,
           BlackThread,
           ScarletHide,
           GreyFeathers,
           ScarletEgg,
           BavariumDust,
           BavariumOre,
           BavariumShard,
           RefinedBavarium,
           BavariumCoin,
           ndAnniversaryMedal,
           ndAnniversaryTicket,
           PlayersVoiceTicketPart_1209000891,
           PlayersVoiceTicketPart_1209000892,
           FFBEHeroesCoin,
           NanoSeeds,
           NanoShard,
           NanoCrystal,
           NanoCore,
           Hypostim,
           AdamJensensPrism,
           ViktorMarchenkosPrism,
           Conch,
           TurretShell,
           CowryShell,
           RainbowShell,
           SummerSummonTicket,
           SummerStone,
           SeasideNicholsPrism,
           AlohaLasswellsPrism,
           MalphasiesPrism,
           CircesPrism,
           HatredRaidCoin,
           DecayedSeeds,
           BurntShard,
           DullCrystal,
           DarkCore,
           CorruptedStone,
           WickedRoots,
           LockofBlackHair,
           PumpkinCandy,
           SpecialFFXVTicket,
           DemonRainsPrism,
           DracuLasswellsPrism,
           GrimLordSakurasPrism,
           RedVial,
           HalloweenSummonTicket,
           LilithsPrism,
           LuciusPrism,
           ConquerorsGavelMagic,
           XenogearsLimitedExchangeTicketFEB,
           GuaranteedSpecialSummonTicket_106211170,
           XenogearsLimitedExchangeTicketFEBCM,
           GElementsRaidCoin,
           BlankSphere,
           DeusRaidCoin,
           GilMap,
           GoldBullion,
           VioletLumber,
           CrimsonCloth,
           EarthenScale,
           EbonyFang,
           MidorisRing,
           SteelLump,
           BlackLeather,
           SmokyGemstone,
           AzureFragment,
           FolkasPrism,
           FeisPrism,
           EllysPrism,
           BartsPrism,
           JechtsPrism,
           AuronsPrism,
           IgnaciosPrism,
           CitansPrism,
           MariasPrism,
           MillionDownloadsTicket_1209000923,
           RedCloth,
           CursedNeedle,
           BlackAsh,
           PureBlood,
           BlackGrimoire,
           FryeviasPrism,
           BsPrism,
           A2sPrism,
           BerylsPrism,
           EllesperissPrism,
           AuroraFryeviasPrism,
           FanFestaSummonTicket,
           CrimsonDragonScale,
           PopstarKatysPrism,
           FanFestaSelectTicket,
           FelixsPrism,
           TianasPrism,
           WinterSummonTicket,
           GiftBow,
           WhiteKnightNoelsPrism,
           ChristinesPrism,
           KrylasPrism,
           ConquerorsGavelSpirit,
           ConquerorsGavelAttackandMagic,
           GuardArmorRaidCoin,
           DarkMatter_235004100,
           SerenityPower,
           FuryStone,
           PowerStone,
           MythrilStone,
           CloudKHsPrism,
           SorasPrism,
           SophiasPrism,
           FaytsPrism,
           RenasPrism,
           ExploringtheMoogleCave,
           STAROCEANANAMNESISTicket,
           CopperCoin,
           BronzeIngot,
           SilverIngot,
           GoldenIngot,
           GlassIngot,
           YunsPrism,
           ChowsPrism,
           AngsPrism,
           QinsPrism,
           BaiHuZhuQuesPrism,
           MyrasPrism,
           RuinationRaidCoin,
           RancidSeeds,
           FragileShard,
           FallenGem,
           DamagedCore,
           JinxedStone,
           EntangledRoots,
           BundleofPurpleThread,
           FanFestaToken,
           SpecialBatchTicket,
           FanFestaPremiumSummonTicket,
           OrientationControlUnit,
           LevistoneFragment,
           ThickSailcloth,
           Galesilk,
           MidnightWings,
           GlobalExchangeTicket,
           CidsPrism,
           GuaranteedFeaturedTicket,
           SpecialBatchTicketSG,
           GuaranteedSpecialSummonTicket_1209000947,
           KarlettesPrism,
           Sunstone,
           EggCoin,
           EsthersPrism,
           SylviesPrism,
           GuaranteedFeaturedTicketFFT,
           GuaranteedSpecialSummonTicket_1209000957,
           BlueOrb,
           HighSeraphUltimasPrism,
           BeowulfsPrism,
           SpecialBatchTicketBL,
           YoungLadysDiary,
           TwilightDesertHerb,
           CloudyWhiteCloth,
           FleetFootedBirdsTailFeather,
           ScorpionStone,
           CrimsonsPrism,
           WaterBookofMagic,
           SpringSummonTicket,
           GuaranteedFeaturedTicketSpring,
           GuaranteedSummonTicketERTMR,
           GuaranteedSummonTicketAUTMR,
           ZenooftheBetaStarsPrism,
           GuaranteedSpecialSummonTicket_1209000964,
           BlackMageGolbezsPrism,
           GuaranteedBlackMageGolbezTicket_1209000967,
           GuaranteedBlackMageGolbezTicket_1209000968,
           GuaranteedBlackMageGolbezTicket_1209000969,
           GuaranteedNagiTicket_1209000970,
           GuaranteedNagiTicket_1209000971,
           GuaranteedYegoTicket_1209000972,
           GuaranteedYegoTicket_1209000973,
           BlackFabric,
           WhiteGem,
           ShisoPowder,
           GrassbeastFang,
           OldTreeSeedShell,
           AkstarsPrism,
           GuaranteedFeaturedTicketAZ,
           DefenseSystemRaidCoin,
           GoldCircuit,
           HandlessClockFace,
           ChargedFilament,
           CopperBolt,
           BrokenGear,
           NagisPrism,
           YegosPrism,
           GuaranteedSpecialSummonTicket_106211230,
           GuaranteedSpecialSummonTicket_106211220,
           KingEdgarofFigarosPrism,
           MonkSabinofKoltssPrism,
           Walnut,
           SummonCoinFFVIMay,
           SummonCoinFFBEMay,
           GuaranteedFeaturedTicketFFVI,
           AmberGem,
           IceBookofMagic,
           SectoredCircleGreen_109303000,
           SectoredCircleGreen_109303010,
           SectoredCircleGreen_109303020,
           SectoredCircleGreen_109303030,
           SectoredCircleGreen_109303040,
           SectoredCircleGreen_109303050,
           GuaranteedSummonTicketUSTMR,
           GuaranteedFeaturedTicketSummer,
           ExchangeCoinLoginSummer,
           SummonCoinSummerMay,
           SummerFinaLidPrism,
           SummerFolkaCitraPrism,
           SecretToolbox,
           RustyMetalParts,
           ResearchersNotes,
           HomemadeLubricant,
           MagneticNeedle,
           ReginasPrism,
           GuaranteedReginaTicket,
           AerithsPrism,
           RedXIIIsPrism,
           BECoupon,
           ImmortalFlameKatysPrism,
           FrostFragment,
           GuaranteedFeaturedTicketFFVII,
           PremiumSummonTicketFFVII,
           PremiumSummonTicketrdAnniv,
           rdAnniversaryMedal,
           SummonCoinrdAnnivCountdown,
           CollectionofManaLimitedTimeExchangeTicketFR,
           GuaranteedSummonTicketFlyingBlades,
           KimonoAyakasPrism,
           DressyAileensPrism,
           PlayersVoiceTicketPart_1209000989,
           PlayersVoiceTicketPart_1209000990,
           rdAnniversaryTicket,
           GuaranteedFeaturedTicketKADA,
           SummonCoinKAyakaDAileen,
           SummonCoinrdAnnivSummon,
           ExchangeCoinComebackQuests,
           ComebackSummonTicket_1209001009,
           EarthBookofMagic,
           FireBookofMagic,
           LightningBookofMagic,
           FightingPitsCoin,
           GuaranteedSpecialSummonTicket_106211280,
           GysahlSeeds,
           EpicGuaranteedSummonTicketHeroes,
           EpicGuaranteedSummonTicketSwornSix,
           SuperTrustMoogleExchangeTicket,
           MagicSilverIngot,
           SilverHilt,
           SeawolfFang,
           SilverGrayLog,
           SilverOrb,
           SacredShieldCharlottesPrism,
           GuaranteedSummonTicketFanFesta,
           DachaoRaidCoin,
           LiquidMako,
           Flywheel,
           NamelessFlower,
           SteelJoint,
           Digestive,
           ZacksPrism,
           YuffiesPrism,
           GuaranteedFeaturedTicketYZ,
           SummonCoinrdAnnivSummonII,
           GuaranteedSummonTicketFFVII,
           SummonCoinElenaMorgana,
           ElenasPrism,
           GuaranteedFeaturedTicketEM,
           MorganasPrism,
           RedStarQuartz,
           AmethystShards,
           AmethystCoin,
           EnlightenmentPoints,
           DiamondEnlightenmentKey,
           GoldEnlightenmentKey,
           SilverEnlightenmentKey,
           BronzeEnlightenmentKey,
           RiverasPrism,
           KingGoldenBombRaidCoin,
           SnowWhiteFlower,
           FestivePetals,
           BeautifulPurpleCloth,
           InvitingPerfume,
           VioletSilkThread,
           SummonCoinRLightningNHope,
           GuaranteedFeaturedTicketRLightningNHope,
           AnniversaryFollowUpTicket,
           AnniversaryFollowUpCoin,
           RadiantLightningsPrism,
           NeverendingHopesPrism,
           GuaranteedSpecialSummonTicket_106211310,
           CreditChip,
           SummonCoinAnnivFollowUp,
           BlazingStone,
           BlazingCoin,
           TsukikosPrism,
           KaitosPrism,
           GuaranteedFeaturedTicketKT,
           SummonCoinKaitoTsukiko,
           GuaranteedFeaturedTicketEndofSummer,
           SummonCoinEndofSummer,
           KimonoFinasPrism,
           GastonsRaidCoin,
           SunlandsSilk,
           SteelIngot,
           DesertBranch,
           RedMineral,
           BlueMineral,
           PrimrosesPrism,
           OlbericsPrism,
           OCTOPATHTRAVELERLimitedTimeExchangeTicketPO,
           ExchangeCoinEnhancedUnits,
           ExchangeCoinEUTrustMoogle,
           WarriorofLightBartzsPrism,
           WarriorofLightLennasPrism,
           DragonGrass,
           GuaranteedSpecialSummonTicket_106211320,
           LargeBodyRaidCoin,
           OrichalcumKH,
           BreathofWind,
           DazzlingStone,
           ThunderGem,
           FrostShard,
           GuaranteedFeaturedTicketWOLBartzWOLLenna,
           SummonCoinWOLBartzWOLLenna,
           MDLStepUpSummonTicket,
           MDLGuaranteedStepUpSummonTicket,
           RikusPrism,
           SephirothKHsPrism,
           SolsPrism,
           LifestoneOre,
           GoldenDevilTail,
           LightEatingBlackCrystal,
           MeteoriteFragment,
           CosmoPowder,
           GuaranteedSpecialSummonTicket_106211390,
           LovelyKatysPrism,
           AIKatysPrism,
           MDLRaffleTicket,
           MDLFestiveRaffleTicket,
           SummonCoinSoraCloudKH,
           SummonCoinRikuSephirothKH,
           GuaranteedFeaturedTicketSoraCloudKH,
           GuaranteedFeaturedTicketRikuSephirothKH,
           MordegonsPrism,
           ElevensPrism,
           VeronicasPrism,
           SerenasPrism,
           DrasilanGuinea,
           GuaranteedSpecialSummonTicket_106211910,
           DQXISSpecialUnitSummoningKeySilver_106211880,
           DQXISSpecialUnitSummoningKeyGold_106211890,
           SummonCoinEVS,
           WildRoseFirionsPrism,
           DarkKnightLeonsPrism,
           WildRose,
           SummonCoinWRFirionDKLeon,
           GuaranteedFeaturedTicketFFII,
           SummonCoinMDLCelebration,
           WarriorofLightKrilesPrism,
           DarkMageExdeathsPrism,
           WarriorofDawnGalufsPrism,
           AtomosRaidCoin,
           PoisonousFang,
           BlackYarn,
           BlackLumber,
           FusedStone,
           MetalRing,
           ChocoboFinasPrism,
           SummonCoinSelectExchangeSummon,
           EnergizingShot,
           RestorativeShot,
           CPRKit,
           BlightStone,
           UnderworldFare,
           GuaranteedFeaturedTicketKG,
           SummonCoinKartenGodrea,
           SummonCoinSpooktacular,
           SpooktacularSlotsToken,
           KartensPrism,
           GodreasPrism,
           SummonCoinAKefkaAShadow,
           GuaranteedFeaturedTicketAKefkaAShadow,
           NamelessKatanasHilt,
           JesterWoodblockPrint,
           CityCamouflage,
           LumpofDarksteel,
           TwinCrystals,
           AssassinShadowsPrism,
           ArchmageKefkasPrism,
           AirForceRaidCoin,
           GiveawayParticipationTicket,
           GiveawayBonusTicket,
           CrimsonHandWovenCloth,
           ShiningMagicalThread,
           BrilliantScarletFeather,
           CrackedJewel,
           SkyBlueStone,
           AldoreKingRainsPrism,
           GuaranteedCompensationTicket,
           MagitekWarriorTerrasPrism,
           AdventurerLockesPrism,
           NarsheCoal,
           SummonCoinMWTerraALocke,
           GuaranteedFeaturedTicketMWTerraALocke,
           CrimsonSaberKey,
           PurpleLightningKey,
           ReincarnationKey,
           ComebackSummonTicket_1209001075,
           GuaranteedSpecialSummonTicket_106211360,
           DrasilianSovereign,
           BlueEye,
           PlatinumOre,
           Fatalistick,
           Mirrorstone,
           GlassFrit,
           SylvandosPrism,
           RabsPrism,
           JasperUnboundsPrism,
           EriksPrism,
           TheLordofShadowsPrism,
           JadesPrism,
           DQXISSpecialUnitSummoningKeyGold_1209001068,
           DQXISSpecialUnitSummoningKeySilver_1209001069,
           TreasureCoin,
           AgentOlivesPrism,
           MastermindXonsPrism,
           DoctorAidensPrism,
           OperativeZyrussPrism,
           GuaranteedFlexibleTicketAOliveMXon,
           GuaranteedFlexibleTicketOZyrusDAiden,
           AldoreWootzOre,
           GunganLacquerTree,
           DeluxeGunpowder,
           FluorineRubber,
           TeakLog,
           PhysalissPrism,
           FestiveSlotsToken,
           HollyJollyTicket,
           GuaranteedFlexibleTicketCPNoctisLunafreya,
           PremiumSummonTicketHollyJolly,
           UnitCoinAiden,
           UnitCoinAng,
           UnitCoinBaiHuZhuQue,
           UnitCoinChow,
           UnitCoinChristine,
           UnitCoinElena,
           UnitCoinEsther,
           UnitCoinFelix,
           UnitCoinFryevia,
           UnitCoinGodrea,
           UnitCoinKaito,
           UnitCoinKarten,
           UnitCoinKryla,
           UnitCoinLilith,
           UnitCoinLing,
           UnitCoinLucius,
           UnitCoinMorgana,
           UnitCoinOlive,
           UnitCoinQin,
           UnitCoinReberta,
           UnitCoinRivera,
           UnitCoinSylvie,
           UnitCoinTiana,
           UnitCoinTsukiko,
           UnitCoinWhiteKnightNoel,
           UnitCoinXon,
           UnitCoinYan,
           UnitCoinYun,
           UnitCoinZyrus,
           PopularityContestVotingTicket,
           CrownPrinceNoctissPrism,
           GentianasPrism,
           LunafreyasPrism,
           ArapaimaRoe,
           GuaranteedSpecialSummonTicket_106211520,
           BoxofRegalement,
           Snowball,
           PlasticJewel,
           WoodenBlocks,
           LevinsonsPrism,
           LucassPrism,
           GuaranteedFlexibleTicketLevinsonLucas,
           HolyNightAmeliaEmiliasPrism,
           WhiteLilyDarkFinasPrism,
           CrimsonLotusTear,
           PricelessStone,
           GoldPowder,
           PurpleEmulsion,
           TwistedBlackHorn,
           FreeDailySummonwithbonusTrustMoogleUnitspecificunlocked,
           SpecialVaultofHiddenTreasuresunlocked,
           FreeLapisSummonunlocked,
           FreeDailySummonunlocked,
           ImmortalKnightGarlandsPrism,
           AwakenedWarriorofLightsPrism,
           WarpCube,
           GuaranteedSpecialSummonTicket_106211450,
           GuaranteedFeaturedTicketArdynRegis,
           SummonCoinArdynRegis,
           BehemothKingRaidCoin,
           TrueBeastFur,
           BeastFur,
           SyntheticFiberCloth,
           DarkbladeHilt,
           ShadowTar,
           RedBeryl,
           ArdynsPrism,
           RegissPrism,
           HessKingLasswellsPrism,
           PurityFragment,
           DropofCourage,
           EngravedBlade,
           SmallMagicalOre,
           HighGradePowder,
           MetallicGel,
           SilkTwine,
           FortuneCookie,
           GoldenCoin,
           XuanWuQingLongsPrism,
           EmperorFoosPrism,
           LuckySlotsToken,
           GuaranteedFeaturedTicketXWQLEFoo,
           SummonCoinXWQLEFoo,
           LuckyYearoftheRatTicket,
           PremiumSummonTicketLunarNewYear,
           SuperTrustMoogleExchangeTicketx5Allplayers,
           FreeDailySummonEXTENSIONweekunlocked,
           BlueTome,
           BlueHolyHorn,
           BluePictureScroll,
           BlueMoonlightFlower,
           BlueSpellstone,
           GuaranteedResummonCompensationTicketSupport,
           GuaranteedResummonCompensationTicketAttacker,
           GuaranteedResummonCompensationTicketMage,
           ComebackSummonTicket_1209001134,
           GuaranteedSpecialSummonTicket_106211590,
           SilverApple,
           RedCube,
           BlueCube,
           DarkObsidian,
           WhiteMageRosasPrism,
           PalomPoromsPrism,
           PaladinCecilsPrism,
           GuaranteedFeaturedTicketPCecilPP,
           SummonCoinPCecilPP,
           SakuraAyakasPrism,
           SieghardIgnaciosPrism,
           SweetLukasPrism,
           SweetNicholsPrism,
           SweetSentimentsSummonTicket,
           GuaranteedFeaturedTicketSISA,
           SummonCoinSISA,
           GuaranteedFeaturedTicketSNicholSLuka,
           SummonCoinSNicholSLuka,
           PermaPremiumSummonTicket,
           BronzeHourglassFFIV,
           ChocolateRaidCoin,
           ChocoChunk,
           CacaoCore,
           ExchangeTicketAOKnightHein,
           GuaranteedFeaturedTicketAOKnightHein,
           SummonCoinAOKnightHein,
           Levigrass,
           GuaranteedSpecialSummonTicket_106211490,
           XandesPrism,
           HeinsPrism,
           AwakenedOnionKnightsPrism,
           MadamEdelsPrism,
           DarkQuartz,
           GoldenDragonHorn,
           GoldenBladeFragment,
           AncientWine,
           SilverDragonFang,
           GuaranteedFeaturedTicketMEdel,
           SummonCoinMEdel,
           SpringBlossomTicket,
           InvigoratingPotionII,
           InvigoratingPotionIII,
           EmeraldGem,
           VioletGem,
           LadyLilithRaidCoin,
           WizardessShantottosPrism,
           LilisettesPrism,
           LiminalResidue,
           DeviousDie,
           GoldIngot,
           CoinofRuin,
           CoinofBirth,
           MagicalMarchSummonTicket,
           ExchangeTicketWShantottoLilisette,
           GuaranteedFeaturedTicketWShantottoLilisette,
           SummonCoinWShantottoLilisette,
           SectoredCirclePurple_109304000,
           SectoredCirclePurple_109304010,
           SectoredCirclePurple_109304020,
           ExchangeTicketSPTidusYunalesca,
           GuaranteedFeaturedTicketSPTidusYunalesca,
           SummonCoinSPTidusYunalesca,
           SpringBreakTicket,
           KimahrisPrism,
           StarPlayerTidusPrism,
           YunalescasPrism,
           SpectralSphere,
           BlackAuxiliaryQuestKey,
           WhiteAuxiliaryQuestKey,
           GreenAuxiliaryQuestKey,
           BlueAuxiliaryQuestKey,
           GuaranteedSpecialSummonTicket_106211750,
           SummonCoinTYLAJ,
           ExchangeTicketFFXYRP,
           GuaranteedFeaturedTicketFFXYRP,
           SummonCoinFFXYRP,
           DailyCoin,
           Amber,
           RikkuFFXsPrism,
           YunaFFXsPrism,
           PainesPrism,
           Lazulite,
           Calcite,
           WhiteCube,
           BlackCube,
           Omniprism,
           FMABROTHERHOODRaidCoin,
           SilverDial,
           GlassFlask,
           AutomailScrew,
           GreenCloth,
           MechanicalGear,
           ExchangeTicketEdwardEAlphonseE,
           GuaranteedFeaturedTicketEdwardEAlphonseE,
           SummonCoinEdwardEAlphonseE,
           ExchangeTicketKBradleyRMustang,
           GuaranteedFeaturedTicketKBradleyRMustang,
           SummonCoinKBradleyRMustang,
           RoyMustangsPrism,
           KingBradleysPrism,
           EdwardElricsPrism,
           AlphonseElricsPrism,
           RakishThiefZidanesPrism,
           DragonKnightFreyasPrism,
           BlackMageVivisPrism,
           StrangeGourmandQuinasPrism,
           DracozombiesTalon,
           ExchangeTicketRTZDKFBMV,
           GuaranteedFeaturedTicketRTZDKFBMV,
           SummonCoinRTZDKFBMV,
           SummonCoinBeatrixEiko,
           GuaranteedSpecialSummonTicket_106211680,
           SakuraoftheDeltaStarsPrism,
           NicholoftheEpsilonStarsPrism,
           ExchangeTicketSakuraDSNicholES,
           GuaranteedFeaturedTicketSakuraDSNicholES,
           SummonCoinSakuraDSNicholES,
           GuaranteedFeaturedTicketGilgameshWOTVFFBE,
           SummonCoinGilgameshWOTVFFBE,
           GilgameshWOTVFFBEsPrism,
           AntiParticleCore,
           MagicalSteelBolt,
           DoubleRubberRing,
           StripeDyedCloth,
           MagicalSteelGears,
           EggceptionalTicket,
           EsperMagicCryst,
           RedEsperLucidite,
           NobleRedEsperLucidite,
           InfernalFireRainsPrism,
           DarkSpiritSolsPrism,
           ExchangeTicketIFRainDSSol,
           GuaranteedFeaturedTicketIFRainDSSol,
           SummonCoinIFRainDSSol,
           DarkVisionsArrivalTicket,
           DraconianPrincessFinasPrism,
           SupremeDevaAkstarsPrism,
           GuaranteedSpecialSummonTicket_106212020,
           YshtolatheSorceresssPrism,
           ExchangeTicketDPFinaSDAkstar,
           GuaranteedFeaturedTicketDPFinaSDAkstar,
           SummonCoinDPFinaSDAkstar,
           SummonCoinSpringAwakening,
           DXSummonTicket,
           DarkMatter_235018200,
           LezardValethsPrism,
           MystinasPrism,
           LokiRaidCoin,
           OrichalcumVP_235016300,
           OrichalcumVP_235016200,
           BookofEverlastingLife,
           BrokenBlade_235016600,
           EbonyPowder,
           FreshMeat,
           ExchangeTicketVALKYRIEPROFILELENNETH,
           GuaranteedFeaturedTicketVALKYRIEPROFILELENNETH,
           SummonCoinVALKYRIEPROFILELENNETH,
           VALKYRIEPROFILELENNETHLimitedExchangeTicketLFA,
           TifaFFVIIACsPrism,
           CloudFFVIIACsPrism,
           KadajsPrism,
           ChurchFlower,
           GuaranteedSpecialSummonTicket_106212200,
           ExchangeTicketFFVIIAC,
           GuaranteedFeaturedTicketFFVIIAC,
           SummonCoinFFVIIAC,
           ExchangeCoinFFVIIACU,
           ExchangeCoinFFVIIACP,
           BeginnersSelectTicket,
           BlueEsperLucidite,
           NobleBlueEsperLucidite,
           HallowedAegisCharlottesPrism,
           MysticalIceLasswellsPrism,
           FourWindsPhysalissPrism,
           WarHeroRaegensPrism,
           ExchangeTicketMILasswellHACharlotte,
           GuaranteedFeaturedTicketMILasswellHACharlotte,
           SummonCoinMILasswellHACharlotte,
           MayBundleTicket,
           DARKVISIONSSpecialQuestCoin,
           UntamedWolfEdelsPrism,
           ExchangeTicketWHRaegenFWPhysalis,
           GuaranteedFeaturedTicketWHRaegenFWPhysalis,
           SummonCoinWHRaegenFWPhysalis,
           DaughterofDestinyVanillesPrism,
           GracefulChampionFangsPrism,
           ExchangeTicketDODVanilleGCFang,
           GuaranteedFeaturedTicketDODVanilleGCFang,
           SummonCoinDODVanilleGCFang,
           DarkVisionsIITicket,
           HecatoncheirRaidCoin,
           OrangeOerbaYarn,
           BlueOerbaYarn,
           MetalParts,
           MedicinalOil,
           OtherworldlyLeather,
           LightningFFXIIIsPrism,
           SerahsPrism,
           NoelsPrism,
           PotentDroplet,
           AbyssalScale,
           TearofWoe,
           ExchangeTicketSerahNoel,
           GuaranteedFeaturedTicketSerahNoel,
           SummonCoinSerahNoel,
           GuaranteedSpecialSummonTicket_106212310,
           CollaborationFestivalCoin,
           CollaborationFestivalExchangeTicket,
           RicoRodriguezsPrism,
           ExchangeTicketLLSquallSeifer,
           GuaranteedFeaturedTicketLLSquallSeifer,
           SummonCoinLLSquallSeifer,
           QuistissPrism,
           SeifersPrism,
           LoneLionSquallsPrism,
           MoonStone,
           EnergyCrystal,
           LuvLuvG,
           GuaranteedSpecialSummonTicket_106212460,
           SelphiesPrism,
           IrvinesPrism,
           BlueMageFinasPrism,
           SorceresssKnightRaidCoin,
           RosettaStone,
           DynamoStone,
           StarFragment,
           SteelCurtain,
           CockatricePinion,
           ComebackSummonTicket_1209001272,
           ExchangeTicketSelphieIrvine,
           GuaranteedFeaturedTicketSelphieIrvine,
           SummonCoinSelphieIrvine,
           DarkVisionsIIITicket,
           FFBEthAnniversarySlotsToken,
           NextEraExchangeTicket,
           FFBEEquipmentExchangeTicket,
           ExchangeTicketWOTVSLKG,
           GuaranteedFeaturedTicketWOTVSLKG,
           SummonCoinWOTVSLKG,
           NextEraIIExchangeTicket,
           DXSummonTicketJuly,
           MontLeonissPrism,
           KitonesPrism,
           SterneLeonissPrism,
           WildCardAcesPrism,
           BenevolentBeautyRemsPrism,
           SteadfastSoldierMachinasPrism,
           RedPhantoma,
           BlankCard,
           GlaciesCodexFFTYPE,
           GuaranteedSpecialSummonTicket_106212670,
           ExchangeTicketWCABBR,
           GuaranteedFeaturedTicketWCABBR,
           SummonCoinWCABBR,
           NextEraIIIExchangeTicket,
		};
    }
}