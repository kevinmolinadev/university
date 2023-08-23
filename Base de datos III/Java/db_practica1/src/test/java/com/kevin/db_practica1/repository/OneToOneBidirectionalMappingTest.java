package com.kevin.db_practica1.repository;

import com.kevin.db_practica1.entity.Adress;
import com.kevin.db_practica1.entity.Order;
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

        Adress adress= new Adress();
        adress.setCity("Cochabamba");
        adress.setStreet("Laguna");
        adress.setStreet("BF 45");
        adress.setState("Activo");
        adress.setCountry("Bolivia");
        adress.setZipCode("0000");

        order.setBillingAddress(adress);
        adress.setOrder(order);
        addressRepository.save(adress);
    }
    @Test
    void updateAddress() {
        Adress adress=addressRepository.findById(2L).get();
        adress.setStreet("ACCD 45");
        adress.getOrder().setStatus("Entregado");
        addressRepository.save(adress);
    }


}
