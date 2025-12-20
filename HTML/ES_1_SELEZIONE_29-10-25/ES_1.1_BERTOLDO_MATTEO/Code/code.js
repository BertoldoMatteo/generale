
function controlla(){
var a=parseInt(document.getElementById("num1").value);
var b=parseInt(document.getElementById("num2").value);
var select=document.getElementById("mySelect").value;
var risposta;

    console.log(a);
    console.log(b);
    console.log(select);
    
switch(select){
    case "0":
        if(b>0){
            risposta="positivo";
        }else if(b<0){
            risposta="negativo";
        }else{
            risposta="nullo";
        }
    break;
    case "1":
        if(a%2==0){
            risposta="pari";
        }else{
            risposta="dispari";
        }
    break;
    case "2":
        risposta=a+b;
    break;
    case "3":
        risposta=Math.abs(a)+Math.abs(b);
    break;
    }
    document.getElementById("output").innerHTML=risposta;
}