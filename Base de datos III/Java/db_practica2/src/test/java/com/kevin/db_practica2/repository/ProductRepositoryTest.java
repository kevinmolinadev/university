package com.kevin.db_practica2.repository;

import com.kevin.db_practica2.entity.Product;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;

@SpringBootTest
class ProductRepositoryTest {
    @Autowired //Aqui estamos inyectando a la interface  que tiene implementado los metodos que necesitamos
    private ProductRepository productRepository;
    //Pruebas unitarias de los procesos CRUD
    @Test
    void saveProduct() {
        //creamos un producto
        Product product = new Product();
        product.setName("Producto Ejemplo 31");
        product.setSku("SKU14546");
        product.setDescription("Esta es una descripción de ejemplo");
        product.setPrice(new BigDecimal(550));
        product.setActive(true);
        product.setUrlImage("https://ejemplo.com/imagen31.jpg");

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
        //Product product = new Product();
        //product.setName("Producto Ejemplo 2");
        //product.setSku("SKU345");
        //product.setDescription("Esta es una descripción de ejemplo 2");
        //product.setPrice(new BigDecimal(150));
        //product.setActive(true);
        //product.setUrlImage("https://ejemplo.com/imagen2.jpg");
        //creamos un producto
        //Product product2 = new Product();
        //product2.setName("Producto Ejemplo 3");
        //product2.setSku("SKU456");
        //product2.setDescription("Esta es una descripción de ejemplo 3");
        //product2.setPrice(new BigDecimal(145));
        //product2.setActive(true);
        //product2.setUrlImage("https://ejemplo.com/imagen3.jpg");

        //productRepository.saveAll(List.of(product,product2));

        List<Product> products = new ArrayList<>();

        Random random=new Random();
        for (int i = 2; i <= 30; i++) {
            Product product = new Product();
            product.setName("Producto Ejemplo " + i);
            product.setSku("SKU" + (1000 + i));
            product.setDescription("Esta es una descripción de ejemplo " + i);
            product.setPrice(new BigDecimal(random.nextInt(500) + 1));
            product.setActive(true);
            product.setUrlImage("https://ejemplo.com/imagen" + i + ".jpg");
            products.add(product);
        }

        productRepository.saveAll(products);

    }

    @Test
    void findAllProduct() {
        List<Product> products = productRepository.findAll();
        products.forEach(product -> {
            System.out.println(product.getId()+" -> "+product.getName());
        });
    }

    @Test
    void deleteProductById() {
        long id  = 2L;
        productRepository.deleteById(id);
    }

    @Test
    void deleteProduct() {
        // encontrar el registro a eliminar
        long id = 3L;
        Product product = productRepository.findById(id).get();
        //Eliminar
        productRepository.delete(product);

    }

    @Test
    void deleteAllProduct() {
        //Eliminar todos los registros
        //productRepository.deleteAll();

        //Eliminar registros especificos
        Product product1 = productRepository.findById(2L).get();
        Product product2 = productRepository.findById(3L).get();

        productRepository.deleteAll(List.of(product1,product2));
    }
}