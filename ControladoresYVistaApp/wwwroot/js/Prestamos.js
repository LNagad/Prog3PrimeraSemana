
let i = document.querySelector("#typeP").children
let interes = document.querySelector("#interestP")

document.querySelector("#typeP").addEventListener("change", (event) => {

    let value = event.target.value

    switch (value) {
        case "0": interes.value = 0
            break;
        case "1": interes.value = 22;
            break;
        case "2": interes.value = 12
            break;
        case "3": interes.value = 8
            break;
        default:
            interes.value = 0
            break;
    }
});