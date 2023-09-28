const sqlite3 = require('sqlite3').verbose();
const db = new sqlite3.Database('mi_base_de_datos.db');
//-------------------------------------------------------//

// Realiza una consulta SELECT para obtener los campos de la tabla "usuarios"
db.each("SELECT nombre, edad FROM usuarios", (err, row) => {
  if (err) {
    console.error(err.message);
  }
  console.log(`Nombre: ${row.nombre}, Edad: ${row.edad}`);

  // Cierra la conexión con la base de datos cuando hayas terminado
  db.close((err) => {
  if (err) {
    console.error(err.message);
  }
  //console.log('Conexión cerrada');
  });
});


