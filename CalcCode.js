function Calculate(){
    var numberOne = parseInt($("#numberOne").val());
    var numberTwo = parseInt($("#numberTwo").val());
    var operation = $("#operation")[0];
    var sop = operation.options[operation.selectedIndex].id;
    var result = 0;
    switch(sop){
        case "+":
        result = getResponse(numberOne, numberTwo, "add");
        break;
        case "-":
        result = getResponse(numberOne, numberTwo, "subtract");
        break;
        case "*":
        result = getResponse(numberOne, numberTwo, "multiply");
        break;
        case "/":
        result = getResponse(numberOne, numberTwo, "divide");
        break;
    }
    $("#output").val(result.result);
}
function getResponse(inputOne, inputTwo, type){
    var response = null;
    $.ajax({
        url: "https://localhost:5001/api/Calculator/"+ type +"?inputone=" + inputOne + "&inputtwo=" + inputTwo,
        method: "GET",
        async: false,
        success: function(data) {
            response = data;
        },
        error: function(er) {
            alert("An error occured")
            console.log(er)

        }
    });
    return response;
}