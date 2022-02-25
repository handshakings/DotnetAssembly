namespace DotnetAssembly
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.LoadExeInMemory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LoadExeInMemory
            // 
            this.LoadExeInMemory.Location = new System.Drawing.Point(47, 31);
            this.LoadExeInMemory.Name = "LoadExeInMemory";
            this.LoadExeInMemory.Size = new System.Drawing.Size(182, 23);
            this.LoadExeInMemory.TabIndex = 0;
            this.LoadExeInMemory.Text = "LoadExeInMemory";
            this.LoadExeInMemory.UseVisualStyleBackColor = true;
            this.LoadExeInMemory.Click += new System.EventHandler(this.LoadExeInMemory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 266);
            this.Controls.Add(this.LoadExeInMemory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button LoadExeInMemory;
    }
}