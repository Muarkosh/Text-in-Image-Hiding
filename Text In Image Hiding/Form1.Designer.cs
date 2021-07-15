using System.Windows.Forms;

namespace Text_In_Image_Hiding
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
            this.openFileDialogForm = new System.Windows.Forms.OpenFileDialog();
            this.Load_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogForm
            // 
            this.openFileDialogForm.FileName = "openFileDialogForm";
            // 
            // Load_button
            // 
            this.Load_button.Location = new System.Drawing.Point(608, 46);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(115, 32);
            this.Load_button.TabIndex = 0;
            this.Load_button.Text = "Load image";
            this.Load_button.UseVisualStyleBackColor = true;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(608, 352);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(115, 32);
            this.Save_button.TabIndex = 1;
            this.Save_button.Text = "Save as .bmp";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(42, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Load_button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.OpenFileDialog openFileDialogForm;
        public System.Windows.Forms.Button Load_button;
        public System.Windows.Forms.Button Save_button;
        private PictureBox pictureBox1;
    }
}

