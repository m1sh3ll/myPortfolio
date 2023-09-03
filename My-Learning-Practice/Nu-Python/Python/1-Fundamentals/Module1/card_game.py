import random

diamonds = ["AD", "2D", "3D", "4D", "5D", "6D", "7D", "8D", "9D", "10D", "JD", "QD", "KD"]

hand = []

while (True):
    if len(diamonds) < 1:
        break
    
    option = input("Press enter to pick a card, or Q then enter to quit: ")

    if option == "q":
        break
    elif option:
        print("Invalid input. Try again!")
        continue
    
    random_int = random.randint(0, len(diamonds) - 1)

    hand.append(diamonds.pop(random_int))

    print("Remaining Cards " + str(diamonds))

    print("Your Hand " + str(hand))

if not diamonds:
    
    print("There are no more cards to pick")
