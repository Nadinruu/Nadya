int b1 = new Random().Next(0,10);
int k1 = new Random().Next(0, 10);
int b2 = new Random().Next(0, 10);
int k2 = new Random().Next(0, 10);
int x =0;
int y =0;
Console.WriteLine ($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}");
if (k1!= k2 && b1!=b2){
    x=(b1-b2)/(k2-k1);
    y=(k2*b1-k1*b2)/(k2-k1);
        Console.Write(x+", "+y);
}              
else{
    Console.Write ("Точки паралельны или совпадают, введите другие значения.");
}