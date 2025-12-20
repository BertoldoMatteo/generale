function abbonamento(){
    let mesi=parseInt(document.getElementById("mesi").value);
    let fascia=document.getElementById("fascia").value;
    let sesso=document.querySelector('input[name="sesso"]:checked').value;
    let costo="";
    
    if(sesso=="M"){
        if(fascia=="F1"){
            costo=10*mesi;
        }else if(fascia=="F2"){
            costo=15*mesi;
        }else{
            costo="errore";
        }
    }else if(sesso=="F"){
        if(fascia=="F1"){
            costo=7*mesi;
        }else if(fascia=="F2"){
            costo=11*mesi;
        }else{
            costo="errore";
        }
    }else{
        costo="errore";
    }
    if(mesi<0){
        costo="valore non accettabile in ";
    }else if(costo<=3){
        costo=costo*1;
    }else  if(mesi<=6){
        costo=costo*85/100;
    }else{
        costo=costo*75/100;
    }
    
    document.getElementById("risposta").innerHTML=costo+"€";
    }