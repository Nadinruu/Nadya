int number = new Random().Next(1,10);
int st = new Random().Next(1,10);
int i =1;
int q =1;
    while (i <=st){
      q = number*q;
      i++;
    }
    Console.Write ($"{number},{st}-> {q} ");