int sayi;
Console.WriteLine("Lütfen Bir Sayı Giriniz : ");
sayi = Convert.ToInt32(Console.ReadLine());

for (int omer = 0; omer <= sayi; omer += 2)
{
    Console.WriteLine(omer);
}