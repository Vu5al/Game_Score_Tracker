namespace Game_Score_Tracker
{
    partial class Form3
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            button_login = new Button();
            button_clear = new Button();
            button_exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(142, 21);
            label1.Name = "label1";
            label1.Size = new Size(124, 29);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(142, 63);
            label2.Name = "label2";
            label2.Size = new Size(128, 18);
            label2.TabIndex = 1;
            label2.Text = "Login to play !";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(31, 110);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Player name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 163);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(142, 111);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(152, 23);
            txt_username.TabIndex = 4;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(142, 160);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(152, 23);
            txt_password.TabIndex = 5;
            // 
            // button_login
            // 
            button_login.Location = new Point(241, 198);
            button_login.Name = "button_login";
            button_login.Size = new Size(53, 27);
            button_login.TabIndex = 6;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(142, 198);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(53, 27);
            button_clear.TabIndex = 7;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = true;
            // 
            // button_exit
            // 
            button_exit.Location = new Point(31, 256);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(70, 29);
            button_exit.TabIndex = 8;
            button_exit.Text = "Exit";
            button_exit.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 311);
            Controls.Add(button_exit);
            Controls.Add(button_clear);
            Controls.Add(button_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "s";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button button_login;
        private Button button_clear;
        private Button button_exit;
    }
}