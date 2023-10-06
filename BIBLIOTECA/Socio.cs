
namespace Projeto
{
    internal class Socio 
    {
        private string nome;
        private string rua;
        private int numero;
        private string bairro;
        private string cidade;
        private string estado;
        List<Emprestimo> ListaDeEmprestimo;
        private TipoDoSocio tipodosocio;
        List<Multa> ListaMultas;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Socio(string nome, string rua, int numero, string bairro, string cidade, string estado, TipoDoSocio tipodosocio, List<Emprestimo> emprestimo, List<Multa> multas)
        {
            this.nome = nome;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.tipodosocio = tipodosocio;
            this.ListaDeEmprestimo = emprestimo;
            this.ListaMultas = multas;
        }

        public override string ToString()
        {
            return "Nome: " + nome + '\'' +
                   "Rua: " + rua + '\'' +
                   "Número: " + numero + '\'' +
                   "Bairro: " + bairro + '\'' +
                   "Cidade: " + cidade + '\'' +
                   "Estado: " + estado + '\''  ;
        }

        public Emprestimo? CriarEmprestimo(Exemplar exemplar)
        {
            DateTime today = DateTime.Now;
            double dias = tipodosocio.DuracaoDoEmprestimo.TotalDays;
            DateTime devolucao = today.AddDays(dias);
            int cont = 0;

            foreach (Multa lista in ListaMultas)
            {
                if (lista.SituacaodaMulta == MultaSituacao.Pendente)
                {
                    cont += 1;
                }
            }

            if (cont == 0)
            {
                Emprestimo CriacaoEmprestimo = new Emprestimo(today, devolucao, exemplar, this);
                ListaDeEmprestimo.Add(CriacaoEmprestimo);

                return CriacaoEmprestimo;
            }
            else
            {
                return null;
            }
        }

        public void RenovarEmprestimo(Emprestimo emprestimo)
        {
            double dias = tipodosocio.DuracaoDoEmprestimo.TotalDays;
            emprestimo.DataDaDevolucao.AddDays(dias);           
        }

        public void EncerrarEmprestimo(Exemplar exemplar)
        {
            foreach (Emprestimo lista in ListaDeEmprestimo)
            {
                if (lista.Exemplar.Indentificador == exemplar.Indentificador)
                {
                    lista.DataDevolvido = DateTime.Now;
                    lista.Exemplar.Situacao = exemplar.Situacao;
                    TimeSpan dias_atraso = DateTime.Now - lista.DataDevolvido;
                    double dias = dias_atraso.TotalDays;
                    double valor_multa = tipodosocio.Multa_por_dia_atrasado * dias;

                    if (lista.DataDaDevolucao < DateTime.Now)
                    {
                        Multa multa = new Multa(DateTime.Now, this, lista, valor_multa, MultaSituacao.Pendente);

                        ListaMultas.Add(multa); 
                    } 
                    
                }
            }

        }
    }
}
