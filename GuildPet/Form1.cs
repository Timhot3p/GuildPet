using System.Globalization;
using System.Diagnostics;

namespace GuildPet
{
    public partial class Form1 : Form
    {
        private Player[] playerList = new Player[50];
        private int playerNumber = 0;
        private Player strPet;
        private Player dexPet;
        private Player intPet;
        public Form1()
        {
            InitializeComponent();
        }

        //generates the players from the input string
        private void generatePlayers()
        {
            string[] players = input.Text.Split("},{");
            this.playerNumber = players.Length;
            if (playerNumber <= 25)
            {
                MessageBox.Show("Not enough players!");
                return;
            }
            if (playerNumber > 50)
            {
                MessageBox.Show("Too many players!");
            }

            for (int p = 0; p < players.Length; p++) {

                string[] attributes = players[p].Split(",");
                for (int i = 0; i < attributes.Length; i++)
                {
                    if (attributes[i].Contains(":"))
                    {
                        attributes[i] = attributes[i].Split(":").Last();
                    }
                }
                string name = attributes[3].Trim('"');
                int level = Int32.Parse(attributes[4]);
                int cls = Int32.Parse(attributes[1]);
                int strength = Int32.Parse(attributes[14].TrimEnd('}'));
                int dexterity = Int32.Parse(attributes[8].TrimEnd('}'));
                int intelligence = Int32.Parse(attributes[13].TrimEnd('}'));
                int constitution = Int32.Parse(attributes[7].TrimEnd('}'));
                int luck = Int32.Parse(attributes[16].TrimEnd('}'));

                this.playerList[p] = new Player(name, level, cls, 0, 0, strength, dexterity, intelligence, constitution, luck);
            }
        }
       
        //returns one of the three main classes (for pets) from the main stat
        public int mainToClass(int main) {
            switch (main) {
                case 1: return 1;
                case 2: return 3;
                case 3: return 2;
                default: return 0;
            }
        }

        //sets the three possible guild pets from the previously generated players
        private void calcPets() {
            if (!input.Text.Contains("["))
            {
                getPetsFromInput();
            }
            else
            {
                generatePlayers();
                this.strPet = getPet(this.playerList, 1);
                this.dexPet = getPet(this.playerList, 2);
                this.intPet = getPet(this.playerList, 3);
            }
                     
        }       

        //turns a list of players into a string
        private string playerListToString(Player[] players) {
            string res = "";
            for (int i = 0; i < players.Length; i++) {
                res = res + players[i].toString() + "\n";
            }
            return res;
        }

        //calculates a guild pet with a certain main attribute from a list of players
        private Player getPet(Player[] players, int main)
        {
            string name = "NoPet";
            int level = 0;
            int mindmg = 0;
            int maxdmg = 0;
            int strength = 0;
            int dexterity = 0;
            int intelligence = 0;
            int constitution = 0;
            int luck = 0;

            if (players == null)
            {
                return new Player(name, level, main, mindmg, maxdmg, strength, dexterity, intelligence, constitution, luck);
            }

            Player[] sortedPlayers = getSortedList(players);
            int n = Math.Min(players.Length, 25);

            int mainstat = 0;
            int sidestat1 = 0;
            int sidestat2 = 0;

            for (int i = 0; i < n; i++)
            {
                level += sortedPlayers[i].Level;                
                mainstat += sortedPlayers[i].getMainStat();
                sidestat1 += sortedPlayers[i].getSideStat1();
                sidestat2 += sortedPlayers[i].getSideStat2();
                constitution += sortedPlayers[i].Constitution;
                luck += sortedPlayers[i].Luck;
            }

            level = level / 25;
            constitution = constitution / 10;
            luck = luck / 10;
            mindmg = (int) ((level + 1) * Classes.getWpnScl(mainToClass(main)));
            maxdmg = (int) ((level + 1) * Classes.getWpnScl(mainToClass(main)));

            switch (main)
            {
                case 1:
                    name = "StrPet";
                    strength = mainstat / 10;
                    dexterity = sidestat1 / 10;
                    intelligence = sidestat2 / 10;                   
                    break;
                case 2:
                    name = "DexPet";
                    strength = sidestat1 / 10;
                    dexterity = mainstat / 10;
                    intelligence = sidestat2 / 10;                   
                    break;
                case 3:
                    name = "IntPet";
                    strength = sidestat1 / 10;
                    dexterity = sidestat2 / 10;
                    intelligence = mainstat / 10;                    
                    break;
                default:
                    break;
            }
            return new Player(name, level, mainToClass(main), mindmg, maxdmg, strength, dexterity, intelligence, constitution, luck);
        }

        //creates the three guild pets directly from the input
        private void getPetsFromInput() {
            string[] val = input.Text.Split(',');
            int level = Int32.Parse(val[0]);
            int stat1 = Int32.Parse(val[1]);
            int stat2 = Int32.Parse(val[2]);
            int stat3 = Int32.Parse(val[3]);
            int con = Int32.Parse(val[4]);
            int luck = Int32.Parse(val[5]);
            int main, side1, side2;

            main = max(stat1, stat2, stat3);
            side1 = mid(stat1, stat2, stat3);
            side2 = min(stat1, stat2, stat3);

            this.strPet = new Player("StrPet", level, 1, (level + 1) * 2, (level + 1) * 2, main, side1, side2, con, luck);

            this.intPet = new Player("IntPet", level, 2, (int)((level + 1) * 4.5), (int)((level + 1) * 4.5), side1, side2, main, con, luck);

            this.dexPet = new Player("DexPet", level, 3, (int)((level + 1) * 2.5), (int)((level + 1) * 2.5), side1, main, side2, con, luck);

        }

