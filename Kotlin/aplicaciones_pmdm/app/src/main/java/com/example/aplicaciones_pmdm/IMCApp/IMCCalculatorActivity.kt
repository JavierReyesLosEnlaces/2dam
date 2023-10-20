package com.example.aplicaciones_pmdm.IMCApp

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.util.Log
import android.widget.Button
import android.widget.TextView
import androidx.cardview.widget.CardView
import com.example.aplicaciones_pmdm.HelloApp.SecondActivity
import com.example.aplicaciones_pmdm.MenuActivity
import com.example.aplicaciones_pmdm.R
import com.google.android.material.slider.RangeSlider
import java.lang.Math.pow
import java.text.DecimalFormat

class IMCCalculatorActivity : AppCompatActivity() {

    private var isMaleSelected: Boolean = false
    private var isFemaleSelected: Boolean = false
    private var currentWeight: Int = 70
    private var currentAge: Int = 40
    private var currentHeight: Int = 120


    //leclaramos estas variables fuera del onCreate para que sean globales
    //globales -> accesibles desde cualquier parte de IMCCalculatorActivity

    private lateinit var  viewMale: CardView
    private lateinit var  viewFemale: CardView

    private lateinit var tvHeight: TextView
    private lateinit var rsHeight: RangeSlider

    private lateinit var tvWeight: TextView
    private lateinit var btnAddWeight: CardView
    private lateinit var btnSubstractWeight: CardView

    private lateinit var tvAge: TextView
    private lateinit var btnAddAge: CardView
    private lateinit var btnSubstractAge: CardView

    private lateinit var btnCalcular: Button

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_imccalculator)

        initComponents()
        initListeners()
        setWeight()
        setAge()
    }

    private fun initListeners() {
        //para poner varias líneas de código metemos llaves, no paréntesis

        viewMale.setOnClickListener{
            setComponentColorMale()
        }

        viewFemale.setOnClickListener{
            setComponentColorFemale()
        }
        rsHeight.addOnChangeListener { _, value, _ ->
            val df = DecimalFormat("#")
            currentHeight = df.format(value).toInt()
            tvHeight.text = "$currentHeight cm"
        }

    // BOTONES DE PESO
        btnSubstractWeight.setOnClickListener {
            currentWeight -= 1
            setWeight()
        }
        btnAddWeight.setOnClickListener {
            currentWeight += 1
            setWeight()
        }

    // BOTONES DE EDAD
        btnSubstractAge.setOnClickListener {
            currentAge -= 1
            setAge()
        }
        btnAddAge.setOnClickListener {
            currentAge += 1
            Log.i("edad","done")
            setAge()
        }


        //BOTÓN DE CÁLCULO
        btnCalcular.setOnClickListener {
            val result = calculateIMC()
            Log.i("IMC", "$result")
            navigateToResult(result)
        }
    }

    private fun navigateToResult(result: Double){
        val intent = Intent(this, ResultActivity::class.java)
        intent.putExtra("extra_name", result)
        startActivity(intent)
    }

    private fun setComponentColorMale() {
        //esta función comprueba si el cardview del nombre está seleccionado
        if (!isMaleSelected){
            viewMale.setCardBackgroundColor(getColor(R.color.background_component))
            viewFemale.setCardBackgroundColor(getColor(R.color.background_component_selected))
            isMaleSelected = true
            isFemaleSelected = false
        }
    }

    private fun setComponentColorFemale() {
        //esta función comprueba si el cardview del nombre está seleccionado
        if (!isFemaleSelected){
            viewFemale.setCardBackgroundColor(getColor(R.color.background_component))
            viewMale.setCardBackgroundColor(getColor(R.color.background_component_selected))
            isFemaleSelected = true
            isMaleSelected = false
        }
    }

    //las funciones fuera del onCreate para que esta actividad sea global
    //pero SOLO en esta actividad

    private fun initComponents(){
        viewMale = findViewById(R.id.viewMale)
        viewFemale = findViewById(R.id.viewFemale)

        // HEIGHT
        tvHeight = findViewById(R.id.tvHeight)
        rsHeight = findViewById(R.id.rsHeight)

        // WEIGHT
        tvWeight = findViewById(R.id.tvWeight)
        btnAddWeight = findViewById(R.id.btnAddWeight)
        btnSubstractWeight = findViewById(R.id.btnSubstractWeight)

        // AGE
        tvAge = findViewById(R.id.tvAge)
        btnAddAge = findViewById(R.id.btnAddAge)
        btnSubstractAge = findViewById(R.id.btnSubstractAge)

        //BOTÓN DE CÁLCULO DEL IMC
        btnCalcular = findViewById(R.id.btnCalcular)
    }

    private fun setWeight() {
        tvWeight.text = currentWeight.toString()
    }

    private fun setAge() {
        tvAge.text = currentAge.toString()
    }


    private fun calculateIMC():Double {
        val df = DecimalFormat("#.##")
        val imc = currentWeight / pow(currentHeight.toDouble()/100, 2.0)

        return df.format(imc).toDouble()
    }

}