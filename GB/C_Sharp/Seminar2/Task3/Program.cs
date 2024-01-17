// Задача 3: Напишите программу, которая принимает на вход 
// целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Console.Write("Введите целое число из отрезка [10, 99]");
int number=Convert.ToInt32(Console.ReadLine());
if  (number>9 && number<100) {

    if ((number/10)>(number%10)) {
    Console.WriteLine($"Наибольшая цифра числа {number} - {number/10}");
    }
    else {
        if ((number/10)==(number%10)) {
            Console.WriteLine($"Во введенном числе {number} обе цифры равны  - {number%10}");
        }
        else {Console.WriteLine($"Наибольшая цифра числа {number} - {number%10}");}
    }
}
else {Console.WriteLine($"Введенное число {number} вне заданного отрезка [10, 99]");}