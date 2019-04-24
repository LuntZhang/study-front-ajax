/*衣服尺寸选择*/
$(function(){
	$(".pro_size li").click(function(){
		$(this).addClass("cur").siblings().removeClass("cur");
		$(this).parent().siblings("strong").text(  $(this).text() );
	})
})
/*数量和价格联动*/
$(function () {
    
    var $span = $(".tbDetailPrice strong");
	var price = $span.text();	
	$("#num_sort").change(function(){
	    var num = $(this).val();
		var amount = num * price;
		$(".pro_price strong").text(amount);
	}).change();
})