        //sorts the given list of players by their main attribute and returns the result
        private Player[] getSortedList(Player[] players)
        {
            if (players == null) { 
                return new Player[0];
            }

            Player[] list = (Player[])players.Clone();          

            long[] values = new long[players.Length];

            for (int i = 0; i < players.Length; i++)
            {
              values[i] = players[i].getMainStat();
            }

            Array.Sort(values, list);
            Array.Reverse(list);

            return list;
        }

        //method executed by pressing the simulate button, calculates the pets and simulates fights against the given hydra, displays the results in the gui
        private void simulate_Click(object sender, EventArgs e)
        {
            calcPets();
            int hydraNr = 1;
            try { hydraNr = Int32.Parse(hydraHeads.Text); } catch { }
            int playerNr = 50;
            try { playerNr = Int32.Parse(playersInput.Text); } catch { }
            int iterations = 100;
            try { iterations = Int32.Parse(iterationsInput.Text); } catch { }


            Player hydra = HydraGetter.getHydra(hydraNr);
            long[] restHp = new long[] { hydra.Hp, hydra.Hp, hydra.Hp };
            long[] avrgDmg = new long[] { 0, 0, 0 };
            int[] cnt = new int[] { 0, 0, 0 };
            float[] playersNeeded = new float[] { 0.0f, 0.0f, 0.0f };
            long[] avrgRestHp = new long[] { 0, 0, 0 };
            float[] won = new float[] { 0.0f, 0.0f, 0.0f };

            for (int c = 0; c < 3; c++)
            {
                Player clsPet;
                switch (c) {
                    case 0: clsPet = this.strPet;
                            break;
                    case 1: clsPet = this.dexPet;
                        break;
                    case 2: clsPet = this.intPet;
                        break;
                    default: clsPet = this.strPet;
                        break;                
                }

                for (int n = 0; n < iterations; n++)
                {
                    restHp[c] = hydra.Hp;
                    for (int i = 0; i < playerNr; i++)
                    {
                        Fight f = new Fight(clsPet, hydra);
                        var results = f.doFight();
                        if (!results.winA) {
                            long dmg = hydra.Hp - results.hpWinner;
                            restHp[c] -= dmg;
                            avrgDmg[c] += dmg;
                            cnt[c]++;
                        }
                        else {
                            restHp[c] = 0;
                            avrgDmg[c] += hydra.Hp;
                            cnt[c]++;
                            break;
                        }
                        if(restHp[c] < 0)
                        {
                            restHp[c] = 0;
                            break;
                        } 
                    }
                    avrgRestHp[c] += restHp[c];
                    won[c] += (restHp[c] > 0) ? 0.0f : 1.0f;
                }
                avrgRestHp[c] = (avrgRestHp[c] / iterations);
                won[c] = 100.0f * won[c] / iterations;
                avrgDmg[c] = avrgDmg[c] / cnt[c];
                playersNeeded[c] = (float)hydra.Hp / avrgDmg[c];
            }
            strOutput1.Text = won[0] + "%";
            strOutput2.Text = Math.Round((100.0f * avrgRestHp[0] / hydra.Hp), 2) + "%";
            strOutput3.Text = "" + Math.Round(playersNeeded[0], 2);

            dexOutput1.Text = won[1] + "%";
            dexOutput2.Text = Math.Round((100.0f * avrgRestHp[1] / hydra.Hp), 2) + "%";
            dexOutput3.Text = "" + Math.Round(playersNeeded[1], 2);

            intOutput1.Text = won[2] + "%";
            intOutput2.Text = Math.Round((100.0f * avrgRestHp[2] / hydra.Hp), 2) + "%";
            intOutput3.Text = "" + Math.Round(playersNeeded[2], 2);
        }

        //maximum of three numbers
        public int max(int a, int b, int c) {
            return Math.Max(a, Math.Max(b, c));
        }

        //middle value of three numbers
        public int mid(int a, int b, int c)
        {
            return Math.Max(Math.Min(a, b), Math.Min(Math.Max(a, b), c));
        }

        //minimum of three numbers
        public int min(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }

        //info text for hovering over the input field
        private void input_MouseHover(object sender, EventArgs e)
        {
            inputInfo.Show("Input your data via 'copy for fight simulator' or manually: level,strength,dexterity,intelligence,constitution,luck", input);
        }

        //info text for hovering over the input label
        private void label8_MouseHover(object sender, EventArgs e)
        {
            inputInfo.Show("Input your data via 'copy for fight simulator' or manually: level,strength,dexterity,intelligence,constitution,luck", label8);
        }

        //info text for hovering over the iterations label
        private void label7_MouseHover(object sender, EventArgs e)
        {
            inputInfo.Show("Number of simulated fights", label7);
        }

        //info text for hovering over the iterations field
        private void iterationsInput_MouseHover(object sender, EventArgs e)
        {
            inputInfo.Show("Number of simulated fights", iterationsInput);
        }
    }
}