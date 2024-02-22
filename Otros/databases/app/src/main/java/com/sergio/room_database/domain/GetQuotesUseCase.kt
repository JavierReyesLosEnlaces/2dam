package com.sergio.room_database.domain

import com.sergio.room_database.data.QuoteRepository
import com.sergio.room_database.data.database.dao.QuoteDao
import com.sergio.room_database.data.database.entities.QuoteEntity
import com.sergio.room_database.data.database.entities.toDatabase
import com.sergio.room_database.data.model.QuoteModel
import com.sergio.room_database.domain.model.Quote
import javax.inject.Inject

class GetQuotesUseCase @Inject constructor(private val repository : QuoteRepository) {

    //suspend es por corrutina
    suspend operator fun invoke():List<Quote>{
        val quotes = repository.getAllQuotesFromApi()

        return if(quotes.isNotEmpty()){
            repository.clearQuotes()
            repository.insertQuotes(quotes.map { it.toDatabase() })
            quotes
        }else{ //Si falla la llamada a la API, se cargan las citas desde la base de datos
            repository.getAllQuotesFromDatabase()
        }
    }




}

