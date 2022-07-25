int yas, yasFark;
Console.Write("Yaşınızı Giriniz:");
yas = Convert.ToInt32(Console.ReadLine());
if (yas >= 18)
{
    Console.WriteLine("Ehliyet Alabilirsiniz :)");
}
else
{       
    yasFark = 18 - yas;
    Console.WriteLine("Ehliyet Alamazsın." +
        " {0} Yıl Beklemen Gerekiyor",yasFark);
}




