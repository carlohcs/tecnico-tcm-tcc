<!-- xxxx Rodapé xxxx -->
		<div id="footer">
		
			<!-- Parceiros -->

			<div id="partners">
				<a href="http://www.tibiaproject.xpg.com.br"><img class="parce" src="img/parceiros/tibia_p.gif" alt="Tibia Project"/></a>
				<a href="http://www.gamestnt.com"><img class="parce" src="img/parceiros/gtnt.gif" alt="Tibia Project"/></a>
				<a href="http://www.wowproject.com.br"><img class="parce" src="img/parceiros/wp.gif" alt="Tibia Project"/></a>
				<a href="http://www.voujogar.com.br"><img class="parce" src="img/parceiros/vjogar.gif" alt="Tibia Project"/></a>
				<a href="http://www.nintendoinvaders.com"><img class="parce" src="img/parceiros/n_inv.gif" alt="Tibia Project"/></a>
			</div>

			<div id="msg_footer">
				<p class="team">JOI&amp;D  2010-2011<!--- <a href="termos-de-uso"/>Termos de uso</a>-->. Obrigado pela visita!</p>
				<p>Proibida a cópia parcial ou total do conteúdo do site. Todos os direitos reservados.</p>
				<p class="team">Website desenvolvido por <a href="loovus.html"/>Loovus</a></p>
			</div>
			
		</div> 

	</div>

	<!-- Volta ao topo -->
	<p><a href="<?php echo $_GET['page'].'#wrapper'; ?>" id="backTop"></a></p>
	<input type="hidden" value="<?php if($verificaSess == true) echo $_SESSION['sessaoUsuario']['codigo']; ?>" id="codUsuSess" />
	
</body>

</html>