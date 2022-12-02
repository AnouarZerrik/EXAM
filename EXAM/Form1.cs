using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EXAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string chaine = @"Data Source=localhost;Initial Catalog=EXAM;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbx1();
            cbx2();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void QSM_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            QSM q = new QSM();
            q.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuestionOuverte q = new QuestionOuverte();
            q.Show();
        }

        private void cbx_ouverte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void cbx1()
        {
            cnx.Open();
            cmd.CommandText = "select * from QSM";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbx_qsm.DataSource = dt;
            cbx_qsm.DisplayMember = "question";
            cbx_qsm.ValueMember = "id_qsm";
            idqsm_txt.DataBindings.Add("text", cbx_qsm.DataSource, "id_qsm");
            cnx.Close();
        }
        public void cbx2()
        {
            cnx.Open();
            cmd.CommandText = "select * from question_ouverte";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbx_ouverte.DataSource = dt;
            cbx_ouverte.DisplayMember = "question";
            cbx_ouverte.ValueMember = "id_QuestionOuvert";
            idouverte_txt.DataBindings.Add("text", cbx_ouverte.DataSource, "id_QuestionOuvert");
            cnx.Close();
        }
    }
}