import random

# class to keep track of the user, rounds chosen


class Game:
    def __init__(self, name, rounds):
        self.name = name
        self.rounds = rounds

# subclass to keep track of the user and computer score, ties


class GameScore(Game):
    def __init__(self, name, rounds):
        super().__init__(name, rounds)
        self.userwins = 0
        self.computerwins = 0
        self.ties = 0
    # display the score

    def show_score(self):
        print(self.name + ":" + str(self.userwins) +
              "- Computer:" + str(self.computerwins))

    # increase the user score
    def user_scores(self):
        self.userwins += 1
        print(self.name + " Wins!")
    # increase the computer score

    def computer_scores(self):
        self.computerwins += 1
        print("Computer Wins!")
    # increase the ties

    def tie_game(self):
        self.ties += 1


# game play starts here
def play_game():
    current_round = 0

    name = input("Please enter your name: ")

    while (True):
        total_rounds = input(
            "Enter number of rounds to play (between 1 to 10): ")
        total_rounds = int(total_rounds)
        if total_rounds <= 10 and total_rounds > 0:
            game = GameScore(name, total_rounds)
            break
        else:
            print("Invalid input! Please enter 1 to 10")

    while (True):
        if current_round < total_rounds:
            # show the round and prompt the user to enter choice
            print("Round #:" + str(current_round + 1))
            users_choice = input(game.name + ", Enter 1 [Rock], 2 [Paper], 3 [Scissors]: ")
            users_choice = int(users_choice)
            # display the result of the users choice
            if users_choice == 1:
                print("You chose Rock")
            elif users_choice == 2:
                print("You chose Paper")
            elif users_choice == 3:
                print("You chose Scissors")
            # computer's choice is chosen at random
            computers_choice = random.randint(1, 3)
            print("Computers choice", computers_choice)
            # display the result of the computers choice
            if computers_choice == 1:
                print("Computer chose Rock")
            elif computers_choice == 2:
                print("Computer chose Paper")
            elif computers_choice == 3:
                print("Computer chose Scissors")
            # score the game
            if users_choice == computers_choice:
                # tie the game
                game.tie_game()
            else:
                # display the explanation for the user - User scores
                if users_choice == 1 and computers_choice == 3:
                    print("Rock Crushes Scissors")
                    game.user_scores()
                elif users_choice == 2 and computers_choice == 1:
                    print("Paper wraps Rock")
                    game.user_scores()
                elif users_choice == 3 and computers_choice == 2:
                    print("Scissors Cuts Paper")
                    game.user_scores()
                #display the computer eplanation - Computer Scores
                elif computers_choice == 1 and users_choice == 3:
                    print("Rock Crushes Scissors")
                    game.computer_scores()
                elif computers_choice == 2 and users_choice == 1:
                    print("Paper wraps Rock")
                    game.computer_scores()
                elif computers_choice == 3 and users_choice == 2:
                    print("Scissors Cuts Paper")
                    game.computer_scores()
            current_round += 1
        else:
            break
    # end while

    if game.userwins == game.computerwins:
        print("Overall Score: Tie")
    else:
        if game.userwins > game.computerwins:
            print("Overall Score: User Wins!")
        else:
            print("Overall Score: Computer Wins!")
            print("User wins:", game.userwins, " - Computer wins:",
                  game.computerwins,  " - Ties: ", game.ties)


play_game()
