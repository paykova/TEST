function symmetric(n){
    let num = Number(n[0]);

    for (let i = 1; i <= num; i++) {
        if (IsReversed("" + i)){
            console.log(i);
        }
    }
    function IsReversed(num){
        for (let i = 0; i < num.length; i++) {
         if (num[i] != num[num.length -i- 1]){
             return false;
         }
        }
        return true;
    }
}
//symmetric(['12'])