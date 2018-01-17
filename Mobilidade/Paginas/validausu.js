function valida_form_usu (){
	if(document.getElementById("ContentPlaceHolder1_txtnome").value == ""){
		alert('Por favor, preencha o campo nome');
		document.getElementById("ContentPlaceHolder1_txtnome").focus();
		return false;
	}
	 //Alfanumerico e espaço(' '),nao aceita numeros e nem caracteres especiais min 5 e max 45 caracteres. 
            var ck_nome = /^[A-Za-z ]{5,45}$/;
            var tempNome = document.getElementById("ContentPlaceHolder1_txtnome").value;
            var matchNome = tempNome.match(ck_nome);
            var idade = parseInt(document.getElementById("ContentPlaceHolder1_txtidade").value)
            if (matchNome == null) {
                alert("Nome inválido : Não informe números! ");
                document.getElementById("ContentPlaceHolder1_txtnome").focus();
                return false;
            }
    else if (idade < 12 || isNaN(idade)){
       alert('Por favor, o campo idade tem ser maior de 11 anos!');
       document.getElementById("ContentPlaceHolder1_txtidade").focus();
		return false;
	}
	else if(document.getElementById("ContentPlaceHolder1_dplsexo").value == ""){
		alert('Por favor, preencha o campo sexo');
		document.getElementById("ContentPlaceHolder1_dplsexo").focus();
		return false;
	}
	else if(document.getElementById("ContentPlaceHolder1_txtlogin").value == ""){
		alert('Por favor, preencha o login!');
		document.getElementById("ContentPlaceHolder1_txtlogin").focus();
		return false;
	}
	else if (document.getElementById("ContentPlaceHolder1_txtsenha").value == ""
	|| document.getElementById("ContentPlaceHolder1_txtsenha").value.length < 6) {
	    alert('Por favor, preencha o campo senha com mais de 6 caracteris!');
	    document.getElementById("ContentPlaceHolder1_txtsenha").focus();
		return false;
	}
	//validar email
	/*var emailPat = /^(\".*\"|[A-Za-z]\w*)@(\[\d{1,3}(\.\d{1,3}){3}]|[A-Za-z]\w*(\.[A-Za-z]\w*)+)$/;
        var emailid = document.getElementById("ContentPlaceHolder1_txtemail").value;
        var matchArray = emailid.match(emailPat);
        if (matchArray == null) {
        	alert("O Email esta no formato incorreto. Tente novamente.");
                document.getElementById("ContentPlaceHolder1_txtemail").focus();
                return false;
            }*/
	else if(document.getElementById("ContentPlaceHolder1_txtcpf").value == "" || 
	document.getElementById("ContentPlaceHolder1_txtcpf").value.length > 11){
		alert('Por favor, preencha o campo cpf com 11 digitos');
		document.getElementById("ContentPlaceHolder1_txtcpf").focus();
		return false;
	}
	else if (isNaN(document.getElementById("ContentPlaceHolder1_txtcpf").value)){
		alert("cpf inválido: informe somente numeros!");
		document.getElementById("ContentPlaceHolder1_txtcpf").focus();
		return false;
	}
            alert("Usuario cadastrado com sucesso!");
	return true;
}