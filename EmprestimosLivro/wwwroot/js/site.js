$(document).ready(function () {
    $('#Emprestimos').DataTable({
        language: {
            "decimal": "",
            "emptyTable": "Sem registrados encontrados na tabela",
            "info": "Mostrando _START_ to _END_ of _TOTAL_ registros",
            "infoEmpty": "Mostrando 0 a 0 de 0 registros",
            "infoFiltered": "(filtered from _MAX_ total entries)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Mostrar _MENU_ registro",
            "loadingRecords": "Carregando...",
            "processing": "",
            "search": "Procurar:",
            "zeroRecords": "Sem registros encontrados",
            "paginate": {
                "first": "Primeiro",
                "last": "Último",
                "next": "Próximo",
                "previous": "Anterior"
            },
            "aria": {
                "orderable": "Order by this column",
                "orderableReverse": "Reverse order this column"
            }
        }
    });

    setTimeout(function () {
        $(".alert").fadeOut("slow", function () {
            $(this).alert('close');
        })
    }, 5000)
})
