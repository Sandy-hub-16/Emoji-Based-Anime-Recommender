namespace EBAR_Desktop.DeleteMenu
{
    partial class AngryEmoji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AngryEmoji));
            txtInput = new TextBox();
            btnBack = new Button();
            btnRemove = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(127, 38);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(229, 27);
            txtInput.TabIndex = 30;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.White;
            btnBack.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(0, 86, 179);
            btnBack.Location = new Point(12, 155);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 29;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(0, 86, 179);
            btnBack.FlatAppearance.BorderSize = 2;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(362, 38);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 28;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 38);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 27;
            label1.Text = "Remove Anime :";
            // 
            // AngryEmoji
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(461, 206);
            Controls.Add(txtInput);
            Controls.Add(btnBack);
            Controls.Add(btnRemove);
            Controls.Add(label1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AngryEmoji";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AngryEmoji";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnBack;
        private Button btnRemove;
        private Label label1;
    }
}