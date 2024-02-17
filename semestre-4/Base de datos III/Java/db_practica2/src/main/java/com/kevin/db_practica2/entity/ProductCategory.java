package com.kevin.db_practica2.entity;

import jakarta.persistence.*;
import lombok.Getter;
import lombok.Setter;

import java.util.ArrayList;
import java.util.List;

@Entity
@Getter @Setter
@Table(name = "product_categories")
public class ProductCategory {
    @Id
    @GeneratedValue(
            strategy = GenerationType.SEQUENCE,
            generator = "product_category_generator"
    )
    @SequenceGenerator(
            name = "product_category_generator",
            sequenceName = "product_category_sequence_name"
            , allocationSize = 1
    )
    private long id;
    private String categoryName;
    private String categoryDescription;
    @OneToMany(cascade = {
            CascadeType.PERSIST,
            CascadeType.MERGE
    }, fetch = FetchType.LAZY, mappedBy = "category")
    private List<Product> products = new ArrayList<>();
}
