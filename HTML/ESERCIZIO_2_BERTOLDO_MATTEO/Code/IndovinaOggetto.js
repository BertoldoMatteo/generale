function Indovina() {
    const com=document.getElementById("text").value;
    const select = document.getElementById("select").value;
    const ogg="Wasabi";
    let risposta;
    switch(select){
        case "1":
            if(com==ogg){
                risposta="Congratulazioni hai vinto";
            }else{
                risposta="Indizio: forma irregolare verde, solitamente si vede in un ristorante cinese";
            }
        break;
        case "2":
            if(com==ogg){
                risposta="Congratulazioni hai vinto";
            }else{
                risposta="Indizio: pasta di consistenza cremosa e talvolta leggermente granulosa ";
            }
        break;
        case "3":
            if(com==ogg){
                risposta="Congratulazioni hai vinto";
            }else{
                risposta="Indizio: odore acre o pungente";
            }
        break;
        case "4":
            risposta="Mi dispiace hai perso, la risposta era Wasabi";
        break;
        default:
            risposta="Errore";
    }
    document.getElementById("risposta").innerHTML=risposta;
}