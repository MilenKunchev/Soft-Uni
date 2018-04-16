function storingObjects(arr) {

    let storedInfo = [];
    let js = {};
    for (let i = 0; i < arr.length; i++) {

        let personData = arr[i].split(' -> ');

        let name = personData[0];
        let age = personData[1];
        let grade = personData[2];

        js = {'name': name, 'age': age, 'grade': grade}

        storedInfo.push(js);
    }
    for (let i = 0; i < storedInfo.length; i++) {
        console.log(`Name: ${storedInfo[i].name}`)
        console.log(`Age: ${storedInfo[i].age}`)
        console.log(`Grade: ${storedInfo[i].grade}`)

    }

}

storingObjects(['Pesho -> 13 -> 6.00', 'Ivan -> 12 -> 5.57', 'Toni -> 13 -> 4.90'])