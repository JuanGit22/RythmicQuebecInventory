namespace RythmicQuebecInventory
{
    partial class FormStartWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStartWindow));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelInventaire = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInventaire
            // 
            this.labelInventaire.AutoSize = true;
            this.labelInventaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventaire.ForeColor = System.Drawing.Color.Silver;
            this.labelInventaire.Location = new System.Drawing.Point(379, 502);
            this.labelInventaire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInventaire.Name = "labelInventaire";
            this.labelInventaire.Size = new System.Drawing.Size(228, 18);
            this.labelInventaire.TabIndex = 3;
            this.labelInventaire.Text = "INVENTAIRE DE STOCKAGE";
            this.labelInventaire.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormStartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.labelInventaire);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormStartWindow";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelInventaire;
    }
}