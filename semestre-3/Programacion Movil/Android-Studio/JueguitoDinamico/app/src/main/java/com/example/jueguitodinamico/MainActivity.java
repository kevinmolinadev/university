package com.example.jueguitodinamico;

import androidx.appcompat.app.AppCompatActivity;

import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.drawable.BitmapDrawable;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.text.InputType;
import android.view.Gravity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.TextView;

import com.google.android.material.snackbar.Snackbar;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Random;

public class MainActivity extends AppCompatActivity {
    List<ImageView> imageViews;
    List<ImageView> originales;
    int idImgSelect = 0;
    boolean canbio=false;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        getSupportActionBar().hide();
        imageViews = new ArrayList<>();
        originales = new ArrayList<>();
        generarPuzzle(1,1);
    }
    public void generarPuzzle(int columnapuzzle,int filapuzzle){
        //CREACION DEL LAYOUT PADRE
        LinearLayout lienzo= new LinearLayout(this);
        lienzo.setOrientation(LinearLayout.VERTICAL);
        lienzo.setLayoutParams(new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MATCH_PARENT,LinearLayout.LayoutParams.MATCH_PARENT));
        lienzo.setGravity(Gravity.CENTER);
        //SECCION DE USUARIO
        LinearLayout User = new LinearLayout(this);
        User.setOrientation(LinearLayout.VERTICAL);
        User.setLayoutParams(new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MATCH_PARENT, LinearLayout.LayoutParams.WRAP_CONTENT));
        User.setPadding(0,0,0,35);
        User.setGravity(Gravity.CENTER_HORIZONTAL);
        EditText editTextcolumna = new EditText(this);
        editTextcolumna.setLayoutParams(new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MATCH_PARENT, LinearLayout.LayoutParams.WRAP_CONTENT));
        editTextcolumna.setHint("Ingrese el numero de columanas");
        editTextcolumna.setInputType(InputType.TYPE_CLASS_NUMBER);
        User.addView(editTextcolumna);
        EditText editTextfila = new EditText(this);
        editTextfila.setLayoutParams(new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MATCH_PARENT, LinearLayout.LayoutParams.WRAP_CONTENT));
        editTextfila.setHint("Ingrese el numero de filas");
        editTextfila.setInputType(InputType.TYPE_CLASS_NUMBER);
        User.addView(editTextfila);
        Button btnM = new Button(this);
        btnM.setLayoutParams(new LinearLayout.LayoutParams(LinearLayout.LayoutParams.WRAP_CONTENT, LinearLayout.LayoutParams.WRAP_CONTENT));
        btnM.setText("GENERAR");
        btnM.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if (editTextcolumna.getText().toString().isEmpty() && editTextfila.getText().toString().isEmpty()){
                    Snackbar.make(btnM, "Ingrese un numero :D", Snackbar.LENGTH_SHORT).show();
                }else{
                    int columna=Integer.valueOf(editTextcolumna.getText().toString());
                    int fila=Integer.valueOf(editTextfila.getText().toString());
                    imageViews.clear();
                    originales.clear();
                    generarPuzzle(columna,fila);
                }
            }
        });
        User.addView(btnM);
        lienzo.addView(User);
        //SECCION DE LA IMAGEN
        Bitmap imagenOriginal = BitmapFactory.decodeResource(getResources(), R.drawable.profile);
        int anchoSeccion = imagenOriginal.getWidth() / columnapuzzle;
        int altoSeccion = imagenOriginal.getHeight() / filapuzzle;
        int escala=2;
        Bitmap[][] secciones = new Bitmap[filapuzzle][columnapuzzle];
        for (int fila = 0; fila < filapuzzle; fila++) {
            LinearLayout filaLayout = new LinearLayout(this);
            filaLayout.setLayoutParams(new LinearLayout.LayoutParams(LinearLayout.LayoutParams.WRAP_CONTENT, LinearLayout.LayoutParams.WRAP_CONTENT));
            for (int columna = 0; columna < columnapuzzle; columna++) {
                ImageView imageView1 = new ImageView(this);
                int x = columna * anchoSeccion;
                int y = fila * altoSeccion;
                secciones[fila][columna] = Bitmap.createBitmap(imagenOriginal, x, y, anchoSeccion, altoSeccion);
                imageViews.add(imageView1);
                imageView1.setId(imageViews.size() -1);
                System.out.println(imageView1.getId());
                imageView1.setImageBitmap(secciones[fila][columna]);
                imageView1.setOnClickListener(this::onClick);
                if (columnapuzzle==1){
                    imageView1.setLayoutParams(new LinearLayout.LayoutParams(anchoSeccion/escala, altoSeccion/escala));
                }
                else if (columnapuzzle<3){
                    imageView1.setLayoutParams(new LinearLayout.LayoutParams(anchoSeccion/escala, altoSeccion/escala));
                } else if (columnapuzzle>=3 && columnapuzzle <6) {
                    imageView1.setLayoutParams(new LinearLayout.LayoutParams(anchoSeccion/escala, altoSeccion/escala));
                }else {
                    imageView1.setLayoutParams(new LinearLayout.LayoutParams(anchoSeccion/escala, altoSeccion/escala));
                }
                ((LinearLayout.LayoutParams) imageView1.getLayoutParams()).setMargins(3, 3, 3, 3);
                // Agregar la ImageView al contenedor
                filaLayout.addView(imageView1);
            }
            lienzo.addView(filaLayout);
        }
        //SECCION ALEATORIA
        Button mezclar =new Button(this);
        mezclar.setLayoutParams(new LinearLayout.LayoutParams(LinearLayout.LayoutParams.WRAP_CONTENT, LinearLayout.LayoutParams.WRAP_CONTENT));
        ((LinearLayout.LayoutParams)mezclar.getLayoutParams()).setMargins(0, 35, 0, 0);
        mezclar.setText("MEZCLAR");
        mezclar.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                mezclarImagenes(imageViews);
            }
        });
        lienzo.addView(mezclar);
        for (ImageView imageView : imageViews) {
            ImageView original = new ImageView(imageView.getContext());
            original.setImageDrawable(imageView.getDrawable());
            originales.add(original);
        }
        setContentView(lienzo);
    }

    public ImageView getImage(int id) {
        ImageView imageView;
        for (int i = 0; i < imageViews.size(); i++) {
            if (imageViews.get(i).getId() == id) {
                return  imageViews.get(i);
            }
        }
        return null;
    }
    public void onClick(View view) {
        if (!canbio) {
            idImgSelect= view.getId();
            canbio=true;
        } else  {
            ImageView anterior = getImage(idImgSelect);
            ImageView ahora = getImage(view.getId());
            Drawable drawable = anterior.getDrawable();
            anterior.setImageDrawable(ahora.getDrawable());
            ahora.setImageDrawable(drawable);
            canbio = false;
            boolean ganado = true;
            for (int i = 0; i < imageViews.size(); i++) {
                if (!compararImagenes(imageViews.get(i), originales.get(i))) {
                    ganado = false;
                    break;
                }
            }
            if (ganado) {
                Snackbar.make(view, "GANASTE :D", Snackbar.LENGTH_SHORT).show();
                imageViews.clear();
                originales.clear();
                generarPuzzle(1,1);
            }
        }
    }
    private boolean compararImagenes(ImageView imagen1, ImageView imagen2) {
        Bitmap bitmap1 = ((BitmapDrawable) imagen1.getDrawable()).getBitmap();
        Bitmap bitmap2 = ((BitmapDrawable) imagen2.getDrawable()).getBitmap();
        return bitmap1.sameAs(bitmap2);
    }

    private void mezclarImagenes(List<ImageView> imageViews) {
        int numImagenes = imageViews.size();
        int[] indicesAleatorios = generarIndicesAleatorios(numImagenes);

        for (int i = 0; i < numImagenes; i++) {
            int indiceActual = indicesAleatorios[i];
            int indiceSiguiente = (i + 1) % numImagenes; // Si llegamos al final, volvemos al principio
            Drawable temp = imageViews.get(indiceActual).getDrawable();
            imageViews.get(indiceActual).setImageDrawable(imageViews.get(indiceSiguiente).getDrawable());
            imageViews.get(indiceSiguiente).setImageDrawable(temp);
        }
    }

    private int[] generarIndicesAleatorios(int numIndices) {
        int[] indicesAleatorios = new int[numIndices];
        Random random = new Random();
        for (int i = 0; i < numIndices; i++) {
            int indiceAleatorio;
            boolean repetido;
            do {
                indiceAleatorio = random.nextInt(numIndices);
                repetido = false;
                for (int j = 0; j < i; j++) {
                    if (indicesAleatorios[j] == indiceAleatorio) {
                        repetido = true;
                        break;
                    }
                }
            } while (repetido);
            indicesAleatorios[i] = indiceAleatorio;
        }
        return indicesAleatorios;
    }
}