--KEVIN MOLINA LAZARTE
CREATE OR REPLACE PACKAGE TR_NOMINA AS
    FUNCTION CALCULAR_NOMINA(employee_id NUMBER) RETURN NUMBER;
    FUNCTION CALCULAR_NOMINA_TWO(employee_id NUMBER, porcentaje_descuento NUMBER) RETURN NUMBER;
    FUNCTION CALCULAR_NOMINA_THREE(employee_id NUMBER, porcentaje_descuento NUMBER, tiene_comision CHAR) RETURN NUMBER;
END TR_NOMINA;
/

CREATE OR REPLACE PACKAGE BODY TR_NOMINA AS
    FUNCTION CALCULAR_NOMINA(employee_id NUMBER) RETURN NUMBER IS
        salario NUMBER;
    BEGIN
        SELECT MAX(salary) INTO salario FROM employees WHERE employee_id =employee_id;
        RETURN salario * 0.85;
    END CALCULAR_NOMINA;

    FUNCTION CALCULAR_NOMINA_TWO(employee_id NUMBER, porcentaje_descuento NUMBER) RETURN NUMBER IS
        salario NUMBER;
    BEGIN
        SELECT MAX(salary) INTO salario FROM employees WHERE employee_id = employee_id;
        RETURN salario * (1 - porcentaje_descuento / 100); 
    END CALCULAR_NOMINA_TWO;

    FUNCTION CALCULAR_NOMINA_THREE(employee_id NUMBER, porcentaje_descuento NUMBER, tiene_comision CHAR) RETURN NUMBER IS
        salario NUMBER;
        comision_amount NUMBER := 0;
    BEGIN
        SELECT MAX(salary) INTO salario FROM employees WHERE employee_id = employee_id;
        IF tiene_comision = 'V' THEN
            comision_amount := salario * 0.05;
        END IF;
        RETURN (salario + comision_amount) * (1 - porcentaje_descuento / 100); 
    END CALCULAR_NOMINA_THREE;
END TR_NOMINA;
/
