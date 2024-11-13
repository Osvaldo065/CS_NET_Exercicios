using Arvore_Familia.Classes;
using System;

class Program {
    public static void Main(String[] args)
    {   //Exibindo uma mensagem inicial
        Console.WriteLine("verificando a arvore genealogica!");

        //Solicitando o nome do membro da familia
        Console.WriteLine("Digite o nome do membro da familia:\n");
        //variavel recebendo o nome digitado pelo usario
        string nome_membro = Console.ReadLine();


        //Criando um objeto mae e passando para a variavel mn
        Mae mn = new Mae();
        //Criando um objeto filho e passando para a variavel fl
        Filhos fl = new Filhos();
        //Criando um objeto avos e passando para a variavel avs
        Avos avs = new Avos();
        //Criando um objeto pai e passando para a variavel pa
        Pai pa = new Pai();

        //Verificando se o nome digitado está vinculado a familia e qual a arvore genealogica dele(a).
        if (nome_membro.Equals(mn.nome_mae, StringComparison.OrdinalIgnoreCase))
        {

            Console.WriteLine("O membro da familia é a mâe: " + mn.nome_mae);
            Console.WriteLine(mn.nome_mae + " é mãe de " + fl.nome_filho);
            Console.WriteLine(mn.nome_mae + " é esposa de " + pa.nome_pai);
            Console.WriteLine(mn.nome_mae + " é nora de " + avs.nome_avó + " e " + avs.nome_avô);
        }
        else if (nome_membro.Equals(fl.nome_filho, StringComparison.OrdinalIgnoreCase)) {

            Console.WriteLine("O membro da familia é o filho: " + fl.nome_filho);
            Console.WriteLine(fl.nome_filho + " é filho de " + mn.nome_mae + " e " + pa.nome_pai);
            Console.WriteLine(fl.nome_filho + " é neto de " + avs.nome_avó + " e " + avs.nome_avô);
            Console.WriteLine(fl.nome_filho + " é neto de " + avs.nome_avó + " e " + avs.nome_avô);
        }
        else if (nome_membro.Equals(pa.nome_pai, StringComparison.OrdinalIgnoreCase)){

            Console.WriteLine("O memrbo da familia é o pai: " + pa.nome_pai);
            Console.WriteLine(pa.nome_pai + " é marido de " + mn.nome_mae + " e pai de" + fl.nome_filho);
            Console.WriteLine("Os pais de " + pa.nome_pai + " são " + avs.nome_avó + " e " + avs.nome_avô);

        }
    }
}