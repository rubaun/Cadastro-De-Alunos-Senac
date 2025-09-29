/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Models
{
    internal class AlunoCadastro
    {
        List<Aluno> alunos;

        public AlunoCadastro()
        {
            alunos = new List<Aluno>();
        }

        public void CadastrarAluno(Aluno aluno)
        {
            alunos.Add(aluno);
        }

        public string ConsultaNomeAluno(string Aluno)
        {
            string cpfAluno = Aluno.Split('-')[0];

            foreach (var aluno in alunos)
            {
                if(aluno.Cpf == cpfAluno)
                {
                    return aluno.Nome;
                }
            }

            return "";
        }

        public bool VerificaCadastro(string Aluno)
        {
            string cpfAluno = Aluno.Split('-')[0];

            foreach (var aluno in alunos)
            {
                if(aluno.Cpf == cpfAluno)
                {
                    return true;
                }
            }

            return false;
        }

        public Aluno CarregaCadastro(string Aluno)
        {
            string cpfAluno = Aluno.Split('-')[0];

            foreach (var aluno in alunos)
            {
                if(aluno.Cpf == cpfAluno)
                {
                    return aluno;
                }
            }

            return new Aluno();
        }

        public bool ConsultaCpf(string cpf)
        {
            foreach (var aluno in alunos)
            {
                if(aluno.Cpf == cpf)
                {
                    return true;
                }
            }
            return false;
        }

        public void EditarCadastro(string Aluno, Aluno dadosNovos)
        {
            string cpfAluno = Aluno.Split('-')[0];

            Aluno cadastrado = CarregaCadastro(cpfAluno);

            cadastrado.Nome = dadosNovos.Nome;
            cadastrado.Telefone = dadosNovos.Telefone;
            cadastrado.Cpf = dadosNovos.Cpf;
            cadastrado.DataNascimento = dadosNovos.DataNascimento;
            cadastrado.Endereco = dadosNovos.Endereco;
            cadastrado.Cidade = dadosNovos.Cidade;
            cadastrado.Bairro = dadosNovos.Bairro;
            cadastrado.Estado = dadosNovos.Estado;
            cadastrado.Cep = dadosNovos.Cep;
        }

        public void ExluirCadastro(string Aluno)
        {
            string cpfAluno = Aluno.Split('-')[0];

            var aluno = alunos.FirstOrDefault(a => a.Cpf == cpfAluno);
            try 
            {
                alunos.Remove(aluno);
                DialogResult msgSucesso = MessageBox.Show(
                    $"Cadastro {aluno.Nome}",
                    "Excluido com Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                DialogResult msgErro = MessageBox.Show(
                    "Erro ao excluir", 
                    ex.Message, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }            
        }

        public List<Aluno> ListaGeral()
        {
            return alunos;
        }

    }
}
*/
