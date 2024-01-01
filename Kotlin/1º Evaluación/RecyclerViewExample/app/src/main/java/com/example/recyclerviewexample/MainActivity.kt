package com.example.recyclerviewexample

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.example.recyclerviewexample.adapter.SuperheroAdapter

class MainActivity : AppCompatActivity() {

    //necesitamos una lista de data classes
    //val sm = Superhero("superman", "dc", "clark kent", "https://phantom-elmundo.unidadeditorial.es/ceb5ddfd91bd7ea95edd24ad7a228ce7/resize/1200/f/jpg/assets/multimedia/imagenes/2022/08/03/16595421832009.jpg")

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        SuperheroProvider.superHeroList
        initRecyclerView()
    }

    private fun initRecyclerView(){
        val recyclerView = findViewById<RecyclerView>(R.id.recyclerSuperhero)
        recyclerView.layoutManager = LinearLayoutManager(this )
        recyclerView.adapter = SuperheroAdapter(SuperheroProvider.superHeroList);
    }
}