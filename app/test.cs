using System;

namespace SonarTest
{
    class TestClass
    {
        static void ComplexMethod()
        {
            int a = 10;
            int b = 20;
            int c = 30;
            int d = 40;
            int e = 50;
            int f = 60;
            int g = 70;
            int h = 80;
            int i = 90;
            int j = 100;

            if (a > b)
            {
                if (b > c)
                {
                    if (c > d)
                    {
                        if (d > e)
                        {
                            if (e > f)
                            {
                                if (f > g)
                                {
                                    if (g > h)
                                    {
                                        if (h > i)
                                        {
                                            if (i > j)
                                            {
                                                Console.WriteLine("a > b > c > d > e > f > g > h > i > j");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            for (int k = 0; k < 100; k++)
            {
                Console.WriteLine("This is line " + k);
            }
        }

        static void ComplexMethod2()
        {
            int a = 10;
            int b = 20;
            int c = 30;
            int d = 40;
            int e = 50;
            int f = 60;
            int g = 70;
            int h = 80;
            int i = 90;
            int j = 100;

            if (a > b)
            {
                if (b > c)
                {
                    if (c > d)
                    {
                        if (d > e)
                        {
                            if (e > f)
                            {
                                if (f > g)
                                {
                                    if (g > h)
                                    {
                                        if (h > i)
                                        {
                                            if (i > j)
                                            {
                                                Console.WriteLine("a > b > c > d > e > f > g > h > i > j");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            for (int k = 0; k < 100; k++)
            {
                Console.WriteLine("This is line " + k);
            }
        }
    }
}
