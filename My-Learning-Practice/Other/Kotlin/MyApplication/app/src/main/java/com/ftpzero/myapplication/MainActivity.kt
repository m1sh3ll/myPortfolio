package com.ftpzero.myapplication

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.widget.TextView
import android.widget.Button
import android.view.View
import android.widget.EditText
import java.lang.Exception
import kotlin.random.Random

class MainActivity : AppCompatActivity() {

    var answer = 0
    var numOfAttempts = 0
    var isGameOver:Boolean = false
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        generateAnswer()
    }

    fun generateAnswer() {
        answer = Random.nextInt(1,25)
    }

    fun startOver(){
        isGameOver = false
        generateAnswer()
        numOfAttempts = 0
        val textView = findViewById<TextView>(R.id.textView)
        textView.text = "Guess 1 to 25"

        val answerTextView = findViewById<TextView>(R.id.answer)
        answerTextView.setText("??")

    }

    fun btnStartOverTapped(view: View){
       startOver()
    }

    fun btnSubmitTapped(view: View) {
        val guess = getUsersGuess() ?: -999
        val textView = findViewById<TextView>(R.id.textView)
        if (guess !in 1..25){
            textView.text = "Guess must be 1 to 25"
            return
        }

        var message = ""
        numOfAttempts++

        if(guess == answer) {
            message = "Correct! Answer $answer - Guesses: $numOfAttempts"
            isGameOver = true
            val answerTextView = findViewById<TextView>(R.id.answer)
            answerTextView.setText(message)

            val submitButton = findViewById<Button>(R.id.buttonSubmit)
            submitButton.isEnabled = false
        }
        else {
            message = if (guess < answer) "Too low!" else "Too high!"

            val answerTextView = findViewById<TextView>(R.id.answer)
            answerTextView.setText(message)

        }


    }

    fun getUsersGuess() : Int? {
        val editTextGuess= findViewById<EditText>(R.id.editTextGuess)
        val usersGuess = editTextGuess.text.toString()
        var guessAsInt = 0

        try {
            guessAsInt = usersGuess.toInt()
        } catch (e: Exception) {
            return null
        }

        return guessAsInt

    }

}