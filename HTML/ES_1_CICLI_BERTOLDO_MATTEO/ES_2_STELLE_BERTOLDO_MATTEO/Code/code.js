function funzione(num , arc){
    if(num<0){
        document.getElementById("stella").innerHTML="";
        document.getElementById("num").value="";
        document.getElementById("num").focus;
        document.getElementById("table").innerHTML="Il valore N deve essere compreso tra 1 e 10";
    }else{
        let stella="";
        switch(arc){
            case "0":

            break;
            case "1":
                stella=stella1(num);
            break;
            case "2":
                stella=stella2(num)
            break;
            case "3":
                stella=stella3(num)
            break;
            case "4":
                stella=stella4(num)
            break;
        }
        document.getElementById("stella").innerHTML=stella;
    }
}

function stella1(N){
    let n=parseInt(N);
    let s="";
    s+="<caption>a. La Stella del Quadrato Pieno:</caption><table>";
    let num=0;
    for(let i=1;i<=n;i++){
        s+="<tr>";
        for(let j=1;j<=n;j++){
            s+="<td>*</td>";
        }
        s+="</tr>";
    }
    s+="</table>";
    return s;
}

function stella2(N){
    let n=parseInt(N);
    let s="";
    s+="<caption>b. Il Contorno del Quadrato:</caption><table>";
    let num=0;
    for(let i=1;i<=n;i++){
        s+="<tr>";
        for(let j=1;j<=n;j++){
            if(i==1 || j==1 || j==n|| i==n){
            s+="<td>*</td>";
        }else{
            s+="<td></td>";
        }
        }
        s+="</tr>";
    }
    s+="</table>";
    return s;
}

function stella3(N){
    let n=parseInt(N);
    let s="";
    s+="<caption>c. Il Triangolo del Coraggio:</caption><table>";
    let num=0;
    for(let i=1;i<=n;i++){
        s+="<tr>";
        for(let j=1;j<=i;j++){
            s+="<td>*</td>";
        }
        s+="</tr>";
    }
    s+="</table>";
    return s;
}

function stella4(N){
    let n=parseInt(N);
    let s="";
    s+="<caption>d. La Stella del Labirinto:</caption><table>";
    let num=0;
    for(let i=1;i<=n;i++){
        s+="<tr>";
        for(let j=1;j<=n;j++){
            if(j<=i){
                s+="<td>*</td>"; 
            }else{
                s+="<td>+</td>";
            }
        }
        s+="</tr>";
    }
    s+="</table>";
    return s;
}