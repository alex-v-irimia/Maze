namespace Maze
{
    partial class Level1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.finish = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.paused = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(1, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(797, 16);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.wall_touch);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(1, 137);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(797, 16);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseEnter += new System.EventHandler(this.wall_touch);
            // 
            // finish
            // 
            this.finish.BackColor = System.Drawing.Color.ForestGreen;
            this.finish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.finish.Location = new System.Drawing.Point(720, 80);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(68, 40);
            this.finish.TabIndex = 2;
            this.finish.Text = "FINISH";
            this.finish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.finish.MouseEnter += new System.EventHandler(this.finish_MouseEnter);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.ForestGreen;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.start.Location = new System.Drawing.Point(12, 80);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(68, 40);
            this.start.TabIndex = 3;
            this.start.Text = "START";
            this.start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paused
            // 
            this.paused.BackColor = System.Drawing.Color.ForestGreen;
            this.paused.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.paused.Location = new System.Drawing.Point(711, -2);
            this.paused.Name = "paused";
            this.paused.Size = new System.Drawing.Size(87, 40);
            this.paused.TabIndex = 4;
            this.paused.Text = "PAUSED";
            this.paused.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paused);
            this.Controls.Add(this.start);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Level1";
            this.Text = "Level1";
            this.Load += new System.EventHandler(this.Level1_Load);
            this.LocationChanged += new System.EventHandler(this.Level1_LocationChanged);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Level1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label finish;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label paused;
    }
}