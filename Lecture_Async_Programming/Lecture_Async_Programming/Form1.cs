using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Lecture_Async_Programming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void taskButton_MouseClick(object sender, MouseEventArgs e)
        {

            var myTask = new Task(this.IntroTask);
            //myTask.Start();
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine("Waiting");
            //}
          //  PrimeExample();

        }
        private void IntroTask()
        {
            Console.WriteLine("Hello world");
        }

        private void SinLookUp()
        {
            Dictionary<double, double> sinLookUp = new Dictionary<double, double>();
            for (double i = 0.0; i <= 2.0 * Math.PI; i += 0.01)
                sinLookUp.Add(i, Math.Sin(i));
            this.taskResult.BeginInvoke(new Action(() => this.taskResult.Text += "Finished sin look up. "));

        }
        private void PrimeExample()
        {
            var nextPrime = Task.Run(() => LectureMath.NextPrime(1000000000));
            var awaiter = nextPrime.GetAwaiter();
            awaiter.OnCompleted(() =>
            {
                long result = awaiter.GetResult();
                this.taskResult.BeginInvoke(new Action(() => this.taskResult.Text += "Next Prime is " + result));
            });
        }
        private void PrimeExampleContinueWith()
        {
            var nextPrime = new Task<long>(() => LectureMath.NextPrime(1000000000));
            nextPrime.ContinueWith(antecedent =>
            {
                long result = antecedent.Result;
                this.taskResult.BeginInvoke(new Action(() => this.taskResult.Text += "Next Prime is " + result));
            });
            nextPrime.Start();
        }
        private void ReturnResultTask()
        {

        }

        private void shinyButton_Click(object sender, EventArgs e)
        {
            this.shinyButton.BeginInvoke(new Action(() =>
            {
                Random r = new Random();
                this.shinyButton.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255), r.Next(255));// = (byte)(r.Next() % 255); 
            }));
        }
    }
}
