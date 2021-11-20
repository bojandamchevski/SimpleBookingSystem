let dateFrom = document.getElementById("dateFrom");
let dateTo = document.getElementById("dateTo");
let quantity = document.getElementById("quantity");
let button = document.getElementById("button");
let header = document.getElementById("alertMessage");

let booking = async () => {
    let id = localStorage.getItem("resourceId");
    let book = {
        ResourceId: parseInt(id),
        Quantity: parseInt(quantity.value),
        DateFrom: dateFrom.value,
        DateTo: dateTo.value
    }
    let response = await fetch("http://localhost:58695/api/Booking/book-resource", {
        method: "POST",
        mode: "cors",
        headers: {
            'Content-Type': 'application/json',
            "Access-Control-Allow-Origin": "*"
        },
        body: JSON.stringify(book)
    })
    if (response.status == 201) {
        header.innerHTML = "Resource booked";
        let getBookingId = async () => {
            let response = await fetch("http://localhost:58695/api/Booking/get-booking-id", {
                method: "GET",
                mode: "cors",
                headers: {
                    'Content-Type': 'application/json',
                    "Access-Control-Allow-Origin": "*"
                }
            });
            let data = await response.json();
            if(data != null){
                console.log(`EMAIL SENT TO admin@admin.com FOR CREATED BOOKING WITH ID ${data}`);
            }
        };
        
        getBookingId();
    }
    else {
        header.innerHTML = "Can not book resource";
    }
}

button.addEventListener("click", booking);