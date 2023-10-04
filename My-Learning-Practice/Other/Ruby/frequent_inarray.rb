
def most_frequent_item_count(myarray)
  counterarray = Array.new
  if myarray.kind_of?(Array)
    for i in 0..(myarray.length - 1)
      current = myarray[i]
      innercounter = 0
      for j in 0..(myarray.length - 1)
        if current == myarray[j]
          innercounter += 1
        end
      end
      counterarray.push(innercounter)
    end
      counterarray.max
  end
end
p "The most frequent item occurs this many times: "
p most_frequent_item_count([3, -1, -1, -1])
p "----------------------------------------"
myarray = [3,-1,-1,-1]
p myarray.count(-1)