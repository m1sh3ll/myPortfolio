def linear_search_dictionary(the_dict, target):
    for x in the_dict:
        if the_dict[x] == target:
            print("Found in key", x)
print("Target not found in dictionary")

my_dictionary = {"red": 5, "blue": 3, "yellow": 12, "green": 7}
linear_search_dictionary(my_dictionary, 5)
linear_search_dictionary(my_dictionary, 3)
linear_search_dictionary(my_dictionary, 8)