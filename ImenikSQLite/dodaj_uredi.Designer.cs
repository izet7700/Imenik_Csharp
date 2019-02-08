namespace ImenikSQLite
{
    partial class dodaj_uredi
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
            this.imeOsebeLabel = new System.Windows.Forms.Label();
            this.priimekOsebeLabel = new System.Windows.Forms.Label();
            this.naslovLabel = new System.Windows.Forms.Label();
            this.telefonLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.imeOsebeTextBox = new System.Windows.Forms.TextBox();
            this.priimekOsebeTextBox = new System.Windows.Forms.TextBox();
            this.naslovTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.shraniButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imeOsebeLabel
            // 
            this.imeOsebeLabel.AutoSize = true;
            this.imeOsebeLabel.Location = new System.Drawing.Point(12, 9);
            this.imeOsebeLabel.Name = "imeOsebeLabel";
            this.imeOsebeLabel.Size = new System.Drawing.Size(27, 13);
            this.imeOsebeLabel.TabIndex = 0;
            this.imeOsebeLabel.Text = "Ime:";
            // 
            // priimekOsebeLabel
            // 
            this.priimekOsebeLabel.AutoSize = true;
            this.priimekOsebeLabel.Location = new System.Drawing.Point(12, 39);
            this.priimekOsebeLabel.Name = "priimekOsebeLabel";
            this.priimekOsebeLabel.Size = new System.Drawing.Size(44, 13);
            this.priimekOsebeLabel.TabIndex = 1;
            this.priimekOsebeLabel.Text = "Priimek:";
            // 
            // naslovLabel
            // 
            this.naslovLabel.AutoSize = true;
            this.naslovLabel.Location = new System.Drawing.Point(12, 68);
            this.naslovLabel.Name = "naslovLabel";
            this.naslovLabel.Size = new System.Drawing.Size(43, 13);
            this.naslovLabel.TabIndex = 2;
            this.naslovLabel.Text = "Naslov:";
            // 
            // telefonLabel
            // 
            this.telefonLabel.AutoSize = true;
            this.telefonLabel.Location = new System.Drawing.Point(12, 98);
            this.telefonLabel.Name = "telefonLabel";
            this.telefonLabel.Size = new System.Drawing.Size(64, 13);
            this.telefonLabel.TabIndex = 3;
            this.telefonLabel.Text = "Tel.številka:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(12, 128);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "Email:";
            // 
            // imeOsebeTextBox
            // 
            this.imeOsebeTextBox.Location = new System.Drawing.Point(114, 6);
            this.imeOsebeTextBox.Name = "imeOsebeTextBox";
            this.imeOsebeTextBox.Size = new System.Drawing.Size(195, 20);
            this.imeOsebeTextBox.TabIndex = 5;
            // 
            // priimekOsebeTextBox
            // 
            this.priimekOsebeTextBox.Location = new System.Drawing.Point(114, 36);
            this.priimekOsebeTextBox.Name = "priimekOsebeTextBox";
            this.priimekOsebeTextBox.Size = new System.Drawing.Size(195, 20);
            this.priimekOsebeTextBox.TabIndex = 6;
            this.priimekOsebeTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // naslovTextBox
            // 
            this.naslovTextBox.Location = new System.Drawing.Point(114, 65);
            this.naslovTextBox.Name = "naslovTextBox";
            this.naslovTextBox.Size = new System.Drawing.Size(195, 20);
            this.naslovTextBox.TabIndex = 7;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Location = new System.Drawing.Point(114, 95);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(195, 20);
            this.telefonTextBox.TabIndex = 8;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(114, 125);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(195, 20);
            this.emailTextBox.TabIndex = 9;
            // 
            // shraniButton
            // 
            this.shraniButton.Location = new System.Drawing.Point(234, 158);
            this.shraniButton.Name = "shraniButton";
            this.shraniButton.Size = new System.Drawing.Size(75, 23);
            this.shraniButton.TabIndex = 10;
            this.shraniButton.Text = "Shrani";
            this.shraniButton.UseVisualStyleBackColor = true;
            this.shraniButton.Click += new System.EventHandler(this.shraniButton_Click);
            // 
            // dodaj_uredi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 193);
            this.Controls.Add(this.shraniButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.naslovTextBox);
            this.Controls.Add(this.priimekOsebeTextBox);
            this.Controls.Add(this.imeOsebeTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.telefonLabel);
            this.Controls.Add(this.naslovLabel);
            this.Controls.Add(this.priimekOsebeLabel);
            this.Controls.Add(this.imeOsebeLabel);
            this.Name = "dodaj_uredi";
            this.Text = "Dodaj / Uredi osebo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imeOsebeLabel;
        private System.Windows.Forms.Label priimekOsebeLabel;
        private System.Windows.Forms.Label naslovLabel;
        private System.Windows.Forms.Label telefonLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox imeOsebeTextBox;
        private System.Windows.Forms.TextBox priimekOsebeTextBox;
        private System.Windows.Forms.TextBox naslovTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button shraniButton;
    }
}