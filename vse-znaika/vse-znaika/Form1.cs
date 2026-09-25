namespace vse_znaika
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
            Form2 f2 = new Form2();
            f2.Owner = this;   // <-- запоминаем кто владелец
            f2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();

            // Подписываемся на событие закрытия второго окна,
            // чтобы снова показать главное
            newForm.FormClosed += (s, args) => this.Show();

            // Скрываем главное окно
            this.Hide();

            // Открываем второе окно
            newForm.Show();
        }
    }
}
