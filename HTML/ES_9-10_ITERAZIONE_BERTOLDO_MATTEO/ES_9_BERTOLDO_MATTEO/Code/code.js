function amicali(){
    let num1=parseInt(document.getElementById("num1").value);
    let num2=parseInt(document.getElementById("num2").value);
    let somma1=0;
    let somma2=0;
    let i=1;
    let ris="";

    while(i<num1){
        if(num1%i==0){
            somma1+=i;
            
        }
        i++;
    }
    i=1;
    while(i<num2){
        if(num2%i==0){
            somma2+=i;
        }
        i++;
    }
    ris=(num1==somma2 && num2==somma1)? "I due numeri sono amicali" : "I due numeri non sono amicali";
    document.getElementById("risposta").innerHTML=ris;
}