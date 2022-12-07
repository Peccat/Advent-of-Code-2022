
using System;
using System.IO;
using System.Collections.Generic;

namespace Day4
{
    class Day4{
        static void Main(){
            try{
                using(StreamReader sr = new StreamReader("day4.txt")){
                    string line;
                    int tol1;
                    int ig1;
                    int tol2;
                    int ig2;
                    int containsPartOne = 0;
                    int containsPartTwo = 0;

                    while((line = sr.ReadLine()) != null){
                        var lines = line.Split(",");
                        var lines21 = lines[0].Split("-"); 
                        var lines22 = lines[1].Split("-"); 
                        tol1 = int.Parse(lines21[0]);
                        ig1 = int.Parse(lines21[1]);
                        tol2 = int.Parse(lines22[0]);
                        ig2 = int.Parse(lines22[1]);
                        if(tol1 <= tol2 && ig1 >= ig2){
                            containsPartOne++;
                            //Console.WriteLine("1 " + tol1 + "-" + ig1 + ";" + tol2 + "-" + ig2);
                        }else if(tol1 >= tol2 && ig1 <= ig2){
                            containsPartOne++;
                            //Console.WriteLine("2 " + tol1 + "-" + ig1 + ";" + tol2 + "-" + ig2);
                        }
                        //------Part 2---------
                        if(tol1 <= tol2 && tol2 <= ig1){
                            containsPartTwo++;
                            Console.WriteLine("1 " + tol1 + "-" + ig1 + ";" + tol2 + "-" + ig2);
                        }else if(tol2 <= tol1 && tol1 <= ig2){
                            containsPartTwo++;
                            Console.WriteLine("2 " + tol1 + "-" + ig1 + ";" + tol2 + "-" + ig2);
                        }
                    }
                    Console.WriteLine(containsPartOne);
                    Console.WriteLine(containsPartTwo);

                }
            }catch(Exception e){
                Console.WriteLine("Error!");
                Console.WriteLine(e.Message);
            }
        }
    }
}