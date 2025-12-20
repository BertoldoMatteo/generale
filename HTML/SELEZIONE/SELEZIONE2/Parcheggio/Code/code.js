function parcheggio(){
    let ore=parseInt(document.getElementById("ore").value);
    let minuti=parseInt(document.getElementById("minuti").value);
    let parcheggio=document.querySelector('input[name="parcheggio"]:checked').value;
    let costo="";
    if(ore>=0 && minuti>=0){
        minuti=minuti+(ore*60);
        if(parcheggio=="C"){
            costo=minuti<=45? "Gratis":
            minuti<=240? (minuti/60)*3:
            (((minuti-240)/60)*2)+12;
        }else if(parcheggio=="A"){
            costo=minuti<=45? "Gratis":
            minuti<=240? (minuti/60)*2:
            (((minuti-240)/60)*1)+8;
        }
    }
    document.getElementById("risposta").innerHTML= costo+"€";
}