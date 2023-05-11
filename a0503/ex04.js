function ex04() {
    var num1 = parseInt(document.getElementById("num1").value);
    var num2 = parseInt(document.getElementById("num2").value);
    var resultado = (num1 + num2)
    var botao = document.getElementById("myButton");
    console.log(resultado);

    if (resultado % 2 === 0) {
        botao.style.backgroundColor = "blue";
    } else {
        botao.style.backgroundColor = "green";
    }
}