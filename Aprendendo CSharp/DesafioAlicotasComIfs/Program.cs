using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 1800;

        if(salario < 1900)
        {
            Console.WriteLine("Não precisa pagar imposto");
        }else if(salario >= 1900 && salario <= 2800)
        {
            Console.WriteLine("IR de 7.5%");
            Console.WriteLine("Deduzir R$142");
        }else if(salario >= 2800.01 && salario <= 3751)
        {
            Console.WriteLine("IR de 15%");
            Console.WriteLine("Deduzir R$350");
        }else if(salario >= 3751.01 && salario <= 4664)
        {
            Console.WriteLine("IR de 22.5%");
            Console.WriteLine("Deduzir R$636");
        }
    }
}