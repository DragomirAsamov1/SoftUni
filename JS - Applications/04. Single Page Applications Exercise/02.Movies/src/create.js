import { homePage } from "./home.js";
import { showView } from "./router.js";

const createSection = document.querySelector("#add-movie");
const form = createSection.querySelector("form");
form.addEventListener("submit", onSubmit);

export function createPage() {
  showView(createSection);
}

async function onSubmit(event) {
  event.preventDefault();
  const formData = new FormData(form);

  const title = formData.get("title");
  const description = formData.get("description");
  const img = formData.get("imageUrl");

  await createMovie(title, description, img);
  form.reset();
  homePage();
}

async function createMovie(title, description, img) {
  const user = JSON.parse(localStorages.getItem("user"));
  await fetch("http://localhost:3030/data/movies", {
    methos: "POST",
    headers: {
      "Content-Type": "application/json",
      "X-Authorization": user.accessToken,
    },
    body: JSON.stringify({ title, description, img }),
  });
}
