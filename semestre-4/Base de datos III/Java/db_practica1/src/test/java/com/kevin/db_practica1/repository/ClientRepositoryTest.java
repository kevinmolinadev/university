package com.kevin.db_practica1.repository;

import com.kevin.db_practica1.entity.Client;
import org.junit.jupiter.api.Test;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.test.context.SpringBootTest;

import java.util.List;

import static org.junit.jupiter.api.Assertions.*;
@SpringBootTest
class ClientRepositoryTest {

    @Autowired
    private ClientRepository clientRepository;

    @Test
    void saveClient() {
        Client client = new Client();
        client.setName("Juan");
        client.setLastName("Perez");

        Client savedClient = clientRepository.save(client);
        System.out.println(savedClient.getId());
        System.out.println(savedClient.toString());
    }

    @Test
    void updateClient() {
        Long id = 1L;
        Client client = clientRepository.findById(id).get();
        client.setLastName("Gomez");
        clientRepository.save(client);
    }

    @Test
    void findAllClients() {
        List<Client> clients = clientRepository.findAll();
        clients.forEach(client -> {
            System.out.println(client.getId()+" -> "+client.getName());
        });
    }

    @Test
    void deleteClientById() {
        long id  = 2L;
        clientRepository.deleteById(id);
    }

    @Test
    void deleteClient() {
        // encontrar el registro a eliminar
        long id = 3L;
        Client client = clientRepository.findById(id).get();
        //Eliminar
        clientRepository.delete(client);

    }

    @Test
    void deleteAllClient() {
        //Eliminar todos los registros
        //clientRepository.deleteAll();

        //Eliminar registros especificos
        Client client1 = clientRepository.findById(2L).get();
        Client client2 = clientRepository.findById(3L).get();

        clientRepository.deleteAll(List.of(client1,client2));
    }
}