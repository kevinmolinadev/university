package com.kevin.db_practica2.repository;

import com.kevin.db_practica2.entity.Product;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

import java.util.List;

@SpringBootTest
public class QueriesWithJPQL {
    @Autowired
    private ProductRepository productRepository;

    @Test
    void findByNameOrDescriptionJPQLIndexParamProduct() {
        String name="Producto Ejemplo 1";
        String description="Esta es una descripción de ejemplo 3";
        List<Product> productList = productRepository.findByNameOrDescriptionJPQLIndexParam(name,description);
        productList.forEach(product -> System.out.println(product.toString()));
    }

    @Test
    void findByNameOrDescriptionJPQLNamedParamProduct() {
        String name="Producto Ejemplo 1";
        String description="Esta es una descripción de ejemplo 3";
        List<Product> productList = productRepository.findByNameOrDescriptionJPQLNamedParam(name,description);
        productList.forEach(product -> System.out.println(product.toString()));
    }
}
