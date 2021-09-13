using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Chilkat;
using TES3MP_GUI.src.Data;
using TES3MP_GUI.src.Enums;
using TES3MP_GUI.src.Extra;

namespace TES3MP_GUI
{
    /*
     * 
     * This class is what I use to edit/parse JSON data.
     * In here, there are also the specific applications of these JSON functions, such as:
     * - Editing attributes,
     * - Editing stats,
     * - Editing birthsigns
     * 
     * In the future, I may put the game specific modifications to class so that I can keep the JSON
     * stuff separate to make it more modular, but this will do for now.
     * 
     * NOTE: I have changed the way JSON files are uploaded, so the fixing of apostrophes/quotations are now gone,
     * since SFTP doesn't need that to happen, I would only need that for when I'm uploading it using echo.
     */
    public static class JsonInfo
    {

        public readonly static string[] attStr =
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

        // Gets the file through the 'cat' command in Linux.
        public static string GetJson(string player)
        {
            return SshFunctions.ExecCommand("cat " + SshFunctions.playerInfo + "/" + player + ".json");
        }

        // The login information is saved on each JSON file. I have not added the option to edit it, but
        // I may in the future.
        public static string[] GetLogin(string player)
        {
            JsonDocument jd = JsonDocument.Parse(GetJson(player));
            string user = jd.RootElement.GetProperty("login").GetProperty("name").ToString();
            string password = jd.RootElement.GetProperty("login").GetProperty("password").ToString();
            string[] info = { user, password };
            return info;
        }


        // 1. Strength, 2. Intelligence, 3. Willpower, 4. Agility, 5. Speed, 6. Endurance, 7. Personality, 8. Luck
        public static int[] GetAttributes(string player)
        {
            JsonDocument jd = JsonDocument.Parse(GetJson(player));
            JsonElement je = jd.RootElement.GetProperty("attributes");
            int[] attributes = new int[8];

            for (int i = 0; i < attributes.Length; i++)
            {
                int curr = je.GetProperty(attStr[i]).GetProperty("base").GetInt32();
                attributes[i] = curr;
            }

            return attributes;
        }

        // Pulls specific attribute value based on its name.
        public static int GetAttribute(string player, string attribute)
        {
            JsonDocument jd = JsonDocument.Parse(GetJson(player));
            JsonElement je = jd.RootElement.GetProperty("attributes");
            return je.GetProperty(attribute).GetProperty("base").GetInt32();
        }

        public static bool EditAttributes(string player, int[] values)
        {
            JsonObject jo = new JsonObject();
            string js = GetJson(player);
            jo.Load(js);
            
            for (int i = 0; i < attStr.Length; i++)
            {
                System.Console.WriteLine("AT INDEX " + i);
                jo.ObjectOf("attributes").ObjectOf(attStr[i]).SetIntOf("base", values[i]);
            }

            jo.EmitCompact = false;

            return SshFunctions.UploadFile(SshFunctions.playerInfo, player + ".json", jo.Emit());
        }

        public static string GetBirthsign(string player)
        {

            JsonDocument jd = JsonDocument.Parse(GetJson(player));
            JsonElement je = jd.RootElement.GetProperty("character");

            return je.GetProperty("birthsign").GetString();
        }

        public static bool EditBirthsign(string player, string birthsign)
        {
            JsonObject jo = new JsonObject();
            string js = GetJson(player);
            jo.Load(js);
            jo.ObjectOf("character").SetStringOf("birthsign", birthsign);
            jo.EmitCompact = false;
            //System.Console.WriteLine(jo.Emit());

            string fixedStr = jo.Emit();
            //SshFunctions.UploadFile(SshFunctions.playerInfo, player + ".json", jo.Emit()/*.Replace("'", "\'")*/);

            //string testingUpload = "I am an uploaded file";
            //SshFunctions.UploadFileNew(SshFunctions.playerInfo, "newPlayer.json", fixedStr);

            return SshFunctions.UploadFile(SshFunctions.playerInfo, player + ".json", fixedStr);
        }

        public static bool IsCustomClass(string player)
        {

            JsonObject jo = new JsonObject();
            string js = GetJson(player);
            jo.Load(js);
            jo.EmitCompact = false;

            return jo.ObjectOf("customClass") != null;
        }

