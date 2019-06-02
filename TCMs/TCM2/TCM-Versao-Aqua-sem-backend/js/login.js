function saida(){
		$('#cmp_login2').remove();
		$('#cmp_login').show('slow');
		$('#c_login').val("nome de usuário");
		$('#c_senha').val("************");
}
$(function(){
	//$('#frmLoga').submit(function(){
	$('#btn_ent').click(function(){
		var login = $('#c_login').val();
		var senha = $('#c_senha').val();
		if(login != "" && senha != ""){
			if(login == "joi&d" && senha == "joi&d"){
				//return false;
				/*$('#f_login').css({background: 'none', border: '1px ridge #ccc', color: '#fff'});
				$('#f_login').remove();
				$('#f_login_inp').remove();*/
				$('#cmp_login').hide('fast');
				$('#frmLoga').append('<div id="cmp_login2"><img src="img/login/user_default.png" alt="Usuário" /><ul><li><span id="login_name">'+ login + '</span></li>' +
				'<li><span id="l_login"><a href="javascript:;">Meu perfil</a> | <a href="javascript:void(0);" onclick="saida();">Sair</a></span></li></ul>' +
				'</div>');
			}else if(login != "joi&d"){
				$.alerts.dialogClass = $(this).attr('style_1');
					jAlert('Login Inválido!', ' ', function() {
					$.alerts.dialogClass = null;
					
				});
				$('#c_login').focus();
				//return false;
			}else if(senha != "joi&d"){
				$.alerts.dialogClass = $(this).attr('style_1');
					jAlert('Senha Inválida!', ' ', function() {
					$.alerts.dialogClass = null;
				});
				$('#c_senha').focus();
				//return false;
			}
		}else{
			$.alerts.dialogClass = $(this).attr('style_1');
				jAlert('Insira Login e Senha!', ' ', function() {
				$.alerts.dialogClass = null;
			});
			$('#c_login').focus();
			//return false;
		}	
	});
	
	
});