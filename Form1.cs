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
            { cns = "Kad�n"; }
            else if (radioButton2.Checked)
            { cns = "Erkek"; }

            if (radioButton3.Checked)
            { snf = "Haz�rl�k"; }
            else if (radioButton4.Checked)
            { snf = "1.S�n�f"; }
            else if (radioButton5.Checked)
            { snf = "2.S�n�f"; }
            else if (radioButton6.Checked)
            { snf = "3.S�n�f"; }
            else { snf = "4.S�n�f"; }

            MessageBox.Show( cns + snf);


        }

    }
}

