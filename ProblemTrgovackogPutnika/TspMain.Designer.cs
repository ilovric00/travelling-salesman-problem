namespace ProblemTrgovackogPutnika
{
    partial class TspMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TspMain));
            this.CostMatrixLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.StartBttn = new System.Windows.Forms.Button();
            this.CostLabel = new System.Windows.Forms.Label();
            this.PathLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.IzbornikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NoviUnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartCityLabel = new System.Windows.Forms.Label();
            this.StartCityComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CostMatrixLabel
            // 
            this.CostMatrixLabel.AutoSize = true;
            this.CostMatrixLabel.BackColor = System.Drawing.Color.Transparent;
            this.CostMatrixLabel.Font = new System.Drawing.Font("Montserrat Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostMatrixLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.CostMatrixLabel.Location = new System.Drawing.Point(10, 36);
            this.CostMatrixLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CostMatrixLabel.Name = "CostMatrixLabel";
            this.CostMatrixLabel.Size = new System.Drawing.Size(142, 23);
            this.CostMatrixLabel.TabIndex = 0;
            this.CostMatrixLabel.Text = "Broj gradova: ";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.NumberLabel.Font = new System.Drawing.Font("Montserrat Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberLabel.ForeColor = System.Drawing.Color.Navy;
            this.NumberLabel.Location = new System.Drawing.Point(151, 36);
            this.NumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(92, 23);
            this.NumberLabel.TabIndex = 1;
            this.NumberLabel.Text = "Number";
            // 
            // StartBttn
            // 
            this.StartBttn.Image = ((System.Drawing.Image)(resources.GetObject("StartBttn.Image")));
            this.StartBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StartBttn.Location = new System.Drawing.Point(17, 259);
            this.StartBttn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.StartBttn.Name = "StartBttn";
            this.StartBttn.Size = new System.Drawing.Size(100, 29);
            this.StartBttn.TabIndex = 2;
            this.StartBttn.Text = "Start";
            this.StartBttn.UseVisualStyleBackColor = true;
            this.StartBttn.Click += new System.EventHandler(this.StartBttn_Click);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.BackColor = System.Drawing.Color.Transparent;
            this.CostLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.ForeColor = System.Drawing.Color.Green;
            this.CostLabel.Location = new System.Drawing.Point(13, 314);
            this.CostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(56, 23);
            this.CostLabel.TabIndex = 3;
            this.CostLabel.Text = "Cost:";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.BackColor = System.Drawing.Color.Transparent;
            this.PathLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathLabel.ForeColor = System.Drawing.Color.Teal;
            this.PathLabel.Location = new System.Drawing.Point(13, 291);
            this.PathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(64, 23);
            this.PathLabel.TabIndex = 4;
            this.PathLabel.Text = "Path: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IzbornikToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // IzbornikToolStripMenuItem
            // 
            this.IzbornikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NoviUnosToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.IzbornikToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("IzbornikToolStripMenuItem.Image")));
            this.IzbornikToolStripMenuItem.Name = "IzbornikToolStripMenuItem";
            this.IzbornikToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.IzbornikToolStripMenuItem.Text = "Izbornik";
            // 
            // NoviUnosToolStripMenuItem
            // 
            this.NoviUnosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("NoviUnosToolStripMenuItem.Image")));
            this.NoviUnosToolStripMenuItem.Name = "NoviUnosToolStripMenuItem";
            this.NoviUnosToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.NoviUnosToolStripMenuItem.Text = "Novi unos";
            this.NoviUnosToolStripMenuItem.Click += new System.EventHandler(this.NoviUnosToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("izlazToolStripMenuItem.Image")));
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("HelpToolStripMenuItem.Image")));
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.HelpToolStripMenuItem.Text = "Pomoć";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // StartCityLabel
            // 
            this.StartCityLabel.AutoSize = true;
            this.StartCityLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartCityLabel.Font = new System.Drawing.Font("Montserrat Semi Bold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartCityLabel.ForeColor = System.Drawing.Color.Navy;
            this.StartCityLabel.Location = new System.Drawing.Point(10, 65);
            this.StartCityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartCityLabel.Name = "StartCityLabel";
            this.StartCityLabel.Size = new System.Drawing.Size(137, 23);
            this.StartCityLabel.TabIndex = 10;
            this.StartCityLabel.Text = "Početni grad:";
            // 
            // StartCityComboBox
            // 
            this.StartCityComboBox.Enabled = false;
            this.StartCityComboBox.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartCityComboBox.ForeColor = System.Drawing.Color.DarkCyan;
            this.StartCityComboBox.FormattingEnabled = true;
            this.StartCityComboBox.Location = new System.Drawing.Point(155, 61);
            this.StartCityComboBox.Name = "StartCityComboBox";
            this.StartCityComboBox.Size = new System.Drawing.Size(47, 27);
            this.StartCityComboBox.TabIndex = 11;
            this.StartCityComboBox.Text = "A";
            // 
            // TspMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.StartCityComboBox);
            this.Controls.Add(this.StartCityLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.CostMatrixLabel);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.StartBttn);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.CostLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "TspMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Problem Trgovačkog Putnika - [Matrica troška]";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CostMatrixLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Button StartBttn;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem IzbornikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NoviUnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.Label StartCityLabel;
        private System.Windows.Forms.ComboBox StartCityComboBox;
    }
}