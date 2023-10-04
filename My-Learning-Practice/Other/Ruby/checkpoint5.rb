#If Statements

def favorite_number(fav,guess)
  if fav > guess
    "Too low"
  elsif guess > fav
    "Too high"
  else
    "You got it!"
  end
end

p "favorite_number(5,5) " + favorite_number(5,5)

#And / Or

def lock(a,b,c,d)

  if (a==3 || a==5 || a==7) && b==2 && (c==5 || c==6) && (d==8 || d==9 || d==0)
    "unlocked"
  else
    "locked"
  end
end

p "lock (3,2,6,1) is = " + lock(3,2,6,1)


def can_i_get?(item,money)

    if item == "computer" && money >= 1000
      true
    elsif item =="ipad" && money >= 500
      true
    else
      false
    end
end

p "can_i_get?(\"computer\", 1000)->"
p can_i_get?("computer", 1000)
p "can_i_get?(\"ipad\", 500)->"
p can_i_get?("ipad", 500)
#Booleans

def tasty?(ripe)
   if ripe
     "Yes"
   else
     "Not Yet"
   end
end

p "Ripe: " + tasty?(true)
