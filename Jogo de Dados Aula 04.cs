Random rnd = new Random();
int Dado1, Dado2, Soma, Win, Loss;
Double Saldo;
String SN = "S";
int count;
count = 0;
Win = 0;
Loss = 0;
Saldo = 100;
while (SN.ToUpper()=="S")
{
    Dado1 = rnd.Next(1, 7);
    Dado2 = rnd.Next(1, 7);
    Soma = Dado1 + Dado2;
    #region SORTEIO DOS DADOS
    Console.WriteLine("Dado 1:" + Dado1);
    Console.WriteLine("Dado 2:" + Dado2);
    if (Dado1 == Dado2)
    {
        Console.WriteLine("Parabéns, você ganhou!!!");
        Console.WriteLine("Os dados são iguais!!");
        Win++;
        Saldo = Saldo + 10;
    }
    else if (Soma == 7 || Soma == 11)
    {
        Console.WriteLine("Parabéns, você ganhou!!!");
        Console.WriteLine("A soma dos dados é igual a " + Soma);
        Win++;
        Saldo = Saldo + 10;

    }
    else
    {
        Console.WriteLine("Que pena, não foi desta vez!!!");
        Console.WriteLine("Tente novamente!!!");
        Loss++;
        Saldo = Saldo - 10;
    }
    #endregion
    Console.WriteLine("Você já ganhou " + Win + " vezes!!");
    Console.WriteLine("Você já perdeu " + Loss + " vezes!!");
    Console.WriteLine("Seu saldo está em R$ " + Saldo);    
    Console.Write("Deseja continuar ? (S/N): ");
    SN=Console.ReadLine();
    Console.Clear();
