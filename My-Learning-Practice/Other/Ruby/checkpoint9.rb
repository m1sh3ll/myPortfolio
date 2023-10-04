p"_Each__________________________________________________"
puts "\n"

a = [2,4,6,8,10]
a.each do |num|
    p "Number: #{num}!"
end

puts "\n"
p "_Each in Rails________________________________________"
puts "\n"
class User
  attr_accessor :name

  def initialize(name)
    @name = name
  end

  def email
    # You'll get a chance to use `join` and `split` in the exercises
    "#{name.split(' ').join('')}@gmail.com"
  end
end

#tests
users = [User.new('Michelle Nesbitt'), User.new('m n'), User.new('No Body')]
users.each do |user|
 p "This user's name is #{user.name}, and their email is #{user.email}."
end

puts "\n"
p "_Exercise 1__________________________________________"
puts "\n"

class ArrayModifier
  #attr_accessor :myarray
  attr_reader :myarray

  def initialize(myarray)
     @myarray = myarray
  end
  def exclaim
      splitarray =[]
      newarray = myarray.join('!, ')
      newarray += "!"
      #p myarray #test if it modified original array
      splitarray = newarray.split(', ')
  end

  def capsify
      newarray = []
      for i in 0..(myarray.length - 1)
        newarray[i] = myarray[i].upcase
      end
        newarray
  end
end

class StringModifier
     attr_accessor :mystring

  def initialize(mystring)
     @mystring = mystring
  end

  def proclaim
      splitarray =[]
      splitarray = mystring.split(' ').join('! ')
      splitarray + "!"
  end
end

#tests
an_array = ["Roxanne", "Put on the red light", "Roxanne", "Put on the red light"]
exclaimed = ArrayModifier.new(an_array).exclaim
capsified = ArrayModifier.new(an_array).capsify
p exclaimed
p capsified
astring = "Roxanne Put on the red light Roxanne Put on the red light"
proclaimed = StringModifier.new(astring).proclaim
p proclaimed

puts "\n"
p "_Exercise 2___________________________________________________"
puts "\n"

def add_value_and_index(myarray)
      newarray = []
      myarray.each_with_index do |element, index|
          newarray[index] = element + index
      end
      newarray
end
#tests
p add_value_and_index([3,4,5])

puts "\n"
p "_Exercise 3___________________________________________________"
puts "\n"

class Title
    attr_accessor :mystring

      def initialize(mystring)
        @mystring = mystring
      end

      def fix
        splitarray=[]
        splitarray=mystring.split(' ')

        splitarray.each_with_index do |word, i|

            if (word == 'of') || (word == 'a') || (word == 'and') || (word == 'the')
                #splitarray[i] = word.downcase
            else
                splitarray[i] = word.capitalize
            end

        end

        splitarray.join(' ')
        end
end
#tests
capsified = Title.new("my STRING TO capITalize").fix
p capsified
