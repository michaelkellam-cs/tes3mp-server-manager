using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TES3MP_GUI.src.Enums
{
    public static class SkillsInfo
    {
        /*
         * Made a simple Enum and way to properly convert
         * Skills strings to align with the game. This is because
         * in the player JSON file, the skills are all one word, but 
         * in the actual game, they are multiple words.
         * i.e.: Short Blade --> Shortblade
         */
        public enum Skills : int
        {
            Block = 0,
            Alchemy = 1,
            Restoration = 2,
            Conjuration = 3,
            Marksman = 4,
            Medium_Armor = 5,
            Alteration = 6,
            Heavy_Armor = 7,
            Mercantile = 8,
            Short_Blade = 9,
            Acrobatics = 10,
            Sneak = 11,
            Light_Armor = 12,
            Long_Blade = 13,
            Armorer = 14,
            Speechcraft = 15,
            Axe = 16,
            Security = 17,
            Enchant = 18,
            Destruction = 19,
            Athletics = 20,
            Illusion = 21,
            Mysticism = 22,
            Spear = 23,
            Blunt_Weapon = 24,
            Hand_to_hand = 25,
            Unarmored = 26
        }

        public static string ConvertSkill(string skill)
        {
            switch (skill)
            {
                case "Shortblade":
                    return "Short Blade";
                case "Longblade":
                    return "Long Blade";
                case "Bluntweapon":
                    return "Blunt Weapon";
                case "Lightarmor":
                    return "Light Armor";
                case "Mediumarmor":
                    return "Medium Armor";
                case "Heavyarmor":
                    return "Heavy Armor";
                default:
                    return skill;
            };
        }
    }
}
