package com.sergio.room_database

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import androidx.activity.viewModels
import androidx.core.view.isVisible
import androidx.lifecycle.Observer
import com.sergio.room_database.databinding.ActivityMainBinding
import com.sergio.room_database.ui.viewmodel.QuoteViewModel
import dagger.hilt.android.AndroidEntryPoint

@AndroidEntryPoint

class MainActivity : AppCompatActivity() {

    private lateinit var binding: ActivityMainBinding

    private val quoteViewModel: QuoteViewModel by viewModels()

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        quoteViewModel.onCreate()

        quoteViewModel.quoteModel.observe(this, Observer {currentQuote ->
            //Podemos poner nombre a it justo después de "{", por ejemplo, "currentQuote ->"
            binding.tvQuote.text = currentQuote.quote
            binding.tvAuthor.text = currentQuote.author
        })
        quoteViewModel.isLoading.observe(this, Observer {
            binding.loading.isVisible = it
        })

        binding.viewContainer.setOnClickListener { quoteViewModel.randomQuote() }


    }
}