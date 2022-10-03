// See https://aka.ms/new-console-template for more information

//Задача 0
/*Console.WriteLine("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(n*n);
*/


//Задача 1
/* Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if(a == b*b)
{
    Console.WriteLine("да");
}
else
{
    Console.Write("нет");    
}
*/


//Задача 3
//1 вариант задачи с while
/* Console.WriteLine("Введите номер дня недели (от 1 до 7): ");
int weekDay = Convert.ToInt32(Console.ReadLine());
while (weekDay < 1 | weekDay > 7) {
    Console.WriteLine("Вы ввели недопустимый номер дня недели, повторите ввод (от 1 до 7): ");
    weekDay = Convert.ToInt32(Console.ReadLine());
}
if(weekDay == 1) Console.WriteLine("Понедельник");
else if(weekDay == 2) Console.WriteLine("Вторник");
else if(weekDay == 3) Console.WriteLine("Среда");
else if(weekDay == 4) Console.WriteLine("Четверг");
else if(weekDay == 5) Console.WriteLine("Пятница");
else if(weekDay == 6) Console.WriteLine("Суббота");
else if(weekDay == 7) Console.WriteLine("Воскресенье");
else Console.WriteLine("Вы ввели недопустимый номер дня недели");
*/

//2 вариант с switch
/*Console.Write("Введите номер дня недели (от 1 до 7): ");
int a = Convert.ToInt32(Console.ReadLine());
while (a < 1 | a > 7) {
    Console.Write("Вы ввели недопустимый номер дня недели, повторите ввод (от 1 до 7): ");
    a = Convert.ToInt32(Console.ReadLine());
}
switch(a) {
    case 1: Console.WriteLine("Понедельник");
    break;
    case 2: Console.WriteLine("Вторник");
    break;
    case 3: Console.WriteLine("Среда");
    break;
    case 4: Console.WriteLine("Четверг");
    break;
    case 5: Console.WriteLine("Пятница");
    break;
    case 6: Console.WriteLine("Суббота");
    break;
    case 7: Console.WriteLine("Воскресенье");
    break;
          default: Console.WriteLine("Вы ввели недопустимый номер дня недели");
          break;

}
*/

//Задача 5
// 1 вариант решения
/* Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
int i = n*(-1);
while (i <= n) {
    Console.Write (Convert.ToString(i) + " ");
    i++;
}
*/

// 2 вариант задачи -(программа выводит все четные числа)
/* Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());  //получили число (4)
int max = n;  //мы получили ввод пользователя -это верхняя граница. (4 будет максимальным)
while (-n <= max){           //пока  -4 <= 4 первый проход цикла
    //if(n % 2 == 0){
        Console.Write (-n + " ");  //если условие выполняется мы попадаем в тело while
        n--;                        // 
   // }
   // else {
   //     Console.Write (-n + " ");
   //     n--;
   // }
}
*/

// 3 вариант задачи через for
/* int n = 0;
Console.WriteLine("Введите число N");
n = Convert.ToInt32(Console.ReadLine());
for (int i = -n; i <= n; i++) {           //
    Console.Write (i + " ");  //
}                   
*/

//Задача 7
/*Console.Write("Введите трехзначное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
while(n < 100| n > 999) {
    Console.Write("Вы ввели недопустимое число, повторите ввод: ");
        n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Последняя цифры числа: "+Convert.ToString (n%10));
*/

// 2 вариант 