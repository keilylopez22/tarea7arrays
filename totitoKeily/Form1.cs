namespace totitoKeily
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int turno = 1;
        private void escribiendo(Button a)
        {
            if (a.Text== "")
            {
                if (turno == 1)
                {
                    a.Text = "x";
                    turno = 2;
                }
                else
                    if (turno == 2)
                    {
                    a.Text = "o";
                    turno = 1;
                    }
            }
            else 
                if(a.Text != "")
            {
                MessageBox.Show("Hacer seleccion de otro cuadro");  
            }
            
        }
        
        private void btn1_Click(object sender, EventArgs e)
        {
            escribiendo(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            escribiendo(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            escribiendo(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            escribiendo(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            escribiendo(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            escribiendo(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            escribiendo(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            escribiendo(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            escribiendo(btn9);
        }
    }
}
