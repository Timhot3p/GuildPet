using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildPet
{
    public class Player
    {
        private string name;

        private int level;
        private int cls;

        private int mindmg;
        private int maxdmg;
        private int armor;

        private int strength;
        private int dexterity;
        private int intelligence;
        private int constitution;
        private int luck;
        long hp;

        public Player(string name, int level, int cls, int mindmg, int maxdmg, int strength, int dexterity, int intelligence, int constitution, int luck)
        {
            this.name = name;
            this.level = level;
            this.cls = cls;
            this.mindmg = mindmg;
            this.maxdmg = maxdmg;
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
            this.constitution = constitution;
            this.luck = luck;
            switch (cls)
            {
                case 1:
                    this.hp = (long)constitution * 5 * (level + 1);
                    this.armor = 50 * level;
                    break;
                case 2:
                    this.hp = (long)constitution * 2 * (level + 1);
                    this.armor = 10 * level;
                    break;
                case 3:
                    this.hp = (long)constitution * 4 * (level + 1);
                    this.armor = 25 * level;
                    break;
                case 4:
                    this.hp = (long)constitution * 4 * (level + 1);
                    this.armor = 25 * level;
                    break;
                case 5:
                    this.hp = (long)constitution * 5 * (level + 1);
                    this.armor = 10 * level;
                    break;
                case 6:
                    this.hp = (long)constitution * 4 * (level + 1);
                    this.armor = 50 * level;
                    break;
                case 7:
                    this.hp = (long)constitution * 4 * (level + 1);
                    this.armor = 50 * level;
                    break;
                case 8:
                    this.hp = (long)constitution * 4 * (level + 1);
                    this.armor = 25 * level;
                    break;
                case 9:
                    this.hp = (long)constitution * 5 * (level + 1);
                    this.armor = 50 * level;
                    break;
                default: this.hp = 0; break;
            }
        }  

        public Player(string name, int level, int cls, int mindmg, int maxdmg, int strength, int dexterity, int intelligence, int constitution, int luck, long hp, int armor)
        {
            this.name = name;
            this.level = level;
            this.cls = cls;
            this.mindmg = mindmg;
            this.maxdmg = maxdmg;
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
            this.constitution = constitution;
            this.luck = luck;
            this.hp = hp;
            this.armor = armor;
        }

        public string Name { get => name; set => name = value; }
        public int Level { get => level; set => level = value; }
        public int MinDmg { get => mindmg; set => mindmg = value; }
        public int MaxDmg { get => maxdmg; set => maxdmg = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Dexterity { get => dexterity; set => dexterity = value; }
        public int Intelligence { get => intelligence; set => intelligence = value; }
        public int Constitution { get => constitution; set => constitution = value; }
        public int Luck { get => luck; set => luck = value; }
        public int Cls { get => cls; set => cls = value; }
        public long Hp { get => hp; set => hp = value; }
        public int Armor { get => armor; set => armor = value; }

        public int getMainStat()
        {
            switch (this.cls)
            {

                case 1: return this.strength;

                case 2: return this.intelligence;

                case 3: return this.dexterity;

                case 4: return this.dexterity;

                case 5: return this.strength;

                case 6: return this.strength;

                case 7: return this.dexterity;

                case 8: return this.intelligence;

                case 9: return this.intelligence;

                default: return 0;
            }
        }
        public int getSideStat1()
        {
            switch (this.cls)
            {
                case 1: return this.dexterity;

                case 2: return this.strength;

                case 3: return this.strength;

                case 4: return this.strength;

                case 5: return this.dexterity;

                case 6: return this.dexterity;

                case 7: return this.strength;

                case 8: return this.strength;

                case 9: return this.strength;

                default: return 0;
            }
        }
        public int getSideStat2()
        {
            switch (this.cls)
            {
                case 1: return this.intelligence;

                case 2: return this.dexterity;

                case 3: return this.intelligence;

                case 4: return this.intelligence;

                case 5: return this.intelligence;

                case 6: return this.intelligence;

                case 7: return this.intelligence;

                case 8: return this.dexterity;

                case 9: return this.dexterity;

                default: return 0;
            }
        }
        public String getClassName() {
            switch (this.cls)
            {
                case 1: return "Warrior";

                case 2: return "Mage";

                case 3: return "Scout";

                case 4: return "Assassin";

                case 5: return "Battle Mage";

                case 6: return "Berserker";

                case 7: return "Demon Hunter";

                case 8: return "Cat-Druid";

                case 9: return "Bear-Druid";

                default: return "None";
            }
        }
        public String toString()
        {
            return "Name: " + this.name + ", Level: " + this.level + ", Klasse: " + this.getClassName() + ", Waffe: " + this.mindmg + " - " + this.maxdmg + ", Stärke: " + this.strength + ", Geschick: " + this.dexterity + ", Intelligenz: " + this.intelligence + ", Ausdauer: " + this.constitution + ", Glück: " + this.luck + ", Rüstung: " + this.armor + ", Leben: " + this.hp + System.Environment.NewLine;

        }
    }
}
