function multiplyDivideNumber(arr){
    let firstNum = Number(arr[0]);
    let secondNum = Number(arr[1]);
    let result = 0;

    if(firstNum <= secondNum){
        result = firstNum * secondNum;
    }else{
        result = firstNum / secondNum;
    }
    console.log(result);
}

multiplyDivideNumber(['13','13'])
//multiplyDivideNumber(['144','12'])