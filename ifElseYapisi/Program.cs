double sayi1, sayi2, sonuc = 0;
Console.WriteLine("*********HESAP MAKİNESİ PROGRAMINA HOŞGELDİNİZ******");
Console.Write("1. Sayiyi Giriniz : ");
sayi1 = Convert.ToDouble(Console.ReadLine());
Console.Write("2. Sayiyi Giriniz : ");
sayi2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("**** İŞLEM TÜRÜNDEN BİRİNİ SEÇİNİZ******");
Console.Write("Toplama İşlemi İçin     ------>> topla \n");
Console.Write("Çıkarma İşlemi İçin     ------>> cıkar \n");
Console.Write("Bölme İşlemi İçin       ------>> bol \n");
Console.Write("Çarpma İşlemi İçin      ------>> carp \n");
string islem = Console.ReadLine();
if (islem == "topla")
{
    sonuc = sayi1 + sayi2;
}
else if (islem == "cıkar")
{
    if (sayi1 > sayi2)
    {
        sonuc = sayi1 - sayi2;
    }
    else
    {
        sonuc = sayi2 - sayi1;
    }


}
else if (islem == "carp")
{
    sonuc = sayi1 * sayi2;
}
else if (islem == "bol")
{
    sonuc = sayi1 / sayi2;
}
else
{
    Console.WriteLine("Yanlış Yazdınız");
}

Console.WriteLine("İşleminizin Sonucu = " + sonuc);
Console.ReadKey();


