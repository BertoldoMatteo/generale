function conversione() {
    const num=parseInt(document.getElementById("num").value);
    const select = document.getElementById("select").value;
    let risposta;
    switch(select){
        case "1":
            risposta=parseInt(num,2);
        break;
        case "2":
            risposta=num.toString(2)
        break;
        case "3":
            risposta=num.toString(16).toUpperCase()
        break;
        default:
            risposta="Errore";
    }
    document.getElementById("risposta").innerHTML=risposta;
  
}