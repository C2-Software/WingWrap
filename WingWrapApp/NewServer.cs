using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace WingWrapApp
{
    public partial class NewServer : Form
    {
        public NewServer()
        {
            InitializeComponent();
        }

        public static void ammendServer()
        {
            if (File.Exists("Servers.json") == true)
            {
                Debug.Print("File made!");
            }




            //string writetext = "Test";

            //File.WriteAllText("Servers.json", writetext);
            //Debug.Print("Generating file...");

            //if (File.Exists("Servers.json") == true)
            //{
            //    Debug.Print("File made!");
            //}
        }

        private void SSubmitButton_Click(object sender, EventArgs e)
        {
            Debug.Print("Submit button pressed");
            ammendServer();
        }

    }
}
