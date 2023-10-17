namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public readonly List<string> Apps = new();

        public override void InstalarAplicativo(string nomeApp)
        {
            if (string.IsNullOrWhiteSpace(nomeApp)) {
                throw new ArgumentException("Nome do app inválido, tente novamente.");
            }

            Apps.Add(nomeApp);
        }

        public void ListarAplicativosInstalados() {
            Console.WriteLine($"\nAplicativos instalados no seu Nokia {Modelo}:");

            foreach (var nome in Apps)
            {
                Console.WriteLine($" - {nome}");
            }
        }
    }
}