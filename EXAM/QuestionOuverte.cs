using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace EXAM
{
    public partial class QuestionOuverte : Form
    {
        public int val;
        public QuestionOuverte()
        {
            InitializeComponent();
        }

        static string chaine = @"Data Source=localhost;Initial Catalog=EXAM;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuestionOuverte_Load(object sender, EventArgs e)
        {
            ajoute_btn.Enabled = true;
            delete_btn.Enabled = true;
            update_btn.Enabled=true;
            id_question_txt.Enabled = false;
            question_txt.Enabled = false;
            reponse_txt.Enabled = false;
            validate_btn.Enabled = false;
            anuller_btn.Enabled = false;

            cbx2();
        }

        private void validate_btn_Click(object sender, EventArgs e)
        {
            if (val == 1)
            {
                cnx.Open();
                cmd.Connection = cnx;
                if (id_question_txt.Text == "" || question_txt.Text == "" || reponse_txt.Text == "")
                { MessageBox.Show("enter the inputs"); }
                else
                {
                    cmd.CommandText = "insert into question_ouverte(id_QuestionOuvert,question,Reponse) values('" + id_question_txt.Text + "','" + question_txt.Text + "','" + reponse_txt.Text + "') ";
                    cmd.ExecuteNonQuery();
                    ajoute_btn.Enabled = true;
                    delete_btn.Enabled = true;
                    update_btn.Enabled = true;
                    id_question_txt.Enabled = false;
                    question_txt.Enabled = false;
                    reponse_txt.Enabled = false;
                    validate_btn.Enabled = false;
                    anuller_btn.Enabled = false;
                    cnx.Close();

                }
                id_question_txt.Clear();
                question_txt.Clear();
                reponse_txt.Clear();
            }
            if (val == 2)
            {
                cnx.Open();
                cmd.Connection = cnx;
                if (id_question_txt.Text == "")
                { MessageBox.Show("enter the inputs"); }
                else
                {
                    cmd.CommandText = "delete from question_ouverte where id_QuestionOuvert='" + id_question_txt.Text + "' ";
                    cmd.ExecuteNonQuery();
                    ajoute_btn.Enabled = true;
                    delete_btn.Enabled = true;
                    update_btn.Enabled = true;
                    id_question_txt.Enabled = false;
                    question_txt.Enabled = false;
                    reponse_txt.Enabled = false;
                    validate_btn.Enabled = false;
                    anuller_btn.Enabled = false;

                }
                cnx.Close();
                id_question_txt.Clear();
            }

            if (val == 3)
            {
                cnx.Open();
                cmd.Connection = cnx;
                if (id_question_txt.Text == "" || question_txt.Text == "" || reponse_txt.Text == "")
                { MessageBox.Show("enter the inputs"); }
                else
                {
                    cmd.CommandText = "update question_ouverte set question ='" + question_txt.Text + "', Reponse ='" + reponse_txt.Text + "'  where id_QuestionOuvert='" + id_question_txt.Text + "' ";
                    cmd.ExecuteNonQuery();
                    ajoute_btn.Enabled = true;
                    delete_btn.Enabled = true;
                    update_btn.Enabled = true;
                    id_question_txt.Enabled = false;
                    question_txt.Enabled = false;
                    reponse_txt.Enabled = false;
                    validate_btn.Enabled = false;
                    anuller_btn.Enabled = false;
                    cnx.Close();

                }
                id_question_txt.Clear();
                question_txt.Clear();
                reponse_txt.Clear();
            }
            cbx2();
        }

        private void ajoute_btn_Click(object sender, EventArgs e)
        {
            val = 1;
            ajoute_btn.Enabled = false;
            update_btn.Enabled=false;
            delete_btn.Enabled=false;
            id_question_txt.Enabled = true;
            question_txt.Enabled = true;
            reponse_txt.Enabled = true;
            validate_btn.Enabled = true;
            anuller_btn.Enabled = true;
        }

        private void anuller_btn_Click(object sender, EventArgs e)
        {
            ajoute_btn.Enabled = true;
            delete_btn.Enabled = true;
            update_btn.Enabled = true;
            id_question_txt.Enabled = false;
            question_txt.Enabled = false;
            reponse_txt.Enabled = false;
            validate_btn.Enabled = false;
            anuller_btn.Enabled = false;

            id_question_txt.Clear();
            question_txt.Clear();
            reponse_txt.Clear();

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            val = 2;
            ajoute_btn.Enabled = false;
            delete_btn.Enabled = false;
            update_btn.Enabled = false;
            id_question_txt.Enabled = true;
            validate_btn.Enabled = true;
            anuller_btn.Enabled = true;
            question_txt.Enabled = false;
            reponse_txt.Enabled = false;


        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            val = 3;
            ajoute_btn.Enabled = false;
            delete_btn.Enabled = false;
            update_btn.Enabled = false;
            id_question_txt.Enabled = true;
            question_txt.Enabled = true;
            reponse_txt.Enabled = true;
            validate_btn.Enabled = true;
            anuller_btn.Enabled = true;

        }


        public void cbx2()
        {
            cnx.Open();
            cmd.CommandText = "select * from question_ouverte";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbx.DataSource = dt;
            cbx.DisplayMember = "question";
            cbx.ValueMember = "id_QuestionOuvert";
            id_question_txt.DataBindings.Add("text", cbx.DataSource, "id_QuestionOuvert");
            cnx.Close();
        }
    }


}
