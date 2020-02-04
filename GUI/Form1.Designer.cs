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
            this.Användarnamn.Location = new System.Drawing.Point(87, 252);
            this.Användarnamn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Användarnamn.Name = "Användarnamn";
            this.Användarnamn.Size = new System.Drawing.Size(261, 22);
            this.Användarnamn.TabIndex = 0;
            this.Användarnamn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Lösenord
            // 
            this.Lösenord.Location = new System.Drawing.Point(519, 252);
            this.Lösenord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Lösenord.Name = "Lösenord";
            this.Lösenord.Size = new System.Drawing.Size(269, 22);
            this.Lösenord.TabIndex = 1;
            this.Lösenord.TextChanged += new System.EventHandler(this.Lösenord_TextChanged);
            // 
            // LoggaInKnapp
            // 
            this.LoggaInKnapp.Location = new System.Drawing.Point(283, 346);
            this.LoggaInKnapp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoggaInKnapp.Name = "LoggaInKnapp";
            this.LoggaInKnapp.Size = new System.Drawing.Size(269, 71);
            this.LoggaInKnapp.TabIndex = 2;
            this.LoggaInKnapp.Text = "Logga in";
            this.LoggaInKnapp.UseVisualStyleBackColor = true;
            this.LoggaInKnapp.Click += new System.EventHandler(this.LoggaInKnapp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(633, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lösenord";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Användarnamn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 498);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoggaInKnapp);
            this.Controls.Add(this.Lösenord);
            this.Controls.Add(this.Användarnamn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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

