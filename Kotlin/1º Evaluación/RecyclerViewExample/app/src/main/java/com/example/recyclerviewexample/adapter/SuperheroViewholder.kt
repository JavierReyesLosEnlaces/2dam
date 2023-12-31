package com.example.recyclerviewexample.adapter

import android.view.View
import android.widget.ImageView
import android.widget.TextView
import androidx.recyclerview.widget.RecyclerView
import com.bumptech.glide.Glide
import com.example.recyclerviewexample.R
import com.example.recyclerviewexample.Superhero

class SuperheroViewholder(view: View): RecyclerView.ViewHolder(view) {

    val superHero = view.findViewById<TextView>(R.id.tvSuperheroName);
    val realName = view.findViewById<TextView>(R.id.tvRealName);
    val publisher = view.findViewById<TextView>(R.id.tvPublisher)
    val photo = view.findViewById<ImageView>(R.id.ivSuperhero)

    fun render(superHeroModel: Superhero){
        superHero.text = superHeroModel.superhero
        realName.text = superHeroModel.realName
        publisher.text = superHeroModel.publisher
        Glide.with(photo.context).load(superHeroModel.photo).into(photo)
    }
}