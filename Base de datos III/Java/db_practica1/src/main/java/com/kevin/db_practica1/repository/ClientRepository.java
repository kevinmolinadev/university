package com.kevin.db_practica1.repository;

import com.kevin.db_practica1.entity.Client;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ClientRepository extends JpaRepository<Client, Long> {

}
