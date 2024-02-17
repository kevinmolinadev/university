package com.kevin.db_practica2.repository;

import com.kevin.db_practica2.entity.Product;
import com.kevin.db_practica2.entity.ProductCategory;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

import java.math.BigDecimal;

@SpringBootTest
class ProductCategoryRepositoryTest {
    @Autowired
    private ProductCategoryRepository productCategoryRepository;

    @Test
    void saveProductCategory() {
        ProductCategory productCategory = new ProductCategory();
        productCategory.setCategoryName("Libros");
        productCategory.setCategoryDescription("Aqui estaran los libros de la materia");

        Product product1= new Product();
        product1.setName("Calculo 1");
        product1.setSku("AAA1");
        product1.setDescription("Calculo 1: The best");
        product1.setPrice(new BigDecimal(150));
        product1.setActive(true);
        product1.setUrlImage("https://ejemplo.com/calculo1.jpg");

        Product product2= new Product();
        product2.setName("Calculo 2");
        product2.setSku("AAA2");
        product2.setDescription("Calculo 2: Finally");
        product2.setPrice(new BigDecimal(250));
        product2.setActive(true);
        product2.setUrlImage("https://ejemplo.com/calculo2.jpg");

        productCategory.getProducts().add(product1);
        productCategory.getProducts().add(product2);

        productCategoryRepository.save(productCategory);
    }
}