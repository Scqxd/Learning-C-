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

int a = 10;
int b = a + 40;
Console.WriteLine(b);

float sd = 3.65F;
var bd = sd + 3465;
Console.WriteLine(bd);