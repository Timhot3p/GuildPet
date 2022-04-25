using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildPet
{
    //represents a player
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

        //constructor without hp and armor, they will get set according to level
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
            this.hp = (long)constitution * Classes.getHpFactor(cls) * (level + 1);
            this.armor = Classes.getMaxArmor(cls) * level;            
        }

        //constructor without hp, will get set according to level
        public Player(string name, int level, int cls, int mindmg, int maxdmg, int strength, int dexterity, int intelligence, int constitution, int luck, int armor)
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
            this.armor = armor;           
            this.hp = (long)constitution * Classes.getHpFactor(cls) * (level + 1);
        }

        //constructor where all values can be entered
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

        //getters and setters for each attribute
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

        //returns the value of the main stat of this player
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

        //returns the value of the first attribute in the order str-dex-int that is not a main attribute for this player
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

        //returns the value of the second attribute in the order str-dex-int that is not a main attribute for this player
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

        //returns the name of this players class
        public String getClassName() {
            return Classes.getName(this.cls);
        }

        //turns all the attributes of this player into a string and returns it
        public String toString()
        {
            return "Name: " + this.name + ", Level: " + this.level + ", Class: " + this.getClassName() + ", Weapon: " + this.mindmg + " - " + this.maxdmg + ", Strength: " + this.strength + ", Dexterity: " + this.dexterity + ", Intelligence: " + this.intelligence + ", Constitution: " + this.constitution + ", Luck: " + this.luck + ", Armor: " + this.armor + ", Hp: " + this.hp + System.Environment.NewLine;

        }
    }
}
