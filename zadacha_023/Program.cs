int number = new Random().Next(1,10);
Console.WriteLine ($"Вывод числа: {number} ");
int i =1;
    while (i <=number){
      double q = Math.Pow(i,3);
      Console.Write ($"{q} ");
      i++;
    }
