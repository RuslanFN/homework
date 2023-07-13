using System;
class Homework {
    static int read_num(){
        int num;
        Console.WriteLine("Введите число");
        bool isValid = Int32.TryParse(Console.ReadLine(), out num);
        if (isValid){
            return num;
        }
        else{
            Console.WriteLine("Неверный ввод");
            return 0;
        }
    }
    static void task10(int num){
        int result = num / 10 % 10;
        Console.WriteLine(result);
    }
    static void task13(int num){
        if (num < 100){
            Console.WriteLine("третьей цифры нет");
        }
        else{
            Console.WriteLine(num % 10);
        }
    }
    static void task15(int num){
        if (num == 6 || num == 7){
            Console.WriteLine("Да");
        }
        else{
            Console.WriteLine("Нет");
        }
    }
    static void Main() {

        task10(read_num());
        task13(read_num());
        task15(read_num());


  }
}
