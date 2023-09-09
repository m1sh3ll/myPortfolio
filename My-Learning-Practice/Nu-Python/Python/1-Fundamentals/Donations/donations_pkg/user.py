def login(database, username, password):

    if password == database.get(username):
        print("Welcome " + username + "!")
        return username
    elif database.get(username) != None and password != database.get(username):
        print("Invalid password")

    return ""
