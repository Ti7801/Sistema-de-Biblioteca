

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


        public Editora(string nome) 
        {
            this.nome = nome;
            listaLivros = new List<Livro>();
        }

        public override string ToString()
        {
            return "Nome: " + nome; 
        }
    }
}
