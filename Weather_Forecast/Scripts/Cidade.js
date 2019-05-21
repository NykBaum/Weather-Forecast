function SalvarCidade() {

    if ($("#nome").val().length < 1)
        return false;

    var nome = $("#nome").val();

    var url = "/Home/Create";

    var token = $('input[name="__RequestVerificationToken"]').val();
    var tokenadr = $('form[action="/Home/Create"] input[name="__RequestVerificationToken"]').val();

    var headers = {};
    var headersadr = {};
    headers['__RequestVerificationToken'] = token;
    headersadr['__RequestVerificationToken'] = tokenadr;

    $.ajax({
        url: url,
        type: "POST",
        datatype: "JSON",
        headers: headersadr,
        data: { id: 0, nome: nome, codigo: 0, __RequestVerificationToken: token },
        success: function (data) {
            alert(data.mensagem);
            document.getElementById('nome').value = '';
        }
    })
}