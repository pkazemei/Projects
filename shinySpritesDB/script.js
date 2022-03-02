var nameSpot = document.getElementById("name");
var input = document.getElementById("input");
var random = document.getElementById("random")
var image = document.getElementById("image");
var imageS = document.getElementById("imageS");
var defaultText = document.getElementById("defaultText");
var shinyText = document.getElementById("shinyText")

// Search for pokemon
async function fetchPokemon() {
    
    //Use API
    var response = await fetch("https://pokeapi.co/api/v2/pokemon/" + input.value);
    
    if(response.ok )
    {
        // Convert to json
    	var data = await response.json();
        console.log(data);

	    //Default image
	    image.src = data.sprites.front_default;
        defaultText.innerText = "Default";

	    //Shiny image
	    imageS.src = data.sprites.front_shiny;
        shinyText.innerText = "Shiny";

	    //Change text to pokemon name
	    nameSpot.innerText = data.name;
	    image.alt = data.name;
    }
    else{
            nameSpot.innerText = "Pokemon not found, try again."
            image.alt = ""
            imageS.src = ""
            image.src = ""
            defaultText.innerText =""
            shinyText.innerText = ""
    }

}

// Find random pokemon
async function fetchRandomPokemon(max){

    // Use API
    var response = await fetch("https://pokeapi.co/api/v2/pokemon?limit=1200");
    var data = await response.json();
    console.log(data.results);

    // Generate a random number
    function getRandomInt(max) {
        return Math.floor(Math.random() * max);

    }

// Setting up a random pokemon object
var randomIndex=getRandomInt(data.results.length);
console.log('random index of pokemon', data.results[randomIndex]);
var randomPokemonObj =  data.results[randomIndex];

// Changing input.value to a random pokemon name
input.value=randomPokemonObj.name;

// Searching for pokemon using input.value
fetchPokemon(input.value);
}