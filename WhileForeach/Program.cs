﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("While Foreach");
Console.WriteLine("Lütfen bir sayı giriniz:");
int sayi = int.Parse(Console.ReadLine());
int sayac = 1;
int toplam = 0;
while (sayac<=sayi)
{
    toplam += sayac;
    sayac ++;
}
Console.WriteLine(toplam/sayi);

// a'dan z'ye kadar olan tüm harleri console'a yazdır.
char character = 'a';
while (character<'z')
{
    Console.Write(character);
    character ++;
}
Console.WriteLine("\n*****Foreach*****");
string[] arabalar = {"BMW","Ford","Toyota", "Nissan"};
foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}
