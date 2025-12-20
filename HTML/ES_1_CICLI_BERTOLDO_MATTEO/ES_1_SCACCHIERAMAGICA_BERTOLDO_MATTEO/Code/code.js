function funzione(num){
    if(num<0 || num>10){
        document.getElementById("table").innerHTML="";
        document.getElementById("num").value="";
        document.getElementById("num").focus;
        document.getElementById("table").innerHTML="Il valore N deve essere compreso tra 1 e 10";
    }else{
        let s=scacchiera(num);
        document.getElementById("table").innerHTML=s;
    }
}

function scacchiera(N){
    let n=parseInt(N)
    let s="";
    let somm=0;
    s+="<caption>La Scacchiera Magica</caption><table>";
    let num=0;
    for(let i=1;i<=n;i++){
        s+="<tr>";
        for(let j=1;j<=n;j++){
            num=i*j;
            s+="<td>"+num+"</td>";
            somm+=num;
        }
        s+="</tr>";
    }
    s+="</table><p>La somma dei numeri della tabella è: "+somm+"</p>";
    return s;
}