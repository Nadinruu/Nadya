int a = new Random().Next(1, 100);
    int i =1;
    Console.WriteLine("Вывод числа: " + a);
    while(a>=i){
        if((i%2)==0){
        Console.WriteLine(i);
        }
        i++;
    }
