
namespace Projeto
{
    internal class Multa
    {
        private DateTime data_da_multa;
        private Socio socio;
        private Emprestimo emprestimo;
        private double valor_da_multa;
        private MultaSituacao situacao_da_multa;
        private Exemplar exemplar;

        public DateTime DatadaMulta
        {
            get { return data_da_multa; }
        }
        public Socio Socio
        {
            get { return socio; }
        }

        public Emprestimo Emprestimo
        {
            get { return emprestimo; }
        }
        public double ValordaMulta
        {
            get { return valor_da_multa;}
        }
        public MultaSituacao SituacaodaMulta
        {
            get { return situacao_da_multa;}
            set { situacao_da_multa = value; }    
        }
        public Exemplar Exemplar
        {
            get { return exemplar; }
        }

        public Multa(DateTime data_da_multa, Socio socio, Emprestimo emprestimo, double valor_da_multa, MultaSituacao situacao_da_multa, Exemplar exemplar)
        {
            this.data_da_multa = data_da_multa;
            this.socio = socio;
            this.emprestimo = emprestimo;
            this.valor_da_multa=valor_da_multa;
            this.situacao_da_multa = situacao_da_multa;
            this.exemplar = exemplar;
        }

    }
}
