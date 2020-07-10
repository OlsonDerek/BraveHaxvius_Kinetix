using System;
using System.Collections.Generic;

namespace BraveHaxvius.Data
{
    public class ImportantItem
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public String CountId { get; set; }
        public String ItemStack { get; set; }
        public String ItemIdClone { get; set; }
        public String SublimationUnitId { get; set; }

        public static readonly ImportantItem Crest = new ImportantItem { Name = "Crest"};
        public static readonly ImportantItem EXPKey = new ImportantItem { Name = "EXP Key"};
        public static readonly ImportantItem JeweledKey = new ImportantItem { Name = "Jeweled Key"};
        public static readonly ImportantItem RareSummonTicket = new ImportantItem { Name = "Rare Summon Ticket"};
        public static readonly ImportantItem ArenaSummonTicket = new ImportantItem { Name = "Arena Summon Ticket"};
        public static readonly ImportantItem GuaranteedTicket = new ImportantItem { Name = "4★+ Guaranteed Ticket"};
        public static readonly ImportantItem NRGRestore_100 = new ImportantItem { Name = "NRG Restore 10"};
        public static readonly ImportantItem NRGRestore_110 = new ImportantItem { Name = "NRG Restore 30"};
        public static readonly ImportantItem NRGRestore_120 = new ImportantItem { Name = "NRG Restore 50"};
        public static readonly ImportantItem EXSummonTicket = new ImportantItem { Name = "EX Summon Ticket"};
        public static readonly ImportantItem GuaranteedEXTicket_170 = new ImportantItem { Name = "4★+ Guaranteed EX Ticket"};
        public static readonly ImportantItem GuaranteedEXTicket_180 = new ImportantItem { Name = "5★ Guaranteed EX Ticket"};
        public static readonly ImportantItem SpecialPass = new ImportantItem { Name = "Special Pass"};
        public static readonly ImportantItem ArenaRestore = new ImportantItem { Name = "Arena Restore"};
        public static readonly ImportantItem RaidRestore_903 = new ImportantItem { Name = "Raid Restore"};
        public static readonly ImportantItem ExpansionVoucher = new ImportantItem { Name = "Expansion Voucher"};
        public static readonly ImportantItem AncientCoin = new ImportantItem { Name = "Ancient Coin"};
        public static readonly ImportantItem AdvanceToken = new ImportantItem { Name = "Advance Token"};
        public static readonly ImportantItem SummonTicket_210 = new ImportantItem { Name = "30% 4★ Summon Ticket"};
        public static readonly ImportantItem SummonTicket_220 = new ImportantItem { Name = "50% 4★ Summon Ticket"};
        public static readonly ImportantItem SummonTicket_230 = new ImportantItem { Name = "10% 5★ Summon Ticket"};
        public static readonly ImportantItem SummonTicket_240 = new ImportantItem { Name = "30% 5★ Summon Ticket"};
        public static readonly ImportantItem SummonTicket_250 = new ImportantItem { Name = "50% 5★ Summon Ticket"};
        public static readonly ImportantItem SelectSummonTicket = new ImportantItem { Name = "5★ Select Summon Ticket"};
        public static readonly ImportantItem GreenClover = new ImportantItem { Name = "Green Clover"};
        public static readonly ImportantItem NagasBlood = new ImportantItem { Name = "Naga's Blood"};
        public static readonly ImportantItem NRGLightSphere = new ImportantItem { Name = "NRG Light Sphere"};
        public static readonly ImportantItem PremiumSummonTicket = new ImportantItem { Name = "Premium 10+1 Summon Ticket"};
        public static readonly ImportantItem GuaranteedSummonTicket = new ImportantItem { Name = "5★ Guaranteed 10+1 Summon Ticket"};
        public static readonly ImportantItem SpecialReturnSummonTicket_910 = new ImportantItem { Name = "Special Return 3★+ Summon Ticket"};
        public static readonly ImportantItem SpecialReturnSummonTicket_911 = new ImportantItem { Name = "Special Return 4★+ Summon Ticket"};
        public static readonly ImportantItem EquipmentEnhancementOrbRestore = new ImportantItem { Name = "Equipment Enhancement Orb Restore"};
        public static readonly ImportantItem YearAnniversarySpecialSummonTicket_280 = new ImportantItem { Name = "2 Year Anniversary Special Summon Ticket"};
        public static readonly ImportantItem YearAnniversarySpecialSummonTicket_290 = new ImportantItem { Name = "2 Year Anniversary 4★+ Special Summon Ticket"};
        public static readonly ImportantItem SummonTicket_912 = new ImportantItem { Name = "5+1 Summon Ticket"};
        public static readonly ImportantItem TrustCoin = new ImportantItem { Name = "Trust Coin"};
        public static readonly ImportantItem FMABROTHERHOODSummonTicket = new ImportantItem { Name = "FMA BROTHERHOOD Summon Ticket"};
        public static readonly ImportantItem RaidRestore_310 = new ImportantItem { Name = "Raid Restore"};
        public static readonly ImportantItem FFVIIIFeaturedSummonTicket = new ImportantItem { Name = "FFVIII Featured Summon Ticket"};
        public static readonly ImportantItem FFBEthAnniversaryNextEraTicket = new ImportantItem { Name = "FFBE 4th Anniversary: Next Era Ticket"};
        public static readonly ImportantItem FFBEthAnniversaryNextEraIITicket = new ImportantItem { Name = "FFBE 4th Anniversary: Next Era II Ticket"};
        public static readonly ImportantItem FFBEthAnniversaryNextEraIIITicket = new ImportantItem { Name = "FFBE 4th Anniversary: Next Era III Ticket"};
        public static readonly ImportantItem FFTYPEFeaturedSummonTicket = new ImportantItem { Name = "FF TYPE-0 Featured Summon Ticket"};

		public static readonly List<ImportantItem> ImportantItems = new List<ImportantItem>
		{
           Crest,
           EXPKey,
           JeweledKey,
           RareSummonTicket,
           ArenaSummonTicket,
           GuaranteedTicket,
           NRGRestore_100,
           NRGRestore_110,
           NRGRestore_120,
           EXSummonTicket,
           GuaranteedEXTicket_170,
           GuaranteedEXTicket_180,
           SpecialPass,
           ArenaRestore,
           RaidRestore_903,
           ExpansionVoucher,
           AncientCoin,
           AdvanceToken,
           SummonTicket_210,
           SummonTicket_220,
           SummonTicket_230,
           SummonTicket_240,
           SummonTicket_250,
           SelectSummonTicket,
           GreenClover,
           NagasBlood,
           NRGLightSphere,
           PremiumSummonTicket,
           GuaranteedSummonTicket,
           SpecialReturnSummonTicket_910,
           SpecialReturnSummonTicket_911,
           EquipmentEnhancementOrbRestore,
           YearAnniversarySpecialSummonTicket_280,
           YearAnniversarySpecialSummonTicket_290,
           SummonTicket_912,
           TrustCoin,
           FMABROTHERHOODSummonTicket,
           RaidRestore_310,
           FFVIIIFeaturedSummonTicket,
           FFBEthAnniversaryNextEraTicket,
           FFBEthAnniversaryNextEraIITicket,
           FFBEthAnniversaryNextEraIIITicket,
           FFTYPEFeaturedSummonTicket,
		};
    }
}