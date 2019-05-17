function SalvarCidade() {

    var nome = $("#nome").val();
    
    var codigo = $("#codigo").val();

    var url = "/Home/Create";

    $.ajax({
        url: url,
        type: "POST",
        datatype: "JSON",
        data: { id: 0, nome: nome, codigo: codigo},
        success: function (data) {
            
        }
    })
}