/*
//Criação de variáveis do tipo float:
float numero1, numero2, soma, subtracao, multiplicacao, divisao, resto;

//Escreve na tela sem a quebra de linha:
Console.Write("Escreva um número: ");
//Lê oque foi digitado na linha, passa para o tipo float e salva na variavel:
numero1 = float.Parse(Console.ReadLine());

Console.Write("Escreva outro número: ");
numero2 = float.Parse(Console.ReadLine());

//Faz as operações entre as duas variáveis e salva nas demais variáveis:
soma = numero1 + numero2;
subtracao = numero1 - numero2;
multiplicacao = numero1 * numero2;
divisao = numero1 / numero2;
resto = numero1 % numero2;

//Faz um cabeçalho inde vai ter 20 caracteres de igual (=):
Console.WriteLine($"{new String('=', 20)}OPERAÇÕES{new String('=', 20)}\n");
//Exibe as informações das operações aritméticas:
Console.WriteLine($"{numero1} + {numero2} = {soma}");
Console.WriteLine($"{numero1} - {numero2} = {subtracao}");
Console.WriteLine($"{numero1} * {numero2} = {multiplicacao}");
Console.WriteLine($"{numero1} / {numero2} = {divisao}");
Console.WriteLine($"{numero1} % {numero2} = {resto}");
*/

//Abertura do projeto:
namespace Operations
{
    //Criação da classe do App:
    class App
    {
        //Inicia a parte principal da classe:
        static void Main(string[] args)
        {
            //Criação das variáveis:
            string number1, number2, result;

            //Escrita do cabeçalho da aplicação:
            Console.WriteLine($"{new String('=', 20)}CALCULADORA{new String('=', 20)}");
            
            //Pede os dois números:
            Console.Write("Digite um número: ");
            number1 = Console.ReadLine();
            Console.Write("Digite outro número: ");
            number2 = Console.ReadLine();

            //Criação do referencial dos resultados: 
            Console.WriteLine($"\n{new String('=', 20)}RESULTADOS{new String('=', 20)}");

            //Execução da função Sum e escrita:
            result = Sum(number1, number2);
            Console.WriteLine(result);
            
            //Execução da função Sub e escrita:
            result = Sub(number1, number2);
            Console.WriteLine(result);

            //Execução da função Mult e escrita:
            result = Mult(number1, number2);
            Console.WriteLine(result);

            //Execução da função Div e escrita:
            result = Div(number1, number2);
            Console.WriteLine(result);

            //Execução da função Mod e escrita:
            result = Mod(number1, number2);
            Console.WriteLine(result);
        }

        //Criação da função de soma que recebe 2 strings:
        public static string Sum(string number1, string number2)
        {
            //Conversão das strings para float:
            float number1_float = float.Parse(number1);
            float number2_float = float.Parse(number2);

            //Retorno da String com o calculo:
            return $"{number1_float} + {number2_float} = {number1_float + number2_float}";
        }

        //Criação da função de subtração que recebe 2 strings:
        public static string Sub(string number1, string number2)
        {
            //Conversão das strings para float:
            float number1_float = float.Parse(number1);
            float number2_float = float.Parse(number2);

            //Retorno da String com o calculo:
            return $"{number1_float} - {number2_float} = {number1_float - number2_float}";
        }

        //Criação da função de multiplicação que recebe 2 strings:
        public static string Mult(string number1, string number2)
        {
            //Conversão das strings para float:
            float number1_float = float.Parse(number1);
            float number2_float = float.Parse(number2);

            //Retorno da String com o calculo:
            return $"{number1_float} × {number2_float} = {number1_float * number2_float}";
        }

        //Criação da função de divisão que recebe 2 strings:
        public static string Div(string number1, string number2)
        {
            //Conversão das strings para float:
            float number1_float = float.Parse(number1);
            float number2_float = float.Parse(number2);

            //Retorno da String com o calculo:
            return $"{number1_float} ÷ {number2_float} = {number1_float / number2_float}";
        }

        //Criação da função de módulo que recebe 2 strings:
        public static string Mod(string number1, string number2)
        {
            //Conversão das strings para float:
            float number1_float = float.Parse(number1);
            float number2_float = float.Parse(number2);

            //Retorno da String com o calculo:
            return $"{number1_float} % {number2_float} = {number1_float % number2_float}";
        }

    }
}