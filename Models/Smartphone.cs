namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo;
        protected string IMEI;
        protected int Memoria; // estou tratando a memória como o armazenamento interno, ao invés da RAM

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("\nLigando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("\nRecebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}