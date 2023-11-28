package com.example.repaso1evjavierreyesalvarez

import android.app.Dialog
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.LinearLayout
import android.widget.RadioButton
import android.widget.RadioGroup
import androidx.cardview.widget.CardView

class MainActivity : AppCompatActivity() {

    private lateinit var botonAplicarColor: CardView
    private lateinit var linearLayoutBox: LinearLayout

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        initComponents()
        initListeners()
    }

    private fun initComponents() {
        botonAplicarColor = findViewById(R.id.btn_aplicarColor)
    }
    private fun initListeners() {
        linearLayoutBox.setOnClickListener{ showDialog()}
    }

    private fun showDialog() {
        val dialog = Dialog(this)
        dialog.setContentView(R.layout.dialog)

        val btnAplicarColor: CardView = dialog.findViewById(R.id.btn_aplicarColor)
        val rgColores: RadioGroup = dialog.findViewById(R.id.rgEligeColor)

        btnAplicarColor.setOnClickListener {
            val seleccionIdColores = rgColores.checkedRadioButtonId
            val seleccionRadiobuttonColores: RadioButton = rgColores.findViewById(seleccionIdColores)

            val blanco = R.color.blanco
            val rojo = R.color.rojo
            val naranja = R.color.naranja
            val amarillo = R.color.amarillo
            val verde = R.color.verde
            val cian = R.color.cian
            val azul = R.color.azul
            val violeta = R.color.violeta
            val gris = R.color.gris
            val negro = R.color.negro

            //color actual debe ser el color del linear layout seleccionado
            //por ahora digamos que empieza en el negro
            var colorActual = R.color.negro;

            when (seleccionRadiobuttonColores.text.toString()) {

                "blanco" -> {
                    colorActual = blanco
                }

                "rojo" -> {
                    colorActual = rojo
                }

                "naranja" -> {
                    colorActual = naranja
                }

                "amarillo" -> {
                    colorActual = amarillo
                }

                "verde" -> {
                    colorActual = verde
                }
                "cian" -> {
                    colorActual = cian
                }

                "azul" -> {
                    colorActual = azul
                }

                "violeta" -> {
                    colorActual = violeta
                }

                "gris" -> {
                    colorActual = gris
                }

                "negro" -> {
                    colorActual = negro
                }
            }
            when (seleccionRadiobuttonColores.text.toString()) {
                "BLANCO" -> {
                    linearLayoutBox.setBackgroundColor(getColor(R.color.blanco))
                }

                "ROJO" -> {
                    linearLayoutBox.setBackgroundColor(getColor(R.color.rojo))
                }

                "NARANJA" -> {
                    linearLayoutBox.setBackgroundColor(getColor(R.color.naranja))
                }

                "AMARILLO" -> {
                    linearLayoutBox.setBackgroundColor(getColor(R.color.amarillo))
                }

                "VERDE" -> {
                    linearLayoutBox.setBackgroundColor(getColor(R.color.verde))
                }

                "CIAN" -> {
                    linearLayoutBox.setBackgroundColor(getColor(R.color.cian))
                }

                "AZUL" -> {
                    linearLayoutBox.setBackgroundColor(getColor(R.color.azul))
                }

                "VIOLETA" -> {
                    linearLayoutBox.setBackgroundColor(getColor(R.color.violeta))
                }

                "GRIS" -> {
                    linearLayoutBox.setBackgroundColor(getColor(R.color.gris))
                }

                "NEGRO" -> {
                    linearLayoutBox.setBackgroundColor(getColor(R.color.negro))
                }
            }

        }
    }
}