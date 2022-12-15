
namespace windowProject_final_
{
    partial class UserJoinForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.PwChBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PwBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnjoin = new System.Windows.Forms.Button();
            this.btnmain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(28, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(28, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "휴대폰번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(28, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "비밀번호";
            // 
            // NameBox
            // 
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Font = new System.Drawing.Font("나눔스퀘어", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NameBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NameBox.Location = new System.Drawing.Point(131, 104);
            this.NameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(166, 23);
            this.NameBox.TabIndex = 3;
            // 
            // IdBox
            // 
            this.IdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdBox.Font = new System.Drawing.Font("나눔스퀘어", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IdBox.Location = new System.Drawing.Point(131, 144);
            this.IdBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(166, 23);
            this.IdBox.TabIndex = 4;
            // 
            // PwChBox
            // 
            this.PwChBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PwChBox.Font = new System.Drawing.Font("나눔스퀘어", 10.2F);
            this.PwChBox.Location = new System.Drawing.Point(131, 222);
            this.PwChBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PwChBox.Name = "PwChBox";
            this.PwChBox.PasswordChar = '●';
            this.PwChBox.Size = new System.Drawing.Size(166, 23);
            this.PwChBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(28, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "비밀번호 확인";
            // 
            // PwBox
            // 
            this.PwBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PwBox.Font = new System.Drawing.Font("나눔스퀘어", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PwBox.Location = new System.Drawing.Point(131, 185);
            this.PwBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PwBox.Name = "PwBox";
            this.PwBox.PasswordChar = '●';
            this.PwBox.Size = new System.Drawing.Size(166, 23);
            this.PwBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "회원가입";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnjoin
            // 
            this.btnjoin.BackColor = System.Drawing.Color.PeachPuff;
            this.btnjoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjoin.Location = new System.Drawing.Point(62, 294);
            this.btnjoin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnjoin.Name = "btnjoin";
            this.btnjoin.Size = new System.Drawing.Size(98, 42);
            this.btnjoin.TabIndex = 11;
            this.btnjoin.Text = "회원가입";
            this.btnjoin.UseVisualStyleBackColor = false;
            this.btnjoin.Click += new System.EventHandler(this.LOGIN_button_Click);
            // 
            // btnmain
            // 
            this.btnmain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmain.Location = new System.Drawing.Point(185, 294);
            this.btnmain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnmain.Name = "btnmain";
            this.btnmain.Size = new System.Drawing.Size(98, 42);
            this.btnmain.TabIndex = 12;
            this.btnmain.Text = "처음으로";
            this.btnmain.UseVisualStyleBackColor = true;
            this.btnmain.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserJoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(335, 361);
            this.Controls.Add(this.btnjoin);
            this.Controls.Add(this.btnmain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PwBox);
            this.Controls.Add(this.PwChBox);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserJoinForm";
            this.Text = "회원가입";
            this.Load += new System.EventHandler(this.UserLoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.TextBox PwChBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PwBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnjoin;
        private System.Windows.Forms.Button btnmain;
    }
}