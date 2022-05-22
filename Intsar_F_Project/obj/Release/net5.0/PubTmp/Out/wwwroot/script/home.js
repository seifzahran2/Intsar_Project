

// about page button Conditions

var btn = document.getElementById("more");
var displayNone= document.querySelectorAll("li.none");
for (let index = 0; index < displayNone.length; index++) {
    btn.addEventListener("click",function(){
        displayNone[index].classList.toggle("block");
    })
    
}
btn.addEventListener("click",function(){
    if(btn.innerHTML==="اقرأ المزيد")
    {
        btn.innerHTML="اقرأ اقل"
    }
    else
    {
        btn.innerHTML="اقرأ المزيد"
    }
})
