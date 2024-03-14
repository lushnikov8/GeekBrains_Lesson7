bool Zd1 = true;
bool Zd2 = true;
bool Zd3 = true;

//<<<---тут основной блок программы
if (Zd1 == true) ExecuteZD1();
if (Zd2 == true) ExecuteZD2();
if (Zd3 == true) ExecuteZD3();
//--->>>


// Процедуры и функции:

void ExecuteZD1()
{
    Console.Clear();
    Console.WriteLine("\x1b[32mЗадача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в \nпромежутке от M до N. Использовать рекурсию, не использовать циклы.\x1b[0m");
    Console.WriteLine();
    Console.Write($"Результат: M=3 N=9 => \x1b[0m");
    NaturNumber(3,9);
    
    Console.WriteLine();
    Console.WriteLine();
    
    Console.Write("Введите N: ");
    int M = int.Parse(Console.ReadLine()!);

    Console.Write("Введите M: ");
    int N = int.Parse(Console.ReadLine()!);

    Console.WriteLine();
    Console.WriteLine("Результат: ");
    NaturNumber(M,N);

    Console.WriteLine();
    WaitForPressAnyKey();
}

void ExecuteZD2()
{
    Console.Clear();
    Console.WriteLine("\x1b[32m");
    Console.WriteLine("Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");    
    Console.WriteLine("\x1b[0m");

    Console.WriteLine("Функция Аккермана A(m,n) Пример: A(2,4) => 11");
    Console.WriteLine();
    
    Console.Write("Ведите m: ");
    int m = int.Parse(Console.ReadLine()!);

    //Console.WriteLine();

    Console.Write("Ведите n: ");
    int n = int.Parse(Console.ReadLine()!);

    Console.WriteLine();
    
    Console.WriteLine($"Результат Урок: A({m},{n}) => {AkkermanF(m,n)}");
    Console.WriteLine($"Результат WiKi: A({m},{n}) => {AkkermanFWiki(m,n)}");

    WaitForPressAnyKey();
}

void ExecuteZD3()
{
    Console.Clear();
    Console.WriteLine("\x1b[32m");
    Console.WriteLine("Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.");    
    Console.WriteLine("\x1b[0m");

    Console.Write("массив будет сгенерирован случаныйми числами введите размерность массива: ");

    int RazmerMass = int.Parse(Console.ReadLine()!);

    int[] massiv = initmassiv(RazmerMass);

    Console.WriteLine();
    
    Console.WriteLine("Вывод массива в обратном порядке рекурсия: ");
    PrintReversMassivRekursia(massiv, massiv.Length - 1);

    Console.WriteLine();
    Console.WriteLine();

    //WaitForPressAnyKey();
}


void WaitForPressAnyKey()
{
    Console.WriteLine();
    while(true)
    {
        Console.WriteLine("Для продолжения нажмите любую клавишу....");
        Console.ReadKey();
        return;
    }
}

void NaturNumber(int M, int N)
{
    Console.Write(M);
    if (M<N) 
    {
        Console.Write(", ");
        NaturNumber(M+1, N);
    }
    
}

    


int[] initmassiv(int KolVo)
{
    int[] NewMassiv = new int[KolVo];

    Console.WriteLine("Исходный массив рандом: ");

    for (int i = 0; i < KolVo; i++)
    {
        NewMassiv[i] = new Random().Next(10,100);
        Console.Write(NewMassiv[i]+" ");
    }

    Console.WriteLine();

    return NewMassiv;
}


void PrintReversMassivRekursia(int[] MassivForprint, int Elemrent)
{
    Console.Write(MassivForprint[Elemrent]);
 
    if (Elemrent-1 < 0 ) return;
    else Console.Write(" ");

    PrintReversMassivRekursia(MassivForprint, Elemrent-1);
}


int AkkermanF(int m, int n)
{
    if (m==0) return n+1;
    else if (n==0) return AkkermanF(m-1,1);
    return AkkermanF(m-1, AkkermanF(m, n-1));
}

int AkkermanFWiki(int n, int m)
{
    if (n==0) return m+1;
    else if (m==0) return AkkermanF(n-1,1);
    return AkkermanF(n-1, AkkermanF(n, m-1));
}
