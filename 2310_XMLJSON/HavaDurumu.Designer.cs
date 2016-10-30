namespace _2310_XMLJSON
{
    partial class HavaDurumu
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
            this.cmbSehirler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbSehirler
            // 
            this.cmbSehirler.FormattingEnabled = true;
            this.cmbSehirler.Location = new System.Drawing.Point(28, 27);
            this.cmbSehirler.Name = "cmbSehirler";
            this.cmbSehirler.Size = new System.Drawing.Size(223, 26);
            this.cmbSehirler.TabIndex = 0;
            this.cmbSehirler.SelectedIndexChanged += new System.EventHandler(this.cmbSehirler_SelectedIndexChanged);
            // 
            // HavaDurumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 361);
            this.Controls.Add(this.cmbSehirler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HavaDurumu";
            this.Text = "HavaDurumu";
            this.Load += new System.EventHandler(this.HavaDurumu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSehirler;
    }
}