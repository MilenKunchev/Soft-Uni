function solve(commands) {
    let arr = [];
    for (i = 0; i < commands.length; i++) {

        let command = commands[i].split(' ')[0];
        let numElement = commands[i].split(' ')[1];

        if (command == 'add') {

            arr.push(numElement);
        }

        if (command == 'remove') {

            //delete arr[numElement];
            arr.splice(numElement, 1)
        }
    }
    console.log(arr.join('\n'));
}

solve(['add 3', 'add 5', 'remove 1', 'add 2']);