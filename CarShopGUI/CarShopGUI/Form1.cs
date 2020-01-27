using System;
using System.Windows.Forms;

namespace CarShopGUI
{
    public partial class MainForm : Form
    {
        Store myStore = new Store();
        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateACar_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            c.Make = txtMake.Text;
            c.Model = txtModel.Text;
            c.Price = Convert.ToDecimal(txtPrice.Text);
            MessageBox.Show($"{c}");
            myStore.CarList.Add(c);
            carInventoryBindingSource.ResetBindings(false);
            txtMake.Text = " ";
            txtModel.Text = " ";
            txtPrice.Text = " ";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            carInventoryBindingSource.DataSource = myStore.CarList;
            lstInventory.DataSource = carInventoryBindingSource;
            lstInventory.DisplayMember = ToString();

        }
    }
}
