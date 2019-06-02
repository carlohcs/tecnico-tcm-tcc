
$(function(){

	$(":input[name='nameContact']").focus();
	$("select[name='selectContact'] option").attr('selected', false);
	if ($.browser.msie){
		$("textarea[name='messageContact']").keyup(function(){
			var len = $("textarea[name='messageContact']");
			$('#cont').css('display', 'block');
			$('#cont').text("Faltam " + eval(500 - len.val().length));
			if(eval(len.val().length >= 500)) len.val(len.val().substring(0,500-1));
		});	
		//if(len > 500) $('#cont').text("Faltam " + len.substring(0,500)); 
	}else{
		$("textarea[name='messageContact']").limit('500', '#cont');
	}
	$('#frmContact').validate({
		rules: {
			nameContact: { required: true, letters: true, minlength: 5 },
			//yearsContact: { required: true,	digits: true, range: [9, 99] },
			emailContact: { required: true,	email: true	},
			selectContact	: { required: true },		
			messageContact: { required: true, minlength: 10 }
		},
		messages: {
			nameContact: { required: "<div id='error_icon'>Insira seu nome.</div>", letters: "<div id='error_icon'>Apenas letras são permetidas</div>", minlength: "<div id='error_icon'>Seu nome deve conter mais de 5 caracteres.</div>" },
			//yearsContact: { required: "<div id='error_icon'>Insira sua idade.</div>", digits: "<div id='error_icon'>Apenas dígitos são permitidos.</div>", range: "<div id='error_icon'>Sua idade deve estar entre 1 e 100 anos.</div>"},
			emailContact: { required: "<div id='error_icon'>Insira e-mail.", email: "<div id='error_icon'>Insira email no formato \"examplo@servidor.com\".</div>" },	
			selectContact: { required: "<div id='error_icon'>Selecione uma opção.</div>" },
			messageContact: { required: "<div id='error_icon'>Insira sua mensagem.</div>", minlength: "<div id='error_icon'>Sua mensagem deve conter mais que 10 caracteres.</div>" }
			
		}
	});
});	