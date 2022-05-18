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
            string numero1, numero2, resultado;

            //Escrita do cabeçalho da aplicação:
            Console.WriteLine($"{new String('=', 20)}CALCULADORA{new String('=', 20)}");
            
            //Pede os dois números:
            Console.Write("Digite um número: ");
            numero1 = Console.ReadLine();
            Console.Write("Digite outro número: ");
            numero2 = Console.ReadLine();

            //Criação do referencial dos resultados: 
            Console.WriteLine($"\n{new String('=', 20)}RESULTADOS{new String('=', 20)}");

            //Execução da função Sum e escrita:
            resultado = Soma(numero1, numero2);
            Console.WriteLine(resultado);
            
            //Execução da função Sub e escrita:
            resultado = Subtracao(numero1, numero2);
            Console.WriteLine(resultado);

            //Execução da função Mult e escrita:
            resultado = Multiplicacao(numero1, numero2);
            Console.WriteLine(resultado);

            //Execução da função Div e escrita:
            resultado = Divisao(numero1, numero2);
            Console.WriteLine(resultado);

            //Execução da função Mod e escrita:
            resultado = Modulo(numero1, numero2);
            Console.WriteLine(resultado);
        }

        //Criação da função de soma que recebe 2 strings:
        public static string Soma(string numero1, string numero2)
        {
            //Conversão das strings para float:
            float numero1_float = float.Parse(numero1);
            float numero2_float = float.Parse(numero2);

            //Retorno da String com o calculo:
            return $"{numero1_float} + {numero2_float} = {numero1_float + numero2_float}";
        }

        //Criação da função de subtração que recebe 2 strings:
        public static string Subtracao(string numero1, string numero2)
        {
            //Conversão das strings para float:
            float numero1_float = float.Parse(numero1);
            float numero2_float = float.Parse(numero2);

            //Retorno da String com o calculo:
            return $"{numero1_float} - {numero2_float} = {numero1_float - numero2_float}";
        }

        //Criação da função de multiplicação que recebe 2 strings:
        public static string Multiplicacao(string numero1, string numero2)
        {
            //Conversão das strings para float:
            float numero1_float = float.Parse(numero1);
            float numero2_float = float.Parse(numero2);

            //Retorno da String com o calculo:
            return $"{numero1_float} × {numero2_float} = {numero1_float * numero2_float}";
        }

        //Criação da função de divisão que recebe 2 strings:
        public static string Divisao(string numero1, string numero2)
        {
            //Conversão das strings para float:
            float numero1_float = float.Parse(numero1);
            float numero2_float = float.Parse(numero2);

            //Retorno da String com o calculo:
            return $"{numero1_float} ÷ {numero2_float} = {numero1_float / numero2_float}";
        }

        //Criação da função de módulo que recebe 2 strings:
        public static string Modulo(string numero1, string numero2)
        {
            //Conversão das strings para float:
            float numero1_float = float.Parse(numero1);
            float numero2_float = float.Parse(numero2);

            //Retorno da String com o calculo:
            return $"{numero1_float} % {numero2_float} = {numero1_float % numero2_float}";
        }

    }
}
