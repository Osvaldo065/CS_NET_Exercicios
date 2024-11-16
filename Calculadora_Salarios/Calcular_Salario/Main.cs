using System;
using System.Text;
using Calcular_Salario.Classes;

class Program 
{
    public static void Main(String[] args)
    {

        Console.WriteLine("\nOlá, seja bem vindo a calculadora de salarios");

        //solicitando o nome
        string nome_funcionario = Funcionario.Solicitar_nome();
        //solictando o cargo
        string cargo_funcionario = Funcionario.Cargo_funcionario();
        //Exibindo o salario com os descontos 
        decimal salario_liquido = Calculando_salario.Desconto_geral();

        //Exibindo o salario
        Console.WriteLine($"\n{nome_funcionario}, com base no seu cargo de {cargo_funcionario}. \nO seu salario liquido é de {salario_liquido}");

    }
}
    







