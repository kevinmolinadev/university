import numpy as np
from cv2 import imread
import matplotlib.pyplot as plt
from helpers.functions import render

def get_histogram(img):
    (row,column) = img.shape
    amount = 256
    histogram = np.zeros((amount,),np.uint8)
    for i in range(row):
        for j in range(column):
            position = img[i,j]
            histogram[position] = histogram[position]+1
    plt.plot(range(amount),histogram[0:amount])
    plt.show()
    #(histogram)
    #return histogram

def histogram(img,color):
    img_copy = np.copy(img)
    (row, column) = img_copy.shape
    img_copy.shape = row*column
    plt.hist(img_copy, bins=255,range=(0,255),histtype="step",color=color)

row,column = 3,3
matriz = np.zeros((row,column))

matriz[:,0]=100
matriz[:,1]=150
matriz[:,2]=200

render(matriz)

# GET HISTOGRAM
plt.hist(matriz,range(0,255),histtype="step")

#Rice
rice = imread("../img/onerice.bmp")
rice_one_channel = rice[:,:,0] 

# Histogram by function
get_histogram(rice_one_channel)
plt.show()

# histogram with plt.hist(<Array>,options)
histogram(rice_one_channel,"red")



