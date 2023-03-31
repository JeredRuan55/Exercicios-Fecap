/*Ganha quando dois numeros sao iguais, se a soma der 7 ou se a soma for 11*/


Random rnd1 = new Random();
int Dado1, Dado2;
Dado1 = rnd1.Next(1, 7);
Dado2 = rnd1.Next(1, 7);
String Nome;

Double Idade;
Console.WriteLine("Para começar digite seu nome: ");
Nome= Console.ReadLine();
Console.WriteLine("Agora digite sua idade: ");
Idade= Convert.ToDouble(Console.ReadLine());
if(Idade<= 17)
{
    Console.WriteLine("Sinto Muito, mas você não pode jogar este jogo :(");
    Console.WriteLine("Tente novamente quando estiver mais velho");
    Environment.Exit(0);
}
else if(Idade>= 45)
{
    Console.WriteLine("Você é velho demais para esse jogo");
    Console.WriteLine("Tente jogar dama!");
    Environment.Exit(0);

}
Console.WriteLine("Olá " + Nome + " !!");
Console.WriteLine("Vamos começar !!" );
Console.WriteLine("Dado 1:" + Dado1);
Console.WriteLine("Dado 2:" + Dado2);
if (Dado1 == Dado2)
{
    Console.WriteLine("Parabéns, Você ganhou!!!");

}
else if (Dado1 != Dado2)
{
    Console.WriteLine("Que pena, não foi dessa vez :(");
    Console.WriteLine("Tente outra vez:)!!!");

}
else if (Dado1 + Dado2 == 7 || Dado1 + Dado2 == 11)
{
    Console.WriteLine("Parabéns, Você ganhou!!!");
    Console.WriteLine("Deseja continuar jogando? :)");
}


