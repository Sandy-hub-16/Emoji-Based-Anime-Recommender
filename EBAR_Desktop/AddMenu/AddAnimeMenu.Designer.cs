namespace EBAR_Desktop.AddMenu
{
    partial class AddAnimeMenu
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
            lblSelectEmoji = new Label();
            btnLikeEmoji = new Button();
            btnHeartEmoji = new Button();
            btnLaughEmoji = new Button();
            btnWowEmoji = new Button();
            btnSadEmoji = new Button();
            btnAngryEmoji = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblSelectEmoji
            // 
            lblSelectEmoji.AutoSize = true;
            lblSelectEmoji.BackColor = Color.Transparent;
            lblSelectEmoji.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectEmoji.ForeColor = Color.White;
            lblSelectEmoji.Location = new Point(12, 23);
            lblSelectEmoji.Name = "lblSelectEmoji";
            lblSelectEmoji.Size = new Size(118, 28);
            lblSelectEmoji.TabIndex = 0;
            lblSelectEmoji.Text = "Select Emoji";
            // 
            // btnLikeEmoji
            // 
            btnLikeEmoji.BackColor = Color.Transparent;
            btnLikeEmoji.BackgroundImage = Properties.Resources.like_emoji;
            btnLikeEmoji.BackgroundImageLayout = ImageLayout.Zoom;
            btnLikeEmoji.Cursor = Cursors.Hand;
            btnLikeEmoji.FlatAppearance.BorderSize = 0;
            btnLikeEmoji.FlatStyle = FlatStyle.Flat;
            btnLikeEmoji.Location = new Point(68, 84);
            btnLikeEmoji.Name = "btnLikeEmoji";
            btnLikeEmoji.Size = new Size(117, 112);
            btnLikeEmoji.TabIndex = 1;
            btnLikeEmoji.UseVisualStyleBackColor = false;
            btnLikeEmoji.Click += btnLikeEmoji_Click;
            // 
            // btnHeartEmoji
            // 
            btnHeartEmoji.BackColor = Color.Transparent;
            btnHeartEmoji.BackgroundImage = Properties.Resources.heart_emoji;
            btnHeartEmoji.BackgroundImageLayout = ImageLayout.Zoom;
            btnHeartEmoji.Cursor = Cursors.Hand;
            btnHeartEmoji.FlatAppearance.BorderSize = 0;
            btnHeartEmoji.FlatStyle = FlatStyle.Flat;
            btnHeartEmoji.Location = new Point(309, 84);
            btnHeartEmoji.Name = "btnHeartEmoji";
            btnHeartEmoji.Size = new Size(136, 123);
            btnHeartEmoji.TabIndex = 2;
            btnHeartEmoji.UseVisualStyleBackColor = false;
            btnHeartEmoji.Click += btnHeartEmoji_Click;
            // 
            // btnLaughEmoji
            // 
            btnLaughEmoji.BackColor = Color.Transparent;
            btnLaughEmoji.BackgroundImage = Properties.Resources.laugh_emoji;
            btnLaughEmoji.BackgroundImageLayout = ImageLayout.Zoom;
            btnLaughEmoji.Cursor = Cursors.Hand;
            btnLaughEmoji.FlatAppearance.BorderSize = 0;
            btnLaughEmoji.FlatStyle = FlatStyle.Flat;
            btnLaughEmoji.Location = new Point(578, 95);
            btnLaughEmoji.Name = "btnLaughEmoji";
            btnLaughEmoji.Size = new Size(107, 112);
            btnLaughEmoji.TabIndex = 3;
            btnLaughEmoji.UseVisualStyleBackColor = false;
            btnLaughEmoji.Click += btnLaughEmoji_Click;
            // 
            // btnWowEmoji
            // 
            btnWowEmoji.BackColor = Color.Transparent;
            btnWowEmoji.BackgroundImage = Properties.Resources.wow_emoji;
            btnWowEmoji.BackgroundImageLayout = ImageLayout.Zoom;
            btnWowEmoji.Cursor = Cursors.Hand;
            btnWowEmoji.FlatAppearance.BorderSize = 0;
            btnWowEmoji.FlatStyle = FlatStyle.Flat;
            btnWowEmoji.Location = new Point(68, 257);
            btnWowEmoji.Name = "btnWowEmoji";
            btnWowEmoji.Size = new Size(126, 116);
            btnWowEmoji.TabIndex = 4;
            btnWowEmoji.UseVisualStyleBackColor = false;
            btnWowEmoji.Click += btnWowEmoji_Click;
            // 
            // btnSadEmoji
            // 
            btnSadEmoji.BackColor = Color.Transparent;
            btnSadEmoji.BackgroundImage = Properties.Resources.cry_emoji;
            btnSadEmoji.BackgroundImageLayout = ImageLayout.Zoom;
            btnSadEmoji.Cursor = Cursors.Hand;
            btnSadEmoji.FlatAppearance.BorderSize = 0;
            btnSadEmoji.FlatStyle = FlatStyle.Flat;
            btnSadEmoji.Location = new Point(320, 257);
            btnSadEmoji.Name = "btnSadEmoji";
            btnSadEmoji.Size = new Size(125, 116);
            btnSadEmoji.TabIndex = 5;
            btnSadEmoji.UseVisualStyleBackColor = false;
            btnSadEmoji.Click += btnSadEmoji_Click;
            // 
            // btnAngryEmoji
            // 
            btnAngryEmoji.BackColor = Color.Transparent;
            btnAngryEmoji.BackgroundImage = Properties.Resources.angry_emoji;
            btnAngryEmoji.BackgroundImageLayout = ImageLayout.Zoom;
            btnAngryEmoji.Cursor = Cursors.Hand;
            btnAngryEmoji.FlatAppearance.BorderSize = 0;
            btnAngryEmoji.FlatStyle = FlatStyle.Flat;
            btnAngryEmoji.Location = new Point(578, 257);
            btnAngryEmoji.Name = "btnAngryEmoji";
            btnAngryEmoji.Size = new Size(107, 116);
            btnAngryEmoji.TabIndex = 6;
            btnAngryEmoji.UseVisualStyleBackColor = false;
            btnAngryEmoji.Click += btnAngryEmoji_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 400);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AddAnimeMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnAngryEmoji);
            Controls.Add(btnSadEmoji);
            Controls.Add(btnWowEmoji);
            Controls.Add(btnLaughEmoji);
            Controls.Add(btnHeartEmoji);
            Controls.Add(btnLikeEmoji);
            Controls.Add(lblSelectEmoji);
            DoubleBuffered = true;
            Name = "AddAnimeMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelectEmoji;
        private Button btnLikeEmoji;
        private Button btnHeartEmoji;
        private Button btnLaughEmoji;
        private Button btnWowEmoji;
        private Button btnSadEmoji;
        private Button btnAngryEmoji;
        private Button btnBack;
    }
}