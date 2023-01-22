using System;
using static System.Console;

Clear();

string[] array = MyArray();
string[] result = lessThanThree(array, 3);
WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] lessThanThree(string[] input, int n) 
{
string[] output = new string[CountLessThan(input, n)];
for(int i = 0, j = 0; i < input.Length; i++) 
 {
  if(input[i].Length <= n) 
   {
    output[j] = input[i];
    j++;
   }
 }
 return output;
}

int CountLessThan(string[] input, int n) 
{
int count = 0;
for(int i = 0; i < input.Length; i++) 
 {
 if(input[i].Length <= n) 
  {
  count++;
  }
 }
 return count;
}

string[] MyArray() 
{
    Write("Введите значения через пробел: ");
    return ReadLine().Split(" ");
}