
namespace CRUD.NET_MySQL
{
    partial class CRUD
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
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_telefone = new System.Windows.Forms.TextBox();
            this.btn_criar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.tb_nomes = new System.Windows.Forms.TextBox();
            this.tb_emails = new System.Windows.Forms.TextBox();
            this.tb_telefones = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_deletar_todos = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_ids = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(78, 12);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(80, 30);
            this.tb_id.TabIndex = 4;
            // 
            // tb_nome
            // 
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(79, 47);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(477, 30);
            this.tb_nome.TabIndex = 5;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(79, 84);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(477, 30);
            this.tb_email.TabIndex = 6;
            // 
            // tb_telefone
            // 
            this.tb_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_telefone.Location = new System.Drawing.Point(78, 123);
            this.tb_telefone.MaxLength = 11;
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(478, 30);
            this.tb_telefone.TabIndex = 7;
            // 
            // btn_criar
            // 
            this.btn_criar.Location = new System.Drawing.Point(78, 171);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(74, 24);
            this.btn_criar.TabIndex = 8;
            this.btn_criar.Text = "Criar";
            this.btn_criar.UseVisualStyleBackColor = true;
            this.btn_criar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.Location = new System.Drawing.Point(362, 171);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(74, 24);
            this.btn_deletar.TabIndex = 11;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(269, 171);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(74, 24);
            this.btn_editar.TabIndex = 10;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(171, 171);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(74, 24);
            this.btn_consultar.TabIndex = 9;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // tb_nomes
            // 
            this.tb_nomes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_nomes.Enabled = false;
            this.tb_nomes.Location = new System.Drawing.Point(89, 219);
            this.tb_nomes.Multiline = true;
            this.tb_nomes.Name = "tb_nomes";
            this.tb_nomes.ReadOnly = true;
            this.tb_nomes.Size = new System.Drawing.Size(135, 163);
            this.tb_nomes.TabIndex = 12;
            // 
            // tb_emails
            // 
            this.tb_emails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_emails.Enabled = false;
            this.tb_emails.Location = new System.Drawing.Point(220, 219);
            this.tb_emails.Multiline = true;
            this.tb_emails.Name = "tb_emails";
            this.tb_emails.ReadOnly = true;
            this.tb_emails.Size = new System.Drawing.Size(216, 163);
            this.tb_emails.TabIndex = 13;
            // 
            // tb_telefones
            // 
            this.tb_telefones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_telefones.Enabled = false;
            this.tb_telefones.Location = new System.Drawing.Point(422, 219);
            this.tb_telefones.Multiline = true;
            this.tb_telefones.Name = "tb_telefones";
            this.tb_telefones.ReadOnly = true;
            this.tb_telefones.Size = new System.Drawing.Size(134, 163);
            this.tb_telefones.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(128, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nome";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(293, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "E-mail";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(461, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Telefone";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_deletar_todos
            // 
            this.btn_deletar_todos.Location = new System.Drawing.Point(451, 171);
            this.btn_deletar_todos.Name = "btn_deletar_todos";
            this.btn_deletar_todos.Size = new System.Drawing.Size(105, 24);
            this.btn_deletar_todos.TabIndex = 18;
            this.btn_deletar_todos.Text = "Deletar Todos";
            this.btn_deletar_todos.UseVisualStyleBackColor = true;
            this.btn_deletar_todos.Click += new System.EventHandler(this.btn_deletar_todos_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(434, 388);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(105, 24);
            this.btn_limpar.TabIndex = 19;
            this.btn_limpar.Text = "Limpar GRID";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "ID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_ids
            // 
            this.tb_ids.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ids.Enabled = false;
            this.tb_ids.Location = new System.Drawing.Point(50, 219);
            this.tb_ids.Multiline = true;
            this.tb_ids.Name = "tb_ids";
            this.tb_ids.ReadOnly = true;
            this.tb_ids.Size = new System.Drawing.Size(42, 163);
            this.tb_ids.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(164, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "(Deixe em branco para buscar TODOS registros)";
            // 
            // CRUD
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(579, 422);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_ids);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_deletar_todos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_telefones);
            this.Controls.Add(this.tb_emails);
            this.Controls.Add(this.tb_nomes);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.tb_telefone);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CRUD";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD .NET + MySQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_telefone;
        private System.Windows.Forms.Button btn_criar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.TextBox tb_nomes;
        private System.Windows.Forms.TextBox tb_emails;
        private System.Windows.Forms.TextBox tb_telefones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_deletar_todos;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_ids;
        private System.Windows.Forms.Label label9;
    }
}

