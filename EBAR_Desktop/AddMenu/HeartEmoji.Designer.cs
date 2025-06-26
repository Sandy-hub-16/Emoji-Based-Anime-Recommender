namespace EBAR_Desktop.AddMenu
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
            btnBack = new Button();
            label1 = new Label();
            txtInput = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 155);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 38);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 5;
            label1.Text = "Add Anime :";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(102, 38);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(229, 27);
            txtInput.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(337, 38);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // HeartEmoji
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(445, 206);
            Controls.Add(btnAdd);
            Controls.Add(txtInput);
            Controls.Add(label1);
            Controls.Add(btnBack);
            DoubleBuffered = true;
            Name = "HeartEmoji";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HeartEmoji";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label label1;
        private TextBox txtInput;
        private Button btnAdd;
    }
}