        public static string[] GetClassNameAndDesc(string player)
        {
            if (!IsCustomClass(player))
                return null;

            JsonDocument jd = JsonDocument.Parse(GetJson(player));
            JsonElement je = jd.RootElement.GetProperty("customClass");

            string[] strs = new string[2];
            strs[0] = je.GetProperty("name").GetString();
            strs[1] = je.GetProperty("description").GetString();

            return strs;
        }

        public static string GetClassNameNotCustom(string player)
        {
            if (IsCustomClass(player))
                return null;

            JsonDocument jd = JsonDocument.Parse(GetJson(player));
            JsonElement je = jd.RootElement.GetProperty("character");

            string preStr = je.GetProperty("class").GetString();

            return char.ToUpper(preStr[0]) + preStr.Substring(1);
        }

        public static string[] GetMajorMinor(string player, string type)
        {
            if (IsCustomClass(player))
            {
                JsonDocument jd = JsonDocument.Parse(GetJson(player));
                JsonElement je = jd.RootElement.GetProperty("customClass");
                string[] currSkills = 
                    je.GetProperty(type + "Skills").GetString()
                    .Replace(",", "")
                    .Split(' ');
                for (int i = 0; i < currSkills.Length; i++)
                    currSkills[i] = SkillsInfo.ConvertSkill(currSkills[i]);
                return currSkills;
            } else
            {
                string clssFixed = GetClassNameNotCustom(player);
                clssFixed = char.ToUpper(clssFixed[0]) + clssFixed.Substring(1);
                return DefaultClasses.GetClass(clssFixed, type);
            }
        }

        public static string[] GetMisc(string player)
        {
            string[] miscSkills = new string[17];

            string[] maj = GetMajorMinor(player, "major");
            string[] min = GetMajorMinor(player, "minor");

            for (int i = 0; i < maj.Length; i++)
            {
                maj[i] = maj[i].Replace("Handtohand", "Hand-to-hand");
                min[i] = min[i].Replace("Handtohand", "Hand-to-hand");
            }

            System.Console.WriteLine("STARTING SEARCH!!!");
            Debugging.PrintArray(maj);
            Debugging.PrintArray(min);

            int index = 0;
            foreach (string item in DefaultClasses.AllSkills)
            {
                if (!maj.Contains(item) && !min.Contains(item))
                {
                    miscSkills[index] = item;
                    index++;
                    System.Console.WriteLine("THIS IS: " + item);
                    if (index >= 17)
                        break;
                }
            }

            //System.Console.WriteLine("MAJOR");
            //Debugging.PrintArray(maj);
            //System.Console.WriteLine("MINOR");
            //Debugging.PrintArray(min);
            //System.Console.WriteLine("MISC");
            //Debugging.PrintArray(miscSkills);

            return miscSkills;
        }

        public static int[] GetSkillData(string player)
        {
            int[] skills = new int[27];

            JsonDocument jd = JsonDocument.Parse(GetJson(player));
            JsonElement je = jd.RootElement.GetProperty("skills");

            for (int i = 0; i < skills.Length; i++)
            {
                string currSkill = ((SkillsInfo.Skills) i).ToString()
                    .Replace("_", "")
                    .Replace("-", "")
                    .Replace(" ", "");
                string fixedSkill = char.ToUpper(currSkill[0]) + currSkill.Substring(1).ToLower();
                skills[i] = je.GetProperty(fixedSkill).GetProperty("base").GetInt32();
            }

            return skills;
        }

        public static bool EditSkills(string player, int[] skills)
        {
            JsonObject jo = new JsonObject();
            string js = GetJson(player);
            jo.Load(js);
            for (int i = 0; i < skills.Length; i++)
            {
                string currSkill = ((SkillsInfo.Skills)i).ToString()
                    .Replace("_", "")
                    .Replace("-", "")
                    .Replace(" ", "");
                currSkill = char.ToUpper(currSkill[0]) + currSkill.Substring(1).ToLower();

                jo.ObjectOf("skills").ObjectOf(currSkill).SetIntOf("base", skills[i]);
            }
            //Debugging.PrintArray(skills);
            jo.EmitCompact = false;
            string fixedStr = jo.Emit();
            return SshFunctions.UploadFile(SshFunctions.playerInfo, player + ".json", fixedStr);
        }

