

function apagarElemento(id) {
    if (document.contains(document.getElementById(id))) {
        document.getElementById(id).remove();
    }
}

function validarFormulario() {

    if (validarCampoNome() == false && validarCampoNota() == false && validarCampoFrequenci() == false && validarCampoCodigoMatricula() == false) {
        event.preventDefault();
    }
}

function validarCampoNome() {

    var textoCampoNome = document.getElementById("campo-nome").value;

    document.getElementById("campo-nome").classList.remove("border-success");

    apagarElemento("span-campo-nome-menor-7");
    apagarElemento("span-campo-nome-maior-100");
    apagarElemento("span-campo-nome-novo");

    if (textoCampoNome.length < 7) {
        var elementoSpanNome = document.createElement("span");
        var texto = document.createTextNode("Nome deve conter no mínimo 7 caracteres");
        elementoSpanNome.id = "span-campo-nome-menor-7";
        elementoSpanNome.appendChild(texto);
        elementoSpanNome.classList.add("text-danger");
        document.getElementById("div-campo-nome").appendChild(elementoSpanNome);
        document.getElementById("campo-nome").classList.add("border-danger");
        return false;
    }

    if (textoCampoNome.length > 100) {
        var elementoSpanNome = document.createElement("span");
        elementoSpanNome.textContent = "Nome deve conter no máximo 100 caracteres";
        elementoSpanNome.classList.add("text-danger");
        elementoSpanNome.id = "span-campo-nome-maior-100";
        document.getElementById("div-campo-nome").appendChild(elementoSpanNome);
        document.getElementById("campo-nome").classList.add("border-danger");
        return false;
    }

    if (textoCampoNome.length >= 7 && textoCampoNome.length <= 100) {
        document.getElementById("campo-nome").classList.remove("border-danger");
        document.getElementById("campo-nome").classList.add("border-success");
        return true;
    }
}

function validarCampoNota() {

    apagarElemento("span-campo-nota-maior");
    apagarElemento("span-campo-nota-menor");


    var elementoSpanNota = document.createElement("span");
    var notasMaior = document.createTextNode("Nota invalida.");
    var notasMenor = document.createTextNode("Nota não deve ser negativo");

    var nota1 = document.getElementById("campo-nota1").value;
    var nota2 = document.getElementById("campo-nota2").value;
    var nota3 = document.getElementById("campo-nota3").value;

    if (nota1.length >= 3 || nota1 > 10) {
        elementoSpanNota.id = "span-campo-nota-maior";
        elementoSpanNota.appendChild(notasMaior);
        elementoSpanNota.classList.add("text-danger");
        document.getElementById("div-campo-nota1").appendChild(elementoSpanNota);
        document.getElementById("campo-nota1").classList.add("border-danger");
        return false;
    }

    if (nota1 <= -1) {
        elementoSpanNota.id = "span-campo-nota-menor";
        elementoSpanNota.appendChild(notasMenor);
        elementoSpanNota.classList.add("text-danger");
        document.getElementById("div-campo-nota1").appendChild(elementoSpanNota);
        document.getElementById("campo-nota1").classList.add("border-danger");
        return false;
    }


    if (nota2.length >= 3 || nota2 > 10) {
        elementoSpanNota.id = "span-campo-nota-maior";
        elementoSpanNota.appendChild(notasMaior);
        elementoSpanNota.classList.add("text-danger");
        document.getElementById("div-campo-nota2").appendChild(elementoSpanNota);
        document.getElementById("campo-nota2").classList.add("border-danger");
        return false;
    }

    if (nota2 <= -1) {
        elementoSpanNota.id = "span-campo-nota-menor";
        elementoSpanNota.appendChild(notasMenor);
        elementoSpanNota.classList.add("text-danger");
        document.getElementById("div-campo-nota2").appendChild(elementoSpanNota);
        document.getElementById("campo-nota2").classList.add("border-danger");
        return false;
    }


    if (nota3.length >= 3 || nota3 > 10) {
        elementoSpanNota.id = "span-campo-nota-maior";
        elementoSpanNota.appendChild(notasMaior);
        elementoSpanNota.classList.add("text-danger");
        document.getElementById("div-campo-nota3").appendChild(elementoSpanNota);
        document.getElementById("campo-nota3").classList.add("border-danger");
        return false;
    }

    if (nota3 <= -1) {
        elementoSpanNota.id = "span-campo-nota-menor";
        elementoSpanNota.appendChild(notasMenor);
        elementoSpanNota.classList.add("text-danger");
        document.getElementById("div-campo-nota3").appendChild(elementoSpanNota);
        document.getElementById("campo-nota3").classList.add("border-danger");
        return false;
    }


    if (nota1.length < 3 && nota1 != -1 && nota2.length < 3 && nota2 != -1 && nota3.length < 3 && nota3 != -1) {

        document.getElementById("campo-nota1").classList.remove("border-danger");
        document.getElementById("campo-nota1").classList.add("border-success");

        document.getElementById("campo-nota2").classList.remove("border-danger");
        document.getElementById("campo-nota2").classList.add("border-success");

        document.getElementById("campo-nota3").classList.remove("border-danger");
        document.getElementById("campo-nota3").classList.add("border-success");

        return true;
    }
}

