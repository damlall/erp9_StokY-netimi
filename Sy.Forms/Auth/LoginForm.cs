using Sy.Business.Repository;
using Sy.Core.Abstracts;
using Sy.Core.ComplexType;
using Sy.Core.Entities;
using Sy.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sy.Forms.Auth
{
    public partial class LoginForm : Form
    {
        private IRepository<Client, int> _clientRepository;

        public LoginForm()
        {
            InitializeComponent();
            _clientRepository = new Repository<Client, int>();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var model = new LoginViewModels()
            {
                Email = txtEmail.Text,
                Password = txtEmail.Text
            };

            var user = _clientRepository
                .Query(x => x.Email == model.Email && x.Password == model.Password).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Email veya şifre hatalıdır!");
                return;
            }

            MessageBox.Show($"Hoşgeldin {user.Name} {user.Surname}"); //string format dolar
            StockSettings.UserInfo = new UserInfoViewModel()
            {
                Id = user.Id,
                Email = user.Name,
                Name = user.Surname,
                ApplicationRole = user.ApplicationRole

            };

            this.Close();
        }
    }
}
