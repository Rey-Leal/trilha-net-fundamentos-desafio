namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            try
            {
                Console.WriteLine("Digite a placa do veículo (entrada no estacionamento):");
                veiculos.Add(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RemoverVeiculo()
        {
            try
            {
                Console.WriteLine("Digite a placa do veículo para remover (saída do estacionamento):");
                string placa = Console.ReadLine();

                // Valida existencia da placa digitada nos veiculos estacionados
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    Console.WriteLine("Digite a quantidade de horas da estádia no estacionamento:");
                    int horas = Convert.ToInt16(Console.ReadLine());
                    decimal valorTotal = precoInicial + (precoPorHora * horas);
                    veiculos.Remove(placa);
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Este veículo não está estacionado aqui. Confira a digitação da placa e tente novamente!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ListarVeiculos()
        {
            try
            {
                int contador = 1;

                // Verifica se há veículos no estacionamento
                if (veiculos.Any())
                {
                    Console.WriteLine("Listagem de veículos estacionados:");
                    foreach (var veiculo in veiculos)
                    {
                        Console.WriteLine($"{contador.ToString("D3")} {veiculo.ToString()}");
                    }
                }
                else
                {
                    Console.WriteLine("Não há veículos estacionados.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
