namespace Uppgift_10
{
    partial class Form1
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
            this.btnSlumpa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxGissa = new System.Windows.Forms.TextBox();
            this.btnGissa = new System.Windows.Forms.Button();
            this.txtBoxKommentar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gissa talet!";
            // 
            // btnSlumpa
            // 
            this.btnSlumpa.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSlumpa.Location = new System.Drawing.Point(141, 115);
            this.btnSlumpa.Name = "btnSlumpa";
            this.btnSlumpa.Size = new System.Drawing.Size(202, 32);
            this.btnSlumpa.TabIndex = 1;
            this.btnSlumpa.Text = "Slumpa ett tal mellan 1-1000.";
            this.btnSlumpa.UseVisualStyleBackColor = true;
            this.btnSlumpa.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gissa på ett tal:";
            // 
            // txtBoxGissa
            // 
            this.txtBoxGissa.Location = new System.Drawing.Point(141, 185);
            this.txtBoxGissa.Name = "txtBoxGissa";
            this.txtBoxGissa.Size = new System.Drawing.Size(202, 20);
            this.txtBoxGissa.TabIndex = 3;
            // 
            // btnGissa
            // 
            this.btnGissa.Font = new System.Drawing.Font("Sitka Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGissa.Location = new System.Drawing.Point(268, 211);
            this.btnGissa.Name = "btnGissa";
            this.btnGissa.Size = new System.Drawing.Size(75, 23);
            this.btnGissa.TabIndex = 4;
            this.btnGissa.Text = "Gissa!";
            this.btnGissa.UseVisualStyleBackColor = true;
            this.btnGissa.Click += new System.EventHandler(this.btnGissa_Click);
            // 
            // txtBoxKommentar
            // 
            this.txtBoxKommentar.Location = new System.Drawing.Point(171, 260);
            this.txtBoxKommentar.Name = "txtBoxKommentar";
            this.txtBoxKommentar.Size = new System.Drawing.Size(138, 20);
            this.txtBoxKommentar.TabIndex = 5;
            this.txtBoxKommentar.TextChanged += new System.EventHandler(this.txtBoxKommentar_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 339);
            this.Controls.Add(this.txtBoxKommentar);
            this.Controls.Add(this.btnGissa);
            this.Controls.Add(this.txtBoxGissa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSlumpa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSlumpa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxGissa;
        private System.Windows.Forms.Button btnGissa;
        private System.Windows.Forms.TextBox txtBoxKommentar;
    }
}

