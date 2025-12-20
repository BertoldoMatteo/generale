var array=[
[0,0,0],
[0,0,0],
[0,0,0]
];
var turno=true;
function Gioco(n){
    let riga=Math.floor(n/3);
    let colonna=n%3;
    let str="";
    let vintor=false;
    let vintoc=false;
    let vintod=false;
    if(turno){
        array[riga][colonna]=1;
        document.getElementById(n).disabled=true;
        document.getElementById(n).value="X";
        turno=false;
        document.getElementById("turno").innerHTML="Turno della O";
    }
    else{
        array[riga][colonna]=2;
        document.getElementById(n).disabled=true;
        document.getElementById(n).value="O";
        turno=true;
        document.getElementById("turno").innerHTML="Turno della X";
    }
    console.log(array.join(", "));
    vintor=VerificaRiga();
    vintoc=VerificaColonna();
    vintod=VerificaDiagonale();
    if(vintor || vintoc || vintod){
        for (let i = 0; i <= 8; i++) {
            document.getElementById(i).disabled = true;
        }
        if(turno){
            str="Ha vinto giocatore O";
        }
        else{
            str="Ha vinto giocatore X";
        }
        document.getElementById("risp").innerHTML=str;
    }
}

function VerificaRiga(){;
    let num=0;
    vinto=false;
    for(let i=0;i<3;i++){
        console.log(array[i][0]);
        console.log(array[i][1]);
        console.log(array[i][2]);
        if(array[i][0]==array[i][1] && array[i][1]==array[i][2] && array[i][0]!==0){
            for(let j=0;j<3;j++){
                num=i*3+j;
                document.getElementById(num).style.backgroundColor="rgb(72, 255, 81)";
            }
            return true;
        }
    }
    return false;
}

function VerificaColonna(){
    let num=0;
    vinto=false;
    for(let i=0;i<3;i++){
        console.log(array[0][i]);
        console.log(array[1][i]);
        console.log(array[2][i]);
        if(array[0][i]==array[1][i] && array[1][i]==array[2][i] && array[0][i]!== 0){
            for(let j=0;j<3;j++){
                num=j*3+i;
                document.getElementById(num).style.backgroundColor="rgb(72, 255, 81)";
            }
            return true;
        }
    }
    return false;
}

function VerificaDiagonale(){
    let num=0;
    vinto=false;
        if(array[0][0]==array[1][1] && array[1][1]==array[2][2] && array[0][0]!== 0){
            for(let j=0;j<3;j++){
                document.getElementById(num).style.backgroundColor="rgb(72, 255, 81)";
                num+=4;
            }
            return true;
        }
        else if(array[0][2]==array[1][1] && array[1][1]==array[2][0] && array[0][2]!== 0){
            num=2;
            for(let j=0;j<3;j++){
                document.getElementById(num).style.backgroundColor="rgb(72, 255, 81)";
                num+=2;
            }
            return true;
        }
    return false;
}