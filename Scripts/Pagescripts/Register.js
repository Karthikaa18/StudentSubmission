function register() {
    let firstname = $('#txtfirstname').val();
    let lastname = $('#txtlastname').val();
    let email = $('#txtemail').val();
    let gender = '';
    if ($('#rbtnmale').prop('checked') === true) {
        gender = "Male";
    }
    else {
        gender = "Female";
    }
    let password = $('#txtpassword').val();
    var url = "/Views/Admin/Register";
    var data = JSON.stringify({
        "firstname": firstname,
        "lastname": lastname,
        "email": email,
        "gender": gender,
        "password": password
    });
    $ajax({
        type: "POST",
        data: data,
        url: url,
        contentType: "application/json; charset=utf-8",
        dataType: 'json',
        success: function (result) {
            alert(result);
        },
        error: function (result) {
            alert(error);
        }
    });
}