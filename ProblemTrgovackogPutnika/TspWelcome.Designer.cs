namespace ProblemTrgovackogPutnika
{
    partial class TspWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TspWelcome));
            this.NoCityButton = new System.Windows.Forms.Button();
            this.NoCityButtonTxtBox = new System.Windows.Forms.TextBox();
            this.NoCityLabel = new System.Windows.Forms.Label();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.SubheadingLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InputGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.IzbornikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviUnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.InputGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoCityButton
            // 
            this.NoCityButton.Image = ((System.Drawing.Image)(resources.GetObject("NoCityButton.Image")));
            this.NoCityButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NoCityButton.Location = new System.Drawing.Point(237, 15);
            this.NoCityButton.Margin = new System.Windows.Forms.Padding(4);
            this.NoCityButton.Name = "NoCityButton";
            this.NoCityButton.Size = new System.Drawing.Size(91, 39);
            this.NoCityButton.TabIndex = 0;
            this.NoCityButton.Text = "Unesi";
            this.NoCityButton.UseVisualStyleBackColor = true;
            this.NoCityButton.Click += new System.EventHandler(this.NoCityButton_Click);
            // 
            // NoCityButtonTxtBox
            // 
            this.NoCityButtonTxtBox.Location = new System.Drawing.Point(140, 23);
            this.NoCityButtonTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.NoCityButtonTxtBox.Name = "NoCityButtonTxtBox";
            this.NoCityButtonTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.NoCityButtonTxtBox.Size = new System.Drawing.Size(86, 23);
            this.NoCityButtonTxtBox.TabIndex = 1;
            // 
            // NoCityLabel
            // 
            this.NoCityLabel.AutoSize = true;
            this.NoCityLabel.BackColor = System.Drawing.Color.Transparent;
            this.NoCityLabel.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoCityLabel.Location = new System.Drawing.Point(3, 21);
            this.NoCityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NoCityLabel.Name = "NoCityLabel";
            this.NoCityLabel.Size = new System.Drawing.Size(132, 23);
            this.NoCityLabel.TabIndex = 2;
            this.NoCityLabel.Text = "Broj gradova:";
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.AutoSize = true;
            this.HeadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeadingLabel.Font = new System.Drawing.Font("Montserrat Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadingLabel.ForeColor = System.Drawing.Color.Maroon;
            this.HeadingLabel.Location = new System.Drawing.Point(73, 35);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(367, 38);
            this.HeadingLabel.TabIndex = 3;
            this.HeadingLabel.Text = "Metode Optimizacije";
            // 
            // SubheadingLabel
            // 
            this.SubheadingLabel.AutoSize = true;
            this.SubheadingLabel.BackColor = System.Drawing.Color.Transparent;
            this.SubheadingLabel.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubheadingLabel.ForeColor = System.Drawing.Color.Navy;
            this.SubheadingLabel.Location = new System.Drawing.Point(54, 85);
            this.SubheadingLabel.Name = "SubheadingLabel";
            this.SubheadingLabel.Size = new System.Drawing.Size(405, 32);
            this.SubheadingLabel.TabIndex = 4;
            this.SubheadingLabel.Text = "Problem trgovačkog putnika";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(206, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // InputGroupBox
            // 
            this.InputGroupBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InputGroupBox.BackgroundImage")));
            this.InputGroupBox.Controls.Add(this.NoCityButtonTxtBox);
            this.InputGroupBox.Controls.Add(this.NoCityButton);
            this.InputGroupBox.Controls.Add(this.NoCityLabel);
            this.InputGroupBox.Location = new System.Drawing.Point(89, 246);
            this.InputGroupBox.Name = "InputGroupBox";
            this.InputGroupBox.Size = new System.Drawing.Size(335, 62);
            this.InputGroupBox.TabIndex = 6;
            this.InputGroupBox.TabStop = false;
            this.InputGroupBox.Text = "Unos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IzbornikToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // IzbornikToolStripMenuItem
            // 
            this.IzbornikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noviUnosToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.IzbornikToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("IzbornikToolStripMenuItem.Image")));
            this.IzbornikToolStripMenuItem.Name = "IzbornikToolStripMenuItem";
            this.IzbornikToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.IzbornikToolStripMenuItem.Text = "Izbornik";
            // 
            // noviUnosToolStripMenuItem
            // 
            this.noviUnosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("noviUnosToolStripMenuItem.Image")));
            this.noviUnosToolStripMenuItem.Name = "noviUnosToolStripMenuItem";
            this.noviUnosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.noviUnosToolStripMenuItem.Text = "Novi unos";
            this.noviUnosToolStripMenuItem.Click += new System.EventHandler(this.noviUnosToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("izlazToolStripMenuItem.Image")));
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            // TspWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(530, 357);
            this.Controls.Add(this.InputGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SubheadingLabel);
            this.Controls.Add(this.HeadingLabel);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TspWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Problem Trgovačkog Putnika - [Početna]";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.InputGroupBox.ResumeLayout(false);
            this.InputGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NoCityButton;
        private System.Windows.Forms.TextBox NoCityButtonTxtBox;
        private System.Windows.Forms.Label NoCityLabel;
        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Label SubheadingLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox InputGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem IzbornikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviUnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
    }
}

