let array=[];
let count=0;

function error(n){
    if(isNaN(n)){
        document.getElementById("num").value="";
        document.getElementById("num").focus;
        return true;
    }
}
function creaForm(num){
    let verifica=error(num);
    if(verifica){
        return;
    }
    document.getElementById("b1").disable=true;
    const output=document.getElementById("cont");
    for(let i=0;i<num;i++){
        let input=document.createElement("input");
        input.id="n"+i;
        input.type="number";
        input.placeholder="Inserisci un numero";
        output.appendChild(input);
        let br=document.createElement("br");
        output.appendChild(br);
    }
    let button=document.createElement("button");
    button.textContent="Clicca";
    button.onclick=() => creaArray(num);
    button.id="b2";
    output.appendChild(button);
}

function creaArray(num){
    document.getElementById("b2").disable=true;
    let verifica=error(num);
    let str="";
    if(verifica){
        return;
    }
    for(let i=0;i<num;i++){
        array[i]=document.getElementById("n"+i).value;
    }

    for(let i=0;i<num;i++){
        document.getElementById("n"+i).disable=true;
    }
    const output=document.getElementById("cont");
    let br1=document.createElement("br");
    output.appendChild(br1);
    let input=document.createElement("input");
    input.id="contr";
    input.type="number";
    input.placeholder="Inserisci numero di controllo";
    output.appendChild(input);
    let br=document.createElement("br");
    output.appendChild(br);
    let button=document.createElement("button");
    button.textContent="Clicca";
    button.onclick=() => controllaArray(num);
    button.id="b3";
    output.appendChild(button);
    output.appendChild(button);
}

function controllaArray(){
    document.getElementById("b3").disable=true;
    let n=document.getElementById("contr").value;
    let str="";
    for(let num of array){
        if(num==n) count++;
    }
    const output=document.getElementById("cont");
    let br=document.createElement("br");
    output.appendChild(br);
    let p=document.createElement("p");
    str+="Il valore è presente "+count+" volte,i numeri erano: ["+array.join(',')+"]"
    p=document.createTextNode(str);
    output.appendChild(p);
}