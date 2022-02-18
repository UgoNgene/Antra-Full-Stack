function truncate(str, maxlength){
    if(str.length >maxlength){
        return str.slice(0, maxlength).concat("...");
    }
    return str;
}
console.log(truncate("Hi everyone!", 20));


