
// main toggle
let toggle = document.querySelector('.toggle');
let navigation = document.querySelector('.navigation');
let main = document.querySelector('.main');

toggle.onclick = function ()
{
    navigation.classList.toggle('active')
    main.classList.toggle('active')
}




// add hovered class in selected list item
let list = document.querySelectorAll('.navigation li');

function activeLink()
{
    list.forEach((item) =>
    item.classList.remove('hovered'));
    this.classList.add('hovered')
}

list.forEach((item) => 
 item.addEventListener('mouseover',activeLink));

//  table effect java script

// Get the modal img.onclick =
var modal = document.getElementById("myModal");

var img = document.getElementById("myImg");

function openCard(){
  modal.style.display = "block";
}

var span = document.getElementsByClassName("close")[0];

span.onclick = function() {
  modal.style.display = "none";
}


// message pop up
function togglepopup()
{
  document.getElementById("popup-1").classList.toggle("active")
}

