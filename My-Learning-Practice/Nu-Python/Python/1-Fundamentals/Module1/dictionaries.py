inches_snow = {"Monday": 2, "Tuesday": 4, "Wednesday": 5}

def print_total_snowfall(inches_snow):
    
    total_inches = 0

    for inches in inches_snow.values():
        total_inches += inches
    print("Total snowfall inches " + str(total_inches))

print_total_snowfall(inches_snow)

choice =input("How many inches of snow fell on Thursday ")

inches_snow["Thursday"] = int(choice)

print_total_snowfall(inches_snow)

my_string = "Nucamp"
print(my_string[3:5])