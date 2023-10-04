#MODULE 2
p 4
p :HELLO

principal = 10_000
rate = 0.05
time = 5
num = 12
amount = principal * (1 + rate/num) ** (num * time)
p "After #{time} years I'll have #{amount} dollars!"

p 'Bloc'[7]
p 'Bloc'[2]
nilly = nil
p nilly

def compound_interest(name, principal, rate, years, num)
  amount = principal * (1 + rate/num) ** (num * years)
  "After #{years} years, #{name} will have #{amount} dollars!"
end

p compound_interest('Bob',100,0.05,40,12)
p compound_interest('Joe',250,0.06,50,12)

#module 3
