package com.kevin.db_practica2.repository;

import com.kevin.db_practica2.entity.Address;
import com.kevin.db_practica2.entity.Order;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

import java.math.BigDecimal;

@SpringBootTest
public class OneToOneUniderectionalMappingTest {
    @Autowired
    private OrderRepository orderRepository;

    @Test
    void saveOrder(){
        Order order= new Order();
        order.setOrderTrackingNumber("A123");
        order.setTotalQuantity(10);
        order.setStatus("En proceso");
        order.setTotalPrice(new BigDecimal(1000));

        Address address = new Address();
        address.setCity("Santa Cruz");
        address.setStreet("Manso Perez");
        address.setStreet("Si?");
        address.setState("Activo");
        address.setCountry("Bolivia");
        address.setZipCode("0000");

        order.setBillingAddress(address);
        orderRepository.save(order);

    }

    @Test
    void readOrder(){
        Order order=orderRepository.findById(1L).get();
        System.out.println(order.toString());
    }
    @Test
    void updateOrder(){
        Order order = orderRepository.findById(1L).get();
        order.setTotalPrice(new BigDecimal(1500));
        order.getBillingAddress().setStreet("Calle 41");
        orderRepository.save(order);
    }

    @Test
    void deleteOrder(){
        orderRepository.deleteById(1L);
    }
}
