using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cadastro.Classes
{
    internal class GerenciaDados
    {
        public static void SalvarCadastros(List<Aluno> alunos)
        {
            string json = JsonSerializer.Serialize(alunos);
            File.WriteAllText("alunos.json", json);
        }

        public static bool CarregarCadastros(AlunoCadastro cadastro)
        {
            string conteudo = File.ReadAllText("alunos.json");

            List<Aluno> alunosLidos = JsonSerializer.Deserialize<List<Aluno>>(conteudo);

            if(alunosLidos == null)
            {
                return false;
            }
            else
            {
                foreach (var aluno in alunosLidos)
                {
                    cadastro.CadastrarAluno(aluno);
                }

                return true;
            } 
        }
    }
}
