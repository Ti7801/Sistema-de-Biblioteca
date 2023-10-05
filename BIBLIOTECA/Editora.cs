

namespace Projeto
{
    internal class Editora 
    {
        private string nome;
        List<Livro> listaLivros;

        public string Nome
        {
            get { return nome; }
        }


        public Editora(string nome, List<Livro> listaLivros) 
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
