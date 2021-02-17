namespace DIO.Series
{
    public class Series : EntidadeBase
    {
        // Atributos
        private Genero Genero {get; set; }

        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }

        // Métodos
        public Series(int id, Genero genero, string Titulo, string Descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = ano;
        }
    }
}