namespace GUI
{
    partial class Start
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
            this.LisaboxBöcker = new System.Windows.Forms.ListBox();
            this.MedlemsIdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SkapaBokninKnapp = new System.Windows.Forms.Button();
            this.AvslutaBokning = new System.Windows.Forms.Button();
            this.BokningsNrBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LisaboxBöcker
            // 
            this.LisaboxBöcker.FormattingEnabled = true;
            this.LisaboxBöcker.Location = new System.Drawing.Point(92, 62);
            this.LisaboxBöcker.Name = "LisaboxBöcker";
            this.LisaboxBöcker.Size = new System.Drawing.Size(606, 485);
            this.LisaboxBöcker.TabIndex = 0;
            // 
            // MedlemsIdBox
            // 
            this.MedlemsIdBox.Location = new System.Drawing.Point(92, 607);
            this.MedlemsIdBox.Name = "MedlemsIdBox";
            this.MedlemsIdBox.Size = new System.Drawing.Size(206, 20);
            this.MedlemsIdBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 575);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Medlems Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lisa med böcker";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SkapaBokninKnapp
            // 
            this.SkapaBokninKnapp.Location = new System.Drawing.Point(92, 677);
            this.SkapaBokninKnapp.Name = "SkapaBokninKnapp";
            this.SkapaBokninKnapp.Size = new System.Drawing.Size(210, 36);
            this.SkapaBokninKnapp.TabIndex = 4;
            this.SkapaBokninKnapp.Text = "Skapa bokning";
            this.SkapaBokninKnapp.UseVisualStyleBackColor = false;
            // 
            // AvslutaBokning
            // 
            this.AvslutaBokning.Location = new System.Drawing.Point(501, 677);
            this.AvslutaBokning.Name = "AvslutaBokning";
            this.AvslutaBokning.Size = new System.Drawing.Size(177, 36);
            this.AvslutaBokning.TabIndex = 5;
            this.AvslutaBokning.Text = "Avsluta";
            this.AvslutaBokning.UseVisualStyleBackColor = true;
            // 
            // BokningsNrBox
            // 
            this.BokningsNrBox.Location = new System.Drawing.Point(501, 607);
            this.BokningsNrBox.Name = "BokningsNrBox";
            this.BokningsNrBox.Size = new System.Drawing.Size(177, 20);
            this.BokningsNrBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 575);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Boknings nummer";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 756);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BokningsNrBox);
            this.Controls.Add(this.AvslutaBokning);
            this.Controls.Add(this.SkapaBokninKnapp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MedlemsIdBox);
            this.Controls.Add(this.LisaboxBöcker);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LisaboxBöcker;
        private System.Windows.Forms.TextBox MedlemsIdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SkapaBokninKnapp;
        private System.Windows.Forms.Button AvslutaBokning;
        private System.Windows.Forms.TextBox BokningsNrBox;
        private System.Windows.Forms.Label label3;
    }
}