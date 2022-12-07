
using System;
using System.IO;
using System.Collections.Generic;

namespace Day1{
    class Day1{
        static void Main(){
            try{
                using (StreamReader sr = new StreamReader("day1.txt"))
                {
                    string line;
                    List<int> elfCalories = new List<int>();
                    int calories = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if(line != ""){
                            calories += int.Parse(line);
                        }else{
                            elfCalories.Add(calories);
                            calories = 0;

                        }
                                                    
                    }
                    //Console.WriteLine(String.Join("\n", elfCalories));
                    elfCalories.Sort();
                    elfCalories.Reverse();
                    Console.WriteLine("Part 1: " + elfCalories[0]);
                    int max = elfCalories[0] + elfCalories[1] + elfCalories[2];
                    Console.WriteLine("Part 2: " + max);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(e.Message);
            }
        }
    }
}