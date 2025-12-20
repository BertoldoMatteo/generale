var tent=0;

function funzione(n){
    let tent=0;
    if(n<0){
        document.getElementById("n").focus;
        document.getElementById("n").value="";
        document.getElementById("t").innerHTML="";
    }else{
        str=tabella(n,tent);
        document.getElementById("t").innerHTML=str;
    }
}


function tabella(n){
    num=parseInt(n);
    let str="<table>"
    let random=Math.round(Math.random()*n*n);
    let v=0;
    for (let i=1; i<=n;i++){
        str+="<tr>"
        for(let j=1; j<=n;j++){
            v++;
            str+="<td><input type=button onclick=asteroide("+v+","+n+","+random+") value="+v+" class='celle'></td>"
        }
        str+="</tr>";
    }
    str+="</table>";
    return str;
}

function asteroide(v,n,rand){
    tent++;
    tentativi=parseInt(document.getElementById("tent").value);
    let num=parseInt(n);
    let val=parseInt(v);
    let random=parseInt(rand);
    let risp="";
    let rigaval=1;
    let rigaran=1;
    let colval=(val%n);
    if(colval==0) colval=n;
        let colran=(random%n);
    if(colran==0) colran=n;
    while((val-n)>0){
        val-=n;
        rigaval++;
    }
    val=parseInt(v);
    while((random-n)>0){
        random-=n;
        rigaran++;
    }
    random=parseInt(rand);
    if(tent>=tentativi){
        risp="Hai esaurito i tentativi, la cella era la: riga: "+ rigaran +"colonna: "+colran;
    }
    else{
        risp="Soluzione:<br>"
        if(val==random){
            risp+="Bravo hai colpito l'asteroide";
            tent=0;
        }
        else if(rigaval==rigaran){
            if(colval>colran){
                risp+="Più a sinistra";
            }
            else{
                risp+="Più a destra";
            }
        }
        else if(colval==colran){
            if(rigaval>rigaran){
                risp+="Più a nord";
            }
            else{
                risp+="Più a sud";
            }
        }
        else if(rigaval>rigaran && colval>colran){
            risp+="Più a nord-ovest";
        }
        else if(rigaval>rigaran && colval<colran){
            risp+="Più a nord-est";
        }
        else if(rigaval<rigaran && colval>colran){
            risp+="Più a sud-ovest";
        }
        else{
            risp+="Più a sud-est";
        }
    }
document.getElementById("risposta").innerHTML=risp;
}