using Business.Concrete;
using Entities.Concrete;
using System;

class Workaround
{
    static void Main()
    {

        Vatandas vatandas1 = new Vatandas();

        SelamVer(isim: "Buse");
        SelamVer(isim: "Kevser");
        SelamVer(isim: "Hilal");
        SelamVer();

        int sonuc = Topla(100, 35);

        //Arrays

        //string ogrenci1 = "Buse";
        //string ogrenci2 = "Zeynep";
        //string ogrenci3 = "Deniz";

        string[] ogrenciler = new string[3];
        ogrenciler[0] = "Buse";
        ogrenciler[1] = "Belinay";
        ogrenciler[2] = "Mert";
        //ogrenciler=new string[4];
        //ogrenciler[4] = "Pınar";

        for (int i = 0; i < ogrenciler.Length; i++)
        {
            Console.WriteLine(ogrenciler[i]);
        }

        string[] sehirler1 = new[] { "Ankara", "İzmir", "Eskişehir" };
        string[] sehirler2 = new[] { "İstanbul", "Bursa", "Rize" };

        sehirler2 = sehirler1;
        sehirler1[0] = "Kastamonu";
        Console.WriteLine(sehirler2[0]);

        int sayi1 = 10;
        int sayi2 = 20;
        sayi2 = sayi1;
        sayi1 = 30;
        Console.WriteLine(sayi2); 

        foreach (string sehir in sehirler1)
        {
            Console.WriteLine(sehir);

        }
        Person person1 = new Person();
        person1.FirstName = "Buse";
        person1.LastName = "Yıldız";
        person1.NationalIdentity = 12345;
        person1.DateofBirthYear = 2000;

        Person person2 = new Person();
        person2.FirstName = "Cihad";
        person2.LastName = "Kıbrıs";
        person2.NationalIdentity = 2316;
        person2.DateofBirthYear = 1996;

        List<string> yeniSehirler = new List<string>{"Düzce", "Bolu", "Antalya"};
        yeniSehirler.Add("İzmir");
        foreach (var sehir in yeniSehirler)
        {
            Console.WriteLine(sehir);
        }

        PTTManager pttManager = new PTTManager(new PersonManager());
        pttManager.GiveMask(person1);

        Console.ReadLine();
    }

    static void SelamVer(string isim="noname")
    {
        Console.WriteLine("Merhaba " + isim);
    }

    static int Topla(int sayi1 =5, int sayi2 = 10) { 

        int sonuc = sayi1 + sayi2;
        Console.WriteLine("Toplam :" + sonuc);
        return sonuc; 
    }
    private static void degiskenler()
    {
        string mesaj = "Selam";
        double tutar = 10000;
        int sayi = 100;
        bool girisYapmisMi = false;

        string ad = "Buse";
        string soyad = "Yıldız";
        int dogumYili = 2001;
        long tcNo = 12345678910;

        Console.WriteLine(tutar * 1.18);
        Console.WriteLine(tutar * 1.18);
    }
}

public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set;}
    public int dogumYili { get; set;}
    public long tcNo { get; set; }
}