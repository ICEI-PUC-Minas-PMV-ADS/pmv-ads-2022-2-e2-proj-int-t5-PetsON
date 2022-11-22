
$(function () {
    $('.carousel').carousel({
        interval: 2000
    });
    $('.carousel-control.right').trigger('click');
});

$(document).ready(function () {
    $("#btnFetch").click(function () {

        // disable button
        $(this).prop("disabled", true);
        // add spinner to button
        $(this).html(
            `<span class="spinner-border spinner-border-sm" role="status" aria-hidden="true"></span>&nbsp;Login`
        );
    });
});

$(document).ready(function () {

    var erro = document.getElementById("erroLogin");
    var email = document.getElementById("email").value == "";
    var senha = document.getElementById("senha").value == "";

    $("#btnFetchEntrar").click(function () {

        if (email && senha) {

            return
            $(this).prop("disabled", true);
            $(this).html(
                `<button id="erroLogin" type="submit" class="btn btn-warning">&nbsp;&nbsp;Entrar</a>`
            );
            range.selectNode(erro);

        } else {

            $(this).prop("disabled", true);
            $(this).html(
                `<span class="spinner-border spinner-border-sm" role="status" aria-hidden="true"></span>&nbsp;Entrar`
            );
        }
        return
       
    });
}); 







   

$(document).ready(function () {
    $("#btnFetchCadastro").click(function () {
        // disable button
        $(this).prop("disabled", true);
        // add spinner to button
        $(this).html(
            `<span class="spinner-border spinner-border-sm" role="status" aria-hidden="true"></span>&nbsp;Cadastrar`
        );
    });
});






