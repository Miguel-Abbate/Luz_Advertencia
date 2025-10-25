Console.Clear(); // limpa a tela

bool t, p, r, w; // chama a função e cria variaveis do tipo

Console.WriteLine("--- Simulador de Luz de Advertência ---\n");
Console.WriteLine("[A]tivado, [outro] Desativado\n");

Console.Write("Sensor de temperatura...: ");
string sensorT = Console.ReadLine()!.ToUpper(); // le a entrada e armazena a estring
t = (sensorT == "A");

Console.Write("Sensor de pressão.......: ");
string sensorP = Console.ReadLine()!.ToUpper(); // le a entrada e armazena a estring
p = (sensorP == "A");

Console.Write("Sensor de rotação.......: ");
string sensorR = Console.ReadLine()!.ToUpper(); // le a entrada e armazena a estring
r = (sensorR == "A");

w = t && (p || !r); //&& "E" , || "OU"


string resultado;

if (w) // se
{
    resultado = "ATIVADA";
}
else // senao
{
    resultado = "DESATIVADA";
}

// resultado = w ? "ATIVADA" : "DESATIVADA"; outro comando alternativo ao anterior

Console.WriteLine($"\nA luz de advertência estará {resultado}.");
