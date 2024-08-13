
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
int[] numbers= new int[10];// 10 elamanli sayı dizisi oluşturma 

for (int i = 0;  i< numbers.Length; i++) // döngü içide sayıların girilmesi 
{
    Console.WriteLine($"Lütfen sayılar kümesinin {i+1}. sayısını giriniz");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine("Girmiş olduğunuz sayılar");
foreach (int number in numbers)//girilen sayıları konsola yazdırmak için 
{
    Console.WriteLine(number);
}


Console.WriteLine("Lütfen 11. sayınızı giriniz");

Array.Resize(ref numbers, numbers.Length+1);// yeni sayı eklemek için dizinin eleman sayısını artırıyorum
numbers[numbers.Length-1]=Convert.ToInt32(Console.ReadLine());//son elemana ekleme yapmak


Array.Sort(numbers);//sayıları küçükten büyüğe sıralamak için sort kullandım
Array.Reverse(numbers);// küçükten büyüğe sıralanan sayıları ters çevirerek büyüktenn küçüğe sıralamak


Console.WriteLine("Sayıların büyükten küçüğe sıralanması");
foreach (int number in numbers)// sıralanan sayıların sıra ile okumasının yapılması 
{
    
    Console.WriteLine(number);
}

