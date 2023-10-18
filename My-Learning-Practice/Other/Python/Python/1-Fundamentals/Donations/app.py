
from donations_pkg import homepage
from donations_pkg import user


database = {
    "admin": "password123"
}
donations = []
authorized_user = ""


while (True):
    homepage.show_homepage()

    if authorized_user == "":
        print("You must be logged in to donate.")
    else:
        print("Logged in as:", authorized_user)

    option = input("\nChoose an option: ")

    if option == "1":
        # Login Functionality
        username = input("\nEnter username: ")
        password = input("Enter password: ")
        authorized_user = user.login(database, username, password)

    elif option == "2":
        # Register Functionality
        username = input("\nEnter new username: ")
        password = input("Enter new password: ")
        authorized_user = user.register(database, username)
        if authorized_user != "":
            database[username] = password

    elif option == "3":
        # Donate Functionality
        if authorized_user == "":
            print("\nYou are not logged in.")
        else:
            donation_string = homepage.donate(authorized_user)
            donations.append(donation_string)

    elif option == "4":
        # Show Donations Functionality
        if authorized_user == "":
            print("\nYou are not logged in.")
        else:
            homepage.show_donations(donations)
    elif option == "5":
        print("Leaving DonateMe...")
        break
    else:
        print("Invalid option")
