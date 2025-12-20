function Calcolo(){
    let reddito=document.getElementById("reddito").value;
    let imposta;
    imposta= reddito<0 ? "errore inserimento dati"
            :(reddito<=3000) ? "0"
            :(reddito<=1500) ? (reddito-3000)*23/100
            :(reddito<=28000) ? 3450 + (reddito-15000)*27/100
            :(reddito<=55000) ? 6960 + (reddito-28000)*38/100
            :(reddito<=75000) ? 17220 + (reddito-55000)*41/100
            :25420 + (reddito-75000)*43/100;
    document.getElementById("risposta").innerHTML=imposta;
}