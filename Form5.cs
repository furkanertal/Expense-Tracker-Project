using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeHazırlık1
{
    public partial class FormKaydet : Form
    {
        int? id;
        public FormKaydet(int? Id = null)
        {
            InitializeComponent();
            if (Id != null)
            {
                this.id = Id;
            }
        }

        private void FormKaydet_Load(object sender, EventArgs e)
        {

        }
    }
}
