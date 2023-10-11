--Ver quien agrega datos en regions
CREATE OR REPLACE TRIGGER INS_EMPL
AFTER INSERT ON REGIONS  
BEGIN
    INSERT INTO LOG_TABLE VALUES('INSERCION EN LA TABLA REGIONS', USER);
END;

--HR solo tinene acceso
CREATE OR REPLACE TRIGGER VALIDATION_HR
AFTER INSERT OR UPDATE OR DELETE ON REGIONS  
BEGIN
    IF USER <> 'HR' THEN
        RAISE_APPLICATION_ERROR(-20000,'NO ERES HR, NO TENES EL PODER');
    END IF;
END;

--Registro de quienes trabajan en la tabla REGIONS
CREATE or REPLACE TRIGGER TR_REGION
BEFORE INSERT OR UPDATE OR DELETE ON REGIONS
BEGIN

 IF INSERTING THEN
    INSERT INTO LOG_TABLE VALUES('INSERSION',USER);
 END IF;
  IF UPDATING('REGION_NAME') THEN
    INSERT INTO LOG_TABLE VALUES('UPDATE REGION_NAME',USER);
 END IF;
  IF UPDATING('REGION_ID') THEN
    INSERT INTO LOG_TABLE VALUES('UPDATE REGION_ID',USER);
 END IF;
  IF  DELETING THEN
    INSERT INTO LOG_TABLE VALUES('DELETE',USER);
 END IF;
END;