var cotar = function () {

    var ClienteId = $('#ClienteId').val();
    var Modelo = $('#Veiculo_Modelo').val();
    var Ano = $('#Veiculo_Ano').val();
    var Tipo = $('#Veiculo_Tipo').val();

    $.post("/api/Cotacao", { ClienteId: ClienteId, Modelo: Modelo, Ano: Ano, Tipo: Tipo }, function (data) {

        console.log(data);

    }, 'json');

}