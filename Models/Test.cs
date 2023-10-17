namespace DesafioPOO.Models
{
    public class Test
    {
        private static string ReceberAppAleatorio(string[] listaDeExclusao)
        {
            string[] listaDeApps = {
                "WhatsApp",
                "WhatsApp 2",
                "O aplicativo ateriormente conhecido como Twitter",
                "Facebook",
                "YouTube",
                "Instagram",
                "Formula 1",
                "Crunchyroll",
            };

            string[] listaFiltrada = listaDeApps.Where(app => !listaDeExclusao.Any(x => x.Equals(app))).ToArray();

            return listaFiltrada[new Random().Next(listaFiltrada.Length)];
        }

        private static string ReceberModeloIPhoneAleatorio()
        {
            string[] modelosIPhone = {
                "15 Pro Max",
                "15 Pro",
                "15 Plus",
                "15",
                "14 Pro Max",
                "14 Pro",
                "14 Plus",
                "14",
            };

            return modelosIPhone[new Random().Next(modelosIPhone.Length)];
        }

        private static string ReceberModeloNokiaAleatorio()
        {
            string[] modelosNokia = {
                "C12",
                "G60",
                "C2",
                "C21",
                "G21",
                "C01",
                "C20",
                "C30",
            };

            return modelosNokia[new Random().Next(modelosNokia.Length)];
        }

        public static void Iphone()
        {
            Iphone iphone = new(
                numero: "82999999999",
                modelo: ReceberModeloIPhoneAleatorio(),
                imei: "00009714141248",
                memoria: 1024 * 512
            );

            iphone.Ligar();
            iphone.InstalarAplicativo(
                nomeApp: ReceberAppAleatorio(
                    listaDeExclusao: iphone.Apps.Select(app => app.Nome).ToArray()
                )
            );
            iphone.InstalarAplicativo(
                nomeApp: ReceberAppAleatorio(
                    listaDeExclusao: iphone.Apps.Select(app => app.Nome).ToArray()
                )
            );
            iphone.InstalarAplicativo(
                nomeApp: ReceberAppAleatorio(
                    listaDeExclusao: iphone.Apps.Select(app => app.Nome).ToArray()
                )
            );
            iphone.ListarAplicativosInstalados();
            iphone.MemoriaUtilizada();
            iphone.ReceberLigacao();
        }

        public static void Nokia()
        {
            Nokia iphone = new(numero: "65988888888", modelo: ReceberModeloNokiaAleatorio(), imei: "000051241981720", memoria: 1024 * 512);

            iphone.Ligar();
            iphone.InstalarAplicativo(nomeApp: ReceberAppAleatorio(listaDeExclusao: iphone.Apps.ToArray()));
            iphone.InstalarAplicativo(nomeApp: ReceberAppAleatorio(listaDeExclusao: iphone.Apps.ToArray()));
            iphone.InstalarAplicativo(nomeApp: ReceberAppAleatorio(listaDeExclusao: iphone.Apps.ToArray()));
            iphone.ListarAplicativosInstalados();
            iphone.ReceberLigacao();
        }
    }
}