namespace RythmicQuebecInventory
{
    partial class AddDeleteCoach
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddDeleteCoaches = new System.Windows.Forms.GroupBox();
            this.DeleteCoach = new System.Windows.Forms.Button();
            this.CoachGrid = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddCoach = new System.Windows.Forms.Button();
            this.AddDeleteCoaches.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoachGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD COACH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(758, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "LOG OUT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(658, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "SEARCH ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(718, 57);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 4;
            // 
            // AddDeleteCoaches
            // 
            this.AddDeleteCoaches.BackColor = System.Drawing.Color.White;
            this.AddDeleteCoaches.Controls.Add(this.DeleteCoach);
            this.AddDeleteCoaches.Controls.Add(this.CoachGrid);
            this.AddDeleteCoaches.Controls.Add(this.AddCoach);
            this.AddDeleteCoaches.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddDeleteCoaches.Location = new System.Drawing.Point(112, 114);
            this.AddDeleteCoaches.Margin = new System.Windows.Forms.Padding(2);
            this.AddDeleteCoaches.Name = "AddDeleteCoaches";
            this.AddDeleteCoaches.Padding = new System.Windows.Forms.Padding(2);
            this.AddDeleteCoaches.Size = new System.Drawing.Size(735, 365);
            this.AddDeleteCoaches.TabIndex = 5;
            this.AddDeleteCoaches.TabStop = false;
            this.AddDeleteCoaches.Text = "Add Delete Coach";
            // 
            // DeleteCoach
            // 
            this.DeleteCoach.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCoach.Location = new System.Drawing.Point(573, 309);
            this.DeleteCoach.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteCoach.Name = "DeleteCoach";
            this.DeleteCoach.Size = new System.Drawing.Size(92, 25);
            this.DeleteCoach.TabIndex = 2;
            this.DeleteCoach.Text = "Delete Coach";
            this.DeleteCoach.UseVisualStyleBackColor = true;
            // 
            // CoachGrid
            // 
            this.CoachGrid.BackgroundColor = System.Drawing.Color.Cyan;
            this.CoachGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CoachGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoachGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5});
            this.CoachGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CoachGrid.Location = new System.Drawing.Point(43, 49);
            this.CoachGrid.Margin = new System.Windows.Forms.Padding(2);
            this.CoachGrid.Name = "CoachGrid";
            this.CoachGrid.RowHeadersWidth = 51;
            this.CoachGrid.RowTemplate.Height = 24;
            this.CoachGrid.Size = new System.Drawing.Size(644, 58);
            this.CoachGrid.TabIndex = 1;
            this.CoachGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Group";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "First Name and Last Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Phone Number";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Email";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Address";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 220;
            // 
            // AddCoach
            // 
            this.AddCoach.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCoach.Location = new System.Drawing.Point(449, 309);
            this.AddCoach.Margin = new System.Windows.Forms.Padding(2);
            this.AddCoach.Name = "AddCoach";
            this.AddCoach.Size = new System.Drawing.Size(98, 25);
            this.AddCoach.TabIndex = 0;
            this.AddCoach.Text = "Add Coach";
            this.AddCoach.UseVisualStyleBackColor = true;
            this.AddCoach.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddDeleteCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.AddDeleteCoaches);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddDeleteCoach";
            this.Text = "AddDeleteCoach";
            this.AddDeleteCoaches.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CoachGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox AddDeleteCoaches;
        private System.Windows.Forms.DataGridView CoachGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button AddCoach;
        private System.Windows.Forms.Button DeleteCoach;
    }
}