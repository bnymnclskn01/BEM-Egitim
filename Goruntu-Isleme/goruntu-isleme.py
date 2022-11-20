# -*- coding: utf-8 -*-
"""
Created on Sat Nov 19 15:48:26 2022

@author: ever_
"""

import cv2 #OPENCV projeye import ediyoruz(Projemize OpenCV Ekliyoruz)
import numpy as np #Görüntü işlemede matematiksel işlermler dolaylı yoldan geldiği için numpy kütüphanesini projemize ekledik.
from matplotlib import  pyplot as plt
"""cv2.imshow("Kahve",image)# Dizinden çektiğimiz 1.jpg resmine manipülasyon uygulamk için yeniden adlandırdık.
print(image)#Image değişkenini ekrana yazdırıyoruz.
print("Resim Boyutu : " +str(image.size))
print("Resim Renk Kodları"+str(image[220,175]))
print("Resim  Özellikleri : "+str(image.shape))
print("Resim Veri Tipi"+ str(image.dtype))

image =cv2.imread("1.jpg") #Dosya dizininden resimimizi image değişkenin atamak için kullanıyoruz.
image[:,:,0]=50 #1.: Yükesklik 2. : Genişlik 3. 0 rgb renk kodunu veriyoruz
image[:,:,0]=200
cv2.imshow("Kahve",image)
print("Resim Renk Kodları : "+str(image[220,175]))

resim1=cv2.imread("kirmizi.png")
resim2=cv2.imread("mavi.jpg")
print(resim1[250,270])
print(resim2[300,350])
cv2.imshow("Kırmızı",resim1)
cv2.imshow("Mavi",resim2)
print("Ağırlık Resim Tonlama ")
print(resim1[250,270]+resim2[300,350])
resim=cv2.imread("ataturk.jpg")
aynalamaResim=cv2.copyMakeBorder(resim,75,75,125,125,cv2.BORDER_REFLECT)
uzatilanResim=cv2.copyMakeBorder(resim,120,120,120,120,cv2.BORDER_REPLICATE)
tekrarlananResim=cv2.copyMakeBorder(resim,100,100,100,100,cv2.BORDER_WRAP)
sarilanResim=cv2.copyMakeBorder(resim,50,50,50,50,cv2.BORDER_CONSTANT,
                                value=(75,150,255))
cv2.imshow("Atatürk",aynalamaResim)
cv2.imshow("Uzatilan Atatürk",uzatilanResim)
cv2.imshow("Tekrarlanan Atatürk",tekrarlananResim)
cv2.imshow("Sarılan Atatürk",sarilanResim)"""
image_path="yol.jpeg"
img=cv2.imread(image_path)
print(img.shape)
gray_image=cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
"""plt.imshow(gray_image)
plt.show()"""
print(gray_image.shape)
output2=cv2.blur(gray_image,(10,10))
"""
plt.imshow(output2)
plt.show()"""
(h, w) = img.shape[:2]
center=(w/2,h/2)
M=cv2.getRotationMatrix2D(center,13,scale=1.1)
rotated=cv2.warpAffine(gray_image,M,(w,h))
"""plt.imshow(rotated)
plt.show()"""
(thresh,output2)=cv2.threshold(gray_image,200,255,cv2.THRESH_BINARY)
output2=cv2.GaussianBlur(output2,(5,5),3)
output2=cv2.Canny(output2,180,255)
"""plt.imshow(output2)
plt.show()"""

cv2.waitKey(0)#Pencede açık kalması için yazılan open cv metotudur.
cv2.destroyAllWindows()#Windows işletim sisteminde çalıştığımız için windows çalıştır pencerisini kullanıyoruz.