let valueId = document.querySelector('#zodiacoResult')
let value = document.querySelector('#zodiacoResult').textContent
let e = document.createElement('div')
e.style.cssText += 'width: 50px;'

switch (value) {
    case "Aries":
        e.innerHTML = '<img class="w-100" src="https://es.calcuworld.com/wp-content/themes/twentytwelve-child/images/zodiaco/aries.png">'
        break;
    case "Piscis":
        e.innerHTML = '<img class="w-100" src="https://es.calcuworld.com/wp-content/themes/twentytwelve-child/images/zodiaco/piscis.png">'
        break;
    case "Tauro":
        e.innerHTML = '<img class="w-100" src="https://es.calcuworld.com/wp-content/themes/twentytwelve-child/images/zodiaco/tauro.png">'
        break;
    case "Géminis":
        e.innerHTML = '<img class="w-100" src="https://es.calcuworld.com/wp-content/themes/twentytwelve-child/images/zodiaco/geminis.png">'
        break;
    case "Cáncer":
        e.innerHTML = '<img class="w-100" src="https://es.calcuworld.com/wp-content/themes/twentytwelve-child/images/zodiaco/cancer.png">'
        break;
    case "Leo":
        e.innerHTML = '<img class="w-100" src="https://es.calcuworld.com/wp-content/themes/twentytwelve-child/images/zodiaco/leo.png">'
        break;
    case "Virgo":
        e.innerHTML = '<img class="w-100" src="https://es.calcuworld.com/wp-content/themes/twentytwelve-child/images/zodiaco/virgo.png">'
        break;
    case "Libra":
        e.innerHTML = '<img class="w-100" src="https://es.calcuworld.com/wp-content/themes/twentytwelve-child/images/zodiaco/libra.png">'
        break;
    case "Escorpio":
        e.innerHTML = '<img class="w-100" src="https://es.calcuworld.com/wp-content/themes/twentytwelve-child/images/zodiaco/escorpio.png">'
        break;
    case "Sagitario":
        e.innerHTML = '<img class="w-100" src="https://es.calcuworld.com/wp-content/themes/twentytwelve-child/images/zodiaco/sagitario.png">'
        break;
    case "Capricornio":
        e.innerHTML = '<img class="w-100" src="https://es.calcuworld.com/wp-content/themes/twentytwelve-child/images/zodiaco/capricornio.png">'
        break;
    case "Acuario":
        e.innerHTML = '<img class="w-100" src="https://es.calcuworld.com/wp-content/themes/twentytwelve-child/images/zodiaco/acuario.png">'
        break;


}
valueId.parentNode.appendChild(e)
