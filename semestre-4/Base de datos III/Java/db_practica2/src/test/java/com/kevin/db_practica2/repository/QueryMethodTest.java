package com.kevin.db_practica2.repository;

import com.kevin.db_practica2.entity.Product;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

import java.math.BigDecimal;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.util.List;

@SpringBootTest
public class QueryMethodTest {
    @Autowired
    private ProductRepository productRepository;

    @Test
    void findByNameProduct() {
        Product product=productRepository.findByName("Producto Ejemplo Actualizado");
        System.out.println("ID:"+product.getId()+"\nName: "+product.getName()+"\nDescription: "+product.getDescription());
    }

    @Test
    void findByIdProduct(){
        Product product=productRepository.findById(1L).get();
        System.out.println("ID:"+product.getId()+"\nName: "+product.getName()+"\nDescription: "+product.getDescription());
    }

    @Test
    void findByNameOrDescriptionProduct() {
        String name="Producto Ejemplo 1";
        String description="Esta es una descripción de ejemplo 3";
        List<Product> productList = productRepository.findByNameOrDescription(name,description);
        /*productRepository.findAll().forEach(product -> {
            if(product.getName() == name || product.getDescription() == description){
                productList.add(product);
            }
        });*/
        productList.forEach(product -> {
            System.out.println("ID:"+product.getId()+"\nName: "+product.getName()+"\nDescription: "+product.getDescription());
        });
    }

    @Test
    void findByNameAndDescriptionProduct() {
        String name="Producto Ejemplo 2";
        String description="Esta es una descripción de ejemplo 2";
        List<Product> productList = productRepository.findByNameAndDescription(name,description);
        /*productRepository.findAll().forEach(product -> {
            if(product.getName() == name || product.getDescription() == description){
                productList.add(product);
            }
        });*/
        productList.forEach(product -> {
            System.out.println("ID:"+product.getId()+"\nName: "+product.getName()+"\nDescription: "+product.getDescription());
        });
    }

    @Test
    void findByPriceGreaterThanProduct(){
        Long price = 120L;
        List<Product> productList = productRepository.findByPriceGreaterThan(new BigDecimal(price));
        productList.forEach(product -> {
            System.out.println("ID:"+product.getId()+"\nName: "+product.getName()+"\nPrice: "+product.getPrice());
        });
    }
    @Test
    void findByPriceLessThanProduct(){
        Long price = 120L;
        List<Product> productList = productRepository.findByPriceLessThan(new BigDecimal(price));
        productList.forEach(product -> {
            System.out.println("ID:"+product.getId()+"\nName: "+product.getName()+"\nPrice: "+product.getPrice());
        });
    }

    @Test
    void findByPriceBetweenProduct(){
        Long priceMax = 150L;
        Long priceMin = 120L;
        List<Product> productList = productRepository.findByPriceBetween(new BigDecimal(priceMin),new BigDecimal(priceMax));
        productList.forEach(product -> {
            System.out.println("ID:"+product.getId()+"\nName: "+product.getName()+"\nPrice: "+product.getPrice());
        });
    }

    @Test
    void findByDateCreatedBetweenProduct(){
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("yyyy-MM-dd HH:mm:ss.SSSSSS");
        String start="2023-08-14 23:02:06.678460";
        String end="2023-08-15 09:02:20.915272";
        LocalDateTime startDate = LocalDateTime.parse(start,formatter);
        LocalDateTime endDate = LocalDateTime.parse(end,formatter);
        List<Product> productList = productRepository.findByDateCreatedBetween(startDate, endDate);
        productList.forEach(product -> {
            System.out.println("ID:"+product.getId()+"\nName: "+product.getName()+"\nPrice: "+product.getPrice());
        });
    }

    @Test
    void findByNameInProduct() {
        List<String> names = List.of("Producto Ejemplo 1", "Producto Ejemplo 2", "Producto Ejemplo 3");
        List<Product> productList = productRepository.findByNameIn(names);
        productList.forEach(product -> {
            System.out.println("ID:" + product.getId() + "\nName: " + product.getName() + "\nDescription: " + product.getDescription());
        });
    }

    @Test
    void findFirst2ByOrderByNameAscProduct() {
        List<Product> productList = productRepository.findFirst2ByOrderByNameAsc();
        productList.forEach(product -> {
            System.out.println("ID:" + product.getId() + "\nName: " + product.getName() + "\nDescription: " + product.getDescription());
        });
    }

    @Test
    void findTop2ByOrderByNameDescProduct(){
        List<Product> productList = productRepository.findTop2ByOrderByNameDesc();
        productList.forEach(product -> {
            System.out.println("ID:"+product.getId()+"\nName: "+product.getName()+"\nDescription: "+product.getDescription());
        });
    }
}
