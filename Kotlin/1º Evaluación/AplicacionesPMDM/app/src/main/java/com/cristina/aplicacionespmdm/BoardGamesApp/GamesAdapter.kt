package com.cristina.aplicacionespmdm.BoardGamesApp

import android.view.LayoutInflater
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import com.cristina.aplicacionespmdm.R

class GamesAdapter (private val games: List<Game>, private val onItemSelected: (Int) -> Unit): RecyclerView.Adapter<GamesViewHolder>(){

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): GamesViewHolder {
       val view =  LayoutInflater.from(parent.context).inflate(R.layout.item_game, parent,false)
        return GamesViewHolder(view)
    }
    override fun onBindViewHolder(holder: GamesViewHolder, position: Int) {
        holder.render(games[position]) //en vez de position podríamos poner "it"
    }

    override fun getItemCount(): Int = games.size

}
