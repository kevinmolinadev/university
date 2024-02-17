package com.example.eventos.Clases;

import android.content.Context;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.Paint;
import android.graphics.Path;
import android.view.MotionEvent;
import android.view.SurfaceHolder;
import android.view.SurfaceView;
public class Pantalla extends SurfaceView implements SurfaceHolder.Callback {
    private SurfaceHolder holder;
    private Paint paint;
    private Path path;
    public Pantalla(Context context) {
        super(context);
        holder = getHolder();
        holder.addCallback(this);
        paint = new Paint();
        paint.setColor(Color.BLACK);
        paint.setStrokeWidth(10);
        paint.setStyle(Paint.Style.STROKE);
        path = new Path();
    }
    /*public void canbio(int color){
        paint.setColor(color);
    }*/


    @Override
    public void surfaceCreated(SurfaceHolder holder) {
        Canvas canvas = holder.lockCanvas();
        canvas.drawColor(Color.WHITE);
        draw(canvas);
        holder.unlockCanvasAndPost(canvas);
    }
    public void clear(){
        path.reset();
    }
    public void drawStar() {
        if (holder.getSurface().isValid()) {
            Canvas canvas = holder.lockCanvas();
            canvas.drawColor(Color.WHITE);
            paint.setColor(Color.YELLOW);
            Path path = new Path();
            int centerX = canvas.getWidth() / 2;
            int centerY = canvas.getHeight() / 2;
            int outerRadius = 100;
            int innerRadius = 50;
            int numPoints = 5;
            double angle = Math.PI / numPoints;
            for (int i = 0; i < numPoints * 2; i++) {
                double radius = (i % 2 == 0) ? outerRadius : innerRadius;
                float x = (float) (centerX + radius * Math.cos(i * angle));
                float y = (float) (centerY + radius * Math.sin(i * angle));
                if (i == 0) {
                    path.moveTo(x, y);
                } else {
                    path.lineTo(x, y);
                }
            }
            path.close();
            canvas.drawPath(path, paint);
            holder.unlockCanvasAndPost(canvas);
        }
    }
    public void drawCircle() {
        if (holder.getSurface().isValid()) {
            Canvas canvas = holder.lockCanvas();
            canvas.drawColor(Color.WHITE);
            paint.setColor(Color.RED);
            int centerX = canvas.getWidth() / 2;
            int centerY = canvas.getHeight() / 2;
            int radius = 100;
            canvas.drawCircle(centerX, centerY, radius, paint);
            holder.unlockCanvasAndPost(canvas);
        }
    }

    public void drawRectangle() {
        if (holder.getSurface().isValid()) {
            Canvas canvas = holder.lockCanvas();
            paint.setColor(Color.GREEN);
            int left = 100;
            int top = 200;
            int right = 300;
            int bottom = 400;
            canvas.drawRect(left, top, right, bottom, paint);
            holder.unlockCanvasAndPost(canvas);
        }
    }

    public void drawLine() {
        if (holder.getSurface().isValid()) {
            Canvas canvas = holder.lockCanvas();
            paint.setColor(Color.BLUE);
            int startX = 50;
            int startY = 500;
            int endX = 250;
            int endY = 500;
            canvas.drawLine(startX, startY, endX, endY, paint);
            holder.unlockCanvasAndPost(canvas);
        }
    }

    @Override
    public void surfaceChanged(SurfaceHolder holder, int format, int width, int height) {
    }
    @Override
    public void surfaceDestroyed(SurfaceHolder holder) {
    }
    public void draw(Canvas canvas) {
        super.draw(canvas);
        canvas.drawColor(Color.WHITE);
        canvas.drawPath(path, paint);
    }
    @Override
    public boolean onTouchEvent(MotionEvent event) {
        float x = event.getX();
        float y = event.getY();
        switch (event.getAction()) {
            case MotionEvent.ACTION_DOWN:
                path.moveTo(x, y);
                break;
            case MotionEvent.ACTION_MOVE:
                path.lineTo(x, y);
                break;
            case MotionEvent.ACTION_UP:
                break;
            default:
                return false;
        }
        Canvas canvas = holder.lockCanvas();
        draw(canvas);
        holder.unlockCanvasAndPost(canvas);
        return true;
    }
}