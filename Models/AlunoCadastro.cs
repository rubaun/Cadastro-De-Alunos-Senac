using Cadastro.Data;
using System.Collections.Generic;
using System.Linq;


namespace Cadastro.Models
{
    
    public class AlunoCadastro
    {
       
        public void CadastrarAluno(Aluno aluno)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Alunos.Add(aluno);
                context.SaveChanges(); 
            }
        }

        
        public Aluno CarregaCadastro(string cpf) 
        {
            foreach (var aluno in ListaGeral())
            {
                    if (aluno.Cpf == cpf)
                        return aluno;
            }
               
            return null;
        }

        public bool ConsultaCpf(string cpf)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Alunos.Any(a => a.Cpf == cpf);
            }
        }

        
        public void EditarCadastro(Aluno dadosNovos)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Alunos.Update(dadosNovos);
                context.SaveChanges();
            }
        }

       
        public void ExcluirCadastro(string cpf)
        {
            using (var context = new ApplicationDbContext())
            {
                var aluno = context.Alunos.FirstOrDefault(a => a.Cpf == cpf);
                if (aluno != null)
                {
                    context.Alunos.Remove(aluno);
                    context.SaveChanges();
                }
            }
        }

        
        public List<Aluno> ListaGeral() 
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Alunos.ToList();
            }
        }
    }
}