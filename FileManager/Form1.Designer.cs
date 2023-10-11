namespace FileManager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Desktop = new System.Windows.Forms.Button();
            this.button_Documents = new System.Windows.Forms.Button();
            this.button_Pictures = new System.Windows.Forms.Button();
            this.button_Music = new System.Windows.Forms.Button();
            this.button_Video = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_FilesList = new System.Windows.Forms.FlowLayoutPanel();
            this.Back = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Desktop
            // 
            this.button_Desktop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Desktop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Desktop.Location = new System.Drawing.Point(3, 3);
            this.button_Desktop.Name = "button_Desktop";
            this.button_Desktop.Size = new System.Drawing.Size(111, 23);
            this.button_Desktop.TabIndex = 0;
            this.button_Desktop.Text = "Рабочий стол";
            this.button_Desktop.UseVisualStyleBackColor = true;
            this.button_Desktop.Click += new System.EventHandler(this.button_Desktop_Click);
            // 
            // button_Documents
            // 
            this.button_Documents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Documents.Location = new System.Drawing.Point(3, 32);
            this.button_Documents.Name = "button_Documents";
            this.button_Documents.Size = new System.Drawing.Size(111, 23);
            this.button_Documents.TabIndex = 1;
            this.button_Documents.Text = "Мои документы";
            this.button_Documents.UseVisualStyleBackColor = true;
            this.button_Documents.Click += new System.EventHandler(this.button_Documents_Click);
            // 
            // button_Pictures
            // 
            this.button_Pictures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Pictures.Location = new System.Drawing.Point(3, 61);
            this.button_Pictures.Name = "button_Pictures";
            this.button_Pictures.Size = new System.Drawing.Size(111, 23);
            this.button_Pictures.TabIndex = 2;
            this.button_Pictures.Text = "Картинки";
            this.button_Pictures.UseVisualStyleBackColor = true;
            this.button_Pictures.Click += new System.EventHandler(this.button_Pictures_Click);
            // 
            // button_Music
            // 
            this.button_Music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Music.Location = new System.Drawing.Point(3, 90);
            this.button_Music.Name = "button_Music";
            this.button_Music.Size = new System.Drawing.Size(111, 23);
            this.button_Music.TabIndex = 3;
            this.button_Music.Text = "Музыка";
            this.button_Music.UseVisualStyleBackColor = true;
            this.button_Music.Click += new System.EventHandler(this.button_Music_Click);
            // 
            // button_Video
            // 
            this.button_Video.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Video.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Video.Location = new System.Drawing.Point(3, 119);
            this.button_Video.Name = "button_Video";
            this.button_Video.Size = new System.Drawing.Size(111, 23);
            this.button_Video.TabIndex = 4;
            this.button_Video.Text = "Видео";
            this.button_Video.UseVisualStyleBackColor = true;
            this.button_Video.Click += new System.EventHandler(this.button_Video_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_Desktop);
            this.panel1.Controls.Add(this.button_Video);
            this.panel1.Controls.Add(this.button_Documents);
            this.panel1.Controls.Add(this.button_Music);
            this.panel1.Controls.Add(this.button_Pictures);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 152);
            this.panel1.TabIndex = 5;
            // 
            // panel_FilesList
            // 
            this.panel_FilesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_FilesList.Location = new System.Drawing.Point(149, 53);
            this.panel_FilesList.Name = "panel_FilesList";
            this.panel_FilesList.Size = new System.Drawing.Size(633, 466);
            this.panel_FilesList.TabIndex = 6;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(66, 492);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(77, 27);
            this.Back.TabIndex = 7;
            this.Back.Text = "< Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(633, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 531);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.panel_FilesList);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Desktop;
        private System.Windows.Forms.Button button_Documents;
        private System.Windows.Forms.Button button_Pictures;
        private System.Windows.Forms.Button button_Music;
        private System.Windows.Forms.Button button_Video;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panel_FilesList;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

