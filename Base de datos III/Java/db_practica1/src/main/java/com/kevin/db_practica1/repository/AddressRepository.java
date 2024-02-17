package com.kevin.db_practica1.repository;

import com.kevin.db_practica1.entity.Address;
import org.springframework.data.jpa.repository.JpaRepository;

public interface AddressRepository extends JpaRepository<Address, Long> {
}
