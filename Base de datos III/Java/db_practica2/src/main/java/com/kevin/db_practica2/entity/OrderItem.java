package com.kevin.db_practica2.entity;

import jakarta.persistence.*;
import lombok.Data;

import java.math.BigDecimal;
@Entity
@Data
@Table(name = "order_items")
public class OrderItem {
    @Id
    @GeneratedValue(
            strategy = GenerationType.SEQUENCE,
            generator = "order_item_generator"
    )
    @SequenceGenerator(
            name = "order_item_generator",
            sequenceName = "order_item_sequence_name"
            , allocationSize = 1
    )
    private long id;
    private String imageUrl;
    private BigDecimal price;
    private int quantity;
    @OneToOne
    @JoinColumn(name = "product_id")
    private Product product;
}
