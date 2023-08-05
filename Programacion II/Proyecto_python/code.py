#Inportamos las librerias que utilizamos 
import cv2
import os
#INTERFAZ
Galeria='Galeria'
if not os.path.exists('face'):
    os.makedirs('face')
    print('Se creo la carpeta: face')
else:
    print('Carpeta encontrada :D')
face_id=cv2.CascadeClassifier(cv2.data.haarcascades + 'haarcascade_frontalface_default.xml')
for imagen in os.listdir(Galeria):
    foto=cv2.imread(Galeria + "/" + imagen)
    faces=face_id.detectMultiScale(foto, 1.1,5)
    for (x,y,w,h) in faces:
        #cv2.rectangle(foto, (x,y), (x+w, y+h),(0,225,0),2)
        face=foto[y:y + h, x:x + w]
        face=cv2.resize(face, (150,150))
        cv2.imshow('Face', face)
        cv2.waitKey(0)
        cv2.imwrite("Proyecto_python/face/"+ str(input()) + ".jpg", face) 
    #cv2.imshow('Foto', foto)
    #cv2.waitKey(0)
#cv2.destroyAllWindows()