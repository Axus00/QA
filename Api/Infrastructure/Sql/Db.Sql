-- Active: 1726540042986@@bcrn01sve84ak1mcbrs1-mysql.services.clever-cloud.com@3306@bcrn01sve84ak1mcbrs1
create table Users(
    Id int not null auto_increment PRIMARY KEY,
    Names varchar(45) not null,
    LastNames varchar(45) not null,
    Email varchar(150) not null
);

INSERT INTO Users (Names, LastNames, Email) VALUES
('Juan', 'Pérez', 'juan.perez@example.com'),
('María', 'González', 'maria.gonzalez@example.com'),
('Carlos', 'Sánchez', 'carlos.sanchez@example.com'),
('Ana', 'Martínez', 'ana.martinez@example.com'),
('Luis', 'Hernández', 'luis.hernandez@example.com'),
('Laura', 'López', 'laura.lopez@example.com'),
('Pedro', 'Ramírez', 'pedro.ramirez@example.com'),
('Sofía', 'Torres', 'sofia.torres@example.com'),
('Diego', 'Flores', 'diego.flores@example.com'),
('Lucía', 'Cruz', 'lucia.cruz@example.com');



select * from Users;