namespace Lecture_Forms
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
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.testOpenFile = new System.Windows.Forms.Button();
            this.openFileTextBox = new System.Windows.Forms.TextBox();
            this.testButton = new System.Windows.Forms.Button();
            this.helloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hello, World";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(271, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // testOpenFile
            // 
            this.testOpenFile.Location = new System.Drawing.Point(31, 155);
            this.testOpenFile.Name = "testOpenFile";
            this.testOpenFile.Size = new System.Drawing.Size(150, 63);
            this.testOpenFile.TabIndex = 3;
            this.testOpenFile.Text = "Open File";
            this.testOpenFile.UseVisualStyleBackColor = true;
            this.testOpenFile.Click += new System.EventHandler(this.testOpenFile_Click);
            // 
            // openFileTextBox
            // 
            this.openFileTextBox.Location = new System.Drawing.Point(31, 237);
            this.openFileTextBox.Name = "openFileTextBox";
            this.openFileTextBox.Size = new System.Drawing.Size(150, 20);
            this.openFileTextBox.TabIndex = 4;
            // 
            // testButton
            // 
            this.testButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.testButton.Location = new System.Drawing.Point(299, 88);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(145, 59);
            this.testButton.TabIndex = 5;
            this.testButton.Text = "button2";
            this.testButton.UseVisualStyleBackColor = false;
            this.testButton.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.testButton.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // helloLabel
            // 
            this.helloLabel.AutoSize = true;
            this.helloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloLabel.Location = new System.Drawing.Point(299, 194);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Size = new System.Drawing.Size(324, 97);
            this.helloLabel.TabIndex = 6;
            this.helloLabel.Text = "HELLO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.helloLabel);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.openFileTextBox);
            this.Controls.Add(this.testOpenFile);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button testOpenFile;
        private System.Windows.Forms.TextBox openFileTextBox;
        public System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label helloLabel;
    }
}

