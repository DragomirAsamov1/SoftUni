const expect = require("chai").expect;
const createCaluclator = require("./07. Add-Subtract");

describe("create calculator - regular cases", function () {
  let calc;

  beforeEach(function () {
    calc = createCaluclator();
  });
  it("should return 0 for get()", function () {
    expect(calc.get()).to.equal(0);
  });

  it("should return 5 after add(2); add(3)", function () {
    calc.add(2);
    calc.add(3);
    expect(calc.get()).to.equal(5);
  });

  it("should return -5 after subtract(3); subtract(2)", function () {
    calc.subtract(3);
    calc.subtract(2);
    expect(calc.get()).to.equal(-5);
  });

  it("should return 4.2 after add(5.3); subtract(1.1);", function () {
    calc.add(5.3);
    calc.subtract(1.1);
    expect(calc.get()).to.equal(5.3 - 1.1);
  });

  it('should return 2 after add(10); subtract("7"); add("-2"); subtract(-1)', function () {
    calc.add(10);
    calc.subtract("7");
    calc.add("-2");
    calc.subtract(-1);
    expect(calc.get()).to.equal(2);
  });

  it("should return NaN for add(string)", function () {
    calc.add("hello");
    expect(calc.get()).to.be.NaN;
  });

  it("should return Nan for subtract(string)", function () {
    calc.subtract("hello");
    expect(calc.get()).to.be.NaN;
  });
});
