namespace EXAM
{
    partial class QuestionOuverte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.anuller_btn = new System.Windows.Forms.Button();
            this.validate_btn = new System.Windows.Forms.Button();
            this.ajoute_btn = new System.Windows.Forms.Button();
            this.reponse_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.question_txt = new System.Windows.Forms.TextBox();
            this.id_question_txt = new System.Windows.Forms.TextBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // anuller_btn
            // 
            this.anuller_btn.Location = new System.Drawing.Point(294, 394);
            this.anuller_btn.Name = "anuller_btn";
            this.anuller_btn.Size = new System.Drawing.Size(123, 44);
            this.anuller_btn.TabIndex = 21;
            this.anuller_btn.Text = "Anuller";
            this.anuller_btn.UseVisualStyleBackColor = true;
            this.anuller_btn.Click += new System.EventHandler(this.anuller_btn_Click);
            // 
            // validate_btn
            // 
            this.validate_btn.Location = new System.Drawing.Point(437, 394);
            this.validate_btn.Name = "validate_btn";
            this.validate_btn.Size = new System.Drawing.Size(123, 44);
            this.validate_btn.TabIndex = 20;
            this.validate_btn.Text = "Validee";
            this.validate_btn.UseVisualStyleBackColor = true;
            this.validate_btn.Click += new System.EventHandler(this.validate_btn_Click);
            // 
            // ajoute_btn
            // 
            this.ajoute_btn.Location = new System.Drawing.Point(29, 396);
            this.ajoute_btn.Name = "ajoute_btn";
            this.ajoute_btn.Size = new System.Drawing.Size(123, 44);
            this.ajoute_btn.TabIndex = 19;
            this.ajoute_btn.Text = "Ajouter";
            this.ajoute_btn.UseVisualStyleBackColor = true;
            this.ajoute_btn.Click += new System.EventHandler(this.ajoute_btn_Click);
            // 
            // reponse_txt
            // 
            this.reponse_txt.Location = new System.Drawing.Point(169, 253);
            this.reponse_txt.Name = "reponse_txt";
            this.reponse_txt.Size = new System.Drawing.Size(181, 23);
            this.reponse_txt.TabIndex = 30;
            this.reponse_txt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 29;
            this.label3.Text = "Reponse";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 28;
            this.label2.Text = "question";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID_question";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // question_txt
            // 
            this.question_txt.Location = new System.Drawing.Point(169, 162);
            this.question_txt.Name = "question_txt";
            this.question_txt.Size = new System.Drawing.Size(181, 23);
            this.question_txt.TabIndex = 26;
            this.question_txt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // id_question_txt
            // 
            this.id_question_txt.Location = new System.Drawing.Point(169, 130);
            this.id_question_txt.Name = "id_question_txt";
            this.id_question_txt.Size = new System.Drawing.Size(181, 23);
            this.id_question_txt.TabIndex = 25;
            this.id_question_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(169, 396);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(110, 44);
            this.delete_btn.TabIndex = 31;
            this.delete_btn.Text = "delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // QuestionOuverte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.reponse_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.question_txt);
            this.Controls.Add(this.id_question_txt);
            this.Controls.Add(this.anuller_btn);
            this.Controls.Add(this.validate_btn);
            this.Controls.Add(this.ajoute_btn);
            this.Name = "QuestionOuverte";
            this.Text = "QuestionOuverte";
            this.Load += new System.EventHandler(this.QuestionOuverte_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button anuller_btn;
        private Button validate_btn;
        private Button ajoute_btn;
        private TextBox reponse_txt;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox question_txt;
        private TextBox id_question_txt;
        private Button delete_btn;
    }
}