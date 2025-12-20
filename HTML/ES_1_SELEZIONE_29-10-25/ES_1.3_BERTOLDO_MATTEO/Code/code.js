function calcola(){
    let red=document.getElementById("reddito").value;
    let tasse;
    const p1=0.1;
    const p2=0.2;
    const p3=0.3;
    if(red<15000){
        tasse=p1*red;
    }else if(red>30000){
        tasse=p3*red;
    }else{
        tasse=p2*red;
    }
    document.getElementById("risposta").innerHTML=tasse;
}