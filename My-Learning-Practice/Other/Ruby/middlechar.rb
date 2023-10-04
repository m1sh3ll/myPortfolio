string1 = "middle"
if (string1).length % 2 == 0
  p string1[(string1.length/2) - 1] + "" + string1[string1.length/2]
else
  p string1[(string1.length / 2).floor]
end
string1 = "midadle"
if (string1).length % 2 == 0
  p string1[(string1.length/2) - 1] + "" + string1[string1.length/2]
else
  p string1[(string1.length / 2).floor]
end