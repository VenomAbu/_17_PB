using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PB
{
    internal class Aluno
    {
        private int _matricula;
        private string _nome;
        private List<Turma> _turmas;

        public int Matricula { get => _matricula; set => _matricula = value; }
        public string Nome { get => _nome; set => _nome = value; }
        internal List<Turma> Turmas { get => _turmas; set => _turmas = value; }

        public Aluno(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
            Turmas = new List<Turma>();
        }

        public Aluno()
        {
            Matricula = 0;
            Nome = "";
            Turmas = new List<Turma>();
        }

        public string AddTurma(Turma turma)
        {
            Turmas.Add(turma);
            return "Aluno " + Nome + " adicionado a turma " + turma.Codigo + ".";
        }

        public string ExibirTurmas()
        {
            string info = $"Turmas do aluno {Nome}:\n";
            foreach (Turma turma in Turmas)
            {
                info += $"- {turma}\n";
            }
            return info;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
