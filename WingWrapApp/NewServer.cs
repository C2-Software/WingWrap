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
using System.Text.Json;

namespace WingWrapApp
{
    public partial class NewServer : Form
    {
        public NewServer()
        {
            InitializeComponent();
        }

        public class Serverdata
        {
            public string serverName { get; set; }
            public int serverPort { get; set; }
            public string serverfile { get; set; }
        }

        public void ammendServer()
        {
            var serverData = new Serverdata
            {
                serverName = SNameInput.Text,
            };

            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(serverData, options);

            if (File.Exists("Servers.json") == true)
            {
                File.AppendAllText("Servers.json", jsonString);
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
