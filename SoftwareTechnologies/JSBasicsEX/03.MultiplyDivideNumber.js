function multiplyOrDivide(num){
    let num1 = Number(num[0]);
    let num2 = Number(num[1]);

    if (num2 >= num1){
        let sum = num1 * num2;
        return sum;
    }
    else{
        let sum = num1 / num2;
        return sum;
    }

}