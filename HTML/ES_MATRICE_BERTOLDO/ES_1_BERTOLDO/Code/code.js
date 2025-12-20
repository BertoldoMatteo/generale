var matrice=[];
function Calcola(){
    let A1=parseInt(document.getElementById("A1").value);
    let A2=parseInt(document.getElementById("A2").value);
    let B1=parseInt(document.getElementById("B1").value);
    let B2=parseInt(document.getElementById("B2").value);
    matrice=[
        [A1, B1],
        [A2, B2]
    ]
    let controllo=Controllo(matrice);
    
    if(controllo){
        matrice=Vendite(matrice);
    }
    else{
        document.getElementById("A1").value="";
        document.getElementById("B1").value="";
        document.getElementById("A2").value="";
        document.getElementById("B2").value="";
        return;
    }
    document.getElementById("A1").value=matrice[0][0];
    document.getElementById("B1").value=matrice[0][1];
    document.getElementById("A2").value=matrice[1][0];
    document.getElementById("B2").value=matrice[1][1];
    return;
}

function Controllo(matrice){
    for(let i=0;i<2;i++){
        for(let j=0;j<2;j++){
            if(isNaN(matrice[i][j]) || matrice[i][j]<=0){
                return false;
            }
            else{
                matrice[i][j]=parseInt(matrice[i][j]);
            }
        }
    }
    return true;
}

function Vendite(matrice){
    matrice[0][0]=matrice[0][0]+parseInt((matrice[0][0]/100)*20);
    matrice[0][1]+=parseInt((matrice[0][1]/100)*20);
    matrice[1][0]+=parseInt((matrice[1][0]/100)*5);
    matrice[1][1]+=parseInt((matrice[1][1]/100)*5);
    return matrice;
}