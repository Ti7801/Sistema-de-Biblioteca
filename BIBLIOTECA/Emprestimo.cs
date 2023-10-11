
namespace Projeto
{
    internal class Emprestimo
    {
        private readonly DateTime data_do_emprestimo;
        private DateTime data_da_devolucao;
        private DateTime data_devolvido;
        private Exemplar exemplar;
        private Socio socio;

        public DateTime DataDoEmprestimo
        {
            get { return data_do_emprestimo; }
        }

        public DateTime DataDaDevolucao
        {
            get { return data_da_devolucao; }
            set { data_da_devolucao = value; }
        }

        public DateTime DataDevolvido
        {
            get { return data_devolvido; }
            set { data_devolvido = value; }
        }

        public Exemplar Exemplar 
        {
            get { return exemplar; }
            set { exemplar = value; }
        }

        public Socio Socio 
        {
            get { return socio; }
        }

        public Emprestimo(DateTime data_do_emprestimo, DateTime data_da_devolucao, Exemplar exemplar, Socio socio)
        {
            this.data_do_emprestimo = data_do_emprestimo;
            this.data_da_devolucao = data_da_devolucao;
            this.exemplar = exemplar;
            this.socio = socio;
        }

    }
}
