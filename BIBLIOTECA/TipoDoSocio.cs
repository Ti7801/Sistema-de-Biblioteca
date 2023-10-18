
namespace Projeto
{
    internal abstract class TipoDoSocio
    {
        private string descricao_do_tipo;
        private int limite_de_exemplares;
        private TimeSpan duracao_do_emprestimo;
        private int limite_de_renovacoes;
        private double multa_por_dia_atrasado;

        public string DescricaoDoTipo
        {
            get { return descricao_do_tipo; } 
        }

        public int LimiteDeExemplares
        {
            get { return limite_de_exemplares;}
        }

        public TimeSpan DuracaoDoEmprestimo
        {
            get { return duracao_do_emprestimo; }
        }

        public int LimiteDeRenovacoes
        {
            get { return limite_de_renovacoes; }
        }
        public double Multa_por_dia_atrasado
        {
            get { return multa_por_dia_atrasado; }
        }


        public TipoDoSocio(string descricao_do_tipo, int limite_de_exemplares, TimeSpan duracao_do_emprestimo, int limite_de_renovacoes, double multa_por_dia_atrasado)
        {
            this.descricao_do_tipo = descricao_do_tipo;
            this.limite_de_exemplares = limite_de_exemplares;
            this.duracao_do_emprestimo = duracao_do_emprestimo;
            this.limite_de_renovacoes = limite_de_renovacoes;
            this.multa_por_dia_atrasado = multa_por_dia_atrasado;
        }

        public override string ToString()
        {
            return "Descrição do Tipo: " + descricao_do_tipo + '\'' +
                   "Duração do Emprestimo: " + duracao_do_emprestimo + '\'' +
                   "Limite de Exemplares: " + limite_de_exemplares + '\'' +
                   "Limite de Renovações: " + limite_de_renovacoes + '\'' +
                   "Multa por dia atrasado: " + multa_por_dia_atrasado + '\'' ;
        }

        public abstract int GetLimiteDeExemplares();

    }
}
