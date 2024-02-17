// Practica Procedimientos 

--1
CREATE OR REPLACE PROCEDURE VISUALIZAR AS
BEGIN
  -- Seleccionar el nombre y el salario de todos los empleados
  FOR employee_rec IN (SELECT FIRST_NAME, SALARY FROM EMPLOYEES) LOOP
    -- Mostrar los datos del empleado
    DBMS_OUTPUT.PUT_LINE('Nombre: ' || employee_rec.FIRST_NAME || ', Salario: ' || employee_rec.SALARY);
  END LOOP;
END;

--2
CREATE OR REPLACE PROCEDURE VISUALIZAR_DEPARTAMENTO(
  dep_number IN NUMBER,
  employee_count OUT NUMBER
) AS
BEGIN
  employee_count := 0; -- Inicializar el contador de empleados
  
  -- Seleccionar el nombre y el salario de los empleados del departamento dado
  FOR employee_rec IN (SELECT FIRST_NAME, SALARY FROM EMPLOYEES WHERE DEPARTMENT_ID = dep_number) LOOP
    -- Mostrar los datos del empleado
    DBMS_OUTPUT.PUT_LINE('Nombre: ' || employee_rec.FIRST_NAME || ', Salario: ' || employee_rec.SALARY);
    employee_count := employee_count + 1; -- Incrementar el contador de empleados
  END LOOP;
END;

--3
CREATE OR REPLACE PROCEDURE CUENTA(
  acount_number IN OUT VARCHAR2
) AS
BEGIN
  -- Verificar si el numero de cuenta tiene 20 caracteres
  IF LENGTH(acount_number) = 20 THEN
    acount_number := SUBSTR(acount_number, 1, 4) || '-' || SUBSTR(acount_number, 5, 4) || '-' ||
                       SUBSTR(acount_number, 9, 2) || '-' || SUBSTR(acount_number, 11, 10);
  ELSE
    DBMS_OUTPUT.PUT_LINE('El numero de cuenta no es valido.');
  END IF;
END;




