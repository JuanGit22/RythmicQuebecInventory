namespace RythmicQuebecInventory
{
    partial class admLogin
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
            this.labelLoginpage = new System.Windows.Forms.Label();
            this.admAccessClick = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.passWord = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLoginpage
            // 
            this.labelLoginpage.AutoSize = true;
            this.labelLoginpage.BackColor = System.Drawing.Color.Black;
            this.labelLoginpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginpage.ForeColor = System.Drawing.Color.Silver;
            this.labelLoginpage.Location = new System.Drawing.Point(127, 73);
            this.labelLoginpage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoginpage.Name = "labelLoginpage";
            this.labelLoginpage.Size = new System.Drawing.Size(109, 18);
            this.labelLoginpage.TabIndex = 0;
            this.labelLoginpage.Text = "LOGIN PAGE";
            // 
            // admAccessClick
            // 
            this.admAccessClick.AutoSize = true;
            this.admAccessClick.BackColor = System.Drawing.Color.Black;
            this.admAccessClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admAccessClick.ForeColor = System.Drawing.Color.Silver;
            this.admAccessClick.Location = new System.Drawing.Point(468, 73);
            this.admAccessClick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.admAccessClick.Name = "admAccessClick";
            this.admAccessClick.Size = new System.Drawing.Size(143, 20);
            this.admAccessClick.TabIndex = 1;
            this.admAccessClick.Text = "ADMIN ACCESS";
            this.admAccessClick.Click += new System.EventHandler(this.admAccessClick_Click);
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.Color.White;
            this.userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.Gray;
            this.userName.Location = new System.Drawing.Point(127, 122);
            this.userName.Margin = new System.Windows.Forms.Padding(2);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(142, 21);
            this.userName.TabIndex = 2;
            this.userName.Text = "Username";
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // passWord
            // 
            this.passWord.BackColor = System.Drawing.Color.White;
            this.passWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWord.ForeColor = System.Drawing.Color.Gray;
            this.passWord.Location = new System.Drawing.Point(127, 150);
            this.passWord.Margin = new System.Windows.Forms.Padding(2);
            this.passWord.Name = "passWord";
            this.passWord.Size = new System.Drawing.Size(142, 21);
            this.passWord.TabIndex = 0;
            this.passWord.Text = "Password";
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Gray;
            this.Back.Location = new System.Drawing.Point(158, 269);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(78, 28);
            this.Back.TabIndex = 3;
            this.Back.Text = "BACK";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // admLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(824, 473);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.passWord);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.admAccessClick);
            this.Controls.Add(this.labelLoginpage);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "admLogin";
            this.Text = "admLogin";
            this.Load += new System.EventHandler(this.admLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoginpage;
        private System.Windows.Forms.Label admAccessClick;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.Button Back;
    }
}