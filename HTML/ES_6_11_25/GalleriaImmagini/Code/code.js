function Esegui() {
    let img=document.getElementById("select").value;
    let tema=document.querySelector('input[name="tema"]:checked').value;
    let percorso="";

    switch(img){
        case "Montagna":
            percorso=tema=== "colore" ? "Img/montagna/colore.png" : "Img/montagna/bianco_nero.png";
            break;
        case "Mare":
            percorso=tema=== "colore" ? "Img/mare/colore.png" : "Img/mare/bianco_nero.png";
            break;
        case "Città":
            percorso=tema=== "colore" ? "Img/città/colore.png" : "Img/città/bianco_nero.png";
            break;
        default:
            percorso="";
    }
    document.getElementById("immagine").src=percorso;
}