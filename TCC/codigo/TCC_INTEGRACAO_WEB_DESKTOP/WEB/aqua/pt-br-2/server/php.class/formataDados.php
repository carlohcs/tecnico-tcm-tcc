<?php 

include('sqlInstruction.class.php');
$obj = new SqlInstruction;
$conSql = $obj->conexaoSql();


$arr = array('Mudando de console vale a pena?','Gerenciando jogos em lan','Como fazer um bom jogo','Jogos que nos atualizam','Jogos digitais, o futuro da computa��o');

$obj->defineEntidade('artigo');

for($i=1;$i<=5;$i++){


$obj->updateSql("LINK_ART = '".$obj->formataUrl($arr[$i-1])."'","COD_ART = ".$i."");

}

echo "FINALIZADO";

/*
$arr = array('Grand Chase poder� ser vendido para clientes','Final Fantasy de volta aos consoles','Metal slug: nova saga e lancada','Nija Ex n�o ser� vendido na alemanha',
'Microsoft lan�a patch para xbox360','EA lan�a o mais novo game do mundo NFS','Google decide entrar na era dos Games','World warcraft nao sera mais atualizado',
'Alemanha proibe alguns jogos','Imagens in�ditas de Uncharted 3: Drake\'s Deception',
'Leia a an�lise de F1 2011 para PC e consoles','Ultimate Marvel Vs Capcom 3 ganha novas imagens em','Novas imagens de Yakuza Black Panther 2 para PSP',
'Modern Warfare 3 pode vir para feira de games em','Veja a lista com os jogos que chegam esta semana','Expans�o de inFamous 2 dispon�vel dia 25 de outubr',
'Warhammer: Space Marine','Syndicate','Resistance 3','Resident Evil 5 � criticado seriamente nos pa�ses','Sony vai cobrar por acesso a modo online de jogos',
'PS3 vai exibir imagens em ultra resolu��o,diz Sony','Counter-Strike � mais esporte do que viol�ncia, di','Novo extra para Gears of War 3 chega em novembro c',
'WiiClube Gasto com games nos EUA se mant�m est�vel','Canal de v�deos do 3DS ter� filmes e v�deos da Dre','Com novo nome Yakuza Of the End chega aos EUA',
'Live brasileiro oferece Gears of War 2','Est�dio brasileiro cria jogo online de Formula 1');	

$obj->defineEntidade('noticias');

for($i=1;$i<=29;$i++){


$obj->updateSql("LINK_NOT = '".$obj->formataUrl($arr[$i-1])."'","COD_NOT = ".$i."");

}

echo "FINALIZADO";*/