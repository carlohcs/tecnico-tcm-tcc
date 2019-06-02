function init_dw_Scroll1() {
    var wndo = new dw_scrollObj('bg_news03', 'resume_news');
    wndo.setUpScrollControls('bg_news01');
}
if ( dw_scrollObj.isSupported() ) {
	dw_Event.add( window, 'load', init_dw_Scroll1);
}