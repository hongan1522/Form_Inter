﻿namespace WindowsFormsApp1
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            qlnv1 = new QLNV();
            tabPage2 = new TabPage();
            qlOrder1 = new QLOrder();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1296, 814);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(qlnv1);
            tabPage1.Location = new Point(8, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1280, 767);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // qlnv1
            // 
            qlnv1.Dock = DockStyle.Fill;
            qlnv1.Location = new Point(3, 3);
            qlnv1.Margin = new Padding(3, 4, 3, 4);
            qlnv1.Name = "qlnv1";
            qlnv1.Size = new Size(1274, 761);
            qlnv1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(qlOrder1);
            tabPage2.Location = new Point(8, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1280, 767);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // qlOrder1
            // 
            qlOrder1.Location = new Point(0, -12);
            qlOrder1.Name = "qlOrder1";
            qlOrder1.Size = new Size(2738, 1932);
            qlOrder1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1296, 814);
            Controls.Add(tabControl1);
            Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QLNV";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private QLNV qlnv1;
        private QLOrder qlOrder1;
    }
}

