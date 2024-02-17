package com.kevin.db_practica2.repository;

import com.kevin.db_practica2.entity.Address;
import org.springframework.data.jpa.repository.JpaRepository;

public interface AddressRepository extends JpaRepository<Address, Long> {
}
