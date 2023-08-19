package com.kevin.db_practica1.repository;

import com.kevin.db_practica1.entity.Product;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;

import java.math.BigDecimal;
import java.time.LocalDateTime;
import java.util.List;
import java.util.Optional;

//Esta interfaz e
public interface ProductRepository extends JpaRepository<Product, Long> {

    /*
     * Retornar productos con la condición de que exista el Name
     * */
    Product findByName(String name);

    /*
     * Retornar productos con la condición de que exisa el Id
     * */
    @Override
    Optional<Product> findById(Long id);

    /*
     * Retornar productos con la condición de que exista el Name o exista la descripción.
     * */
    List<Product> findByNameOrDescription(String name, String description);

    /*
     * Retornar productos con la condición de que exista el Name y exista la descripción.
     * */
    List<Product> findByNameAndDescription(String name, String description);


    /*
     * Retornar productos cuyos precios son mayores al que se le envía por parámetro.
     * */
    List<Product> findByPriceGreaterThan(BigDecimal price);

    /*
     * Retornar productos cuyos precios son menores al que se le envía por parámetro.
     * */
    List<Product> findByPriceLessThan(BigDecimal price);

    /*
     * Retornar productos cuyos precios se encuentren en un rango (Between).
     * */
    List<Product> findByPriceBetween(BigDecimal startPrice, BigDecimal endPrice);

    /*
     * Retornar productos que fueron creados en un rango específico (Between).
     * */
    List<Product> findByDateCreatedBetween(LocalDateTime startDate, LocalDateTime endDate);

    //Trabajo de investigación

    /*
     * Retornar productos que se encuentren dentro de la lista de names
     * */
    List<Product> findByNameIn(List<String> names);

    /*
     * Retorna los primeros 2 productos ordenados alfabéticamente por nombre de manera ascendente (de la A a la Z)
     * */
    public List<Product> findFirst2ByOrderByNameAsc();

    /*
     * Retorna los primeros 2 productos ordenados alfabéticamente por nombre de manera descendente (de la Z a la A)
     * */
    public List<Product> findTop2ByOrderByNameDesc();

    //Creando metodos de consulta personalizados con JPQL

    //Consulta con JPQL utilizando parametros como posiciones
    @Query("SELECT p FROM Product p WHERE  p.name=?1 or p.description=?2")
    List<Product> findByNameOrDescriptionJPQLIndexParam(String name,String description);

    //Consulta con JPQL utilizando nombres como pararametros
    @Query("SELECT p FROM Product p WHERE  p.name=:name or p.description=:description")
    List<Product> findByNameOrDescriptionJPQLNamedParam(@Param("name") String name,@Param("description") String description);

    //Creando metodos de consulta personalizados con SQL nativo

    //Consulta con SQL utilizando parametros como posiciones
    @Query(value = "SELECT * FROM products p WHERE  p.name=?1 or p.description=?2", nativeQuery = true)
    List<Product> findByNameOrDescriptionSQLIndexParam(String name,String description);

    //Consulta con SQL utilizando nombres como pararametros
    @Query(value = "SELECT * FROM products p WHERE  p.name=:name or p.description=:description", nativeQuery = true)
    List<Product> findByNameOrDescriptionSQLNamedParam(@Param("name") String name,@Param("description") String description);

    //Creando metodos de consulta con Named Querry con JPQL
    Product findByPrice(@Param("price") BigDecimal price);
    List<Product> findAllOrderByNameDesc();

    //Creando metodos de consulta con Named Querry con SQL Nativo
    @Query(nativeQuery = true)
    Product findByDescription(@Param("description") String description);
    List<Product> findAllOrderByNameASC();



}
