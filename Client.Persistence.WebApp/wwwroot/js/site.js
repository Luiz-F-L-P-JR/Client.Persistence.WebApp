// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(document).ready(function () {
    $.fn.dataTable.ext.errMode = 'none';

    $('#client-table').DataTable({
        columnDefs: [
            {
                targets: -1,
                className: 'dt-body-right'
            }
        ]
    });
});

$(document).ready(function () {
    $.fn.dataTable.ext.errMode = 'none';
    
    $('#publicArea-table').DataTable({
        columnDefs: [
            {
                targets: -1,
                className: 'dt-body-right'
            }
        ]
    });
}); 

