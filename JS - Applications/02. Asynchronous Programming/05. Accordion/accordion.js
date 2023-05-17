async function solution() {
  const main = document.getElementById("main");
  const url = `http://localhost:3030/jsonstore/advanced/articles/list`;

  const response = await fetch(url);
  const data = await response.json();

  data.forEach((a) => {
    let divAccordion = document.createElement("div");
    divAccordion.className = "accordion";

    let divHead = document.createElement("div");
    divHead.className = "head";

    let spanElement = document.createElement("span");
    spanElement.textContent = a.title;

    let btnElement = document.createElement("button");
    btnElement.id = a._id;
    btnElement.textContent = "More";
    btnElement.addEventListener("click", toggle);

    let divExtra = document.createElement("div");
    divExtra.className = "extra";

    let pElement = document.createElement("p");

    divHead.appendChild(spanElement);
    divHead.appendChild(btnElement);
    divExtra.appendChild(pElement);
    divAccordion.appendChild(divHead);
    divAccordion.appendChild(divExtra);
    main.appendChild(divAccordion);
  });

  async function toggle(ev) {
    const accordion = ev.target.parentNode.parentNode;

    const p = accordion.children[1].children[0];

    const extra = accordion.children[1];
    const detailsUrl = `http://localhost:3030/jsonstore/advanced/articles/details/${ev.target.id}`;

    const response = await fetch(detailsUrl);
    const data = await response.json();

    p.textContent = data.content;

    const hidden = ev.target.textContent === "More";

    extra.style.display = hidden ? "block" : "none";
    ev.target.textContent = hidden ? "Less" : "More";
  }

  console.log(data);
}

solution();
