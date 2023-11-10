package com.example.recyclerviewexample.adapter

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.example.recyclerviewexample.R
import com.example.recyclerviewexample.Superhero

class SuperheroAdapter(private  val superheroList: List<Superhero>) : RecyclerView.Adapter<SuperheroViewholder>() {
    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): SuperheroViewholder {
        //devuelve el item al viewholder por cada item de superheroes
        val layoutInflater = LayoutInflater.from(parent.context)
        return SuperheroViewholder(layoutInflater.inflate(R.layout.item_superhero, parent, false))
    }

    override fun getItemCount(): Int {
        return superheroList.size
    }

    override fun onBindViewHolder(holder: SuperheroViewholder, position: Int) {
        val item = superheroList[position]
        holder.render(item)
    }
}