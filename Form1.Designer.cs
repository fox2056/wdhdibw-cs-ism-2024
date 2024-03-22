
namespace lab1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxCalosc = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBoxTyp = new System.Windows.Forms.ListBox();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.listBoxCzas = new System.Windows.Forms.ListBox();
            this.listBoxAdresWe = new System.Windows.Forms.ListBox();
            this.listBoxAdresWy = new System.Windows.Forms.ListBox();
            this.listBoxProtokol = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wybraćPlikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Czytaj plik";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(853, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Plik";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(151, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(696, 30);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "C:\\Users\\Oleksii\\Downloads\\db_small\\ZALog2003.09.30.txt";
            // 
            // listBoxCalosc
            // 
            this.listBoxCalosc.FormattingEnabled = true;
            this.listBoxCalosc.ItemHeight = 20;
            this.listBoxCalosc.Location = new System.Drawing.Point(12, 103);
            this.listBoxCalosc.Name = "listBoxCalosc";
            this.listBoxCalosc.Size = new System.Drawing.Size(941, 264);
            this.listBoxCalosc.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 374);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(940, 30);
            this.progressBar1.TabIndex = 4;
            // 
            // listBoxTyp
            // 
            this.listBoxTyp.FormattingEnabled = true;
            this.listBoxTyp.ItemHeight = 20;
            this.listBoxTyp.Location = new System.Drawing.Point(12, 412);
            this.listBoxTyp.Name = "listBoxTyp";
            this.listBoxTyp.Size = new System.Drawing.Size(120, 444);
            this.listBoxTyp.TabIndex = 5;
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 20;
            this.listBoxData.Location = new System.Drawing.Point(138, 412);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(120, 444);
            this.listBoxData.TabIndex = 6;
            // 
            // listBoxCzas
            // 
            this.listBoxCzas.FormattingEnabled = true;
            this.listBoxCzas.ItemHeight = 20;
            this.listBoxCzas.Location = new System.Drawing.Point(264, 412);
            this.listBoxCzas.Name = "listBoxCzas";
            this.listBoxCzas.Size = new System.Drawing.Size(162, 444);
            this.listBoxCzas.TabIndex = 7;
            // 
            // listBoxAdresWe
            // 
            this.listBoxAdresWe.FormattingEnabled = true;
            this.listBoxAdresWe.ItemHeight = 20;
            this.listBoxAdresWe.Location = new System.Drawing.Point(432, 410);
            this.listBoxAdresWe.Name = "listBoxAdresWe";
            this.listBoxAdresWe.Size = new System.Drawing.Size(171, 444);
            this.listBoxAdresWe.TabIndex = 8;
            // 
            // listBoxAdresWy
            // 
            this.listBoxAdresWy.FormattingEnabled = true;
            this.listBoxAdresWy.ItemHeight = 20;
            this.listBoxAdresWy.Location = new System.Drawing.Point(609, 410);
            this.listBoxAdresWy.Name = "listBoxAdresWy";
            this.listBoxAdresWy.Size = new System.Drawing.Size(166, 444);
            this.listBoxAdresWy.TabIndex = 9;
            // 
            // listBoxProtokol
            // 
            this.listBoxProtokol.FormattingEnabled = true;
            this.listBoxProtokol.ItemHeight = 20;
            this.listBoxProtokol.Location = new System.Drawing.Point(781, 410);
            this.listBoxProtokol.Name = "listBoxProtokol";
            this.listBoxProtokol.Size = new System.Drawing.Size(172, 444);
            this.listBoxProtokol.TabIndex = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 860);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(960, 32);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 21);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(149, 25);
            this.toolStripStatusLabel2.Text = "Gotowy do pracy";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.oProgramieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 33);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wybraćPlikToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // wybraćPlikToolStripMenuItem
            // 
            this.wybraćPlikToolStripMenuItem.Name = "wybraćPlikToolStripMenuItem";
            this.wybraćPlikToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.wybraćPlikToolStripMenuItem.Text = "Wybrać plik";
            this.wybraćPlikToolStripMenuItem.Click += new System.EventHandler(this.wybraćPlikToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem1});
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            // 
            // oProgramieToolStripMenuItem1
            // 
            this.oProgramieToolStripMenuItem1.Name = "oProgramieToolStripMenuItem1";
            this.oProgramieToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.oProgramieToolStripMenuItem1.Text = "O programie";
            this.oProgramieToolStripMenuItem1.Click += new System.EventHandler(this.oProgramieToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 892);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listBoxProtokol);
            this.Controls.Add(this.listBoxAdresWy);
            this.Controls.Add(this.listBoxAdresWe);
            this.Controls.Add(this.listBoxCzas);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.listBoxTyp);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listBoxCalosc);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lab_UZ";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBoxCalosc;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox listBoxTyp;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.ListBox listBoxCzas;
        private System.Windows.Forms.ListBox listBoxAdresWe;
        private System.Windows.Forms.ListBox listBoxAdresWy;
        private System.Windows.Forms.ListBox listBoxProtokol;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wybraćPlikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem1;
    }
}

