const expect = require("chai").expect;
const isOddOrEven = require("./11. EvenOrOdd");

describe("is odd or even - regular cases", () => {
  it("should return undefined if parameter, we passed is not string", function () {
    expect(isOddOrEven(1)).is.equal(undefined);
  });

  it("should return undefined if we passed no parameters", function () {
    expect(isOddOrEven()).is.equal(undefined);
  });

  it("should return even when we pass string with length of 2", function () {
    expect(isOddOrEven("do")).is.equal("even");
  });

  it("should return odd when we pass string with length of 3", function () {
    expect(isOddOrEven("for")).is.equal("odd");
  });
});
