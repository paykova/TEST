function sum(str){

    let nums = str[0].split(' ').map(Number);

    let a = (nums[0]);
    let b = (nums[1]);
    let c = (nums[2]);

    if (a + b === c) {
        if (a <= b){
            console.log("" + a + " + " + b + " = " + c);
        }
        else{
            console.log("" + b + " + " + a + " = " + c);
        }
    }
    else if (a + c === b){
        if(a<=c){
            console.log("" + a + " + " + c + " = " + b);
        }
        else{
            console.log("" + c + " + " + a + " = " + b);
        }
    }
    else if (b + c === a){
        if (b<=c){
            console.log("" + b + " + " + c + " = " + a);
        }
        else{
            console.log("" + c + " + " + b + " = " + a);
        }
    }
    else {
        console.log('No');
    }
}

sum (['-5', '-3', '-2'])