function recensione(){
    let star=document.getElementById("select").value;
    let feed=document.querySelector('input[name="Feedback"]:checked').value;
    let answer="Valutazione: " + star + "<br>" + "Feedback: " + feed;
    document.getElementById("risposta").innerHTML=answer;
}