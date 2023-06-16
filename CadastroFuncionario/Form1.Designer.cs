namespace CadastroFuncionario
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.matricula_tx = new System.Windows.Forms.TextBox();
            this.nome_tx = new System.Windows.Forms.TextBox();
            this.salario_txt = new System.Windows.Forms.TextBox();
            this.funcao_tx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.salariototal_tx = new System.Windows.Forms.Label();
            this.salario_tx = new System.Windows.Forms.Label();
            this.irpf_txt = new System.Windows.Forms.Label();
            this.cadastrar_tx = new System.Windows.Forms.Button();
            this.cancelar_tx = new System.Windows.Forms.Button();
            this.cpf_txt = new System.Windows.Forms.MaskedTextBox();
            this.salariofim_tx = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("French Script MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Funcionário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matricula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Função:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cpf: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Salário";
            // 
            // matricula_tx
            // 
            this.matricula_tx.Location = new System.Drawing.Point(206, 111);
            this.matricula_tx.Name = "matricula_tx";
            this.matricula_tx.Size = new System.Drawing.Size(121, 22);
            this.matricula_tx.TabIndex = 6;
            // 
            // nome_tx
            // 
            this.nome_tx.Location = new System.Drawing.Point(206, 157);
            this.nome_tx.Name = "nome_tx";
            this.nome_tx.Size = new System.Drawing.Size(121, 22);
            this.nome_tx.TabIndex = 7;
            // 
            // salario_txt
            // 
            this.salario_txt.Location = new System.Drawing.Point(567, 151);
            this.salario_txt.Name = "salario_txt";
            this.salario_txt.Size = new System.Drawing.Size(100, 22);
            this.salario_txt.TabIndex = 8;
            this.salario_txt.TextChanged += new System.EventHandler(this.salario_txt_TextChanged);
            // 
            // funcao_tx
            // 
            this.funcao_tx.FormattingEnabled = true;
            this.funcao_tx.Items.AddRange(new object[] {
            "MEDICO",
            "TI",
            "ADM"});
            this.funcao_tx.Location = new System.Drawing.Point(206, 211);
            this.funcao_tx.Name = "funcao_tx";
            this.funcao_tx.Size = new System.Drawing.Size(121, 24);
            this.funcao_tx.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "SalárioTotal";
            // 
            // salariototal_tx
            // 
            this.salariototal_tx.AutoSize = true;
            this.salariototal_tx.Location = new System.Drawing.Point(578, 214);
            this.salariototal_tx.Name = "salariototal_tx";
            this.salariototal_tx.Size = new System.Drawing.Size(0, 16);
            this.salariototal_tx.TabIndex = 12;
            // 
            // salario_tx
            // 
            this.salario_tx.AutoSize = true;
            this.salario_tx.Location = new System.Drawing.Point(585, 218);
            this.salario_tx.Name = "salario_tx";
            this.salario_tx.Size = new System.Drawing.Size(0, 16);
            this.salario_tx.TabIndex = 13;
            // 
            // irpf_txt
            // 
            this.irpf_txt.AutoSize = true;
            this.irpf_txt.Location = new System.Drawing.Point(494, 268);
            this.irpf_txt.Name = "irpf_txt";
            this.irpf_txt.Size = new System.Drawing.Size(43, 16);
            this.irpf_txt.TabIndex = 14;
            this.irpf_txt.Text = "IRPF: ";
            // 
            // cadastrar_tx
            // 
            this.cadastrar_tx.Location = new System.Drawing.Point(81, 313);
            this.cadastrar_tx.Name = "cadastrar_tx";
            this.cadastrar_tx.Size = new System.Drawing.Size(131, 64);
            this.cadastrar_tx.TabIndex = 16;
            this.cadastrar_tx.Text = "Cadastrar";
            this.cadastrar_tx.UseVisualStyleBackColor = true;
            this.cadastrar_tx.Click += new System.EventHandler(this.cadastrar_tx_Click);
            // 
            // cancelar_tx
            // 
            this.cancelar_tx.Location = new System.Drawing.Point(248, 313);
            this.cancelar_tx.Name = "cancelar_tx";
            this.cancelar_tx.Size = new System.Drawing.Size(142, 64);
            this.cancelar_tx.TabIndex = 17;
            this.cancelar_tx.Text = "Cancelar";
            this.cancelar_tx.UseVisualStyleBackColor = true;
            this.cancelar_tx.Click += new System.EventHandler(this.cancelar_tx_Click);
            // 
            // cpf_txt
            // 
            this.cpf_txt.Location = new System.Drawing.Point(567, 104);
            this.cpf_txt.Mask = "000.000.000-00";
            this.cpf_txt.Name = "cpf_txt";
            this.cpf_txt.Size = new System.Drawing.Size(100, 22);
            this.cpf_txt.TabIndex = 18;
            // 
            // salariofim_tx
            // 
            this.salariofim_tx.AutoSize = true;
            this.salariofim_tx.Location = new System.Drawing.Point(584, 219);
            this.salariofim_tx.Name = "salariofim_tx";
            this.salariofim_tx.Size = new System.Drawing.Size(81, 16);
            this.salariofim_tx.TabIndex = 20;
            this.salariofim_tx.Text = "SalárioTotal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(544, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "irpf_tx";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.salariofim_tx);
            this.Controls.Add(this.cpf_txt);
            this.Controls.Add(this.cancelar_tx);
            this.Controls.Add(this.cadastrar_tx);
            this.Controls.Add(this.irpf_txt);
            this.Controls.Add(this.salario_tx);
            this.Controls.Add(this.salariototal_tx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.funcao_tx);
            this.Controls.Add(this.salario_txt);
            this.Controls.Add(this.nome_tx);
            this.Controls.Add(this.matricula_tx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox matricula_tx;
        private System.Windows.Forms.TextBox nome_tx;
        private System.Windows.Forms.TextBox salario_txt;
        private System.Windows.Forms.ComboBox funcao_tx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label salariototal_tx;
        private System.Windows.Forms.Label salario_tx;
        private System.Windows.Forms.Label irpf_txt;
        private System.Windows.Forms.Button cadastrar_tx;
        private System.Windows.Forms.Button cancelar_tx;
        private System.Windows.Forms.MaskedTextBox cpf_txt;
        private System.Windows.Forms.Label salariofim_tx;
        private System.Windows.Forms.Label label8;
    }
}

