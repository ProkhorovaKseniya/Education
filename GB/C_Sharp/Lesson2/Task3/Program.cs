int n = 10;
int[] array = { 2, 5, 4, 7, 8, 35, 40, 83, 38, 100 };
int i=0;
Console.Write($"Чётные: ");
while (i<n) {
    
    if (array[i]%2==0){
        Console.Write($"{array[i]} ");
    }
    i=i+1;
}