function validarCampoFrequenci() {

    apagarElemento("span-campo-frequencia-menor");
    apagarElemento("span-campo-frequencia-maior");

    var campoFrequencia = document.getElementById("campo-frequencia").value;
    var elementoSpanFrequencia = document.createElement("span");
    var frequenciaMaior = document.createTextNode("Frequencia não deve ser maior que 100.");
    var frequenciaMenor = document.createTextNode("Frequencia invalida.");

    if (campoFrequencia <= -1) {
        elementoSpanFrequencia.id = "span-campo-frequencia-menor";
        elementoSpanFrequencia.appendChild(frequenciaMenor);
        elementoSpanFrequencia.classList.add("text-danger");
        document.getElementById("div-campo-frequencia").appendChild(elementoSpanFrequencia);
        document.getElementById("campo-frequencia").classList.add("border-danger");
        return false;
    }
    if (campoFrequencia > 100) {
        elementoSpanFrequencia.id = "span-campo-frequencia-maior";
        elementoSpanFrequencia.appendChild(frequenciaMaior);
        elementoSpanFrequencia.classList.add("text-danger");
        document.getElementById("div-campo-frequencia").appendChild(elementoSpanFrequencia);
        document.getElementById("campo-frequencia").classList.add("border-danger");
        return false;
    }
    if (campoFrequencia < 101 && campoFrequencia > -1) {

        document.getElementById("campo-frequencia").classList.remove("border-danger");
        document.getElementById("campo-frequencia").classList.add("border-success");

    }
}

function validarCampoCodigoMatricula() {

    apagarElemento("span-campo-matricula-maior");
    apagarElemento("span-campo-matricula-menor");

    var campoMatricula = document.getElementById("campo-codigo-matricula").value;
    var elementoSpanMatricula = document.createElement("span");
    var matriculaMario = document.createTextNode("Matricula nao deve ser maior que 15 caracteres.");
    var matriculaMenor = document.createTextNode("Matricula invalida.");

    if (campoMatricula.length > 15) {
        elementoSpanMatricula.id = "span-campo-matricula-maior"
        elementoSpanMatricula.appendChild(matriculaMario);
        elementoSpanMatricula.classList.add("text-danger");
        document.getElementById("div-campo-codigo-matricula").appendChild(elementoSpanMatricula);
        document.getElementById("campo-codigo-matricula").classList.add("border-danger");
        return false
    }
    if (campoMatricula <= -1 || campoMatricula == 0 || campoMatricula.length < 1) {
        elementoSpanMatricula.id = "span-campo-matricula-menor"
        elementoSpanMatricula.appendChild(matriculaMenor);
        elementoSpanMatricula.classList.add("text-danger");
        document.getElementById("div-campo-codigo-matricula").appendChild(elementoSpanMatricula);
        document.getElementById("campo-codigo-matricula").classList.add("border-danger");
        return false
    }
    if (campoMatricula > -1 && !campoMatricula == 0 && campoMatricula.length < 15 && !campoMatricula.length < 1) {

        document.getElementById("campo-codigo-matricula").classList.remove("border-danger");
        document.getElementById("campo-codigo-matricula").classList.add("border-success");
        return true;
    }

}

function situacaoAluno() {
    var frequencia = document.getElementById("campo-frequencia").value;
    var nota1 = parseFloat(document.getElementById("campo-nota1").value);
    var nota2 = parseFloat(document.getElementById("campo-nota2").value);
    var nota3 = parseFloat(document.getElementById("campo-nota3").value);
    var resultadoMedia = parseFloat((nota1 + nota2 + nota3) / 3);

    if (frequencia < 65) {
        document.getElementById("situacao").classList.add("text-danger");
        document.getElementById("situacao").innerHTML = "Reprovado por Frequência";
        document.getElementById("campo-situacao").innerHTML = "Reprovado por Frequência";
        document.getElementById("campo-situacao").value = "Reprovado por Frequência";
    }

    else if (resultadoMedia >= 7) {
        document.getElementById("situacao").classList.add("text-success");
        document.getElementById("situacao").innerHTML = "Aprovado";
        document.getElementById("campo-situacao").innerHTML = "Aprovado";
        document.getElementById("campo-situacao").value = "Aprovado";
    }

    else if (resultadoMedia < 7) {
        document.getElementById("situacao").classList.add("text-warning");
        document.getElementById("situacao").innerHTML = "Exame";
        document.getElementById("campo-situacao").innerHTML = "Exame";
        document.getElementById("campo-situacao").value = "Exame";
    }
    else {
        document.getElementById("situacao").classList.add("text-danger");
        document.getElementById("situacao").innerHTML = "Reprovado";
        document.getElementById("campo-situacao").innerHTML = "Reprovado";
        document.getElementById("campo-situacao").value = "Reprovado";
    }
}




