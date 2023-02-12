﻿$('#roomAdd').on('submit', function (e) {
    if (AddRoomValidation() == false) {
        AddRoomValidation();
        e.preventDefault();
    }

});

function AddRoomValidation() {
    var validate = true;
    var inputRoomNumber = $('#roomNumber').val();
    var inputRoomSize = $('#roomSize').val();
    var inputRoomRent = $('#roomRent').val();
    
    /*var inputValidation = new RegExp(/^[0-9]$/);*/
    $('.Error').remove();

    if (inputRoomNumber.length < 1) {
        $('#roomNumber').after('<span class="Error" style="color:red">This field is required.</span>');

        validate = false;
    }

    if (inputRoomSize.length < 1) {
        $('#roomSize').after('<span class="Error" style="color:red">This field is required.</span>');

        validate = false;
    }

    if (inputRoomRent.length < 1) {
        $('#roomRent').after('<span class="Error" style="color:red">This field is required.</span>');

        validate = false;
    }

    
    

    return validate
}