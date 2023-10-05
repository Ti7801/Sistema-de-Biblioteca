

namespace Projeto
{
    internal class Autor 
    {
        private string nome;
        List<Livro> listaLivros;

        public string Nome
        {
            get { return nome; }
        }

        public Autor(string nome, List<Livro> listaLivros)
        {
            this.nome = nome;
            this.listaLivros = listaLivros; 
        }

        public override string ToString()
        {
            return "Nome: " + nome;
        }
    }
}
