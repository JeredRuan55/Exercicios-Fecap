

/*Ganha quando dois numeros sao iguais, se a soma der 7 ou se a soma for 11*/
//Variáveis

Random rnd1 = new Random();
int Dado1, Dado2, Soma, Win, Loss;
int Count;
Count= 0; 
Win= 0;
Loss= 0;
Console.WriteLine("Vamos começar o Jogo!!");
while (Count <= 10)
{
    Dado1 = rnd1.Next(1, 7);
    Dado2 = rnd1.Next(1, 7);
    Soma = Dado1 + Dado2;
    #region Sorteio dos Dados
    Console.WriteLine("Dado 1:" + Dado1);
    Console.WriteLine("Dado 2:" + Dado2);
    if (Dado1 == Dado2)
    {
        Console.WriteLine("Parabéns, Você ganhou!!!");
        Win++;

    }
    else if (Dado1 != Dado2)
    {
        Console.WriteLine("Que pena, não foi dessa vez :(");
        Console.WriteLine("Tente outra vez:)!!!");
        Loss++;

    }
    else if (Dado1 + Dado2 == 7 || Dado1 + Dado2 == 11)
    {
        Console.WriteLine("Parabéns, Você ganhou!!!");
        Console.WriteLine("Deseja continuar jogando? :)");
        Win++;
    }
    #endregion Sorteio de Dados
    Console.WriteLine("Você já ganhou " + Win + " vezes!!!");
    Console.WriteLine("Você ja perdeu " + Loss + " vezes!!!");
    Count++;
}

