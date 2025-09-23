using Cadastro.Classes;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        AlunoCadastro cadastro = new AlunoCadastro();
        bool editar;

        public Form1()
        {
            InitializeComponent();

            if(GerenciaDados.CarregarCadastros(cadastro))
            {
                CarregarCadastrosLista();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cadastro.VerificaCadastro(boxCpf.Text) && !editar)
            {
                avisos.Text = "Aluno já cadastrado.";
            }
            else if (!VerificaForm())
            {
                avisos.Text = "Preencha todos os dados.";
            }
            else if (!editar)
            {
                CadastrarAluno();
            }
            else if (editar)
            {
                EditarAluno();
            }

            GerenciaDados.SalvarCadastros(cadastro.ListaGeral());
        }

        private void CadastrarAluno()
        {
            Aluno aluno = new Aluno
            {
                Nome = boxNome.Text,
                Telefone = boxTelefone.Text,
                Cpf = boxCpf.Text,
                DataNascimento = dateNascimento.Value,
                Endereco = boxEndereco.Text,
                Bairro = boxBairro.Text,
                Cidade = boxCidade.Text,
                Estado = boxEstado.Text,
                Cep = boxCEP.Text
            };

            if(cadastro.ConsultaCpf(aluno.Cpf))
            {
                avisos.Text = "CPF já cadastrado.";
                LimpaForm();
                return;
            }
            else
            {
                cadastro.CadastrarAluno(aluno);
                listCadastro.Items.Add($"{ aluno.Cpf}-{ aluno.Nome}");
                LimpaForm();
            }
                
        }

        private void EditarAluno()
        {
            Aluno aluno = new Aluno
            {
                Nome = boxNome.Text,
                Telefone = boxTelefone.Text,
                Cpf = boxCpf.Text,
                DataNascimento = dateNascimento.Value,
                Endereco = boxEndereco.Text,
                Bairro = boxBairro.Text,
                Cidade = boxCidade.Text,
                Estado = boxEstado.Text,
                Cep = boxCEP.Text
            };

            cadastro.EditarCadastro(aluno.Cpf, aluno);
            LimpaForm();
            editar = false;
            AtivarModoEditar();
        }

        private void LimpaForm()
        {
            boxNome.Text = "";
            boxTelefone.Text = "";
            boxCpf.Text = "";
            boxEndereco.Text = "";
            boxBairro.Text = "";
            boxCidade.Text = "";
            boxEstado.Text = "";
            boxCEP.Text = "";
        }

        private bool VerificaForm()
        {
            {
                bool valido = true;

                // Nome
                if (string.IsNullOrWhiteSpace(boxNome.Text))
                {
                    boxNome.BackColor = Color.FromArgb(255, 192, 192);
                    valido = false;
                }
                else
                {
                    boxNome.BackColor = Color.White;
                }

                // Telefone
                if (string.IsNullOrWhiteSpace(boxTelefone.Text))
                {
                    boxTelefone.BackColor = Color.FromArgb(255, 192, 192);
                    valido = false;
                }
                else
                {
                    boxTelefone.BackColor = Color.White;
                }

                // CPF
                if (string.IsNullOrWhiteSpace(boxCpf.Text))
                {
                    boxCpf.BackColor = Color.FromArgb(255, 192, 192);
                    valido = false;
                }
                else
                {
                    boxCpf.BackColor = Color.White;
                }

                // Endereço
                if (string.IsNullOrWhiteSpace(boxEndereco.Text))
                {
                    boxEndereco.BackColor = Color.FromArgb(255, 192, 192);
                    valido = false;
                }
                else
                {
                    boxEndereco.BackColor = Color.White;
                }

                // Bairro
                if (string.IsNullOrWhiteSpace(boxBairro.Text))
                {
                    boxBairro.BackColor = Color.FromArgb(255, 192, 192);
                    valido = false;
                }
                else
                {
                    boxBairro.BackColor = Color.White;
                }

                // Cidade
                if (string.IsNullOrWhiteSpace(boxCidade.Text))
                {
                    boxCidade.BackColor = Color.FromArgb(255, 192, 192);
                    valido = false;
                }
                else
                {
                    boxCidade.BackColor = Color.White;
                }

                // CEP
                if (string.IsNullOrWhiteSpace(boxCEP.Text))
                {
                    boxCEP.BackColor = Color.FromArgb(255, 192, 192);
                    valido = false;
                }
                else
                {
                    boxCEP.BackColor = Color.White;
                }

                // Estado
                if (string.IsNullOrWhiteSpace(boxEstado.Text))
                {
                    boxEstado.BackColor = Color.FromArgb(255, 192, 192);
                    valido = false;
                }
                else
                {
                    boxEstado.BackColor = Color.White;
                }

                return valido;

            }
        }

        private void CarregarCadastro()
        {
            editar = true;

            Aluno aluno = cadastro.CarregaCadastro(listCadastro.SelectedItem.ToString());

            boxNome.Text = aluno.Nome;
            boxTelefone.Text = aluno.Telefone;
            boxCpf.Text = aluno.Cpf;
            dateNascimento.Value = aluno.DataNascimento;
            boxEndereco.Text = aluno.Endereco;
            boxEstado.Text = aluno.Estado;
            boxCidade.Text = aluno.Cidade;
            boxBairro.Text = aluno.Bairro;
            boxCEP.Text = aluno.Cep;

            AtivarModoEditar();
        }

        private void CarregarCadastrosLista()
        {
            listCadastro.Items.Clear();

            foreach (var aluno in cadastro.ListaGeral())
            {
                listCadastro.Items.Add($"{aluno.Cpf}-{aluno.Nome}");
            }
        }

        private void AtivarModoEditar()
        {
            if (editar)
            {
                button1.Text = "Salvar";
            }
            else
            {
                button1.Text = "Cadastrar";
            }
        }

        private void editarBt_Click(object sender, EventArgs e)
        {
            CarregarCadastro();
        }

        private void excluirBtn_Click(object sender, EventArgs e)
        {
            string alunoExcluir = listCadastro.SelectedItem.ToString();

            DialogResult resultado = MessageBox.Show(
                $"Tem certeza que deseja excluir: {cadastro.ConsultaNomeAluno(alunoExcluir)} ?", "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                cadastro.ExluirCadastro(alunoExcluir);
                MessageBox.Show("Aluno excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Operação cancelada.");
            }

            listCadastro.Items.Clear();

            foreach(var aluno in cadastro.ListaGeral())
            {
                listCadastro.Items.Add($"{aluno.Cpf}-{aluno.Nome}");
            }

            GerenciaDados.SalvarCadastros(cadastro.ListaGeral());
        }

    }
}
