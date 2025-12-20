let voti=[];
var count=0;
var str="";
function creaArray(voto){
    if(isNaN(voto) || voto<1 || voto>10){
        document.getElementById("risposta").innerHTML="Errore";
        document.getElementById("voto").value="";
        document.getElementById("voto").focus;
    }
    else if(count>=10){
        str=calcolo();
        document.getElementById("risposta").innerHTML="I risultati:<br>"+ str;
    }
    else{
        voti.push(voto);
        console.log(voti.join(", "))
        count++;
        document.getElementById("voto").value="";
        document.getElementById("voto").focus;
    }
}
function calcolo(){
    str+="Media: "+ media()+"<br>";
    str+="Insufficenze: "+insufficenze()+"<br>";
    str+="Voto più alto: "+votoalto()+"<br>";
    str+="Voto più basso: "+votobasso()+"<br>";
    return str;
}
function media(){
    let somma=0;
    let media;
    for(let num of voti){
        somma+=num;
    }
    media=somma/10;
    console.log(media);
    
    return media;
}
function insufficenze(){
    let ins=0;
    for(let num of voti){
        if(num<6) ins++;
    }
    return ins;
}
function votoalto(){
    let n=0;
    for(let num of voti){
        if(num>n) n=num;
    }
    return n;
}
function votobasso(){
    let n=10;
    for(let num of voti){
        if(num<n) n=num;
    }
    return n;
}