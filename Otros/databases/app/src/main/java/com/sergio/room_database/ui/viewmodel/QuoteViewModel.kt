package com.sergio.room_database.ui.viewmodel

import androidx.lifecycle.MutableLiveData
import androidx.lifecycle.ViewModel
import androidx.lifecycle.viewModelScope
import com.sergio.room_database.data.model.QuoteModel
import com.sergio.room_database.data.model.QuoteProvider
import com.sergio.room_database.domain.GetQuotesUseCase
import com.sergio.room_database.domain.GetRandomQuoteUseCase
import com.sergio.room_database.domain.model.Quote
import kotlinx.coroutines.launch
import dagger.hilt.android.lifecycle.HiltViewModel
import javax.inject.Inject

@HiltViewModel

class QuoteViewModel @Inject constructor(private val getQuotesUseCase:GetQuotesUseCase,
                                         private val getRandomQuoteUseCase:GetRandomQuoteUseCase
): ViewModel() {
    val quoteModel = MutableLiveData<Quote>()
    val isLoading = MutableLiveData<Boolean>()




    fun randomQuote() {
        viewModelScope.launch {

        isLoading.postValue(true)
        val quote = getRandomQuoteUseCase()
        if(quote!=null) {

            //con !! aseguras al programa que eso no es nulo
            quoteModel.postValue(quote!!)
        }
        isLoading.postValue(false)
    }
    }


    fun onCreate() {
        isLoading.postValue(true)

        viewModelScope.launch {
            val result = getQuotesUseCase()
            if (!result.isNullOrEmpty()) {
                quoteModel.postValue(result[0])
                isLoading.postValue(false)
            }
        }
    }

}
