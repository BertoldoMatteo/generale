function funzione(p,n){
    let num=parseInt(n);
    let str=p.toString();
    if(isNaN(num)){
        document.getElementById("num").focus;
        document.getElementById("num").value="";
        document.getElementById("risp").innerHTML="Il codice deve avere un valore numerico";
    }else{
        s=cifrario(num,str);
        document.getElementById("risp").innerHTML=s;
    }
}

function cifrario(n,p){
    let chiave=parseInt(n);
    let str=p.toString();
    let lung=str.length;
    let ascii=0;
    let char="";
    let s="parola cittografata<br>";
    for(let i=0;i<lung;i++){
        console.log(str);
        
        ascii=str.charCodeAt(i);
        ascii+=chiave;
        while(ascii>255){
            ascii-=255;
        }
        console.log(ascii);
        char=String.fromCharCode(ascii);
        s+=""+char; 
    }
    return s;
}
