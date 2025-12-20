var matrice=[
    [0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0],
    [0,0,0,0,0,0,0,0],
];

function CreaTabella(){
    let table=document.createElement("table");
    for(let i=0;i<8;i++){
        let tr=document.createElement("tr");
        for(let j=0;j<8;j++){
            let td=document.createElement("td");
            let input=document.createElement("input");
            input.type="button";
            input.onclick=() => Energia(i,j);
            input.value=i+""+j;
            input.id=i+""+j;
            console.log(i+""+j);
            td.appendChild(input);
            tr.appendChild(td);
        }
        table.appendChild(tr);
    }
    form.appendChild(table);
}

function Energia(i,j){
    matrice[i][j]=1;
    console.log(i+""+j);
    let bottone=document.getElementById(i+""+j);
    bottone.style.backgroundColor="rgb(0;256;0)";
}

function Stabilità(){
    let somma=0;
    let somma1=0;
    let risp=document.createElement("p");
    for(let i=0;i<8;i++){
        for(let j=0;j<8;j++){
            somma+=matrice[i][j];
        }
        if(i>0 && somma1!=somma){
            let riga=i+1;
            risp.innerHTML="Non stabile alla riga: "+riga;
            form.appendChild(risp);
            return;
        }
        if(i=0){
            let riga=i+1;
            for(let j=0;j<8;j++){
                somma1+=matrice[riga][j];
            }
            if(somma1!=somma){
                    let riga=i+1;
                    risp.innerHTML="Non stabile alla riga: "+riga;
                    form.appendChild(risp);
                    return; 
            }
        }
        somma1=somma;
        somma=0;
    }
    risp.innerHTML="Stabile";
    form.appendChild(risp);
    return;
}