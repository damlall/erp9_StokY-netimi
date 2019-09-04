using Sy.Business.Repository;
using Sy.Core.ComplexType;
using Sy.Core.Entities;
using Sy.Forms.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sy.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            gbGiris.Visible = true;
            lblGirisBilgi.Visible = false;

        }

        private void btnGrisiYap_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.ShowDialog();
            if (StockSettings.UserInfo == null)
            {
                gbGiris.Visible = true;
                lblGirisBilgi.Visible = false;
            }
            else
            {
                gbGiris.Visible = false;
                lblGirisBilgi.Visible = true;
                lblGirisBilgi.Text = StockSettings.UserInfo.Display;
            }

        }

        private void btnKayıtOl_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.ShowDialog();
        }
    }
}
