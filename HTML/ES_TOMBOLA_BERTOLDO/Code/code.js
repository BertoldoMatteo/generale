// Array
var num90 = [];     // numeri da 0 a 89, corispondenti a quelli del tabellone
var num90c = [];    // numeri del tabellone nel loro ordine casuale

//Matrice
var griglia = [];   // matrice 18×5 per segnare se il numero è stato estratto

// Variabili booleane per verificare assegnazione dei premi in base ai punti nelle righe e cartelle
var ambo = false;
var terna = false;
var quaterna = false;
var cinquina = false;
var tombola = false;

//variabili di conteggio
var count = 0;      // conta i numeri estratti
var punti = 0;      // punti per ambo/terna/quaterna/cinquina/tombola


// Funzione per creare il tabellone
function Inizio() {

    document.getElementById("start").disabled = true;

    const contenitore = document.getElementById("contenitore");
    contenitore.innerHTML = "";

    num90 = creaArray();
    num90c = [];
    griglia = creaMatrice();

    let ind = 0;

    // 6 caselle da 15 numeri (totale 90)
    for (let j = 0; j < 6; j++) {

        const gruppo = document.createElement("div");
        gruppo.classList.add("gruppo");

        for (let i = 0; i < 15; i++) {

            let n = Math.floor(Math.random() * num90.length);
            let numero = num90[n] + 1;

            const cella = document.createElement("div");
            cella.classList.add("cella");
            cella.textContent = numero;

            cella.id = ind;
            num90c[ind] = numero;

            gruppo.appendChild(cella);

            num90.splice(n, 1);
            ind++;
        }

        contenitore.appendChild(gruppo);
    }

    num90 = creaArray();

    document.getElementById("estratto").innerHTML = "";
    document.getElementById("punti").innerHTML = "";
}

// Funzione che crea array da 0 a 89
function creaArray() {
    for (let i = 0; i < 90; i++) {
        num90.push(i);
    }
    return num90;
}

// Funzione che crea matrice che memorizza i numeri estratti
function creaMatrice() {
    for (let i = 0; i < 18; i++) {
        griglia.push([]);
        for (let k = 0; k < 5; k++) {
            griglia[i][k] = false;
        }
    }
    return griglia;
}

// Funzione che viene eseguita ad ogni estrazione del numero
function Estrai() {

    let numEstratto = 0;
    let riga = 0;
    let cella = 0;

    let n = Math.floor(Math.random() * (90 - count));
    let num = num90[n];

    num90.splice(n, 1);

    numEstratto = num90c[num];

    document.getElementById(num).style.backgroundColor = "green";

    riga = Math.floor(num / 5);
    cella = num % 5;

    griglia[riga][cella] = true;

    verifica();

    document.getElementById("estratto").innerHTML = "Numero estratto: " + numEstratto;

    count++;
}

// Funzione che conta i numeri estratti nella riga o casella e verifica ambo, terna, quaterna, cinquina, tombola
function verifica() {

    let h = 0;
    let z = 0;
    let riga = 0;

    if (cinquina) {

        // Controllo per la tombola
        for (let k = 0; k < 6; k++) {
            for (let i = 0; i < 3; i++) {
                for (let j = 0; j < 5; j++) {
                    h = k * 3 + i;
                    if (griglia[h][j] || griglia[h][j] == "vinto") {
                        punti++;
                    }
                }
            }

            if (punti == 15) {
                tombola = true;
                let casella = k + 1;
                document.getElementById("punti").innerHTML = "Tombola nella casella: " + casella;
            }

            punti = 0;
        }

    } else {
        // Controllo ambo/terna/quaterna/cinquina
        for(let i=0; i<18; i++){

            for(let j=0; j<5; j++){

                if(griglia[i][j]){
                    punti++;
                    z=j;
                }

                if(griglia[i][j]=="vinto"){
                    punti=-4;
                }
            }

            if(i%6<=2){
                riga=Math.floor(i/6)*3+(i%6)+1;
            }else{
                riga=Math.floor(i/6)*3+(i%6)-2;
            }

            if(quaterna){

                if (punti==5) {
                    cinquina=true;
                    document.getElementById(i * 5 + z).style.backgroundColor="yellow";
                    document.getElementById("punti").innerHTML="Cinquina in riga "+riga;
                }

            }else if(terna){

                if(punti==4){
                    quaterna=true;
                    griglia[i][z]="vinto";
                    document.getElementById(i*5+z).style.backgroundColor="yellow";
                    document.getElementById("punti").innerHTML="Quaterna in riga "+riga;
                }

            }else if(ambo){

                if(punti==3){
                    terna=true;
                    griglia[i][z]="vinto";
                    document.getElementById(i*5+z).style.backgroundColor="yellow";
                    document.getElementById("punti").innerHTML="Terna in riga "+riga;
                }

            }else if(punti==2){

                ambo=true;
                griglia[i][z]="vinto";
                document.getElementById(i*5+z).style.backgroundColor="yellow";
                document.getElementById("punti").innerHTML="Ambo in riga "+riga;
            }

            punti=0;
            z=0;
        }
    }
}
