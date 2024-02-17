CREATE OR REPLACE TRIGGER PF_GESTION_FACTURAS
BEFORE INSERT OR UPDATE OR DELETE ON FACTURAS
DECLARE
    V_OPERACION VARCHAR2(10);
BEGIN
    IF INSERTING THEN
        V_OPERACION:='INSERT';
    ELSIF UPDATING THEN
        V_OPERACION:='UPDATE';
    ELSIF DELETING THEN
        V_OPERACION:='DELETE';
    END IF;
    INSERT INTO LOG_CONTROL VALUES('FACTURAS',SYSDATE,USER,V_OPERACION);
END;

CREATE OR REPLACE TRIGGER PF_LINEAS_FACTURA
BEFORE INSERT OR UPDATE OR DELETE ON LINEAS_FACTURA
DECLARE
    V_OPERACION VARCHAR2(10);
BEGIN
    IF INSERTING THEN
        V_OPERACION:='INSERT';
    ELSIF UPDATING THEN
        V_OPERACION:='UPDATE';
    ELSIF DELETING THEN
        V_OPERACION:='DELETE';
    END IF;
    INSERT INTO LOG_CONTROL VALUES('LINEAS_FACTURA',SYSDATE,USER,V_OPERACION);
END;
