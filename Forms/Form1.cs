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
            if(alunoSelecionado != null)
            {
                SalvarAlunoEditado();
            }
            else
            {
                CadastrarAluno();
            }
        }

        private void SalvarAlunoEditado()
        {
            cadastro.EditarCadastro(alunoSelecionado);
            LimpaForm();
            CarregarCadastrosLista();
            button1.Text = "Cadastrar";
            avisos.Text = "Cadastro atualizado com sucesso!";
            alunoSelecionado = null;
        }

        private void CadastrarAluno()
        {
            if (cadastro.ConsultaCpf(boxCpf.Text))
            {
                avisos.Text = "CPF já cadastrado.";
                return;
            }

            if(!VerificaForm())
            {
                avisos.Text = "Preencha os campos obrigatórios. 🤯";
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
            string? cpf = GetCpfFromSelectedItem();
            if (string.IsNullOrEmpty(cpf)) return;

            alunoSelecionado = cadastro.CarregaCadastro(cpf);

            if (alunoSelecionado != null)
            {
                boxNome.Text = alunoSelecionado.Nome;
                boxTelefone.Text = alunoSelecionado.Telefone;
                boxCpf.Text = alunoSelecionado.Cpf;
                dateNascimento.Value = alunoSelecionado.DataNascimento;
                boxEndereco.Text = alunoSelecionado.Endereco;
                boxBairro.Text = alunoSelecionado.Bairro;
                boxCidade.Text = alunoSelecionado.Cidade;
                boxEstado.Text = alunoSelecionado.Estado;
                boxCEP.Text = alunoSelecionado.Cep;
            }

            boxCpf.Enabled = false;
            button1.Text = "Salvar";
            avisos.Text = $"Editando: {alunoSelecionado.Nome}";
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
            
            foreach(var aluno in cadastro.ListaGeral())
            {
                listCadastro.Items.Add($"{aluno.Cpf}-{aluno.Nome}");
            }
        }

        

        private void editarBt_Click(object sender, EventArgs e)
        {
            EditarAluno();
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

        private string GetCpfFromSelectedItem()
        {
            if (listCadastro.SelectedItem == null)
                return string.Empty;

            string selectedItem = listCadastro.SelectedItem.ToString();
            string cpf = selectedItem.Split('-')[0].Trim();
            return cpf;
        }
    }
}
