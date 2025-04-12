using System.Diagnostics;
using System.IO;

namespace WingWrapApp
{
    partial class NewServer
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
            SNameLabel = new Label();
            SNameInput = new TextBox();
            SSubmitButton = new Button();
            ServerPortInput = new TextBox();
            ServerPortLabel = new Label();
            ServerExeInput = new TextBox();
            SeverExeLabel = new Label();
            ServerExecutableDialog = new OpenFileDialog();
            SelectExecutableButton = new Button();
            SuspendLayout();
            // 
            // SNameLabel
            // 
            SNameLabel.AutoSize = true;
            SNameLabel.Location = new Point(22, 26);
            SNameLabel.Margin = new Padding(2, 0, 2, 0);
            SNameLabel.Name = "SNameLabel";
            SNameLabel.Size = new Size(94, 20);
            SNameLabel.TabIndex = 0;
            SNameLabel.Text = "Server Name";
            // 
            // SNameInput
            // 
            SNameInput.Location = new Point(22, 49);
            SNameInput.Margin = new Padding(2);
            SNameInput.MaxLength = 25;
            SNameInput.Name = "SNameInput";
            SNameInput.PlaceholderText = "(e.g. Minecraft)";
            SNameInput.Size = new Size(211, 27);
            SNameInput.TabIndex = 1;
            // 
            // SSubmitButton
            // 
            SSubmitButton.Location = new Point(638, 416);
            SSubmitButton.Margin = new Padding(2);
            SSubmitButton.Name = "SSubmitButton";
            SSubmitButton.Size = new Size(90, 27);
            SSubmitButton.TabIndex = 2;
            SSubmitButton.Text = "Submit";
            SSubmitButton.UseVisualStyleBackColor = true;
            SSubmitButton.Click += SSubmitButton_Click;
            // 
            // ServerPortInput
            // 
            ServerPortInput.Location = new Point(22, 120);
            ServerPortInput.Margin = new Padding(2);
            ServerPortInput.MaxLength = 25;
            ServerPortInput.Name = "ServerPortInput";
            ServerPortInput.PlaceholderText = "(e.g 25565)";
            ServerPortInput.Size = new Size(211, 27);
            ServerPortInput.TabIndex = 4;
            // 
            // ServerPortLabel
            // 
            ServerPortLabel.AutoSize = true;
            ServerPortLabel.Location = new Point(22, 97);
            ServerPortLabel.Margin = new Padding(2, 0, 2, 0);
            ServerPortLabel.Name = "ServerPortLabel";
            ServerPortLabel.Size = new Size(80, 20);
            ServerPortLabel.TabIndex = 3;
            ServerPortLabel.Text = "Server Port";
            // 
            // ServerExeInput
            // 
            ServerExeInput.Location = new Point(22, 196);
            ServerExeInput.Margin = new Padding(2);
            ServerExeInput.MaxLength = 25;
            ServerExeInput.Name = "ServerExeInput";
            ServerExeInput.PlaceholderText = "(e.g. C:/user/Minecraft_server)";
            ServerExeInput.Size = new Size(211, 27);
            ServerExeInput.TabIndex = 6;
            // 
            // SeverExeLabel
            // 
            SeverExeLabel.AutoSize = true;
            SeverExeLabel.Location = new Point(22, 173);
            SeverExeLabel.Margin = new Padding(2, 0, 2, 0);
            SeverExeLabel.Name = "SeverExeLabel";
            SeverExeLabel.Size = new Size(126, 20);
            SeverExeLabel.TabIndex = 5;
            SeverExeLabel.Text = "Server Executable";
            // 
            // ServerExecutableDialog
            // 
            ServerExecutableDialog.FileName = "ServerExecutableInput";
            ServerExecutableDialog.Title = "Select Server Executable";
            ServerExecutableDialog.FileOk += ServerExecutableDialog_FileOk;
            // 
            // SelectExecutableButton
            // 
            SelectExecutableButton.Location = new Point(238, 196);
            SelectExecutableButton.Name = "SelectExecutableButton";
            SelectExecutableButton.Size = new Size(94, 29);
            SelectExecutableButton.TabIndex = 7;
            SelectExecutableButton.Text = "Select file...";
            SelectExecutableButton.UseVisualStyleBackColor = true;
            SelectExecutableButton.Click += SelectExecutableButton_Click;
            // 
            // NewServer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 464);
            Controls.Add(SelectExecutableButton);
            Controls.Add(ServerExeInput);
            Controls.Add(SeverExeLabel);
            Controls.Add(ServerPortInput);
            Controls.Add(ServerPortLabel);
            Controls.Add(SSubmitButton);
            Controls.Add(SNameInput);
            Controls.Add(SNameLabel);
            Margin = new Padding(2);
            Name = "NewServer";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SNameLabel;
        private TextBox SNameInput;
        private Button SSubmitButton;
        private TextBox ServerPortInput;
        private Label ServerPortLabel;
        private TextBox ServerExeInput;
        private Label SeverExeLabel;
        private OpenFileDialog ServerExecutableDialog;
        private Button SelectExecutableButton;
    }
}