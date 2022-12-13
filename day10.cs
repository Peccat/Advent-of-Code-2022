
using System;
using System.IO;
using System.Collections.Generic;


namespace Day10
{
    class day10
    {
        static int Ell(int cycle, int register){
            int sum = 0;
            if(cycle == 20 || cycle == 60 || cycle == 100 || cycle == 140 || cycle == 180 || cycle == 220)//20,60,100,140,180,220
            {
                sum = cycle*register;
                //Console.WriteLine(sum + "=" + cycle + "*" + register);
            }
            return sum;
        }
        static void PrintSprite(int register, int CRT){
            Console.Write("Sprite position: ");
            for (int i = 0; i < 40; i++)
            {
                if(i == register-1 || i == register || i == register+1){
                    Console.Write("#");
                }else{
                    Console.Write(".");
                }
            }
            Console.WriteLine("\n");
        }
        static char CRTISAKTIVE(int register, int CRT){
            if(CRT == register - 1 || CRT == register || CRT == register + 1){
                return '#';
            }else{
                return '.';
            }
        }
        static void Main(){
            try{
                using (StreamReader sr = new StreamReader("day10.txt"))
                {
                    string line;
                    int cycle = 0;
                    int register = 1;
                    int sum = 0;
                    int CRT = 0;
                    string CRTout = "";
                    List<string> CRTLIST = new List<string>();

                    PrintSprite(register,CRT);
                    while((line = sr.ReadLine()) != null ){
                        if(line == "noop"){
                            cycle++;
                            sum += Ell(cycle, register);
                            CRTout += CRTISAKTIVE(register,CRT);
                            Console.WriteLine("\nStart cycle " + cycle + ": begin executing noop");
                            Console.WriteLine("During cycle " + cycle + ": CRT draws pixel in position " + CRT);
                            Console.WriteLine("Current CRT row: " + CRTout);
                            Console.WriteLine("End of cycle " + cycle + ": finish executing noop");
                            CRT++;
                            if(CRT%40 == 0 && CRT > 5){
                                CRTLIST.Add(CRTout);
                                CRTout = "";
                                CRT = 0;
                            }
                        }else{
                            var lines = line.Split(" ");
                            cycle++;
                            sum += Ell(cycle, register);
                            Console.WriteLine("\nStart cycle " + cycle + ": begin executing " + line);
                            Console.WriteLine("During cycle  " + cycle + ": CRT draws pixel in position " + CRT);
                            CRTout += CRTISAKTIVE(register,CRT);
                            Console.WriteLine("Current CRT row: " + CRTout);
                            CRT++;
                            if(CRT%40 == 0 && CRT > 5){
                                CRTLIST.Add(CRTout);
                                CRTout = "";
                                CRT = 0;
                            }

                            //seconds cycle write to x   
                            cycle ++;
                            sum += Ell(cycle, register);

                            Console.WriteLine("\nDuring cycle " + cycle + ": CRT draws pixel in position " + CRT);
                            CRTout += CRTISAKTIVE(register,CRT);
                            Console.WriteLine("Current CRT row: " + CRTout);
                            register += int.Parse(lines[1]);
                            Console.WriteLine("End of cycle " + cycle + ": finish executing " + line + " (Register X is now " + register + ")");
                            CRT++;
                            if(CRT%40 == 0 && CRT > 5){
                                CRTLIST.Add(CRTout);
                                CRTout = "";
                                CRT = 0;
                            }
                            PrintSprite(register,CRT);
                        }

                                                
                    }
                    Console.WriteLine("\n-----------------------\nPart1: " + sum + "\nPart2:");
                    Console.WriteLine(String.Join("\n" , CRTLIST));
                }
            }catch(Exception e){
                Console.WriteLine("Error!");
                Console.WriteLine(e.Message);
            }
        }
    }
}