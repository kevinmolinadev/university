import copy
import numpy as np
import cv2
from helpers.functions import clear_img, create_border_of_color, draw_border, render

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

# Create border
img_mask=create_border_of_color(img_cleaned_red)
img_with_border = draw_border(img_channel_raw, img_mask)
render(img_with_border)

## Yellow
green_segmentated = G > 100
red_green_segmented_yellow = np.logical_and(red_segmentated,green_segmentated)
img_segmented_yellow = np.logical_and(red_green_segmented_yellow,blue_segmentated)
img_cleaned_yellow = clear_img(img_segmented_yellow)
#render_with_lines(img_channel_raw,get_coordinates_of_color(img_cleaned_yellow))

