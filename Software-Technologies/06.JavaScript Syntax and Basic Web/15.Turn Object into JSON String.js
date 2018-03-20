function solve(arr) {
    let obj = {};
    for (i = 0; i < arr.length; i++) {

        let tokens = arr[i].split(' -> ');
        let key = tokens[0];
        let value = tokens[1];
        if (key === "age" || key === "grade") {
            value = Number(value);
        }

        obj[key] = value;
    }

    let js = JSON.stringify(obj);
    console.log(js);
}

solve(['name -> Angel', 'surname -> Georgiev', 'age -> 20', 'grade -> 6.00', 'date -> 23/05/1995', 'town -> Sofia']);