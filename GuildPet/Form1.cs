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
        public int classToMain(int cls) {
            switch (cls) { 
                case 1: return 1;
                case 2: return 3;
                case 3: return 2;
                case 4: return 2;
                case 5: return 1;
                case 6: return 1;
                case 7: return 2;
                case 8: return 3;
                case 9: return 3;
                default: return 0;
            }
        }
        public int mainToClass(int main) {
            switch (main) {
                case 1: return 1;
                case 2: return 3;
                case 3: return 2;
                default: return 0;
            }
        }
        public float getWpnScl(int cls) {
            switch (cls)
            {
                case 1: return 2.0f;

                case 2: return 4.5f;

                case 3: return 2.5f;

                case 4: return 2.0f;

                case 5: return 2.0f;

                case 6: return 2.0f;

                case 7: return 2.5f;

                case 8: return 4.5f;

                case 9: return 4.5f;

                default: return 0.0f;
            }
        }
        private void calcPet_Click(object sender, EventArgs e)            
        {
            generatePlayers();
            this.strPet = getPet(this.playerList, 1);
            this.dexPet = getPet(this.playerList, 2);
            this.intPet = getPet(this.playerList, 3);     

            petStrength.Text = this.strPet.toString();
            petDexterity.Text = this.dexPet.toString();
            petIntelligence.Text = this.intPet.toString();         

         }

        private string playerListToString(Player[] players) {
            string res = "";
            for (int i = 0; i < players.Length; i++) {
                res = res + players[i].toString() + "\n";
            }
            return res;
        }
        private Player getPet(Player[] players, int main)
        {

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
                return new Player("Pet", level, main, mindmg, maxdmg, strength, dexterity, intelligence, constitution, luck);
            }

            Player[] sortedPlayers = getSortedList(players);
            int n = Math.Min(players.Length, 25);

            int mainstat = 0;
            int sidestat1 = 0;
            int sidestat2 = 0;

            for (int i = 0; i < n; i++)
            {
                level += players[i].Level;                
                mainstat += players[i].getMainStat();
                sidestat1 += players[i].getSideStat1();
                sidestat2 += players[i].getSideStat2();
                constitution += players[i].Constitution;
                luck += players[i].Luck;
            }

            level = level / 25;
            constitution = constitution / 10;
            luck = luck / 10;

            switch (main)
            {
                case 1:
                    strength = mainstat / 10;
                    dexterity = sidestat1 / 10;
                    intelligence = sidestat2 / 10;
                    mindmg = (int) ((level + 1) * 2);
                    maxdmg = (int) ((level + 1) * 2);
                    break;
                case 2:
                    strength = sidestat1 / 10;
                    dexterity = mainstat / 10;
                    intelligence = sidestat2 / 10;
                    mindmg = (int) ((level + 1) * 2.5);
                    maxdmg = (int) ((level + 1) * 2.5);
                    break;
                case 3:
                    strength = sidestat1 / 10;
                    dexterity = sidestat2 / 10;
                    intelligence = mainstat / 10;
                    mindmg = (int) ((level + 1) * 4.5);
                    maxdmg = (int) ((level + 1) * 4.5);
                    break;
                default:
                    break;
            }
            return new Player("Pet", level, mainToClass(main), mindmg, maxdmg, strength, dexterity, intelligence, constitution, luck);
        }
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

        private void simulate_Click(object sender, EventArgs e)
        {
            int hydraNr = 1;
            try { hydraNr = Int32.Parse(hydraHeads.Text); } catch { }
            Player testHydra = HydraGetter.getHydra(hydraNr);
            Fight fs = new Fight(this.strPet, testHydra);
            var results = fs.doFight();
            strOutput.Text = results.winA + ", " + results.hpWinner;
            Fight fd = new Fight(this.strPet, testHydra);
            var resultd = fd.doFight();
            dexOutput.Text = resultd.winA + ", " + resultd.hpWinner;
            Fight fi = new Fight(this.strPet, testHydra);
            var resulti = fi.doFight();
            intOutput.Text = resulti.winA + ", " + resulti.hpWinner;
        }
    }
}