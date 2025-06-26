namespace EBAR_Desktop.DeleteMenu
{
    partial class HeartEmoji
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
            lblStatus = new Label();
            txtInput = new TextBox();
            btnBack = new Button();
            btnRemove = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.White;
            lblStatus.ForeColor = Color.LimeGreen;
            lblStatus.Location = new Point(276, 189);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 15;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(127, 38);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(229, 27);
            txtInput.TabIndex = 14;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 155);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(362, 38);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 12;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
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
            label1.TabIndex = 11;
            label1.Text = "Remove Anime :";
            // 
            // HeartEmoji
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(461, 206);
            Controls.Add(lblStatus);
            Controls.Add(txtInput);
            Controls.Add(btnBack);
            Controls.Add(btnRemove);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "HeartEmoji";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HeartEmoji";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private TextBox txtInput;
        private Button btnBack;
        private Button btnRemove;
        private Label label1;
    }
}