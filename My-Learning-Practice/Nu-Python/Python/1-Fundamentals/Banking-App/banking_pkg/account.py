def show_balance(balance):
  print("Current Balance: $" + str(balance))

def deposit(balance):
  amount = input("Enter amount to deposit: ")
  return balance + float(amount)

def withdraw(balance):
  amount = input("Enter amount to withdraw: ")
  return balance - float(amount)

def logout(name):
  print("Goodbye "+ name + "!")
