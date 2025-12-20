function terna(){
    let min=parseInt(document.getElementById("min").value);
    let max=parseInt(document.getElementById("max").value);
    let risp="";
    let a=min;
    let b=a+1;
    let c=b+1;
    let i=0;

    for(a=min;a<b;a++){
        for(b=a+1;b<c;b++){
            for(c=b+1;c=max;c++){
                if(a*a+b*b==c*c){
                    risp=risp + "TERNA: <br> a = "+a+"<br> b = "+b+"<br> c = "+c+"<br>";
                    document.getElementById("risposta").innerHTML=risp;
                    i++;
                }
            }
        }
    }
    document.getElementById("risposta").innerHTML=risp+"<br>Le terne sono : "+i;
}