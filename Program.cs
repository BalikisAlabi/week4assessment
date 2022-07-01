using System;

namespace Week4Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("-----------QUESTION 1---------------");

        	//Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, 
          // such that the remainder of their division by 5 is 0. Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.
               
               Console.WriteLine(" Enter your first input");
               int firstNum = int.Parse(Console.ReadLine());
               Console.WriteLine(" Enter your second input");
               int secondNum = int.Parse(Console.ReadLine());
               for (int B = firstNum; B<= secondNum; B++)
               {
                if (B % 5== 0); 
                 Console.WriteLine($"The number between them is divisible by 5: {B}");
               }
              
            
            Console.WriteLine("----------QUESTION 2-------------");

        	//Write a program that prints on the console the first 100 numbers in the Fibonacci 
            //sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …

            int num1 = 0, num2 = 1, nextNumber,Number = 101;

            Console.Write($"{num1 + " " + num2},");
            for (int a = 2; a < Number; a++)
            {
                nextNumber = num1 + num2;
                Console.Write($"{nextNumber},");
                num1 = num2;
                num2 = nextNumber;

            }

            Console.WriteLine("------------QUESTION 3------------");
          // 	Write a program that finds the greatest of given 5 numbers.
           int cat = 0;
           int dog = 0;
           int eat = 0;
           int frog = 0;
           int goat = 0;
           int horse = 0;
          Console.WriteLine(" Enter first number");
          int.Parse(Console.ReadLine());
          Console.WriteLine("Enter the second number");
          int.Parse(Console.ReadLine());
          Console.WriteLine("Enter the third number");
          int.Parse(Console.ReadLine());
          Console.WriteLine("Enter the fourth number");
          int.Parse(Console.ReadLine());
          Console.WriteLine("Enter the fifth number");
          int.Parse(Console.ReadLine());

          int [] greatestNumber = Math.Max(cat, dog, eat, frog, goat, horse);
          Console.WriteLine($"The greatest number is : {greatestNumber}");
          Console.WriteLine();
           

           Console.WriteLine("------------QUESTION 4------------");

            Console.Write("Input A : ");
            double a = double.parse(Console.ReadLine());
            Console.Write("Input B: ");
            double b = double.parse(Console.ReadLine());
            Console.Write("Input C: ");
            double c =double.parse(Console.ReadLine());
            double d = (double)(b * b - 4 * a * c);
            if (d < 0)
                Console.WriteLine("\nD={0}\nThere are no real roots.", d);
            else if (d == 0)
            {
                double x1 = (double)(-b / 2 * a);
                Console.WriteLine("\nX={0}", x1);
            }
            else
            {
               double x1 = (double)((-b + Math.Sqrt(d)) / (2 * a));
                double x2 = (double)((-b - Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("\nX1={0}\nX2={1}", x1, x2);
            }
            Console.ReadLine();
          
            Console.WriteLine("------------QUESTION 5------------");
              /*	Write a program that applies bonus points to given scores in the range [1…9] by the following rules: 
             •	If the score is between 1 and 3, the program multiplies it by 10.
             •	If the score is between 4 and 6, the program multiplies it by 100. 
             •	 If the score is between 7 and 9, the program multiplies it by 1000.
             •	 If the score is 0 or more than 9, the program prints an error message.*/

             Console.WriteLine("Enter the bonuspoints between 1 and 9");
            bonusPoints = ConvertToint32(Console.ReadLine());
            if (bonusPoints>= 1 && <=3)
             Console.WriteLine($" Score is : {bonusPoints} * 10");
             else (bonusPoints>= 4 && <= 6)
             Console.WriteLine($"Score is : {bonusPoints} *100");
             if (bonusPoints>= 7 && <=9)
             Console.WriteLine($"Score is : {bonusPoints} *1000");
             else
             Console.WriteLine("Wrong input");

              Console.WriteLine("------------QUESTION 6------------");

             /*Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously.
              The number N should be read from the standard input*/
            
              
               int s = 1;
              int jk = int.Parse(Console.ReadLine());
              while (s <= jk)
              { 
                if (s % 3 != 0 || s % 7 != 0)
                {
                    Console.WriteLine(s);
                }
                s++;
              }

              
              Console.WriteLine("------------QUESTION 7------------");
              
            	/*Write a program that prints all possible cards from a standard deck of cards, without jokers 
                (there are 52 cards: 4 suits of 13 cards).
                 Hints (Number the cards from 2 to 14 (these numbers will match the cards 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A).
                  Number the suits from 1 to 4 (1 – club, 2 – diamond, 3 – heart and 4 – spades).
                   Now you can use the two nested loops and print each of the cards with two switch statements)*/

                   for (int i = 0; i < 4; i++)
            {
                if(i != 0) Console.WriteLine();

                for (int j = 0; j < 13; j++)
                {
                    switch (i)
                    {
                        case 0:
                             Console.Write("Hearts "); 
                             break;
                        case 1:
                             Console.Write("Diamonds "); 
                             break;
                        case 2: 
                            Console.Write("Spades "); 
                            break;
                        case 3: 
                            Console.Write("Clubs ");
                             break;
                    }
                    switch(j)
                    {
                        case 0: 
                            Console.WriteLine("2"); 
                            break;
                        case 1: 
                            Console.WriteLine("3"); 
                            break;
                        case 2:
                             Console.WriteLine("4"); 
                             break;
                        case 3: 
                            Console.WriteLine("5"); 
                            break;
                        case 4:
                             Console.WriteLine("6");
                              break;
                        case 5: 
                            Console.WriteLine("7");
                             break;
                        case 6: 
                            Console.WriteLine("8"); 
                            break;
                        case 7: 
                            Console.WriteLine("9"); 
                            break;
                        case 8: 
                            Console.WriteLine("10");
                             break;
                        case 9: 
                            Console.WriteLine("J"); 
                            break;
                        case 10: 
                            Console.WriteLine("Q"); 
                            break;
                        case 11: 
                            Console.WriteLine("K"); 
                            break;
                        case 12:
                             Console.WriteLine("A");
                              break;
                    }
                }
            }
            Console.ReadLine();

                Console.WriteLine("------------QUESTION 8------------");
        	//Write a program that reads from the console number N and print the sum of the first N members of the 
            //Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
             

             int N1 = 0, N2 = 1, N3 = 0;
             Console.WriteLine("Enter number to print the sum");
            int n = int.Parse(Console.ReadLine());
            
            Console.Write($"0, 1");
            for (int a = 2; a<= n; n++)
            {
                N3 = N1 +N2;
                Console.Write ($"{0},",N3);
                N1 = N2;
                N2 =N3;

            }

                    Console.WriteLine("------------QUESTION 9------------");
             	//Write a program that for a given number n, outputs a matrix in the form of a spiral: 
               //Example for n=4 
                 //1	2	3	4
                //12	13	14	5
                //11	16	15	6
                //10	9	8	7

                    spiralprints(int m, int n, int a{R} {C})
                    int, k = 0, l = 0;
                    while(k < m && l < n)
                    for (i = l; i < n; ++i)
                    {
                      printf("%d ", a[k][i]);
                    }
                    k++
                    for (i = k; i < m; ++i)
                    {
                        printf("%d ", a[i][n-1]);
                    }
                    n--
                    if (k < m)
                    {
                        for(i = n-1; i >= 1; --i)
                        {
                           printf("%d ", a[m-1][i]); 
                        }
                        m--
                    }
                    if (l < n)
                    {
                        for(i = m-1; i >= k; --i)
                
                        {
                           printf("%d ", a[i][l]); 
                        }
                        l++
                    }

                    {int a[R] [C]{{1,  2,  3},
                                 {4,  5,  6},
                                 {7,  8,  9},
                                 {10, 11, 12},
                                 {13, 14, 15}
                               }
                        spiralPrint(R,C,a);

                        return 0;
                    }
            
                Console.WriteLine("------------QUESTION 10------------");

            	Write a program, which creates an array of 20 elements of type integer and initializes each of the elements 
                with a value equals to the index of the element multiplied by 5. 
                Print the elements to the console.

                int [] ele= new int[20]
                for (int i = 0; i < ele.Length; i++)
                {
                   ele[i] = i*5;
                 Console.Write([i]);
 
                }

                Console.WriteLine("------------QUESTION 11------------");

             //	Write a program, which reads two arrays from the console and checks whether they are equal 
               // (two arrays are equal when they are of equal length and all of their elements,
               //  which have the same index, are equal). 

               int [] arr1 = [2, 3, 4];
               int [] arr2 = [2, 4, 3];
               if(arr1== arr2)
               {
                 Console.WriteLine("Correct");
               }
               else
               {
                Console.WriteLine("Wrong");
               }

                Console.WriteLine("------------QUESTION 12------------");

            	//Write a program, which finds the maximal sequence of consecutive equal elements in an array.
                 //E.g.: {1, 1, 2, 3, 2, 2, 2, 1} {2, 2, 2}. 
                    
                    int first = 1, second = 1, number = 0;
                    int [] max = [1, 1, 2, 3, 3, 3, 3, 2, 2, 1];
                    int[] arr = new int[max];
                       for (int i = 0; i < arr.Length; i++) 
		     	{
				Console.Write ("Enter {0} element: ", i);
				arr [i] = Int32.Parse (Console.ReadLine ());
		     	}
		    	for (int i = 0; i < arr.Length - 1; i++) 
			    {
                     if (arr[i] == arr[i + 1]) second++;
                        else second = 1;
				if (second > first) 
				{
					first  = second;
					number = arr [i];
				}
			for (int i = 0; i < first; i++) Console.Write ("{0}, ", number);

                    
                Console.WriteLine("------------QUESTION 13------------");

                //Write a program, which finds the most frequently occurring element in an array. 
                //Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} 4 (5 times). 

                int arry[] = { 2,5,3,4,5,3,3};
                int n = math.mostFrequent(arry);
               {
                 Console.WriteLine($"{n}");
               }
               
                 Console.WriteLine("------------QUESTION 14------------");

            	//Write a program that converts a decimal number to binary one
                Console.WriteLine("Enter a decimal number");
                int decimalNumber = int.Parse(Console.ReadLine());
                int binaryValue = 0;
                int base1 = 1;
                while(decimalNumber > 0)
                {
                  int remainder = decimalNumber % 2;
                  decimalNumber = decimalNumber / 2;
                  binaryValue +=  remainder * base1;
                  base = base1 * 10; 
                }
                Console.WriteLine($" Binary value is {binaryValue}");

                Console.WriteLine("------------QUESTION 15------------");
            	//Write a program that converts a binary number to decimal one. 
                Console.WriteLine("Enter a binary number"); 

               Console.WriteLine("------------QUESTION 16------------"); 
              // Write a program that converts a decimal number to hexadecimal one.  
               Console.Write("Enter binary number: ");
                 int binaryNumber = int.Parse(Console.ReadLine());
                 int decimalNumber = Convert.ToInt32(binaryNumber.ToString(), 2);           
                 Console.Write($"Decimal Value : {decimalNumber} ");

                 Console.WriteLine("------------QUESTION 17------------");
                 //Write a program that converts a hexadecimal number to decimal one
                 Console.Write("Enter decimal number: ");
                 int decimalNum = int.Parse(Console.ReadLine());
                 string hexaDecimalValue = (decimalNum.ToString("x"));           
                 Console.Write($"Hexadecimal Value : {hexaDecimalValue} ");

                  Console.WriteLine("------------QUESTION 18------------");
                  //Write a program that converts a hexadecimal number to binary one.
                  Console.Write("Enter hexadecimal number: ");
                 string hexaDecimalNumber = Console.ReadLine();
                 Console.WriteLine($"Binary Value : {Convert.ToString(Convert.ToInt32(hexaDecimalNum , 16) , 2)} "); 

                 Console.WriteLine("------------QUESTION 19------------");
                 //Write a program that converts a binary number to hexadecimal one. 
                 Console.Write("Enter binary number: ");
                 string binary = Console.ReadLine();
                 Console.WriteLine($"Hexadecimal Value : {Convert.ToInt32(binary , 2).ToString("x")}");

                
                

        }
    }
}
