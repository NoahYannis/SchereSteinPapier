
namespace Schere_Stein_Papier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblSSP = new System.Windows.Forms.Label();
            this.pbSpieler = new System.Windows.Forms.PictureBox();
            this.pbGegner = new System.Windows.Forms.PictureBox();
            this.lblSpieler = new System.Windows.Forms.Label();
            this.lblGegner = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpieler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGegner)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSSP
            // 
            this.lblSSP.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSSP.ForeColor = System.Drawing.Color.Black;
            this.lblSSP.Location = new System.Drawing.Point(45, 25);
            this.lblSSP.Name = "lblSSP";
            this.lblSSP.Size = new System.Drawing.Size(870, 118);
            this.lblSSP.TabIndex = 0;
            this.lblSSP.Text = "Schere, Stein, Papier!";
            this.lblSSP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbSpieler
            // 
            this.pbSpieler.Image = global::Schere_Stein_Papier.Properties.Resources.SchereSteinPapier_Stein;
            this.pbSpieler.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbSpieler.InitialImage")));
            this.pbSpieler.Location = new System.Drawing.Point(115, 159);
            this.pbSpieler.Name = "pbSpieler";
            this.pbSpieler.Size = new System.Drawing.Size(351, 204);
            this.pbSpieler.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSpieler.TabIndex = 1;
            this.pbSpieler.TabStop = false;
            // 
            // pbGegner
            // 
            this.pbGegner.Image = global::Schere_Stein_Papier.Properties.Resources.SchereSteinPapier_Schere;
            this.pbGegner.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbGegner.InitialImage")));
            this.pbGegner.Location = new System.Drawing.Point(516, 161);
            this.pbGegner.Name = "pbGegner";
            this.pbGegner.Size = new System.Drawing.Size(359, 201);
            this.pbGegner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGegner.TabIndex = 2;
            this.pbGegner.TabStop = false;
            // 
            // lblSpieler
            // 
            this.lblSpieler.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSpieler.ForeColor = System.Drawing.Color.Black;
            this.lblSpieler.Location = new System.Drawing.Point(205, 391);
            this.lblSpieler.Name = "lblSpieler";
            this.lblSpieler.Size = new System.Drawing.Size(137, 52);
            this.lblSpieler.TabIndex = 3;
            this.lblSpieler.Text = "Spieler";
            this.lblSpieler.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblGegner
            // 
            this.lblGegner.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGegner.ForeColor = System.Drawing.Color.Black;
            this.lblGegner.Location = new System.Drawing.Point(625, 394);
            this.lblGegner.Name = "lblGegner";
            this.lblGegner.Size = new System.Drawing.Size(166, 49);
            this.lblGegner.TabIndex = 4;
            this.lblGegner.Text = "Gegner";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(402, 460);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(166, 60);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(976, 560);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblGegner);
            this.Controls.Add(this.lblSpieler);
            this.Controls.Add(this.pbGegner);
            this.Controls.Add(this.pbSpieler);
            this.Controls.Add(this.lblSSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "SchereSteinPapier";
            ((System.ComponentModel.ISupportInitialize)(this.pbSpieler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGegner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSSP;
        private System.Windows.Forms.PictureBox pbSpieler;
        private System.Windows.Forms.PictureBox pbGegner;
        private System.Windows.Forms.Label lblSpieler;
        private System.Windows.Forms.Label lblGegner;
        private System.Windows.Forms.Button btnStart;
    }
}

