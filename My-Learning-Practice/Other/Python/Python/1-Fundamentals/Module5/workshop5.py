import random

def guess_random_number(tries, start, stop):
  rnd = random.randint(start,stop)

  while(tries !=0):
    print("Number of tries left:",tries)

    guess = input("Guess a number between: " + str(start) + " and " + str(stop) + ": ")
    guess = int(guess)
    
    if(guess == rnd):
      print("You guessed the correct number!")
      return
    elif guess < rnd:
      print("Guess higher!")
    elif guess > rnd:
      print("Guess lower!")

    tries -= 1
    if(tries == 0):
      print("Guess higher!")
      print("You have failed to guess the number:", rnd)


def guess_random_num_linear(tries, start, stop):
  rnd = random.randint(start,stop)

  print("The number for the program to guess is:", rnd)

  for num in range(start, stop + 1):
    print("Number of tries left:", tries)
    print("The program is guessing...", num)
    if num == rnd:
      print("The program has guessed the correct number!")
      return num 
    tries -= 1
    if tries == 0:
      return

def guess_random_num_binary(tries, start, stop):
    rnd = random.randint(start,stop)
    
    print("The number for the program to guess is:", rnd)

    while start <= stop:
        pivot = (start + stop) // 2
        pivot_value = pivot
        if pivot_value == rnd:
            print("Found it!", rnd)
            return pivot
        if pivot_value > rnd:
            print("Guessing higher!")
            stop = pivot - 1
        else:
            print("Guessing lower!")
            start = pivot + 1
        tries -=1
        if tries == 0:  
          print("Your program failed to find the number")        
          return     

# guess_random_number(5, 1, 20)
# guess_random_num_linear(15, 1, 20)
guess_random_num_binary(5, 0, 100)