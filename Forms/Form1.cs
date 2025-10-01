using Cadastro.Data;
using Cadastro.Models;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        AlunoCadastro cadastro;
        Aluno? alunoSelecionado;

        public Form1() //Construtor
        {
            InitializeComponent();
            cadastro = new AlunoCadastro(); //Instancia a classe AlunoCadastro
            CarregarCadastrosLista();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cadastro.ConsultaCpf(boxCpf.Text) && !editar)
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

        }

        private void CadastrarAluno()
        {
            if (cadastro.ConsultaCpf(boxCpf.Text))
            {
                avisos.Text = "CPF já cadastrado.";
                return;
            }

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

            cadastro.CadastrarAluno(aluno);
            LimpaForm();
            CarregarCadastrosLista();
            avisos.Text = "Aluno cadastrado com sucesso! 🧑‍🎓";
        }

        private void EditarAluno()
        {
            if (alunoSelecionado == null)
            {
                avisos.Text = "Nenhum aluno selecionado para editar. 😕";
                return;
            }

            alunoSelecionado.Nome = boxNome.Text;
            alunoSelecionado.Telefone = boxTelefone.Text;
            alunoSelecionado.Cpf = boxCpf.Text;
            alunoSelecionado.DataNascimento = dateNascimento.Value;
            alunoSelecionado.Endereco = boxEndereco.Text;
            alunoSelecionado.Bairro = boxBairro.Text;
            alunoSelecionado.Cidade = boxCidade.Text;
            alunoSelecionado.Estado = boxEstado.Text;
            alunoSelecionado.Cep = boxCEP.Text;

            cadastro.EditarCadastro(alunoSelecionado);

            LimpaForm();
            CarregarCadastrosLista();
            avisos.Text = "Cadastro editado com sucesso 😎";
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

        private void CarregarCadastrosLista()
        {
            listCadastro.Items.Clear();
            List<Aluno> alunosCarregados = cadastro.ListaGeral();
            foreach(var aluno in alunosCarregados)
            {
                listCadastro.Items.Add($"{aluno.Cpf}-{aluno.Nome}");
            }
        }

        

        private void editarBt_Click(object sender, EventArgs e)
        {
            CarregarCadastrosLista();
        }

        private void excluirBtn_Click(object sender, EventArgs e)
        {
            string alunoExcluir = listCadastro.SelectedItem.ToString();

            DialogResult resultado = MessageBox.Show(
                $"Tem certeza que deseja excluir: {cadastro.ConsultaCpf(alunoExcluir)} ?", "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                cadastro.ExcluirCadastro(alunoExcluir);
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

            //Utilizando Json
            //GerenciaDados.SalvarCadastros(cadastro.ListaGeral());
        }

    }
}
