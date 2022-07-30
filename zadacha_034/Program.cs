int[] numbers = new int [5];
Random rand = new Random();
int index = 0;
    for(int i=0; i<numbers.Length;i++)
    {
        numbers[i]= rand.Next(100,1000);
        Console.Write(numbers[i]+" ");
        if(numbers[i]%2==0)
        {
            index++;
        }
        Console.WriteLine();
    }
     Console.WriteLine("Сумма четных чисел: "+index);
