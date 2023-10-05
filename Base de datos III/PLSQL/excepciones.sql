//EXCEPCIONES PRACTICA
SET SERVEROUTPUT ON

//1
DECLARE 
    EMPL EMPLOYEES.EMPLOYEE_ID%TYPE;
BEGIN
    SELECT EMPLOYEE_ID INTO EMPL FROM EMPLOYEES
    WHERE EMPLOYEE_ID =1000;
    dbms_output.put_line(EMPL);
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        dbms_output.put_line('Error, No se encontro ese empleado');
END;

//2
DECLARE 
    EMPL EMPLOYEES%ROWTYPE;
BEGIN
    SELECT * INTO EMPL FROM EMPLOYEES
    WHERE EMPLOYEE_ID > 100;
    dbms_output.put_line(EMPL.FIRST_NAME);
EXCEPTION
    WHEN TOO_MANY_ROWS THEN
        dbms_output.put_line('Error, Demasiados empleados en la consulta');
END;

//3
DECLARE 
    SALARY EMPLOYEES.SALARY%TYPE;
BEGIN
    SELECT SALARY INTO SALARY FROM EMPLOYEES
    WHERE EMPLOYEE_ID = 100;
    dbms_output.put_line(SALARY/0);
EXCEPTION
    WHEN ZERO_DIVIDE THEN
        dbms_output.put_line('Error, division por 0');
END;

//4 
DECLARE
    DUPLICATE EXCEPTION;
    PRAGMA EXCEPTION_INIT(DUPLICATE, -00001);
BEGIN
    INSERT INTO REGIONS VALUES (5,'DB');
    COMMIT;
EXCEPTION
    WHEN DUPLICATE THEN
        dbms_output.put_line('Error, Clave duplicada, intente otra');
END;
    