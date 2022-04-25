using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace GuildPet
{
    //represents an instance of a fight
    internal class Fight {
        private Player playerA;
        private Player playerB;
        private long restHpA;
        private long restHpB;
        private float redA;
        private float redB;
        private float dodgeA;
        private float dodgeB;
        private int mindmgA;
        private int maxdmgA;
        private int mindmgB;
        private int maxdmgB;
        private bool turnA;
        private int round;
        
        //creates a fight between two players with full hp
        public Fight(Player playerA, Player playerB) {
            this.playerA = playerA;
            this.playerB = playerB;
            this.restHpA = playerA.Hp;
            this.restHpB = playerB.Hp;
            setDmgReductors();
            setDodgeChances();
            setDamageRanges();
            this.turnA = (rng() > 0.5);
            this.round = 0;
        }

        //creates a fight between two players with custom hp
        public Fight(Player playerA, Player playerB, long restHpA, long restHpB)
        {
            this.playerA = playerA;
            this.playerB = playerB;
            this.restHpA = restHpA;
            this.restHpB = restHpB;
            setDmgReductors();
            setDodgeChances();
            setDamageRanges();
            this.turnA = (rng() > 0.5);
            this.round = 0;
        }

        //returns a random float value between 0 and 1
        private float rng() {
            return (float)Random.Shared.NextDouble();
        }

        //sets the damage reduction through armor for both players for this fight
        private void setDmgReductors() {
            this.redA = getDmgReduction(this.playerB, this.playerA);
            this.redB = getDmgReduction(this.playerA, this.playerB);
        }

        //sets the dodge (block, multi attack) chances for both players for this fight
        private void setDodgeChances() {
            this.dodgeA = getDodgeChances(this.playerB, this.playerA);
            this.dodgeB = getDodgeChances(this.playerA, this.playerB);
        }

        //sets the max and min damage values for both players for this fight, excluding crit bonus, armor reduction and round bonus
        private void setDamageRanges() {
            this.mindmgA = getMinMaxDamage(this.playerA, this.playerB, false);
            this.maxdmgA = getMinMaxDamage(this.playerA, this.playerB, true);
            this.mindmgB = getMinMaxDamage(this.playerB, this.playerA, false);
            this.maxdmgB = getMinMaxDamage(this.playerB, this.playerA, true);
        }

        //executes fireballs if any of the players is a battle mage
        private void executeFireball() {
            if (this.playerB.Cls == 5)
            {
                long fireball1 = getFireballDmg(this.playerB, this.playerA);
                this.restHpA -= fireball1;

                this.round++;

            }
            if (this.playerA.Cls == 5)
            {
                long fireball2 = getFireballDmg(this.playerA, this.playerB);
                this.restHpB -= fireball2;

                this.round++;

            }
        }        

        //executes a hit from playerA to playerB
        private void aHitsb() {
            if (rng() > this.dodgeB)
            {
                int baseDmg = this.mindmgA + (int)(rng() * (this.maxdmgA - this.mindmgA));
                int crit = (rng() > 0.5) ? 2 : 1;
                int totaldamage = (int) (baseDmg * crit * (1.0f + this.round / 6.0f) * (1 - this.redB));
                this.restHpB -= totaldamage;               
            } 
            if(this.playerA.Cls == 4) { this.round++;  }
        }

        //executes a hit from playerB to playerA
        private void bHitsa() {
            if (rng() > this.dodgeA)
            {
                int baseDmg = this.mindmgB + (int)(rng() * (this.maxdmgB - this.mindmgB));
                int crit = (rng() > 0.5) ? 2 : 1;
                int totaldamage = (int) (baseDmg * crit * (1.0f + this.round / 6.0f) * (1 - this.redA));
                this.restHpA -= totaldamage;
            }
            if (this.playerB.Cls == 4) { this.round++; }
        }

        //checks if the fight has ended and check if a demon hunter revived
        private bool hasEnded() {
            if (restHpA <= 0) {
                if (playerA.Cls == 7) {
                    return !revived(true);
                } else {
                    return true;
                }
            }

            if (restHpB <= 0) {
                if (playerB.Cls == 7) {
                    return !revived(false);
                }
                else {
                    return true;
                }
            }

            return false;
        }

        //rolls if a demon hunter revives and executes it if so
        private bool revived(bool playerA) {
            if (playerA && this.playerA.Cls == 7) {
                if (rng() < 0.25) {
                    this.restHpA = this.playerA.Hp;
                    return true;
                }
                else {
                    return false;
                }
            }

            if(!playerA && this.playerB.Cls == 7) {
                if (rng() < 0.25) {
                    this.restHpB = this.playerB.Hp;
                    return true;
                }
                else {
                    return false;
                }
            }

            return false;
        }

        //executes the next hit for this fight
        public void nextHit()
        {
            if (this.turnA) { aHitsb(); } else { bHitsa(); };
            this.turnA = !this.turnA;
            this.round++;
        }

        //executes the next hit until one player is dead or 100 hits have been reached
        public (bool winA, long hpWinner) doFight() {
            executeFireball();
            while (!hasEnded()) {
                nextHit();
                if(round > 100) { return (true, 0); }
            }
            bool winA = (this.restHpA >= 0);
            long hpWinner = winA ? this.restHpA : this.restHpB;
            return (winA, hpWinner);
        }

        //returns the total damage reduction of a player defender when attacked by a player attacker
        public static float getDmgReduction(Player attacker, Player defender) {
            if (attacker.Cls == 2)
            {
                return 0.0f;
            }
            else
            {
                switch (defender.Cls)
                {
                    case 1: return Math.Min(defender.Armor / (attacker.Level * 100.0f), 0.5f);
                    case 2: return Math.Min(defender.Armor / (attacker.Level * 100.0f), 0.1f);
                    case 3: return Math.Min(defender.Armor / (attacker.Level * 100.0f), 0.25f);
                    case 4: return Math.Min(defender.Armor / (attacker.Level * 100.0f), 0.25f);
                    case 5: return (Math.Min(defender.Armor / (attacker.Level * 100.0f), 0.1f) + 0.4f);
                    case 6: return Math.Min(defender.Armor / (attacker.Level * 200.0f), 0.25f);
                    case 7: return Math.Min(defender.Armor / (attacker.Level * 100.0f), 0.5f);
                    case 8: return Math.Min(defender.Armor / (attacker.Level * 100.0f), 0.25f);
                    case 9: return Math.Min(defender.Armor / (attacker.Level * 50.0f), 0.5f);
                    default: return 0.0f;

                }
            }
        }

        //returns the dodge (block, multi attack) chances of a player defender when attacked by a player attacker
        public static float getDodgeChances(Player attacker, Player defender)
        {
            if (attacker.Cls == 2 && defender.Cls != 6)
            {
                return 0.0f;
            }
            else
            {
                return Classes.getDodgeChances(defender.Cls);               
            }
        }

        //returns the value of the stat that will reduce the main stat of the player attacker when attacking the player defender
        public static int getReducingStat(Player attacker, Player defender) {
            switch (attacker.Cls) {
                case 1: return defender.Strength / 2;
                case 2: return defender.Intelligence / 2;
                case 3: return defender.Dexterity / 2;
                case 4: return defender.Dexterity / 2;
                case 5: return defender.Strength / 2;
                case 6: return defender.Strength / 2;
                case 7: return defender.Dexterity / 2;
                case 8: return defender.Intelligence / 2;
                case 9: return defender.Intelligence / 2;
                default: return 0;
            }
        }

        //returns the remaining main stat of a player attacker when attacking a player defender after main stat reduction
        public static int getReducedMain(Player attacker, Player defender) {

            int reducedMain = Math.Max(attacker.getMainStat() - getReducingStat(attacker, defender), attacker.getMainStat() / 2);          
            return reducedMain;
        }

        //returns the min or max damage (depending on bool max) a player attacker can inflict on a player defender, excluding crit bonus, armor reduction and round bonus
        public static int getMinMaxDamage(Player attacker, Player defender, bool max) {
            int damage = 0;
            int wpndmg = max ? attacker.MaxDmg : attacker.MinDmg;            
            int reducedMain = getReducedMain(attacker, defender); 
            damage = wpndmg * (reducedMain/10 + 1);

            if (attacker.Cls == 4) {
                damage = (int)(damage * 0.625);
            }
            else if (attacker.Cls == 6) {
                damage = (int)(damage * 1.25);
            }
            else if (attacker.Cls == 2 && defender.Cls == 6) {
                damage *= 2;
            }

            return damage;
        }                  

        //returns the fireball damage a player attacker will inflict on a player defender
        public static long getFireballDmg(Player attacker, Player defender)            
        {
            if (attacker.Cls == 5 && defender.Cls != 2 && defender.Cls != 5) {
                switch (defender.Cls) {
                    case 1: return (long)Math.Min((0.33 * defender.Hp), (0.25 * attacker.Hp));
                    case 3: return (long)Math.Min((0.33 * defender.Hp), (0.20 * attacker.Hp));
                    case 4: return (long)Math.Min((0.33 * defender.Hp), (0.20 * attacker.Hp));
                    case 6: return (long)(0.33 * defender.Hp);
                    case 7: return (long)(0.33 * defender.Hp);
                    case 8: return (long)(0.33 * defender.Hp);
                    case 9: return (long)(0.33 * defender.Hp);
                    default: return 0;
                }
            }
            return 0;
        }       
    }
}