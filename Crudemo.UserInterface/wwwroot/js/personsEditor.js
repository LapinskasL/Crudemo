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
}