/*Ganha quando dois numeros sao iguais, se a soma der 7 ou se a soma for 11*/
Random rnd1 = new Random();
int Dado1, Dado2;
Dado1 = rnd1.Next(1, 7);
Dado2 = rnd1.Next(1, 7);
Console.WriteLine("Dado 1:"+ Dado1);
Console.WriteLine("Dado 2:" + Dado2);
if(Dado1 == Dado2) 
{
    Console.WriteLine("Parabéns, Você ganhou!!!");
    
}else if(Dado1 != Dado2)
{    Console.WriteLine("Que pena, não foi dessa vez :(");
    Console.WriteLine("Tente outra vez:)!!!");

}else if(Dado1 + Dado2 == 7 || Dado1 + Dado2 == 11) 
{
    Console.WriteLine("Parabéns, Você ganhou!!!");
    Console.WriteLine("Continue jogando :)");
}
else (Dado1 == Dado2)
{
    Console.WriteLine();
}
