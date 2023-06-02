namespace LojaDeCinema.Modelos
{
    public class ItemAlimentar
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public decimal PrecoVenda { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public decimal Lucro 
        {
            get
            {
                return (PrecoVenda * Quantidade) - (PrecoUnitario * Quantidade);
            }
        }
    }
}
