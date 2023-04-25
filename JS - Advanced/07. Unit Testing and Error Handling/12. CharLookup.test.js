const expect = require("chai").expect;
const lookupChar = require("./12. CharLookup");

describe("lookupChar regular cases", () => {
  it('should return "a" when we pass "Reneta" and 5 as parameters', function () {
    expect(lookupChar("Reneta", 5)).is.equal("a");
  });

  it("should return undefined when we pass no parameteres", function () {
    expect(lookupChar()).is.equal(undefined);
  });

  it("should return undefined when we pass only string parameter", function () {
    expect(lookupChar("Reneta")).is.equal(undefined);
  });

  it("should return undefined when we pass only integer parameter", function () {
    expect(lookupChar(5)).is.equal(undefined);
  });

  it("should return undefined when we pass floating point number instead of integer", function () {
    expect(lookupChar("Reneta", 5.5)).is.equal(undefined);
  });

  it('should return "Incorrect index" when we pass bigger index than length of string', function () {
    expect(lookupChar("Reneta", 6)).is.equal("Incorrect index");
  });

  it('should return "Incorrect index" when we passed index smaller than 0', function () {
    expect(lookupChar("Reneta", -1)).is.equal("Incorrect index");
  });

  it('should return "a" when we pass "Reneta", 5 and additional unnesesarry parameter', function () {
    expect(lookupChar("Reneta", 5, "somestring")).is.equal("a");
  });

  it("should return undefined on lookupChar(2, 2)", () => {
    expect(lookupChar(2, 2)).to.equal(undefined);
  });

  it('should return undefined on lookupChar("test", "2")', () => {
    expect(lookupChar("test", "2")).to.equal(undefined);
  });
});
