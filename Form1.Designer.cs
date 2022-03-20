namespace Uppgift3WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtBNamn = new System.Windows.Forms.TextBox();
            this.txtBEftNamn = new System.Windows.Forms.TextBox();
            this.txtPersNr = new System.Windows.Forms.TextBox();
            this.btnKör = new System.Windows.Forms.Button();
            this.btnAvsluta = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staffan Leandersson, Sleandersson@yahoo.se, L0002B, Uppgift 3";
            // 
            // txtBNamn
            // 
            this.txtBNamn.Location = new System.Drawing.Point(13, 32);
            this.txtBNamn.Name = "txtBNamn";
            this.txtBNamn.PlaceholderText = "Förnamn";
            this.txtBNamn.Size = new System.Drawing.Size(206, 23);
            this.txtBNamn.TabIndex = 2;
            // 
            // txtBEftNamn
            // 
            this.txtBEftNamn.Location = new System.Drawing.Point(13, 70);
            this.txtBEftNamn.Name = "txtBEftNamn";
            this.txtBEftNamn.PlaceholderText = "Efternamn";
            this.txtBEftNamn.Size = new System.Drawing.Size(206, 23);
            this.txtBEftNamn.TabIndex = 3;
            // 
            // txtPersNr
            // 
            this.txtPersNr.Location = new System.Drawing.Point(13, 108);
            this.txtPersNr.MaxLength = 13;
            this.txtPersNr.Name = "txtPersNr";
            this.txtPersNr.PlaceholderText = "Personnummer (tio siffror)";
            this.txtPersNr.Size = new System.Drawing.Size(206, 23);
            this.txtPersNr.TabIndex = 4;
            // 
            // btnKör
            // 
            this.btnKör.Location = new System.Drawing.Point(144, 137);
            this.btnKör.Name = "btnKör";
            this.btnKör.Size = new System.Drawing.Size(75, 23);
            this.btnKör.TabIndex = 1;
            this.btnKör.Text = "Kör koll!";
            this.btnKör.UseVisualStyleBackColor = true;
            this.btnKör.Click += new System.EventHandler(this.btnKör_Click);
            // 
            // btnAvsluta
            // 
            this.btnAvsluta.Location = new System.Drawing.Point(13, 137);
            this.btnAvsluta.Name = "btnAvsluta";
            this.btnAvsluta.Size = new System.Drawing.Size(75, 23);
            this.btnAvsluta.TabIndex = 5;
            this.btnAvsluta.TabStop = false;
            this.btnAvsluta.Text = "Avsluta";
            this.btnAvsluta.UseVisualStyleBackColor = true;
            this.btnAvsluta.Click += new System.EventHandler(this.btnAvsluta_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(225, 32);
            this.lblResultat.MinimumSize = new System.Drawing.Size(380, 135);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(380, 135);
            this.lblResultat.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 171);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.btnAvsluta);
            this.Controls.Add(this.btnKör);
            this.Controls.Add(this.txtPersNr);
            this.Controls.Add(this.txtBEftNamn);
            this.Controls.Add(this.txtBNamn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Uppgift 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtBNamn;
        private TextBox txtBEftNamn;
        private TextBox txtPersNr;
        private Button btnKör;
        private Button btnAvsluta;
        private Label lblResultat;
    }
}