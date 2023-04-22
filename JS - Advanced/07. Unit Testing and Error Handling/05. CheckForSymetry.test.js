const expect = require("chai").expect;
const isSymmetric = require("./05. CheckForSymetry");

describe("Check for Symetry - Regular cases", () => {
  it("Should return true on isSymetric([1,2,1])", () => {
    expect(isSymmetric([1, 2, 1])).to.be.true;
  });

  it("Should return false on isSymetric([1,2,-1])", () => {
    expect(isSymmetric([1, 2, -1])).to.be.false;
  });

  it("should return true on isSymetric([10,20,20,10])", () => {
    expect(isSymmetric([10, 20, 20, 10])).to.be.true;
  });

  it("should return false on isSymetric([10,20,30,10])", () => {
    expect(isSymmetric([10, 20, 30, 10])).to.be.false;
  });

  it('should return true on isSymetric(["pesho", new Date(2016,8,15),false,new Date(2016,8,15), "pesho"])', () => {
    expect(
      isSymmetric([
        "pesho",
        new Date(2016, 8, 15),
        false,
        new Date(2016, 8, 15),
        "pesho",
      ])
    );
  });
});

describe("Check for symetric - edge cases", () => {
  it("should return false on isSymetric([2]", () => {
    expect(isSymmetric([2])).to.be.true;
  });

  it("should return true on isSymetric([])", () => {
    expect(isSymmetric([])).to.be.true;
  });

  it('should return false on isSymetric("hello")', () => {
    expect(isSymmetric("hello")).to.be.false;
  });

  it("should return true on isSymetric([[1,2], [2], [1,2]])", () => {
    expect(isSymmetric([[1, 2], [2], [1, 2]])).to.be.true;
  });
});
