package com.kevin.db_practica2.repository;

import com.kevin.db_practica2.entity.Address;
import com.kevin.db_practica2.entity.Order;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

import java.math.BigDecimal;

@SpringBootTest
public class OneToOneBidirectionalMappingTest {
    @Autowired
    private AddressRepository addressRepository;

    @Test
    void saveAddress() {
        Order order= new Order();
        order.setOrderTrackingNumber("A234");
        order.setTotalQuantity(50);
        order.setStatus("En espera");
        order.setTotalPrice(new BigDecimal(1200));

        Address address = new Address();
        address.setCity("Cochabamba");
        address.setStreet("Laguna");
        address.setStreet("BF 45");
        address.setState("Activo");
        address.setCountry("Bolivia");
        address.setZipCode("0000");

        order.setBillingAddress(address);
        address.setOrder(order);
        addressRepository.save(address);
    }
    @Test
    void updateAddress() {
        Address address =addressRepository.findById(2L).get();
        address.setStreet("ACCD 45");
        address.getOrder().setStatus("Entregado");
        addressRepository.save(address);
    }


}
