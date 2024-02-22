package com.sergio.room_database.domain

import com.sergio.room_database.data.QuoteRepository
import com.sergio.room_database.data.model.QuoteModel
import com.sergio.room_database.data.model.QuoteProvider
import com.sergio.room_database.domain.model.Quote
import javax.inject.Inject

class GetRandomQuoteUseCase @Inject constructor(private val repository: QuoteRepository) {

    suspend operator fun invoke(): Quote? {
        val quotes = repository.getAllQuotesFromDatabase()
        if (!quotes.isNullOrEmpty()) {
            val randomNumber = (quotes.indices).random()
            return quotes[randomNumber]
        }
        return null
    }
}


