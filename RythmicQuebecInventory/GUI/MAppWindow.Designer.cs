namespace RythmicQuebecInventory
{
    partial class MAppWindow
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
            this.AdmAccess = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.viewAndSch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.admAccessClick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdmAccess
            // 
            this.AdmAccess.AutoSize = true;
            this.AdmAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdmAccess.ForeColor = System.Drawing.Color.Silver;
            this.AdmAccess.Location = new System.Drawing.Point(748, 28);
            this.AdmAccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AdmAccess.Name = "AdmAccess";
            this.AdmAccess.Size = new System.Drawing.Size(0, 20);
            this.AdmAccess.TabIndex = 1;
            this.AdmAccess.Click += new System.EventHandler(this.AdmAccess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(127, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "MAIN APPLICATION WINDOW";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // viewAndSch
            // 
            this.viewAndSch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAndSch.Location = new System.Drawing.Point(127, 122);
            this.viewAndSch.Margin = new System.Windows.Forms.Padding(2);
            this.viewAndSch.Name = "viewAndSch";
            this.viewAndSch.Size = new System.Drawing.Size(188, 41);
            this.viewAndSch.TabIndex = 3;
            this.viewAndSch.Text = "VIEW AND SEARCH";
            this.viewAndSch.UseVisualStyleBackColor = true;
            this.viewAndSch.Click += new System.EventHandler(this.viewAndSch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(694, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // admAccessClick
            // 
            this.admAccessClick.AutoSize = true;
            this.admAccessClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admAccessClick.ForeColor = System.Drawing.Color.Silver;
            this.admAccessClick.Location = new System.Drawing.Point(630, 35);
            this.admAccessClick.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.admAccessClick.Name = "admAccessClick";
            this.admAccessClick.Size = new System.Drawing.Size(143, 20);
            this.admAccessClick.TabIndex = 5;
            this.admAccessClick.Text = "ADMIN ACCESS";
            this.admAccessClick.Click += new System.EventHandler(this.label3_Click);
            // 
            // MAppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.admAccessClick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewAndSch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdmAccess);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MAppWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main Application Window";
            this.Load += new System.EventHandler(this.MAppWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AdmAccess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewAndSch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label admAccessClick;
    }
}