// Función para consultar los datos de la tabla usuarios
function consultarUsuarios() {
  var request = window.indexedDB.open('mi_base_de_datos', 1);

  request.onerror = function (event) {
    console.log("Error al abrir la base de datos: " + event.target.errorCode);
  };

  request.onsuccess = function (event) {
    var db = event.target.result;

    // Iniciar una transacción de lectura en la tabla 'usuarios'
    var transaction = db.transaction(['usuarios'], 'readonly');

    // Obtener el almacén de objetos de la transacción
    var objectStore = transaction.objectStore('usuarios');

    // Abrir un cursor para recorrer todos los registros en la tabla
    var usuarios = [];

    objectStore.openCursor().onsuccess = function (event) {
      var cursor = event.target.result;
      if (cursor) {
        // Agregar el registro actual al array de usuarios
        usuarios.push(cursor.value);
        cursor.continue();
      } else {
        // Todos los registros han sido consultados
        console.log("Usuarios en la base de datos:", usuarios);
      }
    };

    // Manejar errores de la transacción
    transaction.onerror = function (event) {
      console.log("Error al consultar usuarios: " + event.target.error);
    };

    // Completar la transacción
    transaction.oncomplete = function () {
      db.close();
    };
  };

  request.onblocked = function (event) {
    console.log("La base de datos está bloqueada debido a otra conexión abierta.");
  };
}

// Ejemplo de uso
consultarUsuarios();
