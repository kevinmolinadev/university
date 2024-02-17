CREATE OR REPLACE TRIGGER PF_TOTAL_VENDIDO
BEFORE INSERT OR UPDATE OR DELETE ON LINEAS_FACTURA
FOR EACH ROW
DECLARE
    V_COUNT NUMBER;
    V_COD NUMBER;
BEGIN
    V_COD:=NVL(:NEW.COD_PRODUCTO, :OLD.COD_PRODUCTO);
    SELECT TOTAL_VENDIDOS INTO V_COUNT FROM PRODUCTOS WHERE COD_PRODUCTO=V_COD;
    IF V_COUNT IS NULL THEN
        V_COUNT:=0;
    END IF;
    IF INSERTING THEN
        V_COUNT:= V_COUNT+:NEW.UNIDADES;
    ELSIF UPDATING THEN
        IF :OLD.UNIDADES > :NEW.UNIDADES THEN
            V_COUNT:= V_COUNT - (:OLD.UNIDADES - :NEW.UNIDADES);
        ELSE
            V_COUNT:=V_COUNT + (:NEW.UNIDADES - :OLD.UNIDADES);
        END IF;
    ELSIF DELETING THEN
        V_COUNT:=V_COUNT-:OLD.UNIDADES;
    END IF;
    BEGIN
        UPDATE PRODUCTOS SET TOTAL_VENDIDOS = V_COUNT WHERE COD_PRODUCTO = V_COD;
    END;
    DBMS_OUTPUT.PUT_LINE('COD_PRODUCTO: '||V_COD||' TOTAL_VENDIDOS: '||V_COUNT||' UNIDADES ELIMINADAS: '||:OLD.UNIDADES ||' UNIDADES AGREGADAS: '||:NEW.UNIDADES);
END;