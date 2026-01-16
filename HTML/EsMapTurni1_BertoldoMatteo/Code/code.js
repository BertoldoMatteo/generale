var studenti = [];
var rim = false;

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

function Stampa() {
    for (let [chiave, valore] of mappa) {
        let tr = document.getElementById("tr" + chiave);

        for (let elem of valore) {
            let td = document.createElement("td");
            td.textContent = elem < 10 ? "S0" + elem : "S" + elem;
            tr.appendChild(td);
        }
    }
}

function controlloTurno() {
    if (turno == 0 || turno === "") {
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

function Cerca() {
    Valori();
    for (let [chiave, valore] of mappa) {
        let index = valore.indexOf(stud);

        if (index !== -1) {

            if (rim) {
                    valore.splice(index, 1);
                    return true;
            }
            document.getElementById("risp").innerHTML =
                (stud < 10 ? "Lo studente S0" + stud : "Lo studente S" + stud) +
                " è presente nel turno " + chiave;

            return true;
        }
    }
    return false;
}


function Verifica() {
    Valori();
    if (controlloStud()) {
        let trovato = Cerca();
        if (!trovato) {
            document.getElementById("risp").innerHTML =
                "Lo studente S" + stud + " non è presente in nessun turno";
        }
    }
}

function aggiungi() {
    Valori();

    if (controlloTurno() && controlloStud()) {
        if (Cerca()) return;

        let tur = mappa.get(turno);
        tur.push(stud);

        let tr = document.getElementById("tr" + turno);
        let td = document.createElement("td");
        td.textContent = stud < 10 ? "S0" + stud : "S" + stud;
        tr.appendChild(td);

        document.getElementById("risp").innerHTML = "Studente aggiunto correttamente";
    }
}

function rimuovi() {
    Valori();

    if (controlloTurno() && controlloStud()) {
        rim = true;
        let trovato = Cerca();
        rim = false;

        if (trovato) {
            document.getElementById("risp").innerHTML =
                (stud < 10 ? "Lo studente S0" + stud : "Lo studente S" + stud) +
                " è stato eliminato";

            Stampa();
        } else {
            document.getElementById("risp").innerHTML =
                "Lo studente non è presente in questo turno";
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
