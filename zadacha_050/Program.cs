int m = IntIput("Введите колличество строк: ");
int n = IntIput("Введите колличество столбцов: ");
string positionNumber = strIput("Введите позицию: ");
int [,] numbers = new int [m,n];

FillArray(numbers);
PrintArray (numbers);

if (positionNumber.Length != 2) {
    Console.WriteLine("Введено неверное значение");
}
else {
    int i1 = int.Parse(positionNumber[0].ToString());
    int j1 = int.Parse(positionNumber[1].ToString());

    if (i1>m || j1>n){
      Console.WriteLine($"{positionNumber} - такого значения нет в массиве");  
    }
    else {
        Console.WriteLine(numbers[i1,j1]);
    }
}

void PrintArray (int [,] array)
{
    for (int i =0; i < array.GetLength(0);i++){
        for (int j =0; j< array.GetLength(1);j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
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


string strIput (string output){ // выводит число в консоль
    Console.Write(output);
    return Console.ReadLine();

}
Console.WriteLine();