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
            SNameLabel.Location = new Point(27, 33);
            SNameLabel.Name = "SNameLabel";
            SNameLabel.Size = new Size(113, 25);
            SNameLabel.TabIndex = 0;
            SNameLabel.Text = "Server Name";
            // 
            // SNameInput
            // 
            SNameInput.Location = new Point(27, 61);
            SNameInput.Name = "SNameInput";
            SNameInput.PlaceholderText = "Server Name...";
            SNameInput.Size = new Size(263, 31);
            SNameInput.TabIndex = 1;
            // 
            // SSubmitButton
            // 
            SSubmitButton.Location = new Point(798, 520);
            SSubmitButton.Name = "SSubmitButton";
            SSubmitButton.Size = new Size(112, 34);
            SSubmitButton.TabIndex = 2;
            SSubmitButton.Text = "Submit";
            SSubmitButton.UseVisualStyleBackColor = true;
            SSubmitButton.Click += SSubmitButton_Click;
            // 
            // NewServer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 580);
            Controls.Add(SSubmitButton);
            Controls.Add(SNameInput);
            Controls.Add(SNameLabel);
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