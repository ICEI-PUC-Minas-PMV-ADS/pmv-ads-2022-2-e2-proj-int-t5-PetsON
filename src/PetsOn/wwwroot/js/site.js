﻿
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
    $("#btnFetchCadastro").click(function () {
        // disable button
        $(this).prop("disabled", true);
        // add spinner to button
        $(this).html(
            `<span class="spinner-border spinner-border-sm" role="status" aria-hidden="true"></span>&nbsp;Cadastrar`
        );
    });
});






