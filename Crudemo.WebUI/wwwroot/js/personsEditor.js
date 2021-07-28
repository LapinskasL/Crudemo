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
            { data: "dateAdded" }
        ]
    });
    return table;
}

function AjaxGetUpsertPersonFormPartial(personId = null) {
    var ajaxCall = $.ajax({
        type: "GET",
        url: "/persons/GetUpsertPersonFormPartial",
        data: {
            personId: personId
        }
    });
    return ajaxCall;
}

function CreateModal(formHtml) {
    bootbox.dialog({
        title: 'Person',
        size: 'small',
        message: formHtml,
        buttons: {
            submit: {
                label: 'Submit',
                className: 'btn-primary',
                callback: function () {
                    alert('submitted');
                }
            }
        }
    });
}

function OpenCreateModal() {
    AjaxGetUpsertPersonFormPartial()
        .done(function (partialView) {
            CreateModal(partialView);
        });
}