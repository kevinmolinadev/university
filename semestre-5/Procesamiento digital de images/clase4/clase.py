import numpy as np
import cv2
import matplotlib.pyplot as plt
from clase1.clase import information

def get_sampling(step,img):
    # (row,column) = img.shape
    # row_sampling = range(0, row, step)
    # column_sampling = range(0, column, step)
    # width_sampling = len(row_sampling)
    # height_sampling = len(column_sampling)
    # sampling = np.zeros((width_sampling,height_sampling),np.uint8)
    
    # for i in range(width_sampling):
    #     for j in range(height_sampling):
    #         sampling[i,j]=img[row_sampling[i],column_sampling[j]]
    
    sampling = img[::step,::step]
    
    return sampling

def get_histogram(img,width):
    (row,column) = img.shape
    histogram = np.zeros((width,))
    for i in range(row):
        for j in range(column):
            position = img[i,j]
            histogram[position] += 1

    return histogram


cat_img = cv2.imread("../img/profile.png")
cat_img_channel = cat_img[:,:,0]
#plt.figure(figsize=(8,8))
#plt.imshow(cat_img_channel, cmap="gray")
#plt.show()

# GET SAMPLING OF CAT_IMG 
sampling_cat = get_sampling(2, cat_img_channel)
# plt.imshow(sampling_cat, cmap="gray")
information(sampling_cat)

# GET HISTOGRAM OF SAMPLING
fields_count=256 # 0 - 255 representation of pixel colours in scale of gray
sampling_histogram= get_histogram(sampling_cat,fields_count)
plt.figure(figsize=(12,8))
plt.plot(range(fields_count),sampling_histogram[0:fields_count])
plt.show()  