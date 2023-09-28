// Función para borrar la tabla usuarios
function borrarTablaUsuarios() {
  var request = window.indexedDB.open('mi_base_de_datos', 1);

  request.onerror = function (event) {
    console.log("Error al abrir la base de datos: " + event.target.errorCode);
  };

  request.onsuccess = function (event) {
    var db = event.target.result;

    // Iniciar una transacción de escritura en la base de datos
    var transaction = db.transaction(['usuarios'], 'readwrite');

    // Obtener el almacén de objetos de la transacción
    var objectStore = transaction.objectStore('usuarios');

    // Borrar la tabla de usuarios
    var deleteRequest = objectStore.clear();

    deleteRequest.onsuccess = function () {
      console.log("Tabla 'usuarios' borrada con éxito.");
    };

    deleteRequest.onerror = function (event) {
      console.log("Error al borrar la tabla 'usuarios': " + event.target.error);
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
borrarTablaUsuarios();
