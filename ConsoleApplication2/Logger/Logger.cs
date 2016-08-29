using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnowRentLibrary.Logger
{
    public class Logger
    {
        public AlertMode AlertMode { get; set; }
        public LogMode LogMode { get; set; }
        public Logger()
        {

        }

        public Logger(LogMode logMode, AlertMode alertMode )
        {
            this.LogMode = logMode;
            this.AlertMode = alertMode;

        }

        public void Log(String toLog, String msg = null, String userDirectory = null)
        {
            if (msg == null)
            {
                msg = toLog;
            }
            if (userDirectory == null)
            {
                userDirectory = Path.GetTempPath() + "\\" + AppDomain.CurrentDomain.FriendlyName.ToString().Split('.')[0];
                Directory.CreateDirectory(userDirectory);
            }
            switch (this.LogMode)
            {
                case LogMode.NONE:
                    break;
                case LogMode.CONSOLE:
                    Console.WriteLine(toLog);
                    break;
                case LogMode.EXTERNAL:
                    SaveToFile(toLog, userDirectory);
                    break;
                case LogMode.CURRENT_FOLDER:
                    TextWriter file = new StreamWriter(
                        AppDomain.CurrentDomain.BaseDirectory +
                        "\\current_logs",true, UTF8Encoding.UTF8);
                    file.WriteLine(toLog);
                    file.Close();
                    break;
                case LogMode.TEMP_FOLDER:

                    SaveToFile(toLog, userDirectory);
                    break;
                default:
                    break;
            }
            switch (this.AlertMode)
            {
                case AlertMode.NONE:
                    break;
                case AlertMode.CONSOLE:
                    Console.WriteLine(toLog);
                    break;
                case AlertMode.MESSAGE_BOX:
                    //MessageBox.Show(msg);
                    System.Windows.Forms.MessageBox.Show(msg);
                    break;
                case AlertMode.TOAST:   
                    break;
                case AlertMode.OVERLAY:
                    break;
                default:
                    break;
            }
        }

        private static void SaveToFile(String toLog, String userDirectory)
        {
            TextWriter file1 = new StreamWriter(
              userDirectory + "\\current_logs", true, UTF8Encoding.UTF8);
            Directory.CreateDirectory(userDirectory.ToString());
            file1.WriteLine(toLog);
            file1.Close();


        }

        public void Log(Exception toLog, String msg = null)
        {
            if (msg == null)
            {
                msg = toLog.Message;
            }
        }
    }
}
