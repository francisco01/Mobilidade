function valida_avaliacao() {
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
    else if (document.getElementById("ContentPlaceHolder1_txtnota").value == "") {
        alert('Por favor, preencha o campo nota!');
        document.getElementById("ContentPlaceHolder1_txtnota").focus();
        return false;
    }
    return true;
}



