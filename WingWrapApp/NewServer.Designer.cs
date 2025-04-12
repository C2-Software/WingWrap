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
            SNameInput.Margin = new Padding(2, 2, 2, 2);
            SNameInput.Name = "SNameInput";
            SNameInput.PlaceholderText = "Server Name...";
            SNameInput.Size = new Size(211, 27);
            SNameInput.TabIndex = 1;
            // 
            // SSubmitButton
            // 
            SSubmitButton.Location = new Point(638, 416);
            SSubmitButton.Margin = new Padding(2, 2, 2, 2);
            SSubmitButton.Name = "SSubmitButton";
            SSubmitButton.Size = new Size(90, 27);
            SSubmitButton.TabIndex = 2;
            SSubmitButton.Text = "Submit";
            SSubmitButton.UseVisualStyleBackColor = true;
            SSubmitButton.Click += SSubmitButton_Click;
            // 
            // NewServer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 464);
            Controls.Add(SSubmitButton);
            Controls.Add(SNameInput);
            Controls.Add(SNameLabel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "NewServer";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SNameLabel;
        private TextBox SNameInput;
        private Button SSubmitButton;

    }
}