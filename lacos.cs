// See https://aka.ms/new-console-template for more information




double salario=0.00;
double nfilhos = 0.00;
double mediasalario = 0.00;
double totalsalario = 0.00;
double medianfilhos = 0.00;
double totalfilhos = 0.00;
double maiorsalario = 0.00;
double psalario100 = 0.00;
double contadorsalario = 0.00;

int habitantes = 3;

for (int i = 1; i <= habitantes; i++)
{
    Console.Write("Digite o salario: ");
    salario = double.Parse(Console.ReadLine());
    Console.Write("Digite o numero de filhos: ");
    nfilhos = double.Parse(Console.ReadLine());

    //totalizar
    totalsalario = totalsalario + salario;
    totalfilhos += nfilhos;

    if (salario > maiorsalario)
    {
        maiorsalario = salario;
    }

    if (salario >= 100)
    {
        contadorsalario++;
    }

}
mediasalario = (totalsalario / habitantes);
medianfilhos = (totalfilhos / habitantes);
psalario100 = (contadorsalario / habitantes) * 100;
Console.WriteLine("Total salarios: " + totalsalario);
Console.WriteLine("media salario: " + mediasalario);

Console.WriteLine("Total filhos: " + totalfilhos);
Console.WriteLine("media filhos: " + medianfilhos);

Console.WriteLine("percentual ate 100: " + psalario100+"%");



