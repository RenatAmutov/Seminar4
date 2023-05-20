// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 

int Deg(int a, int b){
int result = a;
    for(int i = 1; i < b; i++){
        result *= a;
    }
        return result;
}

Console.WriteLine("Данная программа возводит числа в степень");

Console.WriteLine("Введите число");

int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень в которую будем возводить");

int B = Convert.ToInt32(Console.ReadLine());

int C = Deg(A,B);

Console.WriteLine($"цифра {A} в степени {B} равна {C}");