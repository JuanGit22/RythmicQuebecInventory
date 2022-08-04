namespace RythmicQuebecInventory
{
    partial class createQRCode
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboSelectBoxes = new System.Windows.Forms.ComboBox();
            this.labelLogOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
<<<<<<< HEAD
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(725, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOG OUT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
=======
>>>>>>> 915d7267ecd26a6e9a9f1098e4d53a714f33dcbd
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(127, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "CREATE QR CODES";
            // 
            // cboSelectBoxes
            // 
            this.cboSelectBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelectBoxes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboSelectBoxes.FormattingEnabled = true;
            this.cboSelectBoxes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboSelectBoxes.Items.AddRange(new object[] {
            "Box1",
            "Box2",
            "Box3",
            "Box4",
            "Box5",
            "Box6"});
            this.cboSelectBoxes.Location = new System.Drawing.Point(127, 122);
            this.cboSelectBoxes.Margin = new System.Windows.Forms.Padding(2);
            this.cboSelectBoxes.Name = "cboSelectBoxes";
            this.cboSelectBoxes.Size = new System.Drawing.Size(197, 30);
            this.cboSelectBoxes.TabIndex = 2;
            this.cboSelectBoxes.Text = "Select Box";
            // 
<<<<<<< HEAD
            // createQRCode
=======
            // labelLogOut
            // 
            this.labelLogOut.AutoSize = true;
            this.labelLogOut.BackColor = System.Drawing.Color.Black;
            this.labelLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogOut.ForeColor = System.Drawing.Color.Silver;
            this.labelLogOut.Location = new System.Drawing.Point(1010, 30);
            this.labelLogOut.Name = "labelLogOut";
            this.labelLogOut.Size = new System.Drawing.Size(182, 25);
            this.labelLogOut.TabIndex = 0;
            this.labelLogOut.Text = "DÉCONNECTER ";
            // 
            // creatQRCode
>>>>>>> 915d7267ecd26a6e9a9f1098e4d53a714f33dcbd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.cboSelectBoxes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLogOut);
            this.ForeColor = System.Drawing.Color.Gray;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "createQRCode";
            this.Text = "createQRCode";
            this.Load += new System.EventHandler(this.creatQRCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSelectBoxes;
        private System.Windows.Forms.Label labelLogOut;
    }
}