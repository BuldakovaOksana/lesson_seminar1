// 1. Какая задача.
// 2. Я делаю то и то...
// 3. Какие данные
// 4. Что вы ожидаете
// 5. Что получается в итоги
// 6. Ошибки
// 7. Почему как исправить?

// int, double, string, bool

// Переменная
// if else
// while

// поменять значение двух переменных местами

// int a=1;
//int b=3;

//Console.WriteLine("a = " + a + " b = " + b);

//int temp=a;
//a=b;
//b=temp;

//Console.WriteLine("a = {0}  b = {1}", a, b);
//Console.WriteLine($"a = {a}  b = {b}");


// Переменная 
// - тип данных
// - имя
// - значение 


// int a=1;
// int b=3;
// Console.WriteLine($"a = {a}  b = {b}");

// a=a+b;
// b=a-b;
// a=a-b;

// Console.WriteLine($"a = {a}  b = {b}");

// int a= new Random().Next(1,100);
// int b= new Random().Next(1,100);

// Console.WriteLine($"a = {a}  b = {b}");

// if(a>b)
// {
// Console.WriteLine(a);
// }
// else 
// {
// Console.WriteLine(b);
// }


// int current = 1;

// while(current<=10)
// {
//     Console.WriteLine($"{current} {current*current}");
// //    current++;
    
// }

// Показать все числа из [2; 128]
// Которые делятся на 3 и на 5


// int start = 2;
// int end = 128;
// int current = start;
// while (current<=end)
// {
  //    if ((current %3==0) && (current %5==0))
 //     {
  //        Console.WriteLine(current);
 //     }
  //    current++;
// }

int candy = 27;
int max = 5;

int player =1;


while (candy >0)
{
    Console.WriteLine($"Конфет осталось: {candy}");
    int count =0;
    while (!(count >=1 && count <(max+1)))
    {       
    
     Console.Write($"Сколько конфет берёт игрок {player}:");
     count = int.Parse(Console.ReadLine());
    }
     candy=candy-count;
     if (candy >=0)
     {
         
     if (player ==1)  {  player=2; }
     else { player=1; }
     }
}

Console.WriteLine($"Победа игрока {player}");
