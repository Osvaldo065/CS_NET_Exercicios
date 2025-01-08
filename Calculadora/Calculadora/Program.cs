using Calculadora.Classes;
using System;
class Program{
    public static void Main(String[] args) {

        Console.WriteLine("Olá, seja bem vindo!!");

        //Chamando o menu da calculadora
        int menu = entrada_user.Menu_calculadora();

        //Solicitando um valor 
        float valorUm = entrada_user.Lendo_valores();

        //Solicitando outro valor
        float valorDois = entrada_user.Lendo_valores();

        float result = 0;

        //Criando uma estrutura de caso para verificar a escolha do usuário
        switch (menu)
        {
            case 1:
                result = Operações.Somar(valorUm, valorDois);
                Console.WriteLine($"O resultado da sua soma é: {result}");
                break;
            
            case 2:
                result = Operações.Subtracao(valorUm, valorDois);
                Console.WriteLine($"O resultado da sua subtração é: {result}");
                break ;

            case 3:
                result = Operações.Divisao(valorUm, valorDois);
                Console.WriteLine($"O resultado da sua divisão é: {result}");
                break;

            case 4:
                result = Operações.Multiplicacao(valorUm, valorDois);
                Console.WriteLine($"O resultado da sua multiplicação é: {result}");        
                break;
            
            default:
                Console.WriteLine("O valor informado está invalido");
                break;
        }
        

        
        
        
    }
}