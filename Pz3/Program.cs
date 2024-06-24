// // Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// // Использовать рекурсию, не использовать циклы..


int[] array = {10,2,5,4,5,6,6};
int iter = 0;
      
PrintArr(array,iter);
			
static void PrintArr(int[] array, int i)
    {
	  if (i >= array.Length) 
      {
	    return;
	  }
	  PrintArr(array,i+1);
	  Console.Write(array[i]+" ");
	}
		
	
