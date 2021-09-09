using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using System.IO;
using System.Threading;
using TES3MP_GUI.src.Extra;
using System.Windows.Forms;

namespace TES3MP_GUI
{
    /*
     * This takes care of all the Linux commands.
     * Using SSH allows us to pull player data, write player data,
     * upload new files, and get a stream of output data from our
     * output Tmux.
     * 
     * This also allows us to set up tmux commands to automatically run files through our tmux sessions.
     */

    public static class SshFunctions
    {

        public static SshClient Client;

        public static string serverTmux;
        public static string serverDir;
        public static string playerInfo;

        public static ShellStream shellStream;

        public static bool loggedIn = false;
        static SshFunctions()
        {
            //Thread thread = new Thread(() => GetStreamData(shellStream));
        }

        public static bool Login()
        {
            try
            {
                System.Console.WriteLine("SSH STARTED");

                string user = LoginForm.User;
                //string user = "ubuntu";
                string password = File.ReadAllText(LoginForm.PemFile);

                PrivateKeyFile privateKey;
                using (var keyStream = new MemoryStream(Encoding.ASCII.GetBytes(password)))
                {
                    privateKey = new PrivateKeyFile(keyStream);
                }
                string ip = LoginForm.IpAddress;
                Client = new SshClient(ip, 22, user, privateKey);
                Client.ConnectionInfo.Timeout = new TimeSpan(50000000);
                Client.Connect();
 
                

                return true;
            } catch (Exception)
            {
                return false;
            }
            
        }

        public static void SetDirectoriesAndShell(string thisDir)
        {
            serverTmux = "tes3-server";
            serverDir = thisDir;
            playerInfo = serverDir + "CoreScripts/data/player";

            ExecCommand("cd " + serverDir);

            shellStream = Client.CreateShellStream("vt-100", 80, 60, 800, 800, 65536);
        }

        public static string ExecCommand(string command)
        {
            try
            {
                SshCommand com = Client.CreateCommand(command);
                com.Execute();
                return com.Result;
            } catch (Exception)
            {
                return null;
            }
        }

        public static string TmuxCommand(string session, string command)    
        {
            string finalComm = "tmux send-keys -t \"$" + session + "\" C-z '" + command + "' Enter";
            return ExecCommand(finalComm);
        }

        public static string TmuxEcho(string session, string echo)
        {
            string finalComm = "tmux send-keys -t \"$" + session + "\" C-z 'echo \"" + echo + "\"' Enter";
            return ExecCommand(finalComm);
        }

        // Previous way of uploading files. I wasn't comfortable with just echo'ing out the results of the string,
        // then converting it to a JSON file, so I would recommend using the newer UploadFile method that uses SFTP.
        // Would not recommend using, but if you do, you will have to change the JsonInfo.cs file to account for apostrophes,
        // quotations, etc. Really, it would be best to just use the new UploadFile.
        public static bool UploadFileOld(string directory, string fileName, string file)
        {
            try
            {
                ExecCommand("echo $\'" + file + "\' > " + directory + "/" + fileName);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Uses SFTP to upload file. Converts data into bytes, then uses a MemoryStream to upload.
        public static bool UploadFile(string directory, string fileName, string fileData)
        {

            try
            {
                PrivateKeyFile privateKey;
                using (var keyStream = new MemoryStream(Encoding.ASCII.GetBytes(File.ReadAllText(LoginForm.PemFile))))
                {
                    privateKey = new PrivateKeyFile(keyStream);
                }
                using (var client = new SftpClient(LoginForm.IpAddress, 22, LoginForm.User, privateKey))
                {
                    client.Connect();

                    if (client.IsConnected)
                    {
                        byte[] byteData = Encoding.UTF8.GetBytes(fileData);
                        // Debugging.ShowMBox(Encoding.UTF8.GetString(byteData));
                        using (var ms = new MemoryStream(byteData))
                        {
                            ms.Write(byteData, 0, byteData.Length);
                            ms.Position = 0;
                            client.UploadFile(ms, directory + "/" + fileName);

                            return true;
                        }
                    } 

                    return false;
                }
            } catch (Exception err)
            {
                System.Console.WriteLine("Unable to upload file");
                Debugging.ShowMBox(err.ToString());
                return false;
            }
            
        }

        /// <summary>
        /// Checks if the server is running under the designated session.
        /// </summary>
        /// <param name="session"></param>
        /// <returns>Returns true if server is running, false if it isn't.</returns>
        public static bool IsServerRunning(string session)
        {
            string output = ExecCommand("tmux has-session -t " + session + " || echo \"Not found\"");
            if (output.Length > 0)
                return false;
            return true;
        }

        // Runs the file to start the TES3 server as well as start the output stream.
        public static bool StartServer(string session)
        {

            if (IsServerRunning(session))
            {
                System.Console.WriteLine("Cannot start server. Either server is already running, or tmux session is already active.");
                return false;
            }

            string tmuxComm = "tmux new-session -d -s " + session;
            ExecCommand(tmuxComm);
            string server = serverDir + "tes3mp-server";
            TmuxCommand(session, server);
            return true;
        }

        /// <summary>
        /// Stops the server 
        /// </summary>
        /// <param name="session"></param>
        /// <returns>Returns true if server successfully stopped, false if unsuccessful.    </returns>
        public static bool StopServer(string session)
        {
            if (!IsServerRunning(session))
            {
                System.Console.WriteLine("Server is not running on this session.");
                return false;
            }
            try
            {
                ExecCommand("tmux kill-session -t " + session);
                return true;
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Error closing server.");
                return false;
            }

        }

    }

    
}
