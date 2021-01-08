
namespace WindowsFormsApP14._5
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
            this.TxtGetallen = new System.Windows.Forms.TextBox();
            this.BtnVerwisselen = new System.Windows.Forms.Button();
            this.BtnVerplaatsen = new System.Windows.Forms.Button();
            this.TxtVerwisssel = new System.Windows.Forms.TextBox();
            this.TxtVerplaats = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndex1 = new System.Windows.Forms.TextBox();
            this.txtIndex2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtGetallen
            // 
            this.TxtGetallen.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGetallen.Location = new System.Drawing.Point(28, 123);
            this.TxtGetallen.Multiline = true;
            this.TxtGetallen.Name = "TxtGetallen";
            this.TxtGetallen.Size = new System.Drawing.Size(248, 288);
            this.TxtGetallen.TabIndex = 0;
            // 
            // BtnVerwisselen
            // 
            this.BtnVerwisselen.Location = new System.Drawing.Point(282, 56);
            this.BtnVerwisselen.Name = "BtnVerwisselen";
            this.BtnVerwisselen.Size = new System.Drawing.Size(171, 23);
            this.BtnVerwisselen.TabIndex = 1;
            this.BtnVerwisselen.Text = "Verwisselen";
            this.BtnVerwisselen.UseVisualStyleBackColor = true;
            this.BtnVerwisselen.Click += new System.EventHandler(this.BtnVerwisselen_Click);
            // 
            // BtnVerplaatsen
            // 
            this.BtnVerplaatsen.Location = new System.Drawing.Point(561, 56);
            this.BtnVerplaatsen.Name = "BtnVerplaatsen";
            this.BtnVerplaatsen.Size = new System.Drawing.Size(171, 23);
            this.BtnVerplaatsen.TabIndex = 2;
            this.BtnVerplaatsen.Text = "Verplaatsen";
            this.BtnVerplaatsen.UseVisualStyleBackColor = true;
            this.BtnVerplaatsen.Click += new System.EventHandler(this.BtnVerplaatsen_Click);
            // 
            // TxtVerwisssel
            // 
            this.TxtVerwisssel.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVerwisssel.Location = new System.Drawing.Point(282, 123);
            this.TxtVerwisssel.Multiline = true;
            this.TxtVerwisssel.Name = "TxtVerwisssel";
            this.TxtVerwisssel.Size = new System.Drawing.Size(238, 288);
            this.TxtVerwisssel.TabIndex = 3;
            // 
            // TxtVerplaats
            // 
            this.TxtVerplaats.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVerplaats.Location = new System.Drawing.Point(526, 123);
            this.TxtVerplaats.Multiline = true;
            this.TxtVerplaats.Name = "TxtVerplaats";
            this.TxtVerplaats.Size = new System.Drawing.Size(262, 288);
            this.TxtVerplaats.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Index1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Index2";
            // 
            // txtIndex1
            // 
            this.txtIndex1.Location = new System.Drawing.Point(94, 24);
            this.txtIndex1.Name = "txtIndex1";
            this.txtIndex1.Size = new System.Drawing.Size(100, 22);
            this.txtIndex1.TabIndex = 7;
            // 
            // txtIndex2
            // 
            this.txtIndex2.Location = new System.Drawing.Point(94, 66);
            this.txtIndex2.Name = "txtIndex2";
            this.txtIndex2.Size = new System.Drawing.Size(100, 22);
            this.txtIndex2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtIndex2);
            this.Controls.Add(this.txtIndex1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtVerplaats);
            this.Controls.Add(this.TxtVerwisssel);
            this.Controls.Add(this.BtnVerplaatsen);
            this.Controls.Add(this.BtnVerwisselen);
            this.Controls.Add(this.TxtGetallen);
            this.Name = "Form1";
            this.Text = "git";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtGetallen;
        private System.Windows.Forms.Button BtnVerwisselen;
        private System.Windows.Forms.Button BtnVerplaatsen;
        private System.Windows.Forms.TextBox TxtVerwisssel;
        private System.Windows.Forms.TextBox TxtVerplaats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIndex1;
        private System.Windows.Forms.TextBox txtIndex2;
    }
}

