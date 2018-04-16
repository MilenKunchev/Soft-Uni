function solve(inputArr) {

    let obj = {};

    for (let i = 0; i < inputArr.length - 1; i++) {

        let tokens = inputArr[i].split(' ');

        let key = tokens[0];
        let value = tokens[1];

        obj[key] = value;
    }

    let keyToPrint = inputArr[inputArr.length - 1];

    if (obj[keyToPrint] == undefined) {
        console.log('None')
    } else {
        console.log(obj[keyToPrint])
    }
}

solve(['3 test', '3 test1', '4 test2', '4 test3', '4 test5', '4']);
solve(['key value', 'key eulav', 'test tset', 'key'])