const readline = require('readline');
const sqlite3 = require('sqlite3').verbose();
//-------------------------------------------------------//

// Crear una interfaz para leer desde la consola
const teclado = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

// Abre la conexión a la base de datos
const db = new sqlite3.Database('mi_base_de_datos.db');

// Pedimos campos por consola: nombre y edad
teclado.question('Ingrese el nombre: ', (nombre) => {
teclado.question('Ingrese la edad: ', (edad) => {

// Sentencia SQL INSERT para insertar el nombre y la edad en la tabla
const sql = 'INSERT INTO usuarios(nombre, edad) VALUES (?, ?)';
    
// Ejecuta la sentencia INSERT con los valores proporcionados
db.run(sql, [nombre, edad], (err) => {
  if (err) {
    return console.error(err.message);
  }
  console.log(`Se ha insertado el registro: Nombre: ${nombre}, Edad: ${edad}`);
      
      // Cierra la conexión con la base de datos
      db.close((err) => {
        if (err) {
          return console.error(err.message);
        }
        //console.log('Conexión cerrada');
        teclado.close(); // Cierra la interfaz de consola
      });
    });
  });
});
