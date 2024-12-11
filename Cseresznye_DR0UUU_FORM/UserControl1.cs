using Cseresznye_DR0UUU_FORM.LibraryModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cseresznye_DR0UUU_FORM
{
    public partial class UserControl1 : UserControl
    {
        LibraryDatabaseContext context = new LibraryDatabaseContext();
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            context.Szerzos.Load();
            string search = textBox1.Text.ToLower();

            LoadData(search);
        }

        private void LoadData(string search)
        {
            var x = from y in context.Szerzos
                    where y.Nev.Contains(search)
                    select y.Nev;

            szerzoBindingSource.DataSource = x.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            context.Szerzos.Load();
            string search = textBox1.Text.ToLower();

            LoadData(search);
        }
    }
}
