function verifica(){
    let n1=document.getElementById("char1").value;
    let n2=document.getElementById("char2").value;
    let n3=document.getElementById("char3").value;
    let result;
    if(isNaN(n3)){
        result="Il terzo carattere non è un numero";
    }else{
        let a1=n1.charCodeAt(0);
        console.log(a1);
        let a2=n2.charCodeAt(0);
        console.log(a2);
        console.log(n3);
        let a3=Math.abs(a1-a2);
        if(a3==n3){
            result="Il terzo numero è la differenza tra i due caratteri";
        }else{
            result="Il terzo numero non è la differenza tra i due caratteri";
        }
    }
    document.getElementById("risposta").innerHTML=result;
}