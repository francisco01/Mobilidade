function valida_form_loc() {
    if (document.getElementById("ContentPlaceHolder1_txtplaca").value == ""
	|| document.getElementById("ContentPlaceHolder1_txtplaca").value.length > 8) {
        alert('Por favor, preencha o campo placa de forma correta! (xxx-xxxx)');
        document.getElementById("ContentPlaceHolder1_txtplaca").focus();
        return false;
    }
    else if (document.getElementById("ContentPlaceHolder1_txtcnh").value == "") {
        alert('Por favor, preencha o campo cnh!');
        document.getElementById("ContentPlaceHolder1_txtcnh").focus();
        return false;
    }
    else if (document.getElementById("ContentPlaceHolder1_txtdtini").value == "") {
        alert('Por favor, preencha o campo data inicial!');
        document.getElementById("ContentPlaceHolder1_txtdtini").focus();
        return false;
    }
    else if (document.getElementById("ContentPlaceHolder1_txtdtfim").value == "") {
        alert('Por favor, preencha o campo data final!');
        document.getElementById("ContentPlaceHolder1_txtdtfim").focus();
        return false;
    }
    else if (document.getElementById("ContentPlaceHolder1_txtpreco").value == "") {
        //alert('Por favor, preencha o campo preço!');
        //document.getElementById("ContentPlaceHolder1_txtpreco").focus();
        //return false;
    }
    return true;
}
