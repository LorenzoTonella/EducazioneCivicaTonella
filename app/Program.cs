using System;

namespace EsercizioGITv0._1
{
    class Crittografia
    {
         static void Main(string[] args)
        {
             int restart = 0;
            do{
                Console.Write("Inserisci una stringa: ");
                string s = Console.ReadLine();
                Console.Write("Inserisci un numero: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Che funzione vuoi eseguire? ");
                int funz=int.Parse(Console.ReadLine());
                switch(funz)
                {
                    case 1: PrimoPunto(s, n);
                    break;
                    case 2: SecondoPunto(s, n);
                    break;
                    case 3: TerzoPunto(s, n);
                    break;
                    case 4: QuartoPunto(s, n);
                    break;
                    case 5: QuintoPunto(s, n);
                    break;
                    
                }
                


                Console.Write("Rieseguire? 1/0: ");
                restart = int.Parse(Console.ReadLine());
            }while (restart == 1);
            
        
        }
        
        static string s ="";
        static int n = 0;
        static int counter=0;
        static int result3 = 0;
        static double result4 = 0;
        static string result1 = "";
        static string result2 ="";
        static int result5=0;


        
        
        public static void PrimoPunto(string s,int n)
        {
            try{
            
                

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
                result1 = new string(arr1);
                Console.WriteLine($"Punto 1: {result1}");
                
                
            }
            catch
            {
                
            }
                
        }
        public static void SecondoPunto(string s,int n)
        {
            try{
                
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
                result2 = new string(arr2);
                Console.WriteLine($"Punto 2: {result2}");

                
            }
            catch
            {
                
            }
                
        }
        public static void TerzoPunto(string s,int n)
        {
             try{
                
             // Punto 3
                int sum = 0;

                foreach (char c in s)
                {
                    int value = char.ToLower(c) - 'a' + 1;
                    sum += value;
                    Console.WriteLine(c + " = " + value);
                }

                 result3 = sum * n;

                Console.WriteLine($"Punto 3: (" + sum + ") * " + n + " = " + result3);
                
            }
            catch
            {
               
            }
                
        }
        public static void QuartoPunto(string s,int n)
        {
             try{
                
              // Punto 4
                int product = 1;
                foreach (char c in s)
                {
                    if (char.IsLetter(c))
                    {
                        int value = char.ToLower(c) - 'a' + 1;
                        product *= value;
                        
                        Console.WriteLine(c + " = " + value);
                    }
                }
                 result4 = Math.Ceiling((double)product / n);
                Console.WriteLine($"Punto 4: (" + product + ") / " + n + " = " + result4);
                
            }
            catch
            {
                
            }
                
        }
        public static void QuintoPunto(string s,int n)
        {
            
            
            
                try{
                
              // Punto 5
                
                if (n % 2 == 0)
                {
                     TerzoPunto(s, n);
                }
                else
                {
                     QuartoPunto(s, n);
                }

                counter++;
                
            
            }
            catch
            {
                
            }
            
                
        }

               


            }
        }
    
