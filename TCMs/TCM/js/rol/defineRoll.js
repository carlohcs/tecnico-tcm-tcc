function init_dw_Scroll1() {
    var wndo = new dw_scrollObj('ex1', 'int1');
    wndo.setUpScrollControls('btrolagem');
}
function init_dw_Scroll2() {
    var wndo = new dw_scrollObj('ex2', 'int2');
    wndo.setUpScrollControls('btrolagem2');
}
if ( dw_scrollObj.isSupported() ) {
	dw_Event.add( window, 'load', init_dw_Scroll1);
    dw_Event.add( window, 'load', init_dw_Scroll2);
}