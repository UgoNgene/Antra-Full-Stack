function validateCards(cardNum, bannedPrefixes){
    var object = {};
    var jsonArray =[];

    object.card = cardNum; 
    object.isValid = true;
    object.isAllowed = true;

    for(var i =0; i<bannedPrefixes.length;i++){
        if(bannedPrefixes[i] == cardNum.substr(0,bannedPrefixes[i].length)){
            object.isAllowed = false;
            break;
        }
    }

    if(!isNaN(cardNum)){
        var lastNum = cardNum.charAt(cardNum.length-1);
        var chars = cardNum.slice(0,-1).split('');
        var sum = 0;
        for(var i in chars){
            sum = sum + (chars[i]*2);
        }
        if(sum%10 != lastNum){
            object.isValid = false;
        }
    }else{
        object.isAllowed = false;
        object.isValid = false;
    }
    
    jsonArray.push(object);
    console.log(jsonArray);
}

var cardsToValidate = "6724843711060148";
var bannedPrefixes = ["11","3434","67453","9"];

validateCards(cardsToValidate,bannedPrefixes);
