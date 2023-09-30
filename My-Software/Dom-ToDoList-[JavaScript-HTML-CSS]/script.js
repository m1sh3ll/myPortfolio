var d = document;
var counter = 1;
var ul1 = d.getElementById("list1");
ul1.textContent = "My To-Do List";
var btnadd = document.getElementById("addbutton");


d.getElementById("addbutton").addEventListener("click", function (e) {    
    e.preventDefault();
    
    var text1 = d.getElementById("task1").value + " - " + d.getElementById("description").value;
    var litext = d.createTextNode(text1);
    var li1 = d.createElement("li");    
    li1.appendChild(litext);
    var btn = d.createElement('button');
    btn.innerText = 'x';
    btn.setAttribute("class", "delbutton btn btn-danger");
    li1.appendChild(btn);
    ul1.appendChild(li1);
    counter++;
    var delbuttons = d.querySelectorAll('.delbutton');
    delbuttons.forEach(function(element)
    {    
        element.addEventListener('click', 
        function() 
        {
        var li2 = this.parentNode;
        li2.remove();
        });
    });
    d.getElementById("task1").value ="";
    d.getElementById("description").value="";  
    
    
});