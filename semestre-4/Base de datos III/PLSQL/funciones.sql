// Practica Funciones

--1 
CREATE OR REPLACE FUNCTION calcular_salarios (p_departamento_id NUMBER)
RETURN NUMBER
IS
  salary_total NUMBER := 0;
BEGIN
  -- Verificar si el departamento existe
  SELECT SUM(SALARY) INTO salary_total
  FROM EMPLOYEES
  WHERE DEPARTMENT_ID = p_departamento_id;
  
  IF salary_total IS NULL THEN
    -- Si no se encuentra ningun empleado en el departamento
    RAISE_APPLICATION_ERROR(-20001, 'No hay empleados en el departamento especificado.');
  ELSIF salary_total = 0 THEN
    -- Si la suma de salarios es cero
    RAISE_APPLICATION_ERROR(-20002, 'El departamento existe, pero no hay salarios.');
  END IF;
  
  RETURN salary_total;
EXCEPTION
  WHEN NO_DATA_FOUND THEN
    -- Si el departamento no existe
    RAISE_APPLICATION_ERROR(-20003, 'El departamento no existe.');
END;

--2
CREATE OR REPLACE FUNCTION calcular_salarios_out (
  p_departamento_id NUMBER,
  p_num_empleados_afectados OUT NUMBER
)
RETURN NUMBER
IS
  salary_total NUMBER := 0;
BEGIN
  -- Verificar si el departamento existe
  SELECT SUM(SALARY) INTO salary_total
  FROM EMPLOYEES
  WHERE DEPARTMENT_ID = p_departamento_id;
  
  IF salary_total IS NULL THEN
    -- Si no se encuentra ningun empleado en el departamento
    RAISE_APPLICATION_ERROR(-20001, 'No hay empleados en el departamento especificado.');
  ELSIF salary_total = 0 THEN
    -- Si la suma de salarios es cero
    RAISE_APPLICATION_ERROR(-20002, 'El departamento existe, pero no hay salarios que sumar.');
  END IF;
  
  -- Contar el numero de empleados afectados por la consulta
  SELECT COUNT(*) INTO p_num_empleados_afectados
  FROM EMPLOYEES
  WHERE DEPARTMENT_ID = p_departamento_id;

  RETURN salary_total;
EXCEPTION
  WHEN NO_DATA_FOUND THEN
    -- Si el departamento no existe
    RAISE_APPLICATION_ERROR(-20003, 'El departamento no existe.');
END;

--3
CREATE OR REPLACE FUNCTION CREAR_REGION (name_region VARCHAR2)
RETURN NUMBER
IS
  id_region NUMBER;
BEGIN
  -- Obtener el codigo de region mas alto existente y agregar 1
  SELECT NVL(MAX(REGION_ID), 0) + 1 INTO id_region
  FROM REGIONS;

  -- Insertar la nueva region en la tabla
  INSERT INTO REGIONS (REGION_ID, REGION_NAME) VALUES (id_region, name_region);
  
  COMMIT; -- Confirmar la transaccion

  RETURN id_region; -- Devolver el nuevo codigo de region
EXCEPTION
  WHEN OTHERS THEN
    -- Si se produce algun error, generar un mensaje de error
    RAISE_APPLICATION_ERROR(-20001, 'Error al crear la region: ' || SQLERRM);
END;