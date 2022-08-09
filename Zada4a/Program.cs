      string[] arr; 
      int count; 
      string stroka;
      string[] arr2; 

      // Заполнение массива с клавиатуры строками, через энтер, если ничего не ввести и нажать энтер - заполнение массива прекращается.

      Console.WriteLine("Введите строки, чтобы закончить нажмите Enter:");

      count = 0; 
      arr = new string[count]; 

      do
      {
        
        stroka = Console.ReadLine();

        
        if (stroka!="")
        {
          
          count++;

          
          arr2 = new string[count];

          
          for (int i = 0; i < arr2.Length - 1; i++)
            arr2[i] = arr[i];

          
          arr2[count - 1] = stroka;

          
          arr = arr2;
        }
      } while (stroka != "");

      // Заполнение нового массива элементами из первого масиива, если они не длиннее 3 символов.
      
      for (int i = 0; i < arr.Length; i++)
      {
        int k = 0;
       
        int size = arr[i].Length;
        if (size < 4)
        {
            k++;
            string [] arr3 = new string [k];
            for(int j = 0; j < k; j++)
            {
                
                arr3[j] = arr[i];

              
                Console.WriteLine($"Строки не длиннее 3 символов: {arr3[j]}");  // Вывод на экран каждого элемента нового массива
            }
            
            
        }
        
      }
      