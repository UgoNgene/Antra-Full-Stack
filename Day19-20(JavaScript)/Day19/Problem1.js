let salaries={
    John: 100,
    Ann: 160,
    Pete: 130
}
var sum = 0;
for(var index in salaries){
    if(salaries.hasOwnProperty(index)){
        sum += parseFloat(salaries[index]);
    }
}
console.log(sum);