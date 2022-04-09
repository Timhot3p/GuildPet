using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuildPet
{
    public class HydraGetter
    {
        public Player getHydra(int heads)
        {
            switch (heads)
            {
                case 1: return new Player("Head 1", 325, 1, 0, 0, 52800, 6720, 6720, 126000, 21600, 200000000, 50000);

                case 2: return new Player("Head 2", 350, 1, 0, 0, 48416, 11972, 12081, 163332, 23725, 380000000, 50000);

                case 3: return new Player("Head 3", 370, 2, 0, 0, 7998, 7998, 58256, 170280, 24768, 250000000, 10000);

                case 4: return new Player("Head 4", 395, 3, 0, 0, 10493, 65789, 10573, 184230, 31720, 770000000, 25000);

                case 5: return new Player("Head 5", 420, 3, 0, 0, 21357, 67614, 21357, 203916, 42294, 1360000000, 25000);

                case 6: return new Player("Head 6", 440, 1, 0, 0, 70908, 25251, 25251, 231278, 45372, 2500000000, 50000);

                case 7: return new Player("Head 7", 460, 3, 0, 0, 22991, 76322, 22638, 240345, 46864, 3000000000, 25000);

                case 8: return new Player("Head 8", 480, 2, 0, 0, 18980, 18980, 90136, 264951, 48613, 2500000000, 10000);

                case 9: return new Player("Head 9", 500, 5, 0, 0, 89425, 34237, 34416, 324682, 63017, 10900000000, 10000);

                case 10: return new Player("Head 10", 525, 3, 0, 0, 37239, 76696, 37239, 330986, 53802, 14000000000, 25000);

                case 11: return new Player("Head 11", 550, 5, 0, 0, 106424, 20679, 20679, 347519, 57549, 19000000000, 10000);

                case 12: return new Player("Head 12", 575, 1, 0, 0, 111363, 39613, 39613, 376189, 71319, 20000000000, 50000);

                case 13: return new Player("Head 13", 600, 4, 0, 0, 34306, 123563, 34306, 399001, 80786, 19000000000, 25000);

                case 14: return new Player("Head 14", 610, 2, 0, 0, 39832, 39832, 136753, 417645, 63190, 10000000000, 10000);

                case 15: return new Player("Head 15", 620, 1, 0, 0, 137144, 39634, 39634, 447741, 86381, 28000000000, 50000);

                case 16: return new Player("Head 16", 625, 1, 0, 0, 153224, 15470, 48265, 489105, 88120, 30000000000, 50000);

                case 17: return new Player("Head 17", 630, 1, 0, 0, 163224, 64781, 63721, 507599, 93780, 32000000000, 50000);

                case 18: return new Player("Head 18", 640, 5, 0, 0, 182015, 41927, 41927, 575061, 99832, 37000000000, 10000);

                case 19: return new Player("Head 19", 650, 1, 0, 0, 195334, 50000, 50000, 651487, 117563, 43000000000, 50000);

                case 20: return new Player("Head 20", 660, 1, 0, 0, 229388, 62835, 62835, 711394, 137813, 48000000000, 50000);

                default: return new Player("Head 20", 660, 1, 0, 0, 229388, 62835, 62835, 711394, 137813, 48000000000, 50000);


            }

        }
    }
}
