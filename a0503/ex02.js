function ex02() {
    var nome = document.getElementById("nome")
    var idade = parseInt(document.getElementById("idade").value)
    if (idade >= 18) {
        console.log(nome.value + " é maior de idade")
    }
    else {
        console.log(nome.value + "Não é maior de idade")
    }
}