function ocultaDiv(obj, pl, prin){
	//ID do CONTEÚDO para ocultar/exibir - recebendo parâmetro - obj
	var obje = document.getElementById(obj);
	//ID da DIV de SINAL - recebendo parâmetro - pl
	var plus = document.getElementById(pl);	
	//ID da DIV que fica aberta  - recebendo parâmetro - divEx
	var divEx = document.getElementById(prin);	
	
	//Se a div que selecionei estiver oculta, manda exibir, o restante fica oculto
	if($(obje).css('display')=='none'){
		for ( i=1 ; i <=5 ; i++ ){
			$('#cont'+i).hide('slow');
			$('#bar'+i).css('color', '#696969');
			$('#plus'+i).css('background','url(img/mais_hl.jpg) no-repeat');
		}
		$(obje).show('slow');
		$(divEx).css('color', '#d7d7d7');
		$(plus).css('background','url(img/menos_hl.jpg) no-repeat');
	//Se a div que selecionei estiver aberta, mando ocultar e retirar os estilos	
	}else{
		$(obje).hide('slow');
		$(divEx).css('color', '#696969');
		$(plus).css('background','url(img/mais_hl.jpg) no-repeat');
	}
}
