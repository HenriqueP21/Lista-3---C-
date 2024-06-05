using System;
namespace TerceiraAtividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1 – Peça para o usuário informar um login e uma senha e verifique:
            - Se o login for igual a “admin” e a senha igual a “1234”, escreva, “Pode
            acessar”
            - Senão, escreva, “Login ou senha incorreto” */

            Console.WriteLine("Insira seu Usuário:");
            string login = Console.ReadLine();

            Console.WriteLine("\nInsira sua senha:");
            string senha = Console.ReadLine();

            if (login == "admin" && senha == "1234")
            {
                Console.WriteLine("\nPode Acessar");
            }
            else
            {
                Console.WriteLine("Login ou Senha Incorreta");
            }


            /* 2 - Uma loja solicitou um sistema para verificar as blusas do estoque.
            - Se a quantidade for maior que 40, escreva, “ESTOQUE OK”
            - Se a quantidade for maior que 20 e menor ou igual a 40, escreva,
            “ATENÇÃO AO ESTOQUE”
            - Senão, escreva “ESTOQUE CRITICO” */

            Console.WriteLine("Insira a Quantitade de Blusas no Estoque:");
            int qntEstoque = int.Parse(Console.ReadLine());

            if (qntEstoque > 40)
            {
                Console.WriteLine("Estoque OK");
            }
            else if (qntEstoque > 20 && qntEstoque < 40)
            {
                Console.WriteLine("Atenção ao Estoque");
            }
            else
            {
                Console.WriteLine("Estoque Crítico");
            }


            /* 3 – Para conseguir o visto de outro país é solicitado informações sobre
            o usuário, como idade e salário, se a idade for maior ou igual a 18 e o
            salário for maior que R$2000, escreva, “PODE VIAJAR”, senão, escreva,
            “NÃO PODE VIAJAR” */

            Console.WriteLine("Insira sua Idade:");
            int idadeVistoViagem = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira seu Salário:");
            double salarioVistoViagem = double.Parse(Console.ReadLine());

            if (idadeVistoViagem >= 18 && salarioVistoViagem > 2000)
            {
                Console.WriteLine("\nPode viajar!");
            }
            else
            {
                Console.WriteLine("\nNão pode viajar!");
            }


            /* 4 – Os alunos de uma escola podem escolher uma aula diferente todo
            mês, para decidirem isso, é feito uma enquete.
            - Quem digitou o número 1 ou 2, optou pela aula de desenho e pintura,
            então, escreva “DESENHO E PINTURA”.
            - Quem digitou o número 3 ou 4, optou pela aula de discurso e debate,
            então, escreva “DISCURSO E DEBATE”.
            - Quem digitou outro número irá fazer aula de dança, então, escreva,
            “DANÇA” */

            Console.WriteLine("Vote na Aula do Mês: \nOs votos 1 e 2 são para: Desenho e Pintura; \nOs votos 3 e 4 são para Discurso e Debate; \nOutros Valores de Voto são para Dança.");

            Console.WriteLine("\nInsira seu Voto:");
            int voto = int.Parse(Console.ReadLine());

            if (voto == 1 || voto == 2)
            {
                Console.WriteLine("Desenho e Pintura");
            }
            else if (voto == 3 || voto == 4)
            {
                Console.WriteLine("Discurso e Debate");
            }
            else
            {
                Console.WriteLine("Dança");
            }


            /* 5 – O usuário irá digitar um número, verifique se:
            - Se o número digitado é positivo (maior que zero) e maior que 100 ao
            mesmo tempo, se sim, escreva “número especial”
            - Senão, escreva “fora do intervalo” */

            Console.WriteLine("Insira um valor: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor > 0 && valor > 100)
            {
                Console.WriteLine("Valor Especial");
            }
            else
            {
                Console.WriteLine("Fora do Intervalo");
            }
        }
    }
}