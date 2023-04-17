
int Tabuada;
Console.WriteLine("***PROGRAMA DA TABUADA***");
Console.Write("Entre com a tabuada que deseja: ");
Tabuada = Convert.ToInt32(Console.ReadLine());
for(int i =1; i <= 10; i++)
{
    Console.WriteLine(i + " x " + Tabuada + " = " + (i * Tabuada));
}
