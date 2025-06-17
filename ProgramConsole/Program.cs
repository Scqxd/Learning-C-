Console.Write("Укажите ваш возраст: ");
string? age = Console.ReadLine(); // Читка ответа пользователя
Console.WriteLine($"Вам {age} лет!");


Console.WriteLine("Добро пожаловать!");
Console.Write("Укажите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int result;
result = num1 + num2;
Console.WriteLine($"Ваш результат: {result}");

//арифмитические операции

int a = 10;
int b = a + 40;
Console.WriteLine(b);

float sd = 3.65F;
var bd = sd + 3465;
Console.WriteLine(bd);

var z = 10.0 /  4.0;
Console.WriteLine(z);

var x = 10.0;
var y = x % 4.0; //результат равен 2
Console.WriteLine(y);

int x2 = 5;
int z2 = ++x2; // z2=5; x2=6
Console.WriteLine($"{x2} - {z2}");

