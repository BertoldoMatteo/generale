var numeri=[];

function Crea(N){
    const form=document.getElementById("f");
    if(isNaN(N) || N<1 || N>1000){
        let p=document.createElement("p");
        p.innerHTML="Valore non valido";
        form.appendChild(p);
        document.getElementById("num").value="";
        document.getElementById("num").focus;
        return;
    }
    else{
        document.getElementById("num").disable=true;
        document.getElementById("b").disable=true;
        N=parseInt(N);
        for(let i=0;i<N;i++){
            let input=document.createElement("input");
            input.type="number";
            input.id="n"+i;
            input.placeholder="Inserisci valore";
            form.appendChild(input);
        }
        let button=document.createElement("input");
        button.type="button";
        button.onclick=() => Calcola(N);
        button.value="Invia valori";
        form.appendChild(button);
    }
}

function Calcola(N){
    const form=document.getElementById("f");
    let v=0;
    let somma=0;
    let str="";
    for(let i=0;i<N;i++){
        v=document.getElementById("n"+i).value;
        if(isNaN(v) || v<-1000 || v>1000){
            let p=document.createElement("p");
            p.innerHTML="Valore: "+v+" non valido";
            form.appendChild(p);
            return;
        }
        else{
            numeri[i]=parseInt(v);
        }
    }
    somma=Somma(numeri);
    str+="La somma dei numeri è: "+somma;
    str+="<br>La media dei numeri è: "+Media(somma,N);
    let p=document.createElement("p");
    p.innerHTML=str;
    form.appendChild(p);
}

function Somma(numeri){
    let somma=0;
    for(let num of numeri){
        somma+=num;
    }
    return somma;
}
function Media(somma,N){
    let media=0;
    media=somma/N;
    return media;
}