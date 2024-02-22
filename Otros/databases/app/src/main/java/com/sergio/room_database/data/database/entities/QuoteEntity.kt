package com.sergio.room_database.data.database.entities

import androidx.room.ColumnInfo
import androidx.room.Entity
import androidx.room.PrimaryKey
import com.sergio.room_database.domain.model.Quote

@Entity(tableName = "quote_table")
data class QuoteEntity(
    @PrimaryKey(autoGenerate = true)
    @ColumnInfo(name = "id") val id: Int = 0,
    @ColumnInfo(name = "quote") val quote: String,
    @ColumnInfo(name = "author") val author: String
)
// Hay que especificarle los campos porque también existe el campo "id"
fun Quote.toDatabase() = QuoteEntity(quote = quote, author =  author)
