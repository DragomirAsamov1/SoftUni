const baseUrl = "http://localhost:3030/";

window.addEventListener("load", () => {
  fetch(`${baseUrl}data/recipes`)
    .then((res) => res.json())
    .then((recipes) => {
      renderRecipes(Object.values(recipes));
    });

  const main = document.querySelector("main");
  const guestNavigation = document.querySelector("#guest");
  const userNavigation = document.querySelector("#user");
  const logoutButton = document.querySelector("#logoutBtn");

  logoutButton.addEventListener("click", (e) => {
    e.preventDefault();

    localStorage.clear();
    location.reload();
  });
  let username = localStorage.getItem("username");
  if (username) {
    userNavigation.style.display = "block";
  } else {
    guestNavigation.style.display = "block";
  }

  guestNavigation.style.display = "block";
});

function renderRecipes(recipes) {
  const mainElement = document.querySelector("main");

  mainElement.innerHTML = "";

  recipes.forEach((x) => {
    mainElement.appendChild(createRecipe(x));
  });
}

function createRecipe(recipe) {
  let recipeElement = document.createElement("article");
  recipeElement.classList.add("preview");

  recipeElement.addEventListener("click", () => {
    fetch(`${baseUrl}data/recipes/${recipe._id}`)
      .then((res) => res.json())
      .then((details) => {
        const mainElement = document.querySelector("main");
        mainElement.innerHTML = "";
        mainElement.appendChild(renderDetailRecipe(details));
      });
  });
  let h2Element = document.createElement("h2");
  h2Element.textContent = `${recipe.name}`;
  let divTitle = document.createElement("div");
  divTitle.classList.add("title");
  divTitle.appendChild(h2Element);

  let divSmall = document.createElement("div");
  divSmall.classList.add("small");
  let img = document.createElement("img");
  img.src = `${recipe.img}`;
  divSmall.appendChild(img);
  recipeElement.appendChild(divTitle);
  recipeElement.appendChild(divSmall);

  return recipeElement;
}

function renderDetailRecipe(details) {
  let recipeElement = document.createElement("article");

  let h2Element = document.createElement("h2");
  h2Element.textContent = `${details.name}`;
  let img = document.createElement("img");
  img.src = details.img;
  let divThumb = document.createElement("div");
  divThumb.classList.add("thumb");
  divThumb.appendChild(img);

  let ulElement = document.createElement("ul");

  details.ingredients.map((x) => {
    let liElement = document.createElement("li");
    liElement.textContent = x;
    ulElement.appendChild(liElement);
  });

  let h3Element = document.createElement("h3");
  h3Element.textContent = "Ingredients:";
  let divIngredients = document.createElement("div");
  divIngredients.appendChild(h3Element);
  divIngredients.appendChild(ulElement);

  let divBand = document.createElement("div");
  divBand.appendChild(divThumb);
  divBand.appendChild(divIngredients);

  let divDescription = document.createElement("div");
  divDescription.classList.add("description");
  let h3Preparation = document.createElement("h3");
  h3Preparation.textContent = "Preparation:";
  divDescription.appendChild(h3Preparation);

  details.steps.map((x) => {
    let pElement = document.createElement("p");
    pElement.textContent = x;
    divDescription.appendChild(pElement);
  });

  recipeElement.appendChild(h2Element);
  recipeElement.appendChild(divBand);
  recipeElement.appendChild(divDescription);

  return recipeElement;
}
