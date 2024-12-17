using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjeHazırlık1
{
    public partial class FormDatabase : Form
    {
        public FormDatabase()
        {
            InitializeComponent();

        }

        private void FormDatabase_Load(object sender, EventArgs e)
        {

        }

        void Listele()
        {
            string sql = "SELECT * from Statistics";
            dataGridView1.DataSource = CRUD.Listele(sql);
        }

        private void ButtonDuzenle_Click(object sender, EventArgs e)
        {
            int seciliid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            FormKaydet form = new FormKaydet(seciliid);
            form.ShowDialog();

            if (radioButtonGelir.Checked = true)
            {

            }
        }



        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void ButtonGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void ButtonEkle_Click(object sender, EventArgs e)
        {
            FormKaydet form = new FormKaydet();
            form.ShowDialog();
        }

        private void ButtonTamam_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain();
            formMain.Show();
            this.Hide();
        }

        private void comboBoxGelir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonGelir_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    public class Baglan
    {
        public static SQLiteConnection connection = new SQLiteConnection("Data source=.\\information.db;Version=3");
    }

    public class CRUD
    {
        public static DataTable dt;
        public static DataTable Listele(string sql)
        {
            dt = new DataTable();
            SQLiteDataAdapter adtr = new SQLiteDataAdapter(sql, Baglan.connection);
            adtr.Fill(dt);
            return dt;
        }

        

    }


}
