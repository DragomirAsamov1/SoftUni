const expect = require("chai").expect;
const mathEnforcer = require("./13. MathEnforcer");

describe("mathEnforcer", function () {
  describe("addFive", function () {
    it("should return correct result with a number parameter", function () {
      expect(mathEnforcer.addFive(5)).to.equal(10);
    });

    it("should return correct result with a non-number parameter", function () {
      expect(mathEnforcer.addFive("5")).to.equal(undefined);
    });

    it("should return correct result with a negative-number parameter", function () {
      expect(mathEnforcer.addFive(-20)).to.equal(-15);
    });

    it("should return correct result with a floating point parameter", function () {
      expect(mathEnforcer.addFive(5.1)).closeTo(10.1, 0.1);
    });

    it("should return correct result without parameters", function () {
      expect(mathEnforcer.addFive()).to.equal(undefined);
    });
  });

  describe("subtractTen", function () {
    it("should return correct result with a number parameter", function () {
      expect(mathEnforcer.subtractTen(20)).to.equal(10);
    });

    it("should return correct result with a non-number parameter", function () {
      expect(mathEnforcer.subtractTen("5")).to.equal(undefined);
    });

    it("should return correct result with a negative-number parameter", function () {
      expect(mathEnforcer.subtractTen(-20)).to.equal(-30);
    });

    it("should return correct result with a floating point parameter", function () {
      expect(mathEnforcer.subtractTen(20.1)).closeTo(10.1, 0.1);
    });
    it("should return correct result without parameters", function () {
      expect(mathEnforcer.subtractTen()).to.equal(undefined);
    });
  });

  describe("sum", function () {
    it("should return correct result with a number parameter", function () {
      expect(mathEnforcer.sum(7, 3)).to.equal(10);
    });

    it("should return correct result with a non-number parameter", function () {
      expect(mathEnforcer.sum("5", 5)).to.equal(undefined);
    });

    it("should return correct result with a non-number parameters", function () {
      expect(mathEnforcer.sum("5", "7")).to.equal(undefined);
    });

    it("should return correct result with a negative-number parameter", function () {
      expect(mathEnforcer.sum(-20, 30)).to.equal(10);
    });

    it("should return correct result with a floating point parameter", function () {
      expect(mathEnforcer.sum(20.1, 0.8)).closeTo(20.9, 0.1);
    });
    it("should return correct result without parameters", function () {
      expect(mathEnforcer.sum()).to.equal(undefined);
    });
  });
});
