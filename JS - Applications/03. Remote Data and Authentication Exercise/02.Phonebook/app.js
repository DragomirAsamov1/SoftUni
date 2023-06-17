const url = "http://localhost:3030/jsonstore/phonebook";
function attachEvents() {
  const loadBtn = document.getElementById("btnLoad");
  const createBtn = document.getElementById("btnCreate");
  const ul = document.getElementById("phonebook");

  const person = document.getElementById("person");
  const phone = document.getElementById("phone");

  loadBtn.addEventListener("click", onCLickLoad);
  createBtn.addEventListener("click", onClickCreate);

  async function onCLickLoad() {
    ul.innerHTML = "";
    const response = await fetch(url);
    const data = await response.json();

    Object.values(data).forEach((x) => {
      const { person, phone, _id } = x;
      const li = document.createElement("li");
      li.textContent = `${person}: ${phone}`;
      li.setAttribute("id", _id);
      ul.appendChild(li);

      const deleteBtn = document.createElement("button");
      deleteBtn.textContent = "Delete";
      deleteBtn.setAttribute("id", "btnDelete");
      deleteBtn.addEventListener("click", onDeleteClick);
      li.appendChild(deleteBtn);
    });
  }

  async function onDeleteClick(ev) {
    const id = ev.target.parentNode.id;
    ev.target.parentNode.remove();

    const deleteResponse = await fetch(url + `/${id}`, {
      method: "DELETE",
    });
  }

  async function onClickCreate() {
    if (person.value !== "" && phone.value !== "") {
      const response = await fetch(url, {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({ person: person.value, phone: phone.value }),
      });

      person.value = "";
      phone.value = "";
    }
  }
}

attachEvents();
