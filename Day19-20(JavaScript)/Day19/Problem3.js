function checkEmailId(str){
    if(str.includes('@') && str.includes('.')){
        if((str.indexOf('.') - str.indexOf('@'))>1 ){
        return true;
        }else{
            console.log('Incorrect Email Entry');
        }
    }
    return false;
}

if(checkEmailId('my@.com')){
    console.log(true);
}else{
    console.log(false);
}