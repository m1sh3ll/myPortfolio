import random

all_scores = []

def dice_game():
    high_score = 0
    while (True):        
        if(len(all_scores)>0):
          high_score = max(all_scores)        
        print("Current High Score:", high_score)        
        print("1) Roll Dice")
        print("2) Leave Game")
        choice=input("Enter your choice: ")
        if(choice != "1"):
          print("Goodbye!")
          break;
        print("")
        roll1 = random.randint(1,6)
        roll2 = random.randint(1,6)
        total = roll1 + roll2       
        print("You roll a... ", roll1)
        print("You roll a... ", roll2)        
        print("")
        print("You rolled a total of:", total)
        print("") 
        if(total > high_score):
          print("New high score!")
          print("")
        all_scores.append(total)

dice_game()
