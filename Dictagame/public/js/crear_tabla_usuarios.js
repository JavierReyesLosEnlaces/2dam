// Node.js se ejecuta en el lado del servidor
// indexedDB se ejecuta en el lado del cliente (sin conexión, en el navegador: almacenamiento de bases de datos en el lado del cliente en navegadores web.

// Abre o crea una base de datos en IndexedDB
var request = window.indexedDB.open('mi_base_de_datos', 1);

request.onerror = function (event) {
  console.log("Error al abrir la base de datos: " + event.target.errorCode);
};

request.onupgradeneeded = function (event) {
  // Este evento se dispara la primera vez que se abre la base de datos o cuando cambia la versión
  var db = event.target.result;
  var objectStore = db.createObjectStore('usuarios', { keyPath: 'id', autoIncrement: true });

  // Define los campos de la tabla
  objectStore.createIndex('nombre', 'nombre', { unique: false });
  objectStore.createIndex('edad', 'edad', { unique: false });

};

request.onsuccess = function (event) {
  var db = event.target.result;
  // La base de datos está lista para ser utilizada
};

request.onblocked = function (event) {
  console.log("La base de datos está bloqueada debido a otra conexión abierta.");
};

console.log("Tabla USUARIOS creada.");
