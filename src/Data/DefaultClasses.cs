using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TES3MP_GUI.src.Data
{
    public static class DefaultClasses
    {
        /*
         * 
         * This class will return all Major and Minor skills 
         * of a specific default class in the form of a 2d Array.
         * 
         * USE: https://en.uesp.net/wiki/Morrowind:Classes for reference
         */

        private const string M = "major";
        private const string m = "minor";

        public static string[] AllSkills =
        {
            "Armorer",
            "Athletics",
            "Axe",
            "Block",
            "Blunt Weapon",
            "Heavy Armor",
            "Long Blade",
            "Medium Armor",
            "Spear",
            "Alchemy",
            "Alteration",
            "Conjuration",
            "Destruction",
            "Enchant",
            "Illusion",
            "Mysticism",
            "Restoration",
            "Unarmored",
            "Acrobatics",
            "Hand-to-hand",
            "Light Armor",
            "Marksman",
            "Mercantile",
            "Security",
            "Short Blade",
            "Sneak",
            "Speechcraft"
        };

        public static string[] Classes =
        {
            "Acrobat",
            "Agent",
            "Archer",
            "Assassin",
            "Barbarian",
            "Bard",
            "Battlemage",
            "Crusader",
            "Healer",
            "Knight",
            "Mage",
            "Monk",
            "Nightblade",
            "Pilgrim",
            "Rogue",
            "Scout",
            "Sorcerer",
            "Spellsword",
            "Thief",
            "Warrior",
            "Witchhunter"
        };

        public static string[] Attributes =
        {
            "Strength",
            "Intelligence",
            "Willpower",
            "Agility",
            "Speed",
            "Endurance",
            "Personality",
            "Luck"
        };

        public static string[] GetClass(string clss, string type)
        {
            switch (clss)
            {
                case "Acrobat":
                    return GetAcrobat(type);
                case "Agent":
                    return GetAgent(type);
                case "Archer":
                    return GetArcher(type);
                case "Assassin":
                    return GetAssassin(type);
                case "Barbarian":
                    return GetBarbarian(type);
                case "Bard":
                    return GetBard(type);
                case "Battlemage":
                    return GetBattlemage(type);
                case "Crusader":
                    return GetCrusader(type);
                case "Healer":
                    return GetHealer(type);
                case "Knight":
                    return GetKnight(type);
                case "Mage":
                    return GetMage(type);
                case "Monk":
                    return GetMonk(type);
                case "Nightblade":
                    return GetNightblade(type);
                case "Pilgrim":
                    return GetPilgrim(type);
                case "Rogue":
                    return GetRogue(type);
                case "Scout":
                    return GetScout(type);
                case "Sorcerer":
                    return GetSorcerer(type);
                case "Spellsword":
                    return GetSpellsword(type);
                case "Thief":
                    return GetThief(type);
                case "Warrior":
                    return GetWarrior(type);
                case "Witchhunter":
                    return GetWitchhunter(type);
                default:
                    System.Console.WriteLine("DEFAULT!!!");
                    return null;
            }
        }

        private static string[] GetAcrobat(string type)
        {
            if (type == M)
            {
                return new string[]
                {
                    "Acrobatics",
                    "Athletics",
                    "Marksman",
                    "Sneak",
                    "Unarmored"
                };
            }
            else if (type == m)
            {
                return new string[]
                {
                    "Speechcraft",
                    "Alteration",
                    "Spear",
                    "Hand-to-hand",
                    "Light Armor"
                };
            }

            return null;
        }

        private static string[] GetAgent(string type)
        {
            if (type == M)
            {
                return new string[]
                {
                    "Speechcraft",
                    "Sneak",
                    "Acrobatics",
                    "Light Armor",
                    "Short Blade"
                };
            }
            else if (type == m)
            {
                return new string[]
                {
                    "Mercantile",
                    "Conjuration",
                    "Block",
                    "Unarmored",
                    "Illusion"
                };
            }

            return null;
        }

        private static string[] GetArcher(string type)
        {
            if (type == M)
            {
                return new string[]
                {
                    "Marksman",
                    "Long Blade",
                    "Block",
                    "Athletics",
                    "Light Armor"
                };
            }
            else if (type == m)
            {
                return new string[]
                {
                    "Unarmored",
                    "Spear",
                    "Restoration",
                    "Sneak",
                    "Medium Armor"
                };
            }

            return null;
        }

        private static string[] GetAssassin(string type)
        {
            if (type == M)
            {
                return new string[]
                {
                    "Sneak",
                    "Marksman",
                    "Light Armor",
                    "Short Blade",
                    "Acrobatics"
                };
            }
            else if (type == m)
            {
                return new string[]
                {
                    "Security",
                    "Long Blade",
                    "Alchemy",
                    "Block",
                    "Athletics"
                };
            }

            return null;
        }

        private static string[] GetBarbarian(string type)
        {
            if (type == M)
            {
                return new string[]
                {
                    "Axe",
                    "Medium Armor",
                    "Blunt Weapon",
                    "Athletics",
                    "Block"
                };
            }
            else if (type == m)
            {
                return new string[]
                {
                    "Acrobatics",
                    "Light Armor",
                    "Armorer",
                    "Marksman",
                    "Unarmored"
                };
            }

            return null;
        }

        private static string[] GetBard(string type)
        {
            if (type == M)
            {
                return new string[]
                {
                    "Speechcraft",
                    "Alchemy",
                    "Acrobatics",
                    "Long Blade",
                    "Block"
                };
            }
            else if (type == m)
            {
                return new string[]
                {
                    "Mercantile",
                    "Illusion",
                    "Medium Armor",
                    "Enchant",
                    "Security"
                };
            }

            return null;
        }

        private static string[] GetBattlemage(string type)
        {
            if (type == M)
            {
                return new string[]
                {
                    "Alteration",
                    "Destruction",
                    "Conjuration",
                    "Axe",
                    "Heavy Armor"
                };
            }
            else if (type == m)
            {
                return new string[]
                {
                    "Mysticism",
                    "Long Blade",
                    "Marksman",
                    "Enchant",
                    "Alchemy"
                };
            }

            return null;
        }

        private static string[] GetCrusader(string type)
        {
            if (type == M)
            {
                return new string[]
                {
                    "Blunt Weapon",
                    "Long Blade",
                    "Destruction",
                    "Heavy Armor",
                    "Block"
                };
            }
            else if (type == m)
            {
                return new string[]
                {
                    "Restoration",
                    "Armorer",
                    "Hand-to-hand",
                    "Medium Armor",
                    "Alchemy"
                };
            }

            return null;
        }

        private static string[] GetHealer(string type)
        {
            if (type == M)
            {
                return new string[]
                {
                    "Restoration",
                    "Mysticism",
                    "Alteration",
                    "Hand-to-hand",
                    "Speechcraft"
                };
            }
            else if (type == m)
            {
                return new string[]
                {
                    "Illusion",
                    "Alchemy",
                    "Unarmored",
                    "Light Armor",
                    "Blunt Weapon"
                };
            }

            return null;
        }

        private static string[] GetKnight(string type)
        {
            if (type == M)
            {
                return new string[]
                {
                    "Long Blade",
                    "Axe",
                    "Speechcraft",
                    "Heavy Armor",
                    "Block"
                };
            }
            else if (type == m)
            {
                return new string[]
                {
                    "Restoration",
                    "Mercantile",
                    "Medium Armor",
                    "Enchant",
                    "Armorer"
                };
            }

            return null;
        }

        private static string[] GetMage(string type)
        {
            if (type == M)
            {
                return new string[]
                {
                    "Mysticism",
                    "Destruction",
                    "Alteration",
                    "Illusion",
                    "Restoration"
                };
            }
            else if (type == m)
            {
                return new string[]
                {
                    "Enchant",
                    "Alchemy",
                    "Unarmored",
                    "Short Blade",
                    "Conjuration"
                };
            }

            return null;
        }

        private static string[] GetMonk(string type)
        {
            if (type == M)
            {
                return new string[]
                {
                    "Hand-to-hand",
                    "Unarmored",
                    "Athletics",
                    "Acrobatics",
                    "Sneak"
                };
            }
            else if (type == m)
            {
                return new string[]
                {
                    "Block",
                    "Marksman",
                    "Light Armor",
                    "Restoration",
                    "Blunt Weapon"
                };
            }

            return null;
        }

        private static string[] GetNightblade(string type)
        {
            if (type == M)
            {
                return new string[]
                {
                    "Mysticism",
                    "Illusion",
                    "Alteration",
                    "Sneak",
                    "Short Blade"
                };
            }
            else if (type == m)
            {
                return new string[]
                {
                    "Light Armor",
                    "Unarmored",
                    "Destruction",
                    "Marksman",
                    "Security"
                };
            }

            return null;
        }

        private static string[] GetPilgrim(string type)
        {
            System.Console.WriteLine("GETTING PILGRIM");
            if (type == M)
            {
                return new string[]
                {
                    "Speechcraft",
                    "Mercantile",
                    "Marksman",
                    "Restoration",
                    "Medium Armor"
                };
            }
            else if (type == m)
            {
                return new string[]
                {
                    "Illusion",
                    "Hand-to-hand",
                    "Short Blade",
                    "Block",
                    "Alchemy"
                };
            }

            return null;
        }

        private static string[] GetRogue(string type)
        {
            if (type == M)
            {
                return new string[]
                {
                    "Short Blade",
                    "Mercantile",
                    "Axe",
                    "Light Armor",
                    "Hand-to-hand"
                };
            }
            else if (type == m)
            {
                return new string[]
                {
                    "Block",
                    "Medium Armor",
                    "Speechcraft",
                    "Athletics",
                    "Long Blade"
                };
            }

            return null;
        }

        private static string[] GetScout(string type)
        {
            if (type == M)
            {
                return new string[]
                {
                    "Sneak",
                    "Long Blade",
                    "Medium Armor",
                    "Athletics",
                    "Block"
                };
            }
            else if (type == m)
            {
                return new string[]
                {
                    "Marksman",
                    "Alchemy",
                    "Alteration",
                    "Light Armor",
                    "Unarmored"
                };
            }

            return null;
        }

        private static string[] GetSorcerer(string type)
        {
            if (type == M)
            {
                return new string[]
                {
                    "Enchant",
                    "Conjuration",
                    "Mysticism",
                    "Destruction",
                    "Alteration"
                };
            }
            else if (type == m)
            {
                return new string[]
                {
                    "Illusion",
                    "Medium Armor",
                    "Heavy Armor",
                    "Marksman",
                    "Short Blade"
                };
            }

            return null;
        }

        private static string[] GetSpellsword(string type)
        {
            if (type == M)
            {
                return new string[]
                {
                    "Block",
                    "Restoration",
                    "Long Blade",
                    "Destruction",
                    "Alteration"
                };
            }
            else if (type == m)
            {
                return new string[]
                {
                    "Blunt Weapon",
                    "Enchant",
                    "Alchemy",
                    "Medium Armor",
                    "Axe"
                };
            }

            return null;
        }

        private static string[] GetThief(string type)
        {
            if (type == M)
            {
                return new string[]
                {
                    "Security",
                    "Sneak",
                    "Acrobatics",
                    "Light Armor",
                    "Short Blade"
                };
            }
            else if (type == m)
            {
                return new string[]
                {
                    "Marksman",
                    "Speechcraft",
                    "Hand-to-hand",
                    "Mercantile",
                    "Athletics"
                };
            }

            return null;
        }

        private static string[] GetWarrior(string type)
        {
            if (type == M)
            {
                return new string[]
                {
                    "Long Blade",
                    "Medium Armor",
                    "Heavy Armor",
                    "Athletics",
                    "Block"
                };
            }
            else if (type == m)
            {
                return new string[]
                {
                    "Armorer",
                    "Spear",
                    "Marksman",
                    "Axe",
                    "Blunt Weapon"
                };
            }

            return null;
        }

        private static string[] GetWitchhunter(string type)
        {
            if (type == M)
            {
                return new string[]
                {
                    "Conjuration",
                    "Enchant",
                    "Alchemy",
                    "Light Armor",
                    "Marksman"
                };
            }
            else if (type == m)
            {
                return new string[]
                {
                    "Unarmored",
                    "Block",
                    "Blunt Weapon",
                    "Sneak",
                    "Mysticism"
                };
            }

            return null;
        }

    }
}
