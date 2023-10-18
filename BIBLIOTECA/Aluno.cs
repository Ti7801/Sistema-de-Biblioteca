
namespace Projeto
{
    internal class Aluno : TipoDoSocio
    {

        public Aluno(string descricao_do_tipo, int limite_de_exemplares, TimeSpan duaracao_do_emprestimo, int limite_de_renovacoes, double multa_por_dia_atraso) : base(descricao_do_tipo, limite_de_exemplares, duaracao_do_emprestimo, limite_de_renovacoes, multa_por_dia_atraso)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override int GetLimiteDeExemplares()
        {
            int limite = 5;

            return limite;
        }

    }
}
