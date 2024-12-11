using Cseresznye_DR0UUU_FORM.LibraryModels;
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
    public partial class UserControl2 : UserControl
    {

        
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            LibraryDatabaseContext context = new LibraryDatabaseContext();

            var x = from y in context.Kolcsonzes
                    select new
                    {
                        KolcsonzesId = y.KolcsonzesId,
                        Tag = y.Tag.Nev,
                        Konyv = y.Konyv.Cim,
                        KolcsonzesDatum = y.KolcsonzesDatum,
                        Statusz = y.Statusz
                    };

            kolcsonzeBindingSource.DataSource = x.ToList();
        }
    }
}
