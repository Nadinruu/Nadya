Console.Write("N =");
int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
int sum =0;
	for(int i = 0; i < n; i++)
    {
		Console.Write($"Ввод с клаиватуры = ");
		a[i] = Convert.ToInt32(Console.ReadLine());
		if (a[i]>0)
		{
			sum+=1;	
		}
    }
	Console.Write("Вывод суммы:"+sum);