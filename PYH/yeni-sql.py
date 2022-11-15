# -*- coding: utf-8 -*-
"""
Created on Sun Nov 13 16:33:39 2022

@author: ever_
"""

import pypyodbc

server = input("Server ismi: \n")
database = input("Database ismi: \n")
def Baglan(a,b):
    db = pypyodbc.connect(
        'Driver={SQL Server};'
        'Server='+a+';'
        'Database='+b+';'
        'Trusted_Connection=True')
    
    if (db==None):
        print("none")
    else:
        print("ok")
    return db
    
a=Baglan(server,database)
cursor=a.cursor()
"""
cursor.execute('Select * From Person')
for i in cursor:
    print(i)
"""
liste=(("Ayşegül Çınar","İstanbul","Yazılım Mühendisi","Bekar"),("Mehmet Çatak","Ankara","Yazılım Mühendisi","Bekar"))
try:
    query=("insert into Person (Name_Surname,City,Bolum,Medeni_Durum) values(?,?,?,?)")
    """Çoklu eklemek için kullanılır"""
    cursor.executemany(query,liste) 
    """Tekli Eklemek İçin Kullanılır."""
    cursor.execute(query,("","","","")) 
    a.commit()
    print("Veri Başarıyla Eklendi")
except:
    print("Ekleme Yaparken Hata Oluştu")
    a.rollback()
a.close()      