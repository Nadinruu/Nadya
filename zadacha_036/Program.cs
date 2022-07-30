int[] numbers = new int [5];
Random rand = new Random();
int sum = 0;
    for(int i=0; i<numbers.Length;i++){
        numbers[i]= rand.Next(0,99);
        Console.Write(numbers[i]+" ");
        if(numbers[i]%2!=0){
            sum+=numbers[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine("Сумма чисел нечетных позиций: "+sum);
