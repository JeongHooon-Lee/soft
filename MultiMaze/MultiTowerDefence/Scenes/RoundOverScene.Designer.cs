﻿namespace MazeClient
{
    partial class RoundOverScene
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
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 72);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 6;
            label1.Text = "5번 화면";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(542, 355);
            button1.Name = "button1";
            button1.Size = new Size(163, 29);
            button1.TabIndex = 5;
            button1.Text = "6번 화면 이동";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RoundOverScene
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "RoundOverScene";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}