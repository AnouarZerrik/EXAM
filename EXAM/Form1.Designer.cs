namespace EXAM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.idexam_exam = new System.Windows.Forms.TextBox();
            this.idqsm_txt = new System.Windows.Forms.TextBox();
            this.debut_txt = new System.Windows.Forms.TextBox();
            this.idouverte_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fin_txt = new System.Windows.Forms.TextBox();
            this.ajoute_btn = new System.Windows.Forms.Button();
            this.validate_btn = new System.Windows.Forms.Button();
            this.anuller_btn = new System.Windows.Forms.Button();
            this.cbx_qsm = new System.Windows.Forms.ComboBox();
            this.cbx_ouverte = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(660, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Question ouverte";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // idexam_exam
            // 
            this.idexam_exam.Location = new System.Drawing.Point(157, 122);
            this.idexam_exam.Name = "idexam_exam";
            this.idexam_exam.Size = new System.Drawing.Size(181, 23);
            this.idexam_exam.TabIndex = 2;
            // 
            // idqsm_txt
            // 
            this.idqsm_txt.Location = new System.Drawing.Point(157, 209);
            this.idqsm_txt.Name = "idqsm_txt";
            this.idqsm_txt.Size = new System.Drawing.Size(181, 23);
            this.idqsm_txt.TabIndex = 3;
            // 
            // debut_txt
            // 
            this.debut_txt.Location = new System.Drawing.Point(157, 151);
            this.debut_txt.Name = "debut_txt";
            this.debut_txt.Size = new System.Drawing.Size(181, 23);
            this.debut_txt.TabIndex = 5;
            // 
            // idouverte_txt
            // 
            this.idouverte_txt.Location = new System.Drawing.Point(157, 238);
            this.idouverte_txt.Name = "idouverte_txt";
            this.idouverte_txt.Size = new System.Drawing.Size(181, 23);
            this.idouverte_txt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID_EXAM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "DATE_DEBUT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "DATE_FIN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "id_qsm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "id_QuestionOuverte";
            // 
            // fin_txt
            // 
            this.fin_txt.Location = new System.Drawing.Point(157, 183);
            this.fin_txt.Name = "fin_txt";
            this.fin_txt.Size = new System.Drawing.Size(181, 23);
            this.fin_txt.TabIndex = 14;
            // 
            // ajoute_btn
            // 
            this.ajoute_btn.Location = new System.Drawing.Point(17, 392);
            this.ajoute_btn.Name = "ajoute_btn";
            this.ajoute_btn.Size = new System.Drawing.Size(123, 44);
            this.ajoute_btn.TabIndex = 15;
            this.ajoute_btn.Text = "Ajouter";
            this.ajoute_btn.UseVisualStyleBackColor = true;
            // 
            // validate_btn
            // 
            this.validate_btn.Location = new System.Drawing.Point(402, 394);
            this.validate_btn.Name = "validate_btn";
            this.validate_btn.Size = new System.Drawing.Size(123, 44);
            this.validate_btn.TabIndex = 17;
            this.validate_btn.Text = "Validee";
            this.validate_btn.UseVisualStyleBackColor = true;
            // 
            // anuller_btn
            // 
            this.anuller_btn.Location = new System.Drawing.Point(259, 394);
            this.anuller_btn.Name = "anuller_btn";
            this.anuller_btn.Size = new System.Drawing.Size(123, 44);
            this.anuller_btn.TabIndex = 18;
            this.anuller_btn.Text = "Anuller";
            this.anuller_btn.UseVisualStyleBackColor = true;
            // 
            // cbx_qsm
            // 
            this.cbx_qsm.FormattingEnabled = true;
            this.cbx_qsm.Location = new System.Drawing.Point(584, 45);
            this.cbx_qsm.Name = "cbx_qsm";
            this.cbx_qsm.Size = new System.Drawing.Size(194, 23);
            this.cbx_qsm.TabIndex = 19;
            this.cbx_qsm.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbx_ouverte
            // 
            this.cbx_ouverte.FormattingEnabled = true;
            this.cbx_ouverte.Location = new System.Drawing.Point(584, 98);
            this.cbx_ouverte.Name = "cbx_ouverte";
            this.cbx_ouverte.Size = new System.Drawing.Size(194, 23);
            this.cbx_ouverte.TabIndex = 20;
            this.cbx_ouverte.SelectedIndexChanged += new System.EventHandler(this.cbx_ouverte_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "QSM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ouverte";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "QSM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(157, 392);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(96, 44);
            this.delete_btn.TabIndex = 23;
            this.delete_btn.Text = "delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_ouverte);
            this.Controls.Add(this.cbx_qsm);
            this.Controls.Add(this.anuller_btn);
            this.Controls.Add(this.validate_btn);
            this.Controls.Add(this.ajoute_btn);
            this.Controls.Add(this.fin_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idouverte_txt);
            this.Controls.Add(this.debut_txt);
            this.Controls.Add(this.idqsm_txt);
            this.Controls.Add(this.idexam_exam);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button2;
        private TextBox idexam_exam;
        private TextBox idqsm_txt;
        private TextBox debut_txt;
        private TextBox idouverte_txt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox fin_txt;
        private Button ajoute_btn;
        private Button validate_btn;
        private Button anuller_btn;
        private ComboBox cbx_qsm;
        private ComboBox cbx_ouverte;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button delete_btn;
    }
}