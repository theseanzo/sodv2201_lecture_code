using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lecture_Forms
{
    class ButtonListener
    {
        Form1 form;
        public ButtonListener(Form1 _form)
        {
            this.form = _form;
            this.form.button1.MouseClick += ButtonClicked;
        }
        public void ButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine("We pressed the button");
        }
    }
}
