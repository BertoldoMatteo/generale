var numeri=[];

function Invio(num){ // funzione per prendere in input i numeri e verificarne la validità
    document.getElementById("num").value="";
    document.getElementById("num").focus();
    num=parseInt(num);
    if(isNaN(num)){//berifico che sia un numero
        document.getElementById("risp").innerHTML="valore non valido";
    }
    else{
        numeri.push(num);
        document.getElementById("array").innerHTML=numeri.join(", ");
    }
}

function Calcolo(){ // funzione per calcolare i risultati, avendo i numeri
    let str="";
    document.getElementById("invia").disabled=true;
    document.getElementById("num").disabled=true;
    str+="La somma dei numeri pari è "+SommaP()+"<br>"; // funzione per calcolare somma numeri pari
    str+="Il prodotto dei numeri in posizione dispari è "+ProdD();// funzione per calcolare prodotto dei numeri in posizione dispari
    document.getElementById("risp").innerHTML=str;
}

function SommaP(){ // somma pari
    let somma=0;
    for(let num of numeri){
        if(num%2==0){// verifico se è pari
            somma+=num;
        }
    }
    return somma;
}

function ProdD(){ // prodotto pos dispari
    let prod=1;
    for(let i=1;i<numeri.length;i+=2){// moltiplico solo 1 ogni 2 numeri
        prod*=numeri[i]
    }
    return prod
}