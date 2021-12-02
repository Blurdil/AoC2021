import number from './input-day1.js';


 // A = 477
 // B = 488
 // C = 504
 // D = 523
 // E = 549
// < 1996

function numberArray(){

    var arr = [];
    number.split(/(\s+)/).map(s => {
        s = parseInt(s);
        if(!isNaN(s)){
            arr.push(s);
        }
    });
    
    let result1 = pussel1(arr);
    let result2 = threeMeasurment(arr);
    

    var div = document.getElementById("PoD1-1");
    div.innerHTML = result1;
    var div2 = document.getElementById("PoD1-2");
    div2.innerHTML = result2;
}

function pussel1(arr){
    var lastNumber = 0;
    var counter = -1;
    for(let i = 0; i < arr.length; i++){
        if(parseInt(arr[i]) > lastNumber )
            counter++;

        lastNumber = parseInt(arr[i]);
    }
    return counter;
}

function threeMeasurment(arr) {
    let lastNumber = 0;
    var counter = -1;
    for(let i = 0; i < arr.length; i++){
        
        let isInsideArr = (i + 2) < arr.length;
        let threeMeasurment = 0;
        if(isInsideArr){
            let a = parseInt(arr[i]);
            let b = parseInt(arr[i + 1])
            let c = parseInt(arr[i + 2])
            threeMeasurment = a + b + c;
       
            if(threeMeasurment > lastNumber){
                counter++;
            }
       
        }
        lastNumber = threeMeasurment;
    }
    return counter;
}

export default numberArray();