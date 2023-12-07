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
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // FEITO 🐱‍👤
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);         
        }

        public void RemoverVeiculo()
        {           
            
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            //FEITO 🐱‍👤
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal  
                // FEITO 🐱‍👤   
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
    
                 int horas = int.Parse(Console.ReadLine());

                 decimal valorTotal = precoInicial + precoPorHora * horas;
                
                // TODO: Remover a placa digitada da lista de veículos
                // FEITO 🐱‍👤
                 veiculos.Remove(placa);
                

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }
        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // FEITO 🐱‍👤
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                  Console.WriteLine(veiculo);
                }     
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
