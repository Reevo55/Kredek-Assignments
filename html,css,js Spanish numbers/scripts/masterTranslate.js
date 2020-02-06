let maxNumber = parseInt(localStorage.getItem('maxNumber'));
let minNumber = parseInt(localStorage.getItem('minNumber'));

let timeout;

let currentRandomNumber = 0;
let startingCountDown = localStorage.getItem('waitingTime');

let fromToAnotherLang = "pl-es";
let translatedText = "";

let numberText = document.getElementById("number");
let inputText = document.getElementById("inputNumber");
let timer = document.getElementById("timer");
let buttonNumber = document.getElementById("buttonNumber");
let buttonBack = document.getElementById("buttonBack");
let rightAnswerField = document.getElementById("rightAnswer");

// losowa liczba
function randomNumber(min, max) {
    return Math.floor(Math.random() * (max - min)) + min;
}

//wyswietla liczbe
function displayNumber() {
    let randomNum = randomNumber(minNumber, maxNumber);

    numberText.value = randomNum;
}

//odliczanie
function countDown(counterValue) {
    let duration = counterValue;

    let myTimer = setInterval(function () {
        if (startingCountDown == counterValue) {
            currentRandomNumber = randomNumber(minNumber, maxNumber);
        }

        translateText(currentRandomNumber, fromToAnotherLang);


        timer.textContent = counterValue;

        if (--counterValue < 0) {
            counterValue = duration;
            timer.textContent = "Wprowadź liczbę!";
            numberText.textContent = currentRandomNumber;
            inputText.textContent = "";
            clearInterval(myTimer);

            timeout = setTimeout(function () {
                timer.textContent = "Za długi czas wprowadzania!";
                game();
            }, 100000);
        }
    }, 1000);
}

//sprawdzenie api z yandex, tłuamczenie tekstu
function translateText(textToTranslate, langToLang) {

    $.get("https://translate.yandex.net/api/v1.5/tr.json/translate?key=trnsl.1.1.20191221T112250Z.5bb72c343d2296cb.fe67a446b46124ec5304d641fd9241bcc0fd6d0c&text=" + textToTranslate + "&lang=" + langToLang, function (result) {
        translatedText = result.text.toString().toLocaleLowerCase();
    });
}

//sprawdzenie odpowiedzi
function checkAnswer() {
    debugger;
    //translatedText = translatedText.toLowerCase();
    let strHelp = inputText.value.toString().toLocaleLowerCase();

    if (strHelp == translatedText || (strHelp == "uno" && currentRandomNumber == 1)) {
        timer.textContent = "Dobrze!";
        game();
    }
    else {
        timer.textContent = "Źle!";
	    rightAnswerField.textContent = translatedText.toLowerCase();
        game();
    }
}

//gra
function game() {
    inputText.value = "";
    countDown(startingCountDown);
    gameStart();
}

buttonBack.addEventListener("click", function()
{
    window.location.href = '../indexMenu.html'
})

buttonNumber.addEventListener('click', function () {
    clearTimeout(timeout);
    checkAnswer();
});

//dodanie mozliwosci klikania enterem
$(document).keypress(function (e) {
    if (e.which == 13) {
        clearTimeout(timeout);
        checkAnswer();
    }
});

game();