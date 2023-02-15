function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);

   function onClick () {
   let input = JSON.parse(document.querySelector('#inputs textarea').value)
   let bestRestaurant = document.getElementById('bestRestaurant')
   let workerElement = document.getElementById('workers')

   let avgSalary = 0
   let totalSalary = 0
   let output = {}

   for (let line of input) {
      let restaurantInfo = line.split(' - ')
      let restaurantName = restaurantInfo[0]
      let workers = restaurantInfo[1].split(', ')
      for (let worker of workers) {
         let [name, salary] = worker.split(' ')
         
         if(output.hasOwnProperty(restaurantName)){
            output[restaurantName][name] = Number(salary)
         } else {
            output[restaurantName] = {}
         }
      }

      let entries = Object.entries(output);

      for (let entry of entries) {
         let key = entry[0];
         let values = Object.values(entry[1]);

         for (let salary of values) {
            totalSalary += salary;
         }

         avgSalary = totalSalary / values.length;
      }
   }
      
   }
}