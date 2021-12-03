import input from './input-day3.mjs';
let _bin = "";
execute();

function execute(){
    let data = [];
    data = input.match(/[0-9]+/g);
    pussel1(data);
    pussel2(data);
}

function pussel1(data){
    //00100
    //11100
    let gammaBit = ""; 
    let epilsonBit = "";
    var indexCounter = 0;
    let arr = [];
    let bits = [];

    data.forEach((e, index) => {
        for(var i = 0; i < e.length; i++){
            arr.push(e[i]);
        }
        arr.forEach((e,i ) => {
            if(bits[i] === undefined){
            bits[i] = new Array();
            }
            bits[i].push(e);       
            
        })

        
        arr = [];
    })
    bits.forEach((e, i) => {
        let zero = 0;
        let one = 0;
        bits[i].filter((v, i) => {
            if(v === "0"){
                
                zero++
            } else {
                one++;
            }
        });
        if(zero > one){
            gammaBit = gammaBit + "0";
            epilsonBit = epilsonBit + "1";
        } else {
            gammaBit = gammaBit + "1";
            epilsonBit = epilsonBit + "0";
        }
        
    })
    
    let gammaDecimal =  binaryToDecimal(gammaBit);
    let epilsonDecimal =  binaryToDecimal(epilsonBit);
    console.log(gammaDecimal);
    console.log(epilsonDecimal);
    let result = gammaDecimal * epilsonDecimal;
    console.log(Math.round(result));
}

function pussel2(data){
    //1001101
    let oneBeginArr = buildArrays(data, 0, 1);
    let zeroBeginArr = buildArrays(data, 0 , 0);

    let oxygenGeneratorRating = "";
    let c02ScrubberRating = "";
    if(oneBeginArr.length > zeroBeginArr.length){
         oxygenGeneratorRating = sortArrays(oneBeginArr, 1 , "o");
         c02ScrubberRating = sortArrays(zeroBeginArr, 1, "c");
    } else {
        oxygenGeneratorRating = sortArrays(zeroBeginArr, 1, "o");
        c02ScrubberRating = sortArrays(oneBeginArr, 1 , "c");
    }
    let oxygenResult = binaryToDecimal(oxygenGeneratorRating);
    let c02Result = binaryToDecimal(c02ScrubberRating);
    console.log(oxygenResult);
    console.log(c02Result);
    console.log(oxygenResult * c02Result);
}

function sortArrays(data, i, type){
    let bin = "";
    if(data.length > 1){
        let startsWithZero = buildArrays(data, i, 0);
        let startsWithOne = buildArrays(data, i, 1);

        i++
        if(type === "o"){
            if(startsWithZero.length > startsWithOne.length){
                sortArrays(startsWithZero, i , type);
            } else if(startsWithOne.length > startsWithZero.length){
                sortArrays(startsWithOne, i , type);
            } else if(startsWithOne.length === startsWithZero.length){
                sortArrays(startsWithOne, i , type);
            }
        } else if(type === "c"){
            if(startsWithZero.length < startsWithOne.length){
                sortArrays(startsWithZero, i , type);
            } else if(startsWithOne.length < startsWithZero.length){
                sortArrays(startsWithOne, i , type);
            } else if(startsWithOne.length === startsWithZero.length){
                sortArrays(startsWithZero, i , type);
            }
        }
    }else {
        _bin = data[0].toString();
        
    }
    return _bin;
}

function buildArrays(data, index, beginWith){
    let arr = [];
    data.filter((e) => {
        if(parseInt(e[index]) === beginWith){
            arr.push(e);
         }
    })
    return arr;
}

function binaryToDecimal(bit){
    let num = 0;
    let dec = 0;
    let i = 0;
    let rem = 0;
    num = parseInt(bit);
    while(num > 0){
        rem = num % 10;
        num = num / 10;
        num = num.toFixed(0);
        dec = dec + rem * Math.pow(2,i);
        
        i++;
    }
    return dec;
}