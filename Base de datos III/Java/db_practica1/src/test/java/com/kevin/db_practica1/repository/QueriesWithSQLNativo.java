package com.kevin.db_practica1.repository;

import com.kevin.db_practica1.entity.Product;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

import java.util.List;
@SpringBootTest
public class QueriesWithSQLNativo {
    @Autowired
    private ProductRepository productRepository;

    @Test
    void findByNameOrDescriptionSQLIndexParamProduct() {
        String name="Producto Ejemplo 1";
        String description="Esta es una descripción de ejemplo 3";
        List<Product> productList = productRepository.findByNameOrDescriptionSQLIndexParam(name,description);
        productList.forEach(product -> System.out.println(product.toString()));
    }

    @Test
    void findByNameOrDescriptionSQLNamedParamProduct() {
        String name="Producto Ejemplo 1";
        String description="Esta es una descripción de ejemplo 3";
        List<Product> productList = productRepository.findByNameOrDescriptionSQLNamedParam(name,description);
        productList.forEach(product -> System.out.println(product.toString()));
    }
}
