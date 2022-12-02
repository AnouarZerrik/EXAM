using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EXAM
{
    public partial class QSM : Form
    {
        public QSM()
        {
            InitializeComponent();
        }


        static string chaine = @"Data Source=localhost;Initial Catalog=EXAM;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);


        private void QSM_Load(object sender, EventArgs e)
        {
            Anuller_btn.Enabled= false;
            validate_btn.Enabled= false;
            id_qsm_txt.Enabled=false;
            question_txt.Enabled = false;
            option1_txt.Enabled = false;
            option2_txt.Enabled = false;
            option3_txt.Enabled = false;
            optionC_txt.Enabled = false;
        }

        private void Ajoute_btn_Click(object sender, EventArgs e)
        {
            validate_btn.Enabled =true;
            Ajoute_btn.Enabled =false;
            Anuller_btn.Enabled = true;
            id_qsm_txt.Enabled = true;
            question_txt.Enabled = true;
            option1_txt.Enabled = true;
            option2_txt.Enabled = true;
            option3_txt.Enabled = true;
            optionC_txt.Enabled = true;

        }

        private void validate_btn_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into QSM(id_qsm,question,option1,option2 ,option3,option_corecte) values('" + id_qsm_txt.Text + "','" + question_txt.Text + "','" + option1_txt.Text + "','" + option2_txt.Text + "','" + option3_txt.Text + "','" + optionC_txt.Text + "') ";
            cmd.ExecuteNonQuery();

            id_qsm_txt.DataBindings.Clear();
            question_txt.DataBindings.Clear();
            option1_txt.DataBindings.Clear();
            option2_txt.DataBindings.Clear();
            option3_txt.DataBindings.Clear();
            optionC_txt.DataBindings.Clear();
            Ajoute_btn.Enabled = true;
            Anuller_btn.Enabled = false;
            validate_btn.Enabled = false;
            id_qsm_txt.Enabled = false;
            question_txt.Enabled = false;
            option1_txt.Enabled = false;
            option2_txt.Enabled = false;
            option3_txt.Enabled = false;
            optionC_txt.Enabled = false;
            cnx.Close();
        }

        private void Anuller_btn_Click(object sender, EventArgs e)
        {
            Ajoute_btn.Enabled = true; 
            Anuller_btn.Enabled=false;
            validate_btn.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }
    }
}
