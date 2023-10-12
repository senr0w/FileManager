using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager
{
    public partial class Form1 : Form
    {
        private string currentLocation;
        private string stringcurrentLocation;

        public Form1()
        {
            InitializeComponent();
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Desktop_Click(object sender, EventArgs e)
        {

            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        private void button_Documents_Click(object sender, EventArgs e)
        {
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        }

        private void button_Pictures_Click(object sender, EventArgs e)
        {
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
        }

        private void button_Music_Click(object sender, EventArgs e)
        {
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
        }

        private void button_Video_Click(object sender, EventArgs e)
        {
            DisplayFiles(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos)); 
        }
        private void DisplayFiles(string filePath)
        {
            currentLocation = filePath;
            stringcurrentLocation = "";
            panel_FilesList.Controls.Clear();
            string[] filesList = Directory.GetDirectories(filePath).Concat(Directory.GetFiles(filePath)).ToArray();
            for (int i = 0; i < filesList.Length - 1; i++)
            {
                bool isHidden = ((File.GetAttributes(filesList[i]) & FileAttributes.Hidden) == FileAttributes.Hidden);

                if (!isHidden)
                {
                    var startOfName = filesList[i].LastIndexOf("\\");
                    var fileName = filesList[i].Substring(startOfName + 1, filesList[i].Length - (startOfName + 1));

                    Button newButton = new Button();
                    newButton.Text = fileName;
                    newButton.Name = filesList[i];
                    newButton.Location = new Point(70, 70);
                    newButton.Size = new Size(200, 60);
                    newButton.TextAlign = ContentAlignment.MiddleLeft;
                    newButton.Padding = new Padding(24, 0, 0, 0);
                    newButton.BackColor = Color.Pink;
                    newButton.FlatStyle = FlatStyle.Flat;
                    panel_FilesList.Controls.Add(newButton);
                    newButton.Click += button_Click_Open;
                }
            }
        }
        
        private void button_Click_Open(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string filePath = button.Name;
            textBox1.Text = filePath;
            try
            {
                DisplayFiles(filePath);
            }
            catch (Exception ex)
            {
                var process = new System.Diagnostics.Process();
                process.StartInfo = new System.Diagnostics.ProcessStartInfo() { UseShellExecute = true, FileName = filePath };
                process.Start();
            }
          
        }

        private void Back_Click(object sender, EventArgs e)
        {
            var previousFolder = this.currentLocation.Substring(0, this.currentLocation.LastIndexOf("\\"));
            DisplayFiles(previousFolder);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void NewFolder_Click(object sender, EventArgs e)
        {
            string Location = @"C:\Users\User\Desktop\Sisprog";
            string path= System.IO.Path.Combine(Location, NewFolderText.Text);
            System.IO.Directory.CreateDirectory(path);
            MessageBox.Show("Папка сделана");
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            string Location= @"C:\Users\User\Desktop\Sisprog";
            string file = System.IO.Path.Combine(Location, NewFolderText.Text+".docx");
            if(!System.IO.File.Exists(file))
            {
                System.IO.File.Create(file);
            }
            MessageBox.Show("Намутил файлик");
        }
    }
}
