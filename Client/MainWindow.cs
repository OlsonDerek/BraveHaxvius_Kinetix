using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BraveHaxvius;
using BraveHaxvius.Data;
using Client.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Client
{
    public partial class MainWindow : Form
    {
        BraveExvius client = new BraveExvius();
        DataTable injectDataTable = new DataTable();
        JToken Gachas;
        List<Sell> sellable = new List<Sell>();
        int RunMissionCount = 0;
        bool StopForArena = false;
        bool StopForRaid = false;
        public int ChangeParty = -1;
        public int RaidParty = -1;
        public bool Verbose = false;
        List<Mission> QueuedMissions = new List<Mission>();

        public MainWindow()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            InitStaticItems();
            client.FacebookUserId = fbidInput.Text;
            client.FacebookToken = fbtokenInput.Text;
            client.ProxyIpAddr = ProxyIP.Text;
            if (!String.IsNullOrWhiteSpace(ProxyIP.Text))
                client.ProxyPort = int.Parse(ProxyPort.Text);
            Logger.LogHook = Hook;
        }
        public void Hook(String s)
        {
            consoleLog.Focus();
            consoleLog.AppendText(s + "\r\n");

            consoleLog.SelectionStart = consoleLog.Text.Length;
            consoleLog.ScrollToCaret();
        }
        private void InitStaticItems()
        {
            injectDataTable.Columns.Add("Count");
            injectDataTable.Columns.Add("Type");
            injectDataTable.Columns.Add("Name");
            injectDataTable.Columns.Add("ID");
            Item.Items.FindAll(i => i.Description != null).ForEach(i => injectDataTable.Rows.Add(0, "item", i.Name, i.ItemId));
            Equipment.Equipments.FindAll(i => i.Description != null).ForEach(i => injectDataTable.Rows.Add(0, "equip", i.Name, i.EquipId));
            Materia.Materias.FindAll(i => i.Description != null).ForEach(i => injectDataTable.Rows.Add(0, "materia", i.Name, i.MateriaId));
            injectDataGrid.DataSource = injectDataTable;

            Unit.Units.FindAll(u => u.Description != null && u.IsSummonable == "1" && u.UnitId == u.BaseUnitId);
            List<Mission> list = new List<Mission>();
            Mission.Missions.FindAll(i => i.Description != null).ForEach(i => list.Add(i));

            unitSelect.DataSource = Unit.Units.FindAll(u => u.Description != null && u.IsSummonable == "1" && u.UnitId == u.BaseUnitId);
            unitSelect.DisplayMember = "Name";

            missionSelect.DataSource = list;
            missionSelect.DisplayMember = "NameId";
            missionSelect.SelectedItem = list.Find(x => x.MissionId == "11420201");

            var raidList = list.FindAll(i => i.Raid == "1");
            raidList.Reverse();
            raidMissionSelect.DataSource = raidList;
            raidMissionSelect.DisplayMember = "Name";

            comboBox1.DataSource = new List<int>() { 0, 1, 2, 3, 4, 5 };
            raidTeamComboBox.DataSource = new List<int>() { 0, 1, 2, 3, 4, 5 };

        }
        private void InitGacha(BraveExvius b)
        {
            Gachas = b.GetUserInfo[GameObject.GachaScheduleMst];

            foreach (var gacha in b.GachaId)
                JPGacha.Items.Add(gacha);

            JPGacha.SelectedIndex = 0;

            foreach (var ticket in Ticket.Tickets)
                JPGachaTicket.Items.Add(ticket.Name);

            JPGachaTicket.SelectedIndex = 0;
        }
        private void InjectSearchInput_TextChanged(object sender, EventArgs e)
        {
            injectDataTable.DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", injectSearchInput.Text);
        }
        private void InjectButton_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                injectButton.Enabled = false;
                var itemHax = String.Join(",", injectDataTable.Rows.Cast<DataRow>().ToList().FindAll(i => i.ItemArray[1].ToString() == "item" && i.ItemArray[0].ToString() != "0").Select(i => "20:" + i.ItemArray[3] + ":" + i.ItemArray[0]));
                var equipmentHax = String.Join(",", injectDataTable.Rows.Cast<DataRow>().ToList().FindAll(i => i.ItemArray[1].ToString() == "equip" && i.ItemArray[0].ToString() != "0").Select(i => "21:" + i.ItemArray[3] + ":" + i.ItemArray[0]));
                var materiaHax = String.Join(",", injectDataTable.Rows.Cast<DataRow>().ToList().FindAll(i => i.ItemArray[1].ToString() == "materia" && i.ItemArray[0].ToString() != "0").Select(i => "22:" + i.ItemArray[3] + ":" + i.ItemArray[0]));
                client.Login();
                client.DoMission(Mission.AirshipDeck, false, itemHax, equipmentHax, materiaHax);
                injectButton.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }
        private void SummonButton_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                Func<int, int> iteration = i =>
                {
                    summonButton.Text = (i + 1).ToString() + "...";
                    return 1;
                };
                summonButton.Enabled = false;
                var unit = unitSelect.SelectedItem as Unit;
                client.Login();
                client.UnitHunterNew(unit, sell3Star.Checked, sell4Star.Checked, sell5Star.Checked, iteration);
                summonButton.Text = "summon";
                summonButton.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }
        private void GitHubButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/shalzuth/BraveHaxvius");
        }
        private void DonateButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=shal.zuth@gmail.com&lc=US&currency_code=USD&bn=PP%2dDonationsBF");
        }
        private void LevelPartyButton_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                Func<string, int> update = i =>
                {
                    levelStatus.Text = i;
                    return 1;
                };
                levelPartyButton.Enabled = false;
                client.Login();
                client.LevelPartyNew(update);
                levelPartyButton.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }
        private void RankUpButton_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                Func<string, int> update = i =>
                {
                    levelStatus.Text = i;
                    return 1;
                };
                rankUpButton.Enabled = false;
                client.Login();
                while (true)
                {
                    var result = client.DoMission(Mission.CityofAshAnabethTheMysteriousCouple, false, null, null, null, false, false, false, false, false, null, 15000);
                    var level = result[GameObject.UserTeamInfo].First()[Variable.Level].ToString();
                    var experience = result[GameObject.UserTeamInfo].First()[Variable.Experience].ToString();
                    levelStatus.Text = "Rank " + level + " : experience = " + experience;
                    if (level == "250")
                        break;
                    Thread.Sleep(3000);
                }
                rankUpButton.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }

        private void JPLogin_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                JPLogin.Enabled = false;
                client.LoginJapan();
                InitGacha(client);
                JPLogin.Enabled = true;
                GachaSummon.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }

        private void GachaSummon_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                GachaSummon.Enabled = false;

                var GachaId = JPGacha.Text.Split(':').Select(p => p.Trim()).ToList().First();
                var Gacha = Gachas.First(g => g[Variable.GachaId].ToString() == GachaId);
                var GachaTicket = Ticket.Tickets.First(x => x.Name == JPGachaTicket.Text).Id;
                var GachaSubId = Gacha[Variable.Options].ToString().Split(',').Last();
                client.Summon(Gacha[Variable.GachaId].ToString(), GachaSubId, "1", GachaTicket);

                GachaSummon.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }

        private void StartMission_Click(object sender, EventArgs e)
        {
            try
            {
                var t = new Thread(() => RunMission(false));

                t.IsBackground = true;
                t.Start();
            }
            catch (Exception ex)
            {
                Logger.Out($"Error: {ex.InnerException}");
            }
        }

        private void RunMission(bool queuedMission = false)
        {
            StartMission.Enabled = false;
            client.Device = RBiOS.Checked ? "iPhone9,3" : "XT890";
            client.OperatingSystem = RBiOS.Checked ? "ios10.2.1" : RBAndroid.Checked ? "android4.4.2" : "amazon";
            client.Login();
            //if (Verbose)
            client.UpdateCurrentParty();
            var mission = missionSelect.SelectedItem as Mission;
            //client.DoMission(mission, CBFriends.Checked, null, null, null, CBTrophies.Checked, CBChallenge.Checked, CBLoot.Checked, CBUnits.Checked, CBExplore.Checked, LBLevel.Text, 3000);
            RunMissionCount = 0;
            var TotalErrors = 0;
            var runTotal = RepeatMission.Text.Replace(" ", "") ?? "1";
            while (RunMissionCount < Int32.Parse(runTotal) && TotalErrors < 3)
            {
                if (queuedMission && QueuedMissions.Count > 0)
                {
                    mission = QueuedMissions.FirstOrDefault();
                    QueuedMissions.Remove(mission);
                    queuedMissions.Items.RemoveAt(queuedMissions.Items.IndexOf(mission.Name));
                }
                try
                {
                    var iterationInfo = $"Doing run ... {mission.Name} {(++RunMissionCount).ToString()}/{runTotal} With party: {client.MyCurrentParty.CurrentPartyNames}";
                    Logger.Out(iterationInfo);
                    var missionResult = client.DoMission(mission, CBFriends.Checked, null, null, null, CBTrophies.Checked, CBChallenge.Checked, CBLoot.Checked, CBUnits.Checked, CBExplore.Checked, LBLevel.Text, 1500);

                    client.ArenaOrbs = UInt16.Parse(missionResult[GameObject.UserTeamInfo][0][Variable.ColosseumOrb].ToString());
                    client.RaidOrbs = UInt16.Parse(missionResult[GameObject.UserTeamInfo][0][Variable.RaidOrb].ToString());
                    var currentEnergy = Int32.Parse(missionResult[GameObject.UserTeamInfo][0][Variable.Energy].ToString());

                    Thread.Sleep(1500);
                    if (StopForArena && client.ArenaOrbs > 0)// && (RunMissionCount % 20 == 0))
                    {
                        client.ClearArena();
                    }
                    if (StopForRaid && client.RaidOrbs > 0)//&& (RunMissionCount % 20 == 0))
                    {
                        client.ClearRaid(raidMissionSelect.SelectedItem as Mission, RaidParty);
                    }

                    if (Verbose && RunMissionCount % 10 == 0)
                    {
                        client.UpdateCurrentParty(missionResult);

                        client.MyCurrentParty.MyPartyUnits.ForEach(x =>
                        {
                            if (x.TMR == 100 || (x.TMR > 0 && x.TMR > x.LastTMR))
                            {
                                Logger.Out(x.Name + " Gained " + (x.TMR - x.LastTMR) + " points.");
                            }
                        });

                    }

                    if (Verbose && currentEnergy > 195)
                    {
                        Logger.Out("Warning: Excess Energy " + client.TotalEnergy);
                    }

                    if (ChangeParty >= 0 && ChangeParty < 5 && client.MyCurrentParty.MyPartyId != ChangeParty)
                    {
                        client.SetParty(ChangeParty);
                    }

                    // Get fresh data every x runs
                    if (RunMissionCount > 1 && RunMissionCount % 100 == 0)
                    {
                        client.UpdateGetUserInfo();
                    }
                }
                catch (Exception ex)
                {
                    Logger.Out(ex.Message);
                    Console.WriteLine(ex.InnerException);
                    TotalErrors++;
                }
            }
            StartMission.Enabled = true;

            Logger.Out("Run Complete!");
        }

        private void EndMission_Click(object sender, EventArgs e)
        {
            Logger.Out("Ending after Next Mission is Completed...");
            RunMissionCount = Int32.Parse(RepeatMission.Text.Replace(" ", ""));
            client.UpdateGetUserInfo();
        }

        private void RBOS_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void FbidInput_TextChanged(object sender, EventArgs e)
        {
            fbidInput.Text = fbidInput.Text.Replace(" ", "");
            client.FacebookUserId = fbidInput.Text;
            Settings.Default.fbidInput = fbidInput.Text;
            Settings.Default.Save();
        }

        private void fbtokenInput_TextChanged(object sender, EventArgs e)
        {
            fbtokenInput.Text = fbtokenInput.Text.Replace(" ", "");
            client.FacebookToken = fbtokenInput.Text;
            Settings.Default.fbtokenInput = fbtokenInput.Text;
            Settings.Default.Save();
        }

        private void ProxyIP_TextChanged(object sender, EventArgs e)
        {
            client.ProxyIpAddr = ProxyIP.Text;
            Settings.Default.ProxyIP = ProxyIP.Text;
            Settings.Default.Save();
        }

        private void ProxyPort_TextChanged(object sender, EventArgs e)
        {
            client.ProxyPort = int.Parse(ProxyPort.Text);
            Settings.Default.ProxyPort = ProxyPort.Text;
            Settings.Default.Save();
        }

        private void GetEnergy(object sender, EventArgs e)
        {
            if (client.GetUserInfo != null)
                energyButton.Text = client.TotalEnergy;
        }

        private void CBTrophies_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb.Checked)
            {
                LBLevel.Text = "";
                LBLevel.Enabled = false;
                CBChallenge.Checked = false;
                CBChallenge.Enabled = false;
            }
            else
            {
                LBLevel.Enabled = true;
            }
        }
        private void arenaButton_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                Func<string, int> update = i =>
                {
                    levelStatus.Text = i;
                    return 1;
                };
                arenaButton.Enabled = false;
                client.Login();
                client.ClearArena();
                arenaButton.Enabled = true;
            });
            t.IsBackground = true;
            t.Start();
        }

        public class Sell
        {
            public String ItemName;
            public String id;
            public String type;
            public int count;
            public int price;
            public override string ToString()
            {
                return ItemName + " : " + count;
            }
        }
        private void sellButton_Click(object sender, EventArgs e)
        {
            var t = new Thread(() =>
            {
                if (sellButton.Text == "login")
                {
                    sellButton.Enabled = false;
                    client.Login();
                    var items = client.GetUserInfo[GameObject.UserItemInfo_4rC0aLkA].First()[Variable.ItemList].ToString().Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    var equips = client.GetUserInfo[GameObject.UserEquipItemInfo_w83oV9uP].First()[Variable.ItemList].ToString().Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    var materias = client.GetUserInfo[GameObject.UserMateriaInfo_aS39Eshy].First()[Variable.ItemList].ToString().Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    
                    foreach (var itemInfo in items)
                    {
                        var id = itemInfo.Split(new char[1] { ':' })[0];
                        var count = itemInfo.Split(new char[1] { ':' })[1];
                        var item = Item.Items.First(i => i.ItemId == id);
                        sellable.Add(new Sell { ItemName = item.Name, count = int.Parse(count), id = id, price = int.Parse(item.ItemSellPrice), type = "20:" });//, ItemNameAndCount = item.Name + " : " + count });
                    }
                    foreach (var itemInfo in equips)
                    {
                        var id = itemInfo.Split(new char[1] { ':' })[0];
                        var count = itemInfo.Split(new char[1] { ':' })[1];
                        var item = Equipment.Equipments.First(i => i.EquipId == id);
                        sellable.Add(new Sell { ItemName = item.Name, count = int.Parse(count), id = id, price = int.Parse(item.ItemSellPrice), type = "21:" });//, ItemNameAndCount = item.Name + " : " + count });
                    }
                    foreach (var itemInfo in materias)
                    {
                        var id = itemInfo.Split(new char[1] { ':' })[0];
                        var count = itemInfo.Split(new char[1] { ':' })[1];
                        var item = Materia.Materias.First(i => i.MateriaId == id);
                        sellable.Add(new Sell { ItemName = item.Name, count = int.Parse(count), id = id, price = int.Parse(item.ItemSellPrice), type = "22:" });//, ItemNameAndCount = item.Name + " : " + count });
                    }
                    sellable = sellable.OrderByDescending(s => s.count).ToList();
                    sellButton.Text = "sell";
                    sellItemSelect.DataSource = sellable;
                    sellButton.Enabled = true;
                }
                else if (sellButton.Text == "sell")
                {
                    sellButton.Enabled = false;
                    var item = (sellItemSelect.SelectedItem as Sell);
                    while ((UInt64)item.count * (UInt64)item.price > 999999999)
                    {
                        var maxSell = 999999999 / item.price;
                        client.Network.SendPacket(Request.ItemSell, new JProperty(Variable.ItemSell, new JArray(new JObject(
                            new JProperty(Variable.StoreItemSellId, item.type + item.id + ":" + maxSell),
                            new JProperty(Variable.StoreItemSellPrice, ((UInt64)item.price * (UInt64)maxSell).ToString())))));
                        item.count -= maxSell;
                        Thread.Sleep(3000);
                    }
                    client.Network.SendPacket(Request.ItemSell, new JProperty(Variable.ItemSell, new JArray(new JObject(
                        new JProperty(Variable.StoreItemSellId, item.type + item.id + ":" + item.count),
                        new JProperty(Variable.StoreItemSellPrice, (item.price * item.count).ToString())))));
                    sellButton.Enabled = true;
                }
            });
            t.IsBackground = true;
            t.Start();
        }

        private void summon_raid(object sender, EventArgs e)
        {
            var raidcoins = sellable.Find(x => x.id == "106305500").count;
            var summonTotal = raidcoins / 10000;
            var leftOver = (raidcoins % 10000) / 100;
            var units = new List<Unit>();
            for (int i = 0; i < summonTotal; i++)
            {
                units.AddRange(client.Summon("71020", "710202", "100", "0"));
            }
            if (leftOver > 0)
            {
                units.AddRange(client.Summon("71020", "710202", leftOver.ToString(), "0"));
            }
            var sumOfUnits = new Dictionary<string, int>();
            foreach (var unit in units)
            {
                if (sumOfUnits.ContainsKey(unit.Name))
                {
                    sumOfUnits[unit.Name]++;
                }
                else
                {
                    sumOfUnits.Add(unit.Name, 1);
                }
            }            
            foreach(var unit in sumOfUnits)
            {
                Logger.Out($"{unit.Key} : {unit.Value}");
            }
        }

        private void missionsTab_Click(object sender, EventArgs e)
        {

        }

        private void raidCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            StopForRaid = cb.Checked;
        }

        private void arenaCheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            StopForArena = cb.Checked;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addToQueue_Click(object sender, EventArgs e)
        {
            var mission = missionSelect.SelectedItem as Mission;
            if (!QueuedMissions.Contains(mission))
            {
                QueuedMissions.Add(mission);
                queuedMissions.Items.Add(mission.Name);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var mission = QueuedMissions.FirstOrDefault();
            missionSelect.SelectedItem = missionSelect.FindStringExact(mission.Name);
            RepeatMission.Value = QueuedMissions.Count;
            RunMission(true);            
        }

        private void selectRaidTeam_Click(object sender, EventArgs e)
        {

        }

        private void raidTeamComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
