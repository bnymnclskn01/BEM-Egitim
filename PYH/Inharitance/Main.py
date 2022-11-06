# -*- coding: utf-8 -*-
"""
Created on Sun Nov  6 15:49:27 2022

@author: ever_
"""

from Action import Employee
emp=Employee()
#access Data
emp.person_info('Ömer Talha Aktaş',25)
emp.company_info('Google','Atlanta')
emp.employee_info(50000,'Machine Learning')
print("Çalışan Listesi Ekleme")

ÇalışanListesi = [] 

for i in range(0,100000):
    inp = input("(1) Yeni çalışan ekle \n(2) Çık")
    if(inp == "1"):
        yeniÇalışan = [ ]
        yeniÇalışan.insert(1,input("İsim : "))
        yeniÇalışan.insert(1,input("Yaş : "))
        yeniÇalışan.insert(1,input("Şirket : "))
        yeniÇalışan.insert(1,input("Şirket Lokasyonu : "))
        yeniÇalışan.insert(1,input("Gelir : "))
        yeniÇalışan.insert(1,input("Meslek : "))
        
        ÇalışanListesi.append(yeniÇalışan)    
    else:
        break

emp=Employee()
seçim=input("Çalışan numarasını girin")
seç= int(seçim) - 1
seçilenKişi = ÇalışanListesi[seç]

emp.person_info(seçilenKişi[0],seçilenKişi[1])
emp.company_info(seçilenKişi[2],seçilenKişi[3])
emp.employee_info(seçilenKişi[4],seçilenKişi[5])