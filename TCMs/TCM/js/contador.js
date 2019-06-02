		//Função que define o Cookie, com os parametros nome, valor e local
			function defineCookie(nome, valor){
				var cookieJoid = nome + "=" + escape(valor);
				document.cookie = cookieJoid;
			}
		//Função que busca o cookie pelo nome	
			function buscaCookie(nome){
			//propriedades do cookie
				var cook = document.cookie;
				var ValorIn = nome + "=";
				var inic = cook.indexOf(";" + ValorIn);
				if(inic == -1){
					inic = cook.indexOf(ValorIn);	
				if(inic !=0) 
				return null; 
				}else
					inic+=2;
					var fim = document.cookie.indexOf(";", inic);
				if(fim == -1) 
				fim = cook.length;
					return unescape(cook.substring(inic + ValorIn.length, fim));	
			}	
			function cont(){
				var visitas; 
				
				if(!(visitas = buscaCookie('Joid')))
					visitas = 0;
					visitas++;
					defineCookie('Joid', visitas);
					document.getElementById('ns').innerHTML = visitas;
					if(visitas == 60){
				visitas = 0;
				}
			}
			window.onload = cont;