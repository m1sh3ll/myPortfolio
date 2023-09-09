
from donations_pkg import homepage
from donations_pkg import user

database = {
  "admin": "password123"
}
donations = []
authorized_user = ""

homepage.show_homepage()

if authorized_user == "":
  print("You must be logged in to donate.")
else:
  print("Logged in as:", authorized_user)

option = input("Choose an option:")

if option==1:
  #print("TODO: Write Login Functionality")
  username = input("Enter username: ")
  password = input("Enter password: ")

  authorized_user = user.login(database,username,password)

elif option ==2:
  print("TODO: Write Register Functionality")
elif option ==3:
  print("TODO: Write Donate Functionality")
elif option ==4:
  print("TODO: Write Show Donations Functionality")
elif option ==5:
  print("Leaving DonateMe...")
else:
  print("Invalid option")