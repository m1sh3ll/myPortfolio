package com.ftpzero.myapplication

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.TextView
import kotlin.random.Random

class MainActivity : AppCompatActivity() {

    var answer = 0
    var isGameOver:Boolean = false
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        generateAnswer()
    }

    fun generateAnswer() {
        answer = Random.nextInt(1,25)
    }

    fun btnStartOverTapped(){
        isGameOver = false
        generateAnswer()

        val answerTextView = findViewById<TextView>(R.id.answer)
        answerTextView.setText("??")
    }

    fun btnSubmitTapped() {
        isGameOver = true
        val answerTextView = findViewById<TextView>(R.id.answer)
        answerTextView.setText(answer.toString())
    }

}