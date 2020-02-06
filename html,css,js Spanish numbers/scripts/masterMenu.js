let buttonStart = document.getElementById("gameStart");
let buttonOptions = document.getElementById("options");

if (localStorage.minNumber == null)
    localStorage.setItem('minNumber', 0);
if (localStorage.maxNumber == null)
    localStorage.setItem('maxNumber', 100);
if (localStorage.waitingTime == null)
    localStorage.setItem('waitingTime', 3);

//po prostu przechodzenie pomiedzy stronami
buttonOptions.addEventListener("click", function () {
    window.location.href = 'pages/indexOptions.html';
});
buttonStart.addEventListener("click", function () {
    window.location.href = 'pages/indexTranslate.html';
})