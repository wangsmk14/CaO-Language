using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CAO_Language
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int pointer = 0;
            List<char> db = new List<char>();
            db.Add((char)0);
            Console.Title = "CAO Language 1.0 Console";
            Console.WriteLine("CAO Language 1.0(23-01-13)[x86-32 Version] On .NET");
            Console.WriteLine();
            if (args.Length == 0)
            {
                while (true)
                {
                    Console.Write("CaO Command>>>");
                    input = Console.ReadLine();
                    List<string> command = new List<string>();
                    for (int a = 0; a < input.Length; a++)
                    {
                        command.Add(input[a].ToString());
                    }
                    int index = 0;
                    bool run = true;
                    foreach (string cmd in command)
                    {
                        if (run)
                        {
                            switch (cmd)
                            {
                                case "火":
                                    pointer--;
                                    if (pointer > -1)
                                    {

                                    }
                                    else
                                    {
                                        pointer = 0;
                                        Console.WriteLine("CaO Error>>>指针不能小于零(pointer cannot be less than zero)");
                                    }
                                    break;
                                case "卓":
                                    pointer++;
                                    try
                                    {
                                        char test = db[pointer];
                                    }
                                    catch (ArgumentOutOfRangeException)
                                    {
                                        db.Add((char)0);
                                    }
                                    break;
                                case "艹":
                                    db[pointer]++;
                                    break;
                                case "早":
                                    db[pointer]--;
                                    break;
                                case "焯":
                                    Console.WriteLine("CaO Output(String)>>> " + db[pointer]);
                                    int output = db[pointer];
                                    Console.WriteLine("CaO Output(ASCII Number Code)>>> " + output.ToString());
                                    break;
                                case "草":
                                    Console.Write("CaO Input(ASCII Number Code)>>>");
                                    db[pointer] = (char)int.Parse(Console.ReadLine());
                                    break;
                                case "，":
                                    if (db[pointer] == 0)
                                    {
                                        run = false;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("CaO Error>>>意外的符号 " + cmd + "(Unexpected symbol " + cmd + ")");
                                    break;
                            }

                            index++;
                        }
                        else
                        {
                            if (cmd == "。")
                            {
                                run = true;
                            }
                        }
                    }
                }

            }
            else
            {
                StreamReader file = new StreamReader(args[0]);
                input = file.ReadToEnd();
                List<string> command = new List<string>();
                for (int a = 0; a < input.Length; a++)
                {
                    command.Add(input[a].ToString());
                }
                int index = 0;
                bool run = true;
                foreach (string cmd in command)
                {
                    if (run)
                    {
                        switch (cmd)
                        {
                            case "火":
                                pointer--;
                                if (pointer > -1)
                                {

                                }
                                else
                                {
                                    pointer = 0;
                                    Console.WriteLine("CaO Error>>>指针不能小于零(pointer cannot be less than zero)");
                                }
                                break;
                            case "卓":
                                pointer++;
                                try
                                {
                                    char test = db[pointer];
                                }
                                catch (ArgumentOutOfRangeException)
                                {
                                    db.Add((char)0);
                                }
                                break;
                            case "艹":
                                db[pointer]++;
                                break;
                            case "早":
                                db[pointer]--;
                                break;
                            case "焯":
                                Console.WriteLine("CaO Output(String)>>> " + db[pointer]);
                                int output = db[pointer];
                                Console.WriteLine("CaO Output(ASCII Number Code)>>> " + output.ToString());
                                break;
                            case "草":
                                Console.Write("CaO Input(ASCII Number Code)>>>");
                                db[pointer] = char.Parse(Console.ReadLine());
                                break;
                            case "，":
                                if (db[pointer] == 0)
                                {
                                    run = false;
                                }
                                break;
                            default:
                                Console.WriteLine("CaO Error>>>意外的符号 " + cmd + "(Unexpected symbol " + cmd + ")");
                                break;
                        }

                        index++;
                    }
                    else
                    {
                        if (cmd == "。")
                        {
                            run = true;
                        }
                    }
                }
                Console.Write("CaO Info>>>按下回车以退出(Press Enter to exit)");
                Console.ReadLine();
            }
        }
    }
}
