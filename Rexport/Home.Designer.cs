
namespace Rexport
{
    partial class Home
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.createButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.logoLabel = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.upperPanel = new System.Windows.Forms.Panel();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.welcomeTextLabel = new System.Windows.Forms.Label();
            this.selectLanguageLabel = new System.Windows.Forms.Label();
            this.languageComboBox = new System.Windows.Forms.ComboBox();
            this.homePanel = new System.Windows.Forms.Panel();
            this.editPanel = new System.Windows.Forms.Panel();
            this.editLabel = new System.Windows.Forms.Label();
            this.createPanel = new System.Windows.Forms.Panel();
            this.createLabel = new System.Windows.Forms.Label();
            this.dinamicPanel = new System.Windows.Forms.Panel();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.homePanel.SuspendLayout();
            this.editPanel.SuspendLayout();
            this.createPanel.SuspendLayout();
            this.dinamicPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.leftPanel.Controls.Add(this.logoLabel);
            this.leftPanel.Controls.Add(this.Logo);
            this.leftPanel.Controls.Add(this.createButton);
            this.leftPanel.Controls.Add(this.editButton);
            this.leftPanel.Controls.Add(this.homeButton);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(211, 577);
            this.leftPanel.TabIndex = 0;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.createButton.Location = new System.Drawing.Point(0, 311);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(211, 49);
            this.createButton.TabIndex = 3;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editButton.Location = new System.Drawing.Point(0, 256);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(211, 49);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(101)))));
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.homeButton.Location = new System.Drawing.Point(0, 201);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(211, 49);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.BackColor = System.Drawing.Color.Transparent;
            this.logoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logoLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.logoLabel.Location = new System.Drawing.Point(-3, 160);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(214, 20);
            this.logoLabel.TabIndex = 1;
            this.logoLabel.Text = "a syllabus editting system";
            this.logoLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::Rexport.Properties.Resources.Rexport;
            this.Logo.Location = new System.Drawing.Point(-46, -13);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(293, 183);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // upperPanel
            // 
            this.upperPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(143)))), ((int)(((byte)(143)))));
            this.upperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperPanel.Location = new System.Drawing.Point(211, 0);
            this.upperPanel.Name = "upperPanel";
            this.upperPanel.Size = new System.Drawing.Size(972, 38);
            this.upperPanel.TabIndex = 1;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.welcomeLabel.Location = new System.Drawing.Point(98, 80);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(376, 44);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome to Rexport!\r\n";
            this.welcomeLabel.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // welcomeTextLabel
            // 
            this.welcomeTextLabel.AutoSize = true;
            this.welcomeTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.welcomeTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.welcomeTextLabel.Location = new System.Drawing.Point(99, 149);
            this.welcomeTextLabel.Name = "welcomeTextLabel";
            this.welcomeTextLabel.Size = new System.Drawing.Size(792, 108);
            this.welcomeTextLabel.TabIndex = 3;
            this.welcomeTextLabel.Text = "This is a syllabus editing system for computer and software\r\nengineering courses " +
    "of Izmir University of Economics. \r\nYou can edit an existing syllabus or create " +
    "a new one.\r\n";
            this.welcomeTextLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // selectLanguageLabel
            // 
            this.selectLanguageLabel.AutoSize = true;
            this.selectLanguageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectLanguageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.selectLanguageLabel.Location = new System.Drawing.Point(99, 288);
            this.selectLanguageLabel.Name = "selectLanguageLabel";
            this.selectLanguageLabel.Size = new System.Drawing.Size(370, 36);
            this.selectLanguageLabel.TabIndex = 4;
            this.selectLanguageLabel.Text = "Please select the language\r\n";
            // 
            // languageComboBox
            // 
            this.languageComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.languageComboBox.ForeColor = System.Drawing.Color.Silver;
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            "English",
            "Turkish"});
            this.languageComboBox.Location = new System.Drawing.Point(105, 351);
            this.languageComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.Size = new System.Drawing.Size(201, 37);
            this.languageComboBox.TabIndex = 5;
            this.languageComboBox.Text = "Select Language";
            this.languageComboBox.SelectedIndexChanged += new System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.welcomeLabel);
            this.homePanel.Controls.Add(this.languageComboBox);
            this.homePanel.Controls.Add(this.welcomeTextLabel);
            this.homePanel.Controls.Add(this.selectLanguageLabel);
            this.homePanel.Location = new System.Drawing.Point(0, 0);
            this.homePanel.Margin = new System.Windows.Forms.Padding(2);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(972, 540);
            this.homePanel.TabIndex = 6;
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.editLabel);
            this.editPanel.Location = new System.Drawing.Point(0, 0);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(972, 540);
            this.editPanel.TabIndex = 6;
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editLabel.Location = new System.Drawing.Point(122, 69);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(296, 55);
            this.editLabel.TabIndex = 0;
            this.editLabel.Text = "EDIT LABEL";
            // 
            // createPanel
            // 
            this.createPanel.Controls.Add(this.createLabel);
            this.createPanel.Location = new System.Drawing.Point(0, 0);
            this.createPanel.Name = "createPanel";
            this.createPanel.Size = new System.Drawing.Size(1037, 599);
            this.createPanel.TabIndex = 7;
            // 
            // createLabel
            // 
            this.createLabel.AutoSize = true;
            this.createLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.createLabel.Location = new System.Drawing.Point(122, 69);
            this.createLabel.Name = "createLabel";
            this.createLabel.Size = new System.Drawing.Size(332, 55);
            this.createLabel.TabIndex = 0;
            this.createLabel.Text = "Create LABEL";
            // 
            // dinamicPanel
            // 
            this.dinamicPanel.Controls.Add(this.homePanel);
            this.dinamicPanel.Controls.Add(this.editPanel);
            this.dinamicPanel.Controls.Add(this.createPanel);
            this.dinamicPanel.Location = new System.Drawing.Point(211, 35);
            this.dinamicPanel.Name = "dinamicPanel";
            this.dinamicPanel.Size = new System.Drawing.Size(972, 542);
            this.dinamicPanel.TabIndex = 7;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1183, 577);
            this.Controls.Add(this.dinamicPanel);
            this.Controls.Add(this.upperPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.createPanel.ResumeLayout(false);
            this.createPanel.PerformLayout();
            this.dinamicPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Panel upperPanel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label welcomeTextLabel;
        private System.Windows.Forms.Label selectLanguageLabel;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Label editLabel;
        private System.Windows.Forms.Panel createPanel;
        private System.Windows.Forms.Label createLabel;
        private System.Windows.Forms.Panel dinamicPanel;
    }
}

