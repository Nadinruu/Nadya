int m = IntIput("Введите колличество строк: ");
int n = IntIput("Введите колличество столбцов: ");
double [,] numbers = new double [m,n];

FillArray(numbers);
PrintArray (numbers);



void PrintArray (double [,] array)
{
    for (int i =0; i < array.GetLength(0);i++){
        for (int j =0; j< array.GetLength(1);j++){
            Console.Write(Math.Round(array[i,j],1)+ " ");
        }
        Console.WriteLine();
    }
}



void FillArray (double [,] array)
{
    for (int i =0; i < array.GetLength(0);i++){
        for (int j =0; j< array.GetLength(1);j++){
            array[i,j] = new Random().Next(-100,100) + new Random().NextDouble();
        }
    }
}


int IntIput (string output){ // выводит число в консоль
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine();