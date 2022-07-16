int a = new Random().Next(1,100);
int b = new Random().Next(1,100);
int c = new Random().Next(1,100);
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);  
if (a>b && a>c){
    Console.WriteLine("Вывод максимального числа: "+a); 
}
else if (b>a && b>c){
    Console.WriteLine("Вывод максимального числа: "+b);
}
else {
    Console.WriteLine("Вывод максимального числа: "+c);
}
