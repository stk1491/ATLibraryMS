$(document).ready(function () {
    $('#category').attr('disabled', true);
    $('#booktitle').attr('disabled', true);
    LoadCategory();

    $('#category').change(function() {
        var CatID = $(this).val();
        if (CatID > 0) {
            LoadBookTitle(CatID);
        }
        else {
            alert("Select Book Title");
            $('#category').attr('disabled', true);
            $('#booktitle').attr('disabled', true);
            $('#category').append('<option>--Select Category--</option>');
            $('#booktitle').append('<option>--Select Book--</option>');
        }
    });
});

function LoadCategory() {
    $('#category').empty();
    $.ajax({
        url: '/Cascading/Categories',
        success: function (response) {
            if (response != null && response != undefined && response.length > 0) {
                $('#category').attr('disabled', false);
                $('#category').append('<option>--Select Category--</option>');
                $('#booktitle').append('<option>--Select Book--</option>');
                $.each(response, function (i, data) {

                    $('#category').append('<option value=' + data.id + '>' + data.Name + '</option>');
                });
            }
            else {
                $('#category').attr('disabled', true);
                $('#booktitle').attr('disabled', true)
                $('#category').append('<option>--Category Not Available--</option>');
                $('#booktitle').append('<option>--Books Not Available--</option>');                    ;
            }
        },
        error: function (error) {
            alert(error);
        }
    });

    function LoadBookTitle(CatID) {
        $('#category').empty();
        $.ajax({
            url: '/Cascading/Categories?Id=' + CatID,
            success: function (response) {
                if (response != null && response != undefined && response.length > 0) {
                    $('#booktitle').attr('disabled', false);
                    $('#category').append('<option>--Select Category--</option>');
                    $('#booktitle').append('<option>--Select Book--</option>');
                    $.each(response, function (i, data) {

                        $('#booktitle').append('<option value=' + data.id + '>' + data.Name + '</option>');
                    });
                }
                else {
                    $('#category').attr('disabled', true);
                    $('#booktitle').attr('disabled', true)
                    $('#booktitle').append('<option>--Books Not Available--</option>');;
                }
            },
            error: function (error) {
                alert(error);
            }
        });
}