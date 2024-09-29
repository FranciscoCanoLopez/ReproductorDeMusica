namespace ReproductorDeMusica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnPrev = new Button();
            btnNext = new Button();
            btnPlay = new Button();
            lstvSongs = new ListView();
            lblSongName = new Label();
            pictureBox1 = new PictureBox();
            btnLoadSongs = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(340, 340);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(94, 29);
            btnPrev.TabIndex = 0;
            btnPrev.Text = "⏮︎";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(540, 340);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 1;
            btnNext.Text = "⏭︎";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(440, 340);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(94, 29);
            btnPlay.TabIndex = 2;
            btnPlay.Text = "▶";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += BtnPlay;
            // 
            // lstvSongs
            // 
            lstvSongs.BackColor = Color.DarkGray;
            lstvSongs.Location = new Point(12, 12);
            lstvSongs.Name = "lstvSongs";
            lstvSongs.Size = new Size(247, 357);
            lstvSongs.TabIndex = 3;
            lstvSongs.UseCompatibleStateImageBehavior = false;
            // 
            // lblSongName
            // 
            lblSongName.AutoSize = true;
            lblSongName.Font = new Font("Vladimir Script", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSongName.ForeColor = Color.White;
            lblSongName.Location = new Point(340, 290);
            lblSongName.Name = "lblSongName";
            lblSongName.Size = new Size(0, 36);
            lblSongName.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.ImageLocation = "\"C:\\Users\\volub\\Downloads\\descarga.jpeg\"";
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(371, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 230);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnLoadSongs
            // 
            btnLoadSongs.Location = new Point(84, 375);
            btnLoadSongs.Name = "btnLoadSongs";
            btnLoadSongs.Size = new Size(94, 29);
            btnLoadSongs.TabIndex = 6;
            btnLoadSongs.Text = "Load Songs";
            btnLoadSongs.UseVisualStyleBackColor = true;
            btnLoadSongs.Click += btnLoadSongs_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(700, 450);
            Controls.Add(btnLoadSongs);
            Controls.Add(pictureBox1);
            Controls.Add(lblSongName);
            Controls.Add(lstvSongs);
            Controls.Add(btnPlay);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Name = "Form1";
            Text = "MP3 player";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrev;
        private Button btnNext;
        private Button btnPlay;
        private ListView lstvSongs;
        private Label lblSongName;
        private PictureBox pictureBox1;
        private Button btnLoadSongs;
    }
}
