using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WingWrapApp
{
    public partial class NewServer : Form
    {
        public NewServer()
        {
            InitializeComponent();
        }

        public static void filesetup(string ServerName)
        {
            string path = "Servers.json";
            if (File.Exists(path))
            {
                Console.WriteLine("Debug file read");
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(ServerName);
                    Console.WriteLine("Debug file saved");
                }
            }
            else
            {
                File.WriteAllText(path, "");
                Console.WriteLine("Debug file made");
            }
        }

        private void SSubmitButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button pressd");
            filesetup(SNameInput.Text);
        }

    }
}
