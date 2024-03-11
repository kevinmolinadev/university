import copy
import numpy as np
import cv2
import matplotlib.pyplot as plt

def render(value):
    plt.clf()
    plt.imshow(value,cmap="gray")
    plt.show()

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
    
def clear_img(img):
    img_copy = np.copy(img)
    (row, _) = img_copy.shape
    for i in range(row):
        count = np.sum(img_copy[i, :])
        if count < 20:
            img_copy[i] = 0
    return img_copy

def render_with_lines(img,points):
    plt.imshow(img,cmap="gray")
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

def create_border_of_color(img):
    (row,column) = img.shape
    border = np.zeros((row,column))
    for i in range(1,row - 1):
        for j in range(1,column - 1):
            count = np.sum([
                img[i - 1,j - 1],
                img[i,j - 1],
                img[i + 1,j - 1],
                img[i - 1,j],
                img[i + 1,j],
                img[i - 1,j + 1],
                img[i,j + 1],
                img[i + 1,j + 1]
            ])
            
            if(count >= 3 and count <=6):
                border[i -1,j]=1
                border[i + 1,j]=1
                border[i,j]=1
                border[i,j - 1]=1
                border[i,j + 1]=1
                    
    return border

def draw_border(img,mask):
    img_copy=copy.deepcopy(img)
    (row,column,_)=img_copy.shape
    for i in range(row):
        for j in range(column):
            if(mask[i,j]==1):
                img_copy[i,j,:]=[155, 89, 182]        
    return img_copy

def resize(img,scale_x,scale_y,type:int):
    types=[
        cv2.INTER_LINEAR,
        cv2.INTER_NEAREST,
        cv2.INTER_AREA,
    ]
    img_copy = copy.deepcopy(img)
    img_resize = cv2.resize(img_copy,None,fx=scale_x,fy=scale_y,interpolation=types[type - 1])
    return img_resize

