double k1, k2, aci, alan;
Console.Write("1. Kenarı Giriniz : ");
k1=Convert.ToDouble(Console.ReadLine());
Console.Write("2. Kenarı Giriniz:");
k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Açı Değerini Giriniz:");
aci=Convert.ToDouble(Console.ReadLine());

alan = k1 * k2 * Math.Sin(aci) / 2;
Console.WriteLine("Üçgenin Alanı ={0}",alan);
