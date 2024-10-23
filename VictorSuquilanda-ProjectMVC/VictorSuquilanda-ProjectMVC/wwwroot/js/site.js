// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function CrearAlter() {
    alert("Guten Tag World");
}
function Sumar() {
    var num1 = document.getElementById("numero1").value;
    var num2 = document.getElementById("numero2").value;

    var suma = parseInt(num1) + parseInt(num2);

    document.getElementById("resultado").value = suma;
}

$(document).ready(function () {
    $('#sumar').click(function () {
        var num1 = $("#numero1").val();
        var num2 = $("#numero2").val();

        var sum = parseInt(num1) + parseInt(num2);
        $("#resultado").val(sum);
    });
});
