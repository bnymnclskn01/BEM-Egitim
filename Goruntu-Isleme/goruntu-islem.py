# -*- coding: utf-8 -*-
"""
Created on Sat Nov 19 17:16:41 2022

@author: ever_
"""
import cv2 #OPENCV projeye import ediyoruz(Projemize OpenCV Ekliyoruz)
import numpy as np #Görüntü işlemede matematiksel işlermler dolaylı yoldan geldiği için numpy kütüphanesini projemize ekledik.
from matplotlib import  pyplot as plt
image_path="yol.jpeg"
img=cv2.imread(image_path)
gray_image=cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
output2=cv2.blur(gray_image,(10,10))
(h, w) = img.shape[:2]
center=(w/2,h/2)
M=cv2.getRotationMatrix2D(center,13,scale=1.1)
rotated=cv2.warpAffine(gray_image,M,(w,h))
"""plt.imshow(rotated)
plt.show()"""
(thresh,output2)=cv2.threshold(gray_image,200,255,cv2.THRESH_BINARY)
"""
output2=cv2.GaussianBlur(output2,(5,5),3)
"""
output2=cv2.Canny(output2,180,255)
lines = cv2.HoughLinesP(output2, 1, np.pi/180,30)
for line in lines:
    x1,y1,x2,y2 = line[0]
    cv2.line(img,(x1,y1),(x2,y2),(0,255,0),4)
plt.imshow(img)
def mask_of_image(img):
    height=img.shape[0]
    polygons = np.array([[(0,height),(2200,height),(250,100)]])
    mask=np.zeros_like(img)
    cv2.fillPoly(mask,polygons,255)
    masked_image=cv2.bitwise(img,mask)
    return masked_image