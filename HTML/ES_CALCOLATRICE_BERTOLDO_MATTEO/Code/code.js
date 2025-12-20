let numero1 = 0;
let n1=0;
let numero2 = 0;
let n2=0;
let risultato;
let primonumero=true;
let concatena=false;
let som=false;
let diff=false;
let molt=false;
let div=false;
let rest=false;
let pot=false;
let rad=false;
let canc=false;
let storico="{";

function cifra1(){
    if(primonumero) numero1=numero1*10+1; 
    else numero2=numero2*10+1;
    storico=storico+"1";
    document.getElementById("stor").innerHTML=storico;
}
function cifra2(){
    if(primonumero) numero1=numero1*10+2;
    else numero2=numero2*10+2;
    storico=storico+"2";
    document.getElementById("stor").innerHTML=storico;
}
function cifra3(){
    if(primonumero) numero1=numero1*10+3;
    else numero2=numero2*10+3;
    storico=storico+"3";
    document.getElementById("stor").innerHTML=storico;
}
function cifra4(){
    if(primonumero) numero1=numero1*10+4;
    else numero2=numero2*10+4;
    storico=storico+"4";
    document.getElementById("stor").innerHTML=storico;
}
function cifra5(){
    if(primonumero) numero1=numero1*10+5;
    else numero2=numero2*10+5;
    storico=storico+"5";
    document.getElementById("stor").innerHTML=storico;
}
function cifra6(){
    if(primonumero) numero1=numero1*10+6;
    else numero2=numero2*10+6;
    storico=storico+"6";
    document.getElementById("stor").innerHTML=storico;
}
function cifra7(){
    if(primonumero) numero1=numero1*10+7;
    else numero2=numero2*10+7;
    storico=storico+"7";
    document.getElementById("stor").innerHTML=storico;
}
function cifra8(){
    if(primonumero) numero1=numero1*10+8;
    else numero2=numero2*10+8;
    storico=storico+"8";
    document.getElementById("stor").innerHTML=storico;
}
function cifra9(){
    if(primonumero) numero1=numero1*10+9;
    else numero2=numero2*10+9; 
    storico=storico+"9";
    document.getElementById("stor").innerHTML=storico;
}
function cifra0(){
    if(primonumero) numero1=numero1*10+0;
    else numero2=numero2*10+0;
    storico=storico+"0";
    document.getElementById("stor").innerHTML=storico;
}
function somma(){
    som=true;
    if(primonumero){
        n1=numero1;
    }else if(concatena){
        n1=risultato;
    }
    primonumero=false;
    storico=storico+"+";
    document.getElementById("stor").innerHTML=storico;
}
function differenza(){
    diff=true;
    if(primonumero){
        n1=numero1;
    }else if(concatena){
        n1=risultato;
    }
    primonumero=false;
    storico=storico+"-";
    document.getElementById("stor").innerHTML=storico;
}
function moltiplicazione(){
    molt=true;
    if(primonumero){
        n1=numero1;
    }else if(concatena){
        n1=risultato;
    }
    primonumero=false;
    storico=storico+"*";
    document.getElementById("stor").innerHTML=storico;
}
function divisione(){
    div=true;
    if(primonumero){
        n1=numero1;
    }else if(concatena){
        n1=risultato;
    }
    primonumero=false;
    storico=storico+"/";
    document.getElementById("stor").innerHTML=storico;
}
function resto(){
    rest=true;
    if(primonumero){
        n1=numero1;
    }else if(concatena){
        n1=risultato;
    }
    primonumero=false;
    storico=storico+"%";
    document.getElementById("stor").innerHTML=storico;
}
function potenza(){
    pot=true;
    if(primonumero){
        n1=numero1;
    }else if(concatena){
        n1=risultato;
    }
    primonumero=false;
    storico=storico+"^";
    document.getElementById("stor").innerHTML=storico;
}
function radice(){
    rad=true;
    storico=storico+"√";
    n1=numero1;
    document.getElementById("stor").innerHTML=storico;
    primonumero=false;
}
function cancella(){
    numero1=0;
    numero2=0;
    n1=0;
    n2=0;
    risultato=0;
    document.getElementById("risposta").innerHTML=risultato;
    storico=storico+"(canc)}<br>{";
    document.getElementById("stor").innerHTML=storico;
    primonumero=true;
}
function uguale(){
    n2=numero2;
    if(som==true){
        risultato=n1+n2;
        
    }else if(diff==true){
        risultato=n1-n2;  
    }else if(molt==true){
        risultato=n1*n2;
    }else if(div==true){
        if(n2==0){
            risultato="impossibile";
        }else{
            risultato=n1/n2; 
        }
    }else if(rest==true){
        risultato=n1%n2;
    }else if(pot==true){
        risultato=n1**n2;  
    }else if(rad==true){
        if(concatena){
            n1=risultato;
        }
        
        risultato=Math.sqrt(n1);
    }else{
        if(concatena){
            risultato=risultato;
        }else{
            risultato=numero1;
        }
        
    }
    concatena=true;
    som=false;
    diff=false;
    molt=false;
    div=false;
    rest=false;
    pot=false;
    rad=false;
    numero1=0;
    numero2=0;
    n1=0;
    n2=0;
    document.getElementById("risposta").innerHTML=risultato;
    let sr=String(risultato);
    storico=storico+"="+sr+"} <br> {"+sr;
    document.getElementById("stor").innerHTML=storico;
}