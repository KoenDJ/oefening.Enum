namespace oefening.Enum
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
            this.cbWerknemers = new System.Windows.Forms.ComboBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblHerkomst = new System.Windows.Forms.Label();
            this.lblSalaris = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbWerknemers
            // 
            this.cbWerknemers.FormattingEnabled = true;
            this.cbWerknemers.Location = new System.Drawing.Point(12, 9);
            this.cbWerknemers.Name = "cbWerknemers";
            this.cbWerknemers.Size = new System.Drawing.Size(121, 24);
            this.cbWerknemers.TabIndex = 0;
            this.cbWerknemers.SelectedIndexChanged += new System.EventHandler(this.cbWerknemers_SelectedIndexChanged);
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(12, 48);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(0, 17);
            this.lblNaam.TabIndex = 2;
            this.lblNaam.Click += new System.EventHandler(this.lblNaam_Click);
            // 
            // lblHerkomst
            // 
            this.lblHerkomst.AutoSize = true;
            this.lblHerkomst.Location = new System.Drawing.Point(12, 88);
            this.lblHerkomst.Name = "lblHerkomst";
            this.lblHerkomst.Size = new System.Drawing.Size(0, 17);
            this.lblHerkomst.TabIndex = 3;
            this.lblHerkomst.Click += new System.EventHandler(this.lblHerkomst_Click);
            // 
            // lblSalaris
            // 
            this.lblSalaris.AutoSize = true;
            this.lblSalaris.Location = new System.Drawing.Point(9, 71);
            this.lblSalaris.Name = "lblSalaris";
            this.lblSalaris.Size = new System.Drawing.Size(0, 17);
            this.lblSalaris.TabIndex = 4;
            this.lblSalaris.Click += new System.EventHandler(this.lblSalaris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSalaris);
            this.Controls.Add(this.lblHerkomst);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.cbWerknemers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbWerknemers;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblHerkomst;
        private System.Windows.Forms.Label lblSalaris;
        private System.Windows.Forms.Label label1;
    }
}

