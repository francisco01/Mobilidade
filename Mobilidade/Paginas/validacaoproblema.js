function valida_problema() {
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
        else if (document.getElementById("ContentPlaceHolder1_DropDownprobl").value == "") {
            alert('Por favor, preencha o campo tipo de problema!');
            document.getElementById("ContentPlaceHolder1_DropDownprobl").focus();
            return false;
        }
        else if (document.getElementById("ContentPlaceHolder1_txtdata").value == "") {
            alert('Por favor, preencha o campo data!');
            document.getElementById("ContentPlaceHolder1_txtdata").focus();
            return false;
        }
        else if (document.getElementById("ContentPlaceHolder1_txtcomnt").value == "") {
            alert('Por favor, preencha o campo comentario!');
            document.getElementById("ContentPlaceHolder1_txtcomnt").focus();
            return false;
        }

        //alert("Usuario cadastrado com sucesso!");
        return true;
}
