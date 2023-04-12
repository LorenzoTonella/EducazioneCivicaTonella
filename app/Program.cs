using System;

namespace EsercizioGITv0._1
{
    class Crittografia
    {
        public static void Main()
        {
            PrimoPunto();
            SecondoPunto();
            TerzoPunto();
            QuartoPunto();
            QuintoPunto();
        }
        int counter=0;
        
        public static bool PrimoPunto()
        {
            try{
            Console.Write("Inserisci una stringa: ");
                string s = Console.ReadLine();
                Console.Write("Inserisci un numero: ");
                int n = int.Parse(Console.ReadLine());
                

                // Punto 1
                char[] arr1 = s.ToCharArray();
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (char.IsLetter(arr1[i]))
                    {
                        char c = (char)(arr1[i] + n);
                        if (c > 'z')
                            c = (char)(c - 26);
                        arr1[i] = c;
                    }
                }
                string result1 = new string(arr1);
                Console.WriteLine($"Punto 1: {result1}");
                return true;
            }
            catch
            {
                return false;
            }
                
        }
        public static bool SecondoPunto()
        {
            try{
                Console.Write("Inserisci una stringa: ");
                string s = Console.ReadLine();
                Console.Write("Inserisci un numero: ");
                int n = int.Parse(Console.ReadLine());
            // Punto 2
                char[] arr2 = s.ToCharArray();
                for (int i = 0; i < arr2.Length; i++)
                {
                    if (char.IsLetter(arr2[i]))
                    {
                        char c = (char)(arr2[i] - n);
                        if (c < 'a')
                            c = (char)(c + 26);
                        arr2[i] = c;
                    }
                }
                string result2 = new string(arr2);
                Console.WriteLine($"Punto 2: {result2}");

                return true;
            }
            catch
            {
                return false;
            }
                
        }
        public static bool TerzoPunto()
        {
             try{
                Console.Write("Inserisci una stringa: ");
                string s = Console.ReadLine();
                Console.Write("Inserisci un numero: ");
                int n = int.Parse(Console.ReadLine());
             // Punto 3
                int sum = 0;

                foreach (char c in s)
                {
                    int value = char.ToLower(c) - 'a' + 1;
                    sum += value;
                    Console.WriteLine(c + " = " + value);
                }

                int result3 = sum * n;

                Console.WriteLine($"Punto 3: (" + sum + ") * " + n + " = " + result3);
                return true;
            }
            catch
            {
                return false;
            }
                
        }
        public static bool QuartoPunto()
        {
             try{
                Console.Write("Inserisci una stringa: ");
                string s = Console.ReadLine();
                Console.Write("Inserisci un numero: ");
                int n = int.Parse(Console.ReadLine());
              // Punto 4
                int product = 1;
                foreach (char c in s)
                {
                    if (char.IsLetter(c))
                    {
                        int value = char.ToLower(c) - 'a' + 1;
                        product *= value;
                    }
                }
                double result4 = Math.Ceiling((double)product / n);
                Console.WriteLine($"Punto 4: {result4}");
                return true;
            }
            catch
            {
                return false;
            }
                
        }
        public static bool QuintoPunto()
        {
            
            
                return false;
            
                
        }

               


            }
        }
    
