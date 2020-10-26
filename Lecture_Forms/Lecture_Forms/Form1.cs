using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture_Forms
{
    public partial class Form1 : Form
    {
        PopupForm dogForm;
        public Form1()
        {
            InitializeComponent();
            dogForm = new PopupForm();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.CornflowerBlue;
        }

        private void testOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            this.openFileTextBox.Text = fileDialog.FileName;

        }
    }
}
