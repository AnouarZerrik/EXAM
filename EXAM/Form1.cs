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
        public int val;
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
            ajoute_btn.Enabled = true;
            delete_btn.Enabled = true;
            anuller_btn.Enabled = false;
            validate_btn.Enabled = false;
            idexam_exam.Enabled = false;
            debut_txt.Enabled = false;
            fin_txt.Enabled = false;
            idqsm_txt.Enabled = false;
            idouverte_txt.Enabled = false;

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

        private void ajoute_btn_Click(object sender, EventArgs e)
        {
            val = 1;
            QO.Enabled = false;
            QSM.Enabled = false;
            ajoute_btn.Enabled = false;
            delete_btn.Enabled = false;
            anuller_btn.Enabled = true;
            validate_btn.Enabled = true;
            idexam_exam.Enabled = true;
            debut_txt.Enabled = true;
            fin_txt.Enabled = true;
            idqsm_txt.Enabled = true;
            idouverte_txt.Enabled = true;


        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            val = 2;
            QO.Enabled = false;
            QSM.Enabled = false;
            ajoute_btn.Enabled = false;
            delete_btn.Enabled = false;
            anuller_btn.Enabled = true;
            validate_btn.Enabled = true;
            idexam_exam.Enabled = true;
            debut_txt.Enabled = false;
            fin_txt.Enabled = false;
            idqsm_txt.Enabled = false;
            idouverte_txt.Enabled = false;
        }

        private void anuller_btn_Click(object sender, EventArgs e)
        {
            ajoute_btn.Enabled = true;
            delete_btn.Enabled = true;
            anuller_btn.Enabled = false;
            validate_btn.Enabled = false;
            idexam_exam.Enabled = false;
            debut_txt.Enabled = false;
            fin_txt.Enabled = false;
            idqsm_txt.Enabled = false;
            idouverte_txt.Enabled = false;
        }

        private void validate_btn_Click(object sender, EventArgs e)
        {
            if (val == 1)
            {
                cnx.Open();
                cmd.Connection = cnx;
                if (idexam_exam.Text == "" || debut_txt.Text == "" || fin_txt.Text == "")
                { MessageBox.Show("enter the inputs"); }
                else
                {
                    cmd.CommandText = "insert into EXAM1(id_exam,date_debut,date_fin,id_qsm,id_QuestionOuverte) values('" + idexam_exam.Text + "','" + debut_txt.Text + "','" + fin_txt.Text + "','" + idqsm_txt.Text + "','" + idouverte_txt.Text + "') ";
                    cmd.ExecuteNonQuery();
                    ajoute_btn.Enabled = true;
                    delete_btn.Enabled = true;
                    anuller_btn.Enabled = false;
                    validate_btn.Enabled = false;
                    idexam_exam.Enabled = false;
                    debut_txt.Enabled = false;
                    fin_txt.Enabled = false;
                    idqsm_txt.Enabled = false;
                    idouverte_txt.Enabled = false;
                    cnx.Close();

                }
            }
            if (val == 2)
            {
                cnx.Open();
                cmd.Connection = cnx;
                if (idexam_exam.Text == "")
                { MessageBox.Show("enter the inputs"); }
                else
                {
                    cmd.CommandText = "delete from EXAM1 where id_exam='" + idexam_exam.Text + "' ";
                    cmd.ExecuteNonQuery();
                    ajoute_btn.Enabled = true;
                    delete_btn.Enabled = true;
                    anuller_btn.Enabled = false;
                    validate_btn.Enabled = false;
                    idexam_exam.Enabled = false;
                    debut_txt.Enabled = false;
                    fin_txt.Enabled = false;
                    idqsm_txt.Enabled = false;
                    idouverte_txt.Enabled = false;
                    cnx.Close();
                }
            }
        }
    }
}