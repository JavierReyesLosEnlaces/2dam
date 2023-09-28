// Node.js se ejecuta en el lado del servidor
/*
const sqlite3 = require('sqlite3').verbose(); //import sqlite3
const db = new sqlite3.Database('mi_base_de_datos.db');

// Exporta una función
export function crearTablaUsuarios() {
}
*/

//-------------------------------------------------------//
const sqlite3 = require('sqlite3').verbose(); //import sqlite3
const db = new sqlite3.Database('mi_base_de_datos.db');// Ejecuta una consulta SQL para crear una tabla
db.serialize(() => {
  db.run("CREATE TABLE IF NOT EXISTS usuarios (nombre TEXT, edad INT)");
});

console.log("Tabla USUARIOS creada.");
//-------------------------------------------------------//

// Ejecuta una consulta SQL para crear una tabla
db.serialize(() => {
  db.run("CREATE TABLE IF NOT EXISTS usuarios (nombre TEXT, edad INT)");
});

console.log("Tabla USUARIOS creada.");