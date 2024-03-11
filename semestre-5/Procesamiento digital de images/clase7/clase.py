import cv2
from helpers.functions import resize

img_cat = cv2.imread("../img/profile.png")

small_l = resize(img_cat,0.8,0.8,1) # Linear
small_n = resize(img_cat,0.8,0.8,2) # Nearest
small_a = resize(img_cat,0.8,0.8,3) # Area
#cv2.imshow("original", img_cat)
#cv2.imshow("small linear",small_l)
#cv2.imshow("small nearest",small_n)
#cv2.imshow("small area",small_a)

cortar = img_cat[::2,::2]
cv2.imshow("clip", cortar)

cv2.waitKey()
cv2.destroyAllWindows()

