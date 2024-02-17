--KEVIN MOLINA LAZARTE 
CREATE OR REPLACE PACKAGE TR_REGIONES AS
    -- PROCEDIMIENTOS
    PROCEDURE ALTA_REGION(p_region_id IN NUMBER, p_region_name IN VARCHAR2);
    PROCEDURE BAJA_REGION(p_region_id IN NUMBER);
    PROCEDURE MOD_REGION(p_region_id IN NUMBER, p_new_name IN VARCHAR2);
    
    -- FUNCIONES
    FUNCTION COD_REGION(p_region_id IN NUMBER) RETURN VARCHAR2;
    FUNCTION EXISTE_REGION(p_region_id IN NUMBER) RETURN BOOLEAN;
END TR_REGIONES;
/
CREATE OR REPLACE PACKAGE BODY TR_REGIONES AS

    -- PROCEDIMIENTOS
    -- ALTA_REGION
    PROCEDURE ALTA_REGION(p_region_id IN NUMBER, p_region_name IN VARCHAR2) IS
    BEGIN
        IF EXISTE_REGION(p_region_id) THEN
            RAISE_APPLICATION_ERROR(-20000, 'LA REGION CON EL ID '|| p_region_id ||' EXISTE');
        ELSE
            INSERT INTO regions (region_id, region_name)
            VALUES (p_region_id, p_region_name);
        END IF;
    END ALTA_REGION;

    -- BAJA_REGION
    PROCEDURE BAJA_REGION(p_region_id IN NUMBER) IS
    BEGIN
        IF EXISTE_REGION(p_region_id) THEN
            DELETE FROM regions
            WHERE region_id = p_region_id;
        ELSE
            RAISE_APPLICATION_ERROR(-20005, 'LA REGION CON EL ID '|| p_region_id ||' NO EXISTE');
        END IF;
    END BAJA_REGION;

    -- MOD_REGION
    PROCEDURE MOD_REGION(p_region_id IN NUMBER, p_new_name IN VARCHAR2) IS
    BEGIN
        IF EXISTE_REGION(p_region_id) THEN
            UPDATE regions
            SET region_name = p_new_name
            WHERE region_id = p_region_id;
        ELSE
            RAISE_APPLICATION_ERROR(-200010, 'LA REGION CON EL ID '|| p_region_id ||' NO EXISTE');
        END IF;
    END MOD_REGION;

    --FUNCIONES
    -- COD_REGION
    FUNCTION COD_REGION(p_region_id IN NUMBER) RETURN VARCHAR2 IS
        v_region_name VARCHAR2(50);
    BEGIN
        SELECT region_name INTO v_region_name
        FROM regions
        WHERE region_id = p_region_id;
        
        RETURN v_region_name;
    EXCEPTION
        WHEN NO_DATA_FOUND THEN
            RETURN NULL;
    END COD_REGION;

    -- EXISTE_REGION
    FUNCTION EXISTE_REGION(p_region_id IN NUMBER) RETURN BOOLEAN IS
        v_count NUMBER;
    BEGIN
        SELECT COUNT(*) INTO v_count
        FROM regions
        WHERE region_id = p_region_id;
        
        RETURN v_count > 0;
    END EXISTE_REGION;
END TR_REGIONES;