function InitializePersonsDataTable() {
    let table = $('#personsTable').DataTable({
        ajax: {
            url: '/persons/getPersons',
            type: 'GET'
        },
        columns: [
            { data: "lastName" },
            { data: "firstName" },
            { data: "phoneNumber" },
            { data: "dateAdded"}
        ]
    });
    return table;
}

var tempHtmlForm = '<form> <div class="form-group"> <label for="formGroupExampleInput">Example label</label> <input type="text" class="form-control" id="formGroupExampleInput" placeholder="Example input"> </div> <div class="form-group"> <label for="formGroupExampleInput2">Another label</label> <input type="text" class="form-control" id="formGroupExampleInput2" placeholder="Another input"> </div> </form>';
function OpenCreateModal() {
    bootbox.dialog({
        title: 'Create User',
        size: 'small',
        message: tempHtmlForm,
        buttons: {
            submit: {
                label: 'Submit',
                className: 'btn-primary',
                callback: function () {
                    alert('submitted');
                }
            }
        }
    })
}