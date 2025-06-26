namespace EBAR_Desktop.ViewMenu
{
    partial class ViewAnimeMenu
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
            label1 = new Label();
            btnLikeEmoji = new Button();
            btnSadEmoji = new Button();
            btnWowEmoji = new Button();
            btnLaughEmoji = new Button();
            btnHeartEmoji = new Button();
            btnAngryEmoji = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 0;
            label1.Text = "Select Emoji ";
            // 
            // btnLikeEmoji
            // 
            btnLikeEmoji.BackColor = Color.Transparent;
            btnLikeEmoji.BackgroundImage = Properties.Resources.like_emoji;
            btnLikeEmoji.BackgroundImageLayout = ImageLayout.Zoom;
            btnLikeEmoji.FlatAppearance.BorderSize = 0;
            btnLikeEmoji.FlatStyle = FlatStyle.Flat;
            btnLikeEmoji.Location = new Point(73, 87);
            btnLikeEmoji.Name = "btnLikeEmoji";
            btnLikeEmoji.Size = new Size(123, 115);
            btnLikeEmoji.TabIndex = 1;
            btnLikeEmoji.UseVisualStyleBackColor = false;
            btnLikeEmoji.Click += btnLikeEmoji_Click;
            // 
            // btnSadEmoji
            // 
            btnSadEmoji.BackColor = Color.Transparent;
            btnSadEmoji.BackgroundImage = Properties.Resources.cry_emoji;
            btnSadEmoji.BackgroundImageLayout = ImageLayout.Zoom;
            btnSadEmoji.FlatAppearance.BorderSize = 0;
            btnSadEmoji.FlatStyle = FlatStyle.Flat;
            btnSadEmoji.Location = new Point(319, 262);
            btnSadEmoji.Name = "btnSadEmoji";
            btnSadEmoji.Size = new Size(124, 110);
            btnSadEmoji.TabIndex = 2;
            btnSadEmoji.UseVisualStyleBackColor = false;
            btnSadEmoji.Click += btnSadEmoji_Click;
            // 
            // btnWowEmoji
            // 
            btnWowEmoji.BackColor = Color.Transparent;
            btnWowEmoji.BackgroundImage = Properties.Resources.wow_emoji;
            btnWowEmoji.BackgroundImageLayout = ImageLayout.Zoom;
            btnWowEmoji.FlatAppearance.BorderSize = 0;
            btnWowEmoji.FlatStyle = FlatStyle.Flat;
            btnWowEmoji.Location = new Point(73, 264);
            btnWowEmoji.Name = "btnWowEmoji";
            btnWowEmoji.Size = new Size(123, 107);
            btnWowEmoji.TabIndex = 3;
            btnWowEmoji.UseVisualStyleBackColor = false;
            btnWowEmoji.Click += btnWowEmoji_Click;
            // 
            // btnLaughEmoji
            // 
            btnLaughEmoji.BackColor = Color.Transparent;
            btnLaughEmoji.BackgroundImage = Properties.Resources.laugh_emoji;
            btnLaughEmoji.BackgroundImageLayout = ImageLayout.Zoom;
            btnLaughEmoji.FlatAppearance.BorderSize = 0;
            btnLaughEmoji.FlatStyle = FlatStyle.Flat;
            btnLaughEmoji.Location = new Point(548, 86);
            btnLaughEmoji.Name = "btnLaughEmoji";
            btnLaughEmoji.Size = new Size(119, 116);
            btnLaughEmoji.TabIndex = 4;
            btnLaughEmoji.UseVisualStyleBackColor = false;
            btnLaughEmoji.Click += btnLaughEmoji_Click;
            // 
            // btnHeartEmoji
            // 
            btnHeartEmoji.BackColor = Color.Transparent;
            btnHeartEmoji.BackgroundImage = Properties.Resources.heart_emoji;
            btnHeartEmoji.BackgroundImageLayout = ImageLayout.Zoom;
            btnHeartEmoji.FlatAppearance.BorderSize = 0;
            btnHeartEmoji.FlatStyle = FlatStyle.Flat;
            btnHeartEmoji.Location = new Point(324, 86);
            btnHeartEmoji.Name = "btnHeartEmoji";
            btnHeartEmoji.Size = new Size(119, 116);
            btnHeartEmoji.TabIndex = 5;
            btnHeartEmoji.UseVisualStyleBackColor = false;
            btnHeartEmoji.Click += btnHeartEmoji_Click;
            // 
            // btnAngryEmoji
            // 
            btnAngryEmoji.BackColor = Color.Transparent;
            btnAngryEmoji.BackgroundImage = Properties.Resources.angry_emoji;
            btnAngryEmoji.BackgroundImageLayout = ImageLayout.Zoom;
            btnAngryEmoji.FlatAppearance.BorderSize = 0;
            btnAngryEmoji.FlatStyle = FlatStyle.Flat;
            btnAngryEmoji.Location = new Point(548, 269);
            btnAngryEmoji.Name = "btnAngryEmoji";
            btnAngryEmoji.Size = new Size(115, 103);
            btnAngryEmoji.TabIndex = 6;
            btnAngryEmoji.UseVisualStyleBackColor = false;
            btnAngryEmoji.Click += btnAngryEmoji_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(22, 397);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ViewAnimeMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnAngryEmoji);
            Controls.Add(btnHeartEmoji);
            Controls.Add(btnLaughEmoji);
            Controls.Add(btnWowEmoji);
            Controls.Add(btnSadEmoji);
            Controls.Add(btnLikeEmoji);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "ViewAnimeMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View Anime Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLikeEmoji;
        private Button btnSadEmoji;
        private Button btnWowEmoji;
        private Button btnLaughEmoji;
        private Button btnHeartEmoji;
        private Button btnAngryEmoji;
        private Button btnBack;
    }
}