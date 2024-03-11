import numpy as np
import cv2
import matplotlib.pyplot as plt
from helpers.functions import information



def get_greather_pixel(value):
    return np.max(value)

def convert_to_gray(values,img):
    average = np.average(values) / 100
    new_img = average * img
    return new_img
    
    
    
    
cat_img = cv2.imread("../img/profile.png")
cat_img_channel = cat_img[:,:,(2,1,0)]

R=cat_img_channel[:,:,0]
G=cat_img_channel[:,:,1]
B=cat_img_channel[:,:,2]

information(R)
information(G)
information(B)


img_gray = convert_to_gray([get_greather_pixel(R),get_greather_pixel(G),get_greather_pixel(B)],cat_img)

#RGB = np.concatenate((R,G,B), axis=1)
plt.imshow(img_gray, cmap="gray")

