namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public readonly List<(string Nome, int Memoria)> Apps = new();

        public override void InstalarAplicativo(string nomeApp)
        {
            if (string.IsNullOrWhiteSpace(nomeApp)) {
                throw new ArgumentException("Nome do app inválido, tente novamente.");
            }

            Random aleatorio = new();
            
            bool sucesso = aleatorio.Next(1, 100) > 11;

            int memoriaInstalada = Apps.Aggregate(0, (acc, x) => acc + x.Memoria);
            int memoriaRestante = Memoria - memoriaInstalada;

            int memoria = sucesso
                ? aleatorio.Next(memoriaRestante / 2)
                : aleatorio.Next(memoriaRestante + 1, int.MaxValue - memoriaRestante + 1);

            if (memoria > memoriaRestante) {
                throw new Exception("Não é possível instalar esse aplicativo. Não há memória disponível.");
            }

            Apps.Add(new ValueTuple<string, int>(nomeApp, memoria));
        }

        public void MemoriaUtilizada()
        {
            int memoriaUtilizada = Apps.Aggregate(0, (acc, x) => acc + x.Memoria);
            double porcentagemUtilizada = (double)memoriaUtilizada * 100 / Memoria;

            Console.WriteLine("\nArmazenamento interno utilizado");
            Console.WriteLine($"{memoriaUtilizada} MB / {Memoria} MB ({porcentagemUtilizada:0.00}%)");
        }

        public void ListarAplicativosInstalados() {
            Console.WriteLine($"\nAplicativos instalados no seu iPhone {Modelo}:");

            foreach (var (nome, memoria) in Apps)
            {
                Console.WriteLine($" - Nome: {nome}, Armazenamento: {memoria} MB");
            }
        }
    }
}