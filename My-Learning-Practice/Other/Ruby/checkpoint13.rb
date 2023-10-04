p "https://www.codewars.com/users/nerdommicro/completed"



p"________________________stringy strings___________________________"
#prints 1010101 ones and zeroes for the length of the string
def stringy(j)
  # Your code here
stringy = ""

 # for i in 1..j
 (1..j).each do |i|
      if i % 2 == 0
       stringy += "0"
      else
       stringy += "1"
      end
  end

    stringy
end

p stringy(2)
p stringy(3)
p stringy(5)
p stringy(10)

p"___________________________count_by__________________________"
def count_by(multiple,i)
    list = []
    j = multiple

    i.times do
        list << multiple
        multiple += j
    end

    list

end
p count_by(2,6)
p count_by(1,5)
p count_by(2,5)
p count_by(3,5)
p count_by(5,5)
p count_by(10,5)
p count_by(50,5)
p count_by(100,5)
