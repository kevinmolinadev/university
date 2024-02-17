package com.kevin.db_practica1.repository;

import com.kevin.db_practica1.entity.Product;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

import java.math.BigDecimal;
import java.util.List;

@SpringBootTest
public class QueriesUsingNamedQueries {
    @Autowired
    private  ProductRepository productRepository;

    @Test
    void finfByPriceNamedQueryProduct() {
        Long price=150L;
        Product product=productRepository.findByPrice(new BigDecimal(price));
        System.out.println(product.toString());
    }
    @Test
    void findAllOrderByNameDesc() {
        List<Product> productList = productRepository.findAllOrderByNameDesc();
        productList.forEach(product -> System.out.println(product.toString()));
    }

    @Test
    void findByDescriptionNativeQuery() {
        String descriptionToFind = "Esta es una descripción de ejemplo 2";
        Product product = productRepository.findByDescription(descriptionToFind);
        System.out.println("Product found by description: " + product.toString());
    }

    @Test
    void findAllOrderByNameASC() {
        List<Product> productList = productRepository.findAllOrderByNameASC();
        productList.forEach(product -> System.out.println(product.toString()));
    }
}
