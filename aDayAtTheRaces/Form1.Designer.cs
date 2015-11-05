namespace aDayAtTheRaces
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.racetrackPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numDog = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numBets = new System.Windows.Forms.NumericUpDown();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRace = new System.Windows.Forms.Button();
            this.lblAl = new System.Windows.Forms.Label();
            this.lblBob = new System.Windows.Forms.Label();
            this.lblJoe = new System.Windows.Forms.Label();
            this.lblBets = new System.Windows.Forms.Label();
            this.radioAl = new System.Windows.Forms.RadioButton();
            this.radioBob = new System.Windows.Forms.RadioButton();
            this.radioJoe = new System.Windows.Forms.RadioButton();
            this.btnBets = new System.Windows.Forms.Button();
            this.radioGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBets)).BeginInit();
            this.SuspendLayout();
            // 
            // racetrackPictureBox
            // 
            this.racetrackPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("racetrackPictureBox.Image")));
            this.racetrackPictureBox.Location = new System.Drawing.Point(12, 12);
            this.racetrackPictureBox.Name = "racetrackPictureBox";
            this.racetrackPictureBox.Size = new System.Drawing.Size(600, 203);
            this.racetrackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrackPictureBox.TabIndex = 0;
            this.racetrackPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 23);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 23);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(23, 124);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 23);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(23, 175);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(77, 23);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioAl);
            this.groupBox1.Controls.Add(this.radioBob);
            this.groupBox1.Controls.Add(this.radioJoe);
            this.groupBox1.Controls.Add(this.btnBets);
            this.groupBox1.Controls.Add(this.numDog);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numBets);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.radioGroupBox);
            this.groupBox1.Controls.Add(this.btnRace);
            this.groupBox1.Controls.Add(this.lblAl);
            this.groupBox1.Controls.Add(this.lblBob);
            this.groupBox1.Controls.Add(this.lblJoe);
            this.groupBox1.Controls.Add(this.lblBets);
            this.groupBox1.Location = new System.Drawing.Point(12, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 182);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // numDog
            // 
            this.numDog.Location = new System.Drawing.Point(261, 147);
            this.numDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDog.Name = "numDog";
            this.numDog.Size = new System.Drawing.Size(55, 20);
            this.numDog.TabIndex = 13;
            this.numDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "bucks on dog number ";
            // 
            // numBets
            // 
            this.numBets.Location = new System.Drawing.Point(98, 147);
            this.numBets.Name = "numBets";
            this.numBets.Size = new System.Drawing.Size(38, 20);
            this.numBets.TabIndex = 11;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 151);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "name";
            // 
            // btnRace
            // 
            this.btnRace.Location = new System.Drawing.Point(387, 35);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(195, 120);
            this.btnRace.TabIndex = 8;
            this.btnRace.Text = "Race!";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // lblAl
            // 
            this.lblAl.AutoSize = true;
            this.lblAl.Location = new System.Drawing.Point(169, 89);
            this.lblAl.Name = "lblAl";
            this.lblAl.Size = new System.Drawing.Size(35, 13);
            this.lblAl.TabIndex = 7;
            this.lblAl.Text = "label3";
            // 
            // lblBob
            // 
            this.lblBob.AutoSize = true;
            this.lblBob.Location = new System.Drawing.Point(169, 63);
            this.lblBob.Name = "lblBob";
            this.lblBob.Size = new System.Drawing.Size(35, 13);
            this.lblBob.TabIndex = 6;
            this.lblBob.Text = "label2";
            // 
            // lblJoe
            // 
            this.lblJoe.AutoSize = true;
            this.lblJoe.Location = new System.Drawing.Point(169, 37);
            this.lblJoe.Name = "lblJoe";
            this.lblJoe.Size = new System.Drawing.Size(35, 13);
            this.lblJoe.TabIndex = 5;
            this.lblJoe.Text = "label1";
            // 
            // lblBets
            // 
            this.lblBets.AutoSize = true;
            this.lblBets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBets.Location = new System.Drawing.Point(161, 20);
            this.lblBets.Name = "lblBets";
            this.lblBets.Size = new System.Drawing.Size(36, 13);
            this.lblBets.TabIndex = 4;
            this.lblBets.Text = "Bets:";
            // 
            // radioAl
            // 
            this.radioAl.AutoSize = true;
            this.radioAl.Location = new System.Drawing.Point(20, 87);
            this.radioAl.Name = "radioAl";
            this.radioAl.Size = new System.Drawing.Size(34, 17);
            this.radioAl.TabIndex = 3;
            this.radioAl.Text = "Al";
            this.radioAl.UseVisualStyleBackColor = true;
            this.radioAl.CheckedChanged += new System.EventHandler(this.radioAl_CheckedChanged);
            // 
            // radioBob
            // 
            this.radioBob.AutoSize = true;
            this.radioBob.Location = new System.Drawing.Point(20, 61);
            this.radioBob.Name = "radioBob";
            this.radioBob.Size = new System.Drawing.Size(44, 17);
            this.radioBob.TabIndex = 2;
            this.radioBob.Text = "Bob";
            this.radioBob.UseVisualStyleBackColor = true;
            this.radioBob.CheckedChanged += new System.EventHandler(this.radioBob_CheckedChanged);
            // 
            // radioJoe
            // 
            this.radioJoe.AutoSize = true;
            this.radioJoe.Checked = true;
            this.radioJoe.Location = new System.Drawing.Point(20, 35);
            this.radioJoe.Name = "radioJoe";
            this.radioJoe.Size = new System.Drawing.Size(42, 17);
            this.radioJoe.TabIndex = 1;
            this.radioJoe.TabStop = true;
            this.radioJoe.Text = "Joe";
            this.radioJoe.UseVisualStyleBackColor = true;
            this.radioJoe.CheckedChanged += new System.EventHandler(this.radioJoe_CheckedChanged);
            // 
            // btnBets
            // 
            this.btnBets.Location = new System.Drawing.Point(51, 147);
            this.btnBets.Name = "btnBets";
            this.btnBets.Size = new System.Drawing.Size(37, 23);
            this.btnBets.TabIndex = 14;
            this.btnBets.Text = "Bets";
            this.btnBets.UseVisualStyleBackColor = true;
            this.btnBets.Click += new System.EventHandler(this.btnBets_Click);
            // 
            // radioGroupBox
            // 
            this.radioGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGroupBox.Location = new System.Drawing.Point(14, 20);
            this.radioGroupBox.Name = "radioGroupBox";
            this.radioGroupBox.Size = new System.Drawing.Size(125, 107);
            this.radioGroupBox.TabIndex = 15;
            this.radioGroupBox.TabStop = false;
            this.radioGroupBox.Text = "Minimum Bet:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(621, 410);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.racetrackPictureBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrackPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numDog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numBets;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Label lblAl;
        private System.Windows.Forms.Label lblBob;
        private System.Windows.Forms.Label lblJoe;
        public System.Windows.Forms.Label lblBets;
        private System.Windows.Forms.RadioButton radioAl;
        private System.Windows.Forms.RadioButton radioBob;
        private System.Windows.Forms.RadioButton radioJoe;
        private System.Windows.Forms.Button btnBets;
        private System.Windows.Forms.GroupBox radioGroupBox;
    }
}

