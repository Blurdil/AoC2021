import data from './input-day2.mjs';

execute();

function execute(){
    var arr = [];
    let directions = [];
    let depthnumbers = [];

    var arr = data.match(/[a-zA-Z]+|[0-9]+/g);
    for(var i = 0; i < arr.length; i++){
        if(i % 2 == 0){
            directions.push(arr[i]);
        }
        else {
            depthnumbers.push(arr[i]);
        }  
    }

     let result1 = dayTwoPusselOne(directions, depthnumbers);
     let result2 = dayTwoPusselTwo(directions , depthnumbers);

    console.log("Event 1 : " + result1);
    console.log("Event 2 : " + result2);
}

function dayTwoPusselOne(directions, depthnumbers){
    let forward = 0;
    let depth = 0;

    for(var i = 0; i < directions.length; i++){
        switch(directions[i]){
            case "up":
                depth = depth - parseInt(depthnumbers[i])
                break;
            case "down":
                depth = depth + parseInt(depthnumbers[i]);
                break;
            case "forward":
                forward = forward + parseInt(depthnumbers[i]);
                
                break;
        }
    }
    return (forward * depth);
}

function dayTwoPusselTwo(directions, depthnumbers){
    let forward = 0;
    let depth = 0;
    let aim = 0;

    for(var i = 0; i < directions.length; i++){
        switch(directions[i]){
            case "up":
                aim = aim - parseInt(depthnumbers[i])
                break;
            case "down":
                aim = aim + parseInt(depthnumbers[i]);
                break;
            case "forward":
                forward = forward + parseInt(depthnumbers[i]);
                depth = depth + ( parseInt(depthnumbers[i]) * aim);
                break;
        }
    }
    return (forward * depth);
}

