using System;
using System.Collections.Generic;

namespace _17_PB
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Turma> turmas = new List<Turma>();
            List<Professor> professores = new List<Professor>();
            List<Disciplina> disciplinas = new List<Disciplina>();
            List<Aluno> alunos = new List<Aluno>();

            Disciplina disciplina1 = new Disciplina(1, "Java");
            Disciplina disciplina2 = new Disciplina(2, ".Net");
            Disciplina disciplina3 = new Disciplina(3, "PB");
            disciplinas.AddRange(new[] { disciplina1, disciplina2, disciplina3 });

            Professor professor1 = new Professor(101, "João");
            Professor professor2 = new Professor(102, "José");
            Professor professor3 = new Professor(103, "Maria");
            professores.AddRange(new[] { professor1, professor2, professor3 });

            Turma turma1 = new Turma(1);
            turma1.AddProfessor(professor1);
            turma1.AddDisciplina(disciplina1);
            turmas.Add(turma1);

            Turma turma2 = new Turma(2);
            turma2.AddProfessor(professor2);
            turma2.AddDisciplina(disciplina2);
            turmas.Add(turma2);

            Turma turma3 = new Turma(3);
            turma3.AddProfessor(professor3);
            turma3.AddDisciplina(disciplina3);
            turmas.Add(turma3);

            Aluno aluno1 = new Aluno(1, "Aluno 1");
            Aluno aluno2 = new Aluno(2, "Aluno 2");
            Aluno aluno3 = new Aluno(3, "Aluno 3");
            alunos.AddRange(new[] { aluno1, aluno2, aluno3 });

            turma1.AddAluno(aluno1);
            turma2.AddAluno(aluno2);
            turma3.AddAluno(aluno3);

            aluno1.AddTurma(turma1);
            aluno2.AddTurma(turma2);
            aluno3.AddTurma(turma3);

            Console.WriteLine("Alocação de Turmas\n");
            foreach (Turma turma in turmas)
            {
                Console.WriteLine(turma);
            }

            Console.WriteLine("\n\nPauta das Turmas\n");
            foreach (Turma turma in turmas)
            {
                Console.WriteLine(turma.gerarPauta());
            }

            Console.WriteLine("\n\nAlocação dos Alunos\n");
            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine(aluno.ExibirTurmas());
                Console.WriteLine();
            }

            Console.WriteLine("\n\nAlocação dos Professores\n");
            foreach (Professor professor in professores)
            {
                Console.WriteLine($"Alocação do Professor: {professor}");
                Console.WriteLine(professor.ExibirTurmas());
                Console.WriteLine();
            }

            Console.WriteLine("\n\nAlocação das Disciplinas\n");
            foreach (Disciplina disciplina in disciplinas)
            {
                Console.WriteLine($"Alocação da Disciplina: {disciplina}");
                Console.WriteLine(disciplina.ExibirTurmas());
                Console.WriteLine();
            }
        }
    }
}
