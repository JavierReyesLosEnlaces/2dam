-- BORRADO DE TABLAS

DROP TABLE IF EXISTS pedidos;
DROP TABLE IF EXISTS servicios;
DROP TABLE IF EXISTS coches;
DROP TABLE IF EXISTS talleres;
DROP TABLE IF EXISTS empleados;
DROP TABLE IF EXISTS clientes;
DROP TABLE IF EXISTS usuarios;
DROP TABLE IF EXISTS roles;
DROP TABLE IF EXISTS pedidosRevision;

-- CREACIÓN DE TABLAS

CREATE TABLE roles (
    id_rol INT PRIMARY KEY IDENTITY,
    nombre_rol VARCHAR(15),
    permiso_lectura BIT, 
    permiso_escritura BIT
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
    id_cliente INT PRIMARY KEY IDENTITY,
    cantidad_adeudada DECIMAL(8,2),
    fecha_registro DATE,
    codigo_postal VARCHAR(5),
    id_usuario INT,
    FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario)
);

CREATE TABLE empleados (
    id_empleado INT PRIMARY KEY IDENTITY,
    salario_base DECIMAL(8,2),
    salario_extra DECIMAL(8,2),
    fecha_inicio_contrato DATE,
    id_usuario INT,
    FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario)
);

CREATE TABLE talleres (
    id_taller INT PRIMARY KEY IDENTITY,
    direccion VARCHAR(30),
    especializacion VARCHAR(30)
);

CREATE TABLE coches (
    id_coche INT PRIMARY KEY IDENTITY,
    modelo VARCHAR(20),
    color VARCHAR(20),
    peso DECIMAL(8,2)
);

CREATE TABLE servicios (
    id_servicio INT PRIMARY KEY IDENTITY,
    precio DECIMAL(8,2),
    familia VARCHAR(20),
    descripcion VARCHAR(50),
    id_taller INT,
    FOREIGN KEY(id_taller) REFERENCES talleres(id_taller)
);

CREATE TABLE pedidos(
    id_pedido INT PRIMARY KEY IDENTITY,
    importe_bruto DECIMAL(8,2),
    tipo_impositivo INT,
    importe_neto DECIMAL(8,2),
    fecha DATE,
    id_coche INT,
    id_servicio INT,
    FOREIGN KEY(id_coche) REFERENCES coches(id_coche),
    FOREIGN KEY(id_servicio) REFERENCES servicios(id_servicio)
);

CREATE TABLE pedidosRevision(
    id_pedidoRevision INT PRIMARY KEY IDENTITY,
	aceptado BIT,
	id_pedido INT,
    FOREIGN KEY(id_pedido) REFERENCES pedidos(id_pedido),
);


-- INSERCIONES EN TABLAS

-- Insertando roles
INSERT INTO roles (nombre_rol, permiso_lectura, permiso_escritura) VALUES
('Administrador', 1, 1),
('Cliente', 1, 0);

-- Insertando usuarios
INSERT INTO usuarios (nombre, primer_apellido, segundo_apellido, dni, telefono, correo_electronico, id_rol) VALUES
('Javier', 'Reyes', 'Álvarez', '73016362X', '666666666', 'javi.reyes.losenlaces@gmail.com', 1),
('Bob', 'Bobito', 'Bobo', '45671234R', '888888888', 'bobito@gmail.com', 2);

-- Insertando clientes
INSERT INTO clientes (cantidad_adeudada, fecha_registro, codigo_postal, id_usuario) VALUES
(500.00, '2023-03-25', '28005', 2);

-- Insertando empleados
INSERT INTO empleados (salario_base, salario_extra, fecha_inicio_contrato, id_usuario) VALUES
(2500.00, 300.00, '2022-01-10', 1);

-- Insertando talleres
INSERT INTO talleres (direccion, especializacion) VALUES
('Calle Mayor, 123', 'Mecánica General'),
('Avenida del Parque, 45', 'Chapa y Pintura'),
('Calle Alcalá, 67', 'Electricidad del Automóvil');

-- Insertando coches
INSERT INTO coches (modelo, color, peso) VALUES
('Toyota Corolla', 'Azul', 1200.50),
('Ford Focus', 'Rojo', 1150.25),
('Volkswagen Golf', 'Blanco', 1100.75),
('Honda Civic', 'Negro', 1250.00),
('BMW Serie 3', 'Gris', 1300.50),
('Audi A4', 'Plata', 1275.25),
('Mercedes-Benz', 'Azul Oscuro', 1350.00),
('Renault Megane', 'Verde', 1180.75),
('Hyundai Elantra', 'Plateado', 1225.00),
('Kia Cerato', 'Blanco Perla', 1125.25);

-- Insertando servicios
INSERT INTO servicios (precio, familia, descripcion, id_taller) VALUES
(500.00, 'Mantenimiento', 'Cambio de Aceite y Filtro', 1),
(750.00, 'Reparación', 'Reparación de Frenos', 2),
(620.00, 'Mantenimiento', 'Cambio de Correa de Distribución', 3),
(430.00, 'Reparación', 'Reparación de Suspensión', 1),
(890.00, 'Mantenimiento', 'Revisión Completa', 2),
(720.00, 'Reparación', 'Reparación de Transmisión', 3),
(580.00, 'Mantenimiento', 'Alineación y Balanceo', 1),
(660.00, 'Reparación', 'Reparación de Sistema Eléctrico', 2),
(490.00, 'Mantenimiento', 'Cambio de Batería', 3),
(850.00, 'Reparación', 'Reparación de Sistema de Refrigeración', 1);

-- Insertando pedidos
INSERT INTO pedidos (importe_bruto, tipo_impositivo, importe_neto, fecha, id_coche, id_servicio) VALUES
(500.00, 21, 605.00, '2024-01-10', 1, 1),
(750.00, 21, 907.50, '2024-01-15', 2, 2),
(620.00, 21, 750.20, '2024-01-20', 3, 3),
(430.00, 21, 519.30, '2024-01-25', 4, 4),
(890.00, 21, 1076.90, '2024-02-01', 5, 5),
(720.00, 21, 871.20, '2024-02-05', 6, 6),
(580.00, 21, 701.80, '2024-02-10', 7, 7),
(660.00, 21, 798.60, '2024-02-15', 8, 8),
(490.00, 21, 592.90, '2024-02-20', 9, 9),
(850.00, 21, 1028.50, '2024-02-25', 10, 10);
