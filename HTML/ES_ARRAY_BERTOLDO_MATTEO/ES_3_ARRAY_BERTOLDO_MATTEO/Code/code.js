let frase=[];
function creaArray(parola){
    document.getElementById("frase").value="";
    document.getElementById("frase").focus;
    frase.push(parola);
    console.log(frase.join)
}
function vuoti(){
    for(let num of frase){
        if(num=="" || num==" "){
            frase.pop(num);
        }
    }
    document.getElementById("risposta").innerHTML=frase.join(",");
}