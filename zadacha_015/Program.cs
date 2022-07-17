int number = Convert.ToInt32(Console.ReadLine());
   int f = 6;
   int g =7;
   if (f==number || g==number){
      Console.WriteLine("{number} -> Да");}
    else if (number > 7 || number < 1){
    Console.WriteLine("Введите число от 1 до 7");
    }
    else {
      Console.WriteLine($"{number} -> Нет");
    }
