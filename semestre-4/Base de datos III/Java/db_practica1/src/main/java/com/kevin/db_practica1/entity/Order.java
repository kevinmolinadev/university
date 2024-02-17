package com.kevin.db_practica1.entity;

import jakarta.persistence.*;
import lombok.Data;
import lombok.Getter;
import org.hibernate.annotations.CreationTimestamp;
import org.hibernate.annotations.UpdateTimestamp;

import java.math.BigDecimal;
import java.time.LocalDateTime;
import java.util.HashSet;
import java.util.Set;

@Entity
@Data
@Table(name="orders")
public class Order {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long id;
    private String orderTrackingNumber;
    private int totalQuantity;
    @Getter
    private BigDecimal totalPrice;
    private String status;
    @CreationTimestamp
    private LocalDateTime dateCreated;
    @UpdateTimestamp
    private LocalDateTime lastUpdated;
    @OneToOne(cascade = CascadeType.ALL)
    //@JoinColumn(name = "billing_address_id", referencedColumnName = "id")
    private Address billingAddress;
    @OneToMany(cascade = CascadeType.ALL)
    @JoinColumn(name = "order_id", referencedColumnName = "id")
    private Set<OrderItem> orderItems= new HashSet<>();

    public BigDecimal getTotalAmount(){
        BigDecimal amount= new BigDecimal(0.0);
        for (OrderItem item: this.orderItems) {
            amount=amount.add(item.getPrice());
        }
        return  amount;
    }
    public int getTotalProducts(){
        int products=0;
        for (OrderItem item: this.orderItems) {
            products+=item.getQuantity();
        }
        return products;
    }
}
