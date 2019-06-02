<?php 

include('sqlInstruction.class.php');
$obj = new SqlInstruction;
$conSql = $obj->conexaoSql();


$arr = array('Mudando de console vale a pena?','Gerenciando jogos em lan','Como fazer um bom jogo','Jogos que nos atualizam','Jogos digitais, o futuro da computação');

$obj->defineEntidade('artigo');

for($i=1;$i<=5;$i++){


$obj->updateSql("LINK_ART = '".$obj->formataUrl($arr[$i-1])."'","COD_ART = ".$i."");

}

echo "FINALIZADO";

/*
$arr = array('Grand Chase poderá ser vendido para clientes','Final Fantasy de volta aos consoles','Metal slug: nova saga e lancada','Nija Ex não será vendido na alemanha',
'Microsoft lança patch para xbox360','EA lança o mais novo game do mundo NFS','Google decide entrar na era dos Games','World warcraft nao sera mais atualizado',
'Alemanha proibe alguns jogos','Imagens inéditas de Uncharted 3: Drake\'s Deception',
'Leia a análise de F1 2011 para PC e consoles','Ultimate Marvel Vs Capcom 3 ganha novas imagens em','Novas imagens de Yakuza Black Panther 2 para PSP',
'Modern Warfare 3 pode vir para feira de games em','Veja a lista com os jogos que chegam esta semana','Expansão de inFamous 2 disponível dia 25 de outubr',
'Warhammer: Space Marine','Syndicate','Resistance 3','Resident Evil 5 é criticado seriamente nos países','Sony vai cobrar por acesso a modo online de jogos',
'PS3 vai exibir imagens em ultra resolução,diz Sony','Counter-Strike é mais esporte do que violência, di','Novo extra para Gears of War 3 chega em novembro c',
'WiiClube Gasto com games nos EUA se mantém estável','Canal de vídeos do 3DS terá filmes e vídeos da Dre','Com novo nome Yakuza Of the End chega aos EUA',
'Live brasileiro oferece Gears of War 2','Estúdio brasileiro cria jogo online de Formula 1');	

$obj->defineEntidade('noticias');

for($i=1;$i<=29;$i++){


$obj->updateSql("LINK_NOT = '".$obj->formataUrl($arr[$i-1])."'","COD_NOT = ".$i."");

}

echo "FINALIZADO";*/