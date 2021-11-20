let table = document.getElementById("table");
let tableBody = document.getElementById("tbody");
let bookButton = document.getElementsByClassName("button");

let getResources = async () => {
    let response = await fetch("http://localhost:58695/api/Resource/get-all-resources", {
        method: "GET",
        mode: "cors",
        headers: {
            'Content-Type': 'application/json',
            "Access-Control-Allow-Origin": "*"
        }
    });
    let data = await response.json();
    for (i = 0; i < data.length; i++) {
        tableBody.innerHTML += `
        <tr>
          <th scope="row" class="number">${i}</th>
          <td class="name">${data[i].name}</td>
          <td class="name">${data[i].currentQuantity}</td>
          <td><a class='btn btn-warning btn-sm' onclick=getResourceById('${data[i].resourceId}')>Book</a></td>
        </tr>`
    }
};

getResources();

let getResourceById = async (id) => {
    let response = await fetch(`http://localhost:58695/api/Resource/get-resource-by-id` + id, {
        method: "GET",
        mode: "cors",
        headers: {
            'Content-Type': 'application/json',
            "Access-Control-Allow-Origin": "*"
        }
    })
    .then(function(response){
        console.log(response);
        localStorage.setItem("resourceId", id);
        window.location.href = "./Booking.html";
    })
    .catch(function(error){
        console.log(error);
    })
};