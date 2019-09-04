using Sy.Business.Repository;
using Sy.Core.Entities;
using Sy.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sy.Core.ViewModels;
using Sy.Core.Enums;

namespace Sy.Forms.Auth
{
    public partial class RegisterForm : Form
    {
        private readonly Core.Abstracts.IRepository<Client, int> _clientRepository;
        public RegisterForm()
        {
            InitializeComponent();
            _clientRepository = new Repository<Client, int>();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            var model = new RegisterViewModel()
            {
                Email = txtEmail.Text,
                Name = txtAd.Text,
                Surname = txtSoyad.Text,
                Password = txtSıfre.Text

            };
            // email var mı kontrol edelim...
            var kontrol = _clientRepository.Query(x => x.Email == model.Email).Any();

            if (kontrol)
            {
                MessageBox.Show("Bu email adresi kullanılmaktadır!");
                return; // bu metodun dışınaa çıkmamızı ve aşağıdaki kodları görmeyi engeller
            }

            //benzersiz email kontrolünden sonra kişiyi kaydedelim...

            var adminMi =! _clientRepository.Query().Any();
           
            _clientRepository.Insert(new Client()
            {

                Email = model.Email,
                Name = model.Name,
                Surname = model.Surname,
                Password = model.Password,
                ApplicationRole = adminMi ? ApplicationRole.Customer : ApplicationRole.Admin

            });
            MessageBox.Show($"Kayıt işleminiz başarılıdır.\n {model.Name} {model.Surname}");

            this.Close(); //bulunduğu classı işaret eder 
            //base kalıtım aldığımız classı işaret eder içindeki consructor ile birlikte



        }
    }
}
