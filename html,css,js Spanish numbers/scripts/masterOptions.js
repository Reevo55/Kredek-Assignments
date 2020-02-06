let buttonFiveSeconds = document.getElementById("fiveSecond");
let buttonThreeSeconds = document.getElementById("threeSecond");
let buttonMenu = document.getElementById("back");

let inputMin = document.getElementById("min");
let inputMax = document.getElementById("max");

let min = localStorage.getItem('minNumber');
let max = localStorage.getItem('maxNumber');
let waitingTime =localStorage.getItem('waitingTime');

setEverything();


//na poczatku wszsytko ustawia
function setEverything(){
    inputMin.value = min;
    inputMax.value = max;
}

buttonFiveSeconds.addEventListener("click", function()
{
    waitingTime = 5;
})
buttonThreeSeconds.addEventListener("click", function()
{
    waitingTime = 3;
})

// powrot do menu glownego
buttonMenu.addEventListener("click", function(){
    debugger;
    min = inputMin.value;
    max = inputMax.value
    if(min > max) alert("Please change min and max. They are not right!");
    else
    {
    localStorage.setItem("minNumber", min);
    localStorage.setItem("maxNumber", max);
    localStorage.setItem("waitingTime", waitingTime);

    window.location.href = '../indexMenu.html';
    }
})