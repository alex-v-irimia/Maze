namespace Maze
{
    partial class Maze
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maze));
            this.main_menu = new System.Windows.Forms.Panel();
            this.play_button = new System.Windows.Forms.Button();
            this.welcome_label = new System.Windows.Forms.Label();
            this.level_select = new System.Windows.Forms.Panel();
            this.level3_button = new System.Windows.Forms.Button();
            this.level2_button = new System.Windows.Forms.Button();
            this.level1_button = new System.Windows.Forms.Button();
            this.main_menu.SuspendLayout();
            this.level_select.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menu
            // 
            this.main_menu.Controls.Add(this.play_button);
            this.main_menu.Controls.Add(this.welcome_label);
            this.main_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_menu.Location = new System.Drawing.Point(0, 0);
            this.main_menu.Name = "main_menu";
            this.main_menu.Size = new System.Drawing.Size(800, 337);
            this.main_menu.TabIndex = 0;
            // 
            // play_button
            // 
            this.play_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.play_button.Location = new System.Drawing.Point(313, 194);
            this.play_button.Name = "play_button";
            this.play_button.Size = new System.Drawing.Size(140, 53);
            this.play_button.TabIndex = 1;
            this.play_button.Text = "PLAY";
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // welcome_label
            // 
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.welcome_label.Location = new System.Drawing.Point(233, 61);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(294, 106);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "Welcome to the\r\n MAZE";
            this.welcome_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // level_select
            // 
            this.level_select.Controls.Add(this.level3_button);
            this.level_select.Controls.Add(this.level2_button);
            this.level_select.Controls.Add(this.level1_button);
            this.level_select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.level_select.Location = new System.Drawing.Point(0, 0);
            this.level_select.Name = "level_select";
            this.level_select.Size = new System.Drawing.Size(800, 337);
            this.level_select.TabIndex = 2;
            // 
            // level3_button
            // 
            this.level3_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.level3_button.Location = new System.Drawing.Point(259, 12);
            this.level3_button.Name = "level3_button";
            this.level3_button.Size = new System.Drawing.Size(93, 38);
            this.level3_button.TabIndex = 2;
            this.level3_button.Text = "LEVEL 3";
            this.level3_button.UseVisualStyleBackColor = true;
            this.level3_button.Click += new System.EventHandler(this.select_level);
            // 
            // level2_button
            // 
            this.level2_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.level2_button.Location = new System.Drawing.Point(135, 12);
            this.level2_button.Name = "level2_button";
            this.level2_button.Size = new System.Drawing.Size(93, 38);
            this.level2_button.TabIndex = 1;
            this.level2_button.Text = "LEVEL 2";
            this.level2_button.UseVisualStyleBackColor = true;
            this.level2_button.Click += new System.EventHandler(this.select_level);
            // 
            // level1_button
            // 
            this.level1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.level1_button.Location = new System.Drawing.Point(12, 12);
            this.level1_button.Name = "level1_button";
            this.level1_button.Size = new System.Drawing.Size(93, 38);
            this.level1_button.TabIndex = 0;
            this.level1_button.Text = "LEVEL 1";
            this.level1_button.UseVisualStyleBackColor = true;
            this.level1_button.Click += new System.EventHandler(this.select_level);
            // 
            // Maze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.level_select);
            this.Controls.Add(this.main_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Maze";
            this.Text = "Maze";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Maze_KeyPress);
            this.main_menu.ResumeLayout(false);
            this.level_select.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_menu;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Panel level_select;
        private System.Windows.Forms.Button level1_button;
        private System.Windows.Forms.Button level2_button;
        private System.Windows.Forms.Button level3_button;
    }
}

