#RSpec Class Errors

class MadeUpClass

  def return_string
    return "String to return"
  end
end

p MadeUpClass.new.return_string
#Basics

class Book

  def set_title=(title)
   @title = title
  end
  def set_author=(author)
    @author = author
  end

  def description
    "#{@title} was written by #{@author}"
  end
end

book = Book.new
book.set_title=("Z for Zachariah")
book.set_author=("Robert C. O'Brien")
p book.description

#Getters and Setters

class Book2
  def title=(t1)
    @title = t1
  end
  def pages=(p1)
    @pages = p1
  end
  def author=(a1)
    @author = a1
  end

  def title
    @title
  end
  def pages
    @pages
  end
  def author
    @author
  end

end

b = Book2.new
b.title = "A Slight Trick of the Mind"
b.pages = 528
b.author = "Hugh Howey"
p b.title
p b.pages
p b.author


#Attr Accessor

class Playlist
  attr_accessor :name
  attr_accessor :author
  attr_accessor :song_list
end

playlist = Playlist.new
playlist.name = "Rock"
playlist.author = "R&R"
playlist.song_list = ["Radioactive", "Clouds"]
p playlist.name
p playlist.author
p playlist.song_list
