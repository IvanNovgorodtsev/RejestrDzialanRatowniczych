using System;
using System.Windows.Forms;

namespace RejestrDzialanRatowniczych
{
    partial class Raporty
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.osobaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wypadekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(785, 355);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellBlick);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobaToolStripMenuItem,
            this.wypadekToolStripMenuItem,
            this.raportyToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(809, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // osobaToolStripMenuItem
            // 
            this.osobaToolStripMenuItem.Name = "osobaToolStripMenuItem";
            this.osobaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.osobaToolStripMenuItem.Text = "Osoba";
            this.osobaToolStripMenuItem.Click += new System.EventHandler(this.osobaToolStripMenuItem_Click);
            // 
            // wypadekToolStripMenuItem
            // 
            this.wypadekToolStripMenuItem.Name = "wypadekToolStripMenuItem";
            this.wypadekToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.wypadekToolStripMenuItem.Text = "Wypadek";
            this.wypadekToolStripMenuItem.Click += new System.EventHandler(this.wypadekToolStripMenuItem_Click);
            // 
            // raportyToolStripMenuItem
            // 
            this.raportyToolStripMenuItem.Name = "raportyToolStripMenuItem";
            this.raportyToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.raportyToolStripMenuItem.Text = "Raporty";
            this.raportyToolStripMenuItem.Click += new System.EventHandler(this.raportyToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Raport1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Raport2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Raport3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(255, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Raport4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(336, 51);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Raport5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // Raporty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 486);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Raporty";
            this.Text = "Raporty";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem osobaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wypadekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raportyToolStripMenuItem;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
    }
}

