int[] numbers = new int [] {1, 7, 6, 9, 21};
int numMax = 0; 
int numMin = numbers[0]; // присваиваем нулевой элемент массива
for (int i = 0; i<numbers.Length; i++){
	if (numbers[i]<numMin)
	{
		numMin = numbers[i]; 
	}    
	else{
	    if (numbers[i]>numMax){
		    numMax = numbers[i];
	    }
    }
}
 
Console.WriteLine("Вывести максимальное: " +numMax);
Console.WriteLine("Вывести минимальное: " + numMin);
numMax = numMax-numMin;
Console.WriteLine("Разница: " + numMax);
