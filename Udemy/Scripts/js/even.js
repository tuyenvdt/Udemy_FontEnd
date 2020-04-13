// var name = prompt("Nhap ten cua ban !");
// alert("Chào : " + name);




$(function() {
	// dau tien la chua co gi hien ra 

	$('.formdangki').fadeOut();

	$('.formdangnhap').fadeOut();
	//kich vao nut thi chuyen sang form khac
	$('#dangnhaptaikhoan').on('click',function() {

		$('.formdangnhap').fadeToggle();
		$('.formdangki').fadeOut();
	});

	$('#dangkitaikhoan').on('click',function() {
		$('.formdangki').fadeToggle();
		$('.formdangnhap').fadeOut();

	});

	$('.cacngonngu').hide();
	$('.macdinh').click(function(){
  		$('.cacngonngu').toggle();
	});
	$('.summary-content').hide();
	$('.slick-slide').mouseover(function(){
		$('.summary-content').show();
		$('.summary-content').offset({top:300,left:200});
	});
	$('.slick-slide').mouseout(function(){
		$('.summary-content').hide();
	});
	$('#seemore').click(function () {
	    $('.what-learn').toggleClass('full');
	})

});