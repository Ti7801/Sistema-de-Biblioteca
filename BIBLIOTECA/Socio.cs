
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
        List<Emprestimo> listaDeEmprestimo;
        private TipoDoSocio tipodosocio;
        List<Multa> listaMultas;

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

        public List<Multa> ListaMultas
        {
            get { return listaMultas; }
        }

        public List<Emprestimo> ListaDeEmprestimo
        {
            get { return listaDeEmprestimo;}
        }

        public Socio(string nome, string rua, int numero, string bairro, string cidade, string estado, TipoDoSocio tipodosocio)
        {
            this.nome = nome;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.tipodosocio = tipodosocio;
            listaDeEmprestimo = new List<Emprestimo>();
            listaMultas = new List<Multa>();
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

            foreach (Multa lista in listaMultas)
            {
                if (lista.SituacaodaMulta == MultaSituacao.Pendente)
                {
                    cont += 1;
                }
            }

            if (cont == 0)
            {
                Emprestimo CriacaoEmprestimo = new Emprestimo(today, devolucao, exemplar, this);
                listaDeEmprestimo.Add(CriacaoEmprestimo);

                return CriacaoEmprestimo;
            }
            else
            {
                return null;
            }
        }

        public void RenovarEmprestimo(Exemplar exemplar)
        {
           
            foreach (Emprestimo emprestimo in listaDeEmprestimo)
            {
                if (emprestimo.Exemplar.Indentificador == exemplar.Indentificador)
                {
                    emprestimo.DataDaDevolucao = emprestimo.DataDaDevolucao + tipodosocio.DuracaoDoEmprestimo;
                }
            }
        }

        public void EncerrarEmprestimo(Exemplar exemplar)
        {
            foreach (Emprestimo lista in listaDeEmprestimo)
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
                        Multa multa = new Multa(DateTime.Now, this, lista, valor_multa, MultaSituacao.Pendente, exemplar);

                        listaMultas.Add(multa); 
                    } 
                    
                }
            }

        }

        public void PagarMulta(Exemplar exemplar)
        {
            foreach (Multa multa in listaMultas)
            {
                if (multa.Exemplar.Indentificador == exemplar.Indentificador)
                {
                    multa.SituacaodaMulta = MultaSituacao.Paga;
                    break;
                }
                
            }

        }
    }
}
