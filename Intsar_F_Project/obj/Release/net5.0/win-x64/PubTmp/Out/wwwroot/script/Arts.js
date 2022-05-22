// Song Read More
let btnSong = document.getElementById("song-more");
let songDisplay=document.querySelector(".end-section-word div.song-none");

    btnSong.addEventListener("click",function(){
        songDisplay.classList.toggle("block");
        if(btnSong.innerHTML==="اقرأ المزيد")
    {
        btnSong.innerHTML="اقرأ اقل"
    }
    else
    {
        btnSong.innerHTML="اقرأ المزيد"
    }
    })

// Draw Read More
let btnDraw = document.getElementById("draw-more");
let drawDisplay=document.querySelector(".end-section-word div.draw-none");

    btnDraw.addEventListener("click",function(){
        drawDisplay.classList.toggle("block");
        if(btnDraw.innerHTML==="اقرأ المزيد")
    {
        btnDraw.innerHTML="اقرأ اقل"
    }
    else
    {
        btnDraw.innerHTML="اقرأ المزيد"
    }
    })

// Violin Read More
let btnViolin = document.getElementById("violin-more");
let violinDisplay=document.querySelector(".end-section-word div.violin-none");

    btnViolin.addEventListener("click",function(){
        violinDisplay.classList.toggle("block");
        if(btnViolin.innerHTML==="اقرأ المزيد")
    {
        btnViolin.innerHTML="اقرأ اقل"
    }
    else
    {
        btnViolin.innerHTML="اقرأ المزيد"
    }
    })

// Cello Read More
let btnCello = document.getElementById("cello-more");
let celloDisplay=document.querySelector(".end-section-word div.cello-none");

    btnCello.addEventListener("click",function(){
        celloDisplay.classList.toggle("block");
        if(btnCello.innerHTML==="اقرأ المزيد")
    {
        btnCello.innerHTML="اقرأ اقل"
    }
    else
    {
        btnCello.innerHTML="اقرأ المزيد"
    }
    })
