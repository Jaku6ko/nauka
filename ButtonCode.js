function ToggleOne(){
    var buttonOne = $("#toggleThree");
    var buttonThree = $("#toggleOne");
    if(buttonOne.disabled)
    {
        buttonOne.disabled = false;
        buttonThree.value = "Disable 1";
    }
    else
    {
        buttonOne.disabled = true;
        buttonThree.value = "Enable 1";
    }
}
function ToggleTwo(){
    var buttonTwo = $("#toggleOne");
    var buttonOne = $("#toggleTwo");
    if(buttonTwo.disabled)
    {
        buttonTwo.disabled = false;
        buttonOne.value = "Disable 2";
    }
    else
    {
        buttonTwo.disabled = true;
        buttonOne.value = "Enable 2";
    }
}
function ToggleThree(){
    var buttonThree = $("#toggleTwo");
    var buttonOne = $("#toggleThree");
    if(buttonThree.disabled)
    {
        buttonThree.disabled = false;
        buttonOne.value = "Disable 3";
    }
    else
    {
        buttonThree.disabled = true;
        buttonOne.value = "Enable 3";
    }
}
function ToggleAll(){
    var buttonOne = $("#toggleThree");
    var buttonTwo = $("#toggleOne");
    var buttonThree = $("#toggleTwo");
    if(buttonThree.disabled || buttonTwo.disabled || buttonThree.disabled)
    {
        buttonOne.disabled = false;
        buttonTwo.disabled = false;
        buttonThree.disabled = false;
        buttonThree.value = "Disable 1";
        buttonOne.value = "Disable 2";
        buttonTwo.value = "Disable 3";
    }
    else
    {
        buttonOne.disabled = true;
        buttonTwo.disabled = true;
        buttonThree.disabled = true;
        buttonThree.value = "Enable 1";
        buttonOne.value = "Enable 2";
        buttonTwo.value = "Enable 3";
    }
}