from cv2 import imread
import matplotlib.pyplot as plt
from clase import render

#P1 Invert color

gray_img = imread("../img/escala de grises.jpg")

#Method 1
gray_one_channel = gray_img[:,:,0]
(row,column)=gray_one_channel.shape

for i in range(row):
    for j in range(column):
        color_reversed= 255 - gray_one_channel[i,j]
        gray_one_channel[i,j]=color_reversed
        
render(gray_one_channel)


#Method 2
other_img= 255 - gray_img
render(other_img)