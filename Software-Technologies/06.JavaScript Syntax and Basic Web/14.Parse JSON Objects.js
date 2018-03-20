function solve(input) {

    for (let i = 0; i < input.length; i++) {
        let obj = JSON.parse(input[i]);
        console.log(`Name: ${obj.name}`)
        console.log(`Age: ${obj.age}`)
        console.log(`Date: ${obj.date}`)
    }
}

let arr = ['{"name": "Gosho", "age": 10, "date": "19/06/2005"}','{"name": "Tosho", "age": 11, "date": "04/04/2005"}']

solve (arr);
//solve({"name": "Gosho", "age": 10, "date": "19/06/2005"});
//solve({"name": "Tosho", "age": 11, "date": "04/04/2005"});