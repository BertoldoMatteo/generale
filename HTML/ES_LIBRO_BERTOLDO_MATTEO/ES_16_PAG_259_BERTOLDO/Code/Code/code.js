let array=[];
let arrayp=[];
let arrayd=[];
let count=0;

function error(n){
    if(isNaN(n) || n<1){
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
    let verifica=error(num);
    let str="";
    if(verifica){
        return;
    }
    for(let i=0;i<num;i++){
        array[i]=document.getElementById("n"+i).value;
    }
    for(let num of array){
        if(num%2==0){
            arrayp.push(num);
        }
        else{
            arrayd.push(num);
        }
    }
    const output=document.getElementById("cont");
    let p=document.createElement("p");
    p=document.createTextNode("Numeri pari: ["+arrayp.join(", ")+"]         Numeri dispari:["+arrayd.join(", ")+"]");
    output.appendChild(p);
    
}