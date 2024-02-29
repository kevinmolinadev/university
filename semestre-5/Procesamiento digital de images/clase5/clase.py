import copy
import numpy as np
import cv2
import matplotlib.pyplot as plt
from clase1.clase import render

def clear_img(img):
    img_copy = np.copy(img)
    (row, _) = img_copy.shape
    for i in range(row):
        count = np.sum(img_copy[i, :])
        if count < 20:
            img_copy[i] = 0
    return img_copy

def render_with_lines(img,points):
    render(img)
    plt.plot(points[0],points[1])
    plt.show()

def get_coordinates_of_color(img):
    img_copy = np.copy(img)
    (row,column) = img_copy.shape
    row_min, column_min = row, column
    row_max, column_max = 0, 0
    for i in range(row):
        for j in range(column):
            if(img_copy[i,j]>0):
                if(i<row_min):
                    row_min=i
                if(i>row_max):
                    row_max=i
                if(j<column_min):
                    column_min=j
                if (j>column_max):
                    column_max=j
                    
    points_x = [column_min,column_max,column_max,column_min,column_min]
    points_y = [row_min,row_min,row_max,row_max,row_min]
    return [points_x,points_y]


img = cv2.imread("../img/flowers.jpg")
img_channel_raw = img[:,:,(2,1,0)]
img_channel = copy.deepcopy(img_channel_raw)
R=img_channel[:,:,0]
G=img_channel[:,:,1]
B=img_channel[:,:,2]

render(R)
render(G)
render(B)

RGB = np.concatenate((R,G,B), axis=1)
render(RGB)


red_segmentated = R > 150
green_segmentated = G < 40
blue_segmentated = B < 40

RGB_segmented = np.concatenate((red_segmentated,green_segmentated,blue_segmentated), axis=1)
render(RGB_segmented)

## Red
red_green_segmented = np.logical_and(red_segmentated,green_segmentated)
img_segmented_red = np.logical_and(red_green_segmented,blue_segmentated)
render(img_segmented_red)

#Clear pixels 
img_cleaned_red = clear_img(img_segmented_red)
render(img_cleaned_red)

#Delimit the desired color: Red of img
#render_with_lines(img_channel_raw,get_coordinates_of_color(img_cleaned_red))

## Yellow
green_segmentated = G > 100
red_green_segmented_yellow = np.logical_and(red_segmentated,green_segmentated)
img_segmented_yellow = np.logical_and(red_green_segmented_yellow,blue_segmentated)
img_cleaned_yellow = clear_img(img_segmented_yellow)
render_with_lines(img_channel_raw,get_coordinates_of_color(img_cleaned_yellow))