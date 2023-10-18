""" 
### Below are the variables for the game

"""
wizard = "Wizard"
elf = "Elf"
human = "Human"

wizard_hp = 70
elf_hp = 100
human_hp = 150
dragon_hp = 300

wizard_damage = 150
elf_damage = 100
human_damage = 20
dragon_damage = 50

# Main menu

while (True):
    print("Welcome to the Game")
    print("1) Wizard")
    print("2) Elf")
    print("3) Human")

    character = input("Choose Your Character: ")
    if character == "1":
        character = wizard
        my_hp = wizard_hp
        my_damage = wizard_damage
        break
    elif character == "2":
        character = elf
        my_hp = elf_hp
        my_damage = elf_damage
        break
    elif character == "3":
        character = human
        my_hp = human_hp
        my_damage = human_damage
        break
    else:
        print("Unknown character")
        break

print("You have chosen the character: " + character)
print("Health:", my_hp)
print("Damage:", my_damage)
print("")

# battle

while (True):
    dragon_hp = dragon_hp - my_damage
    if dragon_hp <= 0:
        print("The", character, "damaged the Dragon!")
        print("The Dragon's hitpoints are now: 0")
        print("")
        print("The Dragon has lost the battle.")
        break

    print("The", character, "damaged the Dragon!")
    print("The Dragon's hitpoints are now:", dragon_hp)
    print("")

    my_hp = my_hp - dragon_damage
    if my_hp <= 0:
        print("The Dragon strikes back at the", character)
        print("The", character, "hitpoints are now: 0")
        print("")
        print("The", character, "has lost the battle.")
        break

    print("The Dragon strikes back at the", character)
    print("The", character, "hitpoints are now:", my_hp)
    print("")
