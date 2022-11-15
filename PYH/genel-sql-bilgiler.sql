/*
Select : Veritabanýmýzda verileri okumak
için kullanýlýr.
Update : Veritabanýnda var olan kayýtlarý
güncellemek için kullanýlýr.
Insert Into: Veritabanýna Yeni Kayýt
Oluþturmak için Kullanýlýr.
Create Database : Veritabaný oluþturur
Alter Database: Mevcut veritabaný,
üzerinde iþlem yapmak için kullanýlýr.
Create Table : Yeni tablo oluþturur
Alter Table: Mevcut tablo özelliklerinde
deðiþiklik yapmak için kullanýlýr.
Drop Table : Veritabaný içindeki bir
tabloyu silmek için kullanýrýz.
*/
/*
---- Veritabaný Data Tipleri ----
- character(n): Metin tipinde n ile belirtilen sayý kadar
karaekter depolar. n ile belirtilenden az karekter girmiþ
olsa bile n kadar yer kulanýr. (örn : character(40))
- varchar(n) or character(n) varying(n): En fazla n ile belirti-
len kadar karekter yer kaplar. Girilen veri n deðirinden
az ise girildiði n kadar alan kaplar.
- binary(n): Metinsel olarak binary deðerleri n ile belirtilen
kadar yer kaplar.
- boolen: True : False Var Yok gibi iki durumda kullanýlýr.
- integer:Tam sayý olarak kullanýlýr. 4 byte yer kaplar.
-2.147.438.658 - 2.147.438.657 sayýlarý arasýnda deðer tutar.
- smallint: küçük tam sayý deðerlerini depolar. Virgüllü deðer
kabul etmez. 2 byte yer kaplar: -32.768 -32.767 arasýnda
deðer kullanýr.
- tinyint: Mini tam sayýlarý kaplar 0 -255 sayý arasýnda deðer
alýr.
- bigint: Büyük Tam Sayýlarý kaplar
-9.223.372.036.854.755.808 - 9.223.372.036.854.755.807
arasýnda deðer alýr.
- decimal(p,s): Virgüllü deðer kullanýr Örn:Decimal(5,2)
Bu ifade toplam 5 rakamlý bunun 2 tanesi virgüllü olacaðýný
belirtiyoruz.
- numeric(p,s): Decimal veri tipiyle aynýdýr.
Float(p) Virgüllü sayýlarý yuvarlayarak kayýt eder.

- Date: Tarih
- Time:Saat
*/