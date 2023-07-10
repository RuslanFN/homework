using System;
class HelloWorld {
  static void Main() {
    //task 1
    Console.WriteLine("Введите первое число");
    int num_a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int num_b = Convert.ToInt32(Console.ReadLine());

    if (num_a > num_b){
        Console.WriteLine(num_a);
    }else{
        Console.WriteLine(num_b);
    }
    
    //task 2
    Console.WriteLine("Введите первое число");
    int num_c = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    num_a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число");
    num_b = Convert.ToInt32(Console.ReadLine());

    if (num_a >= num_b && num_a >= num_c){
        Console.WriteLine(num_a);
    }else if (num_b >= num_a && num_b >= num_c){
        Console.WriteLine(num_b);
    }else {
        Console.WriteLine(num_c);
    }

    // task 3
    Console.WriteLine("Введите число");
    num_a = Convert.ToInt32(Console.ReadLine());

    if(num_a % 2 == 0){
        Console.WriteLine("Да");
    }else {
        Console.WriteLine("Нет");
    }

    //task 4
    Console.WriteLine("Введите число больше одного");
    num_a = Convert.ToInt32(Console.ReadLine());

    for (int i = 2; i <= num_a; i++){
        if (i % 2 == 0){
            Console.WriteLine(i);
        }
    }


  }
}
