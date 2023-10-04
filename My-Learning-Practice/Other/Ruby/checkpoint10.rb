p "_Exercise 1_________________________-"
puts "\n"

class User
  attr_accessor :email, :name, :role, :age, :sex
  def initialize(email, config = {})
    @email = email
    @name = config[:name]
    @age = config[:age]
    @sex = config[:sex]
    @role = config[:role] || 'basic'
  end
end

#tests
u = User.new("joe@example.com", { name: "Bob" })
p u.email
p u.name
u = User.new("joe@example.com", { name: "Joe", age: 34, sex: :male, role: "member" })
p u.age
p u.sex
p u.role

puts "\n"
p "_Exercise 2_________________________-"
puts "\n"

def hash_to_array(hash = {})
  a = []
  hash.each do |key, value|
    # build the "a" array here
    a << "#{key} is #{value}"
  end
  # return the "a" array
  a
end
p hash_to_array({ name: "Michelle", age: 38})

puts "\n"
p "_Exercise 3_________________________-"
puts "\n"

def merge_us(hash1 = {}, hash2={})
  hash1.merge(hash2)
end


def my_keys(hash1 = {})
  hash1.keys
end


def do_i_have(hash1 = {}, array_of_keys)
    sorted_keys1 = hash1.keys.sort
    sorted_keys2 = array_of_keys.sort

    if sorted_keys1 == sorted_keys2
        true
    else
        false
    end
end

#tests
h1 = { name: "Computer", cost: "$1,000" }
h2 = { name: "Bob", age: 34 }
p merge_us(h1,h2)

new_hash1 = { name: "Computer", cost: "$1,000", first_name: "Bob", age: 34 }
p my_keys(new_hash1)

puts "\n"
p "_Exercise 3________________do i have?_________-"

p "returns false if it doesn't have any of the keys"
    h = { name: "Computer", cost: "$1,000" }
    keys = [:age, :bio]
    p do_i_have(h,keys)

p "returns false if one or more of the keys isn't in the hash"
    h = { name: "Computer", cost: "$1,000" }
    keys = [:name, :bio, :cost]
    p do_i_have(h,keys)

p "returns false if the hash has a different number of keys than the array"
    h = { name: "Computer", cost: "$1,000" }
    keys = [:name]
    p do_i_have(h,keys)

p "returns true if all keys are in the hash"
    h = { name: "Computer", cost: "$1,000", uuid: "1234" }
    keys = [:name, :cost, :uuid]
    p do_i_have(h,keys)

p "returns true if all keys are in the hash, regardless of order"
    h = { name: "Computer", cost: "$1,000", uuid: "1234" }
    keys = [:name, :uuid, :cost]
    p do_i_have(h,keys)
