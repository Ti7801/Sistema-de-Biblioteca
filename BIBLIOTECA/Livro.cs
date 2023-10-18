
namespace Projeto
{
    internal class Livro
    {
        private string titulo;
        private int ano;
        private int edicao;
        private string ibsn;
        private Editora editora;
        List<Exemplar> exemplares;
        List<Autor> listaAutores;

        public string Titulo
        {
            get { return titulo; }
        }
        public int Ano
        {
            get { return ano; }
        }

        public List<Exemplar> Exemplares
        {
            get { return exemplares; }
            set { exemplares = value; }
        }
        
        public Livro(string titulo, int ano, int edicao, string ibsn, Editora editora)
        {
            this.titulo = titulo;
            this.ano = ano;
            this.edicao = edicao;
            this.ibsn = ibsn;
            this.editora = editora;
            exemplares = new List<Exemplar>();
            listaAutores = new List<Autor>();     
        }

        public override string ToString()
        {
            string nome = "";

            foreach (Autor autor in listaAutores)
            {
                nome = nome +  autor.ToString() + ", " ;
            }

            return "Titulo: " + titulo + '\'' +
                 "Ano: " + ano + '\'' +
                 "Edição: " + edicao + '\'' +
                 "Isbn: " + ibsn + '\'' +
                 "Editora: " + editora + '\'' +
                 "Autores: " + nome ;
        }
    }
}
