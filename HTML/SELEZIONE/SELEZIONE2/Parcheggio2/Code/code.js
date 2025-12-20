function parcheggio(){
    let tempo=parseInt(document.getElementById("tempo").value);
    let mezzo=document.getElementById("mezzo").value;
    let tipo=document.getElementById("tipo").value;
    let tariffa="";
    let costo="";
    if(tempo>=0){
        if(mezzo=="A"){
            tariffa=tipo=="C"? tempo*0.025:tempo*0.015;
        }else{
            tariffa=tipo=="C"? tempo*0.013:tempo*0.010;
        }
        if(tempo<=60){
            costo=tariffa;
        }else if(tempo<=120){
            costo=tariffa*70/100;
        }else{
            costo=tariffa*50/100;
        }
    }
    document.getElementById("risposta").innerHTML="Tariffa base: "+ tariffa +"€<br>Costo: " + costo + "€";
}