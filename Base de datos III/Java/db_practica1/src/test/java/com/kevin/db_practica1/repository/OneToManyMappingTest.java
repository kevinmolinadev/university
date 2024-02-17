package com.kevin.db_practica1.repository;

import com.kevin.db_practica1.entity.Address;
import com.kevin.db_practica1.entity.Order;
import com.kevin.db_practica1.entity.OrderItem;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

import java.math.BigDecimal;

@SpringBootTest
public class OneToManyMappingTest {
    @Autowired
    private OrderRepository orderRepository;
    @Autowired
    private ProductRepository productRepository;

    @Test
    void saveOrderItems() {
        Order order= new Order();
        order.setOrderTrackingNumber("A345");
        order.setStatus("En proceso");

        //Item1
        OrderItem orderItem1= new OrderItem();
        orderItem1.setProduct(productRepository.findById(1L).get());
        orderItem1.setImageUrl(orderItem1.getProduct().getUrlImage());
        orderItem1.setQuantity(2);
        orderItem1.setPrice(orderItem1.getProduct().getPrice().multiply(new BigDecimal(orderItem1.getQuantity())));

        //Item2
        OrderItem orderItem2= new OrderItem();
        orderItem2.setProduct(productRepository.findById(2L).get());
        orderItem2.setImageUrl(orderItem2.getProduct().getUrlImage());
        orderItem2.setQuantity(2);
        orderItem2.setPrice(orderItem1.getProduct().getPrice().multiply(new BigDecimal(orderItem2.getQuantity())));

        //Aqui agregamos los productos en la orden
        order.getOrderItems().add(orderItem1);
        order.getOrderItems().add(orderItem2);

        //Aqui calculamos el precio total de la orden
        BigDecimal orderTotalAmount = order.getTotalAmount();
        order.setTotalPrice(orderTotalAmount);
        order.setTotalQuantity(order.getOrderItems().size());

        orderRepository.save(order);
    }
    @Test
    void saveOrderProducts() {
        Order order= new Order();
        order.setOrderTrackingNumber("A456");
        order.setStatus("Terminado");

        //Item1
        OrderItem orderItem1= new OrderItem();
        orderItem1.setProduct(productRepository.findById(14L).get());
        orderItem1.setImageUrl(orderItem1.getProduct().getUrlImage());
        orderItem1.setQuantity(4);
        orderItem1.setPrice(orderItem1.getProduct().getPrice().multiply(new BigDecimal(orderItem1.getQuantity())));

        //Item2
        OrderItem orderItem2= new OrderItem();
        orderItem2.setProduct(productRepository.findById(34L).get());
        orderItem2.setImageUrl(orderItem2.getProduct().getUrlImage());
        orderItem2.setQuantity(3);
        orderItem2.setPrice(orderItem2.getProduct().getPrice().multiply(new BigDecimal(orderItem2.getQuantity())));

        //Aqui agregamos los productos en la orden
        order.getOrderItems().add(orderItem1);
        order.getOrderItems().add(orderItem2);
        //Aqui calculamos el precio total de la orden
        order.setTotalPrice(order.getTotalAmount());

        //Aqui calculamos el total de productos
        order.setTotalQuantity(order.getTotalProducts());

        //Aqui implementamos la dirrecion
        Address address = new Address();
        address.setCity("Santa Cruz");
        address.setStreet("Manso Perez"); // Corrigiendo esta línea
        address.setState("Activo");
        address.setCountry("Bolivia");
        address.setZipCode("0000");

        order.setBillingAddress(address);

        orderRepository.save(order);
    }
}
