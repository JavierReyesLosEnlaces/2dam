CREATE TABLE roles (id_rol INT PRIMARY KEY, permiso_lectura BIT, permiso_escritura BIT, permiso_modificacion BIT);
CREATE TABLE usuarios (id_usuario INT PRIMARY KEY, nombre VARCHAR(30), primer_apellido VARCHAR(30), segundo_apellido VARCHAR(30), dni VARCHAR(9), clave_usuario VARCHAR(30), clave_contraseña VARCHAR(30), telefono VARCHAR(12), correo_electronico VARCHAR(30), id_rol INT, FOREIGN KEY (id_rol) REFERENCES roles(id_rol));
CREATE TABLE clientes (id_cliente INT PRIMARY KEY, estado_cuenta VARCHAR(15), fecha_registro VARCHAR(10), codigo_postal VARCHAR(5), id_usuario INT, FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario));
CREATE TABLE empleados (id_empleado INT PRIMARY KEY, salario_base DECIMAL(5,2), salario_extra DECIMAL(5,2), fecha_inicio_contrato VARCHAR(10), id_usuario INT, FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario));
CREATE TABLE talleres (id_taller INT PRIMARY KEY, direccion VARCHAR(30), especializacion VARCHAR(30), encargado INT, FOREIGN KEY(encargado) REFERENCES empleados(id_empleado));
CREATE TABLE coches (id_coche INT PRIMARY KEY, modelo VARCHAR(20), color VARCHAR(20), peso DECIMAL(5,2));
CREATE TABLE servicios (id_servicio INT, precio DECIMAL(5,2), familia VARCHAR(20), descripcion VARCHAR(50), id_coche INT, FOREIGN KEY(id_coche) REFERENCES coches(id_coche));
CREATE TABLE pedidos(id_pedido INT PRIMARY KEY, importe_bruto DECIMAL(5,2), tipo_impositivo INT, importe_neto DECIMAL(5,2), fecha VARCHAR(10));
