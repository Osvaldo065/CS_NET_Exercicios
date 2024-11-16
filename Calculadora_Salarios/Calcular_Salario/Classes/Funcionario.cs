namespace Calcular_Salario.Classes
{

    public class Funcionario
    {
        //Metodo para solicitar o nome do funcionario 
        public static string Solicitar_nome()
        {
            //Solicitando o nome do funcionario
            Console.WriteLine("Digite seu nome:");
            string nome_funcionario = Console.ReadLine();
            //retornando o nome do funcionario
            return nome_funcionario;

        }

        //Metodo para solicitar o salario do funcionario

        public static decimal Solicitar_salario()
        {
            //Recebendo o valor do salario bruto
            Console.WriteLine("\nInforme o seu salario Bruto:");
            string entrada_salarial = Console.ReadLine();
            decimal salario_bruto = 0;

            //Realizando a conversão de string para decimal
            try
            {
                salario_bruto = decimal.Parse(entrada_salarial); //Conversão do salario para valor decimal

            }
            catch (FormatException)
            {
                Console.WriteLine("\nO valor digitado invalido. Por favor insira outro valor para o salario.");
                return 0;

            }

            //Retorna o valor do salario
            return salario_bruto;


        }

        //Metodo para solicitar o cargo do funcionario

        public static string Cargo_funcionario()
        {

            //Solicitando o cargo do funcionario
            Console.WriteLine("\nDigite a sua ocupação atual:");
            string nome_cargo = Console.ReadLine();
            
            //Retornando o nome do cargo
            return nome_cargo;

        }

    }
}

