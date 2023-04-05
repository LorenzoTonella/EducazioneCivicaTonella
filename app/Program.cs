using System;

namespace EsercizioGITv0._1
{
    class Crittografia
    {
        int counter=0;
        
        public bool PrimoPunto()
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
        public bool SecondoPunto()
        {
            return false;
        }

               


            }
        }
    
