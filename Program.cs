void Zadacha1(){
    //Напишите цикл, который принимает на вход два числа (A и B)
    //и возводит число A в натуральную степень B.
    Console.Write("Введите число A: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число B: ");
    int b = Convert.ToInt32(Console.ReadLine());
    double res = Math.Pow(a, b);
    Console.Write(res);
}

void Zadacha2(){
    //Напишите программу, которая принимает на вход число
    //и выдаёт сумму цифр в числе.
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    while (number > 0) {
        sum = sum + number % 10;
        number = number /10 ;
    }
    Console.WriteLine(sum);
}

void Zadacha3(){
    //Напишите программу, которая задаёт массив из 8 элементов 
    //и выводит отсортированный по модулю массив.
    int size = 8;
    Random rand = new Random();
    int[] array = new int[size];
    for( int i = 0; i < array.Length; i++){
        array[i] = rand.Next(-100,100);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    for( int i = 0; i < array.Length; i++){
        int minPos = i;
        for(int j = i; j < array.Length; j++){
            if(Math.Abs(array[j]) < Math.Abs(array[minPos])){
                minPos = j;
            }
        }
        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
        Console.Write(array[i] + " ");
    }
}
//Zadacha1();
//Zadacha2();
Zadacha3();