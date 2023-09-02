balance = 0;

def atm_menu(name):
    print("")
    print("          === Automated Teller Machine ===          ")   
    print("User: " + name)
    print("------------------------------------------")
    print("| 1.    Balance     | 2.    Deposit      |")
    print("------------------------------------------")
    print("------------------------------------------")
    print("| 3.    Withdraw    | 4.    Logout       |")
    print("------------------------------------------")
    choice = input("Choose an option: ")
    print("Current Balance: $" + str(balance))

print("          === Automated Teller Machine ===          ")
name = input("Enter name to register: ")
pin = input("Enter PIN: ")
print(name + " has registered with a starting balance of $" + str(balance))

while(True):
  print("")
  print("          === Automated Teller Machine ===          ")
  print("LOGIN")
  if input("Enter name: ") == name and input("Enter PIN: ") == pin:
    atm_menu(name)
    break
  else:
    print("Invalid credentials!")


