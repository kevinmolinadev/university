from cv2 import imread
from helpers.functions import render, segmentation

#rice = imread("../img/onerice.bmp")
#rice_one_channel = rice[:,:,0]
#processed_rice = segmentation(rice_one_channel, 120);
#render(processed_rice)


rices = imread("../img/rices.png")
rices_one_channel = rices[:,:,0]
processed_rices = segmentation(rices_one_channel, 115)

render(processed_rices)