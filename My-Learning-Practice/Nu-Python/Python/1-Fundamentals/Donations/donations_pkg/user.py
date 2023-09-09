def login(database, username, password):

    if password == database.get(username):
        print("\nWelcome back " + username + "!")
        return username
    elif database.get(username) != None and password != database.get(username):
        print("\nIncorrect password for " + username + ".")
    else:
        print("\nUser not found. Please register.")

    return ""


def register(database, username):
    if database.get(username) != None:
        print("\nUsername already registered.")
        return ""
    else:
        print("\nUsername " + username + " registered!")
        return username