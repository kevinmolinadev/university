import copy
import numpy as np
from cv2 import imread
import matplotlib.pyplot as plt
from helpers.functions import render, clear_img, get_coordinates_of_color, render_with_lines

def clip(img):
    img_copy = np.copy(img)
    (row, _) = img_copy.shape
    for i in range(row):
        if(i >110):
            img_copy[i]=0
    return img_copy

def histogram(img,color):
    img_copy = np.copy(img)
    (row, column) = img_copy.shape
    img_copy.shape = row*column
    plt.hist(img_copy, bins=255,range=(0,255),histtype="step",color=color)

duck = imread("../img/pato.jpg")
duck_channel_raw = duck[:,:,(2,1,0)]
duck_channel = copy.deepcopy(duck_channel_raw)
R=duck_channel[:,:,0]
G=duck_channel[:,:,1]
B=duck_channel[:,:,2]

red_segmentated = R <130
green_segmentated = G < 120
blue_segmentated = B < 130

RGB = np.concatenate((red_segmentated,green_segmentated,blue_segmentated), axis=1)
render(RGB)

red_green_segmented = np.logical_and(red_segmentated,blue_segmentated)
duck_segmented_red = np.logical_and(red_green_segmented,green_segmentated)
duck_cleaned = clear_img(duck_segmented_red)
render(duck_cleaned)

duck_new = clip(duck_cleaned)

duck_points = get_coordinates_of_color(duck_new)

render_with_lines(duck_channel_raw, duck_points)

histogram(R,"red")
histogram(G,"green")
histogram(B,"blue")
plt.show()