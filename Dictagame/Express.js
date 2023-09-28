/*
const express = require('express');
const app = express();
const port = 3000; // Puerto en el que se ejecutará el servidor

app.use(express.static('public')); // Ruta a la carpeta con tus archivos HTML, CSS y JS

app.get('/', (req, res) => {
  res.sendFile('C:\Users\Alumno\Desktop\hackeo\index.html');
});

app.listen(port, () => {
  console.log(`Servidor web en ejecución en http://localhost:${port}`);
});
*/
const express = require('express');
const path = require('path'); // Importa el módulo 'path' para trabajar con rutas

const app = express();
const port = 3000; // Puerto en el que se ejecutará el servidor

app.use(express.static('public')); // Ruta a la carpeta con tus archivos HTML, CSS y JS

app.get('/', (req, res) => {
  // Utiliza 'path.join' para obtener la ruta absoluta del archivo 'index.html'
  res.sendFile(path.join(__dirname, 'public', 'index.html'));
});

app.listen(port, () => {
  console.log(`Servidor web en ejecución en http://localhost:${port}`);
});

