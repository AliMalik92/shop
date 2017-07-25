$(document).ready(function() {
    $("body").fadeIn(400);

$('#myCarousel').carousel()
$('#newProductCar').carousel()

/* Home page item price animation */
$('.thumbnail').mouseenter(function() {
   $(this).children('.zoomTool').fadeIn();
});

$('.thumbnail').mouseleave(function() {
	$(this).children('.zoomTool').fadeOut();
});

// Show/Hide Sticky "Go to top" button
	$(window).scroll(function(){
		if($(this).scrollTop()>200){
			$(".gotop").fadeIn(200);
		}
		else{
			$(".gotop").fadeOut(200);
		}
	});
// Scroll Page to Top when clicked on "go to top" button
	$(".gotop").click(function(event){
		event.preventDefault();

		$.scrollTo('#gototop', 1500, {
        	easing: 'easeOutCubic'
        });
	});

});

function addTochart(itemid) {
    alert("hi");
    var ajaxRequest = $.ajax({
        
        type: "GET",
        url: "http://localhost:42285/api/shopApi/addCart?itemid=" + itemid,
        contentType: "application/json;charset=utf-8",
        processData: false,
        success: function (resp) {
            alert("Add Cart Successfully");
            window.setTimeout(function () { window.location = ""; }, 1000);
        },
        error: function (resp) {
            alert("Error Occured");
        }
    });
}

function register() {
    alert("ali");
    var fName = document.getElementById("FirstName").value;
    var lName = document.getElementById("LastName").value;
    var email = document.getElementById("Email").value;
    var pass = document.getElementById("Password").value;
    var dof = document.getElementById("DateOfBirth").value;
    var User = {
        "FirstName": fName,
        "LastName": lName,
        "Email": email,
        "Password": pass,
        "DateOfBirth":dof
    }
    var ajaxRequest = $.ajax({
        type: "POST",
        url: "http://localhost:2051/api/WebApi/AddUser",
        contentType: "application/json;charset=utf-8",
        processData: false,
        data: JSON.stringify(User),
        success: function (resp) {
            alert("User Add Successfully");
            window.setTimeout(function () { window.location = "http://localhost:2051/shopping/Index"; }, 1000);
        },
        error: function (resp) {
            alert("Error Occured");
        }
    });
}