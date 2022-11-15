# -*- coding: utf-8 -*-
"""
Created on Sat Nov 12 15:33:35 2022

@author: ever_
"""
import pypyodbc
db=pypyodbc.connect(
    'Driver={SQL Server};'
    'Server=SOFTWARE\SQLEXPRESS;'
    'Database=pyhEgitim;'
    'Trusted_Connection=True;'
    )
imlec=db.cursor()
"""
imlec.execute('Select * From Personel')
personel=imlec.fetchall()
for i in personel:
    print(i)
"""
"""
Veri = ()
a=input("NameSurname\n")
Veri = Veri + (a,)
b=input("Email\n")
Veri = Veri + (b,)
c=input("Password\n")
Veri = Veri + (c,)
d=input("Adress\n")
Veri = Veri + (d,)
komut='INSERT INTO Personel VALUES(?,?,?,?)'
veriler=Veri
sonuc=imlec.execute(komut,veriler)
db.commit()
"""
"""
guncelle=imlec.execute('Update Personel Set Address=?, NameSurname=? Where ID=?',('Ankara','Ahmet Rüzgar Tekeli',1))
db.commit()
print(str(guncelle)+" Kayıt güncellendi")"""
"""sonuc=imlec.execute('Delete from Personel Where Address=?',('Ankara',))
db.commit()"""
imlec.execute('Select * From Personel')
personel=imlec.fetchall()
for i in personel:
    print(i)