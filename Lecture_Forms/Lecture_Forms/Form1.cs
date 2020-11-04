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
            ButtonListener buttonListener = new ButtonListener(this);
        }
        private void button_MouseEnter(object sender, EventArgs e)
        {
            if (!(sender is Button))
                return;
            ((Button)sender).BackColor = Color.Red;
            helloLabel.Hide();
        }
        private void button_MouseLeave(object sender, EventArgs e)
        {
            if (!(sender is Button))
                return;
            ((Button)sender).BackColor = Color.CornflowerBlue;
            helloLabel.Show();

        }
        private void testOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            this.openFileTextBox.Text = fileDialog.FileName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dogForm = new PopupForm();
            dogForm.Show();
        }
    }
}
