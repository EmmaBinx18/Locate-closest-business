$(document).ready(function () {  
    $("#openSearchModal").click(function () { 
        $("#searchModal").modal('show');  
    });  
    
    $("#openRegisterBusinessModal").click(function () { 
        $("#registerBusinessModal").modal('show');  
    });
    
    $("#step1 .nextButton").click(function() {
        $("#step1").css("display", "none");
        $("#step2").css("display", "block");
    });

    $("#step2 .nextButton").click(function() {
        $("#step2").css("display", "none");
        $("#step3").css("display", "block");
    });
});
