function populateTable(url){
    const table = document.querySelector("table");
    const head = table.querySelector("thead");
    const body = table.querySelector("tbody");

    head.innerHTML = `<tr></tr>`;
    body.innerHTML = "";
    fetch(url)
    .then(res => res.json()) 
    .then(data =>{
        console.log(data);


        for( var key in data[0]){
            const headerElement = document.createElement("th");
            headerElement.textContent = key.toUpperCase();
            head.querySelector("tr").appendChild(headerElement);
            console.log(key);
        }

        for(var i= 0; i< data.length;i++){
            const rowElement = document.createElement("tr");
            
            for(key in data[i]){
                const cellElement = document.createElement("td");
                cellElement.textContent = data[i][key];
                console.log(data[i][key]);
                
                rowElement.appendChild(cellElement);
            }

            body.appendChild(rowElement);
        }
    })
    .catch(error =>{
        console.log(error);
    });


}

populateTable("https://fakerestapi.azurewebsites.net/api/v1/Users");