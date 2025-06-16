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