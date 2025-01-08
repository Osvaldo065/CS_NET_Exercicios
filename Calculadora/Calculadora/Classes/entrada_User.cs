namespace Calculadora.Classes;

class entrada_user{

    public static int Menu_calculadora()
    {
        Console.WriteLine("Escolha a opção de calculo:");

        Console.WriteLine("[1]Soma\n[2]Subtrair\n[3]Divisão\n[4]Multiplicação");
        int opcao_escolhida = Convert.ToInt32(Console.ReadLine());

        return opcao_escolhida;
    }

    public static float Lendo_valores()
    {
        float valor_recebido = 0;

        try
        {
            Console.WriteLine("Digite um valor:");
            valor_recebido = float.Parse(Console.ReadLine());
        }
        catch(FormatException)
        {
            Console.WriteLine("Valor invalido");
        }

        return valor_recebido;
    }

}