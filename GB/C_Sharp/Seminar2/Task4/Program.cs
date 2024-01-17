// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую. 
// Допускается вывод цифр в обратном порядке, например: 3462 => 2,6,4,3
Console.Write("Введите натуралььное число: ");
int N=Convert.ToInt32(Console.ReadLine());
if (N < 10){
Console.WriteLine(N);
}
else {
    while (N>0) {// n==0
        int digit=N%10;
        N/=10;
        if (N>0) {
            Console.Write(digit+", ");
        }
        else{
            Console.Write(digit);
        }
    }   
}
