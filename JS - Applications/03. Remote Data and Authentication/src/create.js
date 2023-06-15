const formElement = document.querySelector("form");
formElement.addEventListener("submit", (e) => {
  e.preventDefault();
  let formData = new FormData(e.currentTarget);
  let name = formData.get("name");
  let img = formData.get("img");
  let ingredients = formData.get("ingredients").split("\n");
  let steps = formData.get("steps").split("\n");

  let data = {
    name,
    img,
    ingredients,
    steps,
  };

  let accessToken = localStorage.getItem("accessToken");

  fetch("http://localhost:3030/data/recipes", {
    method: "POST",
    headers: {
      "content-type": "applicaiton/json",
      "X-Authorization": accessToken,
    },
    body: JSON.stringify(data),
  })
    .then((res) => res.json())
    .then((data) => {
      location.href = "/";
    });
});
