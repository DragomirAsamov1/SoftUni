function printDeckOfCards(cards) {
  const faces = [
    "2",
    "3",
    "4",
    "5",
    "6",
    "7",
    "8",
    "9",
    "10",
    "J",
    "Q",
    "K",
    "A",
  ];
  const suits = {
    S: "\u2660",
    H: "\u2665",
    D: "\u2666",
    C: "\u2663",
  };

  let resultArr = [];

  cards.forEach((cardSymbols) => {
    let suit = cardSymbols.slice(-1);
    let face = cardSymbols.substring(0, cardSymbols.length - 1);

    if (faces.includes(face) && suits[suit]) {
      let card = createCard();
      resultArr.push(card);
    } else {
      console.log(`Invalid card: ${cardSymbols}`);
      throw new Error("Error");
    }

    function createCard() {
      let card = {
        face,
        suit: suits[suit],
      };

      return card;
    }
  });

  return resultArr;
}

try {
  let resultArr = printDeckOfCards(["5S", "3D", "QD", "1C"]);
  let resultStr = "";
  resultArr.forEach((x) => (resultStr += x.face + x.suit + " "));
  resultStr.trimEnd();
  console.log(resultStr);
} catch (ex) {}
