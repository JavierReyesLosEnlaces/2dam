const sqlite3 = require('sqlite3').verbose();
const db = new sqlite3.Database('mi_base_de_datos.db');
//-------------------------------------------------------//

const nombreTabla = 'usuarios';
const sql = `DROP TABLE IF EXISTS ${nombreTabla}`;

// Ejecuta la sentencia DROP TABLE
db.run(sql, [], (err) => {
  if (err) {
    return console.error('err.message');
  }
  console.log(`Tabla "${nombreTabla}" eliminada`);
  
  // Cierra la conexión con la base de datos
  db.close((err) => {
    if (err) {
      return console.error(err.message);
    }
    //console.log('Conexión cerrada');
  });
});
