function insereTexto(inf,tit){
	/*var par = document.createElement("p");
	par.setAttribute('id', 'txt');
	var local = document.getElementById('int2');
	local.appendChild(par);*/
	var arr = new Array(5);
	//CONTEUDO NOTICIA
	//CALL OF DUTY
	arr[0] = "Ap�s superar o recorde de vendas antecipadas e de compras em 24h, Call of Duty: Black Ops consegue a fa�anha de arrecadar US$ 650 milh�es em apenas cinco dias e deixa para tr�s a marca conquistada por Call of Duty: Modern Warfare 2. De acordo com a Activision, o game superou a arrecada��o de Modern Warfare 2 em cerca US$ 100 milh�es nos primeiros dias de venda. A produtora afirma que mais de 2,6 milh�es de jogadores j� entraram em confronto e a jogatina on-line soma quase 6 milh�es de horas no modo multiplayer. Em Call of Duty: Black Ops, o jogador enfrenta miss�es secretas que ocorreram durante a Guerra Fria, per�odo em que o mundo estava dividido em duas grandes pot�ncias: Estados Unidos e a Uni�o Sovi�tica. Call of Duty: Black Ops j� est� dispon�vel com vers�es para PC, PlayStation 3 e Xbox 360. ";

	arr[1] = "Recentemente, a Sony e a Guerrilla Games anunciaram o beta multiplayer de Killzone 3 apenas alguns jogadores da PlayStation Plus e integrantes da imprensa especializada.Na semana passada, as companhias confirmaram o lan�amento da vers�o para testes aos assinantes da PlayStation Plus. Para participar do beta, os membros precisam apenas fazer o download do game.A trama de Killzone 3 vai come�ar logo ap�s o final do segundo game e o jogador poder� assumir o comando de Sev e Rico. O t�tulo tamb�m far� analogia ao per�odo do regime nazista. Desta vez, ficar� bem claro o desprezo dos Helghasts em rela��o aos humanos. Al�m disso, a cultura dos inimigos ser� mais explorada e eles ter�o um dialeto pr�prio.Vale lembrar que o game ter� suporte � tecnologia 3D e, recentemente, a Sony confirmou que Killzone 3 ser� traduzido para o portugu�s, incluindo di�logos dublados, legendas e outras fun��es do jogo.Killzone 3 ser� lan�ado dia 22 de fevereiro de 2011 nos Estados Unidos.";
	//PLAYSTATION MOVE
	arr[2] = "Segundo Ricardo Fil�, gerente de Produtos da Playstation Division do Brasil, o Playstation Move deve estar dispon�vel oficialmente no Brasil antes do Natal de 2010, embora n�o tenha especificado uma data. O controle baseado em movimentos, concorrente direto do Kinect da Microsoft e o Wii da Nintendo,  � o �nico que ainda n�o foi lan�ado oficialmente no pa�s.O principal diferencial do Move, segundo Fil�, � a maior precis�o de movimentos, aliados aos bons gr�ficos que somente o Playstation 3 � capaz de oferecer. O valor do produto no Brasil ainda n�o foi divulgado, mas j� foi confirmada a presen�a de ao menos cinco t�tulos compat�veis em seu lan�amento � por�m, nenhum nome foi especificado.Outra novidade fica por conta da poss�vel chegada de uma vers�o nacional da Playstation Network. Seguindo o lan�amento da Xbox LIVE brasileira pela Microsoft, Fil� afirma que Sony tem grande interesse em estabelecer sua rede online no pa�s. Por�m, assim como o lan�amento do Move, n�o foi especificada uma data para quando isso possa acontecer.";
	//LARA CROFT
	arr[3] = "Com enorme atraso, a Crystal Dynamics finalmente disponibilizou o patch que adiciona o modo cooperativo online a Lara Croft and the Guardian of Light. A atualiza��o est� dispon�vel desde o m�s passado no Xbox 360 e ainda est� sem data para sair no PC.";
	//IPAD
	arr[4] = "Alguns jogos se tornam cl�ssicos e, por mais evolu�da que seja a tecnologia alguns anos � frente, sempre h� os saudosistas que querem os jogos antigos. O Space Quest: The Sarien Encounter, da Sierra On-Line (originalmente para PCs), est� chegando ao iPad, em uma vers�o criada por um f�.O que o torna mais interessante � que o jogo n�o � um aplicativo; � feito para jogar em um navegador. Basta carregar a URL http://ipad.sarien.net no Safari Mobile, salvar em um Favorito na tela inicial e pronto! Voc� est� a um passo de jogar um verdadeiro cl�ssico de 1987.O Space Quest no iPad foi desenvolvido por Martin Kool. O Touch Arcade testou o jogo e ficou impressionado com a semelhan�a do jogo no iPad com o original. Os gr�ficos podem assustar os mais novos, que est�o acostumados a v er jogos em 3D, mas s�o �timos para os que jogaram SQ nos anos 1980.A �nica cr�tica do site foi a falta de sons presentes no original, um desafio para jogos feitos para o navegador. F�s do jogo devem visitar os f�runs da Sarien.net, onde Martin est� pedindo opini�es sobre um poss�vel aplicativo oficial da s�rie lan�ada pela Sierra.";
	
	//CONTEUDO T�TULOS
	var arrN = new Array(5);
	arrN[0] = "Call of Duty: Black Ops";
	arrN[1] = "Killzone 3";
	arrN[2] = "PlayStation Move";
	arrN[3] = "Lara Croft Online";
	arrN[4] = "iPad Jogos";
		
	//INSERE O CONTEUDO
	document.getElementById('txt').innerHTML = arr[inf];
	//INSERE O T�TULO
	document.getElementById('noticias2_t').innerHTML = arrN[tit];
}
//window.onload = insereTexto('0','0');