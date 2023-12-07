namespace DatabaaseBuisnessSchool
{
    partial class Form2
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
            this.UsernameLBL = new System.Windows.Forms.Label();
            this.IsikukoodLBL = new System.Windows.Forms.Label();
            this.PasswordLBL = new System.Windows.Forms.Label();
            this.Username_box = new System.Windows.Forms.TextBox();
            this.Isikukood_box = new System.Windows.Forms.TextBox();
            this.Password_box = new System.Windows.Forms.TextBox();
            this.enter_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameLBL
            // 
            this.UsernameLBL.AutoSize = true;
            this.UsernameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.UsernameLBL.Location = new System.Drawing.Point(201, 156);
            this.UsernameLBL.Name = "UsernameLBL";
            this.UsernameLBL.Size = new System.Drawing.Size(102, 24);
            this.UsernameLBL.TabIndex = 0;
            this.UsernameLBL.Text = "Username:";
            // 
            // IsikukoodLBL
            // 
            this.IsikukoodLBL.AutoSize = true;
            this.IsikukoodLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.IsikukoodLBL.Location = new System.Drawing.Point(209, 208);
            this.IsikukoodLBL.Name = "IsikukoodLBL";
            this.IsikukoodLBL.Size = new System.Drawing.Size(94, 24);
            this.IsikukoodLBL.TabIndex = 1;
            this.IsikukoodLBL.Text = "Isikukood:";
            // 
            // PasswordLBL
            // 
            this.PasswordLBL.AutoSize = true;
            this.PasswordLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.PasswordLBL.Location = new System.Drawing.Point(209, 255);
            this.PasswordLBL.Name = "PasswordLBL";
            this.PasswordLBL.Size = new System.Drawing.Size(97, 24);
            this.PasswordLBL.TabIndex = 2;
            this.PasswordLBL.Text = "Password:";
            // 
            // Username_box
            // 
            this.Username_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Username_box.Location = new System.Drawing.Point(309, 156);
            this.Username_box.Name = "Username_box";
            this.Username_box.Size = new System.Drawing.Size(232, 29);
            this.Username_box.TabIndex = 3;
            // 
            // Isikukood_box
            // 
            this.Isikukood_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Isikukood_box.Location = new System.Drawing.Point(311, 208);
            this.Isikukood_box.Name = "Isikukood_box";
            this.Isikukood_box.Size = new System.Drawing.Size(230, 29);
            this.Isikukood_box.TabIndex = 4;
            // 
            // Password_box
            // 
            this.Password_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Password_box.Location = new System.Drawing.Point(311, 255);
            this.Password_box.Name = "Password_box";
            this.Password_box.Size = new System.Drawing.Size(230, 29);
            this.Password_box.TabIndex = 5;
            // 
            // enter_btn
            // 
            this.enter_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.enter_btn.Location = new System.Drawing.Point(286, 335);
            this.enter_btn.Name = "enter_btn";
            this.enter_btn.Size = new System.Drawing.Size(183, 38);
            this.enter_btn.TabIndex = 6;
            this.enter_btn.Text = "enter";
            this.enter_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(279, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Create new account";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enter_btn);
            this.Controls.Add(this.Password_box);
            this.Controls.Add(this.Isikukood_box);
            this.Controls.Add(this.Username_box);
            this.Controls.Add(this.PasswordLBL);
            this.Controls.Add(this.IsikukoodLBL);
            this.Controls.Add(this.UsernameLBL);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLBL;
        private System.Windows.Forms.Label IsikukoodLBL;
        private System.Windows.Forms.Label PasswordLBL;
        private System.Windows.Forms.TextBox Username_box;
        private System.Windows.Forms.TextBox Isikukood_box;
        private System.Windows.Forms.TextBox Password_box;
        private System.Windows.Forms.Button enter_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}