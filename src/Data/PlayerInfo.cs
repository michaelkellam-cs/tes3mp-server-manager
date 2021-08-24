using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TES3MP_GUI
{
    /*
     * 
     * The current implementation of player data may not be very scalable,
     * especially if more features such as inventory modification are to be
     * added. This is a potential way to save/write data, so I will keep it her
     * for now.
     * 
     */
    public class PlayerInfo
    {

        // "login":
        // 0 - "name"
        // 1 - "password"
        private string[] login = new string[2];

        // "settings":
        // 0 - "difficulty"
        // 1 - "enforcedLogLevel"
        // 2 - "physicsFramerate"
        // 3 - "consoleAllowed"
        // 4 - "bedRestAllowed"
        // 5 - "wildernessRestAllowed"
        // 6 - "waitAllowed"
        // 7 - "staffRank"
        private string[] settings = new string[8];

        // 0 - "gender"
        // 1 - "race"
        // 2 - "head"
        // 3 - "hair"
        // 4 - "class"
        // 5 - "birthsign"
        private string[] character = new string[6];

        private string[] customClass = new string[0];
        private string[] location = new string[7];
        private string[] stats = new string[8];
        private string[] fame = new string[2];
        private string[] shapeshift = new string[4];
        private string[] attributes = new string[8];
        private string[] skills = new string[27];
        private string[] recordLinks = new string[0];
        private string[] equipment = new string[9];
        private string[] inventory = new string[4];
        private string[] spellbook = new string[0];
        private string[] books = new string[0];
        private string[] factionRanks = new string[0];
        private string[] factionReputation = new string[0];
        private string[] factionExpulsion = new string[0];
        private string[] mapExplored = new string[3];
        private string[] ipAddresses = new string[1];
        private string[] customVariables = new string[0];
        private string[] quickKeys = new string[0];
        private string[] journal = new string[0];
        private string[] miscellaneous = new string[2];
        private string[] topics = new string[0];


        public PlayerInfo()
        {

        }

        public void Execute()
        {
            //Console.WriteLine("Printing out login info");
            for (int i = 0; i < login.Length; i++)
            {
                Console.WriteLine(login[i]);
            }
        }
    }
}
