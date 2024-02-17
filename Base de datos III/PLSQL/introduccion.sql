--USO DE ORACLE PLSQL

//BLOQUE ANONIMO/ UN BLOQUE DEBE INICIARSE Y CERRARCE 
SET SERVEROUTPUT ON
BEGIN
    dbms_output.put_line('HELLO WORD FROM ORACLE');
    dbms_output.put_line('HELLO WORD FROM ORACLE'|| ' HOLA DESDE ORACLE');
END;

//USO DE VARIABLE
/*DECLARE
    salary number(2);
    name varchar(100);
    fecha_nacimiento date*/
    
//USO DE VARIABLES CON VALOR
/*DECLARE
    SALARY NUMBER(2):=80;
    NAME VARCHAR(100):='Patito Juan';
    FECHA_NACIMIENTO DATE:='16-jun-2023';*/

//USO DE UN BLOQUE CON VARIABLES    
DECLARE
    SALARY NUMBER(2):=80;
    NAME VARCHAR(100):='Patito Juan';
    FECHA_NACIMIENTO DATE:='16-jun-2023';
BEGIN
    NULL;
END;

//VARIABLES ESCALARES EN PL/SQL
DECLARE 
    NAME VARCHAR(100):='Kevin';
    LASTNAME VARCHAR(100):='Molina';
BEGIN
    NAME:='Patito';
    dbms_output.put_line(NAME);
    dbms_output.put_line(LASTNAME);
    dbms_output.put_line(NAME ||' '|| LASTNAME);
END;


//VARIABLES CONSTANTES
DECLARE 
    X number:=5;
    Y number:=10;
BEGIN
    X:=X+Y;
    dbms_output.put_line(X);
END;


DECLARE 
    X number:=5;
    Y number:=NULL;
BEGIN
    X:=X+Y;
    dbms_output.put_line(X);
END;


DECLARE 
    X number:=5;
    Y number:=10;
    Z CONSTANT NUMBER:=20;
BEGIN
    Z:=10;
    X:=X+Y+Z;
    dbms_output.put_line(X);
END;