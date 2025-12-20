let array=[];

function creaForm(){
    const output=document.getElementById("cont");
    let input=document.createElement("input");
    input.id="num";
    input.required=true;
    input.placeholder="Inserisci numero";
    input.type="number";
    output.appendChild(input);
    let button=document.createElement("button");
    button.onclick=() => random(document.getElementById("num").value);
    button.textContent="Clicca!";
    output.appendChild(button);
}



function random(n){
    const output=document.getElementById("cont");
    let count=0;
    for(let i=0;i<100;i++){
        array[i]=(Math.floor(Math.random()*20))+1;
    }
    for(let num of array){
        if(num==n){
            count++;
        }
    }
    let p=document.createElement("p");
    p.id="p";
    output.appendChild(p);
    document.getElementById("p").innerHTML="Il numero "+n+" è presente "+count+" volte";
    
}