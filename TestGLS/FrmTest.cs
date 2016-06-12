using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace TestGLS
{
    public partial class FrmTest : Form
    {
        Controller.Controller controller;
        public FrmTest()
        {
            controller = new Controller.Controller();
            InitializeComponent();
        }

        private void btnInvoke_Click(object sender, EventArgs e)
        {
            controller.SearchNearestParcelShops(tbxStreet.Text,tbxZipCode.Text,tbxCountryCode.Text,Convert.ToInt32(tbxAmount.Text));
            for(int i = 0; i < controller.ReturnCount(); i++)
            {
                MessageBox.Show(controller.GetShop(i).CompanyName);
            }
            
        }
    }
}
