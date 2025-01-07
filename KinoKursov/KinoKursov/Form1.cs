namespace KinoKursov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string projekciq = comboBox1.SelectedItem.ToString();
            int red = int.Parse(textBox1.Text);
            int coloni = int.Parse(textBox2.Text);
            //Premiera - 12,00
            //Normalno - 7,50
            //Namaleno - 5,00
            double cenaNaBilet = 0;
            if (projekciq == "Premiera - 12,00")
            {
                cenaNaBilet = 12;
            }
            else if (projekciq == "Normalno - 7,50")
            {
                cenaNaBilet = 7.50;
            }
            else if (projekciq == "Namaleno - 5,00")
            {
                cenaNaBilet = 5.00;
            }
            else
            {
                MessageBox.Show("Моля, изберете валиден тип прожекция!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            double total = red * coloni * cenaNaBilet;
            label5.Text = $"Общите приходи са: {total:F2} лв.";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
