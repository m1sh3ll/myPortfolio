class User:
    def __init__(self, name, pin, password):
        self.name = name
        self.pin = pin
        self.password = password

    def change_name(self, name):
        self.name = name
        print("Your name has been changed to", self.name)

    def change_pin(self, pin):
        self.pin = pin
        print("Your PIN has been changed.")

    def change_password(self, password):
        self.password = password
        print("Your password has been changed to", self.password)

class BankUser(User):
    def __init__(self, name, pin, password):
        super().__init__(name, pin, password)
        self.balance = 0

    def show_balance(self):
        print("Name: "+ self.name + " Balance " + str(self.balance))

    def withdraw(self, amount):        
        self.balance -= amount
        # print(self.name, "withdraws", amount)        
    def deposit(self, amount):
        self.balance += amount
        # print(self.name, "deposits", amount) 
    def transfer_money(self, amount, user):
        print("You are transferring $" + str(amount) + " to " + user)
        print("Authentication required") 
        pin = input("Enter your PIN "+ self.name + ": ")    
        if self.pin == pin:
            print("Transfer authorized")  
            print("Transferring $" + str(amount) + " to " + user)        
            self.balance -= amount
            return True
        return False
    def request_money(self, amount):        
        password = input("Please enter password for " + self.name+": ")
        if self.password == password:               
            self.balance += amount
            return True
        return False


# """ Driver Code for Task 1 """
# user1 = User("michelle", "1234", "bestpassword")
# print("Name: "+ user1.name + " PIN: " + user1.pin + " Password: " + user1.password)


# """ Driver Code for Task 2 """
# user2 = User("michelle", "1235", "best2password")
# print("Name: "+ user2.name + " PIN: " + user2.pin + " Password: " + user2.password)
# name = input("Enter new name: ");
# # user2.change_name(name);
# pin = input("Enter new pin: ");
# user2.change_pin(pin);
# password = input("Enter new password: ");
# user2.change_password(password);
# print("Name: "+ user2.name + " PIN: " + user2.pin + " Password: " + user2.password)

# """ Driver Code for Task 3 """
# user1 = BankUser("michelle", "1234", "bestpassword")
# print("Name: "+ user1.name + " PIN: " + user1.pin + " Password: " + user1.password + " Balance: " + user1.balance)

# """ Driver Code for Task 4 """
# user1 = BankUser("michelle", "1234", "bestpassword")
# print("Name: "+ user1.name + " PIN: " + user1.pin + " Password: " + user1.password)
# user1.show_balance
# user1.deposit(100)
# user1.show_balance
# user1.withdraw(25)
# user1.show_balance

# """ Driver Code for Task 5 """


user1 = BankUser("Bob", "1234", "password")
user2 = BankUser("Alice", "1234", "password")
user2.deposit(5000)

print(user2.name + " has an account balance of: " + str(user2.balance))
print(user1.name + " has an account balance of: " + str(user1.balance))
print("")

if user2.transfer_money(500, user1.name) == True:
    if user1.request_money(500) == True:
        print(user2.name + " has an account balance of: " + str(user2.balance))
        print(user1.name + " has an account balance of: " + str(user1.balance))
        
