namespace HelloWorld
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selectBtn = new System.Windows.Forms.Button();
            this.btnRand = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNxt = new System.Windows.Forms.Button();
            this.checkSlide = new System.Windows.Forms.CheckBox();
            this.checkSlideRand = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(312, 262);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(90, 25);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open File 📂";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(512, 256);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(512, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(209, 262);
            this.selectBtn.Margin = new System.Windows.Forms.Padding(0);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(90, 25);
            this.selectBtn.TabIndex = 3;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // btnRand
            // 
            this.btnRand.Location = new System.Drawing.Point(106, 262);
            this.btnRand.Margin = new System.Windows.Forms.Padding(0);
            this.btnRand.Name = "btnRand";
            this.btnRand.Size = new System.Drawing.Size(90, 25);
            this.btnRand.TabIndex = 4;
            this.btnRand.Text = "Random 🎲";
            this.btnRand.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(2, 262);
            this.btnBack.Margin = new System.Windows.Forms.Padding(0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 25);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "<- Previous";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnNxt
            // 
            this.btnNxt.Location = new System.Drawing.Point(414, 262);
            this.btnNxt.Margin = new System.Windows.Forms.Padding(0);
            this.btnNxt.Name = "btnNxt";
            this.btnNxt.Size = new System.Drawing.Size(90, 25);
            this.btnNxt.TabIndex = 6;
            this.btnNxt.Text = "Next ->";
            this.btnNxt.UseVisualStyleBackColor = true;
            // 
            // checkSlide
            // 
            this.checkSlide.AutoSize = true;
            this.checkSlide.Location = new System.Drawing.Point(12, 293);
            this.checkSlide.Margin = new System.Windows.Forms.Padding(0);
            this.checkSlide.Name = "checkSlide";
            this.checkSlide.Size = new System.Drawing.Size(110, 17);
            this.checkSlide.TabIndex = 8;
            this.checkSlide.Text = "Enable Slideshow";
            this.checkSlide.UseVisualStyleBackColor = true;
            this.checkSlide.CheckedChanged += new System.EventHandler(this.enableSlideshow);
            // 
            // checkSlideRand
            // 
            this.checkSlideRand.AutoSize = true;
            this.checkSlideRand.Location = new System.Drawing.Point(120, 294);
            this.checkSlideRand.Margin = new System.Windows.Forms.Padding(0);
            this.checkSlideRand.Name = "checkSlideRand";
            this.checkSlideRand.Size = new System.Drawing.Size(153, 17);
            this.checkSlideRand.TabIndex = 9;
            this.checkSlideRand.Text = "Enable Random Slideshow";
            this.checkSlideRand.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(276, 291);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.slideshow);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(343, 294);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(163, 13);
            this.labelInfo.TabIndex = 12;
            this.labelInfo.Text = "Delay between slides (in minutes)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 315);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkSlideRand);
            this.Controls.Add(this.checkSlide);
            this.Controls.Add(this.btnNxt);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRand);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Neuro\'s Wallpapers";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Button btnRand;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNxt;
        private System.Windows.Forms.CheckBox checkSlide;
        private System.Windows.Forms.CheckBox checkSlideRand;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelInfo;
    }
}

