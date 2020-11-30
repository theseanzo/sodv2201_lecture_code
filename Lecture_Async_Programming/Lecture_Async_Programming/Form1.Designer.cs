namespace Lecture_Async_Programming
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
            this.taskButton = new System.Windows.Forms.Button();
            this.taskResult = new System.Windows.Forms.TextBox();
            this.shinyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskButton
            // 
            this.taskButton.Location = new System.Drawing.Point(39, 14);
            this.taskButton.Name = "taskButton";
            this.taskButton.Size = new System.Drawing.Size(104, 38);
            this.taskButton.TabIndex = 0;
            this.taskButton.Text = "Intro Task";
            this.taskButton.UseVisualStyleBackColor = true;
            this.taskButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.taskButton_MouseClick);
            // 
            // taskResult
            // 
            this.taskResult.Location = new System.Drawing.Point(39, 72);
            this.taskResult.Multiline = true;
            this.taskResult.Name = "taskResult";
            this.taskResult.ReadOnly = true;
            this.taskResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.taskResult.Size = new System.Drawing.Size(104, 154);
            this.taskResult.TabIndex = 1;
            // 
            // shinyButton
            // 
            this.shinyButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.shinyButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.shinyButton.Location = new System.Drawing.Point(387, 45);
            this.shinyButton.Name = "shinyButton";
            this.shinyButton.Size = new System.Drawing.Size(160, 124);
            this.shinyButton.TabIndex = 2;
            this.shinyButton.UseVisualStyleBackColor = false;
            this.shinyButton.Click += new System.EventHandler(this.shinyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shinyButton);
            this.Controls.Add(this.taskResult);
            this.Controls.Add(this.taskButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button taskButton;
        private System.Windows.Forms.TextBox taskResult;
        private System.Windows.Forms.Button shinyButton;
    }
}

