//mask telefone
const tel = document.getElementById('tel') // Seletor do campo de telefone

tel.addEventListener('keypress', (e) => mascaraTelefone(e.target.value)) // Dispara quando digitado no campo
tel.addEventListener('change', (e) => mascaraTelefone(e.target.value)) // Dispara quando autocompletado o campo

const mascaraTelefone = (valor) => {
    valor = valor.replace(/\D/g, "")
    valor = valor.replace(/^(\d{2})(\d)/g, "($1) $2")
    valor = valor.replace(/(\d)(\d{4})$/, "$1-$2")
    tel.value = valor // Insere o(s) valor(es) no campo
}

// Mask CPF
window.addEventListener('load', () => {
    let a = document.getElementById('campoCpf');

    a.addEventListener("input", () => {
        let arr = a.value.split('');

        if (arr.length > 3 && arr[3] != ".") {
            arr.splice(3, 0, '.');
        }

        if (arr.length > 7 && arr[7] != ".") {
            arr.splice(7, 0, '.');
        }

        if (arr.length > 11 && arr[11] != "-") {
            arr.splice(11, 0, '-');
        }

        a.value = arr.join('');
    });
});