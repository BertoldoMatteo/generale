var testo="";

function showfile(input){
    let inputfile = input.files[0];
    if(inputfile){
        let reader = new FileReader();

        reader.readAsText(inputfile);   //inputfile è l'oggetto da leggere come testo

        reader.onload = function() {   //al termine del caricamento viene generato l'evento load
            testo=reader.result;   //prop. result di target dell'oggetto "e" mi consente di accedere al contenuto del file
        }
    }
}

function trovaComune(testo){
    let Comune=document.getElementById("LuogoDiNascita").value;
    Comune=Comune.toUpperCase();
    let array= testo.split("\r\n");
    let luogo="Luogo non trovato";
    console.log(array.join(", "));
    for(let i=0;i<array.length;i++){
        if(array[i].includes(Comune) && array[i].slice(0,Comune.length)==Comune){
            luogo=array[i].slice(-4);
        }
        console.log(luogo);
    }
    return luogo;
}


function Calcola(){
    let str="";
    let cognome=(document.getElementById("cognome").value).toUpperCase();
    let nome=(document.getElementById("nome").value).toUpperCase();
    let sesso=document.getElementById("sesso").value;
    let data=document.getElementById("DataDiNascita").value;
    let codLuogo=trovaComune(testo); //do il testo del file alla funzione che troverà il comune Corrispondente;
    let contr=controllo(cognome, nome, sesso, codLuogo);
    if(contr=="errore"){
        document.getElementById("risposta").innerHTML="errore";
    }
    else if(contr=="corretto"){
        str+=Cognome(cognome);
        str+=Nome(nome);
        str+=Data(data, sesso);
        str+=codLuogo;
        str+=verifica(str);
        document.getElementById("risposta").innerHTML="Il cosice fiscale è: "+ str;
    }
    
}

function controllo(c,n,s,l){
    let ascii;
    for(let i of c){
        let ascii=i.charCodeAt(0);
        if(ascii<65 || ascii>90){
            return "errore";
        }
    }
    for(let i of n){
        let ascii=i.charCodeAt(0);
        if(ascii<65 || ascii>90){
            return "errore";
        }
    }
    for(let i of s){
        let ascii=i.charCodeAt(0);
        if(ascii<65 || ascii>90){
            return "errore";
        }
    }
    ascii=parseInt(l.charCodeAt(0));
    if(ascii<65 || ascii>90){
            return "errore";
        }
    for(let i=1;i<=l.lenght;i++){
        ascii=parseInt(l.charCodeAt(i));
        if(ascii<48 || ascii>57){
            return "errore";
        }
    }
    return "corretto";
    
}

function Cognome(cognome){
    let str="";
    var count=0;
    let ascii="";
    for(let i of cognome){
        ascii=i.charCodeAt(0);
        console.log(ascii);
        if(ascii!="65" && ascii !="69" && ascii!="73" && ascii!="79" && ascii!="85" && count<3){
        str+=i;
        count++;
        }
    }
    if(count<3){
        for(let i of cognome){
            ascii=i.charCodeAt(0);
            if((ascii== "65" || ascii =="69" || ascii=="73" || ascii=="79" || ascii=="85")&& count<3){
                str+=i;
                count++;
            }
        }
    }
    if(count<3){
        for(let i=count;i<3;i++) str+="X";
    }
    return str;
}

function Nome(nome){
    let str="";
    var count=0;
    let ascii;
    for(let i of nome){
        ascii=i.charCodeAt(0);
        console.log(ascii);
        if(ascii!="65" && ascii !="69" && ascii!="73" && ascii!="79" && ascii!="85" && count<4){
            count++;
            if(count!=2) str+=i;
            
        }
    }
    if(count<4){
        count=0;
        str="";
        for(let i of nome){
            ascii=i.charCodeAt(0);
            if(ascii!="65" && ascii !="69" && ascii!="73" && ascii!="79" && ascii!="85" && count<4){
                str+=i;
                count++;
            }
        }
    }
    if(count<4){
        for(let i of nome){
            ascii=i.charCodeAt(0);
            if((ascii== "65" || ascii =="69" || ascii=="73" || ascii=="79" || ascii=="85")&& count<3){
                str+=i;
                count++;
            }
        }
    }
    if(count<3){
        for(let i=count;i<=3;i++) str+="X";
    }
    return str;
}

function Data(data, sesso){
    let str="";
    let anno=data.slice(2,4);
    let mese=data.slice(5,7);
    let giorno=parseInt(data.slice(8,10));
    
    switch (mese){
        case "01":
            mese="A";
        break;
        case "02":
            mese="B";
        break;
        case "03":
            mese="C";
        break;
        case "04":
            mese="D";
        break;
        case "05":
            mese="E";
        break;
        case "06":
            mese="H";
        break;
        case "07":
            mese="L";
        break;
        case "08":
            mese="M";
        break;
        case "09":
            mese="P";
        break;
        case "10":
            mese="R";
        break;
        case "11":
            mese="S";
        break;
        case "12":
            mese="T";
        break;
        default:
            mese="errore";
        break;
    }
    if(sesso=="F"){
        giorno+=40;
    }
    else if(giorno<10){
        giorno="0"+giorno;
    }
    str+=""+anno+""+mese+""+giorno;
    return str;
}

function verifica(codice){
    let somma=0;
    codice=codice.toString();
    let ascii=0;
    let str="";
    let count=0;
    for(let num of codice){
        ascii=num.charCodeAt();
        count+=1;
        if(ascii>64 && ascii<91){
            ascii-=65;
        }else{
            ascii-=48;
        }
        ascii=ascii.toString();
        if(count%2==1){
            let cd=[1,0,5,7,9,13,15,17,19,21,2,4,18,20,11,3,6,8,12,14,16,10,22,25,24,23]
            ascii=cd[ascii];
        }
    ascii=parseInt(ascii)
    somma+=ascii;
}
    
    somma=somma%26;
    somma+=65;
    str=String.fromCharCode(somma);
    return str;
}