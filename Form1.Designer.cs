namespace Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            boxNome = new TextBox();
            boxTelefone = new TextBox();
            boxCpf = new TextBox();
            boxEndereco = new TextBox();
            boxBairro = new TextBox();
            boxCidade = new TextBox();
            boxEstado = new TextBox();
            label11 = new Label();
            boxCEP = new TextBox();
            listCadastro = new ListBox();
            editarBt = new Button();
            label12 = new Label();
            pictureBox2 = new PictureBox();
            dateNascimento = new DateTimePicker();
            avisos = new Label();
            excluirBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(192, 52);
            label1.Name = "label1";
            label1.Size = new Size(326, 32);
            label1.TabIndex = 0;
            label1.Text = "PROGRAMA DE CADASTRO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(192, 84);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 2;
            label2.Text = "Cadastro de Alunos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 162);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 3;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 199);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 4;
            label4.Text = "CPF:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 238);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 5;
            label5.Text = "Data de Nascimento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(45, 275);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 6;
            label6.Text = "Endereço:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 313);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 7;
            label7.Text = "Bairro:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(303, 313);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 8;
            label8.Text = "Cidade:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(45, 350);
            label9.Name = "label9";
            label9.Size = new Size(45, 15);
            label9.TabIndex = 9;
            label9.Text = "Estado:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(303, 159);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 10;
            label10.Text = "Telefone:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(45, 402);
            button1.Name = "button1";
            button1.Size = new Size(473, 32);
            button1.TabIndex = 11;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // boxNome
            // 
            boxNome.AllowDrop = true;
            boxNome.Location = new Point(94, 156);
            boxNome.Name = "boxNome";
            boxNome.Size = new Size(193, 23);
            boxNome.TabIndex = 12;
            // 
            // boxTelefone
            // 
            boxTelefone.Location = new Point(364, 154);
            boxTelefone.Name = "boxTelefone";
            boxTelefone.Size = new Size(154, 23);
            boxTelefone.TabIndex = 13;
            // 
            // boxCpf
            // 
            boxCpf.Location = new Point(94, 191);
            boxCpf.Name = "boxCpf";
            boxCpf.Size = new Size(193, 23);
            boxCpf.TabIndex = 14;
            // 
            // boxEndereco
            // 
            boxEndereco.Location = new Point(110, 267);
            boxEndereco.Name = "boxEndereco";
            boxEndereco.Size = new Size(408, 23);
            boxEndereco.TabIndex = 16;
            // 
            // boxBairro
            // 
            boxBairro.Location = new Point(110, 305);
            boxBairro.Name = "boxBairro";
            boxBairro.Size = new Size(177, 23);
            boxBairro.TabIndex = 17;
            // 
            // boxCidade
            // 
            boxCidade.Location = new Point(364, 305);
            boxCidade.Name = "boxCidade";
            boxCidade.Size = new Size(154, 23);
            boxCidade.TabIndex = 18;
            // 
            // boxEstado
            // 
            boxEstado.Location = new Point(110, 342);
            boxEstado.Name = "boxEstado";
            boxEstado.Size = new Size(177, 23);
            boxEstado.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(303, 350);
            label11.Name = "label11";
            label11.Size = new Size(31, 15);
            label11.TabIndex = 20;
            label11.Text = "CEP:";
            // 
            // boxCEP
            // 
            boxCEP.Location = new Point(364, 342);
            boxCEP.Name = "boxCEP";
            boxCEP.Size = new Size(154, 23);
            boxCEP.TabIndex = 21;
            // 
            // listCadastro
            // 
            listCadastro.FormattingEnabled = true;
            listCadastro.Location = new Point(564, 157);
            listCadastro.Name = "listCadastro";
            listCadastro.Size = new Size(257, 214);
            listCadastro.TabIndex = 22;
            // 
            // editarBt
            // 
            editarBt.BackColor = Color.MidnightBlue;
            editarBt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editarBt.ForeColor = SystemColors.ControlLightLight;
            editarBt.Location = new Point(564, 402);
            editarBt.Name = "editarBt";
            editarBt.Size = new Size(122, 32);
            editarBt.TabIndex = 23;
            editarBt.Text = "Editar";
            editarBt.UseVisualStyleBackColor = false;
            editarBt.Click += editarBt_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(564, 92);
            label12.Name = "label12";
            label12.Size = new Size(96, 42);
            label12.TabIndex = 24;
            label12.Text = "Alunos\r\nCadastrados";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(666, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // dateNascimento
            // 
            dateNascimento.Location = new Point(168, 232);
            dateNascimento.Name = "dateNascimento";
            dateNascimento.Size = new Size(350, 23);
            dateNascimento.TabIndex = 26;
            // 
            // avisos
            // 
            avisos.AutoSize = true;
            avisos.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            avisos.ForeColor = Color.Red;
            avisos.Location = new Point(202, 114);
            avisos.Name = "avisos";
            avisos.Size = new Size(0, 37);
            avisos.TabIndex = 27;
            // 
            // excluirBtn
            // 
            excluirBtn.BackColor = Color.Crimson;
            excluirBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            excluirBtn.ForeColor = SystemColors.ControlLightLight;
            excluirBtn.Location = new Point(692, 402);
            excluirBtn.Name = "excluirBtn";
            excluirBtn.Size = new Size(129, 32);
            excluirBtn.TabIndex = 28;
            excluirBtn.Text = "Excluir";
            excluirBtn.UseVisualStyleBackColor = false;
            excluirBtn.Click += excluirBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(856, 477);
            Controls.Add(excluirBtn);
            Controls.Add(avisos);
            Controls.Add(dateNascimento);
            Controls.Add(pictureBox2);
            Controls.Add(label12);
            Controls.Add(editarBt);
            Controls.Add(listCadastro);
            Controls.Add(boxCEP);
            Controls.Add(label11);
            Controls.Add(boxEstado);
            Controls.Add(boxCidade);
            Controls.Add(boxBairro);
            Controls.Add(boxEndereco);
            Controls.Add(boxCpf);
            Controls.Add(boxTelefone);
            Controls.Add(boxNome);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Cadastro de Alunos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private TextBox boxNome;
        private TextBox boxTelefone;
        private TextBox boxCpf;
        private TextBox boxEndereco;
        private TextBox boxBairro;
        private TextBox boxCidade;
        private TextBox boxEstado;
        private Label label11;
        private TextBox boxCEP;
        private ListBox listCadastro;
        private Button editarBt;
        private Label label12;
        private PictureBox pictureBox2;
        private DateTimePicker dateNascimento;
        private Label avisos;
        private Button excluirBtn;
    }
}
