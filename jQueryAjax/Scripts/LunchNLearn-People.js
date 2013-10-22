$(document).ready(function () {
    
    $('#SavePerson').click(function () {
        var newGuy = $('#newPersonForm').serialize();
        addPerson(newGuy);
        $('#newPersonModal').modal('hide');
    });
    
});

function showModal() {
    $('#newPersonModal').modal();
}

function removePerson(id) {
    var person = {};
   // person.id = rowId;
    
    $.ajax({
        type: 'POST',
        url: '/People/Remove',
        data: id,
        success: function (response) {
            if (response.IsError) {
                alert('Error: ' + response.Message.Text);
            } else {
                $('#theHouse').html(response.Message);
            }
        },
        error: function (response) {
            alert('Things have gone horribly wrong.');
        }
    });
}

function addPerson(person) {
    
    $.ajax({
        type: 'POST',
        url: '/People/Add',
        data: person,
        success: function (response) {
            if (response.IsError) {
                alert('Error: ' + response.Message.Text);
            } else {
                $('#theHouse').html(response.Message);
            }
        },
        error: function (response) {
            alert('Things have gone horribly wrong.');
        }
    });
}