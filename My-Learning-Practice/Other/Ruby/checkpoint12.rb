items = ["HDMI", "CAT5e", "COAX", "RCA RED"]
items.each do |item|
  p item
end


items = [1, 2, 3, 4]
items.each { |item| p item + item }

array = ["HDMI", "CAT5e", "COAX", "RCA RED"]

p array

def new_array_plus(items)
  new_items = []
  items.each { |item| new_items << item + "-HDMI" }
  new_items
end
p new_array_plus(array)


#add input to each string in the array and uppercase them
def new_array_plus_map(items)
    puts "What port should we add next?"
    input = gets
    items.map { |item| item.upcase + "-" + input.upcase}
end

puts new_array_plus_map(array)

a = %w(z yyyy xxx ww)
#sort each item in an arry by its length
def sort_by_length(array)
    array.sort{|x, y| x.length <=> y.length}
end
p sort_by_length(a)

#filter out all numbers > 5
a = [1, 2, 17, 56, 7, 12, 3, 18, 19, 23]
def filter(array)
  array.select { |num| num > 5 }
end

p filter(a)

#return array of all numbers in the array + 2
def new_array_plus_map2(items)
    items.map { |item| item + 2}
end
p new_array_plus_map2(a)
#see if there is a string in the array
def any_strings?(array)
  array.any? {|a| a.is_a? String}
end
#see if there is a number in the array including floats doubles integers
def any_numbers?(array)
  array.any? {|a| a.is_a? Numeric}
end
#see if there is either a string or a number in the array
def any_strings_or_numbers?(array)
  array.any? {|a| a.is_a? String} || array.any? {|a| a.is_a? Numeric}
end
