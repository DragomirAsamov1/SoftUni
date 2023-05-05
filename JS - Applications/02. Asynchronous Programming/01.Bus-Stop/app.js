async function getInfo() {
  const stopNameElement = document.getElementById("stopName");
  const timeTableElement = document.getElementById("buses");
  const stopId = document.getElementById("stopId").value;
  console.log(stopId);

  const url = `http://localhost:3030/jsonstore/bus/businfo/${stopId}`;

  try {
    timeTableElement.replaceChildren();
    const res = await fetch(url);
    if (res.status !== 200) {
      throw new Error("Stop ID not found!");
    }

    const data = await res.json();
    Object.entries(data.buses).forEach((b) => {
      const liElement = document.createElement("li");
      liElement.textContent = `Bus ${b[0]} arrives in ${b[1]} minutes`;
      timeTableElement.appendChild(liElement);
    });

    stopNameElement.textContent = data.name;
  } catch (error) {
    stopNameElement.textContent = "Error";
  }
}
