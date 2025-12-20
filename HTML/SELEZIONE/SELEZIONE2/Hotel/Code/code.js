function soggiorno(){
    let giorni=parseInt(document.getElementById("giorni").value);
    let stanza=document.querySelector('input[name="stanza"]:checked').value;
    let stagione=document.querySelector('input[name="stagione"]:checked').value;
    let parcheggio=document.querySelector('input[name="parcheggio"]:checked').value;
    let costo="";
    let verifica=document.getElementById("myCheck");

    if(verifica.checked){
        document.getElementById("risposta").innerHTML="casa";
    }else if(giorni>=0){
        switch (stanza){
            case "B":
                switch (stagione){
                    case "BS":
                        costo=15*giorni;
                    break;
                    case "MS":
                        costo=20*giorni;
                    break;
                    case "AS":
                        costo=25*giorni;
                    break;
                    default:
                        costo="errore";
                }
            break;
            case "M":
                switch (stagione){
                    case "BS":
                        costo=30*giorni;
                    break;
                    case "MS":
                        costo=35*giorni;
                    break;
                    case "AS":
                        costo=40*giorni;
                    break;
                    default:
                        costo="";
                }
            break;
            case "A":
                switch (stagione){
                    case "BS":
                        costo=45*giorni;
                    break;
                    case "MS":
                        costo=50*giorni;
                    break;
                    case "AS":
                        costo=55*giorni;
                    break;
                    default:
                        costo="";
                }
            break;
        }
        if(giorni>=3 && giorni<=7){
            costo=costo*75/100;
        }else{
            costo=costo*65/100;
        }
        if(parcheggio="SI"){
            costo=costo+giorni*5;
        }
        document.getElementById("risposta").innerHTML=costo+"€";
    }
    
}