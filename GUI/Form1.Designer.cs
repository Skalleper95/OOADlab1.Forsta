namespace GUI
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
            this.Användarnamn = new System.Windows.Forms.TextBox();
            this.Lösenord = new System.Windows.Forms.TextBox();
            this.LoggaInKnapp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Användarnamn
            // 
            this.Användarnamn.Location = new System.Drawing.Point(65, 205);
            this.Användarnamn.Name = "Användarnamn";
            this.Användarnamn.Size = new System.Drawing.Size(197, 20);
            this.Användarnamn.TabIndex = 0;
            this.Användarnamn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Lösenord
            // 
            this.Lösenord.Location = new System.Drawing.Point(389, 205);
            this.Lösenord.Name = "Lösenord";
            this.Lösenord.Size = new System.Drawing.Size(203, 20);
            this.Lösenord.TabIndex = 1;
            this.Lösenord.TextChanged += new System.EventHandler(this.Lösenord_TextChanged);
            // 
            // LoggaInKnapp
            // 
            this.LoggaInKnapp.Location = new System.Drawing.Point(212, 281);
            this.LoggaInKnapp.Name = "LoggaInKnapp";
            this.LoggaInKnapp.Size = new System.Drawing.Size(202, 58);
            this.LoggaInKnapp.TabIndex = 2;
            this.LoggaInKnapp.Text = "Logga in";
            this.LoggaInKnapp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lösenord";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Användarnamn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 405);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoggaInKnapp);
            this.Controls.Add(this.Lösenord);
            this.Controls.Add(this.Användarnamn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Användarnamn;
        private System.Windows.Forms.TextBox Lösenord;
        private System.Windows.Forms.Button LoggaInKnapp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

