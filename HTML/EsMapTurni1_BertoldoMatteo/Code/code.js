var studenti=[]

var mappa=new Map(
    ["7", ["S01", "S02", "S03"]],
    ["8", ["S04", "S05", "S06"]],
    ["9", ["S07", "S08", "S09"]],
    ["10", ["S11", "S14"]],
    ["11", ["S15"]]
)

var turno=document.getElementById('turno').value
var stud=document.getElementById('stud').value

function aggiungi(){
    let err=controllo(turno, stud);
    if(err){
        for(let valore of mappa.values()){
            if(valore==stud){
                document.getElementById("risp").innerHTML="Lo studente "+ stud+ " è già presente nel turno "+mappa.get(stud);
                return   
            }
        }
        mappa.set(turno,stud);
        let tr=document.getElementById("tr"+turno)
        let td=document.createElement("td");
        if(stud<10){
           td.textContent="S0"+stud; 
        }
        else{
            td.textContent="S"+stud;
        }
        tr.appendChild(td);
    }
}


function controllo(azione){
    let turno=document.getElementById('turno').value
    let stud=document.getElementById('stud').value
    if(turno==0){
        document.getElementById("risp").innerHTML="Inserire il turno";
        return false
    }
    else if(isNaN(stud) || stud<1){
        document.getElementById("risp").innerHTML="Inserire numero valido >1";
        return false
    }
    return true
}

azione=="aggiungi" ?  aggiungi(turno, stud) :
    azione=="tot-turni" ? TotTurni() :
    azione=="tot-studenti" ? TotStud() :
    azione=="codStudente" ? stud()  :
    rimstud();