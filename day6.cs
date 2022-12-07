using System.Collections.Generic;
using System;
using System.IO;

namespace Day6
{
    class day6
    {
        public static int Day6(string line, int max){
            int max2 = max;
            int exit = 0;
            for (int i = 0; i < line.Length-4; i++)
                {
                    for (int j = 1; j < max2; j++)
                    {
                        if(line[i] == line[i+j]){
                            max2 = max;
                            break;
                        }
                        if (j == max2-1){
                            exit = i+max2;
                            max2--;
                        }
                    }
                    if(max2 == 0){
                        break;
                    }   
                } 
                return exit;
            
        }
        static void Main(){
            try
            {
                using(StreamReader sr = new StreamReader("day6.txt")){
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        
                        Console.WriteLine("Part one: " + Day6(line,4));
                        Console.WriteLine("Part two: " + Day6(line,14));
                        
                          
                    }
                }
            }
            catch (System.Exception e)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(e.Message);
            }
        }
    }
}