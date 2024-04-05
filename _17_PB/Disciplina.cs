using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PB
{
    internal class Disciplina
    {
        private int _codigo;
        private string _nome;
        private List<Turma> _turmas;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nome { get => _nome; set => _nome = value; }
        internal List<Turma> Turmas { get => _turmas; set => _turmas = value; }

        public Disciplina(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            Turmas = new List<Turma>();
        }

        public Disciplina()
        {
            Codigo = 0;
            Nome = "";
        }

        public void AddTurma(Turma turma)
        {
            Turmas.Add(turma);
        }

        public string ExibirTurmas()
        {
            string info = $"Turmas da disciplina {Nome}:\n";
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
