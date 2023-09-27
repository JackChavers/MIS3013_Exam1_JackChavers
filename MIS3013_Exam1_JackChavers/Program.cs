// MIS 3013 005
// September 27, 2023
// Jack Chavers, 113493948

using System.Runtime.InteropServices;

Console.WriteLine("MIS 3013 Exam 1");

string outMesStr;
string userChoiceStr;
int nOrder=0;
double subtotal=0;
double pCogs = 0;
double pGears = 0;
int levelbelow=0;
int levelbetween=0;
int levelabove=0;
string nCogsStr;
double nCogsDbl;
string nGearsStr;
double nGearsDbl;
double sumOfAll=0;


do
{
    nOrder = nOrder + 1;
    outMesStr = string.Format($"Please input number of cogs in Order  {nOrder}: ");
    Console.Write(outMesStr);
    nCogsStr = Console.ReadLine();
    nCogsDbl = Convert.ToDouble(nCogsStr);

    outMesStr = string.Format($"Please input number of gears in Order  {nOrder}: ");
    Console.Write(outMesStr);
    nGearsStr = Console.ReadLine();
    nGearsDbl = Convert.ToDouble(nGearsStr);

    pCogs = nCogsDbl * 60;
    pGears = nGearsDbl * 200;
    subtotal = pCogs + pGears;
    sumOfAll = sumOfAll + subtotal;


    if (subtotal > 2000)
    {
        
        outMesStr = string.Format($"The subtotal of order {nOrder} is: {subtotal:C2}, and it is ABOVE $2000");
        Console.WriteLine(outMesStr);
        levelabove = levelabove + 1;
    }
    else if (subtotal >= 1000.00 && subtotal <= 2000.00)
    {
        outMesStr = string.Format($"The subtotal of order {nOrder} is: {subtotal:C2}, and it is BETWEEN $1000.00 and $2000.00");
        Console.WriteLine(outMesStr);
        levelbetween = levelbetween + 1;
        
    }
    else
    {
        outMesStr = string.Format($"The subtotal of order {nOrder} is: {subtotal:C2}, and it is BELOW $1000");
        Console.WriteLine(outMesStr);
        levelbelow = levelbelow + 1;

    }

    Console.Write("Do you want to input another order? (yes/no) ");
    userChoiceStr = Console.ReadLine();

}

while (userChoiceStr == "yes");

Console.WriteLine("Summary Information");
outMesStr = string.Format($"Total number of orders: {nOrder}");
Console.WriteLine(outMesStr);
outMesStr = string.Format($"The number of cogs sold: {nCogsDbl}");
Console.WriteLine(outMesStr);
outMesStr = string.Format($"The number of gears sold: {nGearsDbl}");
Console.WriteLine(outMesStr);
outMesStr = string.Format($"The Sum of all orders' subtotals: {sumOfAll:C2}");
Console.WriteLine(outMesStr);

double levelbelowp=1.0*levelbelow/nOrder;
double levelbetweenp = 1.0*levelbetween / nOrder;
double levelabovep = 1.0*levelabove / nOrder;
outMesStr = string.Format($"Number of orders BELOW $1,000.00: {levelbelow}/{nOrder} ({levelbelowp:P2})");
Console.WriteLine(outMesStr);
outMesStr = string.Format($"Number of orders BETWEEN $1000.00 and $2000.00: {levelbetween}/{nOrder} ({levelbetweenp:P2})");
Console.WriteLine(outMesStr);
outMesStr = string.Format($"Number of orders ABOVE $2,000.00: {levelabove}/{nOrder} ({levelabovep:P2})");
Console.WriteLine(outMesStr);












