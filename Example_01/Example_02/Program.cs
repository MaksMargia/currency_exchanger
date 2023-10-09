using System.Collections;

float rublesInWallet;
float dollarInWallet;
int rubToUsd = 64, usdToRub = 66;

float exchangeCurrencyCount;
string desiredOperetion;
Console.WriteLine("Добро пожаловать в обменник валют");
System.Console.Write("Введите баланс рублей:");
rublesInWallet = Convert.ToSingle(Console.ReadLine());
System.Console.WriteLine("Введите баланс долларов ");
dollarInWallet = Convert.ToSingle(Console.ReadLine());
System.Console.WriteLine("Выберете необходимую операцию");
System.Console.WriteLine("1 - обменять рубли на доллары");
System.Console.WriteLine("2 - обменять доллары на рубли");
System.Console.WriteLine("Ваш выбор:");
desiredOperetion = Console.ReadLine();

switch (desiredOperetion)
{
  case "1":
    System.Console.WriteLine("Обмен рублей на доллары");
    System.Console.WriteLine("сколько вы хотите обменять?");
    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine()); 
    if(rublesInWallet >= exchangeCurrencyCount)
    {
        rublesInWallet -= exchangeCurrencyCount;
        dollarInWallet += exchangeCurrencyCount / rubToUsd;
    }
    else
    {
        System.Console.WriteLine("Недостаточно рублей");
    }
    break;

   case "2":
   System.Console.WriteLine("Обмен долларов на рубли");
   System.Console.WriteLine("Сколько вы хотите обменять?");
    exchangeCurrencyCount  = Convert.ToSingle(Console.ReadLine());
    if (dollarInWallet >= exchangeCurrencyCount)
    {
        dollarInWallet -= exchangeCurrencyCount;
        rublesInWallet += exchangeCurrencyCount * usdToRub;
    }    
    else 
    {
        System.Console.WriteLine("Недопустимое количество долларов");
    }
    break;
   default:
   Console.WriteLine("Выбрана неверная операция");
   break;
}  

System.Console.WriteLine($"Ваш баланс: {rublesInWallet} рублей "+ $"{dollarInWallet} долларов");
   