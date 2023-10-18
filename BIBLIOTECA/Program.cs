

namespace Projeto{

    class Program
    {
        static void Main(string[] ags)
        {
            // QUESTÃO 1

            // 1º Livro

            string titulo1 = "Anoitecer Maldito";
            int ano1 = 2022;
            int edicao1 = 1;
            string ibsn1 = "978-65-89999-01-3";
            Editora editora1 = new Editora("Editora TI");

            // 2º Livro

            string titulo2 = "Anoitecer Maldito 2: A ameaça do mal está sempre presente";
            int ano2 = 2023;
            int edicao2 = 2;
            string ibsn2 = "999-28-56123-05-9";
            Editora editora2 = new Editora("Editora TI");

            //Criando os objetos livros
            Livro livro1 = new Livro(titulo1, ano1, edicao1, ibsn1, editora1);
            Livro livro2 = new Livro(titulo2, ano2, edicao2, ibsn2, editora2);

           
            //Exemplares livro 1

            int identificador1 = 321;
            int identificador2 = 329;
            DateTime data_de_aquisicao1 = new DateTime(2022, 2, 25, 12, 30, 55);         
            DateTime data_de_aquisicao2 = new DateTime(2022, 2, 25, 12, 30, 55);

            Exemplar exemplar1 = new Exemplar(identificador1, data_de_aquisicao1, Situacao.Disponivel, livro1);
            Exemplar exemplar2 = new Exemplar(identificador2, data_de_aquisicao2, Situacao.Disponivel, livro1);


            //Exemplares livro 2

            int identificador3 = 422;
            int identificador4 = 433;
            DateTime data_de_aquisicao3 = new DateTime(2023,5, 3, 21,12, 45);
            DateTime data_de_aquisicao4 = new DateTime(2023,5, 3, 21, 12, 45);

            Exemplar exemplar3 = new Exemplar(identificador3, data_de_aquisicao3, Situacao.Disponivel, livro2);
            Exemplar exemplar4 = new Exemplar(identificador4,data_de_aquisicao4,Situacao.Disponivel, livro2);

            // Vinculando os exemplares aos livros
            livro1.Exemplares.Add(exemplar1);
            livro1.Exemplares.Add(exemplar2);
            livro2.Exemplares.Add(exemplar3);
            livro2.Exemplares.Add(exemplar4);
            


            // QUESTÃO 2

            TimeSpan duracaoEmprestimoAluno = new TimeSpan(15, 0, 0, 0);
            TimeSpan duracaoEmprestimoProfessor = new TimeSpan(30, 0, 0, 0);

            //Criado os objetos Tipo dos socios
            TipoDoSocio tipoSocioAluno = new Aluno("Aluno", 5, duracaoEmprestimoAluno, 10, 2.00);
            TipoDoSocio tipoSocioProfessor = new Professor("Professor", 10, duracaoEmprestimoProfessor, 15, 3.00);

            // Criando os sócios
            Socio socio1 = new Socio("Gabriel", "Alameda Beija-Flor", 452,"Bancários", "João Pessoa", "PB", tipoSocioAluno);
            Socio socio2 = new Socio("Tiago", "Alameda Canário da Terra", 952," Jardim Planalto", "João Pessoa", "PB", tipoSocioAluno);
            Socio socio3 = new Socio("Claudio", "Avenida Adolfo Loureiro França", 456, "Jaguaribe", "João Pessoa", "PB", tipoSocioProfessor);



            // QUESTÃO 3 e 4

            Emprestimo? empretimoSocio2 = socio2.CriarEmprestimo(exemplar1);
            Emprestimo? emprestimoSocio3 = socio3.CriarEmprestimo(exemplar2);

            //Questão 5



        }
    }

}