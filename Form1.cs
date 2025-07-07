using System.Drawing;

namespace soru4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cns = "";
            string snf = "";
            if (radioButton1.Checked)
            { cns = "Kadýn"; }
            else if (radioButton2.Checked)
            { cns = "Erkek"; }

            if (radioButton3.Checked)
            { snf = "Hazýrlýk"; }
            else if (radioButton4.Checked)
            { snf = "1.Sýnýf"; }
            else if (radioButton5.Checked)
            { snf = "2.Sýnýf"; }
            else if (radioButton6.Checked)
            { snf = "3.Sýnýf"; }
            else { snf = "4.Sýnýf"; }

            MessageBox.Show( cns + snf);


        }

    }
}

