using hakaton.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hakaton
{
    public partial class ManeForm : Form
    {
        private int currentRowIndex = 0;
        private string selectedType = "All";
        private string selectedMaterial = "All";

        public ManeForm()
        {
            InitializeComponent();
        }

        private void LoadComboBox(ComboBox typeComboBox, ComboBox materialComboBox)
        {
            DataBase.LoadKatalogName(typeComboBox);
            DataBase.LoadKatalogSaller(materialComboBox);
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btmax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btmax.Visible = false;
            btmaxed.Location = btmax.Location;
            btmaxed.Visible = true;
        }

        private void btmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btmaxed_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btmaxed.Visible = false;
            btmax.Visible = true;
        }

        private void ManeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hackathonDataSet.Tovar". При необходимости она может быть перемещена или удалена.
            this.tovarTableAdapter.Fill(this.hackathonDataSet.Tovar);

        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tovarBindingSource.Filter = $"Name Like '%{nameTB.Text}%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка поиска товара:" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   
        private void sallerTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tovarBindingSource.Filter = $"Saller Like '%{sallerTB.Text}%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка поиска товара:" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAnaliz_Click(object sender, EventArgs e)
        {

        }
    }
}
