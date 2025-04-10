namespace WingWrapApp
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("Server1");
            NewServerButton = new Button();
            ServerList = new ListView();
            SuspendLayout();
            // 
            // NewServerButton
            // 
            NewServerButton.Location = new Point(26, 578);
            NewServerButton.Name = "NewServerButton";
            NewServerButton.Size = new Size(239, 85);
            NewServerButton.TabIndex = 0;
            NewServerButton.Text = "New Server";
            NewServerButton.UseVisualStyleBackColor = true;
            NewServerButton.Click += button1_Click;
            // 
            // ServerList
            // 
            ServerList.HoverSelection = true;
            ServerList.Items.AddRange(new ListViewItem[] { listViewItem1 });
            ServerList.Location = new Point(12, 12);
            ServerList.MultiSelect = false;
            ServerList.Name = "ServerList";
            ServerList.Size = new Size(1045, 560);
            ServerList.TabIndex = 1;
            ServerList.UseCompatibleStateImageBehavior = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 693);
            Controls.Add(ServerList);
            Controls.Add(NewServerButton);
            Name = "Main";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button NewServerButton;
        private ListView ServerList;
    }
}