#Array Definition

def new_array(a,b,c,d)
  [a,b,c,d]
end

def  first_and_last(a)
  [a.first,a.last]
end
#Array Methods

def no_fruits?(a)
  a.empty?
end

def number_of_fruits(a1,a2)
  a1.length+a2.length
end

def number_of_unique_fruits(a)
  a.uniq.length
end
#Grocery List

def add_item(item, list1)
  list1<<item
  list1.uniq
end

def remove_item(item, list)
  if list.include?(item)
    list.delete(item)
  end
  list
end

def show_list(list)
  list.uniq.sort

end
