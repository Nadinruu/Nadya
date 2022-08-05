int m = IntIput("Введите колличество строк: ");
int n = IntIput("Введите колличество столбцов: ");
int [,] numbers = new int [m,n];
double[] b=new double[m];
double sum =0;
FillArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    sum =0;
	for (int j = 0; j < numbers.GetLength(1); j++)
    {
		Console.Write(numbers[i,j]+ " ");
        sum+=numbers[i,j];
        
    }
	b[i]=sum/m;
    Console.WriteLine("->"+ Math.Round(b[i],1));
}



void FillArray (int [,] array)
{
    for (int i =0; i < array.GetLength(0);i++){
        for (int j =0; j< array.GetLength(1);j++){
            array[i,j] = new Random().Next(0,10);
        }
    }
}


int IntIput (string output){ // выводит число в консоль
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());

}