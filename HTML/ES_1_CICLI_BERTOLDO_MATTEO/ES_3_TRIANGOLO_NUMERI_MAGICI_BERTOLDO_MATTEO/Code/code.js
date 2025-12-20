function funzione(n){
    let num=parseInt(n);
    if(num<0){
        document.getElementById("num").value="";
        document.getElementById("num").focus;
        document.getElementById("table").innerHTML="Il valore N deve essere compreso tra 1 e 10";
    }else{
        s=Foyd(num);
        document.getElementById("table").innerHTML=s;
    }
}

function Foyd(n){
    console.log(n);
    let s="";
    s+="<caption>Triangolo di Floyd:</caption><table>";
    let c=1;
    for(let i=1;i<=n;i++){
        s+="<tr>";
        for(let j=1;j<=i;j++){
            s+="<td>"+c+"</td><td></td>";
            c++;
        }
        s+="</tr>";
    }
    s+="</table>";
    console.log(s);
    return s;
}