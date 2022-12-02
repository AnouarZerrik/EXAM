using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace EXAM
{
    public partial class QuestionOuverte : Form
    {
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
            id_question_txt.Enabled = false;
            question_txt.Enabled = false;
            reponse_txt.Enabled = false;
            validate_btn.Enabled = false;
            anuller_btn.Enabled = false;
        }

        private void validate_btn_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into question_ouverte(id_QuestionOuvert,question,Reponse) values('" + id_question_txt.Text + "','" + question_txt.Text + "','" + reponse_txt.Text + "') ";
            cmd.ExecuteNonQuery();
            ajoute_btn.Enabled = true;
            id_question_txt.Enabled = false;
            question_txt.Enabled = false;
            reponse_txt.Enabled = false;
            validate_btn.Enabled = false;
            anuller_btn.Enabled = false;
            cnx.Close();
        }

        private void ajoute_btn_Click(object sender, EventArgs e)
        {
            ajoute_btn.Enabled = false;
            id_question_txt.Enabled = true;
            question_txt.Enabled = true;
            reponse_txt.Enabled = true;
            validate_btn.Enabled = true;
            anuller_btn.Enabled = true;
        }

        private void anuller_btn_Click(object sender, EventArgs e)
        {
            ajoute_btn.Enabled = true;
            id_question_txt.Enabled = false;
            question_txt.Enabled = false;
            reponse_txt.Enabled = false;
            validate_btn.Enabled = false;
            anuller_btn.Enabled = false;
        }
    }
}
