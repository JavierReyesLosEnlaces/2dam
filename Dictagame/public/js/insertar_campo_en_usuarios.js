// Función para abrir la base de datos y realizar la inserción
function insertarUsuario(nombre, edad) {
  var request = window.indexedDB.open('mi_base_de_datos', 1);

  request.onerror = function (event) {
    console.log("Error al abrir la base de datos: " + event.target.errorCode);
  };

  request.onsuccess = function (event) {
    var db = event.target.result;

    // Iniciar una transacción de escritura en la tabla 'usuarios'
    var transaction = db.transaction(['usuarios'], 'readwrite');

    // Obtener el almacén de objetos de la transacción
    var objectStore = transaction.objectStore('usuarios');

    // Crear un objeto que represente el nuevo usuario
    var nuevoUsuario = {
      nombre: nombre,
      edad: edad
    };

    // Agregar el nuevo usuario al almacén de objetos
    var agregarRequest = objectStore.add(nuevoUsuario);

    agregarRequest.onsuccess = function () {
      console.log("Usuario insertado con éxito.");
    };

    agregarRequest.onerror = function () {
      console.log("Error al insertar usuario: " + agregarRequest.error);
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
insertarUsuario("Javier Reyes", 28);
