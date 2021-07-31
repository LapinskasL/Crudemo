function InitializePersonsDataTable() {
    let table = $('#personsTable').DataTable({
        rowCallback: function (row, person) {
            $(row).off().on('click', function () {
                OpenUpdateModal(person);
            });
        },
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

function AjaxGetUpsertPersonFormPartial(person = null) {
    var ajaxCall = $.ajax({
        type: "GET",
        url: "/persons/getUpsertPersonFormPartial",
        data: person
    });
    return ajaxCall;
}

function AjaxUpsertPerson() {
    var ajaxCall = $.ajax({
        type: "POST",
        url: "/persons/upsertPerson",
        data: $('#upsertForm').serialize()
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
                label: 'Create',
                className: 'btn-primary',
                callback: function () {
                    AjaxUpsertPerson()
                        .done(function (response) {
                            toastr.success("Person created.");
                            ReloadPersonsTable();
                        });
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

function AjaxDeletePerson() {
    var ajaxCall = $.ajax({
        type: "POST",
        url: "/persons/deletePerson",
        data: $('#upsertForm').serialize()
    });
    return ajaxCall;
}

function UpdateModal(formHtml) {
    bootbox.dialog({
        title: 'Person',
        size: 'small',
        message: formHtml,
        buttons: {
            delete: {
                label: 'Delete',
                className: 'btn-danger',
                callback: function () {
                    AjaxDeletePerson()
                        .done(function (response) {
                            toastr.success("Person deleted.");
                            ReloadPersonsTable();
                        });
                }
            },
            submit: {
                label: 'Update',
                className: 'btn-primary',
                callback: function () {
                    AjaxUpsertPerson()
                        .done(function (response) {
                            toastr.success("Person updated.");
                            ReloadPersonsTable();
                        });
                }
            }
        }
    });
}

function ReloadPersonsTable() {
    $('#personsTable').DataTable().ajax.reload(null, false);
}

function OpenUpdateModal(person) {
    AjaxGetUpsertPersonFormPartial(person)
        .done(function (partialView) {
            UpdateModal(partialView);
        });
}