let array1=[];
let array2=[];

function random(){
    const output=document.getElementById("cont");
    for(let i=0;i<100;i++){
        array1[i]=(Math.floor(Math.random()*100))+1;
    }
    for(let i=0;i<10;i++){
        array2[i]=0;
    }
    for(let num of array1){
        let range=Math.floor(num/10);
        console.log(range);
            array2[range]+=1;
        console.log(array2[range]);
        
    }
    let p=document.createElement("p");
    p.id="p";
    output.appendChild(p);
    document.getElementById("p").innerHTML="Distribuzione per ogni 10: ["+array2.join(", ")+"]";
}