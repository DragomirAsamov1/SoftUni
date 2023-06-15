const formElement = document.querySelector("form");
formElement.addEventListener("submit", (e) => {
  let formData = new FormData(e.currentTarget);
  let email = formData.get("email");
  let password = formData.get("password");

  fetch("http://localhost:3030/users/login", {
    method: "POST",
    headers: {
      "content-type": "application/json",
    },
    body: JSON.stringify({
      email,
      password,
    }),
  })
    .then((res) => res.json())
    .then((user) => {
      localStorage.setItem("_id", user._id);
      localStorage.setItem("userName", user.username);
      localStorage.setItem("accessToken", user.accessToken);
    });
});
