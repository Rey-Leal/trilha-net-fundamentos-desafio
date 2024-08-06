namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal _precoInicial = 0;
        private decimal _precoPorHora = 0;
        private List<string> _veiculos = new List<string>();

        public decimal precoInicial
        {
            get => _precoInicial;
            set
            {
                if (Validacoes.Numerico(value.ToString()))
                {
                    _precoInicial = value;
                }
                else
                {
                    throw new ArgumentException("Preço inicial inválido!");
                }
            }
        }
        public decimal precoPorHora
        {
            get => _precoPorHora;
            set
            {
                if (Validacoes.Numerico(value.ToString()))
                {
                    _precoPorHora = value;
                }
                else
                {
                    throw new ArgumentException("Preço por hora inválido!");
                }
            }
        }

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this._precoInicial = precoInicial;
            this._precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            try
            {
                Console.WriteLine("Digite a placa do veículo (entrada no estacionamento):");
                _veiculos.Add(Console.ReadLine());
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
                if (_veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    Console.WriteLine("Digite a quantidade de horas da estádia no estacionamento:");
                    int horas = Convert.ToInt16(Console.ReadLine());
                    
                    decimal valorTotal = _precoInicial + (_precoPorHora * horas);
                    _veiculos.Remove(placa);

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

                if (_veiculos.Any())
                {
                    Console.WriteLine("Listagem de veículos estacionados:");
                    foreach (var veiculo in _veiculos)
                    {
                        Console.WriteLine($"{contador.ToString("D2")} {veiculo.ToString()}");
                        contador++;
                    }
                }
                else
                {
                    Console.WriteLine("Não existem veículos estacionados.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public bool ExistemVeiculos()
        {
            try
            {
                if (_veiculos.Any())
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}
