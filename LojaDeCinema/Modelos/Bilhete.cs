namespace LojaDeCinema.Modelos
{
    public class Bilhete
    {
        public int ID { get; set; }
        public string NomeFilme { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal PercentagemCorteStudio { get; set; }
        public int Quantidade { get; set; }
        public decimal Lucro 
        {
            get
            {
                return (Quantidade * PrecoVenda) - (PercentagemCorteStudio * (Quantidade * PrecoVenda));
            }
        }
        public decimal LucroPorItem 
        {
            get
            {
                return PrecoVenda - (PercentagemCorteStudio * PrecoVenda);
            }
        }
    }
}
