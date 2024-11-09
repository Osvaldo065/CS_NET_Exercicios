using Arvore_Familia.Classes;
using System;

class Program {
    public static void Main(String[] args)
    {
        Pessoa pessoaUm = new Pessoa();

        pessoaUm.Nome = "Osvaldo";
        pessoaUm.Idade = 20;
        pessoaUm.Apresentar();
    }
}