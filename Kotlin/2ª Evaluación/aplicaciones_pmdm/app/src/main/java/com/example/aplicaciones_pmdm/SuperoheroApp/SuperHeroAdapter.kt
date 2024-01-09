package com.example.aplicaciones_pmdm.SuperoheroApp

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.example.aplicaciones_pmdm.R

class SuperheroAdapter( var superheroList: List<SuperheroItemResponse> = emptyList()) : RecyclerView.Adapter<SuperheroViewHolder>() {
    fun updateList(list: List<SuperheroItemResponse>) {
        superheroList = list
        notifyDataSetChanged() //notifica al adapter que los datos han cambiado
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): SuperheroViewHolder {
        return SuperheroViewHolder(
            LayoutInflater.from(parent.context).inflate(R.layout.item_superhero, parent, false)
        )
    }
    override fun onBindViewHolder(holder: SuperheroViewHolder, position: Int) {
        holder.bind(superheroList[position])
    }
    override fun getItemCount() = superheroList.size
}
