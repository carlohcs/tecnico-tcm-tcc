function insereTexto(inf,tit){
	/*var par = document.createElement("p");
	par.setAttribute('id', 'txt');
	var local = document.getElementById('int2');
	local.appendChild(par);*/
	var arr = new Array(5);
	//CONTEUDO NOTICIA
	//CALL OF DUTY
	arr[0] = "Após superar o recorde de vendas antecipadas e de compras em 24h, Call of Duty: Black Ops consegue a façanha de arrecadar US$ 650 milhões em apenas cinco dias e deixa para trás a marca conquistada por Call of Duty: Modern Warfare 2. De acordo com a Activision, o game superou a arrecadação de Modern Warfare 2 em cerca US$ 100 milhões nos primeiros dias de venda. A produtora afirma que mais de 2,6 milhões de jogadores já entraram em confronto e a jogatina on-line soma quase 6 milhões de horas no modo multiplayer. Em Call of Duty: Black Ops, o jogador enfrenta missões secretas que ocorreram durante a Guerra Fria, período em que o mundo estava dividido em duas grandes potências: Estados Unidos e a União Soviética. Call of Duty: Black Ops já está disponível com versões para PC, PlayStation 3 e Xbox 360. ";

	arr[1] = "Recentemente, a Sony e a Guerrilla Games anunciaram o beta multiplayer de Killzone 3 apenas alguns jogadores da PlayStation Plus e integrantes da imprensa especializada.Na semana passada, as companhias confirmaram o lançamento da versão para testes aos assinantes da PlayStation Plus. Para participar do beta, os membros precisam apenas fazer o download do game.A trama de Killzone 3 vai começar logo após o final do segundo game e o jogador poderá assumir o comando de Sev e Rico. O título também fará analogia ao período do regime nazista. Desta vez, ficará bem claro o desprezo dos Helghasts em relação aos humanos. Além disso, a cultura dos inimigos será mais explorada e eles terão um dialeto próprio.Vale lembrar que o game terá suporte à tecnologia 3D e, recentemente, a Sony confirmou que Killzone 3 será traduzido para o português, incluindo diálogos dublados, legendas e outras funções do jogo.Killzone 3 será lançado dia 22 de fevereiro de 2011 nos Estados Unidos.";
	//PLAYSTATION MOVE
	arr[2] = "Segundo Ricardo Filó, gerente de Produtos da Playstation Division do Brasil, o Playstation Move deve estar disponível oficialmente no Brasil antes do Natal de 2010, embora não tenha especificado uma data. O controle baseado em movimentos, concorrente direto do Kinect da Microsoft e o Wii da Nintendo,  é o único que ainda não foi lançado oficialmente no país.O principal diferencial do Move, segundo Filó, é a maior precisão de movimentos, aliados aos bons gráficos que somente o Playstation 3 é capaz de oferecer. O valor do produto no Brasil ainda não foi divulgado, mas já foi confirmada a presença de ao menos cinco títulos compatíveis em seu lançamento – porém, nenhum nome foi especificado.Outra novidade fica por conta da possível chegada de uma versão nacional da Playstation Network. Seguindo o lançamento da Xbox LIVE brasileira pela Microsoft, Filó afirma que Sony tem grande interesse em estabelecer sua rede online no país. Porém, assim como o lançamento do Move, não foi especificada uma data para quando isso possa acontecer.";
	//LARA CROFT
	arr[3] = "Com enorme atraso, a Crystal Dynamics finalmente disponibilizou o patch que adiciona o modo cooperativo online a Lara Croft and the Guardian of Light. A atualização está disponível desde o mês passado no Xbox 360 e ainda está sem data para sair no PC.";
	//IPAD
	arr[4] = "Alguns jogos se tornam clássicos e, por mais evoluída que seja a tecnologia alguns anos à frente, sempre há os saudosistas que querem os jogos antigos. O Space Quest: The Sarien Encounter, da Sierra On-Line (originalmente para PCs), está chegando ao iPad, em uma versão criada por um fã.O que o torna mais interessante é que o jogo não é um aplicativo; é feito para jogar em um navegador. Basta carregar a URL http://ipad.sarien.net no Safari Mobile, salvar em um Favorito na tela inicial e pronto! Você está a um passo de jogar um verdadeiro clássico de 1987.O Space Quest no iPad foi desenvolvido por Martin Kool. O Touch Arcade testou o jogo e ficou impressionado com a semelhança do jogo no iPad com o original. Os gráficos podem assustar os mais novos, que estão acostumados a v er jogos em 3D, mas são ótimos para os que jogaram SQ nos anos 1980.A única crítica do site foi a falta de sons presentes no original, um desafio para jogos feitos para o navegador. Fãs do jogo devem visitar os fóruns da Sarien.net, onde Martin está pedindo opiniões sobre um possível aplicativo oficial da série lançada pela Sierra.";
	
	//CONTEUDO TíTULOS
	var arrN = new Array(5);
	arrN[0] = "Call of Duty: Black Ops";
	arrN[1] = "Killzone 3";
	arrN[2] = "PlayStation Move";
	arrN[3] = "Lara Croft Online";
	arrN[4] = "iPad Jogos";
		
	//INSERE O CONTEUDO
	document.getElementById('txt').innerHTML = arr[inf];
	//INSERE O TíTULO
	document.getElementById('noticias2_t').innerHTML = arrN[tit];
}
//window.onload = insereTexto('0','0');