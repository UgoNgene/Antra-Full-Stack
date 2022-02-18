const styles=[
    "James",
    "Brennie"
]
console.log(styles);

//Append Robert
styles.push("Robert");
console.log(styles);

//Replace value in the middle with Calvin(odd lengths)
if(styles.length % 2 !=0){
    styles[Math.floor(styles.length/2)] = "Calvin";
}
console.log(styles);

//Remove first element and show it
styles.shift();
console.log(styles);

styles.unshift("Rose","Regal");
console.log(styles);