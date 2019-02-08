namespace ImenikSQLite
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
            this.izberiImenikLabel = new System.Windows.Forms.Label();
            this.dodajImenikLabel = new System.Windows.Forms.Label();
            this.izberiImenikComboBox = new System.Windows.Forms.ComboBox();
            this.dodajImenikTextBox = new System.Windows.Forms.TextBox();
            this.dodajImenikButton = new System.Windows.Forms.Button();
            this.imenikGroupBox = new System.Windows.Forms.GroupBox();
            this.izbrišiOseboButton = new System.Windows.Forms.Button();
            this.urediOseboButton = new System.Windows.Forms.Button();
            this.dodajOseboButton = new System.Windows.Forms.Button();
            this.imenikListBox = new System.Windows.Forms.ListBox();
            this.imenikGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // izberiImenikLabel
            // 
            this.izberiImenikLabel.AutoSize = true;
            this.izberiImenikLabel.Location = new System.Drawing.Point(10, 9);
            this.izberiImenikLabel.Name = "izberiImenikLabel";
            this.izberiImenikLabel.Size = new System.Drawing.Size(68, 13);
            this.izberiImenikLabel.TabIndex = 0;
            this.izberiImenikLabel.Text = "Izberi imenik:";
            // 
            // dodajImenikLabel
            // 
            this.dodajImenikLabel.AutoSize = true;
            this.dodajImenikLabel.Location = new System.Drawing.Point(305, 9);
            this.dodajImenikLabel.Name = "dodajImenikLabel";
            this.dodajImenikLabel.Size = new System.Drawing.Size(71, 13);
            this.dodajImenikLabel.TabIndex = 1;
            this.dodajImenikLabel.Text = "Dodaj imenik:";
            // 
            // izberiImenikComboBox
            // 
            this.izberiImenikComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.izberiImenikComboBox.FormattingEnabled = true;
            this.izberiImenikComboBox.Location = new System.Drawing.Point(84, 6);
            this.izberiImenikComboBox.Name = "izberiImenikComboBox";
            this.izberiImenikComboBox.Size = new System.Drawing.Size(141, 21);
            this.izberiImenikComboBox.TabIndex = 2;
            this.izberiImenikComboBox.SelectedIndexChanged += new System.EventHandler(this.izberiImenikComboBox_SelectedIndexChanged);
            this.izberiImenikComboBox.Click += new System.EventHandler(this.izberiImenikComboBox_Click);
            this.izberiImenikComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.izberiImenikComboBox_MouseClick);
            // 
            // dodajImenikTextBox
            // 
            this.dodajImenikTextBox.Location = new System.Drawing.Point(382, 6);
            this.dodajImenikTextBox.Name = "dodajImenikTextBox";
            this.dodajImenikTextBox.Size = new System.Drawing.Size(134, 20);
            this.dodajImenikTextBox.TabIndex = 3;
            // 
            // dodajImenikButton
            // 
            this.dodajImenikButton.Location = new System.Drawing.Point(522, 4);
            this.dodajImenikButton.Name = "dodajImenikButton";
            this.dodajImenikButton.Size = new System.Drawing.Size(124, 23);
            this.dodajImenikButton.TabIndex = 4;
            this.dodajImenikButton.Text = "Dodaj imenik";
            this.dodajImenikButton.UseVisualStyleBackColor = true;
            this.dodajImenikButton.Click += new System.EventHandler(this.dodajImenikButton_Click);
            // 
            // imenikGroupBox
            // 
            this.imenikGroupBox.Controls.Add(this.izbrišiOseboButton);
            this.imenikGroupBox.Controls.Add(this.urediOseboButton);
            this.imenikGroupBox.Controls.Add(this.dodajOseboButton);
            this.imenikGroupBox.Controls.Add(this.imenikListBox);
            this.imenikGroupBox.Location = new System.Drawing.Point(12, 33);
            this.imenikGroupBox.Name = "imenikGroupBox";
            this.imenikGroupBox.Size = new System.Drawing.Size(634, 301);
            this.imenikGroupBox.TabIndex = 5;
            this.imenikGroupBox.TabStop = false;
            this.imenikGroupBox.Text = "Imenik";
            this.imenikGroupBox.Visible = false;
            // 
            // izbrišiOseboButton
            // 
            this.izbrišiOseboButton.Location = new System.Drawing.Point(504, 272);
            this.izbrišiOseboButton.Name = "izbrišiOseboButton";
            this.izbrišiOseboButton.Size = new System.Drawing.Size(124, 23);
            this.izbrišiOseboButton.TabIndex = 3;
            this.izbrišiOseboButton.Text = "Izbriši osebo";
            this.izbrišiOseboButton.UseVisualStyleBackColor = true;
            this.izbrišiOseboButton.Click += new System.EventHandler(this.izbrišiOseboButton_Click);
            // 
            // urediOseboButton
            // 
            this.urediOseboButton.Location = new System.Drawing.Point(259, 272);
            this.urediOseboButton.Name = "urediOseboButton";
            this.urediOseboButton.Size = new System.Drawing.Size(124, 23);
            this.urediOseboButton.TabIndex = 2;
            this.urediOseboButton.Text = "Uredi osebo";
            this.urediOseboButton.UseVisualStyleBackColor = true;
            this.urediOseboButton.Click += new System.EventHandler(this.urediOseboButton_Click);
            // 
            // dodajOseboButton
            // 
            this.dodajOseboButton.Location = new System.Drawing.Point(0, 272);
            this.dodajOseboButton.Name = "dodajOseboButton";
            this.dodajOseboButton.Size = new System.Drawing.Size(124, 23);
            this.dodajOseboButton.TabIndex = 1;
            this.dodajOseboButton.Text = "Dodaj osebo";
            this.dodajOseboButton.UseVisualStyleBackColor = true;
            this.dodajOseboButton.Click += new System.EventHandler(this.dodajOseboButton_Click);
            // 
            // imenikListBox
            // 
            this.imenikListBox.FormattingEnabled = true;
            this.imenikListBox.Location = new System.Drawing.Point(6, 19);
            this.imenikListBox.Name = "imenikListBox";
            this.imenikListBox.Size = new System.Drawing.Size(622, 238);
            this.imenikListBox.TabIndex = 0;
            this.imenikListBox.SelectedIndexChanged += new System.EventHandler(this.imenikListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 345);
            this.Controls.Add(this.imenikGroupBox);
            this.Controls.Add(this.dodajImenikButton);
            this.Controls.Add(this.dodajImenikTextBox);
            this.Controls.Add(this.izberiImenikComboBox);
            this.Controls.Add(this.dodajImenikLabel);
            this.Controls.Add(this.izberiImenikLabel);
            this.Name = "Form1";
            this.Text = "Imenik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.imenikGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label izberiImenikLabel;
        private System.Windows.Forms.Label dodajImenikLabel;
        private System.Windows.Forms.ComboBox izberiImenikComboBox;
        private System.Windows.Forms.TextBox dodajImenikTextBox;
        private System.Windows.Forms.Button dodajImenikButton;
        private System.Windows.Forms.GroupBox imenikGroupBox;
        private System.Windows.Forms.Button izbrišiOseboButton;
        private System.Windows.Forms.Button urediOseboButton;
        private System.Windows.Forms.Button dodajOseboButton;
        public System.Windows.Forms.ListBox imenikListBox;
    }
}

