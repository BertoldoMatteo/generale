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

function Calcola(){
    let str="";
    let cognome=(document.getElementById("cognome").value).toUpperCase();
    let nome=(document.getElementById("nome").value).toUpperCase();
    let sesso=document.getElementById("sesso").value;
    let data=document.getElementById("DataDiNascita").value;
    let luogo=(document.getElementById("LuogoDiNascita").value).toUpperCase();
    let contr=controllo(cognome, nome, sesso, luogo, data);
    if(contr=="errore"){
        document.getElementById("risposta").innerHTML="errore";
    }
    else if(contr=="corretto"){
        str+=Cognome(cognome);
        str+=Nome(nome);
        str+=Data(data, sesso);
        str+=trovaComune(testo); //do il testo del file alla funzione che troverà il comune Corrispondente;
        str+=verifica(str);
        document.getElementById("risposta").innerHTML="Il cosice fiscale è: "+ str;
    }
    
}

function controllo(c,n,s,l,d){
    let ascii;
    let controllo=c+n+s+l;
    for(let i of controllo){
        let ascii=i.charCodeAt(0);
        if(ascii<65 || ascii>90){
            return "errore";
        }
    }
    if(d.slice(4)<=1900 || d.slice(4)>=2026){
        return "errore";
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
            switch(ascii){
                case "0":
                    ascii=1;
                break;
                case "1":
                    ascii=0;
                break;
                case "2":
                    ascii=5;
                break;
                case "3":
                    ascii=7;
                break;
                case "4":
                    ascii=9;
                break;
                case "5":
                    ascii=13;
                break;
                case "6":
                    ascii=15;
                break;
                case "7":
                    ascii=17;
                break;
                case "8":
                    ascii=19;
                break;
                case "9":
                    ascii=21;
                break;
                case "10":
                    ascii=2;
                break;
                case "11":
                    ascii=4;
                break;
                case "12":
                    ascii=18;
                break;
                case "13":
                    ascii=20;
                break;
                case "14":
                    ascii=11;
                break;
                case "15":
                    ascii=3;
                break;
                case "16":
                    ascii=6;
                break;
                case "17":
                    ascii=8;
                break;
                case "18":
                    ascii=12;
                break;
                case "19":
                    ascii=14;
                break;
                case "20":
                    ascii=16;
                break;
                case "21":
                    ascii=10;
                break;
                case "22":
                    ascii=22;
                break;
                case "23":
                    ascii=25;
                break;
                case "24":
                    ascii=24;
                break;
                case "25":
                    ascii=23;
                break;
            }
        }
    ascii=parseInt(ascii)
    somma+=ascii;
}
    
    somma=somma%26;
    somma+=65;
    str=String.fromCharCode(somma);
    return str;
}