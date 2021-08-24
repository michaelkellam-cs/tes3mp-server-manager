using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TES3MP_GUI.src.Data
{
    /*
     * Custom Reading/Writing class to easily 
     * modify my properties.txt file. If extended,
     * this could be fairly modular.
     */
    public static class ReadWrite
    {

        public static void CreateIfNull(string file)
        {
            if (!File.Exists(file))
            {
                FileStream fs = File.Create(Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "/" + file);
                fs.Close();
                AddNewRow(file, "user", "");
                AddNewRow(file, "ip", "");
                AddNewRow(file, "pass", "");
                AddNewRow(file, "directory", "");
            }
        }

        // Returns the entry from a row.
        // This is assuming the file is using the format of:
        // name=Thomas
        // In this case, if we called this functin on the row "name",
        // it should return "Thomas".
        public static string ReadFileRowEntry(string file, string row)
        {
            if (!File.Exists(file))
                return null;

            using (StreamReader sr = File.OpenText(file))
            {
                string curr = "";
                while ((curr = sr.ReadLine()) != null)
                {
                    if (curr.Length >= row.Length && curr.Substring(0, row.Length) == row)
                    {
                        return curr.Substring(row.Length + 1);
                    }
                }
            }

            return null;
        }

        // Replaces an entry by row. Returns true if a row was found and replaced, false if not.
        public static bool WriteFileRowEntry(string file, string row, string entry)
        {
            string newText = "";

            bool found = false;
            using (StreamReader sr = File.OpenText(file))
            {
                string curr = "";
                while ((curr = sr.ReadLine()) != null)
                {
                    if (curr.Substring(0, curr.IndexOf('=')) == row)
                    {
                        newText += row + "=" + entry + "\n";
                        found = true;
                    } else
                    {
                        newText += curr + "\n";
                    }
                }
                sr.Close();
            }

            if (!found)
                return false;

            try
            {
                byte[] stringData = new UTF8Encoding(true).GetBytes(newText);
                File.WriteAllBytes(file, stringData);
                // System.Console.WriteLine("DATA WRITTEN");
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        // Adds a new entry to the file. This is used to add more properties, such as user, ip, password, and directory.
        private static void AddNewRow(string file, string row, string entry)
        {
            using (StreamWriter sw = File.AppendText(file))
            {
                sw.WriteLine(row + "=" + entry);
            }
        }
    }
}
