$(function(){
	var pontos = parseInt($(".perfil_user li:eq(0) span").text());
	var total = pontos;
	
	var arrPontos = 
		[
			{"medBro": 0, "medPra": 0, "medOur": 0, "troBro": 0, "troPra": 0, "troOur": 0, "troPla": 0, "troDia": 0},
			{"pctTroBro": 0, "pctTroPra": 0, "pctTroOur": 0, "pctTroPla": 0, "pctTroDia": 0}
	];
	var etapa1,etapa2,etapa3 = false;
	var imgMed = $('#medal');
	var imgTro = $('#mini_trophy');
	
	if(pontos > 0)
	{
	
		//VERIFICA MEDALHAS DE BRONZE
		if(parseInt(pontos / 10) >= 10)
		{
			arrPontos[0].medBro = 10;
			arrPontos[0].medPra = 1;
			pontos -= 100;
		}
		else	
		{
			arrPontos[0].medBro = parseInt(pontos / 10);
			pontos = 0;
		}
		
		//Definindo imagens
		imgMed.css({background: 'url("img/perfil/medal_bronze.png")', width: 22 * arrPontos[0].medBro});
		
		
		//VERIFICA MEDALHAS DE PRATA
		if(pontos > 0)
		{
			if(parseInt(pontos / 10) >= 10)
			{
				arrPontos[0].medPra = 10;
				arrPontos[0].medOur = 1;
				pontos -= 100;
			}			
			else	
			{
				arrPontos[0].medPra = parseInt(pontos / 10);
				pontos = 0;
			}
			
			//Definindo imagens
			imgMed.css({background: 'url("img/perfil/medal_silver.png")', width: 22 * arrPontos[0].medPra});
		
		}
		//VERIFICA MEDALHAS DE OURO
		if(pontos > 0)
		{
			if(parseInt(pontos / 10) >= 10)
			{
				arrPontos[0].medOur = 10;
				arrPontos[0].troBro = 1;
				pontos -= 100;
				etapa1 = true;
			}			
			else	
			{
				arrPontos[0].medOur = parseInt(pontos / 10);
				pontos = 0;
			}
			
			//Definindo imagens
			imgMed.css({background: 'url("img/perfil/medal_gold.png")', width: 22 * arrPontos[0].medOur});
			
		}
		
		//-------------TROFÉUS
		
		//VERIFICA TROFÉUS DE BRONZE
		if(pontos > 0)
		{
			if(parseInt(pontos / 20) >= 5)
			{
				arrPontos[0].troBro = 5;
				arrPontos[0].troPra = 1;
				arrPontos[1].pctTroBro = 100;
				pontos -= 100;
			}			
			else	
			{
				arrPontos[0].troBro = parseInt((pontos / 20) % 5);
				arrPontos[1].pctTroBro = parseInt(((pontos / 20) % 5) * 20);
				pontos = 0;
			}
			
			//Definindo imagens
			imgTro.css({background: 'url("img/perfil/mini_trophy_bronze.png")', width: 19.2 * arrPontos[0].troBro});
			
		}
		
		//VERIFICA TROFÉUS DE PRATA
		if(pontos > 0)
		{
			if(parseInt(pontos / 20) >= 5)
			{
				arrPontos[0].troPra = 5;
				arrPontos[0].troOur = 1;
				arrPontos[1].pctTroPra = 100;
				pontos -= 100;
			}			
			else	
			{
				arrPontos[0].troPra = parseInt((pontos / 20) % 5);
				arrPontos[1].pctTroPra = parseInt(((pontos / 20) % 5) * 20);
				pontos = 0;
			}
			
			//Definindo imagens
			imgTro.css({background: 'url("img/perfil/mini_trophy_silver.png")', width: 19.2 * arrPontos[0].troPra});
		}
		
		//VERIFICA TROFÉUS DE OURO
		if(pontos > 0)
		{
			if(parseInt(pontos / 20) >= 5)
			{
				arrPontos[0].troOur = 5;
				arrPontos[0].troPla = 1;
				arrPontos[1].pctTroOur = 100;
				pontos -= 100;
			}			
			else	
			{
				arrPontos[0].troOur = parseInt((pontos / 20) % 5);
				arrPontos[1].pctTroOur = parseInt(((pontos / 20) % 5) * 20);
				pontos = 0;
			}
			
			//Definindo imagens
			imgTro.css({background: 'url("img/perfil/mini_trophy_gold.png")', width: 19.2 * arrPontos[0].troOur});
		}
		
		//VERIFICA TROFÉUS DE PLATINA
		if(pontos > 0)
		{
			if(parseInt(pontos / 20) >= 5)
			{
				arrPontos[0].troPla = 5;
				arrPontos[0].troDia = 1;
				arrPontos[1].pctTroPla = 100;
				pontos -= 100;
			}			
			else	
			{
				arrPontos[0].troPla = parseInt((pontos / 20) % 5);
				arrPontos[1].pctTroPla = parseInt(((pontos / 20) % 5) * 20);
				pontos = 0;
			}
			
			//Definindo imagens
			imgTro.css({background: 'url("img/perfil/mini_trophy_platinum.png")', width: 19.2 * arrPontos[0].troPla});
			
		}
		
		//VERIFICA TROFÉUS DE DIAMANTE
		if(pontos > 0)
		{
			if(parseInt(pontos / 20) >= 5)
			{
				arrPontos[0].troDia = 5;
				arrPontos[1].pctTroDia = 100;
				pontos -= 100;
				etapa2 = true;
			}			
			else	
			{
				arrPontos[0].troDia = parseInt((pontos / 20) % 5);
				arrPontos[1].pctTroDia = parseInt(((pontos / 20) % 5) * 20);
				pontos = 0;
			}
			
			//Definindo imagens
			imgTro.css({background: 'url("img/perfil/mini_trophy_diamond.png")', width: 19.2 * arrPontos[0].troDia});
			
		}

	}
		
	//EXIBINDO PORCENTAGENS
	$('.nivel_percent1 .bar_percent p').text(arrPontos[1].pctTroBro + '%');
	$('.nivel_percent2 .bar_percent p').text(arrPontos[1].pctTroPra + '%');
	$('.nivel_percent3 .bar_percent p').text(arrPontos[1].pctTroOur + '%');
	$('.nivel_percent4 .bar_percent p').text(arrPontos[1].pctTroPla + '%');
	$('.nivel_percent5 .bar_percent p').text(arrPontos[1].pctTroDia + '%');
	
		
	//EXIBINDO IMG DE PORCENTAGEM
	if(arrPontos[1].pctTroBro > 0)
	{$('.nivel_percent1 .bar_percent').css('width',arrPontos[1].pctTroBro - 12); $('#trophy01').css('background',"url('img/perfil/trophy01_a.png')");}
	if(arrPontos[1].pctTroPra > 0)
	{$('.nivel_percent2 .bar_percent').css('width',arrPontos[1].pctTroPra - 12); $('#trophy02').css('background',"url('img/perfil/trophy02_a.png')");}
	if(arrPontos[1].pctTroOur > 0)
	{$('.nivel_percent3 .bar_percent').css('width',arrPontos[1].pctTroOur - 12); $('#trophy03').css('background',"url('img/perfil/trophy03_a.png')");}
	if(arrPontos[1].pctTroPla > 0)
	{$('.nivel_percent4 .bar_percent').css('width',arrPontos[1].pctTroPla - 12); $('#trophy04').css('background',"url('img/perfil/trophy04_a.png')");}
	if(arrPontos[1].pctTroDia > 0)
	{$('.nivel_percent5 .bar_percent').css('width',arrPontos[1].pctTroDia - 12); $('#trophy05').css('background',"url('img/perfil/trophy05_a.png')");}

	if(total > 0)	$('#doubt_percent').css('width',parseInt((total / 850) * 100) - 26);
	
	
	/*if(etapa1 == true) $('#msg').html("<p>Você alcançou a primeira fase!</p>");
	if(etapa2 == true) $('#msg').html("<p>Você alcançou a primeira fase!</p><p>Você alcançou a segunda fase!</p>");*/
	
});	