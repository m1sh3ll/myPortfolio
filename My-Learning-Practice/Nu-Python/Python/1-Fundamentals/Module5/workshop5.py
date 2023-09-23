import random

def guess_random_number(tries, start, stop):
  rnd = random.randint(start,stop)

  while(tries !=0):
    print("Number of tries left: " + str(tries))

    guess = input("Your guess: ")
    guess = int(guess)
    
    if(guess == rnd):
      print("Success!")
      return
    elif guess < rnd:
      print("Guess higher!")
    elif guess > rnd:
      print("Guess lower!")

    tries -= 1
    if(tries == 0):
      print("Guess higher!")
      print("You have failed to guess the number: " + str(rnd))

guess_random_number(5, 1, 20)