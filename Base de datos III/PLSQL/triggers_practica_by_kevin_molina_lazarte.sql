//PRACTICA TRIGGERS KEVIN MOLINA LAZARTE

--1
CREATE OR REPLACE TRIGGER DELETE_EMPLOYEE
BEFORE DELETE ON EMPLOYEES
FOR EACH ROW    
BEGIN
    IF :OLD.JOB_ID = 'ST_CLERK' THEN
        RAISE_APPLICATION_ERROR(-20000,'LOS EMPLEADOS CON JOB_ID: ST_CLERK NO SE PUEDEN ELIMINAR');
    END IF;
END;

--2
CREATE TABLE AUDITORIA (
  USUARIO VARCHAR(50),
  FECHA DATE,
  SALARIO_ANTIGUO NUMBER,
  SALARIO_NUEVO NUMBER
);

--3
CREATE OR REPLACE TRIGGER INSERT_REGION
BEFORE INSERT ON REGIONS
BEGIN
    IF INSERTING THEN
        INSERT INTO AUDITORIA VALUES(USER,SYSDATE,0,0);
    END IF;
END;

--4
CREATE OR REPLACE TRIGGER UPDATE_SALARY_EMPLOYEE
BEFORE UPDATE ON EMPLOYEES
FOR EACH ROW    
BEGIN
    IF :OLD.SALARY > :NEW.SALARY THEN
        RAISE_APPLICATION_ERROR(-20000,'EL SALARIO NUEVO ES MENOR AL SALARIO ACTUAL');
    ELSE
        INSERT INTO AUDITORIA VALUES(USER,SYSDATE,:OLD.SALARY,:NEW.SALARY);
        :NEW.SALARY:=:OLD.SALARY;
    END IF;
END;

--5
CREATE OR REPLACE TRIGGER INSERT_DEPARTMENT
BEFORE INSERT ON DEPARTMENTS
FOR EACH ROW
DECLARE
    COUNT_ROW NUMBER;
BEGIN
    SELECT COUNT(*) INTO COUNT_ROW FROM DEPARTMENTS WHERE DEPARTMENT_ID=:NEW.DEPARTMENT_ID;
    IF COUNT_ROW>0 THEN
        RAISE_APPLICATION_ERROR(-20000,'EL ID '||:NEW.DEPARTMENT_ID||' YA EXISTE');
    ELSE
        IF :NEW.LOCATION_ID IS NULL THEN
            :NEW.LOCATION_ID:=1700;
        END IF;
        IF :NEW.MANAGER_ID IS NULL THEN
            :NEW.MANAGER_ID:=200;
        END IF;
    END IF;
END;
