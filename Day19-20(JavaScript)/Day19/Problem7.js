function validate(str){
    for(var i in str){
    console.log( /[a-z]{1,6}_{0,1}[0-9]{0,4}@hackerrank\.com/.test(str[i]));
    }
}

var emails = ['julia@hackerrank.com','julia_@hackerrank.com','julia_0@hackerrank.com','julia0_@hackerrank.com','julia@gmail.com'];
validate(emails);
