/*
Select : Veritaban�m�zda verileri okumak
i�in kullan�l�r.
Update : Veritaban�nda var olan kay�tlar�
g�ncellemek i�in kullan�l�r.
Insert Into: Veritaban�na Yeni Kay�t
Olu�turmak i�in Kullan�l�r.
Create Database : Veritaban� olu�turur
Alter Database: Mevcut veritaban�,
�zerinde i�lem yapmak i�in kullan�l�r.
Create Table : Yeni tablo olu�turur
Alter Table: Mevcut tablo �zelliklerinde
de�i�iklik yapmak i�in kullan�l�r.
Drop Table : Veritaban� i�indeki bir
tabloyu silmek i�in kullan�r�z.
*/
/*
---- Veritaban� Data Tipleri ----
- character(n): Metin tipinde n ile belirtilen say� kadar
karaekter depolar. n ile belirtilenden az karekter girmi�
olsa bile n kadar yer kulan�r. (�rn : character(40))
- varchar(n) or character(n) varying(n): En fazla n ile belirti-
len kadar karekter yer kaplar. Girilen veri n de�irinden
az ise girildi�i n kadar alan kaplar.
- binary(n): Metinsel olarak binary de�erleri n ile belirtilen
kadar yer kaplar.
- boolen: True : False Var Yok gibi iki durumda kullan�l�r.
- integer:Tam say� olarak kullan�l�r. 4 byte yer kaplar.
-2.147.438.658 - 2.147.438.657 say�lar� aras�nda de�er tutar.
- smallint: k���k tam say� de�erlerini depolar. Virg�ll� de�er
kabul etmez. 2 byte yer kaplar: -32.768 -32.767 aras�nda
de�er kullan�r.
- tinyint: Mini tam say�lar� kaplar 0 -255 say� aras�nda de�er
al�r.
- bigint: B�y�k Tam Say�lar� kaplar
-9.223.372.036.854.755.808 - 9.223.372.036.854.755.807
aras�nda de�er al�r.
- decimal(p,s): Virg�ll� de�er kullan�r �rn:Decimal(5,2)
Bu ifade toplam 5 rakaml� bunun 2 tanesi virg�ll� olaca��n�
belirtiyoruz.
- numeric(p,s): Decimal veri tipiyle ayn�d�r.
Float(p) Virg�ll� say�lar� yuvarlayarak kay�t eder.

- Date: Tarih
- Time:Saat
*/