string A; //определение переменной

A = "Wow";

Console.WriteLine(A);

A = "Penis"; // изменение переменной

Console.WriteLine(A);

const string B = "Hui"; // определяем константу (Нельзя изменять)
 
Console.WriteLine(B);

Console.WriteLine(true); //Логический литерал

Console.WriteLine(-11); //Целочисленный литерал


string name = "Tom"; //Переменная строчная
int age = 33; //Переменная целочисленная
bool isEmployed = true; //Пременная логическая
float weight = 78.65F; //Переменная дробная
 
//Вставление переменных

Console.WriteLine($"Имя: {name}");
Console.WriteLine($"Возраст: {age}");
Console.WriteLine($"Вес: {weight}");
Console.WriteLine($"Работает: {isEmployed}");

//Переменые обозначения с помощью Var

var C = 12;

Console.WriteLine(C);

var G = "Hio";

Console.WriteLine(G);

//Можно использовать переменные с помощью индексов

string names = "Tom";
int ages = 34;
double height = 1.7;
Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", names, height, ages);