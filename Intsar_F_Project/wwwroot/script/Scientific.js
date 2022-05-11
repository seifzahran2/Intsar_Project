// program Read More
let btnProgram = document.getElementById("program-more");
let programDisplay=document.querySelector("div.program-none");

    btnProgram.addEventListener("click",function(){
        programDisplay.classList.toggle("block");
        if(btnProgram.innerHTML==="اقرأ المزيد")
    {
        btnProgram.innerHTML="اقرأ اقل"
    }
    else
    {
        btnProgram.innerHTML="اقرأ المزيد"
    }
    })

// Program App Read More
let btnApp = document.getElementById("app-more");
let appDisplay=document.querySelector(".end-section-word div.app-none");

    btnApp.addEventListener("click",function(){
        appDisplay.classList.toggle("block");
        if(appApp.innerHTML==="اقرأ المزيد")
    {
        btnApp.innerHTML="اقرأ اقل"
    }
    else
    {
        btnApp.innerHTML="اقرأ المزيد"
    }
    })
