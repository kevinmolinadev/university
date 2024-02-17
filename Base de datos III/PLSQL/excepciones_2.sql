//EXCEPCIONES PRACTICA
SET SERVEROUTPUT ON

//1
DECLARE
    CONTROL_REGIONES EXCEPTION;
    v_codigo_region NUMBER := 300;
BEGIN
    IF v_codigo_region > 200 THEN
      RAISE CONTROL_REGIONES;
    ELSE
        --INSERTAR O MODIFICAR DATOS
        INSERT INTO REGIONS VALUES(v_codigo_region,'America');
        DBMS_OUTPUT.PUT_LINE('Operaci�n exitosa.');
    END IF;
EXCEPTION
    WHEN CONTROL_REGIONES THEN
      DBMS_OUTPUT.PUT_LINE('C�DIGO NO PERMITIDO. Debe ser inferior a 200.');
END;