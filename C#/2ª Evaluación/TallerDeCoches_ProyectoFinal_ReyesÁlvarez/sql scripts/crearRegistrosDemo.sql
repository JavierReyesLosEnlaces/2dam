-- BORRADO DE TABLAS

DROP TABLE IF EXISTS pedidos;
DROP TABLE IF EXISTS servicios;
DROP TABLE IF EXISTS coches;
DROP TABLE IF EXISTS talleres;
DROP TABLE IF EXISTS empleados;
DROP TABLE IF EXISTS clientes;
DROP TABLE IF EXISTS usuarios;
DROP TABLE IF EXISTS roles;

-- CREACIÓN DE TABLAS

CREATE TABLE roles (
    id_rol INT PRIMARY KEY,
	nombre_rol VARCHAR(15),
    permiso_lectura BIT, 
    permiso_escritura BIT,
);

CREATE TABLE usuarios (
    id_usuario INT PRIMARY KEY IDENTITY,
    nombre VARCHAR(30),
    primer_apellido VARCHAR(30),
    segundo_apellido VARCHAR(30),
    dni VARCHAR(9),
    telefono VARCHAR(12),
    correo_electronico VARCHAR(50),
    id_rol INT,
    FOREIGN KEY (id_rol) REFERENCES roles(id_rol)
);

CREATE TABLE clientes (
    id_cliente INT PRIMARY KEY,
	cantidad_adeudada DECIMAL(8,2),
    fecha_registro DATE,
    codigo_postal VARCHAR(5),
    id_usuario INT,
    FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario)
);

CREATE TABLE empleados (
    id_empleado INT PRIMARY KEY,
    salario_base DECIMAL(8,2),
    salario_extra DECIMAL(8,2),
    fecha_inicio_contrato DATE,
    id_usuario INT,
    FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario)
);

CREATE TABLE talleres (
    id_taller INT PRIMARY KEY,
    direccion VARCHAR(30),
    especializacion VARCHAR(30),
);

CREATE TABLE coches (
    id_coche INT PRIMARY KEY,
    modelo VARCHAR(20),
    color VARCHAR(20),
    peso DECIMAL(8,2)
);

CREATE TABLE servicios (
    id_servicio INT PRIMARY KEY,
    precio DECIMAL(8,2),
    familia VARCHAR(20),
    descripcion VARCHAR(50),
    id_coche INT,
    FOREIGN KEY(id_coche) REFERENCES coches(id_coche)
);

CREATE TABLE pedidos(
    id_pedido INT PRIMARY KEY,
    importe_bruto DECIMAL(8,2),
    tipo_impositivo INT,
    importe_neto DECIMAL(8,2),
    fecha DATE
);

-- INSERCIONES EN TABLAS

INSERT INTO roles (id_rol, nombre_rol, permiso_lectura, permiso_escritura) VALUES
(1, 'Administrador', 1, 1),
(2, 'Cliente', 1, 0);

SET IDENTITY_INSERT usuarios ON;

INSERT INTO usuarios (id_usuario, nombre, primer_apellido, segundo_apellido, dni, telefono, correo_electronico, id_rol) VALUES
(1, 'Javier', 'Reyes', 'Álvarez', '73016362X', '666666666', 'javi.reyes.losenlaces@gmail.com', 1),
(2, 'Bob', 'Bobito', 'Bobo', '45671234R', '888888888', 'bobito@gmail.com', 2)

INSERT INTO clientes (id_cliente, cantidad_adeudada, fecha_registro, codigo_postal, id_usuario) VALUES
(1, 500.00, '2023-03-25', '28005', 2);

INSERT INTO empleados (id_empleado, salario_base, salario_extra, fecha_inicio_contrato, id_usuario) VALUES
(1, 2500.00, 300.00, '2022-01-10', 1);

INSERT INTO talleres (id_taller, direccion, especializacion) VALUES
(1, 'Calle Mayor, 123', 'Mecánica General'),
(2, 'Avenida del Parque, 45', 'Chapa y Pintura'),
(3, 'Calle Alcalá, 67', 'Electricidad del Automóvil');

INSERT INTO coches (id_coche, modelo, color, peso) VALUES
(1, 'Toyota Corolla', 'Azul', 1200.50),
(2, 'Ford Focus', 'Rojo', 1150.25),
(3, 'Volkswagen Golf', 'Blanco', 1100.75),
(4, 'Honda Civic', 'Negro', 1250.00),
(5, 'BMW Serie 3', 'Gris', 1300.50),
(6, 'Audi A4', 'Plata', 1275.25),
(7, 'Mercedes-Benz', 'Azul Oscuro', 1350.00),
(8, 'Renault Megane', 'Verde', 1180.75),
(9, 'Hyundai Elantra', 'Plateado', 1225.00),
(10, 'Kia Cerato', 'Blanco Perla', 1125.25);

INSERT INTO servicios (id_servicio, precio, familia, descripcion, id_coche) VALUES
(1, 150.00, 'Mantenimiento', 'Cambio de Aceite y Filtro', 1),
(2, 200.00, 'Reparación', 'Reparación de Frenos', 2),
(3, 250.00, 'Mantenimiento', 'Cambio de Correa de Distribución', 3),
(4, 180.00, 'Reparación', 'Reparación de Suspensión', 4),
(5, 300.00, 'Mantenimiento', 'Revisión Completa', 5),
(6, 220.00, 'Reparación', 'Reparación de Transmisión', 6),
(7, 270.00, 'Mantenimiento', 'Alineación y Balanceo', 7),
(8, 190.00, 'Reparación', 'Reparación de Sistema Eléctrico', 8),
(9, 280.00, 'Mantenimiento', 'Cambio de Batería', 9),
(10, 240.00, 'Reparación', 'Reparación de Sistema de Refrigeración', 10);

INSERT INTO pedidos (id_pedido, importe_bruto, tipo_impositivo, importe_neto, fecha) VALUES
(1, 500.00, 21, 605.00, '2024-01-10'),
(2, 750.00, 21, 907.50, '2024-01-15'),
(3, 620.00, 21, 750.20, '2024-01-20'),
(4, 430.00, 21, 519.30, '2024-01-25'),
(5, 890.00, 21, 1076.90, '2024-02-01'),
(6, 720.00, 21, 871.20, '2024-02-05'),
(7, 580.00, 21, 701.80, '2024-02-10'),
(8, 660.00, 21, 798.60, '2024-02-15'),
(9, 490.00, 21, 592.90, '2024-02-20'),
(10, 850.00, 21, 1028.50, '2024-02-25');

