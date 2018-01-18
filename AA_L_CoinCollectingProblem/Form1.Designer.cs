namespace AA_L_CoinCollectingProblem
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
            this.nupN = new System.Windows.Forms.NumericUpDown();
            this.nupM = new System.Windows.Forms.NumericUpDown();
            this.lblN = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblTile = new System.Windows.Forms.Label();
            this.nupSizeOfGridTile = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSizeOfGridTile)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nupN
            // 
            this.nupN.Location = new System.Drawing.Point(127, 10);
            this.nupN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupN.Name = "nupN";
            this.nupN.Size = new System.Drawing.Size(74, 22);
            this.nupN.TabIndex = 1;
            this.nupN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupM
            // 
            this.nupM.Location = new System.Drawing.Point(349, 10);
            this.nupM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupM.Name = "nupM";
            this.nupM.Size = new System.Drawing.Size(74, 22);
            this.nupM.TabIndex = 2;
            this.nupM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(5, 12);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(116, 17);
            this.lblN.TabIndex = 3;
            this.lblN.Text = "Number of Rows:";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(207, 12);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(136, 17);
            this.lblM.TabIndex = 4;
            this.lblM.Text = "Number of Columns:";
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Location = new System.Drawing.Point(12, 38);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(782, 497);
            this.pnlMain.TabIndex = 5;
            this.pnlMain.Click += new System.EventHandler(this.pnlMain_Click);
            // 
            // lblTile
            // 
            this.lblTile.AutoSize = true;
            this.lblTile.Location = new System.Drawing.Point(429, 12);
            this.lblTile.Name = "lblTile";
            this.lblTile.Size = new System.Drawing.Size(82, 17);
            this.lblTile.TabIndex = 7;
            this.lblTile.Text = "Size of Tile:";
            // 
            // nupSizeOfGridTile
            // 
            this.nupSizeOfGridTile.Location = new System.Drawing.Point(520, 10);
            this.nupSizeOfGridTile.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupSizeOfGridTile.Name = "nupSizeOfGridTile";
            this.nupSizeOfGridTile.Size = new System.Drawing.Size(74, 22);
            this.nupSizeOfGridTile.TabIndex = 6;
            this.nupSizeOfGridTile.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(698, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 30);
            this.button2.TabIndex = 8;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 547);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblTile);
            this.Controls.Add(this.nupSizeOfGridTile);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.nupM);
            this.Controls.Add(this.nupN);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Coin Collecting Problem";
            ((System.ComponentModel.ISupportInitialize)(this.nupN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSizeOfGridTile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nupN;
        private System.Windows.Forms.NumericUpDown nupM;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTile;
        private System.Windows.Forms.NumericUpDown nupSizeOfGridTile;
        private System.Windows.Forms.Button button2;
    }
}

