fun main() {
    //My Covnerter will convert many different values

    val feetToMeters = 3.28

    var feetInMeters = 12 * feetToMeters

    println(feetInMeters)

    val age: String = "" + 42 + "!"
    println(" -------------------------")
    print(true)
    print(!true)
    print(!!true)
    print(!!!true)
    println(" -------------------")
    val finishedHomework = true
    val cleanedRoom = true
    val passedMathExam = false
    val canPlayGames = finishedHomework && cleanedRoom
    val canEatSweets = finishedHomework && passedMathExam
    print(canPlayGames)
    print(canEatSweets)
    println(" -------------------")
    val haveSomeExtraMoney = true
    val tip: Double =
        if (haveSomeExtraMoney) {
            10.0
        } else {
            0.0
        }
    println(tip) // 10.0



    val hour = 11
    val userName = "admin"
    if (hour <= 10) {
        print("Good morning, ")
    } else if (hour >= 20) {
        print("Good evening, ")
    } else {
        print("Hello, ")
    }

    if (userName == "admin") {
        println("what would you like to do?")
    } else {
        println("how can I help you, $userName?")
    }

}