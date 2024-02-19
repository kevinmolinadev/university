# -*- coding: utf-8 -*-
import numpy as np
from cv2 import imread
import matplotlib.pyplot as plt


def information(img):
    print("size:",img.shape)
    print("max:",np.max(img))
    print("min:", np.min(img))

def segmentation(raw_img,threshold):
    (row,column)=raw_img.shape
    new_img = np.zeros((row,column))
    area = 0
    for i in range(row):
        for j in range(column):
            if raw_img[i,j] > threshold:
                new_img[i,j] = 255
                area += 1
    print("area:",area)
    return new_img
    
    
def render(value):
    plt.clf()
    plt.imshow(value,cmap="gray")


#rice = imread("../img/onerice.bmp")
#rice_one_channel = rice[:,:,0]
#processed_rice = segmentation(rice_one_channel, 120);
#render(processed_rice)


rices = imread("../img/rices.png")
rices_one_channel = rices[:,:,0]
processed_rices = segmentation(rices_one_channel, 115)

render(processed_rices)