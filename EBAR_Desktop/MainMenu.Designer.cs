namespace EBAR_Desktop
{
    partial class MainMenu
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
            label1 = new Label();
            btnAdmin = new Button();
            btnUser = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(194, 26);
            label1.Name = "label1";
            label1.Size = new Size(449, 54);
            label1.TabIndex = 0;
            label1.Text = "Identity Confirmation";
            // 
            // btnAdmin
            // 
            btnAdmin.Font = new Font("Franklin Gothic Medium", 9F);
            btnAdmin.Location = new Point(356, 118);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(94, 29);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnUser
            // 
            btnUser.Font = new Font("Franklin Gothic Medium", 9F);
            btnUser.Location = new Point(356, 190);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(94, 29);
            btnUser.TabIndex = 2;
            btnUser.Text = "User";
            btnUser.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Cursor = Cursors.Hand;
            btnExit.Font = new Font("Franklin Gothic Medium", 9F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(356, 390);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnUser);
            Controls.Add(btnAdmin);
            Controls.Add(label1);
            Name = "MainMenu";
            Text = "Main Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAdmin;
        private Button btnUser;
        private Button btnExit;
    }
}
