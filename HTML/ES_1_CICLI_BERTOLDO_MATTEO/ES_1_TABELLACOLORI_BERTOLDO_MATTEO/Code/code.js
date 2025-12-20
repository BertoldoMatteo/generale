function tabella(rig , col){
    let r=parseInt(rig);
    let c=parseInt(col);
    console.log(rig);
    console.log(col);
    if(r<=0 || c<=0){
        if(r<=0){
            document.getElementById("num1").value="";
            document.getElementById("num1").focus();
            document.getElementById("sol").value="";
        }else{
            document.getElementById("num2").value="";
            document.getElementById("num2").focus();
            document.getElementById("sol").value="";
        }
    }else{
        let str=colorata(r,c);
        console.log(str);
        document.getElementById("sol").innerHTML=str;
    }
}

function colorata(r,c){
    let st="<caption>Tabella colorata</caption><table>"
        let c1;
        let c2;
        let c3;
        for(let i=1;i<=r;i++){
            st+="<tr>";
            for(let j=1;j<=c;j++){
                c1=Math.round(Math.random()*255);
                c2=Math.round(Math.random()*255);
                c3=Math.round(Math.random()*255);
                st+='<td style="background-color: rgb('+c1+', '+c2+', '+c3+');"></td>';
            }
            st+="</tr>";
        }
        st+="</table>";
        return st;
}