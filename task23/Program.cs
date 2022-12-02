//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Num(int[] num){
  int count = 0;
  int length = num.Length;
  while (count <  length){
    num[count] = Convert.ToInt32(Math.Pow(count, 3));
    count++;
  }
}

void PrintArray(int[] coll){
  int count = coll.Length;
  int index = 0;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] array = new int[num+1];
Num(array);
PrintArray(array);