        public static bool EditClassPremade(string player, string newClass)
        {
            newClass = newClass.ToLower();

            JsonObject jo = new JsonObject();
            string js = GetJson(player);
            jo.Load(js);

            jo.ObjectOf("character").SetStringOf("class", newClass);

            jo.Delete("customClass");
            jo.AddArrayAt(3, "customClass");

            jo.EmitCompact = false;
            //System.Console.WriteLine(jo.Emit());

            string fixedJson = jo.Emit()
                .Replace("\"customClass\": [\r\n  ],", "\"customClass\":[],");

            return SshFunctions.UploadFile(SshFunctions.playerInfo, player + ".json", fixedJson);
        }

        public static bool CreateClass(string player, int specialization, string minorSkills, string majorAttributes,
                                       string majorSkills, string className, string description)
        {
            JsonObject jo = new JsonObject();

            // Replacing here changes "customClass" from a JSON array to a JSON object.
            // If a class is initially default, then customClass is an array, but it should
            // be an object. So I just replaced the brackets with braces and that fixed it.

            if (!IsCustomClass(player))
            {
                System.Console.WriteLine("Creating from previously default player");
                
                try
                {
                    string js = GetJson(player)
                    .Replace("\"customClass\":[]", "\"customClass\":{}")
                    .Replace("\"customClass\": [\r\n  ],", "\"customClass\":{}");
                    jo.Load(js);

                    jo.ObjectOf("character").SetStringOf("class", "custom");

                    jo.ObjectOf("customClass").AddIntAt(-1, "specialization", specialization);
                    jo.ObjectOf("customClass").AddStringAt(-1, "minorSkills", minorSkills);
                    jo.ObjectOf("customClass").AddStringAt(-1, "majorAttributes", majorAttributes);
                    jo.ObjectOf("customClass").AddStringAt(-1, "majorSkills", majorSkills);
                    jo.ObjectOf("customClass").AddStringAt(-1, "name", className);
                    jo.ObjectOf("customClass").AddStringAt(-1, "description", description);

                    jo.EmitCompact = false;

                    string fixedStr = jo.Emit().Replace("'", "\\\'");
                    return SshFunctions.UploadFile(SshFunctions.playerInfo, player + ".json", fixedStr);
                } catch (Exception)
                {
                    return false;
                }
                
            }
            else
            {
                try
                {
                    System.Console.WriteLine("Creating from previously custom player");
                    string js = GetJson(player);
                    jo.Load(js);

                    jo.ObjectOf("customClass").SetIntOf("specialization", specialization);
                    jo.ObjectOf("customClass").SetStringOf("minorSkills", minorSkills);
                    jo.ObjectOf("customClass").SetStringOf("majorAttributes", majorAttributes);
                    jo.ObjectOf("customClass").SetStringOf("majorSkills", majorSkills);
                    jo.ObjectOf("customClass").SetStringOf("name", className);
                    jo.ObjectOf("customClass").SetStringOf("description", description);

                    jo.EmitCompact = false;

                    string fixedStr = jo.Emit();
                    return SshFunctions.UploadFile(SshFunctions.playerInfo, player + ".json", fixedStr);
                } catch (Exception)
                {
                    return false;
                }
                
            }
            
        }

        // When going from a custom class character to a default class, it's important to run this
        // method to ensure that it can be transitioned to a custom class if the user wishes to do so
        // in the future. Otherwise, it would be impossible to create a cusotm class.
        public static void DeleteCustom(string player)
        {
            JsonObject jo = new JsonObject();
            string js = GetJson(player).Replace("\"customClass\":[]", "\"customClass\":{}");
            jo.Load(js);

            jo.Delete("customClass");
            jo.AddArrayAt(3, "customClass");
            jo.EmitCompact = false;
            //System.Console.WriteLine(jo.Emit());
            string fixedStr = jo.Emit().Replace("\"customClass\": [\r\n  ],", "\"customClass\":[]");
            SshFunctions.UploadFile(SshFunctions.playerInfo, "testing.json", fixedStr);
        }

        public static int GetGender(string player)
        {
            JsonDocument jd = JsonDocument.Parse(GetJson(player));
            int gender = jd.RootElement.GetProperty("character").GetProperty("gender").GetInt32();

            return gender;
        }

        public static string GetRace(string player)
        {
            JsonDocument jd = JsonDocument.Parse(GetJson(player));
            string race = jd.RootElement.GetProperty("character").GetProperty("race").GetString();

            return Char.ToUpper(race[0]) + race.Substring(1);
        }
    }

    
}
