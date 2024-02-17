SET SERVEROUTPUT ON
//SQL DENTRO DE PL/SQL
DECLARE 
    salario number;
    nombre employees.first_name%type;
BEGIN
    select salary,first_name into salario,nombre
    from employees
    where employee_id = 114;
    dbms_output.put_line(salario||' -> '||nombre);
END;

//1
DECLARE 
    salario_max employees.salary%type;
BEGIN
    select max(salary) into salario_max
    from employees
    where employees.department_id=100;
    dbms_output.put_line('salario maximo del departamento 100 -> '||salario_max);
END;

//2
DECLARE 
    job_empleado employees.job_id%type;
BEGIN
    select job_id into job_empleado
    from employees
    where employees.employee_id=100;
    dbms_output.put_line('Tipo de trabajo del empleado 100 -> '||job_empleado);
END;

//3
DECLARE 
    departamento departments%rowtype;
BEGIN
    select department_id into departamento
    from employees
    where employees.employee_id=100;
    dbms_output.put_line('Tipo de trabajo del empleado 100 -> '||job_empleado);
END;

//4
DECLARE 
        salario_max employees.salary%type;
        salario_min employees.salary%type;
        diferencia employees.salary%type;

BEGIN
    select max(salary), min(salary) into salario_max, salario_min
    from employees
    where employees.department_id=100;
    diferencia:=salario_max-salario_min;
    dbms_output.put_line('Departemento 100 -> '||' Salario Maximo: '||salario_max ||' Salario Minimo: '||salario_min ||' Diferencia: '||diferencia);
END;