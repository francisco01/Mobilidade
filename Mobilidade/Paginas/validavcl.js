function valida_form_vcl() {
    if (document.getElementById("ContentPlaceHolder1_txtplaca").value == ""
	|| document.getElementById("ContentPlaceHolder1_txtplaca").value.length > 8) {
        alert('Por favor, preencha o campo placa de forma correta! (xxx-xxxx)');
        document.getElementById("ContentPlaceHolder1_txtplaca").focus();
        return false;
    }
    else if (document.getElementById("ContentPlaceHolder1_dplmarca").value == "") {
        alert('Por favor, preencha o campo marca!');
        document.getElementById("ContentPlaceHolder1_dplmarca").focus();
        return false;
    }
    else if (document.getElementById("ContentPlaceHolder1_txtmodelo").value == "") {
        alert('Por favor, preencha o campo modelo!');
        document.getElementById("ContentPlaceHolder1_txtmodelo").focus();
        return false;
    }
    else if (document.getElementById("ContentPlaceHolder1_txtcor").value == "") {
        alert('Por favor, preencha o campo cor!');
        document.getElementById("ContentPlaceHolder1_txtcor").focus();
        return false;
    }
    else if (document.getElementById("ContentPlaceHolder1_txtano").value == "") {
        alert('Por favor, preencha o campo ano!');
        document.getElementById("ContentPlaceHolder1_txtano").focus();
        return false;
    }
    else if (document.getElementById("ContentPlaceHolder1_txtquantidade").value == "") {
        alert('Por favor, preencha o campo quantidade de portas!');
        document.getElementById("ContentPlaceHolder1_txtquantidade").focus();
        return false;
    }
    else if (document.getElementById("ContentPlaceHolder1_txtsituacao").value == "") {
        alert('Por favor, preencha o campo situação!');
        document.getElementById("ContentPlaceHolder1_txtsituacao").focus();
        return false;
    }
    return true;
}



