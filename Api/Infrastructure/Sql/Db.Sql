-- Active: 1726540042986@@bcrn01sve84ak1mcbrs1-mysql.services.clever-cloud.com@3306@bcrn01sve84ak1mcbrs1
create table Users(
    Id int not null auto_increment PRIMARY KEY,
    FullName varchar(100) not null,
    Email varchar(150) not null
);

INSERT INTO Users (FullName, Email) VALUES ("Fernando José Gómez Toro", "fer.gomez.dev@gmail.com");
INSERT INTO Users (FullName, Email) VALUES 
("Laura Marcela Rodríguez Pérez", "laura.rodriguez@correo.com"),
("Carlos Andrés Mejía Gutiérrez", "carlos.mejia@correo.com"),
("María Fernanda Álvarez López", "maria.alvarez@correo.com"),
("Jorge Luis Ramírez Ospina", "jorge.ramirez@correo.com"),
("Ana Sofía Martínez Ríos", "ana.martinez@correo.com");

select * from Users;