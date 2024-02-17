//%Type esto hereda el tipo de dato de la varaible asignada 
DECLARE
    X NUMBER;
    Z X%TYPE; //hereda el tipo de dato de X
BEGIN
    NULL;
END;

//INPUESTO
DECLARE 
    Producto varchar(100):='Camisa';
    Precio number(5,2):=150;
    Impuesto CONSTANT NUMBER(5,2):=0.21;
    Precio_Total number(5,2);
BEGIN
    Precio_Total:=Precio-(Precio*Impuesto);
    dbms_output.put_line('Precio: '||Precio_Total);
END;