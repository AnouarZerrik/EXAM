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
using System.Data.Common;


namespace EXAM
{
    public partial class QSM : Form
    {
        public int val;
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

            cbx1();
        }

        private void Ajoute_btn_Click(object sender, EventArgs e)
        {
            val = 1;
            validate_btn.Enabled =true;
            Ajoute_btn.Enabled =false;
            Anuller_btn.Enabled = true;
            id_qsm_txt.Enabled = true;
            question_txt.Enabled = true;
            option1_txt.Enabled = true;
            option2_txt.Enabled = true;
            option3_txt.Enabled = true;
            optionC_txt.Enabled = true;
            id_qsm_txt.Clear();
            question_txt.Clear();
            option1_txt.Clear();
            option2_txt.Clear();
            option3_txt.Clear();
            optionC_txt.Clear();

        }

        private void validate_btn_Click(object sender, EventArgs e)
        {

            if (val == 1)
            {
                cnx.Open();
                cmd.Connection = cnx;
                if (id_qsm_txt.Text == "" || question_txt.Text == "" || option1_txt.Text == "" || option2_txt.Text == "" || option3_txt.Text == "" || optionC_txt.Text == "")
                { MessageBox.Show("enter the inputs"); }
                else
                {
                    cmd.CommandText = "insert into QSM(id_qsm,question,option1,option2 ,option3,option_corecte) values('" + id_qsm_txt.Text + "','" + question_txt.Text + "','" + option1_txt.Text + "','" + option2_txt.Text + "','" + option3_txt.Text + "','" + optionC_txt.Text + "') ";
                    cmd.ExecuteNonQuery();

                    Ajoute_btn.Enabled = true;
                    delete_btn.Enabled = true;
                    Anuller_btn.Enabled = false;
                    validate_btn.Enabled = false;
                    id_qsm_txt.Enabled = false;
                    question_txt.Enabled = false;
                    option1_txt.Enabled = false;
                    option2_txt.Enabled = false;
                    option3_txt.Enabled = false;
                    optionC_txt.Enabled = false;
                    cnx.Close();
                    id_qsm_txt.Clear();
                    question_txt.Clear();
                    option1_txt.Clear();
                    option2_txt.Clear();
                    option3_txt.Clear();
                    optionC_txt.Clear();
                }
            }

            if (val == 2)
            {
                cnx.Open();
                cmd.Connection = cnx;
                if (id_qsm_txt.Text == "")
                { MessageBox.Show("enter the inputs"); }
                else
                {
                    cmd.CommandText = "delete from QSM where id_qsm='" + id_qsm_txt.Text + "' ";
                    cmd.ExecuteNonQuery();

                    Ajoute_btn.Enabled = true;
                    delete_btn.Enabled = true;
                    update_btn.Enabled = true;
                    Anuller_btn.Enabled = false;
                    validate_btn.Enabled = false;
                    id_qsm_txt.Enabled = false;
                    question_txt.Enabled = false;
                    option1_txt.Enabled = false;
                    option2_txt.Enabled = false;
                    option3_txt.Enabled = false;
                    optionC_txt.Enabled = false;


                }
                cnx.Close();
                id_qsm_txt.Clear();
            }
            if (val == 3)
            {
                cnx.Open();
                cmd.Connection = cnx;
                if (id_qsm_txt.Text == "" || question_txt.Text == "" || option1_txt.Text == "" || option2_txt.Text == "" || option3_txt.Text == "" || optionC_txt.Text == "")
                { MessageBox.Show("enter the inputs"); }
                else
                {
                    cmd.CommandText = "update QSM set question ='" + question_txt.Text + "', option1 ='" + option1_txt.Text + "' , option2 ='" + option2_txt.Text + "', option3 ='" + option3_txt.Text + "', option_corecte ='" + optionC_txt.Text + "' where id_qsm='" + id_qsm_txt.Text + "' ";
                    cmd.ExecuteNonQuery();

                    Ajoute_btn.Enabled = true;
                    delete_btn.Enabled = true;
                    update_btn.Enabled = true;
                    Anuller_btn.Enabled = false;
                    validate_btn.Enabled = false;
                    id_qsm_txt.Enabled = false;
                    question_txt.Enabled = false;
                    option1_txt.Enabled = false;
                    option2_txt.Enabled = false;
                    option3_txt.Enabled = false;
                    optionC_txt.Enabled = false;
                  

                }
                cnx.Close(); 
                id_qsm_txt.Clear();
                question_txt.Clear();
                option1_txt.Clear();
                option2_txt.Clear();
                option3_txt.Clear();
                optionC_txt.Clear();
            }
        }

        private void Anuller_btn_Click(object sender, EventArgs e)
        {
            Ajoute_btn.Enabled = true;
            delete_btn.Enabled = true;
            update_btn.Enabled =true;
            Anuller_btn.Enabled=false;
            validate_btn.Enabled = false;
            id_qsm_txt.Clear();
            question_txt.Clear();
            option1_txt.Clear();
            option2_txt.Clear();
            option3_txt.Clear();
            optionC_txt.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            val = 2;
            validate_btn.Enabled = true;
            delete_btn.Enabled = false;
            Ajoute_btn.Enabled = false;
            update_btn.Enabled = false;
            Anuller_btn.Enabled = true;
            id_qsm_txt.Enabled = true;
            question_txt.Enabled = false;
            option1_txt.Enabled = false;
            option2_txt.Enabled = false;
            option3_txt.Enabled = false;
            optionC_txt.Enabled = false;
            id_qsm_txt.Clear();
            question_txt.Clear();
            option1_txt.Clear();
            option2_txt.Clear();
            option3_txt.Clear();
            optionC_txt.Clear();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            val = 3;
            validate_btn.Enabled = true;
            delete_btn.Enabled = false;
            Ajoute_btn.Enabled = false;
            update_btn.Enabled = false;
            Anuller_btn.Enabled = true;
            id_qsm_txt.Enabled = true;
            question_txt.Enabled = true;
            option1_txt.Enabled = true;
            option2_txt.Enabled = true;
            option3_txt.Enabled = true;
            optionC_txt.Enabled = true;
            id_qsm_txt.Clear();
            question_txt.Clear();
            option1_txt.Clear();
            option2_txt.Clear();
            option3_txt.Clear();
            optionC_txt.Clear();
        }

        public void cbx1()
        {
            cnx.Open();
            cmd.CommandText = "select * from QSM";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbx.DataSource = dt;
            cbx.DisplayMember = "question";
            cbx.ValueMember = "id_qsm";
            id_qsm_txt.DataBindings.Clear();
            question_txt.DataBindings.Clear();
            option1_txt.DataBindings.Clear();
            option2_txt.DataBindings.Clear(); 
            option3_txt.DataBindings.Clear(); 
            optionC_txt.DataBindings.Clear();
            id_qsm_txt.DataBindings.Add("text", cbx.DataSource, "id_qsm");
            cnx.Close();
        }

        private void cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
