@echo off

:: Configura los colores de la consola (fondo negro y letras azul claro)
color 09

:: Establece el ancho y alto de la ventana
mode con cols=80 lines=25

:: Configura la posición de la ventana
mode con:cols=50 lines=10

echo ----------------------------------------------
     
cd "C:\Users\javir\Desktop"
java "C:\Batch scripts\DiasHastaExamenes\CalculoDiasEntreFechas.java"

echo ----------------------------------------------
echo A estudiar, joder
pause
exit
