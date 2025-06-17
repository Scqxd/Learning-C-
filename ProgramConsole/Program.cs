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
int z2 = ++x2; // z2=5; x2=6 ++ - префикс
Console.WriteLine($"{x2} - {z2}");

//Сложный пример про префиксы!!!

int r = 3;
int k = 5;
int c = 40;
int d = c---b*a;    // r=3  k=5  c=39  d=25
Console.WriteLine($"r={r}  k={k}  c={c}  d={d}");

double love = 10 / (5 * 2); //Для обозначения приоритетности добавлять скобки!!!
Console.WriteLine(love);

//Операции присвоения

int num5, num6, num7;
num5 = num6 = num7 = 228;
Console.WriteLine($"5 - {num5}, 6 - {num6}, 7 - {num7}"); //Все обозначено в одну строку!!!

int sum1, sum2, sum3;
sum1 = sum2 = 25;
sum3 = sum1 * sum2;
Console.WriteLine($"{sum3}");

int ram1 = 0;
int ram2 = 0;

Console.WriteLine($"Напишите число ram1 и я его переобразую во вторую переменную ram2\n(Пока Ram2 - {ram2}, Ram1 - {ram1})!!!");
Console.WriteLine("Напишите число для ram1");
ram1 = Convert.ToInt32(Console.ReadLine());

ram2 = ram1;

Console.WriteLine($"На основе вашего вписанного значения Ram1 = {ram1}, Ram2 = {ram2}");

//Применение операций присвоения:

int h = 10;
h += 10;        // 20
h -= 4;         // 16
h *= 2;         // 32
h /= 8;         // 4
h <<= 4;      // 64
h >>= 2;      // 16

Console.WriteLine(h);

int l = 1;
l += 1; // 2
l += 2; // 4

Console.WriteLine(l);

//Операции сравнения

int pop = 5;
int pok = 6;
int lok = 5;

bool sf1 = pop == pok;
bool sf2 = pop == lok;
bool sf3 = pop > pok;
bool sf4 = pop < pok;
bool sf5 = lok < pop;
bool sf6 = lok > pop;
bool sf7 = pop <= lok;
bool sf8 = pop >= lok;
bool sf9 = pop <= pok;

Console.WriteLine($"sf1 - {sf1}, sf2 - {sf2}, sf3 - {sf3}\nsf4 - {sf4}, sf5 - {sf5}, sf6 - {sf6}\nsf7 - {sf7}, sf8 - {sf8}, sf9 - {sf9}");