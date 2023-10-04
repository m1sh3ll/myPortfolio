#Initialize

class Car1
   attr_accessor :make, :model, :year

def initialize(make, model, year)
   @make, @model, @year = make, model, year
end

end

 new_car = Car1.new("Acura", "Integra", 1998)
 p new_car.make
 p new_car.model
 p new_car.year

#Class Methods

class Car2
   attr_accessor :make, :model, :year

    def initialize(make, model, year)
       @make, @model, @year = make, model, year
    end

    def wheels
       4
    end

    def axles
       2
    end
end

new_car = Car2.new("Acura", "Integra", 1999)
p new_car.make
p new_car.model
p new_car.year
p new_car.wheels
p new_car.axles

class Calculator
    attr_accessor :x, :y

    def initialize(x,y)
      @x, @y = x, y
    end
    def description
      "Performs basic mathematical operations"
    end
    def add
      x + y
    end
    def subtract
      x - y
    end
    def multiply
      x * y
    end
    def divide
      x.to_f/y
    end
end

calc = Calculator.new(7,7)
p calc.description
p calc.add
p calc.subtract
p calc.multiply
p calc.divide


#Calculator Class

# class Calculator
#     attr_accessor :x, :y
#
#     def initialize(x,y)
#       @x, @y = x, y
#     end
#     def self.description
#       "Performs basic mathematical operations".
#     end
#     def add
#       x + y
#     end
#     def subtract
#       y - x
#     end
#     def multiply
#       x * y
#     end
#     def divide
#       x.to_f/y
#     end
# end
