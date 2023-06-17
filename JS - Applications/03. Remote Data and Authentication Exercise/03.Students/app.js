async function solve() {
  const url = "http://localhost:3030/jsonstore/collections/students";

  const table = document.querySelector("#results tbody");
  const response = await fetch(url);
  const data = await response.json();

  Object.values(data).forEach((s) => {
    const tr = document.createElement("tr");

    const firstNameCell = tr.insertCell(0);
    firstNameCell.innerText = s.firstName;

    const lastNameCell = tr.insertCell(1);
    lastNameCell.innerText = s.lastName;

    const facultyNumberCell = tr.insertCell(2);
    facultyNumberCell.innerText = s.facultyNumber;

    const gradeCell = tr.insertCell(3);
    gradeCell.innerText = s.grade;

    table.appendChild(tr);
  });

  const firstName = document.getElementsByName("firstName")[0];
  const lastName = document.getElementsByName("lastName")[0];
  const facultyNumber = document.getElementsByName("facultyNumber")[0];
  const grade = document.getElementsByName("grade")[0];

  const submit = document.getElementById("submit");
  submit.addEventListener("click", createStudent);

  async function createStudent(ev) {
    ev.preventDefault();
    if (
      firstName.value !== "" &&
      lastName.value !== "" &&
      facultyNumber.value !== "" &&
      grade !== ""
    ) {
      const response = await fetch(url, {
        method: "POST",
        headers: {
          "content-type": "application/json",
        },
        body: JSON.stringify({
          firstName: firstName.value,
          lastName: lastName.value,
          facultyNumber: facultyNumber.value,
          grade: grade.value,
        }),
      });

      const tr = document.createElement("tr");

      const firstNameCell = tr.insertCell(0);
      firstNameCell.innerText = firstName.value;

      const lastNameCell = tr.insertCell(1);
      lastNameCell.innerText = lastName.value;

      const facultyNumberCell = tr.insertCell(2);
      facultyNumberCell.innerText = facultyNumber.value;

      const gradeCell = tr.insertCell(3);
      gradeCell.innerText = grade.value;

      table.appendChild(tr);

      firstName.value = "";
      lastName.value = "";
      facultyNumber.value = "";
      grade.value = "";
    }
  }
}

solve();
