import numpy as np
from cv2 import imread
from helpers.functions  import render

w_matrix=10
h_matrix=10

new_matrix = np.zeros((w_matrix,h_matrix))

for i in range(w_matrix):
    for j in range(h_matrix):
        if(i%2==0 and j%2!=0):
            new_matrix[i,j]=255

render(new_matrix)


img = imread("../img/prueba.bmp")
img_one_channel = img[:,:,0]
count_white=0
count_black=0
(row,column)=img_one_channel.shape

for i in range(row):
    for j in range(column):
        if(img_one_channel[i,j]==255):
            count_white+=1
        elif (img_one_channel[i,j]==0):
            count_black+=1

render(img_one_channel)
print(count_white,count_black)