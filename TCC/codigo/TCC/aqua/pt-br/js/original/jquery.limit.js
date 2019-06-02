(function($){ 
     $.fn.extend({  
         limit: function(limit,element) {
			
			var interval;
			var self = $(this);
			
			$(this).focus(function(){
				interval = window.setInterval(substring,100);
				$(element).css('display', 'block');
			});
			
			$(this).blur(function(){
				clearInterval(interval);
				substring();
			});
			
			function substring(){
				length = $(self).val().length;
				if(element){
					var el = (limit-length<=0) ? '0' : limit-length;
					$(element).html("Faltam " + el + " caracteres.");
				}	
				if(length > limit)
					$(self).val($(self).val().substring(0,limit));
			}
			
			substring();
			
        } 
    }); 
})(jQuery);