
namespace Calcular_Salario.Classes {

    //Desconto INSS Aliquota

    // Até R$ 1.302,00	7,5%
    // De R$ 1.302,01 até R$ 2.571,29	9%
    // De R$ 2.571,30 até R$ 3.856,94	12%
    // De R$ 3.856,95 até R$ 7.507,49	14%

    public class Calculando_salario
    {
        //Metodo para calcular o desconto do INSS
        public static decimal Desconto_inss(decimal salario_bruto)
        {

            decimal desconto_inss = 0;

            //Condicional para verificar o salario e calcular conforme a aliquo do INSS
            if (salario_bruto <= 1302.00m)
            {
                desconto_inss = salario_bruto * 0.075m;
            }
             else if (salario_bruto >= 1302.01m || salario_bruto <= 2571.29m)
            {
                desconto_inss = salario_bruto * 0.09m;

            }
            else if (salario_bruto >= 2571.30m || salario_bruto <= 3856.94m)
            {
                desconto_inss = salario_bruto * 0.12m;
            }
            else if (salario_bruto >= 3856.95m || salario_bruto <= 7507.49m)
            {
                desconto_inss = salario_bruto * 0.14m;
            }

            return desconto_inss;

        }

        //Aliquota IRRF

        //Até R$ 1.903,98	Isento	-
        //De R$ 1.903,99 até R$ 2.826,65	7,5%	R$ 142,80
        //De R$ 2.826,66 até R$ 3.751,05	15%	R$ 354,80
        //De R$ 3.751,06 até R$ 4.664,68	22,5%	R$ 636,13
        //Acima de R$ 4.664,68	27,5%	R$ 869,36

        public static decimal Desconto_IRRF(decimal salario_bruto)
        {
            decimal desconto_imposto = 0;

            //Condicional para verificar o desconto de imposto de renda

            if(salario_bruto <= 1903.98m){

                desconto_imposto = 0;

            }
            else if(salario_bruto >= 1903.99m || salario_bruto <= 2826.65m){

                desconto_imposto = salario_bruto * 0.075m;

            }
            else if(salario_bruto >= 2826.66m || salario_bruto <= 3751.05m)
            {
                desconto_imposto = salario_bruto * 0.15m;
            }
            else if( salario_bruto >= 3751.06m || salario_bruto <= 4664.68m)
            {
                desconto_imposto = salario_bruto * 22.05m;
            }
            else if(salario_bruto >= 4664.69m)
            {
                desconto_imposto = salario_bruto * 27.05m;
            }

            return desconto_imposto;
        }

        //Metodo para calcular todos os descontos
        public static decimal Desconto_geral()
        {
            decimal salario_bruto = Funcionario.Solicitar_salario();
            decimal desconto_inss = Desconto_inss(salario_bruto);
            decimal desconto_irrf = Desconto_IRRF(salario_bruto);
            //Calculando os descontos 

            decimal salario_liquido = salario_bruto - desconto_inss - desconto_irrf;


            return salario_liquido;
        }
    }
}