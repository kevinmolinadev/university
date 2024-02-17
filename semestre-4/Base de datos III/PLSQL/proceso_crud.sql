SET SERVEROUTPUT ON
//INSERT
DECLARE 
    c1 test.nombre%type;
BEGIN
    c1:='patito miguel';
    insert into test(nombre,edad) values (c1,'xxx');
    commit;
END;

//UPDATE
DECLARE 
    c1 test.nombre%type;
BEGIN
    c1:='kevin';
    update test set edad='18'
    where nombre=c1;
    commit;
END;

//DELETE
DECLARE 
    c1 test.nombre%type;
BEGIN
    c1:='patito';
    delete from test 
    where nombre=c1;
    commit;
END;


//PRACTICA DE CLASE
//1
DECLARE 
    id departments.department_id%type;
    location departments.location_id%type;
    manager departments.manager_id%type;
    name departments.department_name%type;
BEGIN
    select max(department_id)into id
    from departments;
    name:='Informatica';
    id:=id+1;
    manager:=100;
    location:=1000;
    insert into departments (DEPARTMENT_ID,DEPARTMENT_NAME,MANAGER_ID,LOCATION_ID)
    values (id,name,manager,location);
    commit;
END;

//2
DECLARE 
    location departments.location_id%type;
    name departments.department_name%type;
BEGIN
    name:='Informatica';
    location:=1700;
    update departments set location_id=location
    where department_name=name;
    commit;
END;

//3
DECLARE 
    name departments.department_name%type;
BEGIN
    name:='Informatica';
    delete from departments
    where department_name=name;
    commit;
END;

//4 Mostrar de forma ASC los departments 
BEGIN
    NULL;
END;