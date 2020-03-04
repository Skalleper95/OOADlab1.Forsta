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
            this.ListboxBöcker = new System.Windows.Forms.ListBox();
            this.MedlemsIdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SkapaBokninKnapp = new System.Windows.Forms.Button();
            this.AvslutaBokning = new System.Windows.Forms.Button();
            this.BokningsNrBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BokadeBöckerlista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ListboxBöcker
            // 
            this.ListboxBöcker.FormattingEnabled = true;
            this.ListboxBöcker.Location = new System.Drawing.Point(15, 25);
            this.ListboxBöcker.Name = "ListboxBöcker";
            this.ListboxBöcker.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ListboxBöcker.Size = new System.Drawing.Size(219, 277);
            this.ListboxBöcker.TabIndex = 0;
            this.ListboxBöcker.SelectedIndexChanged += new System.EventHandler(this.ListboxBöcker_SelectedIndexChanged);
            // 
            // MedlemsIdBox
            // 
            this.MedlemsIdBox.Location = new System.Drawing.Point(15, 321);
            this.MedlemsIdBox.Name = "MedlemsIdBox";
            this.MedlemsIdBox.Size = new System.Drawing.Size(219, 20);
            this.MedlemsIdBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Medlems ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Skapa en ny bokning ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SkapaBokninKnapp
            // 
            this.SkapaBokninKnapp.Location = new System.Drawing.Point(15, 347);
            this.SkapaBokninKnapp.Name = "SkapaBokninKnapp";
            this.SkapaBokninKnapp.Size = new System.Drawing.Size(108, 24);
            this.SkapaBokninKnapp.TabIndex = 4;
            this.SkapaBokninKnapp.Text = "Skapa bokning";
            this.SkapaBokninKnapp.UseVisualStyleBackColor = true;
            this.SkapaBokninKnapp.Click += new System.EventHandler(this.SkapaBokninKnapp_Click);
            // 
            // AvslutaBokning
            // 
            this.AvslutaBokning.Location = new System.Drawing.Point(376, 64);
            this.AvslutaBokning.Name = "AvslutaBokning";
            this.AvslutaBokning.Size = new System.Drawing.Size(108, 24);
            this.AvslutaBokning.TabIndex = 5;
            this.AvslutaBokning.Text = "Avsluta";
            this.AvslutaBokning.UseVisualStyleBackColor = true;
            this.AvslutaBokning.Click += new System.EventHandler(this.AvslutaBokning_Click);
            // 
            // BokningsNrBox
            // 
            this.BokningsNrBox.Location = new System.Drawing.Point(376, 38);
            this.BokningsNrBox.Name = "BokningsNrBox";
            this.BokningsNrBox.Size = new System.Drawing.Size(108, 20);
            this.BokningsNrBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Boknings nummer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Avsluta en bokning";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(279, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 266);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bokade böcker";
            // 
            // BokadeBöckerlista
            // 
            this.BokadeBöckerlista.FormattingEnabled = true;
            this.BokadeBöckerlista.Location = new System.Drawing.Point(15, 398);
            this.BokadeBöckerlista.Name = "BokadeBöckerlista";
            this.BokadeBöckerlista.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.BokadeBöckerlista.Size = new System.Drawing.Size(219, 277);
            this.BokadeBöckerlista.TabIndex = 12;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 752);
            this.Controls.Add(this.BokadeBöckerlista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BokningsNrBox);
            this.Controls.Add(this.AvslutaBokning);
            this.Controls.Add(this.SkapaBokninKnapp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MedlemsIdBox);
            this.Controls.Add(this.ListboxBöcker);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListboxBöcker;
        private System.Windows.Forms.TextBox MedlemsIdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SkapaBokninKnapp;
        private System.Windows.Forms.Button AvslutaBokning;
        private System.Windows.Forms.TextBox BokningsNrBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox BokadeBöckerlista;
    }
}