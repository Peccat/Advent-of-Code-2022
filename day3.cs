
using System;
using System.Collections.Generic;
using System.IO;

namespace Day3{
    class Day3{
        static void Main(){
            //part 1
            try{
                using (StreamReader sr = new StreamReader("day3.txt"))
                {
                    string line;
                    List<char> chars = new List<char>();
                    int length = 0;
                    int length2 = 0;
                    int PartOne = 0;
                    int a = (int)'a';
                    int A = (int)'A';
                    a--;
                    A-=27;
                    int add = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        
                        length = line.Length;//24
                        length2 = length/2;//12
                        int j = 0;
                        for(int i = 0; i != length2; i++){       //0-11
                            for(j = length2; j != length; j++){  //12-23
                                if(line[i] == line[j]){
                                    chars.Add(line[i]);
                                    if(line[i] - a > 0){
                                        add = (int)line[i] - a;
                                        PartOne += add;
                                        //Console.WriteLine(PartOne + " " + add + " " + line[i]);
                                    }else{
                                        add = (int)line[i] - A;
                                        PartOne += add;
                                        //Console.WriteLine(PartOne + " " + add + " " + line[i]);
                                    }
                                    break;
                                }
                            }
                            if(j!= length){
                                if(line[i] == line[j]){
                                    break;
                                }
                            }
                        }
                    } 

                    //Console.WriteLine(String.Join(" ", chars));
                    Console.WriteLine(PartOne);
                    //2670 high
                }
            }catch(Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            //part 2
            try{
                using (StreamReader sr = new StreamReader("day3.txt"))
                {
                    string line1;
                    string line2;
                    string line3;
                    
                    List<char> chars = new List<char>();
                    int a = (int)'a';
                    int A = (int)'A';
                    int PartTwo = 0;
                    a--;
                    A-=27;
                    bool BreakLoops = false;
                    int add = 0;
                    while ((line1 = sr.ReadLine()) != null)
                    {
                        BreakLoops = false;
                        line2 = sr.ReadLine();
                        line3 = sr.ReadLine();
                        foreach(var i1 in line1){
                            foreach (var i2 in line2)
                            {
                                foreach (var i3 in line3)
                                {
                                    if(i1==i2 && i2 == i3){
                                        chars.Add(i1);
                                        BreakLoops = true;
                                        if((int)i1 - a > 0){
                                            PartTwo += (int)i1 - a;
                                            //Console.Write(PartTwo + " " + i2 + " " + ((int)i1 - a) + "\t");
                                        }else{
                                            PartTwo += (int)i1 - A;
                                            //Console.Write(PartTwo + " " + i2 + " " + ((int)i1 - A) + "\t");
                                        }
                                        break;
                                    }
                                    if (BreakLoops)
                                    {
                                        break;
                                    }
                                }
                                if (BreakLoops)
                                {
                                    break;
                                }
                            }
                            if (BreakLoops)
                            {
                                break;
                            }
                        }

                    } 
                    
                    //Console.WriteLine(String.Join(" ", chars));
                    Console.WriteLine(PartTwo);
                }
            }catch(Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}