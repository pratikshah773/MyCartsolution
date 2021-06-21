
/*document.onload = function () { document.getElementById("loginbutton").innerHTML = "Pratik"; }*/
function login()
{
    console.log("function called");

    

    window.location = "UserAuth/Login";
}


function Logout()
{

    console.log("logout function called");
    window.location = "UserAuth/Logout";

    
}


function Register() {
    console.log("function called");



    window.location = "UserAuth/Register";
}


function addToCart() {confirm("Your product is added to the cart") }





document.getElementsByClassName("BuyNow").onclick = Ajaxcall;

function Ajaxcall() {
    console.log("clicked");
    alert("successfully added to cart");
    var xhr = new XMLHttpRequest();
    xhr.open("Get", "\text.txt", true);
    

    xhr.onload = () => {

        if (xhr.readyState === XMLHttpRequest.DONE) {
            if (xhr.status === 200) {
                console.log(xhr);
                console.log(xhr.response);
            }
        }
        else { console.log("Error occured"); }

    };


    xhr.send();

}

