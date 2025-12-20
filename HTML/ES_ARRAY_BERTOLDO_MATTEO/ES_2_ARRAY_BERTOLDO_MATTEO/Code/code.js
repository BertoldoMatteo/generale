let classe=[];
function creaArray(nome){
    document.getElementById("classe").value="";
    document.getElementById("classe").focus;
    classe.push(nome);
}

function creaForm(num){
    const output=document.getElementById("cont");
    for(let i=0;i<num;i++){
        let input=document.createElement("input");
        input.id="nome"+i;
        input.type="text";
        input.placeholder="Inserisci il nome";
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
    let str="";
    for(let i=0;i<num;i++){
        classe[i]=document.getElementById("nome"+i).value;
    }
    const output=document.getElementById("cont");
    let br1=document.createElement("br");
    output.appendChild(br1);
    let input=document.createElement("input");
    input.id="contr";
    input.type="text";
    input.placeholder="Inserisci nome di controllo";
    output.appendChild(input);
    let br=document.createElement("br");
    output.appendChild(br);
    let button=document.createElement("button");
    button.textContent="Clicca";
    button.onclick=() => controlla(document.getElementById("contr").value);
    button.id="b3";
    output.appendChild(button);
    output.appendChild(button);
}



function controlla(name){
    risp=classe.includes(name);
    if(risp){
        const output=document.getElementById("cont");
        let ris=document.createElement("p");
        ris.id="risposta";
        output.appendChild(ris);
        document.getElementById("risposta").innerHTML="L'alunno: "+name+" è presente";
        return;
    }
    document.getElementById("risposta").innerHTML="L'alunno: "+name+" non è presente";
}