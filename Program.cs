using static System.Console;

using game.src.Entities;

class Program
{
    static void Main()
    {
        WriteLine("Digite 1 para ser um lutador ou 2 para ser um atirador");
        WriteLine();
        
        var option = int.Parse(ReadLine());
        if (option == 1)
        {
            WriteLine("Você escolheu ser lutador!");
            WriteLine();
            WriteLine("Lutador, insira seu nome!");
            WriteLine();
            string namePerso = ReadLine();
            WriteLine();
            Fighter arus = new Fighter(namePerso, 1, "fighter", 5000);    
            WriteLine("O nome do seu personagem é: "+ arus); 
            WriteLine();
            WriteLine(arus.Attack());    
        }
        else if (option == 2)
        {
            WriteLine("Você escolheu ser atirador!");
            WriteLine();
            WriteLine("Atirado, insira seu nome!");
            WriteLine();
            string namePerso = ReadLine();
            WriteLine();
            Shooter sura = new Shooter(namePerso, 1, "fighter", 5000);    
            WriteLine("O nome do seu personagem é: "+ sura);
            WriteLine();
            WriteLine(sura.Attack());
        }
        else
        {
            WriteLine("Valor incorreto, tente novamente.");

        }
        

    }
}