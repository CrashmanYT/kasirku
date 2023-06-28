namespace Kasirku
{
    partial class Kasirku
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
            this.components = new System.ComponentModel.Container();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.noPembelianLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.kembalianLbl = new System.Windows.Forms.Label();
            this.totalPembelianLbl = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuPanel = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuBar.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.dataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.White;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(857, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "&Database";
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.Black;
            this.infoPanel.Controls.Add(this.noPembelianLbl);
            this.infoPanel.Controls.Add(this.timeLbl);
            this.infoPanel.Controls.Add(this.dateLbl);
            this.infoPanel.Controls.Add(this.kembalianLbl);
            this.infoPanel.Controls.Add(this.totalPembelianLbl);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Location = new System.Drawing.Point(0, 24);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(857, 170);
            this.infoPanel.TabIndex = 1;
            // 
            // noPembelianLbl
            // 
            this.noPembelianLbl.AutoSize = true;
            this.noPembelianLbl.Font = new System.Drawing.Font("DS-Digital", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noPembelianLbl.ForeColor = System.Drawing.Color.Lime;
            this.noPembelianLbl.Location = new System.Drawing.Point(33, 15);
            this.noPembelianLbl.Name = "noPembelianLbl";
            this.noPembelianLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.noPembelianLbl.Size = new System.Drawing.Size(39, 19);
            this.noPembelianLbl.TabIndex = 4;
            this.noPembelianLbl.Text = "No : ";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("DS-Digital", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.ForeColor = System.Drawing.Color.Lime;
            this.timeLbl.Location = new System.Drawing.Point(19, 59);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timeLbl.Size = new System.Drawing.Size(53, 19);
            this.timeLbl.TabIndex = 3;
            this.timeLbl.Text = "Time : ";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("DS-Digital", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.ForeColor = System.Drawing.Color.Lime;
            this.dateLbl.Location = new System.Drawing.Point(15, 37);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateLbl.Size = new System.Drawing.Size(57, 19);
            this.dateLbl.TabIndex = 2;
            this.dateLbl.Text = "Date : ";
            // 
            // kembalianLbl
            // 
            this.kembalianLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kembalianLbl.AutoSize = true;
            this.kembalianLbl.Font = new System.Drawing.Font("DS-Digital", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kembalianLbl.ForeColor = System.Drawing.Color.Lime;
            this.kembalianLbl.Location = new System.Drawing.Point(650, 77);
            this.kembalianLbl.Name = "kembalianLbl";
            this.kembalianLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.kembalianLbl.Size = new System.Drawing.Size(195, 36);
            this.kembalianLbl.TabIndex = 1;
            this.kembalianLbl.Text = "Kembalian : ";
            // 
            // totalPembelianLbl
            // 
            this.totalPembelianLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalPembelianLbl.AutoSize = true;
            this.totalPembelianLbl.Font = new System.Drawing.Font("DS-Digital", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPembelianLbl.ForeColor = System.Drawing.Color.Lime;
            this.totalPembelianLbl.Location = new System.Drawing.Point(650, 23);
            this.totalPembelianLbl.Name = "totalPembelianLbl";
            this.totalPembelianLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalPembelianLbl.Size = new System.Drawing.Size(131, 36);
            this.totalPembelianLbl.TabIndex = 0;
            this.totalPembelianLbl.Text = "Total : ";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.menuPanel.Controls.Add(this.textBox2);
            this.menuPanel.Controls.Add(this.button1);
            this.menuPanel.Controls.Add(this.textBox1);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 194);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(857, 64);
            this.menuPanel.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(304, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(535, 22);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(230, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(23, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 22);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridPanel
            // 
            this.dataGridPanel.Controls.Add(this.dataGridView1);
            this.dataGridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPanel.Location = new System.Drawing.Point(0, 258);
            this.dataGridPanel.Name = "dataGridPanel";
            this.dataGridPanel.Size = new System.Drawing.Size(857, 377);
            this.dataGridPanel.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(857, 377);
            this.dataGridView1.TabIndex = 0;
            // 
            // Kasirku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 635);
            this.Controls.Add(this.dataGridPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "Kasirku";
            this.Text = "Kasirku";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.dataGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label totalPembelianLbl;
        private System.Windows.Forms.Label noPembelianLbl;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label kembalianLbl;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel dataGridPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}

