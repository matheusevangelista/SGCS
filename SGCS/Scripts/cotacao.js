var cotar = function () {

    var ClienteId = $('#ClienteId').val();
    var Modelo = $('#Veiculo_Modelo').val();
    var Ano = $('#Veiculo_Ano').val();
    var Tipo = $('#Veiculo_Tipo').val();

    $.post("/api/Cotacao", { ClienteId: ClienteId, Modelo: Modelo, Ano: Ano, Tipo: Tipo }, function (data) {

        $("#ValorCotacao").val(data);

        console.log(data);

        calculaParcelas();

    }, 'json');

}

var calculaParcelas = function () {

    var valorCotacao = $("#ValorCotacao").val();
    var entrada = $("#Entrada").val();
    var parcelas = $("#NumeroPrestacoes").val();

    var valorRestante = valorCotacao - entrada;

    var valorParcelas = valorRestante / parcelas;

    $("#ValorPrestacoes").val(valorParcelas.toFixed(2));


}