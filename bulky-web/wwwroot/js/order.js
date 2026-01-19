$(document).ready(function () {
    $('#tblData').DataTable({
        "ajax": {
            "url": "/Admin/Order/GetAll",
            "dataSrc": "data"
        },
        "columns": [
            { "data": "id", "width": "15%" },
            { "data": "name", "width": "15%" },
            { "data": "phoneNumber", "width": "15%" },
            { "data": "applicationUser.email", "width": "15%" },
            { "data": "orderStatus", "width": "15%" },
            { "data": "orderTotal", "width": "15%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                        <div class="text-center">
                            <a href="/Admin/Order/Details?orderId=${data}" class="btn btn-success mx-2">
                                <i class="bi bi-pencil-square"></i> 
                            </a>
                           
                        </div>`;
                },
                "width": "25%"
            }
        ]
    });
});


