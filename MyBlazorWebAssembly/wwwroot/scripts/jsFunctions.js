
function addNumberJS(number1, number2) {
    var sum = number1 + number2;

    alert(sum);
}

function addNumberCSharp(number1, number2) {
    DotNet.invokeMethodAsync("MyBlazorWebAssembly", "Add", parseInt(number1), parseInt(number2))
        .then(result => {
            alert(result);
        })
}

function GetCurrentDataCSharp() {
    return DotNet.invokeMethodAsync("MyBlazorWebAssembly", "GetCurrentDate")
}

function changeBackgroundColor() {
    document.body.style.background = 'red';
}