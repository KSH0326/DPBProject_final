
namespace windowProject_final_
{
    partial class UserLoginForm
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
            this.PwBox = new System.Windows.Forms.TextBox();
            this.PhoneNumBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PwBox
            // 
            this.PwBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PwBox.Font = new System.Drawing.Font("나눔스퀘어", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PwBox.Location = new System.Drawing.Point(185, 177);
            this.PwBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PwBox.Name = "PwBox";
            this.PwBox.PasswordChar = '●';
            this.PwBox.Size = new System.Drawing.Size(166, 23);
            this.PwBox.TabIndex = 23;
            // 
            // PhoneNumBox
            // 
            this.PhoneNumBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneNumBox.Font = new System.Drawing.Font("나눔스퀘어", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PhoneNumBox.Location = new System.Drawing.Point(185, 136);
            this.PhoneNumBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneNumBox.Name = "PhoneNumBox";
            this.PhoneNumBox.Size = new System.Drawing.Size(166, 23);
            this.PhoneNumBox.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(82, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "비밀번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(82, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "휴대폰번호";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.loginBtn.Location = new System.Drawing.Point(105, 267);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(98, 42);
            this.loginBtn.TabIndex = 18;
            this.loginBtn.Text = "로그인";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(228, 267);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 42);
            this.button1.TabIndex = 19;
            this.button1.Text = "처음으로";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("한수원 한돋움 Bold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(171, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "로그인";
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 359);
            this.Controls.Add(this.PwBox);
            this.Controls.Add(this.PhoneNumBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserLoginForm";
            this.Text = "UserLoginForm";
            this.Load += new System.EventHandler(this.UserLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PwBox;
        private System.Windows.Forms.TextBox PhoneNumBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}