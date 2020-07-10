using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class Recipe
    {
        public String Name { get; set; }
        public String RecipeBookId { get; set; }
        public String Description { get; set; }
        public String CountId { get; set; }
        public String Gil { get; set; }

        public static readonly Recipe Potion = new Recipe { Name = "Potion"};
        public static readonly Recipe HiPotion = new Recipe { Name = "Hi-Potion"};
        public static readonly Recipe Ether = new Recipe { Name = "Ether"};
        public static readonly Recipe Antidote = new Recipe { Name = "Antidote"};
        public static readonly Recipe EyeDrops = new Recipe { Name = "Eye Drops"};
        public static readonly Recipe SmellingSalts = new Recipe { Name = "Smelling Salts"};
        public static readonly Recipe EchoHerbs = new Recipe { Name = "Echo Herbs"};
        public static readonly Recipe UnicornHorn = new Recipe { Name = "Unicorn Horn"};
        public static readonly Recipe Vaccine = new Recipe { Name = "Vaccine"};
        public static readonly Recipe GoldNeedle = new Recipe { Name = "Gold Needle"};
        public static readonly Recipe Remedy = new Recipe { Name = "Remedy"};
        public static readonly Recipe Hyper = new Recipe { Name = "Hyper"};
        public static readonly Recipe HealingSpring = new Recipe { Name = "Healing Spring"};
        public static readonly Recipe SmokeScreen = new Recipe { Name = "Smoke Screen"};
        public static readonly Recipe BodyBoost = new Recipe { Name = "Body Boost"};
        public static readonly Recipe ManaTablet = new Recipe { Name = "Mana Tablet"};
        public static readonly Recipe ProtectDrink = new Recipe { Name = "Protect Drink"};
        public static readonly Recipe ShellDrink = new Recipe { Name = "Shell Drink"};
        public static readonly Recipe BacchussWine = new Recipe { Name = "Bacchus's Wine"};
        public static readonly Recipe Grenade = new Recipe { Name = "Grenade"};
        public static readonly Recipe FragGrenade = new Recipe { Name = "Frag Grenade"};
        public static readonly Recipe Shuriken = new Recipe { Name = "Shuriken"};
        public static readonly Recipe FumaShuriken = new Recipe { Name = "Fuma Shuriken"};
        public static readonly Recipe Tent = new Recipe { Name = "Tent"};
        public static readonly Recipe MagicKey = new Recipe { Name = "Magic Key"};
        public static readonly Recipe BronzeKnife = new Recipe { Name = "Bronze Knife"};
        public static readonly Recipe Dagger = new Recipe { Name = "Dagger"};
        public static readonly Recipe SleepDagger = new Recipe { Name = "Sleep Dagger"};
        public static readonly Recipe Broadsword = new Recipe { Name = "Broadsword"};
        public static readonly Recipe LongSword = new Recipe { Name = "Long Sword"};
        public static readonly Recipe GreatSword = new Recipe { Name = "Great Sword"};
        public static readonly Recipe BusterSword = new Recipe { Name = "Buster Sword"};
        public static readonly Recipe Kotetsu = new Recipe { Name = "Kotetsu"};
        public static readonly Recipe Kikuichimonji = new Recipe { Name = "Kiku-ichimonji"};
        public static readonly Recipe Kazekiri = new Recipe { Name = "Kazekiri"};
        public static readonly Recipe Kodachi = new Recipe { Name = "Kodachi"};
        public static readonly Recipe BattleAxe = new Recipe { Name = "Battle Axe"};
        public static readonly Recipe GreatAxe = new Recipe { Name = "Great Axe"};
        public static readonly Recipe WoodenHammer = new Recipe { Name = "Wooden Hammer"};
        public static readonly Recipe IronHammer = new Recipe { Name = "Iron Hammer"};
        public static readonly Recipe WarHammer = new Recipe { Name = "War Hammer"};
        public static readonly Recipe BronzeMace = new Recipe { Name = "Bronze Mace"};
        public static readonly Recipe IronMace = new Recipe { Name = "Iron Mace"};
        public static readonly Recipe Javelin = new Recipe { Name = "Javelin"};
        public static readonly Recipe Partisan = new Recipe { Name = "Partisan"};
        public static readonly Recipe BronzeKnuckles = new Recipe { Name = "Bronze Knuckles"};
        public static readonly Recipe MetalKnuckles = new Recipe { Name = "Metal Knuckles"};
        public static readonly Recipe CatClaws = new Recipe { Name = "Cat Claws"};
        public static readonly Recipe Rod = new Recipe { Name = "Rod"};
        public static readonly Recipe IronRod = new Recipe { Name = "Iron Rod"};
        public static readonly Recipe Staff = new Recipe { Name = "Staff"};
        public static readonly Recipe CherryStaff = new Recipe { Name = "Cherry Staff"};
        public static readonly Recipe WizardsStaff = new Recipe { Name = "Wizard's Staff"};
        public static readonly Recipe RuneStaff = new Recipe { Name = "Rune Staff"};
        public static readonly Recipe ShortBow = new Recipe { Name = "Short Bow"};
        public static readonly Recipe LongBow = new Recipe { Name = "Long Bow"};
        public static readonly Recipe GreatBow = new Recipe { Name = "Great Bow"};
        public static readonly Recipe Altair = new Recipe { Name = "Altair"};
        public static readonly Recipe LeatherWhip = new Recipe { Name = "Leather Whip"};
        public static readonly Recipe ChainWhip = new Recipe { Name = "Chain Whip"};
        public static readonly Recipe Boomerang = new Recipe { Name = "Boomerang"};
        public static readonly Recipe Chakram = new Recipe { Name = "Chakram"};
        public static readonly Recipe MoonRingBlade = new Recipe { Name = "Moon Ring Blade"};
        public static readonly Recipe Harp = new Recipe { Name = "Harp"};
        public static readonly Recipe SilverHarp = new Recipe { Name = "Silver Harp"};
        public static readonly Recipe LeatherShield = new Recipe { Name = "Leather Shield"};
        public static readonly Recipe SmallShield = new Recipe { Name = "Small Shield"};
        public static readonly Recipe Buckler = new Recipe { Name = "Buckler"};
        public static readonly Recipe BronzeShield = new Recipe { Name = "Bronze Shield"};
        public static readonly Recipe IronShield = new Recipe { Name = "Iron Shield"};
        public static readonly Recipe LeatherHat = new Recipe { Name = "Leather Hat"};
        public static readonly Recipe FeatheredCap = new Recipe { Name = "Feathered Cap"};
        public static readonly Recipe WizardsHat = new Recipe { Name = "Wizard's Hat"};
        public static readonly Recipe Bandana = new Recipe { Name = "Bandana"};
        public static readonly Recipe CelebrantsMiter = new Recipe { Name = "Celebrant's Miter"};
        public static readonly Recipe HypnoCrown = new Recipe { Name = "Hypno Crown"};
        public static readonly Recipe RedCap = new Recipe { Name = "Red Cap"};
        public static readonly Recipe BronzeHelm = new Recipe { Name = "Bronze Helm"};
        public static readonly Recipe IronHelm = new Recipe { Name = "Iron Helm"};
        public static readonly Recipe LeatherShirt = new Recipe { Name = "Leather Shirt"};
        public static readonly Recipe BardsTunic = new Recipe { Name = "Bard's Tunic"};
        public static readonly Recipe ScholarRobe = new Recipe { Name = "Scholar Robe"};
        public static readonly Recipe PowerVest = new Recipe { Name = "Power Vest"};
        public static readonly Recipe Kenpogi = new Recipe { Name = "Kenpogi"};
        public static readonly Recipe MagesHabit = new Recipe { Name = "Mage's Habit"};
        public static readonly Recipe SurvivalVest = new Recipe { Name = "Survival Vest"};
        public static readonly Recipe NinjaGear = new Recipe { Name = "Ninja Gear"};
        public static readonly Recipe BlackBeltGi = new Recipe { Name = "Black Belt Gi"};
        public static readonly Recipe LeatherPlate = new Recipe { Name = "Leather Plate"};
        public static readonly Recipe CopperCuirass = new Recipe { Name = "Copper Cuirass "};
        public static readonly Recipe IronPlate = new Recipe { Name = "Iron Plate"};
        public static readonly Recipe BronzeArmor = new Recipe { Name = "Bronze Armor"};
        public static readonly Recipe IronArmor = new Recipe { Name = "Iron Armor"};
        public static readonly Recipe CottonRobe = new Recipe { Name = "Cotton Robe"};
        public static readonly Recipe SilkRobe = new Recipe { Name = "Silk Robe"};
        public static readonly Recipe TravelersGarbs = new Recipe { Name = "Traveler's Garbs"};
        public static readonly Recipe GaiaGear = new Recipe { Name = "Gaia Gear"};
        public static readonly Recipe ClericsRobes = new Recipe { Name = "Cleric's Robes"};
        public static readonly Recipe IronGloves = new Recipe { Name = "Iron Gloves"};
        public static readonly Recipe PowerWrist = new Recipe { Name = "Power Wrist"};
        public static readonly Recipe HyperWrist = new Recipe { Name = "Hyper Wrist"};
        public static readonly Recipe SilverArmlet = new Recipe { Name = "Silver Armlet"};
        public static readonly Recipe FireRing = new Recipe { Name = "Fire Ring"};
        public static readonly Recipe IceRing = new Recipe { Name = "Ice Ring"};
        public static readonly Recipe SparkRing = new Recipe { Name = "Spark Ring"};
        public static readonly Recipe WaterRing = new Recipe { Name = "Water Ring"};
        public static readonly Recipe GaleRing = new Recipe { Name = "Gale Ring"};
        public static readonly Recipe EarthRing = new Recipe { Name = "Earth Ring"};
        public static readonly Recipe ProtectRing = new Recipe { Name = "Protect Ring"};
        public static readonly Recipe BarrierRing = new Recipe { Name = "Barrier Ring"};
        public static readonly Recipe RegenRing = new Recipe { Name = "Regen Ring"};
        public static readonly Recipe CatsBell = new Recipe { Name = "Cat's Bell"};
        public static readonly Recipe HerosRing = new Recipe { Name = "Hero's Ring"};
        public static readonly Recipe MuscleBelt = new Recipe { Name = "Muscle Belt"};
        public static readonly Recipe Libra = new Recipe { Name = "Libra"};
        public static readonly Recipe Cure = new Recipe { Name = "Cure"};
        public static readonly Recipe Blindna = new Recipe { Name = "Blindna"};
        public static readonly Recipe Vox = new Recipe { Name = "Vox"};
        public static readonly Recipe Poisona = new Recipe { Name = "Poisona"};
        public static readonly Recipe Paralyna = new Recipe { Name = "Paralyna"};
        public static readonly Recipe Stona = new Recipe { Name = "Stona"};
        public static readonly Recipe Fire = new Recipe { Name = "Fire"};
        public static readonly Recipe Blizzard = new Recipe { Name = "Blizzard"};
        public static readonly Recipe Thunder = new Recipe { Name = "Thunder"};
        public static readonly Recipe Water = new Recipe { Name = "Water"};
        public static readonly Recipe Aero = new Recipe { Name = "Aero"};
        public static readonly Recipe Stone = new Recipe { Name = "Stone"};
        public static readonly Recipe Bio = new Recipe { Name = "Bio"};
        public static readonly Recipe Blizzara = new Recipe { Name = "Blizzara"};
        public static readonly Recipe Thundara = new Recipe { Name = "Thundara"};
        public static readonly Recipe Watera = new Recipe { Name = "Watera"};
        public static readonly Recipe Aerora = new Recipe { Name = "Aerora"};
        public static readonly Recipe Gravity = new Recipe { Name = "Gravity"};
        public static readonly Recipe Drain = new Recipe { Name = "Drain"};
        public static readonly Recipe Biora = new Recipe { Name = "Biora"};
        public static readonly Recipe Sleep = new Recipe { Name = "Sleep"};
        public static readonly Recipe Blind = new Recipe { Name = "Blind"};
        public static readonly Recipe Barfire = new Recipe { Name = "Barfire"};
        public static readonly Recipe Barblizzard = new Recipe { Name = "Barblizzard"};
        public static readonly Recipe Barthunder = new Recipe { Name = "Barthunder"};
        public static readonly Recipe Barwater = new Recipe { Name = "Barwater"};
        public static readonly Recipe Baraero = new Recipe { Name = "Baraero"};
        public static readonly Recipe Barstone = new Recipe { Name = "Barstone"};
        public static readonly Recipe Silence = new Recipe { Name = "Silence"};
        public static readonly Recipe Barfira = new Recipe { Name = "Barfira"};
        public static readonly Recipe Barblizzara = new Recipe { Name = "Barblizzara"};
        public static readonly Recipe Barthundara = new Recipe { Name = "Barthundara"};
        public static readonly Recipe Shell = new Recipe { Name = "Shell"};
        public static readonly Recipe Deshell = new Recipe { Name = "Deshell"};
        public static readonly Recipe Barwatera = new Recipe { Name = "Barwatera"};
        public static readonly Recipe Baraerora = new Recipe { Name = "Baraerora"};
        public static readonly Recipe Barstonra = new Recipe { Name = "Barstonra"};
        public static readonly Recipe Steal = new Recipe { Name = "Steal"};
        public static readonly Recipe Brace = new Recipe { Name = "Brace"};
        public static readonly Recipe FireBlade = new Recipe { Name = "Fire Blade"};
        public static readonly Recipe BlizzardBlade = new Recipe { Name = "Blizzard Blade"};
        public static readonly Recipe SilenceBlade = new Recipe { Name = "Silence Blade"};
        public static readonly Recipe WaterBlade = new Recipe { Name = "Water Blade"};
        public static readonly Recipe StoneBlade = new Recipe { Name = "Stone Blade"};
        public static readonly Recipe BlindBlade = new Recipe { Name = "Blind Blade"};
        public static readonly Recipe BioBlade = new Recipe { Name = "Bio Blade"};
        public static readonly Recipe MagicInfuse = new Recipe { Name = "Magic Infuse"};
        public static readonly Recipe MentalBreak = new Recipe { Name = "Mental Break"};
        public static readonly Recipe BioBlaster = new Recipe { Name = "Bio Blaster"};
        public static readonly Recipe BombFragment = new Recipe { Name = "Bomb Fragment"};
        public static readonly Recipe FishScale = new Recipe { Name = "Fish Scale"};
        public static readonly Recipe GiantFeather = new Recipe { Name = "Giant Feather"};
        public static readonly Recipe Pinwheel = new Recipe { Name = "Pinwheel"};
        public static readonly Recipe Icebrand = new Recipe { Name = "Icebrand"};
        public static readonly Recipe CoralSword = new Recipe { Name = "Coral Sword"};
        public static readonly Recipe FireRod = new Recipe { Name = "Fire Rod"};
        public static readonly Recipe Capella = new Recipe { Name = "Capella"};
        public static readonly Recipe ShockWhip = new Recipe { Name = "Shock Whip"};
        public static readonly Recipe OchreShield = new Recipe { Name = "Ochre Shield"};
        public static readonly Recipe GreenBeret = new Recipe { Name = "Green Beret"};
        public static readonly Recipe Barbut = new Recipe { Name = "Barbut"};
        public static readonly Recipe SagesSurplice = new Recipe { Name = "Sage's Surplice"};
        public static readonly Recipe Protect = new Recipe { Name = "Protect"};
        public static readonly Recipe MP_905100040 = new Recipe { Name = "MP +10%"};
        public static readonly Recipe SPR_905100160 = new Recipe { Name = "SPR +10%"};
        public static readonly Recipe BugKiller = new Recipe { Name = "Bug Killer"};
        public static readonly Recipe XPotion = new Recipe { Name = "X-Potion"};
        public static readonly Recipe TurboEther = new Recipe { Name = "Turbo Ether"};
        public static readonly Recipe HolyTorch = new Recipe { Name = "Holy Torch"};
        public static readonly Recipe MythrilSpear = new Recipe { Name = "Mythril Spear"};
        public static readonly Recipe MagesHat = new Recipe { Name = "Mage's Hat"};
        public static readonly Recipe SagesRobe = new Recipe { Name = "Sage's Robe"};
        public static readonly Recipe MythrilGloves = new Recipe { Name = "Mythril Gloves"};
        public static readonly Recipe Cura = new Recipe { Name = "Cura"};
        public static readonly Recipe DEF = new Recipe { Name = "DEF +10%"};
        public static readonly Recipe MythrilHammer = new Recipe { Name = "Mythril Hammer"};
        public static readonly Recipe WindSpear = new Recipe { Name = "Wind Spear"};
        public static readonly Recipe MythrilHelm = new Recipe { Name = "Mythril Helm"};
        public static readonly Recipe Bravery = new Recipe { Name = "Bravery"};
        public static readonly Recipe MAG = new Recipe { Name = "MAG +10%"};
        public static readonly Recipe FineBlade = new Recipe { Name = "Fine Blade"};
        public static readonly Recipe SuperiorBlade = new Recipe { Name = "Superior Blade"};
        public static readonly Recipe AntarcticWind = new Recipe { Name = "Antarctic Wind"};
        public static readonly Recipe ZeussRage = new Recipe { Name = "Zeus's Rage"};
        public static readonly Recipe EarthDrum = new Recipe { Name = "Earth Drum"};
        public static readonly Recipe MythrilDagger = new Recipe { Name = "Mythril Dagger"};
        public static readonly Recipe MainGauche = new Recipe { Name = "Main Gauche"};
        public static readonly Recipe MythrilSword = new Recipe { Name = "Mythril Sword"};
        public static readonly Recipe Osafune = new Recipe { Name = "Osafune"};
        public static readonly Recipe MythrilMace = new Recipe { Name = "Mythril Mace"};
        public static readonly Recipe MythrilClaws = new Recipe { Name = "Mythril Claws"};
        public static readonly Recipe MythrilBow = new Recipe { Name = "Mythril Bow"};
        public static readonly Recipe MythrilWhip = new Recipe { Name = "Mythril Whip"};
        public static readonly Recipe MythrilBuckler = new Recipe { Name = "Mythril Buckler"};
        public static readonly Recipe LargeShield = new Recipe { Name = "Large Shield"};
        public static readonly Recipe MythrilShield = new Recipe { Name = "Mythril Shield"};
        public static readonly Recipe TigerMask = new Recipe { Name = "Tiger Mask"};
        public static readonly Recipe MythrilPlate = new Recipe { Name = "Mythril Plate"};
        public static readonly Recipe SilverCuirass = new Recipe { Name = "Silver Cuirass"};
        public static readonly Recipe PaladinArmor = new Recipe { Name = "Paladin Armor"};
        public static readonly Recipe MythrilArmor = new Recipe { Name = "Mythril Armor"};
        public static readonly Recipe WizardsRobe = new Recipe { Name = "Wizard's Robe"};
        public static readonly Recipe MoonBracer = new Recipe { Name = "Moon Bracer"};
        public static readonly Recipe Dispel = new Recipe { Name = "Dispel"};
        public static readonly Recipe Faith = new Recipe { Name = "Faith"};
        public static readonly Recipe SpiritSlayer = new Recipe { Name = "Spirit Slayer"};
        public static readonly Recipe HP_905101500 = new Recipe { Name = "HP +15%"};
        public static readonly Recipe SleepBlade = new Recipe { Name = "Sleep Blade"};
        public static readonly Recipe AeroBlade = new Recipe { Name = "Aero Blade"};
        public static readonly Recipe StonraBlade_905200660 = new Recipe { Name = "Stonra Blade"};
        public static readonly Recipe VorpalAxe = new Recipe { Name = "Vorpal Axe"};
        public static readonly Recipe GaeBolg = new Recipe { Name = "Gae Bolg"};
        public static readonly Recipe LightCurtain = new Recipe { Name = "Light Curtain"};
        public static readonly Recipe WyvernsFeather = new Recipe { Name = "Wyvern's Feather"};
        public static readonly Recipe WhiteFang = new Recipe { Name = "White Fang"};
        public static readonly Recipe MythrilSaber = new Recipe { Name = "Mythril Saber"};
        public static readonly Recipe Chirijiraden = new Recipe { Name = "Chirijiraden"};
        public static readonly Recipe MythrilAxe = new Recipe { Name = "Mythril Axe"};
        public static readonly Recipe Escutcheon = new Recipe { Name = "Escutcheon"};
        public static readonly Recipe Brigandine = new Recipe { Name = "Brigandine"};
        public static readonly Recipe Curaga = new Recipe { Name = "Curaga"};
        public static readonly Recipe EVOMAG = new Recipe { Name = "EVO MAG +10%"};
        public static readonly Recipe WateraBlade = new Recipe { Name = "Watera Blade"};
        public static readonly Recipe WingedSaint = new Recipe { Name = "Winged Saint"};
        public static readonly Recipe MoraleTalisman = new Recipe { Name = "Morale Talisman"};
        public static readonly Recipe RodofGravity = new Recipe { Name = "Rod of Gravity"};
        public static readonly Recipe VoidVessel = new Recipe { Name = "Void Vessel"};
        public static readonly Recipe StonraBlade_1000000004 = new Recipe { Name = "Stonra Blade"};
        public static readonly Recipe HP_1000000005 = new Recipe { Name = "HP +15%"};
        public static readonly Recipe BurstShot = new Recipe { Name = "Burst Shot"};
        public static readonly Recipe StandardMogcakePack = new Recipe { Name = "Standard Mogcake Pack"};
        public static readonly Recipe RareMogcakePack = new Recipe { Name = "Rare Mogcake Pack"};
        public static readonly Recipe PremiumMogcakePack = new Recipe { Name = "Premium Mogcake Pack"};
        public static readonly Recipe LunarCurtain = new Recipe { Name = "Lunar Curtain"};
        public static readonly Recipe NorthWind = new Recipe { Name = "North Wind"};
        public static readonly Recipe Flametongue = new Recipe { Name = "Flametongue"};
        public static readonly Recipe ATK = new Recipe { Name = "ATK +10%"};
        public static readonly Recipe AutoProtect = new Recipe { Name = "Auto-Protect"};
        public static readonly Recipe BioraBlade = new Recipe { Name = "Biora Blade"};
        public static readonly Recipe RightArm = new Recipe { Name = "Right Arm"};
        public static readonly Recipe BlueFang = new Recipe { Name = "Blue Fang"};
        public static readonly Recipe SleepSword = new Recipe { Name = "Sleep Sword"};
        public static readonly Recipe FlameLance = new Recipe { Name = "Flame Lance"};
        public static readonly Recipe PoisonKnuckles = new Recipe { Name = "Poison Knuckles"};
        public static readonly Recipe ThunderShield = new Recipe { Name = "Thunder Shield"};
        public static readonly Recipe IceArmor = new Recipe { Name = "Ice Armor"};
        public static readonly Recipe AutoShell = new Recipe { Name = "Auto-Shell"};
        public static readonly Recipe OsmoseBlade = new Recipe { Name = "Osmose Blade"};
        public static readonly Recipe ShiningSplendor = new Recipe { Name = "Shining Splendor"};
        public static readonly Recipe YPotion = new Recipe { Name = "Y-Potion"};
        public static readonly Recipe MegaEther = new Recipe { Name = "Mega Ether"};
        public static readonly Recipe BloodSword = new Recipe { Name = "Blood Sword"};
        public static readonly Recipe RedFang = new Recipe { Name = "Red Fang"};
        public static readonly Recipe Trident = new Recipe { Name = "Trident"};
        public static readonly Recipe RodofLightning = new Recipe { Name = "Rod of Lightning"};
        public static readonly Recipe ElvenBow = new Recipe { Name = "Elven Bow"};
        public static readonly Recipe FlameMail = new Recipe { Name = "Flame Mail"};
        public static readonly Recipe Death = new Recipe { Name = "Death"};
        public static readonly Recipe BirdKiller = new Recipe { Name = "Bird Killer"};
        public static readonly Recipe AutoPotion = new Recipe { Name = "Auto-Potion"};
        public static readonly Recipe PowerBreak = new Recipe { Name = "Power Break"};
        public static readonly Recipe MagicBreak = new Recipe { Name = "Magic Break"};
        public static readonly Recipe GiantsAxe = new Recipe { Name = "Giant's Axe"};
        public static readonly Recipe Werebuster = new Recipe { Name = "Werebuster"};
        public static readonly Recipe IceLance = new Recipe { Name = "Ice Lance"};
        public static readonly Recipe IceRod = new Recipe { Name = "Ice Rod"};
        public static readonly Recipe Sirius = new Recipe { Name = "Sirius"};
        public static readonly Recipe MysteryVeil = new Recipe { Name = "Mystery Veil"};
        public static readonly Recipe GoldenArmor = new Recipe { Name = "Golden Armor"};
        public static readonly Recipe BlackRobe = new Recipe { Name = "Black Robe"};
        public static readonly Recipe UndeadKiller = new Recipe { Name = "Undead Killer"};
        public static readonly Recipe ArmorBreak = new Recipe { Name = "Armor Break"};
        public static readonly Recipe ThunderBlade = new Recipe { Name = "Thunder Blade"};
        public static readonly Recipe MonarchsRing = new Recipe { Name = "Monarch's Ring"};
        public static readonly Recipe DominationRing = new Recipe { Name = "Domination Ring"};
        public static readonly Recipe RulersRing = new Recipe { Name = "Ruler's Ring"};
        public static readonly Recipe RingofDominion = new Recipe { Name = "Ring of Dominion"};
        public static readonly Recipe HeavenlyWrath = new Recipe { Name = "Heavenly Wrath"};
        public static readonly Recipe DragonScale_901000350 = new Recipe { Name = "Dragon Scale"};
        public static readonly Recipe GoldenStaff = new Recipe { Name = "Golden Staff"};
        public static readonly Recipe BlessedHammer = new Recipe { Name = "Blessed Hammer"};
        public static readonly Recipe IceShield = new Recipe { Name = "Ice Shield"};
        public static readonly Recipe GoldenVest = new Recipe { Name = "Golden Vest"};
        public static readonly Recipe WhiteRobe = new Recipe { Name = "White Robe"};
        public static readonly Recipe BuddingMapleWand = new Recipe { Name = "Budding Maple Wand"};
        public static readonly Recipe ScionConjurersDalmatica = new Recipe { Name = "Scion Conjurer's Dalmatica"};
        public static readonly Recipe ScionConjurersPattens = new Recipe { Name = "Scion Conjurer's Pattens"};
        public static readonly Recipe CobaltWinglet = new Recipe { Name = "Cobalt Winglet"};
        public static readonly Recipe AntecedentsAttire = new Recipe { Name = "Antecedent's Attire"};
        public static readonly Recipe MeteorSurvivorRing = new Recipe { Name = "Meteor Survivor Ring"};
        public static readonly Recipe UldahnFalchion = new Recipe { Name = "Ul'dahn Falchion"};
        public static readonly Recipe ScionThiefsTunic = new Recipe { Name = "Scion Thief's Tunic"};
        public static readonly Recipe ScionThiefsHalfgloves = new Recipe { Name = "Scion Thief's Halfgloves"};
        public static readonly Recipe GaiasCry = new Recipe { Name = "Gaia's Cry"};
        public static readonly Recipe GoldenBlade = new Recipe { Name = "Golden Blade"};
        public static readonly Recipe FlameShield = new Recipe { Name = "Flame Shield"};
        public static readonly Recipe Circlet = new Recipe { Name = "Circlet"};
        public static readonly Recipe AngelRing = new Recipe { Name = "Angel Ring"};
        public static readonly Recipe BasiliskSteel = new Recipe { Name = "Basilisk Steel"};
        public static readonly Recipe Razzmatazz = new Recipe { Name = "Razzmatazz"};
        public static readonly Recipe HyperBall = new Recipe { Name = "Hyper Ball"};
        public static readonly Recipe Override = new Recipe { Name = "Override"};
        public static readonly Recipe ThunderSpear = new Recipe { Name = "Thunder Spear"};
        public static readonly Recipe Betelgeuse = new Recipe { Name = "Betelgeuse"};
        public static readonly Recipe GoldenShield = new Recipe { Name = "Golden Shield"};
        public static readonly Recipe Imperil = new Recipe { Name = "Imperil"};
        public static readonly Recipe Microphone_1000000014 = new Recipe { Name = "Microphone"};
        public static readonly Recipe EveningGloves = new Recipe { Name = "Evening Gloves"};
        public static readonly Recipe BunnyMask_1000000016 = new Recipe { Name = "Bunny Mask"};
        public static readonly Recipe StylishBlackDress_1000000017 = new Recipe { Name = "Stylish Black Dress"};
        public static readonly Recipe MemoryCandy = new Recipe { Name = "Memory Candy"};
        public static readonly Recipe MageMasher = new Recipe { Name = "Mage Masher"};
        public static readonly Recipe RasAlgethi = new Recipe { Name = "Ras Algethi"};
        public static readonly Recipe GalkanDagger = new Recipe { Name = "Galkan Dagger"};
        public static readonly Recipe LeucosVoulge = new Recipe { Name = "Leucos Voulge"};
        public static readonly Recipe ThothsWand = new Recipe { Name = "Thoth's Wand"};
        public static readonly Recipe OrcPiercer = new Recipe { Name = "Orc Piercer"};
        public static readonly Recipe Retaliator = new Recipe { Name = "Retaliator"};
        public static readonly Recipe IridalStaff = new Recipe { Name = "Iridal Staff"};
        public static readonly Recipe TacticianMagiciansWand = new Recipe { Name = "Tactician Magician's Wand"};
        public static readonly Recipe SharkGun = new Recipe { Name = "Shark Gun"};
        public static readonly Recipe SlickDart = new Recipe { Name = "Slick Dart"};
        public static readonly Recipe Raikiri = new Recipe { Name = "Raikiri"};
        public static readonly Recipe MoogleSpear = new Recipe { Name = "Moogle Spear"};
        public static readonly Recipe BreakShot = new Recipe { Name = "Break Shot"};
        public static readonly Recipe TwinWhip = new Recipe { Name = "Twin Whip"};
        public static readonly Recipe Microphone_903001290 = new Recipe { Name = "Microphone"};
        public static readonly Recipe TorrentRing = new Recipe { Name = "Torrent Ring"};
        public static readonly Recipe DivineShield = new Recipe { Name = "Divine Shield"};
        public static readonly Recipe RavenBeret = new Recipe { Name = "Raven Beret"};
        public static readonly Recipe TacticianMagiciansCoat = new Recipe { Name = "Tactician Magician's Coat"};
        public static readonly Recipe ParadeCuirass = new Recipe { Name = "Parade Cuirass"};
        public static readonly Recipe GoldenHairpin = new Recipe { Name = "Golden Hairpin"};
        public static readonly Recipe ParadeGorget = new Recipe { Name = "Parade Gorget"};
        public static readonly Recipe MoogleCrown = new Recipe { Name = "Moogle Crown"};
        public static readonly Recipe MoogleCape = new Recipe { Name = "Moogle Cape"};
        public static readonly Recipe UnsuiClothes = new Recipe { Name = "Unsui Clothes"};
        public static readonly Recipe GoldenHelm = new Recipe { Name = "Golden Helm"};
        public static readonly Recipe FestivalRobe_904001710 = new Recipe { Name = "Festival Robe+"};
        public static readonly Recipe FestivalCap_904001720 = new Recipe { Name = "Festival Cap+"};
        public static readonly Recipe PlatinumTiara = new Recipe { Name = "Platinum Tiara"};
        public static readonly Recipe Fransisca = new Recipe { Name = "Fransisca"};
        public static readonly Recipe GloryStaff = new Recipe { Name = "Glory Staff"};
        public static readonly Recipe KrisKnife = new Recipe { Name = "Kris Knife"};
        public static readonly Recipe RoyalRing = new Recipe { Name = "Royal Ring"};
        public static readonly Recipe EveningGlove = new Recipe { Name = "Evening Glove"};
        public static readonly Recipe BunnyMask_904001810 = new Recipe { Name = "Bunny Mask"};
        public static readonly Recipe StylishBlackDress_904001820 = new Recipe { Name = "Stylish Black Dress"};
        public static readonly Recipe Darkra = new Recipe { Name = "Darkra"};
        public static readonly Recipe DragonKiller = new Recipe { Name = "Dragon Killer+"};
        public static readonly Recipe MogSearch = new Recipe { Name = "Mog Search"};
        public static readonly Recipe MogResist = new Recipe { Name = "Mog Resist"};
        public static readonly Recipe MogRise = new Recipe { Name = "Mog Rise"};
        public static readonly Recipe FiraBlade = new Recipe { Name = "Fira Blade"};
        public static readonly Recipe ChocolateEgg = new Recipe { Name = "Chocolate Egg"};
        public static readonly Recipe GreatEgg = new Recipe { Name = "Great Egg"};
        public static readonly Recipe MagicalEgg = new Recipe { Name = "Magical Egg"};
        public static readonly Recipe RadiantEgg = new Recipe { Name = "Radiant Egg"};
        public static readonly Recipe StaffofWrath = new Recipe { Name = "Staff of Wrath"};
        public static readonly Recipe CrownofJustice_1000000025 = new Recipe { Name = "Crown of Justice"};
        public static readonly Recipe BlackBandana_1000000026 = new Recipe { Name = "Black Bandana"};
        public static readonly Recipe SecondKnife = new Recipe { Name = "Second Knife"};
        public static readonly Recipe IcyVeins_1000000028 = new Recipe { Name = "Icy Veins"};
        public static readonly Recipe ColdSnap = new Recipe { Name = "Cold Snap"};
        public static readonly Recipe DrakesclawRod = new Recipe { Name = "Drakesclaw Rod"};
        public static readonly Recipe DrakesguardRobe = new Recipe { Name = "Drakesguard Robe"};
        public static readonly Recipe BahamutsFang = new Recipe { Name = "Bahamut's Fang"};
        public static readonly Recipe DragonsRoar = new Recipe { Name = "Dragon's Roar"};
        public static readonly Recipe GutsKnuckle = new Recipe { Name = "Guts Knuckle"};
        public static readonly Recipe GoldenEye = new Recipe { Name = "Golden Eye"};
        public static readonly Recipe ScionStrikersVisor = new Recipe { Name = "Scion Striker's Visor"};
        public static readonly Recipe ScionStrikersAttire = new Recipe { Name = "Scion Striker's Attire"};
        public static readonly Recipe ScionThaumaturgesMonocle = new Recipe { Name = "Scion Thaumaturge's Monocle"};
        public static readonly Recipe ScionThaumaturgesRobe = new Recipe { Name = "Scion Thaumaturge's Robe"};
        public static readonly Recipe Adventurer = new Recipe { Name = "Adventurer"};
        public static readonly Recipe AdventurerII = new Recipe { Name = "Adventurer II"};
        public static readonly Recipe AdventurerIII = new Recipe { Name = "Adventurer III"};
        public static readonly Recipe AdventurerIV = new Recipe { Name = "Adventurer IV"};
        public static readonly Recipe AdventurerV = new Recipe { Name = "Adventurer V"};
        public static readonly Recipe BrokenArm = new Recipe { Name = "Broken Arm"};
        public static readonly Recipe AngelWand = new Recipe { Name = "Angel Wand"};
        public static readonly Recipe PlatinumMusket = new Recipe { Name = "Platinum Musket"};
        public static readonly Recipe AncientOverlord = new Recipe { Name = "Ancient Overlord"};
        public static readonly Recipe IronWill = new Recipe { Name = "Iron Will"};
        public static readonly Recipe DragoonLance = new Recipe { Name = "Dragoon Lance"};
        public static readonly Recipe TypeFists = new Recipe { Name = "Type-3 Fists"};
        public static readonly Recipe CruelOath = new Recipe { Name = "Cruel Oath"};
        public static readonly Recipe BellowsArmGuard = new Recipe { Name = "Bellows Arm Guard"};
        public static readonly Recipe MagicBarrierDevice = new Recipe { Name = "Magic Barrier Device"};
        public static readonly Recipe ZDHelmet = new Recipe { Name = "ZD Helmet"};
        public static readonly Recipe AngelWing = new Recipe { Name = "Angel Wing"};
        public static readonly Recipe PlatinumRobe = new Recipe { Name = "Platinum Robe"};
        public static readonly Recipe SeraphimShield = new Recipe { Name = "Seraphim Shield"};
        public static readonly Recipe EmilsHead = new Recipe { Name = "Emil's Head"};
        public static readonly Recipe HeavyArmorB = new Recipe { Name = "Heavy Armor: B"};
        public static readonly Recipe PlatinaArmor = new Recipe { Name = "Platina Armor"};
        public static readonly Recipe BlizzaraBlade = new Recipe { Name = "Blizzara Blade"};
        public static readonly Recipe ThundaraBlade = new Recipe { Name = "Thundara Blade"};
        public static readonly Recipe AeroraBlade = new Recipe { Name = "Aerora Blade"};
        public static readonly Recipe PlatinumDagger = new Recipe { Name = "Platinum Dagger"};
        public static readonly Recipe ValiantII = new Recipe { Name = "Valiant II"};
        public static readonly Recipe PrecisionLance = new Recipe { Name = "Precision Lance"};
        public static readonly Recipe Valiant = new Recipe { Name = "Valiant"};
        public static readonly Recipe CypressPile = new Recipe { Name = "Cypress Pile"};
        public static readonly Recipe PlatinumSaber = new Recipe { Name = "Platinum Saber"};
        public static readonly Recipe Darkbringer = new Recipe { Name = "Darkbringer"};
        public static readonly Recipe YggdrasilStaff = new Recipe { Name = "Yggdrasil Staff"};
        public static readonly Recipe Dragvandil = new Recipe { Name = "Dragvandil"};
        public static readonly Recipe SweetKiss = new Recipe { Name = "Sweet Kiss"};
        public static readonly Recipe PlatinumMace = new Recipe { Name = "Platinum Mace"};
        public static readonly Recipe PlatinumWhip = new Recipe { Name = "Platinum Whip"};
        public static readonly Recipe TamersGloves = new Recipe { Name = "Tamer's Gloves"};
        public static readonly Recipe SecretKnife = new Recipe { Name = "Secret Knife"};
        public static readonly Recipe StaffofResentment = new Recipe { Name = "Staff of Resentment"};
        public static readonly Recipe PlatinumEdge = new Recipe { Name = "Platinum Edge"};
        public static readonly Recipe FierceBow = new Recipe { Name = "Fierce Bow"};
        public static readonly Recipe Kogarasumaru = new Recipe { Name = "Kogarasumaru"};
        public static readonly Recipe ScarletRoses = new Recipe { Name = "Scarlet Roses"};
        public static readonly Recipe Takemikazuchi = new Recipe { Name = "Takemikazuchi"};
        public static readonly Recipe MetalPipe = new Recipe { Name = "Metal Pipe"};
        public static readonly Recipe PlatinumAxe = new Recipe { Name = "Platinum Axe"};
        public static readonly Recipe RubberSuit = new Recipe { Name = "Rubber Suit"};
        public static readonly Recipe A1ClassPowershield = new Recipe { Name = "A1-Class Powershield"};
        public static readonly Recipe AssistSuit = new Recipe { Name = "Assist Suit"};
        public static readonly Recipe ChobhamArmor = new Recipe { Name = "Chobham Armor"};
        public static readonly Recipe TacticalManual = new Recipe { Name = "Tactical Manual"};
        public static readonly Recipe MagnoliasUniform = new Recipe { Name = "Magnolia's Uniform"};
        public static readonly Recipe IcyVeins_904002010 = new Recipe { Name = "Icy Veins"};
        public static readonly Recipe BlackBandana_904002020 = new Recipe { Name = "Black Bandana"};
        public static readonly Recipe CrownofJustice_904002030 = new Recipe { Name = "Crown of Justice"};
        public static readonly Recipe JeweledBelt = new Recipe { Name = "Jeweled Belt"};
        public static readonly Recipe PlatinumBreastplate = new Recipe { Name = "Platinum Breastplate"};
        public static readonly Recipe RiotGear = new Recipe { Name = "Riot Gear"};
        public static readonly Recipe PlatinumShield = new Recipe { Name = "Platinum Shield"};
        public static readonly Recipe TrueShardofGenius = new Recipe { Name = "True Shard of Genius"};
        public static readonly Recipe TrueFollowersOath = new Recipe { Name = "True Follower's Oath"};
        public static readonly Recipe TrueHydaelynGuard = new Recipe { Name = "True Hydaelyn Guard"};
        public static readonly Recipe TrueSpiritofFreedom = new Recipe { Name = "True Spirit of Freedom"};
        public static readonly Recipe TrueSagesPrajna = new Recipe { Name = "True Sage's Prajna"};
        public static readonly Recipe Kappower = new Recipe { Name = "Kappower"};
        public static readonly Recipe AutoBravery = new Recipe { Name = "Auto-Bravery"};
        public static readonly Recipe AutoFaith = new Recipe { Name = "Auto-Faith"};
        public static readonly Recipe MP_905100370 = new Recipe { Name = "MP + 15%"};
        public static readonly Recipe KittyHeadband = new Recipe { Name = "Kitty Headband"};
        public static readonly Recipe CloakofResentment = new Recipe { Name = "Cloak of Resentment"};
        public static readonly Recipe SparklingHeels = new Recipe { Name = "Sparkling Heels"};
        public static readonly Recipe EvilPipe = new Recipe { Name = "Evil Pipe"};
        public static readonly Recipe PinkStripedFloat = new Recipe { Name = "Pink Striped Float"};
        public static readonly Recipe CheerfulTune = new Recipe { Name = "Cheerful Tune"};
        public static readonly Recipe JoyfulSpirit = new Recipe { Name = "Joyful Spirit"};
        public static readonly Recipe Lightbringer = new Recipe { Name = "Lightbringer"};
        public static readonly Recipe GraspingSphere = new Recipe { Name = "Grasping Sphere"};
        public static readonly Recipe StaffofBlizzards = new Recipe { Name = "Staff of Blizzards"};
        public static readonly Recipe WingEdges = new Recipe { Name = "Wing Edges"};
        public static readonly Recipe SalamandersGauntlets = new Recipe { Name = "Salamander's Gauntlets"};
        public static readonly Recipe CragSplitter = new Recipe { Name = "Crag Splitter"};
        public static readonly Recipe FlaxShield = new Recipe { Name = "Flax Shield"};
        public static readonly Recipe JadeMoonPendant = new Recipe { Name = "Jade Moon Pendant"};
        public static readonly Recipe JadeSunPendant = new Recipe { Name = "Jade Sun Pendant"};
        public static readonly Recipe FieryPassion = new Recipe { Name = "Fiery Passion"};
        public static readonly Recipe StaffofOsiris_1000000055 = new Recipe { Name = "Staff of Osiris"};
        public static readonly Recipe IcyDeath = new Recipe { Name = "Icy Death"};
        public static readonly Recipe Flamethrower_1000000057 = new Recipe { Name = "Flamethrower"};
        public static readonly Recipe ToxicShotgun_1000000058 = new Recipe { Name = "Toxic Shotgun"};
        public static readonly Recipe OnyxSpiritofRa = new Recipe { Name = "Onyx Spirit of Ra"};
        public static readonly Recipe GoldRingofSet = new Recipe { Name = "Gold Ring of Set"};
        public static readonly Recipe PlatinumLance = new Recipe { Name = "Platinum Lance"};
        public static readonly Recipe PlatinumBow = new Recipe { Name = "Platinum Bow"};
        public static readonly Recipe DiamondKnife = new Recipe { Name = "Diamond Knife"};
        public static readonly Recipe DragonScale_904002080 = new Recipe { Name = "Dragon Scale"};
        public static readonly Recipe SagesStaff = new Recipe { Name = "Sage's Staff"};
        public static readonly Recipe SacredClaws = new Recipe { Name = "Sacred Claws"};
        public static readonly Recipe DragovianSpear = new Recipe { Name = "Dragovian Spear"};
        public static readonly Recipe WolfMask = new Recipe { Name = "Wolf Mask"};
        public static readonly Recipe FestivalRobe_904002140 = new Recipe { Name = "Festival Robe"};
        public static readonly Recipe FestivalCap_904002150 = new Recipe { Name = "Festival Cap"};
        public static readonly Recipe YinYangCharm_904002180 = new Recipe { Name = "Yin Yang Charm"};
        public static readonly Recipe SantasClothesII = new Recipe { Name = "Santa's Clothes II"};
        public static readonly Recipe SantasHatII = new Recipe { Name = "Santa's Hat II"};
        public static readonly Recipe TsukumoDoll_904002210 = new Recipe { Name = "Tsukumo Doll"};
        public static readonly Recipe KimonoVest_904002220 = new Recipe { Name = "Kimono Vest"};
        public static readonly Recipe SantasCane = new Recipe { Name = "Santa's Cane"};
        public static readonly Recipe PlatinumFist = new Recipe { Name = "Platinum Fist"};
        public static readonly Recipe GemofCreation = new Recipe { Name = "Gem of Creation"};
        public static readonly Recipe GemofVision = new Recipe { Name = "Gem of Vision"};
        public static readonly Recipe NibelungenRing = new Recipe { Name = "Nibelungen Ring"};
        public static readonly Recipe DragoonTyrant = new Recipe { Name = "Dragoon Tyrant"};
        public static readonly Recipe RustRedCirclet = new Recipe { Name = "Rust-Red Circlet"};
        public static readonly Recipe DiamondRobe = new Recipe { Name = "Diamond Robe"};
        public static readonly Recipe FaerieCloak = new Recipe { Name = "Faerie Cloak"};
        public static readonly Recipe FlowerSuit = new Recipe { Name = "Flower Suit"};
        public static readonly Recipe MagicalArmor = new Recipe { Name = "Magical Armor"};
        public static readonly Recipe FrostyRing = new Recipe { Name = "Frosty Ring"};
        public static readonly Recipe StaffofOsiris_904002370 = new Recipe { Name = "Staff of Osiris"};
        public static readonly Recipe ToxicShotgun_904002380 = new Recipe { Name = "Toxic Shotgun"};
        public static readonly Recipe Flamethrower_904002390 = new Recipe { Name = "Flamethrower"};
        public static readonly Recipe GoldRingofSeth = new Recipe { Name = "Gold Ring of Seth"};
        public static readonly Recipe DiamondSword = new Recipe { Name = "Diamond Sword"};
        public static readonly Recipe DiamondArmor = new Recipe { Name = "Diamond Armor"};
        public static readonly Recipe RicosWingsuit = new Recipe { Name = "Rico's Wingsuit"};
        public static readonly Recipe GE_1000000062 = new Recipe { Name = "GE-64"};
        public static readonly Recipe RicosCombatGloves = new Recipe { Name = "Rico's Combat Gloves"};
        public static readonly Recipe UVK = new Recipe { Name = "UVK-13"};
        public static readonly Recipe CSWraithR = new Recipe { Name = "CS Wraith 225R"};
        public static readonly Recipe UZabijak = new Recipe { Name = "U-24 Zabijak"};
        public static readonly Recipe YinYangCharm_1000000067 = new Recipe { Name = "Yin Yang Charm"};
        public static readonly Recipe VestmentofPrayers = new Recipe { Name = "Vestment of Prayers"};
        public static readonly Recipe WhiteBandana = new Recipe { Name = "White Bandana"};
        public static readonly Recipe TsukumoDoll_1000000070 = new Recipe { Name = "Tsukumo Doll"};
        public static readonly Recipe KimonoVest_1000000071 = new Recipe { Name = "Kimono Vest"};
        public static readonly Recipe ElvenStaff = new Recipe { Name = "Elven Staff"};
        public static readonly Recipe ZenithZAP = new Recipe { Name = "Zenith ZAP"};
        public static readonly Recipe TITAN = new Recipe { Name = "TITAN"};
        public static readonly Recipe EMPGrenade = new Recipe { Name = "EMP Grenade"};
        public static readonly Recipe CtedAzurSOW = new Recipe { Name = "Côte d'Azur S.O.W."};
        public static readonly Recipe NukeVirusSoftware = new Recipe { Name = "Nuke Virus Software"};
        public static readonly Recipe LinebackerGMSGL = new Recipe { Name = "Linebacker G-87 MSGL"};
        public static readonly Recipe SturdyUmbrella = new Recipe { Name = "Sturdy Umbrella"};
        public static readonly Recipe BeachBall = new Recipe { Name = "Beach Ball"};
        public static readonly Recipe GE_1000000081 = new Recipe { Name = "G-0991E"};
        public static readonly Recipe SplashofLife = new Recipe { Name = "Splash of Life"};
        public static readonly Recipe RavenFigurine = new Recipe { Name = "Raven Figurine"};
        public static readonly Recipe HalfCrescentRod = new Recipe { Name = "Half Crescent Rod"};
        public static readonly Recipe AvianCloak = new Recipe { Name = "Avian Cloak"};
        public static readonly Recipe EmpoweredGauntlets = new Recipe { Name = "Empowered Gauntlets"};
        public static readonly Recipe BizarreSculpture = new Recipe { Name = "Bizarre Sculpture"};
        public static readonly Recipe BigRedRibbon = new Recipe { Name = "Big Red Ribbon"};
        public static readonly Recipe CrimsonVest = new Recipe { Name = "Crimson Vest"};
        public static readonly Recipe GallantBelt = new Recipe { Name = "Gallant Belt"};
        public static readonly Recipe Strength = new Recipe { Name = "Strength"};
        public static readonly Recipe Etherize = new Recipe { Name = "Etherize"};
        public static readonly Recipe DiamondBreastplate = new Recipe { Name = "Diamond Breastplate"};
        public static readonly Recipe BlackLeather = new Recipe { Name = "Black Leather"};
        public static readonly Recipe YamatoBelt = new Recipe { Name = "Yamato Belt"};
        public static readonly Recipe Shielder = new Recipe { Name = "Shielder"};
        public static readonly Recipe Soulful = new Recipe { Name = "Soulful"};
        public static readonly Recipe TornDress = new Recipe { Name = "Torn Dress"};
        public static readonly Recipe MetalEarrings = new Recipe { Name = "Metal Earrings"};
        public static readonly Recipe EternalFlame = new Recipe { Name = "Eternal Flame"};
        public static readonly Recipe RuinedShield = new Recipe { Name = "Ruined Shield"};
        public static readonly Recipe KatanaProficiency = new Recipe { Name = "Katana Proficiency"};
        public static readonly Recipe SpiritualProficiency = new Recipe { Name = "Spiritual Proficiency"};
        public static readonly Recipe DemonicMight = new Recipe { Name = "Demonic Might"};
        public static readonly Recipe DemonicMind = new Recipe { Name = "Demonic Mind"};
        public static readonly Recipe PopstarsMicrophone = new Recipe { Name = "Popstar's Microphone"};
        public static readonly Recipe CrimsonDragonRobe = new Recipe { Name = "Crimson Dragon Robe"};
        public static readonly Recipe CrimsonDragonCowl = new Recipe { Name = "Crimson Dragon Cowl"};
        public static readonly Recipe CrimsonWedgeHeels = new Recipe { Name = "Crimson Wedge Heels"};
        public static readonly Recipe AdamantiteKatana = new Recipe { Name = "Adamantite Katana"};
        public static readonly Recipe DiamondJacket = new Recipe { Name = "Diamond Jacket"};
        public static readonly Recipe GenbuRing = new Recipe { Name = "Genbu Ring"};
        public static readonly Recipe ByakkoRing = new Recipe { Name = "Byakko Ring"};
        public static readonly Recipe MetalGreaves = new Recipe { Name = "Metal Greaves"};
        public static readonly Recipe YinYangOrnament = new Recipe { Name = "Yin-Yang Ornament"};
        public static readonly Recipe EliteDogTag = new Recipe { Name = "Elite Dog Tag"};
        public static readonly Recipe AldoreSpecialOpsSword = new Recipe { Name = "Aldore Special Ops Sword"};
        public static readonly Recipe TypeAldoreRifle = new Recipe { Name = "Type-23 Aldore Rifle"};
        public static readonly Recipe DiamondSaber = new Recipe { Name = "Diamond Saber"};
        public static readonly Recipe JetBlackEyepatch = new Recipe { Name = "Jet Black Eyepatch"};
        public static readonly Recipe OctopathSpear = new Recipe { Name = "Octopath Spear"};
        public static readonly Recipe OctopathDagger = new Recipe { Name = "Octopath Dagger"};
        public static readonly Recipe JewelofStrength = new Recipe { Name = "Jewel of Strength"};
        public static readonly Recipe JewelofProtection = new Recipe { Name = "Jewel of Protection"};
        public static readonly Recipe CrystalCrownKH = new Recipe { Name = "Crystal Crown (KH)"};
        public static readonly Recipe EXPEarringKH = new Recipe { Name = "EXP Earring (KH)"};
        public static readonly Recipe MagesStaffKH = new Recipe { Name = "Mage's Staff (KH)"};
        public static readonly Recipe KnightsShieldKH = new Recipe { Name = "Knight's Shield (KH)"};
        public static readonly Recipe BeastCestus = new Recipe { Name = "Beast Cestus"};
        public static readonly Recipe TamersWhip = new Recipe { Name = "Tamer's Whip"};
        public static readonly Recipe BakuyaSword = new Recipe { Name = "Bakuya Sword"};
        public static readonly Recipe KanshouGreatSword = new Recipe { Name = "Kanshou Great Sword"};
        public static readonly Recipe RiceCakeShield = new Recipe { Name = "Rice Cake Shield"};
        public static readonly Recipe GiantChopstick = new Recipe { Name = "Giant Chopstick"};
        public static readonly Recipe DemonRevealingMirror = new Recipe { Name = "Demon-Revealing Mirror"};
        public static readonly Recipe TranscendentSoul = new Recipe { Name = "Transcendent Soul"};
        public static readonly Recipe DiamondHelm = new Recipe { Name = "Diamond Helm"};
        public static readonly Recipe DiamondLance = new Recipe { Name = "Diamond Lance"};
        public static readonly Recipe SoulofDarkness = new Recipe { Name = "Soul of Darkness"};
        public static readonly Recipe WovenTrapperCap = new Recipe { Name = "Woven Trapper Cap"};
        public static readonly Recipe EnchantedBrooch = new Recipe { Name = "Enchanted Brooch"};
        public static readonly Recipe TatteredOvercoat = new Recipe { Name = "Tattered Overcoat"};
        public static readonly Recipe ShatteredYari = new Recipe { Name = "Shattered Yari"};
        public static readonly Recipe CursedLocket = new Recipe { Name = "Cursed Locket"};
        public static readonly Recipe StoneBracer = new Recipe { Name = "Stone Bracer"};
        public static readonly Recipe StoneCrown = new Recipe { Name = "Stone Crown"};
        public static readonly Recipe StoneVest = new Recipe { Name = "Stone Vest"};
        public static readonly Recipe TectonicBracer = new Recipe { Name = "Tectonic Bracer"};
        public static readonly Recipe TectonicCrown = new Recipe { Name = "Tectonic Crown"};
        public static readonly Recipe TectonicVest = new Recipe { Name = "Tectonic Vest"};
        public static readonly Recipe DiamondTiara = new Recipe { Name = "Diamond Tiara"};
        public static readonly Recipe CrimsonsCoat = new Recipe { Name = "Crimson's Coat"};
        public static readonly Recipe BattleGarb = new Recipe { Name = "Battle Garb"};
        public static readonly Recipe DiamondStaff = new Recipe { Name = "Diamond Staff"};
        public static readonly Recipe GatlingArm = new Recipe { Name = "Gatling Arm"};
        public static readonly Recipe FrostedGown = new Recipe { Name = "Frosted Gown"};
        public static readonly Recipe FrostedStilettos = new Recipe { Name = "Frosted Stilettos"};
        public static readonly Recipe LuckyCloverHairpin = new Recipe { Name = "Lucky Clover Hairpin"};
        public static readonly Recipe FrostedMicrophone = new Recipe { Name = "Frosted Microphone"};
        public static readonly Recipe DiamondShieldFFBE = new Recipe { Name = "Diamond Shield (FFBE)"};
        public static readonly Recipe SilverKnightsGauntlet = new Recipe { Name = "Silver Knight's Gauntlet"};
        public static readonly Recipe Onimaru = new Recipe { Name = "Onimaru+"};
        public static readonly Recipe DiamondRod = new Recipe { Name = "Diamond Rod"};
        public static readonly Recipe DiamondBuckler = new Recipe { Name = "Diamond Buckler"};
        public static readonly Recipe PeaceRingFFVII = new Recipe { Name = "Peace Ring (FFVII)"};
        public static readonly Recipe StandardIssueSword = new Recipe { Name = "Standard-Issue Sword"};
        public static readonly Recipe ShinraAlpha = new Recipe { Name = "Shinra Alpha"};
        public static readonly Recipe CurseRingFFVII = new Recipe { Name = "Curse Ring (FFVII)"};
        public static readonly Recipe AmuletofDarkness = new Recipe { Name = "Amulet of Darkness"};
        public static readonly Recipe HoodofDarkness = new Recipe { Name = "Hood of Darkness"};
        public static readonly Recipe MantleofDarkness = new Recipe { Name = "Mantle of Darkness"};
        public static readonly Recipe AileensDress = new Recipe { Name = "Aileen’s Dress"};
        public static readonly Recipe ATypeRifleScope = new Recipe { Name = "A-Type Rifle Scope"};
        public static readonly Recipe FloralObi = new Recipe { Name = "Floral Obi"};
        public static readonly Recipe ThirdAnniversaryPartyGuest = new Recipe { Name = "Third Anniversary Party Guest"};
        public static readonly Recipe EsperOre = new Recipe { Name = "Esper Ore"};
        public static readonly Recipe RedEsperOre = new Recipe { Name = "Red Esper Ore"};
        public static readonly Recipe BlueEsperOre = new Recipe { Name = "Blue Esper Ore"};
        public static readonly Recipe GreenEsperOre = new Recipe { Name = "Green Esper Ore"};
        public static readonly Recipe WhiteEsperOre = new Recipe { Name = "White Esper Ore"};
        public static readonly Recipe BlackEsperOre = new Recipe { Name = "Black Esper Ore"};
        public static readonly Recipe YellowEsperOre = new Recipe { Name = "Yellow Esper Ore"};
        public static readonly Recipe OrangeEsperOre = new Recipe { Name = "Orange Esper Ore"};
        public static readonly Recipe VioletEsperOre = new Recipe { Name = "Violet Esper Ore"};
        public static readonly Recipe FanofFlames = new Recipe { Name = "Fan of Flames"};
        public static readonly Recipe HairpinofFlames = new Recipe { Name = "Hairpin of Flames"};
        public static readonly Recipe YukataofFlames = new Recipe { Name = "Yukata of Flames"};
        public static readonly Recipe FireFoxPlushie = new Recipe { Name = "Fire Fox Plushie"};
        public static readonly Recipe FireFoxMask = new Recipe { Name = "Fire Fox Mask"};
        public static readonly Recipe FireFoxCloak = new Recipe { Name = "Fire Fox Cloak"};
        public static readonly Recipe MPHaste = new Recipe { Name = "MP Haste"};
        public static readonly Recipe EXPBraceletKH = new Recipe { Name = "EXP Bracelet (KH)"};
        public static readonly Recipe DodgeRoll = new Recipe { Name = "Dodge Roll"};
        public static readonly Recipe SephirothsBootsKH = new Recipe { Name = "Sephiroth's Boots (KH)"};
        public static readonly Recipe FloatSandals = new Recipe { Name = "Float Sandals"};
        public static readonly Recipe BlackRobeFFV = new Recipe { Name = "Black Robe (FFV)"};
        public static readonly Recipe FlameRing = new Recipe { Name = "Flame Ring"};
        public static readonly Recipe CoralRing = new Recipe { Name = "Coral Ring"};
        public static readonly Recipe HeartsAgainsttheVoid = new Recipe { Name = "Hearts Against the Void"};
        public static readonly Recipe CharcoalRelic = new Recipe { Name = "Charcoal Relic"};
        public static readonly Recipe CharcoalHood = new Recipe { Name = "Charcoal Hood"};
        public static readonly Recipe CharcoalCloak = new Recipe { Name = "Charcoal Cloak"};
        public static readonly Recipe AshenRelic = new Recipe { Name = "Ashen Relic"};
        public static readonly Recipe AshenHood = new Recipe { Name = "Ashen Hood"};
        public static readonly Recipe AshenCloak = new Recipe { Name = "Ashen Cloak"};
        public static readonly Recipe CPRKit = new Recipe { Name = "CPR Kit"};
        public static readonly Recipe EnergizingShot = new Recipe { Name = "Energizing Shot"};
        public static readonly Recipe RestorativeShot = new Recipe { Name = "Restorative Shot"};
        public static readonly Recipe Flamboyant = new Recipe { Name = "Flamboyant"};
        public static readonly Recipe FourPointShuriken = new Recipe { Name = "Four-Point Shuriken"};
        public static readonly Recipe NinjaGearFFVI = new Recipe { Name = "Ninja Gear (FFVI)"};
        public static readonly Recipe KnowledgeofKatanasandRods = new Recipe { Name = "Knowledge of Katanas and Rods"};
        public static readonly Recipe KingRainsCloak = new Recipe { Name = "King Rain's Cloak"};
        public static readonly Recipe DemonSpear = new Recipe { Name = "Demon Spear"};
        public static readonly Recipe CombatCostume = new Recipe { Name = "Combat Costume"};
        public static readonly Recipe ScholarsSpecs = new Recipe { Name = "Scholar's Specs"};
        public static readonly Recipe PuffPuff = new Recipe { Name = "Puff-Puff"};
        public static readonly Recipe LibertyAction = new Recipe { Name = "Liberty Action"};
        public static readonly Recipe ToysWindUpKey = new Recipe { Name = "Toy's Wind-Up Key"};
        public static readonly Recipe ToyElfsHat = new Recipe { Name = "Toy Elf's Hat"};
        public static readonly Recipe ToyElfsTunic = new Recipe { Name = "Toy Elf's Tunic"};
        public static readonly Recipe FestiveSnowGlobe = new Recipe { Name = "Festive Snow Globe"};
        public static readonly Recipe FestiveReindeerAntlers = new Recipe { Name = "Festive Reindeer Antlers"};
        public static readonly Recipe FestiveElfSuit = new Recipe { Name = "Festive Elf Suit"};
        public static readonly Recipe BoxofRegalement = new Recipe { Name = "Box of Regalement"};
        public static readonly Recipe Snowball = new Recipe { Name = "Snowball"};
        public static readonly Recipe CrimsonEmpress = new Recipe { Name = "Crimson Empress"};
        public static readonly Recipe TruePremiumLeatherJacket = new Recipe { Name = "True Premium Leather Jacket"};
        public static readonly Recipe PremiumLeatherJacket = new Recipe { Name = "Premium Leather Jacket"};
        public static readonly Recipe ObsidianGreatsword = new Recipe { Name = "Obsidian Greatsword"};
        public static readonly Recipe EnduringFlame = new Recipe { Name = "Enduring Flame"};
        public static readonly Recipe PyroGlacialDefender = new Recipe { Name = "Pyro Glacial Defender"};
        public static readonly Recipe PurifiedRing = new Recipe { Name = "Purified Ring"};
        public static readonly Recipe FaithswornRing = new Recipe { Name = "Faithsworn Ring"};
        public static readonly Recipe MajesticHeaddressandHeadband = new Recipe { Name = "Majestic Headdress and Headband"};
        public static readonly Recipe ImperialHeaddressandHeadband = new Recipe { Name = "Imperial Headdress and Headband"};
        public static readonly Recipe RusticSandals = new Recipe { Name = "Rustic Sandals"};
        public static readonly Recipe RusticHeadscarf = new Recipe { Name = "Rustic Headscarf"};
        public static readonly Recipe RusticGarb = new Recipe { Name = "Rustic Garb"};
        public static readonly Recipe ElegantPendant = new Recipe { Name = "Elegant Pendant"};
        public static readonly Recipe ElegantHairOrnament = new Recipe { Name = "Elegant Hair Ornament"};
        public static readonly Recipe ElegantApparel = new Recipe { Name = "Elegant Apparel"};
        public static readonly Recipe FlameSwordFFIV = new Recipe { Name = "Flame Sword (FFIV)"};
        public static readonly Recipe SPR_904003180 = new Recipe { Name = "SPR +30%"};
        public static readonly Recipe RedPetals = new Recipe { Name = "Red Petals"};
        public static readonly Recipe FragrantFlowers = new Recipe { Name = "Fragrant Flowers"};
        public static readonly Recipe BouquetofRoses = new Recipe { Name = "Bouquet of Roses"};
        public static readonly Recipe LoveisVital = new Recipe { Name = "Love is Vital"};
        public static readonly Recipe LoveisMagical = new Recipe { Name = "Love is Magical"};
        public static readonly Recipe EdelsEarrings = new Recipe { Name = "Edel's Earrings"};
        public static readonly Recipe SniperGoggles = new Recipe { Name = "Sniper Goggles"};
        public static readonly Recipe Paikea = new Recipe { Name = "Paikea"};
        public static readonly Recipe Khandroma = new Recipe { Name = "Khandroma"};
        public static readonly Recipe CobraKnife = new Recipe { Name = "Cobra Knife"};
        public static readonly Recipe CobraHat = new Recipe { Name = "Cobra Hat"};
        public static readonly Recipe GunnerYunasDress = new Recipe { Name = "Gunner Yuna's Dress+"};
        public static readonly Recipe ThiefRikkusBandana = new Recipe { Name = "Thief Rikku's Bandana+"};
        public static readonly Recipe WarriorPainesGuise = new Recipe { Name = "Warrior Paine's Guise+"};
        public static readonly Recipe TheLivingofSpira_904003290 = new Recipe { Name = "The Living of Spira"};
        public static readonly Recipe TheLivingofSpira_904003300 = new Recipe { Name = "The Living of Spira+"};
        public static readonly Recipe StateAlchemistsWatch = new Recipe { Name = "State Alchemist's Watch"};
        public static readonly Recipe AlphonseDoll = new Recipe { Name = "Alphonse Doll"};
        public static readonly Recipe HawkeyesHandgun = new Recipe { Name = "Hawkeye's Handgun"};
        public static readonly Recipe WinrysBandana = new Recipe { Name = "Winry's Bandana"};
        public static readonly Recipe AldorePoliceMedal = new Recipe { Name = "Aldore Police Medal"};
        public static readonly Recipe InfernoSaber_904003460 = new Recipe { Name = "Inferno Saber+"};
        public static readonly Recipe InfernoSaber_904003470 = new Recipe { Name = "Inferno Saber++"};
        public static readonly Recipe DragonWingBow = new Recipe { Name = "Dragon Wing Bow+"};
        public static readonly Recipe DiabolossRod = new Recipe { Name = "Diabolos's Rod+"};
        public static readonly Recipe FierceGoddesssKatana = new Recipe { Name = "Fierce Goddess's Katana+"};
        public static readonly Recipe DarkGambanteinn_903020300 = new Recipe { Name = "Dark Gambanteinn (2★)"};
        public static readonly Recipe DarkGambanteinn_903020310 = new Recipe { Name = "Dark Gambanteinn (3★)"};
        public static readonly Recipe DarkGambanteinn_903020320 = new Recipe { Name = "Dark Gambanteinn (4★)"};
        public static readonly Recipe DarkGambanteinn_903020330 = new Recipe { Name = "Dark Gambanteinn (5★)"};
        public static readonly Recipe DarkGambanteinn_903020340 = new Recipe { Name = "Dark Gambanteinn+ (6★)"};
        public static readonly Recipe DarkGambanteinn_903020350 = new Recipe { Name = "Dark Gambanteinn+ (7★)"};
        public static readonly Recipe DarkGambanteinn_903020360 = new Recipe { Name = "Dark Gambanteinn+ (8★)"};
        public static readonly Recipe DarkGambanteinn_903020370 = new Recipe { Name = "Dark Gambanteinn+ (9★)"};
        public static readonly Recipe DarkGambanteinn_903020380 = new Recipe { Name = "Dark Gambanteinn++ (10★)"};
        public static readonly Recipe DarkRagnarok_903020110 = new Recipe { Name = "Dark Ragnarok (2★)"};
        public static readonly Recipe DarkRagnarok_903020120 = new Recipe { Name = "Dark Ragnarok (3★)"};
        public static readonly Recipe DarkRagnarok_903020130 = new Recipe { Name = "Dark Ragnarok (4★)"};
        public static readonly Recipe DarkRagnarok_903020140 = new Recipe { Name = "Dark Ragnarok (5★)"};
        public static readonly Recipe DarkRagnarok_903020150 = new Recipe { Name = "Dark Ragnarok+ (6★)"};
        public static readonly Recipe DarkRagnarok_903020160 = new Recipe { Name = "Dark Ragnarok+ (7★)"};
        public static readonly Recipe DarkRagnarok_903020170 = new Recipe { Name = "Dark Ragnarok+ (8★)"};
        public static readonly Recipe DarkRagnarok_903020180 = new Recipe { Name = "Dark Ragnarok+ (9★)"};
        public static readonly Recipe DarkRagnarok_903020190 = new Recipe { Name = "Dark Ragnarok++ (10★)"};
        public static readonly Recipe MagicBangle_904003250 = new Recipe { Name = "Magic Bangle+"};
        public static readonly Recipe MagicBangle_904003260 = new Recipe { Name = "Magic Bangle"};
        public static readonly Recipe EmeraldNecklace = new Recipe { Name = "Emerald Necklace"};
        public static readonly Recipe DropfromtheHolyGrail = new Recipe { Name = "Drop from the Holy Grail"};
        public static readonly Recipe IceDemonsKatana_903020200 = new Recipe { Name = "Ice Demon's Katana+"};
        public static readonly Recipe IceDemonsKatana_903020210 = new Recipe { Name = "Ice Demon's Katana++"};
        public static readonly Recipe KnightRidersBlade = new Recipe { Name = "Knight Rider's Blade+"};
        public static readonly Recipe WindSpritesSpear = new Recipe { Name = "Wind Sprite's Spear+"};
        public static readonly Recipe SacredCastlesShield = new Recipe { Name = "Sacred Castle's Shield+"};
        public static readonly Recipe NightbringerWolfsHandgun = new Recipe { Name = "Nightbringer Wolf's Handgun+"};
        public static readonly Recipe VanillesClothes = new Recipe { Name = "Vanille's Clothes"};
        public static readonly Recipe FangsClothes = new Recipe { Name = "Fang's Clothes"};
        public static readonly Recipe VanillesBag = new Recipe { Name = "Vanille's Bag"};
        public static readonly Recipe FangsNecklace = new Recipe { Name = "Fang's Necklace"};
        public static readonly Recipe DurableGoldBangleFFXIII = new Recipe { Name = "Durable Gold Bangle (FFXIII-2)"};
        public static readonly Recipe DurableMagiciansMarkFFXIII = new Recipe { Name = "Durable Magician's Mark (FFXIII-2)"};
        public static readonly Recipe GrieverLoneLion = new Recipe { Name = "Griever (Lone Lion)"};
        public static readonly Recipe SeifersCoatDisciplined = new Recipe { Name = "Seifer's Coat (Disciplined)"};
        public static readonly Recipe TengallonHat = new Recipe { Name = "Ten-gallon Hat"};
        public static readonly Recipe GardenGirlsUniform = new Recipe { Name = "Garden Girls' Uniform"};
        public static readonly Recipe IrvinesCoat = new Recipe { Name = "Irvine's Coat"};
        public static readonly Recipe SelphiesDress = new Recipe { Name = "Selphie's Dress"};
        public static readonly Recipe OraclesCodex = new Recipe { Name = "Oracle's Codex+"};
        public static readonly Recipe HoarfrostDagger = new Recipe { Name = "Hoarfrost Dagger+"};

		public static readonly List<Recipe> Recipes = new List<Recipe>
		{
           Potion,
           HiPotion,
           Ether,
           Antidote,
           EyeDrops,
           SmellingSalts,
           EchoHerbs,
           UnicornHorn,
           Vaccine,
           GoldNeedle,
           Remedy,
           Hyper,
           HealingSpring,
           SmokeScreen,
           BodyBoost,
           ManaTablet,
           ProtectDrink,
           ShellDrink,
           BacchussWine,
           Grenade,
           FragGrenade,
           Shuriken,
           FumaShuriken,
           Tent,
           MagicKey,
           BronzeKnife,
           Dagger,
           SleepDagger,
           Broadsword,
           LongSword,
           GreatSword,
           BusterSword,
           Kotetsu,
           Kikuichimonji,
           Kazekiri,
           Kodachi,
           BattleAxe,
           GreatAxe,
           WoodenHammer,
           IronHammer,
           WarHammer,
           BronzeMace,
           IronMace,
           Javelin,
           Partisan,
           BronzeKnuckles,
           MetalKnuckles,
           CatClaws,
           Rod,
           IronRod,
           Staff,
           CherryStaff,
           WizardsStaff,
           RuneStaff,
           ShortBow,
           LongBow,
           GreatBow,
           Altair,
           LeatherWhip,
           ChainWhip,
           Boomerang,
           Chakram,
           MoonRingBlade,
           Harp,
           SilverHarp,
           LeatherShield,
           SmallShield,
           Buckler,
           BronzeShield,
           IronShield,
           LeatherHat,
           FeatheredCap,
           WizardsHat,
           Bandana,
           CelebrantsMiter,
           HypnoCrown,
           RedCap,
           BronzeHelm,
           IronHelm,
           LeatherShirt,
           BardsTunic,
           ScholarRobe,
           PowerVest,
           Kenpogi,
           MagesHabit,
           SurvivalVest,
           NinjaGear,
           BlackBeltGi,
           LeatherPlate,
           CopperCuirass,
           IronPlate,
           BronzeArmor,
           IronArmor,
           CottonRobe,
           SilkRobe,
           TravelersGarbs,
           GaiaGear,
           ClericsRobes,
           IronGloves,
           PowerWrist,
           HyperWrist,
           SilverArmlet,
           FireRing,
           IceRing,
           SparkRing,
           WaterRing,
           GaleRing,
           EarthRing,
           ProtectRing,
           BarrierRing,
           RegenRing,
           CatsBell,
           HerosRing,
           MuscleBelt,
           Libra,
           Cure,
           Blindna,
           Vox,
           Poisona,
           Paralyna,
           Stona,
           Fire,
           Blizzard,
           Thunder,
           Water,
           Aero,
           Stone,
           Bio,
           Blizzara,
           Thundara,
           Watera,
           Aerora,
           Gravity,
           Drain,
           Biora,
           Sleep,
           Blind,
           Barfire,
           Barblizzard,
           Barthunder,
           Barwater,
           Baraero,
           Barstone,
           Silence,
           Barfira,
           Barblizzara,
           Barthundara,
           Shell,
           Deshell,
           Barwatera,
           Baraerora,
           Barstonra,
           Steal,
           Brace,
           FireBlade,
           BlizzardBlade,
           SilenceBlade,
           WaterBlade,
           StoneBlade,
           BlindBlade,
           BioBlade,
           MagicInfuse,
           MentalBreak,
           BioBlaster,
           BombFragment,
           FishScale,
           GiantFeather,
           Pinwheel,
           Icebrand,
           CoralSword,
           FireRod,
           Capella,
           ShockWhip,
           OchreShield,
           GreenBeret,
           Barbut,
           SagesSurplice,
           Protect,
           MP_905100040,
           SPR_905100160,
           BugKiller,
           XPotion,
           TurboEther,
           HolyTorch,
           MythrilSpear,
           MagesHat,
           SagesRobe,
           MythrilGloves,
           Cura,
           DEF,
           MythrilHammer,
           WindSpear,
           MythrilHelm,
           Bravery,
           MAG,
           FineBlade,
           SuperiorBlade,
           AntarcticWind,
           ZeussRage,
           EarthDrum,
           MythrilDagger,
           MainGauche,
           MythrilSword,
           Osafune,
           MythrilMace,
           MythrilClaws,
           MythrilBow,
           MythrilWhip,
           MythrilBuckler,
           LargeShield,
           MythrilShield,
           TigerMask,
           MythrilPlate,
           SilverCuirass,
           PaladinArmor,
           MythrilArmor,
           WizardsRobe,
           MoonBracer,
           Dispel,
           Faith,
           SpiritSlayer,
           HP_905101500,
           SleepBlade,
           AeroBlade,
           StonraBlade_905200660,
           VorpalAxe,
           GaeBolg,
           LightCurtain,
           WyvernsFeather,
           WhiteFang,
           MythrilSaber,
           Chirijiraden,
           MythrilAxe,
           Escutcheon,
           Brigandine,
           Curaga,
           EVOMAG,
           WateraBlade,
           WingedSaint,
           MoraleTalisman,
           RodofGravity,
           VoidVessel,
           StonraBlade_1000000004,
           HP_1000000005,
           BurstShot,
           StandardMogcakePack,
           RareMogcakePack,
           PremiumMogcakePack,
           LunarCurtain,
           NorthWind,
           Flametongue,
           ATK,
           AutoProtect,
           BioraBlade,
           RightArm,
           BlueFang,
           SleepSword,
           FlameLance,
           PoisonKnuckles,
           ThunderShield,
           IceArmor,
           AutoShell,
           OsmoseBlade,
           ShiningSplendor,
           YPotion,
           MegaEther,
           BloodSword,
           RedFang,
           Trident,
           RodofLightning,
           ElvenBow,
           FlameMail,
           Death,
           BirdKiller,
           AutoPotion,
           PowerBreak,
           MagicBreak,
           GiantsAxe,
           Werebuster,
           IceLance,
           IceRod,
           Sirius,
           MysteryVeil,
           GoldenArmor,
           BlackRobe,
           UndeadKiller,
           ArmorBreak,
           ThunderBlade,
           MonarchsRing,
           DominationRing,
           RulersRing,
           RingofDominion,
           HeavenlyWrath,
           DragonScale_901000350,
           GoldenStaff,
           BlessedHammer,
           IceShield,
           GoldenVest,
           WhiteRobe,
           BuddingMapleWand,
           ScionConjurersDalmatica,
           ScionConjurersPattens,
           CobaltWinglet,
           AntecedentsAttire,
           MeteorSurvivorRing,
           UldahnFalchion,
           ScionThiefsTunic,
           ScionThiefsHalfgloves,
           GaiasCry,
           GoldenBlade,
           FlameShield,
           Circlet,
           AngelRing,
           BasiliskSteel,
           Razzmatazz,
           HyperBall,
           Override,
           ThunderSpear,
           Betelgeuse,
           GoldenShield,
           Imperil,
           Microphone_1000000014,
           EveningGloves,
           BunnyMask_1000000016,
           StylishBlackDress_1000000017,
           MemoryCandy,
           MageMasher,
           RasAlgethi,
           GalkanDagger,
           LeucosVoulge,
           ThothsWand,
           OrcPiercer,
           Retaliator,
           IridalStaff,
           TacticianMagiciansWand,
           SharkGun,
           SlickDart,
           Raikiri,
           MoogleSpear,
           BreakShot,
           TwinWhip,
           Microphone_903001290,
           TorrentRing,
           DivineShield,
           RavenBeret,
           TacticianMagiciansCoat,
           ParadeCuirass,
           GoldenHairpin,
           ParadeGorget,
           MoogleCrown,
           MoogleCape,
           UnsuiClothes,
           GoldenHelm,
           FestivalRobe_904001710,
           FestivalCap_904001720,
           PlatinumTiara,
           Fransisca,
           GloryStaff,
           KrisKnife,
           RoyalRing,
           EveningGlove,
           BunnyMask_904001810,
           StylishBlackDress_904001820,
           Darkra,
           DragonKiller,
           MogSearch,
           MogResist,
           MogRise,
           FiraBlade,
           ChocolateEgg,
           GreatEgg,
           MagicalEgg,
           RadiantEgg,
           StaffofWrath,
           CrownofJustice_1000000025,
           BlackBandana_1000000026,
           SecondKnife,
           IcyVeins_1000000028,
           ColdSnap,
           DrakesclawRod,
           DrakesguardRobe,
           BahamutsFang,
           DragonsRoar,
           GutsKnuckle,
           GoldenEye,
           ScionStrikersVisor,
           ScionStrikersAttire,
           ScionThaumaturgesMonocle,
           ScionThaumaturgesRobe,
           Adventurer,
           AdventurerII,
           AdventurerIII,
           AdventurerIV,
           AdventurerV,
           BrokenArm,
           AngelWand,
           PlatinumMusket,
           AncientOverlord,
           IronWill,
           DragoonLance,
           TypeFists,
           CruelOath,
           BellowsArmGuard,
           MagicBarrierDevice,
           ZDHelmet,
           AngelWing,
           PlatinumRobe,
           SeraphimShield,
           EmilsHead,
           HeavyArmorB,
           PlatinaArmor,
           BlizzaraBlade,
           ThundaraBlade,
           AeroraBlade,
           PlatinumDagger,
           ValiantII,
           PrecisionLance,
           Valiant,
           CypressPile,
           PlatinumSaber,
           Darkbringer,
           YggdrasilStaff,
           Dragvandil,
           SweetKiss,
           PlatinumMace,
           PlatinumWhip,
           TamersGloves,
           SecretKnife,
           StaffofResentment,
           PlatinumEdge,
           FierceBow,
           Kogarasumaru,
           ScarletRoses,
           Takemikazuchi,
           MetalPipe,
           PlatinumAxe,
           RubberSuit,
           A1ClassPowershield,
           AssistSuit,
           ChobhamArmor,
           TacticalManual,
           MagnoliasUniform,
           IcyVeins_904002010,
           BlackBandana_904002020,
           CrownofJustice_904002030,
           JeweledBelt,
           PlatinumBreastplate,
           RiotGear,
           PlatinumShield,
           TrueShardofGenius,
           TrueFollowersOath,
           TrueHydaelynGuard,
           TrueSpiritofFreedom,
           TrueSagesPrajna,
           Kappower,
           AutoBravery,
           AutoFaith,
           MP_905100370,
           KittyHeadband,
           CloakofResentment,
           SparklingHeels,
           EvilPipe,
           PinkStripedFloat,
           CheerfulTune,
           JoyfulSpirit,
           Lightbringer,
           GraspingSphere,
           StaffofBlizzards,
           WingEdges,
           SalamandersGauntlets,
           CragSplitter,
           FlaxShield,
           JadeMoonPendant,
           JadeSunPendant,
           FieryPassion,
           StaffofOsiris_1000000055,
           IcyDeath,
           Flamethrower_1000000057,
           ToxicShotgun_1000000058,
           OnyxSpiritofRa,
           GoldRingofSet,
           PlatinumLance,
           PlatinumBow,
           DiamondKnife,
           DragonScale_904002080,
           SagesStaff,
           SacredClaws,
           DragovianSpear,
           WolfMask,
           FestivalRobe_904002140,
           FestivalCap_904002150,
           YinYangCharm_904002180,
           SantasClothesII,
           SantasHatII,
           TsukumoDoll_904002210,
           KimonoVest_904002220,
           SantasCane,
           PlatinumFist,
           GemofCreation,
           GemofVision,
           NibelungenRing,
           DragoonTyrant,
           RustRedCirclet,
           DiamondRobe,
           FaerieCloak,
           FlowerSuit,
           MagicalArmor,
           FrostyRing,
           StaffofOsiris_904002370,
           ToxicShotgun_904002380,
           Flamethrower_904002390,
           GoldRingofSeth,
           DiamondSword,
           DiamondArmor,
           RicosWingsuit,
           GE_1000000062,
           RicosCombatGloves,
           UVK,
           CSWraithR,
           UZabijak,
           YinYangCharm_1000000067,
           VestmentofPrayers,
           WhiteBandana,
           TsukumoDoll_1000000070,
           KimonoVest_1000000071,
           ElvenStaff,
           ZenithZAP,
           TITAN,
           EMPGrenade,
           CtedAzurSOW,
           NukeVirusSoftware,
           LinebackerGMSGL,
           SturdyUmbrella,
           BeachBall,
           GE_1000000081,
           SplashofLife,
           RavenFigurine,
           HalfCrescentRod,
           AvianCloak,
           EmpoweredGauntlets,
           BizarreSculpture,
           BigRedRibbon,
           CrimsonVest,
           GallantBelt,
           Strength,
           Etherize,
           DiamondBreastplate,
           BlackLeather,
           YamatoBelt,
           Shielder,
           Soulful,
           TornDress,
           MetalEarrings,
           EternalFlame,
           RuinedShield,
           KatanaProficiency,
           SpiritualProficiency,
           DemonicMight,
           DemonicMind,
           PopstarsMicrophone,
           CrimsonDragonRobe,
           CrimsonDragonCowl,
           CrimsonWedgeHeels,
           AdamantiteKatana,
           DiamondJacket,
           GenbuRing,
           ByakkoRing,
           MetalGreaves,
           YinYangOrnament,
           EliteDogTag,
           AldoreSpecialOpsSword,
           TypeAldoreRifle,
           DiamondSaber,
           JetBlackEyepatch,
           OctopathSpear,
           OctopathDagger,
           JewelofStrength,
           JewelofProtection,
           CrystalCrownKH,
           EXPEarringKH,
           MagesStaffKH,
           KnightsShieldKH,
           BeastCestus,
           TamersWhip,
           BakuyaSword,
           KanshouGreatSword,
           RiceCakeShield,
           GiantChopstick,
           DemonRevealingMirror,
           TranscendentSoul,
           DiamondHelm,
           DiamondLance,
           SoulofDarkness,
           WovenTrapperCap,
           EnchantedBrooch,
           TatteredOvercoat,
           ShatteredYari,
           CursedLocket,
           StoneBracer,
           StoneCrown,
           StoneVest,
           TectonicBracer,
           TectonicCrown,
           TectonicVest,
           DiamondTiara,
           CrimsonsCoat,
           BattleGarb,
           DiamondStaff,
           GatlingArm,
           FrostedGown,
           FrostedStilettos,
           LuckyCloverHairpin,
           FrostedMicrophone,
           DiamondShieldFFBE,
           SilverKnightsGauntlet,
           Onimaru,
           DiamondRod,
           DiamondBuckler,
           PeaceRingFFVII,
           StandardIssueSword,
           ShinraAlpha,
           CurseRingFFVII,
           AmuletofDarkness,
           HoodofDarkness,
           MantleofDarkness,
           AileensDress,
           ATypeRifleScope,
           FloralObi,
           ThirdAnniversaryPartyGuest,
           EsperOre,
           RedEsperOre,
           BlueEsperOre,
           GreenEsperOre,
           WhiteEsperOre,
           BlackEsperOre,
           YellowEsperOre,
           OrangeEsperOre,
           VioletEsperOre,
           FanofFlames,
           HairpinofFlames,
           YukataofFlames,
           FireFoxPlushie,
           FireFoxMask,
           FireFoxCloak,
           MPHaste,
           EXPBraceletKH,
           DodgeRoll,
           SephirothsBootsKH,
           FloatSandals,
           BlackRobeFFV,
           FlameRing,
           CoralRing,
           HeartsAgainsttheVoid,
           CharcoalRelic,
           CharcoalHood,
           CharcoalCloak,
           AshenRelic,
           AshenHood,
           AshenCloak,
           CPRKit,
           EnergizingShot,
           RestorativeShot,
           Flamboyant,
           FourPointShuriken,
           NinjaGearFFVI,
           KnowledgeofKatanasandRods,
           KingRainsCloak,
           DemonSpear,
           CombatCostume,
           ScholarsSpecs,
           PuffPuff,
           LibertyAction,
           ToysWindUpKey,
           ToyElfsHat,
           ToyElfsTunic,
           FestiveSnowGlobe,
           FestiveReindeerAntlers,
           FestiveElfSuit,
           BoxofRegalement,
           Snowball,
           CrimsonEmpress,
           TruePremiumLeatherJacket,
           PremiumLeatherJacket,
           ObsidianGreatsword,
           EnduringFlame,
           PyroGlacialDefender,
           PurifiedRing,
           FaithswornRing,
           MajesticHeaddressandHeadband,
           ImperialHeaddressandHeadband,
           RusticSandals,
           RusticHeadscarf,
           RusticGarb,
           ElegantPendant,
           ElegantHairOrnament,
           ElegantApparel,
           FlameSwordFFIV,
           SPR_904003180,
           RedPetals,
           FragrantFlowers,
           BouquetofRoses,
           LoveisVital,
           LoveisMagical,
           EdelsEarrings,
           SniperGoggles,
           Paikea,
           Khandroma,
           CobraKnife,
           CobraHat,
           GunnerYunasDress,
           ThiefRikkusBandana,
           WarriorPainesGuise,
           TheLivingofSpira_904003290,
           TheLivingofSpira_904003300,
           StateAlchemistsWatch,
           AlphonseDoll,
           HawkeyesHandgun,
           WinrysBandana,
           AldorePoliceMedal,
           InfernoSaber_904003460,
           InfernoSaber_904003470,
           DragonWingBow,
           DiabolossRod,
           FierceGoddesssKatana,
           DarkGambanteinn_903020300,
           DarkGambanteinn_903020310,
           DarkGambanteinn_903020320,
           DarkGambanteinn_903020330,
           DarkGambanteinn_903020340,
           DarkGambanteinn_903020350,
           DarkGambanteinn_903020360,
           DarkGambanteinn_903020370,
           DarkGambanteinn_903020380,
           DarkRagnarok_903020110,
           DarkRagnarok_903020120,
           DarkRagnarok_903020130,
           DarkRagnarok_903020140,
           DarkRagnarok_903020150,
           DarkRagnarok_903020160,
           DarkRagnarok_903020170,
           DarkRagnarok_903020180,
           DarkRagnarok_903020190,
           MagicBangle_904003250,
           MagicBangle_904003260,
           EmeraldNecklace,
           DropfromtheHolyGrail,
           IceDemonsKatana_903020200,
           IceDemonsKatana_903020210,
           KnightRidersBlade,
           WindSpritesSpear,
           SacredCastlesShield,
           NightbringerWolfsHandgun,
           VanillesClothes,
           FangsClothes,
           VanillesBag,
           FangsNecklace,
           DurableGoldBangleFFXIII,
           DurableMagiciansMarkFFXIII,
           GrieverLoneLion,
           SeifersCoatDisciplined,
           TengallonHat,
           GardenGirlsUniform,
           IrvinesCoat,
           SelphiesDress,
           OraclesCodex,
           HoarfrostDagger,
		};
    }
}