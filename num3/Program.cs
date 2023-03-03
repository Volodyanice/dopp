Console.WriteLine("x1: y1:");
double x1 = Convert.ToDouble(Console.ReadLine());
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("x2: y2:");
double x2 = Convert.ToDouble(Console.ReadLine());
double y2 = Convert.ToDouble(Console.ReadLine());
double coor1_coor2 = System.Math.Sqrt((System.Math.Pow((x2 - x1), 2)) + System.Math.Pow((y2 - y1), 2));
System.Console.WriteLine("{0: 0.000}", coor1_coor2);