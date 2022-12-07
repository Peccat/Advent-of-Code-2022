using System;
using System.IO;
using System.Collections.Generic;

namespace Day2{
    class Day2{
        static void Main(){
            try{
                using (StreamReader sr = new StreamReader("day2.txt"))
                {
                    string line;
                    int points = 0;
                    int PartTwo = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        //A-Rock, B- Paper, C- Scissors
                        //X-Rock, Y- Paper, Z- Scissors
                        //0-lost, 3-draw, 6-win
                        //+1 Rock, +2 Paper, +3 Scissors
                        var lineS = line.Split(" ");
                        if(lineS[0]=="A"){
                            if(lineS[1]=="X"){//R-R
                                points += 4; 
                                PartTwo += 0; //lost
                                PartTwo += 3; //Scissors
                            }else if(lineS[1]=="Y"){//R-P
                                points += 8; 
                                PartTwo += 3; //draw
                                PartTwo += 1; //rock
                            }else if(lineS[1]=="Z"){//R-S
                                points += 3; 
                                PartTwo += 6;//win
                                PartTwo += 2;//paper
                            }
                        }else if(lineS[0]=="B"){
                            if(lineS[1]=="X"){//P-R
                                points += 1; 
                                PartTwo += 0;//lost
                                PartTwo += 1;//rock
                            }else if(lineS[1]=="Y"){//P-P
                                points += 5; 
                                PartTwo += 3;//draw
                                PartTwo += 2;
                            }else if(lineS[1]=="Z"){//P-S
                                points += 9;
                                PartTwo += 6;//win 
                                PartTwo += 3; //scissors
                            }
                        }else if(lineS[0]=="C"){
                            if(lineS[1]=="X"){//S-R
                                points += 7; 
                                PartTwo += 0;//lost
                                PartTwo += 2;//paper
                            }else if(lineS[1]=="Y"){//S-P
                                points += 2; 
                                PartTwo += 3;//draw
                                PartTwo += 3;//scissors
                            }else if(lineS[1]=="Z"){//S-S
                                points += 6; 
                                PartTwo += 6;//win
                                PartTwo += 1;//rock
                            }
                        } 
                    }
                    Console.WriteLine("PartOne: " + points);
                    Console.WriteLine("PartTwo: " + PartTwo);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}