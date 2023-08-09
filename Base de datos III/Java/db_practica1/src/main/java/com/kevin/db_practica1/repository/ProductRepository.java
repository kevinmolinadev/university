package com.kevin.db_practica1.repository;

import com.kevin.db_practica1.entity.Product;
import org.springframework.data.jpa.repository.JpaRepository;

//Esta interfaz e
public interface ProductRepository extends JpaRepository<Product, Long> {

}
