//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

//For two points P1(x1, y1, z1) and P2(x2, y2, z2)

// Distance (d) = 
//
//static void distance(int ax, int ay,
 //                    int az, int bx,
 //                    int by, int bz)
//
//




//

Console.WriteLine("Введите координаты X для точки А" );
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y для точки А" );
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z для точки А" );
int az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты X для точки B" );
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y для точки B" );
int by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z для точки B" );
int bz = -Convert.ToInt32(Console.ReadLine());

{
    double d = Math.Pow((Math.Pow(bx - ax, 2) +
                         Math.Pow(by - ay, 2) +
                         Math.Pow(bz - az, 2)*1),0.5);

    //Console.WriteLine("Дистанция между А и В равна " + (Math.d, 2));
    
    Console.WriteLine("Дистанция между А и В равна " + d);
    return;
}