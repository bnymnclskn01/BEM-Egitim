# -*- coding: utf-8 -*-
"""
Created on Sat Nov 12 16:41:29 2022

@author: ever_
"""

import requests
from bs4 import BeautifulSoup
import pandas as pd
url="https://www.bkmkitap.com/kitap/cok-satan-kitaplar"
response = requests.get(url)
html_icerigi = response.content
soup = BeautifulSoup(html_icerigi,"html.parser")
fiyat = soup.find_all("div",{"class":"col col-12 currentPrice"})
isim =soup.find_all("a",{"class":"fl col-12 text-description detailLink"})
yazar = soup.find_all("a",{"class":"fl col-12 text-title"})
yayin = soup.find_all("a",{"class":"col col-12 text-title mt"})
liste = list()

for i in range(len(isim)):
    isim[i] = (isim[i].text).strip("\n").strip()
    yazar[i] = (yazar[i].text).strip("\n").strip()
    yayin[i] = (yayin[i].text).strip("\n").strip()
    fiyat[i] = (fiyat[i].text).strip("\n").replace("\nTL"," TL").strip()
    liste.append([isim[i],yazar[i],yayin[i],fiyat[i]])

df = pd.DataFrame(liste,columns = ["Kitap İsmi","Yazar","Yayın Evi","Fiyat"])
print(df)

