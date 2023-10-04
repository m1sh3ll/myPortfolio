#No Method Error

def hello (name)
  "Hello #{name}"
end

p hello("Michelle")

#Wrong Number of Arguments

def hello1 (firstname, lastname)
  "Hello #{firstname} #{lastname}"
end

p hello1("Michelle", "Nesbitt")
#No Name Error

def hello2(first,last)
 "Hello #{first} #{last}"
end
p hello2("Michelle", "Nesbitt")
#Type Error

def add(a,b)
  "#{a} + #{b} = #{(a + b)}"

end
p add(5,6)
#Unexpected End

def hello3
  "Hello World"
end
p hello3
