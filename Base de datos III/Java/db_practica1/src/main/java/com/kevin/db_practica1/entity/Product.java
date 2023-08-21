package com.kevin.db_practica1.entity;

import jakarta.persistence.*;
import lombok.*;
import org.hibernate.annotations.CreationTimestamp;
import org.hibernate.annotations.UpdateTimestamp;

import java.math.BigDecimal;
import java.time.LocalDateTime;
//@Getter @Setter @AllArgsConstructor @NoArgsConstructor @ToString
@Data
@Entity
//Usando consultas con NameQuery
//@NamedQuery(
//        name = "Product.findByPrice",
//        query = "SELECT p from Product p where p.price =: price"
//)
//@NamedQuery(
//        name = "Product.findAllOrderByNameDesc",
//        query = "SELECT p from Product p order by p.name desc"
//)
//Uso de NamedQueries
@NamedQueries({
        @NamedQuery(
                name = "Product.findByPrice",
                query = "SELECT p FROM Product p WHERE p.price = :price"
        ),
        @NamedQuery(
                name = "Product.findAllOrderByNameDesc",
                query = "SELECT p FROM Product p ORDER BY p.name DESC"
        ),
        @NamedQuery(
                name = "Product.findByDescription",
                query = "SELECT p FROM Product p WHERE p.description = :description"
        ),
        @NamedQuery(
                name = "Product.findAllOrderByNameASC",
                query = "SELECT p FROM Product p ORDER BY p.name ASC"
        )
})
@Table(
        name="products",
        schema = "practica1",
        uniqueConstraints = {
                @UniqueConstraint(
                        name = "unique_sku",
                        columnNames = "stock_keeping_unit"
                )
        }
)
public class Product {
    //El id es la llave primaria e incrementa automaticamente
    @Id
    @GeneratedValue(
            strategy = GenerationType.IDENTITY
    )
    private Long id;
    @Column(name = "stock_keeping_unit", nullable = false)
    private String sku;
    private String name;
    private String description;
    private BigDecimal price;
    private boolean active;
    private String urlImage;
    @CreationTimestamp
    private LocalDateTime dateCreated;
    @UpdateTimestamp
    private LocalDateTime lastUpdated;
}
