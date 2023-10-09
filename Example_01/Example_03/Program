Console.Write("Введите длину массива: "); 
        if (int.TryParse(Console.ReadLine(), out int length) && length > 0) 
        { 
            int[] array = new int[length]; 
 
            for (int i = 0; i < length; i++) 
            { 
                Console.Write($"Введите элемент {i + 1}: "); 
                if (int.TryParse(Console.ReadLine(), out int element)) 
                { 
                    array[i] = element; 
                } 
                else 
                { 
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число."); 
                    i--; // Повторно запросить элемент 
                } 
            } 
 
            Console.WriteLine("Введенный массив:"); 
            for (int i = 0; i < length; i++) 
            { 
                Console.WriteLine($"Элемент {i + 1}: {array[i]}"); 
            } 
        } 
        else 
        { 
            Console.WriteLine("Некорректный ввод длины массива. Пожалуйста, введите положительное целое число."); 
        }