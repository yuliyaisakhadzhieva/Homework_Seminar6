// На вход программы подаются три целых положительных числа. Определить , является ли это сторонами 
// треугольника. Если да, то вывести всю информацию по нему - площадь, 
// периметр, значения углов треугольника в градусах, 
// является ли он прямоугольным, равнобедренным, равносторонним.

Console.WriteLine("Введите первое число"); 
int a = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите второе число"); 
int b = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите третье число"); 
int c = Convert.ToInt32(Console.ReadLine());  

bool Checktriangle(int a, int b, int c) 
{     
    bool x = false;     
    if ((a + b > c) && (b + c > a) && (a + c > b)) x = true;     
    return x; 
} 

Console.WriteLine(Checktriangle(a, b, c));

int s = 0;
int h = 0;
h = (a+b+c)/2;
s = (a*h)/2;

Console.WriteLine("Площадь треугольника равна: " + s);

int p = 0;
p = a+b+c;

Console.WriteLine("Периметр треугольника равен: " + p);

// int x = Convert.ToDouble (Console. ReadLine ());
// int y = Convert.ToDouble (Console. ReadLine ());
// int z = Convert.ToDouble (Console. ReadLine ());
 
// x = 0;
// y = 0;
// z = 0;

// x = Math.Cos(Double)(((a*a)+(c*c))-(b*b))/(2*a*c);
// y = Math.Cos(Double) (((a*a)+(b*b))-(c*c))/(2*a*b);
// z = Math.Cos(Double) (((b*b)+(c*c))-(a*a))/(2*c*b);

// Console.WriteLine($"Углы треугольника в градусах: {x}; {y}; {z}");

if (a=b=c) Console.WriteLine ("Треугольник равносторонний");
if (x=y || x=z ||y=z) Console.WriteLine ("Треугольник равнобедренный");
if (x=90 || y=90 || z=90) Console.WriteLine ("Треугольник прямоугольный");
