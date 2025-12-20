var kms=prompt("Inserire i chilometri percorsi:", "");
var cod=prompt("Inserire il codice tariffa (0=Nord, 1=Centro,2=Sud ):","");
   while(kms<0){
        kms=prompt("Errore,inserire nuovamente i chilometri percorsi:", "");
    }
    while(cod<0 || cod>2){
        cod=prompt("Errore,inserire nuovamente il codice tariffa:","");
    }
    var costo;
    var km=parseInt(kms);
    if(cod=0){
        costo=km*0.150;
    }else if (cod=1) {
        costo=km*0.125;
    } else {
        costo=km*0.1;
    }
    if(km<=100) costo=costo+km*0.01;
    else costo=costo+1+(km-100)*0.005;
window.onload=function(){
    document.getElementById("risposta").innerHTML=costo
}
