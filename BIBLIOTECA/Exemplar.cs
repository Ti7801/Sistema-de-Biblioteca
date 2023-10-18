
namespace Projeto
{
    internal class Exemplar
    {
        private readonly int identificador;
        private readonly DateTime data_de_aquisicao;
        private Situacao situacao;
        private Livro livro;

        public int Indentificador
        {
            get { return identificador; }
        }
        public Situacao Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }

        public Exemplar(int identificador, DateTime data_de_aquisicao, Situacao situacao, Livro livro)
        {
            this.identificador = identificador;
            this.data_de_aquisicao = data_de_aquisicao;
            this.situacao = situacao;
            this.livro = livro;
        }
    }
}
