using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_In_Image_Hiding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class OpenFileDialogForm : Form1
        {
            public OpenFileDialogForm()
            {
                openFileDialogForm = new OpenFileDialog()
                {
                    FileName = "Select an image file",
                    Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*",
                    Title = "Open image file"
                };
                Load_button.Click += new EventHandler(base.Load_button_Click);
                Controls.Add(Load_button);
            }
            /*
            private void Load_button_Click(object sender, EventArgs e)
            {
                if (openFileDialogForm.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var filePath = openFileDialogForm.FileName;
                        Image image = Image.FromFile(filePath);
                        object obj = image;
                        using (Stream str = openFileDialogForm.OpenFile())
                        {
                            Point ulCorner = new Point(100, 100);
                            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawImagePoint);
                            Graphics.DrawImage(image, ulCorner);
                            this.DrawImagePoint;
                            //Process.Start("notepad.exe", filePath);
                        }
                    }
                    catch (SecurityException ex)
                    {
                        MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                        $"Details:\n\n{ex.StackTrace}");
                    }
                }
            }
            */
            /*
            public void DrawImagePoint(object sender, PaintEventArgs e)
            {
                // Create image.
                Image newImage = Image.FromFile("SampImag.jpg");

                // Create Point for upper-left corner of image.
                Point ulCorner = new Point(100, 100);

                // Draw image to screen.
                e.Graphics.DrawImage(newImage, ulCorner);
            }
            */
        }


        public void Load_button_Click(object sender, EventArgs e)
        {
            //Program.OpenFileDialogForm p = new Program.OpenFileDialogForm();
            if (openFileDialogForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialogForm.FileName;
                    Image image = Image.FromFile(filePath);
                    object obj = image;
                    using (Stream str = openFileDialogForm.OpenFile())
                    {
                        Point ulCorner = new Point(100, 100);
                        pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
                        //Graphics.DrawImage(image, ulCorner);
                        //this.DrawImagePoint;
                        //Process.Start("notepad.exe", filePath);
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }
        }
        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(typeof(Button), "retriever-puppy.jpg");
            bmp1.Save("retriever-puppy.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
        }
    }
}
