/*
int firstthree(int start, int finish){
int numberA = new Random().Next(start, finish);
Console.WriteLine(numberA);
int firstname = numberA / 100;
//int secondname = (numberA % 100) / 10;
int threename = numberA % 10;
int result = firstname*10 + threename;
return result;
}

int A = firstthree(100, 999);
Console.Write(A);


int numberA = new Random().Next(1, 100 );
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 100);
Console.WriteLine(numberB);
    if (numberA >= numberB){
        if (numberA % numberB == 0){
            Console.WriteLine(numberA + " кратное " + numberB);
        } else{
            Console.WriteLine(numberA % numberB + " - остаток");
        }
    }
    if (numberB >= numberA){
        if (numberB % numberA == 0){
            Console.WriteLine(numberB + " кратное " + numberA);
        } else{
            Console.WriteLine(numberB % numberA + " - остаток");
        }
    }



int mass = Convert.ToInt32(Console.ReadLine());
int [] arrey = new int [mass];
for (int i = 0; i < mass; i++){
    arrey[i] = i;
    Console.WriteLine(arrey[i]);
}


Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1


int numberA = new Random().Next(100, 999);
Console.WriteLine(numberA);
int secondname = (numberA % 100) / 10;

Console.Write(secondname);


Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

int numberA = new Random().Next(1, 10000);
Console.WriteLine(numberA);
string numberB = numberA.ToString();

int dlina = numberB.Length;
//Console.WriteLine(dlina);

int n = 0;

if (dlina == 3)
{
    Console.WriteLine(numberA % 10 + " - третья цифра");  
} 
if (dlina - 3 > n)
{
    n = dlina - 3;
   
    Console.WriteLine((numberA % (Math.Pow(10, n + 1))) / (Math.Pow(10, n)) + " - третья цифра");   
} 
if (dlina < 3) 
{
    Console.WriteLine("Третья цифра не обнаружена!");
}



Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

*/
int numberA = new Random().Next(1, 7);
Console.WriteLine(numberA);
if (numberA >= 6)
{
    Console.WriteLine(numberA + " - выходной день недели");
}
else
{
    Console.WriteLine(numberA + " - рабочий день недели");
}


