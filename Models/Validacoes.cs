namespace DesafioFundamentos.Models
{
    public class Validacoes
    {
        public static bool Numerico(string value)
        {
            try
            {
                return int.TryParse(value, out _) ||
                   double.TryParse(value, out _) ||
                   decimal.TryParse(value, out _);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

    }
}
