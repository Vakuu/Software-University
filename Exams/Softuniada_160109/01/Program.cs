﻿using System;

namespace _01
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            if (a + b == c + d)
            {
                Console.WriteLine("Yes");
                Console.WriteLine(a + b);
            }
            else
            {
                if (a + c == b + d)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine(a + c);
                }
                else
                {
                    if (a + d == b + c)
                    {
                        Console.WriteLine("Yes");
                        Console.WriteLine(a + d);
                    }
                    else
                    {
                        if (a== d+b + c)
                        {
                            Console.WriteLine("Yes");
                            Console.WriteLine(a);
                        }
                        else
                        {
                            if (b == a+d + c)
                            {
                                Console.WriteLine("Yes");
                                Console.WriteLine(b);
                            }
                            else
                            {
                                if (c == a+b + d)
                                {
                                    Console.WriteLine("Yes");
                                    Console.WriteLine(c);
                                }
                                else
                                {
                                    if (d == a+b + c)
                                    {
                                        Console.WriteLine("Yes");
                                        Console.WriteLine(d);
                                    }
                                    else
                                    {
                                        Console.WriteLine("No");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
