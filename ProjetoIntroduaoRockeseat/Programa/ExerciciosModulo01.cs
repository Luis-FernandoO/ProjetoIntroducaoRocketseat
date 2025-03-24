using System.Diagnostics.Tracing;
using System.Text.RegularExpressions;
using System.Threading.Channels;

namespace ProjetoIntroduaoRockeseat.Programas;

public static class ExerciciosModulo01

{

    //EX 01 - Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida.
    public static void ExibeBemVindoComNome()
    {
       

        Console.WriteLine("Digite seu nome: ");
        var nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}!, Seja muito bem-vindo!");
    }
    //EX 02 - Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.
    public static void ExibeNomeESobrenomeUsuario()
    {
        Console.WriteLine("Digite seu Nome: ");
        var nome = Console.ReadLine();
        Console.WriteLine("Agora Digite seu Sobrenome: ");
        var sobrenome = Console.ReadLine();

        var nomeCompleto = $"Nome Completo do Usuário: {nome} {sobrenome}";
        Console.WriteLine(nomeCompleto);

    }
    //EX 03 - Crie um programa com 2 valores do tipo double já declarados que retorne(Soma, Subtracao,Multiplicacao, Divisao e Média).
    public static void ExibeResultadoOperacoes()
    {
        Console.WriteLine("Digite um numero para poder realizar uma operação: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite outro numero para poder realizar uma operação: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
       
        double soma = num1 + num2;
        double subtracao = num1 - num2;
        double multiplicacao = num1 * num2;
        double media = (num1 + num2) / 2;
        double divisao = num1 / num2;



        if (num2 == 0) 
        {
            Console.WriteLine("Não vai ser possivel fazer a operação de Divisão pois é impossivel dividir por 0");
            Console.WriteLine($"""
            Soma: {num1} + {num2} = {soma}
            Subtração: {num1} - {num2} = {subtracao} 
            Multiplicação: {num1} x {num2} = {multiplicacao}
            Média: ({num1} + {num2}) / 2 = {media}
            """);
        }
        else
        {

            Console.WriteLine($"""
            Soma: {num1} + {num2} = {soma}
            Subtração: {num1} - {num2} = {subtracao} 
            Multiplicação: {num1} x {num2} = {multiplicacao}
            Divisão: {num1} / {num2} = {divisao}
            Média: ({num1} + {num2}) / 2 = {media}
            """);

        }
    }
    //EX 04 - Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.
    public static void ExibeQuantidadeDeCaracteres()
    {
        Console.WriteLine("Digite uma ou mais palavaras: ");
        var mensagem = Console.ReadLine();
        
        var qtdCaracteres = mensagem.Length;
        Console.WriteLine($"Quantidade de Caracteres: {qtdCaracteres}");
    }
    //EX 05 - Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018.
    public static void VerificaSePlacaEValida()
    {
        Console.WriteLine("Digite a placa do seu veiculo: ");
        var placa = Console.ReadLine().ToUpper().Trim();

        string padrao = @"^[A-Z]{3}\d{4}$";
        if (Regex.IsMatch(placa, padrao))
            Console.WriteLine("Placa Válida: Verdadeiro!");
        else
            Console.WriteLine("Placa Válida: Falso!");
    }
    //EX 06 - Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos.
    public static void ExibicaoData()
    {
        Console.WriteLine("Selecione o tipo de Exibição da data Atual: ");
        Console.WriteLine("""
            1 - DATA (EX: SEGUNDA,20, 01, 2025, 12, 00, 00)
            2 - DATA (EX: 20/01/2025)
            3 - HORA (EX: 12:00:00)
            4 - DATA (EX: 20 janeiro, 2025)
            """);
        int op = Convert.ToInt32(Console.ReadLine());

        var data = "";

        switch (op)
        {
            case 1:
                data = DateTime.Now.ToString("dddd, dd, MM, yyyy, HH,MM, ss");
                Console.WriteLine(data);
                break;
            case 2:
                data = DateTime.Now.ToString("dd/MM/yyyy");
                Console.WriteLine(data);
                break;
            case 3:
                data = DateTime.Now.ToString("HH:mm:ss");
                Console.WriteLine(data);
                break;
            case 4:
                data = DateTime.Now.ToString("dd MMMM, yyyy");
                Console.WriteLine(data);
        break;
}
}
}

