Console.WriteLine("Добро пожаловать в калькулятор!");

Console.WriteLine("Выберите действие!");
Console.WriteLine("1 - Сложение\n2 - Вычитание\n3 - Умножение\n4 - Деление");
int a = Convert.ToInt32(Console.ReadLine());

    if (a == 1)
    {

    Console.WriteLine("Введите 2 числа которые вам надо сложить!");
    var num1 = Convert.ToInt32(Console.ReadLine());
    var num2 = Convert.ToInt32(Console.ReadLine());
    var result = num1 + num2;
    Console.WriteLine($"Ваш результат - {result}");
    }

    else if (a == 2)
    {

    Console.WriteLine("Введите 2 числа которые вам надо отнять!");
    var num1 = Convert.ToInt32(Console.ReadLine());
    var num2 = Convert.ToInt32(Console.ReadLine());
    var result = num1 - num2;
    Console.WriteLine($"Ваш результат - {result}");

    }

    else if (a == 3)
    {

    Console.WriteLine("Введите 2 числа которые вам надо умножить!");
    var num1 = Convert.ToInt32(Console.ReadLine());
    var num2 = Convert.ToInt32(Console.ReadLine());
    var result = num1 * num2;
    Console.WriteLine($"Ваш результат - {result}");

    }

    else if (a == 4)
    {

    Console.WriteLine("Введите 2 числа которые вам надо поделить!");
    double num1 = Convert.ToInt32(Console.ReadLine());
    double num2 = Convert.ToInt32(Console.ReadLine());
    double result = num1 / num2;
    Console.WriteLine($"Ваш результат - {result}");

    }

    else if (a > 4)

    {
    
    Console.WriteLine("Число не введено!");

    }





