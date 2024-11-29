using System;
using System.Windows.Forms;

namespace Tourist
{
    public partial class ENTER : Form
    {
        public ENTER()
        {
            InitializeComponent();
        }

        private void ENTER_Load(object sender, EventArgs e)
        {

        }

        private void ENTERBUTTON_Click(object sender, EventArgs e)
        {
            if (NAMEENTER.Text == "Admin" && PASSWORDENTER.Text == "1234")
            {
                MessageBox.Show("Добро пожаловать", "Успешно");
                Hide();
                PROFRAMTOURIST pROFRAMTOURIST = new PROFRAMTOURIST();
                pROFRAMTOURIST.Show();
            }
            else
            {
                MessageBox.Show("Вы ввели неправильный логин или пароль", "Ошибка авторизации");
            }
        }
        private void PASSWORDENTER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void PASSWORDENTER_TextChanged(object sender, EventArgs e)
        {

        }

        private void NAMEENTER_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
