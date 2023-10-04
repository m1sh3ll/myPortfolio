p "Exercise 1"

class InterestCalculator
    attr_accessor :pr, :r, :yrs, :xcomp

    def initialize(pr,r,yrs,xcomp)
        @pr = pr
        @r = r
        @yrs = yrs
        @xcomp = xcomp
    end

    def amount
        amount = pr * (1 + self.r / self.xcomp) ** (self.xcomp * self.yrs)
        amount.round(2)
    end

    def statement
        "After #{yrs} years I'll have #{amount} dollars!"
    end
end

calc = InterestCalculator.new(500, 0.05, 4, 5)
p calc.statement
p calc.amount

puts "\n"
p "Exercise 2_______"

#Parent
class Apple
    attr_accessor :ripe

    def initialize(ripe)
      @ripe = ripe
    end

    def tasty?
      if ripe
        "Yes"
      else
        "Not yet"
      end
    end
end
#Child class
class Fuji < Apple
    def initialize(ripe)
      super(ripe)
    end

    def flavor
      if ripe
        "Sweet"
      else
        "Tart!"
      end
    end

    def color
        if ripe
          "Yellowish red"
        else
          "Green"
        end
    end

end

p Apple.new(false).tasty?
p Apple.new(true).tasty?
p Fuji.new(false).tasty?
p Fuji.new(true).tasty?
p Fuji.new(false).flavor
p Fuji.new(true).flavor
p Fuji.new(false).color
p Fuji.new(true).color

puts "\n"
p "Exercise 3"
class BankAccount
  attr_accessor :balance

  def initialize(balance)
    @balance = balance
  end

  def deposit(amount)
    @balance+=amount
  end
  def withdraw(amount)
    @balance-=amount
  end

end

class CheckingAccount < BankAccount
  def withdraw(amount)
    super(amount)
    if @balance < 0
       @balance -= 50
    end
    @balance
  end
end

class SavingsAccount < BankAccount
  def withdraw(amount)
    super(amount)
    if @balance < 0
      @balance += amount
    end
    @balance
  end

end



puts "\n"
p "Exercise 4"
module Owner
  attr_accessor :balance, :months, :interest_amount

  def set_new_balance(balance, months, interest_amount)
      @balance, @months, @interest_amount = balance, months, interest_amount
      @balance+=months*interest_amount
      @balance
  end
end

class BankAccount
  include Owner
  attr_accessor :balance

  def initialize(balance)
    @balance = balance
  end

  def deposit(amount)
    @balance+=amount
  end
  def withdraw(amount)
    @balance-=amount
  end

end

class CheckingAccount < BankAccount
  def withdraw(amount)
    super(amount)
    if @balance < 0
       @balance -= 50
    end
    @balance
  end
  def simple_interest
    set_new_balance(@balance,3,10)
  end
end

class SavingsAccount < BankAccount
  def withdraw(amount)
    super(amount)
    if @balance < 0
      @balance += amount
    end
    @balance
  end
  def simple_interest
    set_new_balance(@balance,6,5)
  end
end

puts "\n"
p "Exercise 5"
class Shape
    attr_accessor :color

    def initialize(color = nil)
        @color = color || 'Red'
    end

    def larger_than?(other)
        self.area > other.area
    end

end

class Rectangle < Shape
    attr_accessor :width, :height

    def initialize(width, height, color = nil)
      @width, @height = width, height
      super(color) # this calls Shape#initialize
    end

    def area
      width*height
    end
end

class Square < Rectangle
    def initialize(side, color = nil)
      super(side, side, color) # this calls rectangle#initialize
    end
end

class Circle < Shape
    attr_accessor :radius

    def initialize(radius, color = nil)
      @radius = radius
      super(color) # this calls Shape#initialize
    end

    def area
      Math::PI * (radius*radius)
    end
end
