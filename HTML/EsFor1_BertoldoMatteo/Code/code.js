var numeri=[];
function Invio(num){
    document.getElementById("num").value="";
    num=parseInt(num);
    if(isNaN(num)){
        document.getElementById("risp").innerHTML="valore non valido";
    }
    else{
        numeri.push(num);
    }
}

function Calcolo(){
    let str="";
    document.getElementById("invia").disabled=true;
    document.getElementById("num").disabled=true;
    document.getElementById("array").innerHTML=numeri.join(", ");
    str+="La somma dei numeri pari è "+SommaP()+"<br>";
    str+="Il prodotto dei numeri in posizione dispari è "+ProdD();
    document.getElementById("risp").innerHTML=str;
}

function SommaP(){
    let somma=0;
    for(let num of numeri){
        if(num%2==0){
            somma+=num;
        }
    }
    return somma;
}

function ProdD(){
    let prod=1;
    for(let i=1;i<=numeri.length;i+=2){
        prod*=numeri[i]
    }
    return prod
}