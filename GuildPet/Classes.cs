using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildPet
{
    public class Classes
    {
        public static int getHpFactor(int cls)
        {
            switch (cls)
            {
                case 1: return 5;

                case 2: return 2;

                case 3: return 4;

                case 4: return 4;

                case 5: return 5;

                case 6: return 4;

                case 7: return 4;

                case 8: return 4;

                case 9: return 5;

                default: return 0;
            }
        }

        public static int getMaxArmor(int cls)
        {
            switch (cls)
            {
                case 1: return 50;

                case 2: return 10;

                case 3: return 25;

                case 4: return 25;

                case 5: return 10;

                case 6: return 50;

                case 7: return 50;

                case 8: return 25;

                case 9: return 50;

                default: return 0;
            }
        }

        public static String getName(int cls)
        {
            switch (cls)
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
        public static float getWpnScl(int cls)
        {
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

        public static int classToMain(int cls)
        {
            switch (cls)
            {
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

        public static float getDodgeChances(int cls)
        {
            switch (cls)
            {
                case 1: return 0.25f;

                case 2: return 0;

                case 3: return 0.5f;

                case 4: return 0.5f;

                case 5: return 0;

                case 6: return 0.5f;

                case 7: return 0;

                case 8: return 0.5f;

                case 9: return 0.25f;

                default: return 0.0f;
            }
        }
    }
}