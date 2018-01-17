function valida_sugestao() {
    if (document.getElementById("ContentPlaceHolder1_DropDowntipo").value == "") {
        alert('Por favor, preencha o campo tipo de serviço!');
        document.getElementById("ContentPlaceHolder1_DropDowntipo").focus();
        return false;
    }
    else if (document.getElementById("ContentPlaceHolder1_DropDownnome").value == "") {
        alert('Por favor, preencha o campo nome do serviço!');
        document.getElementById("ContentPlaceHolder1_DropDownnome").focus();
        return false;
    }
    else if (document.getElementById("ContentPlaceHolder1_txtcomnt").value == "") {
        alert('Por favor, preencha o campo sugestão!');
        document.getElementById("ContentPlaceHolder1_txtcomnt").focus();
        return false;
    }
    return true;
}
