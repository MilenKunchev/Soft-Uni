function solve(inputArr){
    let arrLength = Number(inputArr[0]);
    let arr = new Array(arrLength).fill(0);

    inputArr.shift();

    for(i = 0;i < inputArr.length;i++){

        let tokens = inputArr[i].split(' - ')
        let index = Number(tokens[0]);
        let value = tokens[1];

        arr[index]=value;
    }
    console.log(arr.join('\n'));

}

solve(['5','0 - 3','3 - -1','4 - 2']);
