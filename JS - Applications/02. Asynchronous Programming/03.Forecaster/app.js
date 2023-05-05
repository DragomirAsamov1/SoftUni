function attachEvents() {
  const submitBtn = document.getElementById("submit");
  submitBtn.addEventListener("click", getWeather);

  async function getWeather() {
    const url = "http://localhost:3030/jsonstore/forecaster/locations";

    const response = await fetch(url);
    const data = await response.json();

    console.log(data);
  }
}
attachEvents();
