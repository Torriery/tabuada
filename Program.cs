int contador , numero;

Console.WriteLine("ola eu sou a calculadora de tabuada !!!");
Thread.Sleep(2000);

Console.WriteLine("digite um numero de 0 a 10");
numero = Convert.ToInt32(Console.ReadLine()!);

contador = 0;

if(numero < 0 || numero > 10){
    Console.WriteLine("digite outro numero");
    Console.ResetColor();
}
else{

    while (contador <= 10)
    {
     int resultado = contador * numero;   
    Console.WriteLine($"{numero} x {contador++} = {resultado}");
    }
    Console.WriteLine("  ");
}
    
