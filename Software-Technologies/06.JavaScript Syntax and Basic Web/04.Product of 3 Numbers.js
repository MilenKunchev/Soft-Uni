function productOfThreeNumbers(nums) {

    let countOfNegativeNums = 0;
    let result = 'Negative';
    for (let i = 0; i < nums.length; i++) {

        if (nums[i] == 0) {
            result = 'Positive';
            break;
        }

        if (nums[i] < 0) {
            countOfNegativeNums++;
        }
    }

    if (countOfNegativeNums % 2 ==0){
        result='Positive';
    }
        console.log(result);
}

productOfThreeNumbers(['-3', '3', '5']);
productOfThreeNumbers(['-3', '-3', '5']);
productOfThreeNumbers(['-3', '3', '0']);
productOfThreeNumbers(['0', '0', '0']);