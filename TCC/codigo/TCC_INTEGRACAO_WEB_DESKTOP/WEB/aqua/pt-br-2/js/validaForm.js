$(function(){
	
	var emailAtual = $('#frmUpdDataUser input[name="email_usu"]').val();
	
	//CONTATO
	$(":input[name='nameContact']").focus();
	$("select[name='selectContact'] option").attr('selected', false);

	
	$('#frmContact').validate({
		success: function(li) {
			li.addClass('validVal').text('');
		},
		rules: {
			nameContact: { required: true, letters: true, minlength: 5 },
			emailContact: { required: true,	email: true	},
			selectContact	: { required: true },		
			messageContact: { required: true, minlength: 10 }
		},
		messages: {
			nameContact: { required: "<div id='error_icon'>Insira seu nome.</div>", letters: "<div id='error_icon'>Apenas letras são permitidas</div>", minlength: "<div id='error_icon'>Seu nome deve conter mais de 5 caracteres.</div>" },
			emailContact: { required: "<div id='error_icon'>Insira e-mail.", email: "<div id='error_icon'>Insira email no formato \"examplo@servidor.com\".</div>" },	
			selectContact: { required: "<div id='error_icon'>Selecione uma opção.</div>" },
			messageContact: { required: "<div id='error_icon'>Insira sua mensagem.</div>", minlength: "<div id='error_icon'>Sua mensagem deve conter mais que 10 caracteres.</div>" }
			
		}
	});
	//CADASTRO
	$(":input[name='nom_usu']").focus();
	$("#frmRegister").validate({
		success: function(dd) {dd.addClass('validVal').text('');},
		rules: {
			nom_usu: { required: true, letters: true, minlength: 5 },
			sobrenom_usu: { required: true, letters: true, minlength: 5 },
			email_usu: { required: true,	email: true,
				remote: "server/php.class/manageDadosValidos.class.php?dc=email"
			},
			loginUsu: { required: true,minlength: 6,
				remote: "server/php.class/manageDadosValidos.class.php?dc=login"
			},
			senha_usu: { required: true,minlength: 6 },		
			senha_usu_conf: { required: true, dependSen: true  },
			sx_usu: { dependSele: true },
			estado_usu: { dependSele: true },
			cid_usu: { dependSele: true },
			messageRegister: {minlength: 10},
			dt_usu: { required: true, dateDE: true },
			chkTermUse: { required: true }
		},
		messages: {
			nom_usu: { required: "<div id='error_icon'>Insira seu nome.</div>", letters: "<div id='error_icon'>Apenas letras são permitidas</div>", minlength: "<div id='error_icon'>Seu nome deve conter mais de 5 caracteres.</div>" },
			sobrenom_usu: { required: "<div id='error_icon'>Insira seu sobrenome.</div>", letters: "<div id='error_icon'>Apenas letras são permitidas</div>", minlength: "<div id='error_icon'>Seu sobrenome deve conter mais de 5 caracteres.</div>" },
			email_usu: { required: "<div id='error_icon'>Insira e-mail.", email: "<div id='error_icon'>Insira email no formato \"examplo@servidor.com\".</div>", remote: "<div id='error_icon'>E-mail já está sendo utilizado. Por favor, escolha outro.</div>" },	
			loginUsu: { required: "<div id='error_icon'>Insira login.</div>", minlength: "<div id='error_icon'>Seu login deve conter no minimo 6 caracteres.</div>" ,remote: "<div id='error_icon'>Login já está sendo utilizado. Por favor, escolha outro.</div>"},
			senha_usu: { required: "<div id='error_icon'>Insira senha.", minlength: "<div id='error_icon'>Sua senha deve conter pelo menos 6 caracteres.</div>" },
			senha_usu_conf: { required: "<div id='error_icon'>Senha de confirmação inválida.", dependSen: "<div id='error_icon'>Senha de confirmação inválida.</div>" },
			sx_usu: { dependSele: "<div id='error_icon'>Selecione uma opção.</div>" },
			estado_usu: { dependSele: "<div id='error_icon'>Selecione uma opção.</div>" },
			cid_usu: { dependSele: "<div id='error_icon'>Selecione uma opção.</div>" },
			messageRegister: { minlength: "<div id='error_icon'>Sua descrição deve conter pelo menos 10 caracteres.</div>" },
			dt_usu: { required: "<div id='error_icon'>Insira uma data.</div>",dateDE: "<div id='error_icon'>Insira uma data válida.</div>" },
			chkTermUse: { required: "<div id='error_icon'>Aceite os termos de uso.</div>" }
		}
	});
				
	//ATUALIZAÇÃO PERFIL
	$('#frmUpdDataUser').validate({
		success: function(dd) {dd.addClass('validVal').text('');},
		rules: {
			nom_usu: { required: true, letters: true, minlength: 5 },
			sobrenom_usu: { required: true, letters: true, minlength: 5 },
			email_usu: { required: true,	email: true,
				remote: "server/php.class/manageDadosValidos.class.php?dc=email"
			},
			senha_usu: { required: true,minlength: 6 },		
			senha_usu_conf: { required: true, dependSen: true  },
			sx_usu: { dependSele: true },
			estado_usu: { dependSele: true },
			messageRegister: {minlength: 10},
			dt_usu: { required: true, dateDE: true }
		},
		messages: {
			nom_usu: { required: "<div id='error_icon'>Insira seu nome.</div>", letters: "<div id='error_icon'>Apenas letras são permitidas</div>", minlength: "<div id='error_icon'>Seu nome deve conter mais de 5 caracteres.</div>" },
			sobrenom_usu: { required: "<div id='error_icon'>Insira seu sobrenome.</div>", letters: "<div id='error_icon'>Apenas letras são permitidas</div>", minlength: "<div id='error_icon'>Seu sobrenome deve conter mais de 5 caracteres.</div>" },
			email_usu: { required: "<div id='error_icon'>Insira e-mail.", email: "<div id='error_icon'>Insira email no formato \"examplo@servidor.com\".</div>", remote: "<div id='error_icon'>E-mail já está sendo utilizado. Por favor, escolha outro.</div>" },
			senha_usu: { required: "<div id='error_icon'>Insira senha.", minlength: "<div id='error_icon'>Sua senha deve conter pelo menos 6 caracteres.</div>" },
			senha_usu_conf: { required: "<div id='error_icon'>Senha de confirmação inválida.", dependSen: "<div id='error_icon'>Senha de confirmação inválida.</div>" },
			sx_usu: { dependSele: "<div id='error_icon'>Selecione uma opção.</div>" },
			estado_usu: { dependSele: "<div id='error_icon'>Selecione uma opção.</div>" },
			messageRegister: { minlength: "<div id='error_icon'>Sua descrição deve conter pelo menos 10 caracteres.</div>" },
			dt_usu: { required: "<div id='error_icon'>Insira uma data.</div>",dateDE: "<div id='error_icon'>Insira uma data válida.</div>" }
		}
	});
});	