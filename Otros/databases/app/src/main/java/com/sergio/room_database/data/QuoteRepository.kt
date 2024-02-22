package com.sergio.room_database.data

import com.sergio.room_database.data.database.dao.QuoteDao
import com.sergio.room_database.data.database.entities.QuoteEntity
import com.sergio.room_database.data.model.QuoteModel
import com.sergio.room_database.data.model.QuoteProvider
import com.sergio.room_database.data.network.QuoteService
import com.sergio.room_database.domain.model.Quote
import com.sergio.room_database.domain.model.toDomain
import javax.inject.Inject

class QuoteRepository @Inject constructor(
    private val api: QuoteService,
    private val quoteDao: QuoteDao
) {

    //siempre que haya corrutina hay que poner el suspend. cada vez que la app espere una respuesta externa tendremos que hacer una corrutina
    suspend fun getAllQuotesFromApi(): List<Quote> {
        val response: List<QuoteModel> = api.getQuotes()
        return response.map { it.toDomain() }
    }
    suspend fun getAllQuotesFromDatabase(): List<Quote> {
        val response: List<QuoteEntity> = quoteDao.getAllQuotes()
        return response.map { it.toDomain() }

    }
    suspend fun insertQuotes(quotes:List<QuoteEntity>){
        quoteDao.insertAll(quotes)
    }
    suspend fun clearQuotes(){
        quoteDao.deleteAllQuotes()
    }

}


//siempre que haya corrutina hay que poner el suspend. cada vez que la app espere una respuesta externa tendremos que hacer una corrutina