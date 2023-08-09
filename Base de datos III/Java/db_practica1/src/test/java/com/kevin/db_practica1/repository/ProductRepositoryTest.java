package com.kevin.db_practica1.repository;

import com.kevin.db_practica1.entity.Product;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

import java.math.BigDecimal;
import java.util.List;

import static org.junit.jupiter.api.Assertions.*;

@SpringBootTest
class ProductRepositoryTest {
    @Autowired //Aqui estamos inyectando a la interface  que tiene implementado los metodos que necesitamos
    private ProductRepository productRepository;

    //Pruebas unitarias de los procesos CRUD
    @Test
    void saveProduct() {
        //creamos un producto
        Product product = new Product();
        product.setName("Producto Ejemplo");
        product.setSku("SKU234");
        product.setDescription("Esta es una descripción de ejemplo");
        product.setPrice(new BigDecimal(15));
        product.setActive(true);
        product.setUrlImage("https://ejemplo.com/imagen.jpg");

        //guardamos el producto
        Product saveProduct=productRepository.save(product);
        System.out.println(saveProduct.getId());
        System.out.println(saveProduct.toString());
    }
    @Test
    void updateProduct(){
        Long id=1L;
        //obtenemos el producto que querremos actualizar desde el id
        Product product = productRepository.findById(id).get();
        product.setName("Producto Ejemplo Actualizado");

        //guardar actualizacion
        productRepository.save(product);

    }

    @Test
    void saveAllProducts() {
        //creamos un producto
        Product product = new Product();
        product.setName("Producto Ejemplo 2");
        product.setSku("SKU345");
        product.setDescription("Esta es una descripción de ejemplo 2");
        product.setPrice(new BigDecimal(150));
        product.setActive(true);
        product.setUrlImage("https://ejemplo.com/imagen2.jpg");
        //creamos un producto
        Product product2 = new Product();
        product2.setName("Producto Ejemplo 3");
        product2.setSku("SKU456");
        product2.setDescription("Esta es una descripción de ejemplo 3");
        product2.setPrice(new BigDecimal(145));
        product2.setActive(true);
        product2.setUrlImage("https://ejemplo.com/imagen3.jpg");

        productRepository.saveAll(List.of(product,product2));

    }

    @Test
    void findAllProduct() {
        List<Product> products = productRepository.findAll();
        products.forEach(product -> {
            System.out.println(product.getName());
        });
    }
}