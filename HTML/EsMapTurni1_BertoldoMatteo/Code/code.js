
//var rim = false;

var mappa = new Map([
    ["7", ["1", "2", "3"]],
    ["8", ["4", "5", "6"]],
    ["9", ["7", "8", "9"]],
    ["10", ["11", "14"]],
    ["11", ["15"]]
]);

var turno;
var stud;

function Valori() {
    turno = document.querySelector("select").value;
    stud = document.getElementById("stud").value;
}

function Elimina(){
    const elementoDaRimuovere = document.querySelector('#tab');
    
    // Controlla se l'elemento esiste prima di rimuoverlo
    if (elementoDaRimuovere) {
        elementoDaRimuovere.remove(); // Rimuove l'elemento [1, 23, 25]
}
}

function Stampa() {
    Elimina();

    let tab=document.createElement("table");
    tab.id="tab";

    let turni=["7:00 / 8:00","8:00 / 9:00","9:00 / 10:00","9:00 / 10:00","10:00 / 11:00","11:00 / 12:00"]
    let tr = document.createElement("tr");
    let th= document.createElement("th");
    let th1= document.createElement("th");
    th.textContent="TURNO";
    th1.textContent="STUDENTE";
    tr.appendChild(th);
    tr.appendChild(th1);
    tab.appendChild(tr);


    for (let [chiave, valore] of mappa) {
        let tr = document.createElement("tr");
        let td = document.createElement("td");
        td.textContent=turni[chiave-7];
        tr.appendChild(td);
        
        for (let elem of valore) {
            let td = document.createElement("td");
            td.id=elem;
            td.textContent = elem < 10 ? "S0" + elem : "S" + elem;
            tr.appendChild(td);
        }
        tab.appendChild(tr);
    }
    document.body.appendChild(tab);
}

function controlloTurno() {
    if (turno == 0 || turno==null) {
        document.getElementById("risp").innerHTML = "Inserire il turno";
        return false;
    }
    return true;
}

function controlloStud() {
    if (isNaN(stud) || stud < 1) {
        document.getElementById("risp").innerHTML = "Inserire numero valido >0";
        return false;
    }
    return true;
}

function Cerca(rim) {
    Valori();
    let index=-1;
    for (let [chiave, valore] of mappa) {
        index = valore.indexOf(stud);
         
        if (index !== -1) {
            document.getElementById("risp").innerHTML =
                (stud < 10 ? "Lo studente S0" + stud : "Lo studente S" + stud) +
                " è presente nel turno " + chiave;

            break;
        }
    }
    return index;
}


function Verifica() {
    Valori();
    if (controlloStud()) {
        let trovato = Cerca(false);
       
        if (trovato==-1) {
            document.getElementById("risp").innerHTML =
                "Lo studente S" + stud + " non è presente in nessun turno";
        }
    }
}

function aggiungi() {
    Valori();

    if (controlloTurno() && controlloStud()) {
        if (Cerca(false)!=-1) return;

        let tur = mappa.get(turno);
        tur.push(stud);
        Stampa();

        document.getElementById("risp").innerHTML = "Studente aggiunto correttamente";
    }
}

function rimuovi() {
    Valori();
     
    if (controlloStud()) {
        let index = Cerca(true);

        if (index!=-1) {
            document.getElementById("risp").innerHTML =
                (stud < 10 ? "Lo studente S0" + stud : "Lo studente S" + stud) +
                " è stato eliminato";
            for(let valore of mappa.values()){
                if(valore.includes(stud)){
                    valore.splice(index,1);
                }
            }
            Stampa();
        } else {
            document.getElementById("risp").innerHTML =
                "Lo studente non è presente nell' elenco";
        }
    }
}

function ContaTurni() {
    let count = mappa.size;
    document.getElementById("risp").innerHTML = "Sono presenti " + count + " turni";
}

function ContaStudenti() {
    let count = 0;
    for (let valore of mappa.values()) {
        count += valore.length;
    }
    document.getElementById("risp").innerHTML = "Sono presenti " + count + " studenti";
}
