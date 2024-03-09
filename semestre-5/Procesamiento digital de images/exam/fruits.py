import copy
import numpy as np
from cv2 import imread
import matplotlib.pyplot as plt
from clase5.clase import clear_img, create_border_of_color, draw_border, get_coordinates_of_color, render_with_lines

def render(value):
    plt.clf()
    plt.imshow(value,cmap="gray")
    plt.show()
    
def histogram(img,color):
    img_copy = np.copy(img)
    (row, column) = img_copy.shape
    img_copy.shape = row*column
    plt.hist(img_copy, bins=255,range=(0,255),histtype="step",color=color)


# Fruits

fruits = imread("../img/frutos_rojos.png")
fruits_channel_raw = fruits[:,:,(2,1,0)]
fruits_channel = copy.deepcopy(fruits_channel_raw)
R=fruits_channel[:,:,0]
G=fruits_channel[:,:,1]
B=fruits_channel[:,:,2]

red_segmentated = R > 180
green_segmentated = G < 130
blue_segmentated = B < 170

RGB = np.concatenate((red_segmentated,green_segmentated,blue_segmentated), axis=1)

red_green_segmented = np.logical_and(red_segmentated,green_segmentated)
fruit_segmented_red = np.logical_and(red_green_segmented,blue_segmentated)
fruit_cleaned = clear_img(fruit_segmented_red)

fruit_mask = create_border_of_color(fruit_cleaned)
fruit_with_border = draw_border(fruits_channel_raw, fruit_mask)
render(fruit_with_border)

histogram(R,"red")
histogram(G,"green")
histogram(B,"blue")
plt.show()